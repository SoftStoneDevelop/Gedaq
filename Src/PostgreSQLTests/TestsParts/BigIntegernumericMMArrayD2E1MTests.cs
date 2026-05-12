

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
    internal partial interface IBigIntegerMArraynumericMMArrayD2
    {
    }
    
    internal partial class BigIntegerMArraynumericMMArrayD2 : IBigIntegerMArraynumericMMArrayD2
    {


#region TestData

        private readonly BigIntegernumericMMArrayD2E1M[] _testData = new BigIntegernumericMMArrayD2E1M[]
        {
            new BigIntegernumericMMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6708265187203220481L), new System.Numerics.BigInteger(7624241463101012345L), }, { new System.Numerics.BigInteger(471080965944065717L), new System.Numerics.BigInteger(1811062854008407423L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6419357497462997347L), new System.Numerics.BigInteger(1356944542459770318L), }, { new System.Numerics.BigInteger(8679755487320574831L), new System.Numerics.BigInteger(1673006986128297426L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1484511207640421167L), new System.Numerics.BigInteger(415285452543433881L), }, { new System.Numerics.BigInteger(4394435395520622583L), new System.Numerics.BigInteger(343939562655165555L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9031774649265423239L), new System.Numerics.BigInteger(2765493022948317777L), }, { new System.Numerics.BigInteger(2865651909492603189L), new System.Numerics.BigInteger(6538204521921313011L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4782508392174518508L), new System.Numerics.BigInteger(8712514821005383761L), }, { new System.Numerics.BigInteger(6085772897241472434L), new System.Numerics.BigInteger(6958397750848925702L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4962597784631457973L), new System.Numerics.BigInteger(3209904680365639066L), }, { new System.Numerics.BigInteger(3008753677133009162L), new System.Numerics.BigInteger(1251242090962038220L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 16,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2048319954348697154L), new System.Numerics.BigInteger(1499767653191384794L), }, { new System.Numerics.BigInteger(7277323495748851157L), new System.Numerics.BigInteger(5122487439437531178L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4517568579289215629L), new System.Numerics.BigInteger(1385975268345081937L), }, { new System.Numerics.BigInteger(8578371161973541289L), new System.Numerics.BigInteger(1564366486662254277L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1024727416947675697L), new System.Numerics.BigInteger(6956623966423087546L), }, { new System.Numerics.BigInteger(4043266585979112029L), new System.Numerics.BigInteger(5361426957480550946L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3818084607021960712L), new System.Numerics.BigInteger(3200669226264388108L), }, { new System.Numerics.BigInteger(5621977456760396917L), new System.Numerics.BigInteger(3989788563181970911L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6448384149712681846L), new System.Numerics.BigInteger(4780138290882552448L), }, { new System.Numerics.BigInteger(1816137496349357143L), new System.Numerics.BigInteger(3381291433651627832L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7594635140636523688L), new System.Numerics.BigInteger(4481011762911518747L), }, { new System.Numerics.BigInteger(7923213299586436621L), new System.Numerics.BigInteger(7724333205011983913L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5891538183485466702L), new System.Numerics.BigInteger(3768373894201299639L), }, { new System.Numerics.BigInteger(5914818244175823672L), new System.Numerics.BigInteger(2748898323457463651L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5384520715662370361L), new System.Numerics.BigInteger(4331088862657314940L), }, { new System.Numerics.BigInteger(4228980502339863797L), new System.Numerics.BigInteger(344597980972351117L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2377235668774139406L), new System.Numerics.BigInteger(471322632589656937L), }, { new System.Numerics.BigInteger(1970341626665366521L), new System.Numerics.BigInteger(5793798975773758950L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3912876936746163533L), new System.Numerics.BigInteger(6587501559867003319L), }, { new System.Numerics.BigInteger(454121695162672461L), new System.Numerics.BigInteger(7596871740359854261L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6490580696211404190L), new System.Numerics.BigInteger(3604687324247904363L), }, { new System.Numerics.BigInteger(4623031389128136011L), new System.Numerics.BigInteger(8373665738764536187L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3925812530056661301L), new System.Numerics.BigInteger(2765943057822107703L), }, { new System.Numerics.BigInteger(9157313601529885410L), new System.Numerics.BigInteger(3913487098541381987L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4586408304060411526L), new System.Numerics.BigInteger(6714969978462315451L), }, { new System.Numerics.BigInteger(4756670169353281660L), new System.Numerics.BigInteger(1539752775210601060L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3605101009769010311L), new System.Numerics.BigInteger(2444217032802467336L), }, { new System.Numerics.BigInteger(7294702567064534546L), new System.Numerics.BigInteger(6691548349223044070L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(60273317017756562L), new System.Numerics.BigInteger(5326777849539485836L), }, { new System.Numerics.BigInteger(4515397658124760391L), new System.Numerics.BigInteger(6074387077258515598L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(281173002609399564L), new System.Numerics.BigInteger(1612685952172229755L), }, { new System.Numerics.BigInteger(2775846041089669555L), new System.Numerics.BigInteger(5745997377331791153L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7499680664174012948L), new System.Numerics.BigInteger(7782610549530315883L), }, { new System.Numerics.BigInteger(3626523878195588509L), new System.Numerics.BigInteger(4566764194667047550L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2997139411495247777L), new System.Numerics.BigInteger(7265911333130543872L), }, { new System.Numerics.BigInteger(4158377407433954982L), new System.Numerics.BigInteger(509954434877050752L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3160984725966620408L), new System.Numerics.BigInteger(3488840570623109113L), }, { new System.Numerics.BigInteger(3048746612068681160L), new System.Numerics.BigInteger(7815148368336291702L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 62,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7705366544717433070L), new System.Numerics.BigInteger(2120523039700206023L), }, { new System.Numerics.BigInteger(1752409898009158861L), new System.Numerics.BigInteger(8916907511548583677L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2980126616154629025L), new System.Numerics.BigInteger(6836712106772917988L), }, { new System.Numerics.BigInteger(705787008752422316L), new System.Numerics.BigInteger(2607563171171380291L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7261576308230351999L), new System.Numerics.BigInteger(1433502730926742159L), }, { new System.Numerics.BigInteger(2313790999542097168L), new System.Numerics.BigInteger(6754250235844390280L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2150174107351371856L), new System.Numerics.BigInteger(7798352190221510849L), }, { new System.Numerics.BigInteger(8137788598635291144L), new System.Numerics.BigInteger(2563829798856406685L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5377324003462821991L), new System.Numerics.BigInteger(7211864084409448080L), }, { new System.Numerics.BigInteger(7930261946951961990L), new System.Numerics.BigInteger(4893147400779283979L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(705530583078055624L), new System.Numerics.BigInteger(6797035315435321282L), }, { new System.Numerics.BigInteger(1892361454664941962L), new System.Numerics.BigInteger(1932136925433002309L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4206559078072081408L), new System.Numerics.BigInteger(6682345333577699769L), }, { new System.Numerics.BigInteger(6246286529075728791L), new System.Numerics.BigInteger(4849912143525397485L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2665492940109955738L), new System.Numerics.BigInteger(4290893256138786723L), }, { new System.Numerics.BigInteger(1740612696663770460L), new System.Numerics.BigInteger(7479047269573660169L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1937966123760700428L), new System.Numerics.BigInteger(3442509421566001881L), }, { new System.Numerics.BigInteger(4684674260705779403L), new System.Numerics.BigInteger(1325150745876725266L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(869501286726969227L), new System.Numerics.BigInteger(2630564436770848456L), }, { new System.Numerics.BigInteger(7810358825810298816L), new System.Numerics.BigInteger(6960399290155796932L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5497528209974198703L), new System.Numerics.BigInteger(9175554128176800779L), }, { new System.Numerics.BigInteger(7430327102166762819L), new System.Numerics.BigInteger(3060516693553250357L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2115298395168745688L), new System.Numerics.BigInteger(6004787932851325959L), }, { new System.Numerics.BigInteger(9155518476081251744L), new System.Numerics.BigInteger(1879451832463112055L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7322879617390267877L), new System.Numerics.BigInteger(7640910493247585831L), }, { new System.Numerics.BigInteger(8111870122751106306L), new System.Numerics.BigInteger(374284727470483430L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6112765533358933361L), new System.Numerics.BigInteger(1333706259354217085L), }, { new System.Numerics.BigInteger(7965751628118579035L), new System.Numerics.BigInteger(7333867690093302366L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2053719255985897813L), new System.Numerics.BigInteger(259457079235627419L), }, { new System.Numerics.BigInteger(3538419876159009928L), new System.Numerics.BigInteger(492710001114838876L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9070902028915643834L), new System.Numerics.BigInteger(2439275384467690443L), }, { new System.Numerics.BigInteger(7037655499275608099L), new System.Numerics.BigInteger(2025490471786497395L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5652788018935828413L), new System.Numerics.BigInteger(879023813665520141L), }, { new System.Numerics.BigInteger(6514893957177102585L), new System.Numerics.BigInteger(2432077279965980199L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4936559712085140675L), new System.Numerics.BigInteger(3378582919316802491L), }, { new System.Numerics.BigInteger(225626726655245962L), new System.Numerics.BigInteger(4206086993682940456L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5999526576648204532L), new System.Numerics.BigInteger(2302883506885763240L), }, { new System.Numerics.BigInteger(6433671647151062686L), new System.Numerics.BigInteger(8613069717437575465L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5059836617817957189L), new System.Numerics.BigInteger(3702922576646142055L), }, { new System.Numerics.BigInteger(1484672279237626064L), new System.Numerics.BigInteger(771018532681240473L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5164239860639865041L), new System.Numerics.BigInteger(1307835783009209795L), }, { new System.Numerics.BigInteger(3455718364565108095L), new System.Numerics.BigInteger(5002994983939151847L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1723382763264141644L), new System.Numerics.BigInteger(1691292383966985900L), }, { new System.Numerics.BigInteger(6070108063610855554L), new System.Numerics.BigInteger(7214082175090708175L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3731741501985498567L), new System.Numerics.BigInteger(6166871913407651013L), }, { new System.Numerics.BigInteger(6294037923490885425L), new System.Numerics.BigInteger(8864128236081871803L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5968318608235011800L), new System.Numerics.BigInteger(2097926146102367793L), }, { new System.Numerics.BigInteger(6569521528954870425L), new System.Numerics.BigInteger(2308414276662446168L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7366878060429886278L), new System.Numerics.BigInteger(3433538112136170821L), }, { new System.Numerics.BigInteger(2088504157892152852L), new System.Numerics.BigInteger(1643269113330890398L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7485505172485552817L), new System.Numerics.BigInteger(4807651523022892069L), }, { new System.Numerics.BigInteger(1043619971745848211L), new System.Numerics.BigInteger(6244377435985791209L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2021196372263543075L), new System.Numerics.BigInteger(3863831782493347888L), }, { new System.Numerics.BigInteger(5563155486629724817L), new System.Numerics.BigInteger(744103096737213379L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4089811663354334625L), new System.Numerics.BigInteger(4949085147168146288L), }, { new System.Numerics.BigInteger(299710626005433449L), new System.Numerics.BigInteger(2385170484940110810L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2217171186018919722L), new System.Numerics.BigInteger(1018704007370085561L), }, { new System.Numerics.BigInteger(8751743653350708208L), new System.Numerics.BigInteger(8494787770861136847L), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7898469019024082620L), new System.Numerics.BigInteger(5368676093030086135L), }, { new System.Numerics.BigInteger(184935302892944699L), new System.Numerics.BigInteger(7737789331460344623L), }, },
    ModelInner = null,
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4907025422847936580L), new System.Numerics.BigInteger(291981203258137085L), }, { new System.Numerics.BigInteger(4469778369229217900L), new System.Numerics.BigInteger(8836797223794925291L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1570688765152642585L), new System.Numerics.BigInteger(5732878787521569834L), }, { new System.Numerics.BigInteger(6450979620224443021L), new System.Numerics.BigInteger(6294942329617623735L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5438923188871734403L), new System.Numerics.BigInteger(5653932440076128158L), }, { new System.Numerics.BigInteger(8351871489007181995L), new System.Numerics.BigInteger(7050264420506696353L), }, },
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2852702336180720754L), new System.Numerics.BigInteger(2163622106095852480L), }, { new System.Numerics.BigInteger(5143744451865301372L), new System.Numerics.BigInteger(8700587732841122798L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 139,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3897550153981257733L), new System.Numerics.BigInteger(5314624782817123840L), }, { new System.Numerics.BigInteger(729309386931871923L), new System.Numerics.BigInteger(6771754219372391416L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(3228308059193029346L), new System.Numerics.BigInteger(8758269648928547989L), }, { new System.Numerics.BigInteger(4261091070952114782L), new System.Numerics.BigInteger(5821547445187576043L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5127579540796713792L), new System.Numerics.BigInteger(4733959355206343319L), }, { new System.Numerics.BigInteger(7252235618648412623L), new System.Numerics.BigInteger(3108605125744962684L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(6470839406742032689L), new System.Numerics.BigInteger(1331487827448409241L), }, { new System.Numerics.BigInteger(8858957294887236213L), new System.Numerics.BigInteger(713450735096668885L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(5849122584324100568L), new System.Numerics.BigInteger(1708413839091680429L), }, { new System.Numerics.BigInteger(5166559757753358579L), new System.Numerics.BigInteger(7376548603941118895L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2070383322936584767L), new System.Numerics.BigInteger(4691864764755583400L), }, { new System.Numerics.BigInteger(1908168971274582124L), new System.Numerics.BigInteger(1625500530884114291L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(234475771931037874L), new System.Numerics.BigInteger(8875804118958659426L), }, { new System.Numerics.BigInteger(8677692537082992248L), new System.Numerics.BigInteger(934586004697963876L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(9187451604500234821L), new System.Numerics.BigInteger(1713503692065213940L), }, { new System.Numerics.BigInteger(6153829258252004443L), new System.Numerics.BigInteger(1704142645431924125L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2789751007296841437L), new System.Numerics.BigInteger(1355036093582788253L), }, { new System.Numerics.BigInteger(2110040267511119673L), new System.Numerics.BigInteger(1980955785370946607L), }, },
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(7431243917955702739L), new System.Numerics.BigInteger(5864166116594553083L), }, { new System.Numerics.BigInteger(989659920546103482L), new System.Numerics.BigInteger(4849232174584059237L), }, },
},
    NullableValue = null,
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(2893175112159970512L), new System.Numerics.BigInteger(1289725801006524927L), }, { new System.Numerics.BigInteger(2375238205636077730L), new System.Numerics.BigInteger(9023106515851242342L), }, },
    ModelInner = null,
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(8980132958665308999L), new System.Numerics.BigInteger(6957061716639095570L), }, { new System.Numerics.BigInteger(2486967294846554269L), new System.Numerics.BigInteger(3432270157057703948L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4617159979021455603L), new System.Numerics.BigInteger(2849028385744958374L), }, { new System.Numerics.BigInteger(16396905799621444L), new System.Numerics.BigInteger(5366803119528488933L), }, },
    ModelInner = new BigIntegernumericMMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(1697375105742447210L), new System.Numerics.BigInteger(7606492994008982593L), }, { new System.Numerics.BigInteger(7422900828345417627L), new System.Numerics.BigInteger(5136175585702654355L), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4969320225966626694L), new System.Numerics.BigInteger(3548768911697066953L), }, { new System.Numerics.BigInteger(9161385309201106217L), new System.Numerics.BigInteger(3534021711842804101L), }, },
},
            new BigIntegernumericMMArrayD2E1M
{
    Id = 173,
    Value = 
new System.Numerics.BigInteger[,] { { new System.Numerics.BigInteger(4809484211188961918L), new System.Numerics.BigInteger(1460902443388192476L), }, { new System.Numerics.BigInteger(5814030113213710806L), new System.Numerics.BigInteger(8866822744434118188L), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1mi(
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
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
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

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
INSERT INTO public.bigintegernumericmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    bigintegernumericmmarrayd2e1mi_id
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
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericmmarrayd2e1mi_id", 
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
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[5], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[6], true);
                models =  ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericMMArrayD2E1M> models = null;

                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[8], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[11], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IBigIntegerMArraynumericMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 59;
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M), typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 113, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 74, query1, 5, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var models2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 62, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var firstItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 23, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatBigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 86, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 113, query1, 60, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
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
FROM public.bigintegernumericmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems1 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                var secondItems2 = new List<FlatBigIntegernumericMMArrayD2E1M>();
                 ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 35, query1, 109, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatBigIntegernumericMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.bigintegernumericmmarrayd2e1m m
LEFT JOIN public.bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 46))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    BigIntegernumericMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IBigIntegerMArraynumericMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 129, 59))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 62);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerMArraynumericMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerMArraynumericMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 50);
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                BigIntegernumericMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                BigIntegernumericMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MI),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_bigintegernumericmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new BigIntegernumericMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericMMArrayD2E1M),
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
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
FROM public.binary_bigintegernumericmmarrayd2e1m m
LEFT JOIN public.binary_bigintegernumericmmarrayd2e1mi mi ON mi.id = m.bigintegernumericmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IBigIntegerMArraynumericMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<BigIntegernumericMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IBigIntegerMArraynumericMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models =  ((IBigIntegerMArraynumericMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    BigIntegernumericMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
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
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI), typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MI>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MI>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2)),
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_bigintegernumericmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA), typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                await ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                var models2 = new List<BigIntegernumericMMArrayD2E1MIWA>();
                ((IBigIntegerMArraynumericMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(BigIntegernumericMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerMArraynumericMMArrayD2))]
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
                var models = await ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IBigIntegerMArraynumericMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    BigIntegernumericMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

