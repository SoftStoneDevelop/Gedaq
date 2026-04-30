

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
    Id = 7,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(9127889261422392684L),
new System.Numerics.BigInteger(9034086190651196544L),
new System.Numerics.BigInteger(4191213803433088461L),
new System.Numerics.BigInteger(3984342831563844198L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(957836160674881794L),
new System.Numerics.BigInteger(1604247921499214117L),
new System.Numerics.BigInteger(3929486027119226090L),
new System.Numerics.BigInteger(7896805995767173710L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 2,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(432440148109365639L),
new System.Numerics.BigInteger(1177017135732286026L),
new System.Numerics.BigInteger(8627916768132609979L),
new System.Numerics.BigInteger(6203936932149161816L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 20,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4892997177709546249L),
new System.Numerics.BigInteger(9216360313140582169L),
new System.Numerics.BigInteger(4337272463259799660L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7442932691166483809L),
new System.Numerics.BigInteger(6119772813105228961L),
new System.Numerics.BigInteger(9056879006069337214L),
new System.Numerics.BigInteger(513582125873437824L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 8,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4233088331020289250L),
new System.Numerics.BigInteger(8480553296616488371L),
new System.Numerics.BigInteger(3865020250136255044L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 37,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4421589641141084206L),
new System.Numerics.BigInteger(5353555087800071095L),
new System.Numerics.BigInteger(7794699699754660173L),
new System.Numerics.BigInteger(6675227563502691485L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 38,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(211940483195759744L),
new System.Numerics.BigInteger(2160181194900311999L),
new System.Numerics.BigInteger(5435839925259307861L),
new System.Numerics.BigInteger(2893494244279857324L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3500778162881533984L),
new System.Numerics.BigInteger(2996331829016327670L),
new System.Numerics.BigInteger(6942320583738206125L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4222438851122840675L),
new System.Numerics.BigInteger(6643014298197611921L),
new System.Numerics.BigInteger(2152384329215614157L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4191168119806568180L),
new System.Numerics.BigInteger(1727575004587350819L),
new System.Numerics.BigInteger(2576666720816231522L),
new System.Numerics.BigInteger(921868324374345642L),
},
},
            new BigIntegernumericArray1M
{
    Id = 45,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5673146264677301717L),
new System.Numerics.BigInteger(6471824249018649401L),
new System.Numerics.BigInteger(1010977506538242963L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5282861800262784296L),
new System.Numerics.BigInteger(6126456161757585313L),
new System.Numerics.BigInteger(1201170975583356800L),
},
},
            new BigIntegernumericArray1M
{
    Id = 52,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8677638555144901255L),
new System.Numerics.BigInteger(3027897855955262760L),
new System.Numerics.BigInteger(3152471210350162425L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 17,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4344244653955591899L),
new System.Numerics.BigInteger(283936894641008709L),
new System.Numerics.BigInteger(2063647011536132621L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6758726036860212393L),
new System.Numerics.BigInteger(3404591678606115535L),
new System.Numerics.BigInteger(277563016820020725L),
},
},
            new BigIntegernumericArray1M
{
    Id = 56,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(71242845922390846L),
new System.Numerics.BigInteger(8950031908099237785L),
new System.Numerics.BigInteger(9080231040549663709L),
new System.Numerics.BigInteger(449878651630725456L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8436880761070010735L),
new System.Numerics.BigInteger(7309296454158834903L),
new System.Numerics.BigInteger(81662758442489339L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 22,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7990145271121009084L),
new System.Numerics.BigInteger(1378702835991712799L),
new System.Numerics.BigInteger(490038067343072629L),
new System.Numerics.BigInteger(4746397544421588059L),
},
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6731477726204006337L),
new System.Numerics.BigInteger(3848591261903493398L),
new System.Numerics.BigInteger(5450689796279264726L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 69,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7940418973270064048L),
new System.Numerics.BigInteger(9186132226089329497L),
new System.Numerics.BigInteger(2658381026030993600L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2222101434240606380L),
new System.Numerics.BigInteger(4112559547957377977L),
new System.Numerics.BigInteger(261124576082568293L),
},
},
            new BigIntegernumericArray1M
{
    Id = 75,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(173775948716778398L),
new System.Numerics.BigInteger(8316351620983157684L),
new System.Numerics.BigInteger(3767470403966181455L),
new System.Numerics.BigInteger(81925587790736398L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 25,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6554524300954494078L),
new System.Numerics.BigInteger(9014442700082179492L),
new System.Numerics.BigInteger(5711122070639708014L),
new System.Numerics.BigInteger(183741049987257654L),
},
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3361813478713197992L),
new System.Numerics.BigInteger(5221060013424789527L),
new System.Numerics.BigInteger(407432318868023378L),
new System.Numerics.BigInteger(8409872856517158413L),
},
},
            new BigIntegernumericArray1M
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5986344865062083416L),
new System.Numerics.BigInteger(358129541820927036L),
new System.Numerics.BigInteger(3362248189643983115L),
new System.Numerics.BigInteger(998417299714906311L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 81,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8470146722349528495L),
new System.Numerics.BigInteger(6531780329047144715L),
new System.Numerics.BigInteger(2558465646134152938L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6766375405047461509L),
new System.Numerics.BigInteger(8613324273723143011L),
new System.Numerics.BigInteger(8561623144581735916L),
new System.Numerics.BigInteger(6848024088470654630L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 87,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6128613648663728811L),
new System.Numerics.BigInteger(3379967948403268623L),
new System.Numerics.BigInteger(6442794955446652192L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7374907343054122126L),
new System.Numerics.BigInteger(4537151077772237644L),
new System.Numerics.BigInteger(5518487349740183619L),
},
},
            new BigIntegernumericArray1M
{
    Id = 88,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4222694612622272475L),
new System.Numerics.BigInteger(6280051617999500406L),
new System.Numerics.BigInteger(670348038541430364L),
new System.Numerics.BigInteger(5959081039808845516L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7889412961859414997L),
new System.Numerics.BigInteger(8680455554944894093L),
new System.Numerics.BigInteger(7483435086504979290L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 97,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1514346426777981755L),
new System.Numerics.BigInteger(5023006427178491830L),
new System.Numerics.BigInteger(6680427053615209551L),
new System.Numerics.BigInteger(2184594454139131170L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 106,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3796218799278548487L),
new System.Numerics.BigInteger(3969195561628089257L),
new System.Numerics.BigInteger(4469386849821605201L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4779223856797932071L),
new System.Numerics.BigInteger(1472331819073051350L),
new System.Numerics.BigInteger(8494591307831710304L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6693251328529272982L),
new System.Numerics.BigInteger(7782099205216246320L),
new System.Numerics.BigInteger(72935537590596016L),
new System.Numerics.BigInteger(3217708866573872365L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 111,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2219415531018406878L),
new System.Numerics.BigInteger(1735112788858393200L),
new System.Numerics.BigInteger(2848548665952869938L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3906274326398629227L),
new System.Numerics.BigInteger(6236920038713949739L),
new System.Numerics.BigInteger(7320771757784432730L),
new System.Numerics.BigInteger(1161674223517147587L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2275869396691594820L),
new System.Numerics.BigInteger(1985885005617569713L),
new System.Numerics.BigInteger(5516614190155807346L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 125,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4461231406139468914L),
new System.Numerics.BigInteger(1176373338969766157L),
new System.Numerics.BigInteger(4482057499375308338L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1013149692653620869L),
new System.Numerics.BigInteger(3661665292875826460L),
new System.Numerics.BigInteger(348267071646799221L),
},
},
            new BigIntegernumericArray1M
{
    Id = 130,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4134272812733813606L),
new System.Numerics.BigInteger(5840864219983958165L),
new System.Numerics.BigInteger(8947352949608709185L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 42,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7830262024912674514L),
new System.Numerics.BigInteger(2708419024964673765L),
new System.Numerics.BigInteger(8991639098502036082L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 139,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7167663536304619122L),
new System.Numerics.BigInteger(2993533398232377153L),
new System.Numerics.BigInteger(7855100348582227402L),
new System.Numerics.BigInteger(6163677027958790530L),
},
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 148,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6925065595592752914L),
new System.Numerics.BigInteger(1329477100395977931L),
new System.Numerics.BigInteger(4438887920089077214L),
new System.Numerics.BigInteger(7398594524436916671L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 47,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(272653469604696928L),
new System.Numerics.BigInteger(3330722966783593923L),
new System.Numerics.BigInteger(5661973887663802479L),
new System.Numerics.BigInteger(5155212690416555565L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8550477203827662635L),
new System.Numerics.BigInteger(4927966354319648261L),
new System.Numerics.BigInteger(6030154586713534888L),
new System.Numerics.BigInteger(1470868068366565610L),
},
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2148315821521040444L),
new System.Numerics.BigInteger(4944440836732123346L),
new System.Numerics.BigInteger(545208649900301298L),
new System.Numerics.BigInteger(2028396594211353646L),
},
},
            new BigIntegernumericArray1M
{
    Id = 151,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7387682765050231210L),
new System.Numerics.BigInteger(640762815662370368L),
new System.Numerics.BigInteger(7598696407654663462L),
new System.Numerics.BigInteger(2128563353227888592L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8795851864910374815L),
new System.Numerics.BigInteger(1153245238431855674L),
new System.Numerics.BigInteger(360624217552938702L),
new System.Numerics.BigInteger(1933490990174808436L),
},
},
            new BigIntegernumericArray1M
{
    Id = 152,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(738390234924934281L),
new System.Numerics.BigInteger(1040632210016417706L),
new System.Numerics.BigInteger(3693887188977939676L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 54,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2150148134467493798L),
new System.Numerics.BigInteger(2624775354694059021L),
new System.Numerics.BigInteger(3585290749238686407L),
new System.Numerics.BigInteger(6760692049743646055L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1652207446746236410L),
new System.Numerics.BigInteger(8677944864389992727L),
new System.Numerics.BigInteger(4767262119569476662L),
new System.Numerics.BigInteger(3937118238226908569L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8695476436617551044L),
new System.Numerics.BigInteger(5194535279240917800L),
new System.Numerics.BigInteger(7306028002791494378L),
},
},
            new BigIntegernumericArray1M
{
    Id = 157,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8704514608631152349L),
new System.Numerics.BigInteger(2523121630115610933L),
new System.Numerics.BigInteger(8807164015396229809L),
new System.Numerics.BigInteger(2667592159880556521L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 63,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4323417055843709500L),
new System.Numerics.BigInteger(359148021215907233L),
new System.Numerics.BigInteger(939893159949076240L),
new System.Numerics.BigInteger(4162407236971299193L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 160,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4323891660377553266L),
new System.Numerics.BigInteger(982971375974056858L),
new System.Numerics.BigInteger(3180372825317199334L),
new System.Numerics.BigInteger(6643329707572810280L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8875344529044827742L),
new System.Numerics.BigInteger(7514030449003731398L),
new System.Numerics.BigInteger(2802784539854694287L),
new System.Numerics.BigInteger(3145957030805061042L),
},
},
            new BigIntegernumericArray1M
{
    Id = 166,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(677093324342259381L),
new System.Numerics.BigInteger(1591471301602744422L),
new System.Numerics.BigInteger(2878835893752978060L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 71,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8676889685150428174L),
new System.Numerics.BigInteger(6538732515636464534L),
new System.Numerics.BigInteger(4962768738145525021L),
new System.Numerics.BigInteger(7241281415805672167L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7341104468051036626L),
new System.Numerics.BigInteger(6370345436832487687L),
new System.Numerics.BigInteger(3610229834297762204L),
new System.Numerics.BigInteger(6810602947629446327L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 168,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1923677524314645803L),
new System.Numerics.BigInteger(7322520435892435911L),
new System.Numerics.BigInteger(4000406533845677096L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7236639263739961815L),
new System.Numerics.BigInteger(5409953038055697539L),
new System.Numerics.BigInteger(5445273513453187971L),
},
},
            new BigIntegernumericArray1M
{
    Id = 171,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8246405352510767720L),
new System.Numerics.BigInteger(6174648747227373012L),
new System.Numerics.BigInteger(4423784556785337234L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(606916149236325307L),
new System.Numerics.BigInteger(5765116910155362614L),
new System.Numerics.BigInteger(7390149215580811053L),
},
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1781655765402938625L),
new System.Numerics.BigInteger(249893173885836351L),
new System.Numerics.BigInteger(97151184595509726L),
new System.Numerics.BigInteger(1331529576314883476L),
},
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 175,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1424470660828412711L),
new System.Numerics.BigInteger(5253784543452868298L),
new System.Numerics.BigInteger(197221172381748705L),
new System.Numerics.BigInteger(653751980318516755L),
},
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7727607050459503963L),
new System.Numerics.BigInteger(1494740980175254275L),
new System.Numerics.BigInteger(3687255989619473031L),
new System.Numerics.BigInteger(116150295191078560L),
},
},
            new BigIntegernumericArray1M
{
    Id = 180,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1184520715873210102L),
new System.Numerics.BigInteger(5981797191895088552L),
new System.Numerics.BigInteger(8524955427320733932L),
new System.Numerics.BigInteger(5382772161511777416L),
},
    ModelInner = new BigIntegernumericArray1MI
{
    Id = 77,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6816511766509466586L),
new System.Numerics.BigInteger(6027420822046305593L),
new System.Numerics.BigInteger(6037020293732476328L),
new System.Numerics.BigInteger(4288223774123708277L),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericArray1M
{
    Id = 187,
    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7657376496941757364L),
new System.Numerics.BigInteger(6271255713733537645L),
new System.Numerics.BigInteger(2421014215561328280L),
new System.Numerics.BigInteger(8039806943976104029L),
},
    ModelInner = null,
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

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 166;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 20;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[3], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[4], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[30],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
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
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 125;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 148, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 87, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 175, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 130, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        FlatBigIntegernumericArray1M.AssertModel(models[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[17],_testData[34], false);
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
                await ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 157, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 130, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatBigIntegernumericArray1M.AssertModel(models[0],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[1],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[2],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[3],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[4],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[5],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[6],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[7],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[8],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(models[9],_testData[34], false);
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
                 ((IBigIntegerArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 118, query1, 157, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatBigIntegernumericArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 106, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IBigIntegerArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 157, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericArray1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericArray1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericArray1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericArray1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericArray1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericArray1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericArray1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericArray1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericArray1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericArray1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericArray1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericArray1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericArray1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericArray1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericArray1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericArray1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericArray1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericArray1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericArray1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericArray1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericArray1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericArray1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericArray1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericArray1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericArray1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericArray1M.AssertModel(models[25],_testData[34], false);
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
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
BigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[30], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[31], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[32], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[33], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
BigIntegernumericArray1M.AssertModel(models[0],_testData[8], false);BigIntegernumericArray1M.AssertModel(models[1],_testData[9], false);BigIntegernumericArray1M.AssertModel(models[2],_testData[10], false);BigIntegernumericArray1M.AssertModel(models[3],_testData[11], false);BigIntegernumericArray1M.AssertModel(models[4],_testData[12], false);BigIntegernumericArray1M.AssertModel(models[5],_testData[13], false);BigIntegernumericArray1M.AssertModel(models[6],_testData[14], false);BigIntegernumericArray1M.AssertModel(models[7],_testData[15], false);BigIntegernumericArray1M.AssertModel(models[8],_testData[16], false);BigIntegernumericArray1M.AssertModel(models[9],_testData[17], false);BigIntegernumericArray1M.AssertModel(models[10],_testData[18], false);BigIntegernumericArray1M.AssertModel(models[11],_testData[19], false);BigIntegernumericArray1M.AssertModel(models[12],_testData[20], false);BigIntegernumericArray1M.AssertModel(models[13],_testData[21], false);BigIntegernumericArray1M.AssertModel(models[14],_testData[22], false);BigIntegernumericArray1M.AssertModel(models[15],_testData[23], false);BigIntegernumericArray1M.AssertModel(models[16],_testData[24], false);BigIntegernumericArray1M.AssertModel(models[17],_testData[25], false);BigIntegernumericArray1M.AssertModel(models[18],_testData[26], false);BigIntegernumericArray1M.AssertModel(models[19],_testData[27], false);BigIntegernumericArray1M.AssertModel(models[20],_testData[28], false);BigIntegernumericArray1M.AssertModel(models[21],_testData[29], false);BigIntegernumericArray1M.AssertModel(models[22],_testData[30], false);BigIntegernumericArray1M.AssertModel(models[23],_testData[31], false);BigIntegernumericArray1M.AssertModel(models[24],_testData[32], false);BigIntegernumericArray1M.AssertModel(models[25],_testData[33], false);BigIntegernumericArray1M.AssertModel(models[26],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((IBigIntegerArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IBigIntegerArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<BigIntegernumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IBigIntegerArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
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
                var models = await ((IBigIntegerArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericarray1mi
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
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MI), typeof(BigIntegernumericArray1MI)],
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                await ((IBigIntegerArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MI>();
                var models2 = new List<BigIntegernumericArray1MI>();
                ((IBigIntegerArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
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
                var models = await ((IBigIntegerArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA), typeof(BigIntegernumericArray1MIWA)],
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                await ((IBigIntegerArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericArray1MIWA>();
                var models2 = new List<BigIntegernumericArray1MIWA>();
                ((IBigIntegerArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericArray1MIWA)],
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

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IBigIntegerArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

