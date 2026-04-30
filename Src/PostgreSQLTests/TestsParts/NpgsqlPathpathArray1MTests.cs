

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3026503745414173d, y: 0.985332804391267d), new NpgsqlTypes.NpgsqlPoint(x: 0.038006564374003515d, y: 0.1443283190692657d), new NpgsqlTypes.NpgsqlPoint(x: 0.9611689080666301d, y: 0.7854153585746804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2762862974870136d, y: 0.9997027226662747d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291652829864d, y: 0.5074141825045657d), new NpgsqlTypes.NpgsqlPoint(x: 0.653300261324822d, y: 0.5183050133984203d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9525296956587822d, y: 0.10863415765693141d), new NpgsqlTypes.NpgsqlPoint(x: 0.40119806765338895d, y: 0.1359405357304262d), new NpgsqlTypes.NpgsqlPoint(x: 0.0819269338529448d, y: 0.19531975966606596d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49089971805188826d, y: 0.5991175054192825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6511393647695426d, y: 0.019484599566622518d), new NpgsqlTypes.NpgsqlPoint(x: 0.19608765750732793d, y: 0.7623865215638657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.032056986891469075d, y: 0.8342113309129184d), new NpgsqlTypes.NpgsqlPoint(x: 0.012273089078796873d, y: 0.731632081125052d), new NpgsqlTypes.NpgsqlPoint(x: 0.24103768424232652d, y: 0.2684586871040451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47256068453496924d, y: 0.16091050864432532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608174538826671d, y: 0.971008558120096d), new NpgsqlTypes.NpgsqlPoint(x: 0.09841883038357613d, y: 0.2658522120514779d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5165586509833238d, y: 0.9905890585744744d), new NpgsqlTypes.NpgsqlPoint(x: 0.15358679538228293d, y: 0.16198640643694384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100864968538524d, y: 0.3706555890473727d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44558228800796174d, y: 0.39143581334185795d), new NpgsqlTypes.NpgsqlPoint(x: 0.8675950156280792d, y: 0.7948615076292705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616614302915365d, y: 0.8147149474775547d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2706619265427832d, y: 0.5980388877663749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5345611097736406d, y: 0.5507609128245522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4604751130384773d, y: 0.28711527446708274d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3136354875311429d, y: 0.11109705178397578d), new NpgsqlTypes.NpgsqlPoint(x: 0.33140426286023483d, y: 0.001665897583725262d), new NpgsqlTypes.NpgsqlPoint(x: 0.752728812990536d, y: 0.546120219873069d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32420104940030414d, y: 0.08829713093994329d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476649015061975d, y: 0.48590038406327507d), new NpgsqlTypes.NpgsqlPoint(x: 0.3697506181043192d, y: 0.495670387547797d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14620036650050083d, y: 0.050985965691697555d), new NpgsqlTypes.NpgsqlPoint(x: 0.48890004317280933d, y: 0.29976608165695495d), new NpgsqlTypes.NpgsqlPoint(x: 0.1567315748441127d, y: 0.020959284352330743d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6064561927948581d, y: 0.3747863112212072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6611070897162039d, y: 0.23683498374389d), new NpgsqlTypes.NpgsqlPoint(x: 0.821892153508905d, y: 0.404659038188254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3273421739827136d, y: 0.5179925275274174d), new NpgsqlTypes.NpgsqlPoint(x: 0.16903153579420327d, y: 0.1516567251336649d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290378185673057d, y: 0.2965254317206997d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9840527464026432d, y: 0.928992409940665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8919304150670119d, y: 0.13690759797158636d), new NpgsqlTypes.NpgsqlPoint(x: 0.26983047009859196d, y: 0.45163416909015686d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02808524542146995d, y: 0.6652209045628322d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381814946740973d, y: 0.2883592575694983d), new NpgsqlTypes.NpgsqlPoint(x: 0.768387014550138d, y: 0.8127226343045358d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44647740981449213d, y: 0.4340865876307216d), new NpgsqlTypes.NpgsqlPoint(x: 0.4984735976994107d, y: 0.7632016075136173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462971001533914d, y: 0.4026932382041648d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5621474397261301d, y: 0.5526490439604077d), new NpgsqlTypes.NpgsqlPoint(x: 0.0786901801278933d, y: 0.12777185374119038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654586724413833d, y: 0.8944477673811709d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7602608423990113d, y: 0.6022811241713604d), new NpgsqlTypes.NpgsqlPoint(x: 0.42908078397564064d, y: 0.2937690491477448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6384270120824309d, y: 0.2249954715622523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23537366650512104d, y: 0.326724105794865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260581624834164d, y: 0.030189979404691925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3411327171471352d, y: 0.7446570096341488d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7066466229534543d, y: 0.8574069321735134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7173791412673144d, y: 0.7448654456850112d), new NpgsqlTypes.NpgsqlPoint(x: 0.3539231414331443d, y: 0.7626446415136987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.787076724432794d, y: 0.8873884609871557d), new NpgsqlTypes.NpgsqlPoint(x: 0.3958355587173409d, y: 0.057930263858022024d), new NpgsqlTypes.NpgsqlPoint(x: 0.14384551465512063d, y: 0.6297019938527957d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19738681241021028d, y: 0.403343191003635d), new NpgsqlTypes.NpgsqlPoint(x: 0.500381001563851d, y: 0.801145587340526d), new NpgsqlTypes.NpgsqlPoint(x: 0.69284970078133d, y: 0.16290186930734274d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2765542119184997d, y: 0.015269495643598252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8999571234619629d, y: 0.5958575804986149d), new NpgsqlTypes.NpgsqlPoint(x: 0.295819528258503d, y: 0.41661963713263384d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32399680324750146d, y: 0.09791684377455889d), new NpgsqlTypes.NpgsqlPoint(x: 0.1885401466870058d, y: 0.015106362886041835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3641460981959078d, y: 0.8106550238226139d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20505776894559025d, y: 0.6406180152101358d), new NpgsqlTypes.NpgsqlPoint(x: 0.6272960965798556d, y: 0.5610825183748132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208857679601155d, y: 0.3703025459084087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8241466092895343d, y: 0.029877986203598716d), new NpgsqlTypes.NpgsqlPoint(x: 0.32394559303534975d, y: 0.9935624162657429d), new NpgsqlTypes.NpgsqlPoint(x: 0.5548936763555259d, y: 0.7721697109129569d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38504563179776463d, y: 0.521810731453147d), new NpgsqlTypes.NpgsqlPoint(x: 0.1019771786060899d, y: 0.43420608985513776d), new NpgsqlTypes.NpgsqlPoint(x: 0.3344129772727894d, y: 0.705487381435893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6988148986246124d, y: 0.615991896889729d), new NpgsqlTypes.NpgsqlPoint(x: 0.10612823817610872d, y: 0.008402815933468144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283576465544915d, y: 0.5033761084956367d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4928837632088965d, y: 0.6819490830108617d), new NpgsqlTypes.NpgsqlPoint(x: 0.6195161919708725d, y: 0.6388740486952619d), new NpgsqlTypes.NpgsqlPoint(x: 0.029612475287013273d, y: 0.9295740048551451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4397715885253136d, y: 0.22102599299441905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159166662931826d, y: 0.46726993443779585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325505341064482d, y: 0.8036367622787641d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2615473703267669d, y: 0.36366195711684324d), new NpgsqlTypes.NpgsqlPoint(x: 0.8171950413859498d, y: 0.032081662790750975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8160464489901204d, y: 0.15642807164622308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36870336230313727d, y: 0.6073410759892067d), new NpgsqlTypes.NpgsqlPoint(x: 0.554448910726874d, y: 0.07632127489327412d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269927577850701d, y: 0.4526029869229804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41104395288005013d, y: 0.5896893289860937d), new NpgsqlTypes.NpgsqlPoint(x: 0.31860775321286994d, y: 0.14540490114549331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3069387023929766d, y: 0.9480451986763261d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6122405234704373d, y: 0.4193171701087328d), new NpgsqlTypes.NpgsqlPoint(x: 0.21078930652484218d, y: 0.49231152010893797d), new NpgsqlTypes.NpgsqlPoint(x: 0.4848964005247446d, y: 0.7084215944727528d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.651511178981386d, y: 0.44656605865013177d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154294937459415d, y: 0.10108571150227441d), new NpgsqlTypes.NpgsqlPoint(x: 0.760640299346426d, y: 0.49203528169984334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6968899946928977d, y: 0.09815500554956591d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079726554737635d, y: 0.9933441423019663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2180379037814465d, y: 0.5213480214601286d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1316997844731984d, y: 0.5151754986490903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236476255247795d, y: 0.12151645153168777d), new NpgsqlTypes.NpgsqlPoint(x: 0.31661078392188813d, y: 0.566424492443675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39420445273468985d, y: 0.1424583553083394d), new NpgsqlTypes.NpgsqlPoint(x: 0.16363290072912096d, y: 0.7373314234135826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7697679661528979d, y: 0.6447955201190264d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24297880834811536d, y: 0.13686575515660648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878706259645055d, y: 0.537391093983229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936379837496005d, y: 0.6799512275249168d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8422422155433406d, y: 0.0198033351904775d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703681215819475d, y: 0.48043713080670014d), new NpgsqlTypes.NpgsqlPoint(x: 0.478763511803424d, y: 0.8463421479489093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9817284686304698d, y: 0.5057942392673097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5711802737503503d, y: 0.002612340456487394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076855807270459d, y: 0.3860886898467387d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7704914899499388d, y: 0.4202164265575298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647994225640348d, y: 0.7747110403877543d), new NpgsqlTypes.NpgsqlPoint(x: 0.49853685450417884d, y: 0.9000248261550349d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34593800085981263d, y: 0.34233361123716877d), new NpgsqlTypes.NpgsqlPoint(x: 0.29011768369470337d, y: 0.8443794779691303d), new NpgsqlTypes.NpgsqlPoint(x: 0.48971138945107884d, y: 0.4514859850322358d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31437426658244627d, y: 0.9030990922450898d), new NpgsqlTypes.NpgsqlPoint(x: 0.4852635290335078d, y: 0.07796914630218477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720133880092842d, y: 0.6502294325530962d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7831805235647041d, y: 0.6757112802377053d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905020385592491d, y: 0.5958072727921682d), new NpgsqlTypes.NpgsqlPoint(x: 0.4564048652058297d, y: 0.20510735481269304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5790899635249921d, y: 0.6705422191664564d), new NpgsqlTypes.NpgsqlPoint(x: 0.15393004160701407d, y: 0.9942748661479968d), new NpgsqlTypes.NpgsqlPoint(x: 0.17738118796224933d, y: 0.5616880794141036d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7699713470916367d, y: 0.08362002752578745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9426106176065604d, y: 0.7588196780583732d), new NpgsqlTypes.NpgsqlPoint(x: 0.8660544118920251d, y: 0.7181122598355356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.876510708788632d, y: 0.2399674294846963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9039832429475009d, y: 0.8698508750478082d), new NpgsqlTypes.NpgsqlPoint(x: 0.3882395357828431d, y: 0.6142157027049489d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0518676118132253d, y: 0.6845933832092153d), new NpgsqlTypes.NpgsqlPoint(x: 0.4259380809968596d, y: 0.36674047378463015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251598946871324d, y: 0.8405451914759855d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40415115800869217d, y: 0.2621973182177121d), new NpgsqlTypes.NpgsqlPoint(x: 0.09894500877023238d, y: 0.40930693294824605d), new NpgsqlTypes.NpgsqlPoint(x: 0.676878065419971d, y: 0.47037495861813483d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9415802106488569d, y: 0.33845503516251985d), new NpgsqlTypes.NpgsqlPoint(x: 0.931355558082489d, y: 0.623444943862621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962490158392392d, y: 0.4044672774958451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04520500640206804d, y: 0.10691259931848252d), new NpgsqlTypes.NpgsqlPoint(x: 0.2822436378327139d, y: 0.9079819598666299d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495559277600373d, y: 0.18636053665106356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3159148735801287d, y: 0.14987935268582087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886708711450578d, y: 0.96103485778872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7399683842660172d, y: 0.2841284638590299d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4966544961322733d, y: 0.5367247298440532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8908838017441127d, y: 0.6171858560708591d), new NpgsqlTypes.NpgsqlPoint(x: 0.42926574114199145d, y: 0.5917229713817302d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6884807390157437d, y: 0.501367177638638d), new NpgsqlTypes.NpgsqlPoint(x: 0.4561003943941532d, y: 0.004332727112653534d), new NpgsqlTypes.NpgsqlPoint(x: 0.506207255775592d, y: 0.8543042991908265d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9127224500349049d, y: 0.3161972647512775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7768142123298584d, y: 0.2930848139421337d), new NpgsqlTypes.NpgsqlPoint(x: 0.10817906619441642d, y: 0.03571036613782341d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3683646181193492d, y: 0.5816111741796283d), new NpgsqlTypes.NpgsqlPoint(x: 0.22042475403156292d, y: 0.729492258759577d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439718279019949d, y: 0.694673199970932d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.953592181505447d, y: 0.4085192365805512d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801565395711175d, y: 0.23295180903492652d), new NpgsqlTypes.NpgsqlPoint(x: 0.02856745020430196d, y: 0.7402427873533126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3611691232142161d, y: 0.7091616089297826d), new NpgsqlTypes.NpgsqlPoint(x: 0.010193966123927978d, y: 0.5641296793531498d), new NpgsqlTypes.NpgsqlPoint(x: 0.3758604402169653d, y: 0.5374842332588484d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5753318183154258d, y: 0.562031651812589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279784499672855d, y: 0.9610513146815843d), new NpgsqlTypes.NpgsqlPoint(x: 0.10980982272662265d, y: 0.7188776091082064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25707222126498164d, y: 0.4320998748024446d), new NpgsqlTypes.NpgsqlPoint(x: 0.23270371760963082d, y: 0.3160168600748877d), new NpgsqlTypes.NpgsqlPoint(x: 0.07634375544091243d, y: 0.5168549252622028d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1621533144895465d, y: 0.9339683996695289d), new NpgsqlTypes.NpgsqlPoint(x: 0.008227081886963306d, y: 0.33042690530135577d), new NpgsqlTypes.NpgsqlPoint(x: 0.1748923334178989d, y: 0.5269505569096788d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7646836622948847d, y: 0.9232193693100259d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534146265386197d, y: 0.7051645874950089d), new NpgsqlTypes.NpgsqlPoint(x: 0.2161218760787943d, y: 0.2303320659592052d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1574946864375818d, y: 0.19583350089454088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387778299486736d, y: 0.9469454930480321d), new NpgsqlTypes.NpgsqlPoint(x: 0.47724786565975164d, y: 0.31615741328902647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.705405940347308d, y: 0.24365528037898043d), new NpgsqlTypes.NpgsqlPoint(x: 0.38713575612870077d, y: 0.8622977856507544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3806683087813618d, y: 0.6673246070589209d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40932417550501954d, y: 0.15087199632334047d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881084482697793d, y: 0.5121112658694899d), new NpgsqlTypes.NpgsqlPoint(x: 0.3544460215091434d, y: 0.1884191996914718d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27744674819994963d, y: 0.004648780127315066d), new NpgsqlTypes.NpgsqlPoint(x: 0.40761413619744136d, y: 0.9926506398097917d), new NpgsqlTypes.NpgsqlPoint(x: 0.14261664889028414d, y: 0.339062502249282d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4720894345870743d, y: 0.5249049481247299d), new NpgsqlTypes.NpgsqlPoint(x: 0.9089067327150845d, y: 0.29413222331543465d), new NpgsqlTypes.NpgsqlPoint(x: 0.10534542743078135d, y: 0.9480520980067833d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04562317680228911d, y: 0.3509030931683491d), new NpgsqlTypes.NpgsqlPoint(x: 0.10879990299346143d, y: 0.4523256324321602d), new NpgsqlTypes.NpgsqlPoint(x: 0.543900223276392d, y: 0.6311873141997888d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46830712752670334d, y: 0.9497038385275408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6319669613486931d, y: 0.06999143887981618d), new NpgsqlTypes.NpgsqlPoint(x: 0.4868805207966228d, y: 0.2649873518537681d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8009642315580132d, y: 0.5782311804303173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064517456679694d, y: 0.1818522249498099d), new NpgsqlTypes.NpgsqlPoint(x: 0.3993107783577786d, y: 0.5315689492385934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7183341316160757d, y: 0.6547893855237561d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197873763752046d, y: 0.3230026928737306d), new NpgsqlTypes.NpgsqlPoint(x: 0.3629440984745801d, y: 0.791532649608236d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32961156223048826d, y: 0.26905699753916956d), new NpgsqlTypes.NpgsqlPoint(x: 0.926859701314297d, y: 0.6259699102831862d), new NpgsqlTypes.NpgsqlPoint(x: 0.2017432980513525d, y: 0.7445539123710032d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09473133100325704d, y: 0.9157170900703637d), new NpgsqlTypes.NpgsqlPoint(x: 0.14218122664195088d, y: 0.7424136810638539d), new NpgsqlTypes.NpgsqlPoint(x: 0.4820822079466568d, y: 0.48152396613270154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7566035340498745d, y: 0.21846646495209843d), new NpgsqlTypes.NpgsqlPoint(x: 0.013035892277143413d, y: 0.16165904071369952d), new NpgsqlTypes.NpgsqlPoint(x: 0.1678705716393789d, y: 0.7854861826741734d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2791094967394664d, y: 0.17590362361644896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797791059487105d, y: 0.893814063281162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172031292661063d, y: 0.27287608176833433d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9400518828264369d, y: 0.5682499943142415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147556080330097d, y: 0.05461106435887242d), new NpgsqlTypes.NpgsqlPoint(x: 0.1504582549692377d, y: 0.672792395227789d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45249608051870027d, y: 0.14374095847270707d), new NpgsqlTypes.NpgsqlPoint(x: 0.06964152227320664d, y: 0.6686156319216027d), new NpgsqlTypes.NpgsqlPoint(x: 0.34270863256007167d, y: 0.9439291728271735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048287031527978974d, y: 0.842526531583227d), new NpgsqlTypes.NpgsqlPoint(x: 0.4079260959534238d, y: 0.7480886489949147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054658311122333d, y: 0.9555253143884268d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2751303468157167d, y: 0.6362785024978292d), new NpgsqlTypes.NpgsqlPoint(x: 0.22137146905547533d, y: 0.3884043011722369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9330598014908059d, y: 0.3536063493977428d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44378782544335904d, y: 0.26653540432616407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865400737578272d, y: 0.11789221976483921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7178686167537882d, y: 0.46856251197689336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4874488423013038d, y: 0.9343943549324124d), new NpgsqlTypes.NpgsqlPoint(x: 0.059293133680972d, y: 0.3684333207473913d), new NpgsqlTypes.NpgsqlPoint(x: 0.1704951216333549d, y: 0.1854557516919142d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8660228380265858d, y: 0.3759762913405188d), new NpgsqlTypes.NpgsqlPoint(x: 0.26238109676401056d, y: 0.27790660740308226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6782216977785146d, y: 0.48475160315840937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22255099226566777d, y: 0.5697775214977716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481151259803172d, y: 0.5150275829199695d), new NpgsqlTypes.NpgsqlPoint(x: 0.05865134536999883d, y: 0.19297687188660084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4645621417978558d, y: 0.7095539474162397d), new NpgsqlTypes.NpgsqlPoint(x: 0.987085963105682d, y: 0.5626206590404451d), new NpgsqlTypes.NpgsqlPoint(x: 0.6992069403649844d, y: 0.4241427174341348d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08531829328956708d, y: 0.8898356731866911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105339988583744d, y: 0.29819126066844104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168411761489575d, y: 0.3916008357778491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993716063752966d, y: 0.8724222238192345d), new NpgsqlTypes.NpgsqlPoint(x: 0.58330603929056d, y: 0.1962953048379662d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054850840674622d, y: 0.0028761517248581114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.988017436506046d, y: 0.06259715126781218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975474064421164d, y: 0.416281865827273d), new NpgsqlTypes.NpgsqlPoint(x: 0.10970959470663089d, y: 0.8889966655173774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6631776802459022d, y: 0.9972287663813222d), new NpgsqlTypes.NpgsqlPoint(x: 0.16305815118575506d, y: 0.39239721155566265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6010412291456763d, y: 0.9405754446493207d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3090167259490747d, y: 0.7651083283604689d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780322107692291d, y: 0.9670561752550076d), new NpgsqlTypes.NpgsqlPoint(x: 0.36163446592296267d, y: 0.9182456310601066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12742828044151921d, y: 0.2707706166111684d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203413160159121d, y: 0.32511606553187034d), new NpgsqlTypes.NpgsqlPoint(x: 0.3983757269822146d, y: 0.199748272853832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4220301859714758d, y: 0.05517465337816685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6509707222567638d, y: 0.5400148430727989d), new NpgsqlTypes.NpgsqlPoint(x: 0.3175772478608473d, y: 0.36336626661890903d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6072145855389244d, y: 0.31903499299101323d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291170119617381d, y: 0.931168141724267d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742671351784303d, y: 0.79851667618514d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.819857488586412d, y: 0.5841170141568677d), new NpgsqlTypes.NpgsqlPoint(x: 0.10955397187809546d, y: 0.06636135681786204d), new NpgsqlTypes.NpgsqlPoint(x: 0.20139591051144456d, y: 0.5678426567347427d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5890538439119263d, y: 0.23444014062646967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5821146365667508d, y: 0.8217685873098958d), new NpgsqlTypes.NpgsqlPoint(x: 0.4602449138492303d, y: 0.2051492038850411d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7350271982524584d, y: 0.10430216108991752d), new NpgsqlTypes.NpgsqlPoint(x: 0.20275919868812275d, y: 0.18058196907934287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422238746795104d, y: 0.2925384819972414d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9370736922639041d, y: 0.49941620029120104d), new NpgsqlTypes.NpgsqlPoint(x: 0.24420192742889235d, y: 0.10149487085584585d), new NpgsqlTypes.NpgsqlPoint(x: 0.13547447422831238d, y: 0.963160777033826d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7140471094463425d, y: 0.396685201421377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072834369498018d, y: 0.3558887523944342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772848469748075d, y: 0.38280343507870973d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11137006668513683d, y: 0.8103733583968911d), new NpgsqlTypes.NpgsqlPoint(x: 0.598102811275311d, y: 0.7029439441774835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5887337438222006d, y: 0.2293969402238215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6257708905143184d, y: 0.06539820476723679d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345272285250875d, y: 0.8927426338637419d), new NpgsqlTypes.NpgsqlPoint(x: 0.4586119063307187d, y: 0.8225635828677789d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40265623757538815d, y: 0.28658113492386184d), new NpgsqlTypes.NpgsqlPoint(x: 0.1765521274589471d, y: 0.187993890793964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530875369482566d, y: 0.5578772684310253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2492335486572651d, y: 0.9780703140258619d), new NpgsqlTypes.NpgsqlPoint(x: 0.41384483664187444d, y: 0.5206080679103205d), new NpgsqlTypes.NpgsqlPoint(x: 0.004298627017080836d, y: 0.3496596505733719d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19420615543115327d, y: 0.40918046009840614d), new NpgsqlTypes.NpgsqlPoint(x: 0.47883398870637106d, y: 0.7692808160123875d), new NpgsqlTypes.NpgsqlPoint(x: 0.2557190519602828d, y: 0.6676321916448987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03778002008389958d, y: 0.5818263212305576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288666693886331d, y: 0.1886415788433392d), new NpgsqlTypes.NpgsqlPoint(x: 0.178227883724694d, y: 0.06170525244494929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0471621561011204d, y: 0.4652202721981321d), new NpgsqlTypes.NpgsqlPoint(x: 0.06047717227348848d, y: 0.8128499418891997d), new NpgsqlTypes.NpgsqlPoint(x: 0.1781408917778151d, y: 0.32017231892296305d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7296848141366542d, y: 0.9055760617430784d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013893907705126995d, y: 0.1859913932689945d), new NpgsqlTypes.NpgsqlPoint(x: 0.4346620408739664d, y: 0.6553542702630084d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5496129299077694d, y: 0.791494495589097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8587645672407369d, y: 0.27840954655496053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6252001362393037d, y: 0.29887771289562604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42942387252325265d, y: 0.8614029508715176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292635635995269d, y: 0.1954298181795744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255966605769906d, y: 0.2921373170128283d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0794381819123614d, y: 0.4023820719773459d), new NpgsqlTypes.NpgsqlPoint(x: 0.8757831212847315d, y: 0.9665646307283626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6677574259288078d, y: 0.335232568893582d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5413001024013072d, y: 0.11667484274855189d), new NpgsqlTypes.NpgsqlPoint(x: 0.8773174746311626d, y: 0.12246708551938734d), new NpgsqlTypes.NpgsqlPoint(x: 0.727413330303032d, y: 0.05440662947898223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15306423664075242d, y: 0.39927556439657674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5079290719054218d, y: 0.8230442540709172d), new NpgsqlTypes.NpgsqlPoint(x: 0.4248844462478124d, y: 0.17169364695420197d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.633796753224124d, y: 0.986922161458107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078034219346796d, y: 0.4493692509641919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5758137426641874d, y: 0.027773979708507812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09205983671090079d, y: 0.1941192323424138d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578955479054001d, y: 0.739886527156579d), new NpgsqlTypes.NpgsqlPoint(x: 0.6849424104718879d, y: 0.29384897480229577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05014230463186209d, y: 0.05279649646954787d), new NpgsqlTypes.NpgsqlPoint(x: 0.44972077920443454d, y: 0.613714082991153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2855823341344562d, y: 0.951564071402644d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13851468441072912d, y: 0.6600868864516639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139220559789877d, y: 0.6037552935087515d), new NpgsqlTypes.NpgsqlPoint(x: 0.22361350954326786d, y: 0.8303743594877602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024978199516956123d, y: 0.8317333071234672d), new NpgsqlTypes.NpgsqlPoint(x: 0.05943196133214168d, y: 0.5061703257868179d), new NpgsqlTypes.NpgsqlPoint(x: 0.15768666163494804d, y: 0.6338252497842622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7468584780170798d, y: 0.25842084145560684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735918141691831d, y: 0.37288503263076767d), new NpgsqlTypes.NpgsqlPoint(x: 0.2579785877313645d, y: 0.8605527060617311d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3688289897424699d, y: 0.443389458841555d), new NpgsqlTypes.NpgsqlPoint(x: 0.569428182713678d, y: 0.3589719147735839d), new NpgsqlTypes.NpgsqlPoint(x: 0.3453615340062307d, y: 0.6933992047098103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4248042049892834d, y: 0.1166903786676845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219470255168154d, y: 0.9125478103603861d), new NpgsqlTypes.NpgsqlPoint(x: 0.38341966216470635d, y: 0.3086448503398168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5880762837980664d, y: 0.34554206303663815d), new NpgsqlTypes.NpgsqlPoint(x: 0.20589855710896987d, y: 0.21376808773192857d), new NpgsqlTypes.NpgsqlPoint(x: 0.9606301605090839d, y: 0.928708619522963d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.714410420384124d, y: 0.9287501659246639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468832314584962d, y: 0.14936569744248374d), new NpgsqlTypes.NpgsqlPoint(x: 0.03542247139811139d, y: 0.6363194506548371d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8110340650776934d, y: 0.6794373099466106d), new NpgsqlTypes.NpgsqlPoint(x: 0.39204388553389735d, y: 0.5455630847084169d), new NpgsqlTypes.NpgsqlPoint(x: 0.3442020616494176d, y: 0.34474403697623357d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5143156290890616d, y: 0.9036277715676756d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934455069222489d, y: 0.9874021803898498d), new NpgsqlTypes.NpgsqlPoint(x: 0.1530028344304527d, y: 0.42690110925022606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16271286039292798d, y: 0.6473520694775151d), new NpgsqlTypes.NpgsqlPoint(x: 0.4755852154635144d, y: 0.21739212336012825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6840296940756924d, y: 0.2484854526901631d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5523820002347972d, y: 0.8579391176933644d), new NpgsqlTypes.NpgsqlPoint(x: 0.0237073370477503d, y: 0.5227333494321892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542457063474444d, y: 0.9579066001099279d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6510987103799113d, y: 0.5561443665398106d), new NpgsqlTypes.NpgsqlPoint(x: 0.3185779816859434d, y: 0.2853702753816486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4076418125373945d, y: 0.35888265998497504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7930030830538656d, y: 0.8455474337375757d), new NpgsqlTypes.NpgsqlPoint(x: 0.964811664920761d, y: 0.2504377257483269d), new NpgsqlTypes.NpgsqlPoint(x: 0.11506886342273115d, y: 0.15141026355173537d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44786678601019747d, y: 0.0885569391376505d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472374159992452d, y: 0.5918578482245612d), new NpgsqlTypes.NpgsqlPoint(x: 0.8595056187724508d, y: 0.8105947355352336d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6954592702021022d, y: 0.8160110333964048d), new NpgsqlTypes.NpgsqlPoint(x: 0.3936789001840141d, y: 0.7944977200707632d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158536203518376d, y: 0.14666819601471903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7618336544317019d, y: 0.15574476190207354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9078352860748345d, y: 0.7032308629278999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8812375281581988d, y: 0.31686652106541846d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0068110436617190295d, y: 0.5150194079562356d), new NpgsqlTypes.NpgsqlPoint(x: 0.40423721075077335d, y: 0.5826699876184878d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826457226367709d, y: 0.26668399674277077d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6834831252629205d, y: 0.16500810029931912d), new NpgsqlTypes.NpgsqlPoint(x: 0.7650840207427723d, y: 0.6321432699641685d), new NpgsqlTypes.NpgsqlPoint(x: 0.16745909595942177d, y: 0.7374484333532483d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6635159605700235d, y: 0.5206460463840222d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823325569696582d, y: 0.021579064720689267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9902751582837038d, y: 0.3657558111455511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8405303051630751d, y: 0.4212106264028176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6070043868669251d, y: 0.5531004642131238d), new NpgsqlTypes.NpgsqlPoint(x: 0.19414950329810454d, y: 0.48991786394955705d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.507080280229651d, y: 0.7866715196816784d), new NpgsqlTypes.NpgsqlPoint(x: 0.38263686260489593d, y: 0.8716652053195221d), new NpgsqlTypes.NpgsqlPoint(x: 0.03052711898915028d, y: 0.11804066851721617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3575923758757543d, y: 0.7949657471664331d), new NpgsqlTypes.NpgsqlPoint(x: 0.8712341537603464d, y: 0.9862991583409847d), new NpgsqlTypes.NpgsqlPoint(x: 0.6280967758139976d, y: 0.8126352918962632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42754930546238656d, y: 0.08137938891742802d), new NpgsqlTypes.NpgsqlPoint(x: 0.6842791288662363d, y: 0.6175844949137558d), new NpgsqlTypes.NpgsqlPoint(x: 0.6666907125404458d, y: 0.6841264584665455d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3825269473945593d, y: 0.5554332598128996d), new NpgsqlTypes.NpgsqlPoint(x: 0.571123373161522d, y: 0.3753088156871769d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764557306180367d, y: 0.9469188679119651d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5007415593656862d, y: 0.7842184815172981d), new NpgsqlTypes.NpgsqlPoint(x: 0.7743488493833819d, y: 0.095942108039067d), new NpgsqlTypes.NpgsqlPoint(x: 0.31952746515368735d, y: 0.27331846252265257d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8685554895191311d, y: 0.11760015629299037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020419598812305d, y: 0.6518579148518413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512408814255623d, y: 0.09444197713070612d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29418059690697507d, y: 0.15250070865951482d), new NpgsqlTypes.NpgsqlPoint(x: 0.15460372605490602d, y: 0.8554688585688048d), new NpgsqlTypes.NpgsqlPoint(x: 0.1787004137885443d, y: 0.6920576512078277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14477005798454134d, y: 0.76329081072718d), new NpgsqlTypes.NpgsqlPoint(x: 0.35926020959327176d, y: 0.19816895201196694d), new NpgsqlTypes.NpgsqlPoint(x: 0.28179855212982063d, y: 0.27728102448650727d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32715303127005857d, y: 0.3235844532129446d), new NpgsqlTypes.NpgsqlPoint(x: 0.30789894317148525d, y: 0.9511096362728506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5165066240922147d, y: 0.6541698598177188d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8434884469244115d, y: 0.22242332433196854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213954730274528d, y: 0.2648115991391925d), new NpgsqlTypes.NpgsqlPoint(x: 0.3646884820984275d, y: 0.27869923669764674d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27074690890334485d, y: 0.05786351969215309d), new NpgsqlTypes.NpgsqlPoint(x: 0.44342230166868746d, y: 0.8564153762101459d), new NpgsqlTypes.NpgsqlPoint(x: 0.27109646180388025d, y: 0.280866066063435d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6117443351301295d, y: 0.629160208278886d), new NpgsqlTypes.NpgsqlPoint(x: 0.4443112821460782d, y: 0.0875119536276675d), new NpgsqlTypes.NpgsqlPoint(x: 0.9068252122083799d, y: 0.04276961125023726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.453641241475516d, y: 0.2105532210831681d), new NpgsqlTypes.NpgsqlPoint(x: 0.8466572913442665d, y: 0.9064609433313091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6998183111477628d, y: 0.5690690446877289d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8277181935066222d, y: 0.06979165134975052d), new NpgsqlTypes.NpgsqlPoint(x: 0.2665573754046989d, y: 0.6143561998808597d), new NpgsqlTypes.NpgsqlPoint(x: 0.325030690345125d, y: 0.7255777632780797d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2314448574408391d, y: 0.20429415434015286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524689836122659d, y: 0.5140084178690367d), new NpgsqlTypes.NpgsqlPoint(x: 0.90213715080933d, y: 0.7107897441256544d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7360957585563889d, y: 0.008195476924441003d), new NpgsqlTypes.NpgsqlPoint(x: 0.03253702855529994d, y: 0.5291627818006519d), new NpgsqlTypes.NpgsqlPoint(x: 0.2820046212294197d, y: 0.5954663433176915d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.918529104068331d, y: 0.6886103102094501d), new NpgsqlTypes.NpgsqlPoint(x: 0.4822676620591889d, y: 0.29620674434316596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676992813056101d, y: 0.29859370111873607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5921315779657809d, y: 0.971624572460338d), new NpgsqlTypes.NpgsqlPoint(x: 0.41296014131297565d, y: 0.07591744321228999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6942196863185455d, y: 0.6376815668581294d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6604703773466135d, y: 0.6251219179372233d), new NpgsqlTypes.NpgsqlPoint(x: 0.44455392339216326d, y: 0.42379328560857155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014609305317165d, y: 0.6493240781951028d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38654820940681967d, y: 0.7527683542389878d), new NpgsqlTypes.NpgsqlPoint(x: 0.014693690228017031d, y: 0.2979643656923219d), new NpgsqlTypes.NpgsqlPoint(x: 0.30703755868840366d, y: 0.9819825217110726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8067836120572679d, y: 0.8798653725482332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884620657553389d, y: 0.41337380261278256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6232460915324389d, y: 0.7023689460860661d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41588756677516125d, y: 0.19219434568821991d), new NpgsqlTypes.NpgsqlPoint(x: 0.040999468126782235d, y: 0.14694743946692224d), new NpgsqlTypes.NpgsqlPoint(x: 0.49006199235682335d, y: 0.6279385572092118d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6813666636426792d, y: 0.8320377285874794d), new NpgsqlTypes.NpgsqlPoint(x: 0.12879029328958358d, y: 0.7264976164782908d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988278579372045d, y: 0.16691441603678014d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.049317700297041855d, y: 0.20471058158943978d), new NpgsqlTypes.NpgsqlPoint(x: 0.2901519988580945d, y: 0.5630479416328493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6181527904150597d, y: 0.22946067631941447d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.787982561685187d, y: 0.3918751497524914d), new NpgsqlTypes.NpgsqlPoint(x: 0.4379555745736883d, y: 0.5298797634291945d), new NpgsqlTypes.NpgsqlPoint(x: 0.9608106149193945d, y: 0.786578316573737d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08431914063786417d, y: 0.9614679477050724d), new NpgsqlTypes.NpgsqlPoint(x: 0.001800320929326027d, y: 0.5481330139086287d), new NpgsqlTypes.NpgsqlPoint(x: 0.19187215399280566d, y: 0.2382266987741879d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9039684629897856d, y: 0.2865116661209888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121501820426134d, y: 0.24723781929156108d), new NpgsqlTypes.NpgsqlPoint(x: 0.022235996604537123d, y: 0.4021956139891375d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023838220221480966d, y: 0.07620389028867147d), new NpgsqlTypes.NpgsqlPoint(x: 0.33202037700444254d, y: 0.9745487645321329d), new NpgsqlTypes.NpgsqlPoint(x: 0.49691156028129024d, y: 0.3940154482102014d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6337833511322835d, y: 0.37564842353644046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9314529052316071d, y: 0.21456956976089425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9952446252900027d, y: 0.36508301189139014d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6868252369828213d, y: 0.6273975550011004d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038017348490008d, y: 0.773478972909906d), new NpgsqlTypes.NpgsqlPoint(x: 0.2599888523291143d, y: 0.7998905564447191d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.537288295020616d, y: 0.3104905451469775d), new NpgsqlTypes.NpgsqlPoint(x: 0.24724076758917513d, y: 0.5630831720985229d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111673640059174d, y: 0.4102566455929695d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5394784102088106d, y: 0.9169619030410074d), new NpgsqlTypes.NpgsqlPoint(x: 0.4738050924507997d, y: 0.3026160559803437d), new NpgsqlTypes.NpgsqlPoint(x: 0.2751780440903836d, y: 0.6586512690468938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20586058606625202d, y: 0.0721437646196127d), new NpgsqlTypes.NpgsqlPoint(x: 0.770895390384013d, y: 0.4158976541036341d), new NpgsqlTypes.NpgsqlPoint(x: 0.17888452078753148d, y: 0.8923032682627519d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07497281261053079d, y: 0.41499635206025476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024784024079599d, y: 0.18276963259013945d), new NpgsqlTypes.NpgsqlPoint(x: 0.16065258510351665d, y: 0.5876747262110033d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9059267525525181d, y: 0.3398933755685998d), new NpgsqlTypes.NpgsqlPoint(x: 0.14915740324114424d, y: 0.9298761746237583d), new NpgsqlTypes.NpgsqlPoint(x: 0.038263322625063156d, y: 0.06628794581454611d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5166784525744902d, y: 0.9749129018051829d), new NpgsqlTypes.NpgsqlPoint(x: 0.4355316427030679d, y: 0.20892310393612346d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620900496138683d, y: 0.4514903719830833d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9910641661791165d, y: 0.9369781231080169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9076833731267495d, y: 0.08513422709435814d), new NpgsqlTypes.NpgsqlPoint(x: 0.5102413905666824d, y: 0.6369806505885294d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9021867208596457d, y: 0.4274762188298674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125674108725172d, y: 0.4191933553996713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922707693586322d, y: 0.03902167297010928d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6140317921658422d, y: 0.9482075930232181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476807758808676d, y: 0.5494636988929982d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025613148122763d, y: 0.5402958080220072d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9851266036906363d, y: 0.17917676337930477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9470709325225756d, y: 0.39684232602080405d), new NpgsqlTypes.NpgsqlPoint(x: 0.09716200152378618d, y: 0.07091717690501553d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26618500410908363d, y: 0.019506090763316886d), new NpgsqlTypes.NpgsqlPoint(x: 0.4402309288306391d, y: 0.8821998502018595d), new NpgsqlTypes.NpgsqlPoint(x: 0.9759793443328987d, y: 0.49269938405317215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8722022123133816d, y: 0.013903182226820632d), new NpgsqlTypes.NpgsqlPoint(x: 0.6413870102661043d, y: 0.7086688308687269d), new NpgsqlTypes.NpgsqlPoint(x: 0.8362003519666245d, y: 0.9503452964323775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.013079537942220276d, y: 0.29633601534968457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6709013700927624d, y: 0.5284474986086465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124681163994088d, y: 0.4211028625323381d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02137456549700678d, y: 0.8790780629943435d), new NpgsqlTypes.NpgsqlPoint(x: 0.960738756460528d, y: 0.10912035275329635d), new NpgsqlTypes.NpgsqlPoint(x: 0.314030210504606d, y: 0.720214024861115d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7041421303022005d, y: 0.4426198652304707d), new NpgsqlTypes.NpgsqlPoint(x: 0.27924890776697897d, y: 0.31614602231240174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924841010543837d, y: 0.553496252823602d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36271868603205115d, y: 0.5839971674504411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998588047509585d, y: 0.4687272278572716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926739973300917d, y: 0.47417628200345197d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4439657639999868d, y: 0.9482022057960187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2768748869837073d, y: 0.909533066996597d), new NpgsqlTypes.NpgsqlPoint(x: 0.18158810333709685d, y: 0.12242656119728068d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6584948881904202d, y: 0.13367444017277574d), new NpgsqlTypes.NpgsqlPoint(x: 0.4592493424330101d, y: 0.7989798469542575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5499073273145527d, y: 0.006898427708868393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2484104155388992d, y: 0.09803537511247085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085385266291138d, y: 0.9814701518938692d), new NpgsqlTypes.NpgsqlPoint(x: 0.08446715320098164d, y: 0.24493171217992493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4647554544825915d, y: 0.5009646870713965d), new NpgsqlTypes.NpgsqlPoint(x: 0.4083980444215781d, y: 0.6550627838385176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6361102820787614d, y: 0.9676606617921558d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13083967838515964d, y: 0.09225063790003774d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174876105669148d, y: 0.3327528498131398d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499922584535924d, y: 0.7357800196709515d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4803472456790622d, y: 0.34738518273587093d), new NpgsqlTypes.NpgsqlPoint(x: 0.25015119607758607d, y: 0.12409425942587204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5008687120926882d, y: 0.473370376832307d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7879552073294356d, y: 0.15035420678427125d), new NpgsqlTypes.NpgsqlPoint(x: 0.721440639954446d, y: 0.10838190754704558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238906597584875d, y: 0.4278743168082556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6009884569619613d, y: 0.8828189667139443d), new NpgsqlTypes.NpgsqlPoint(x: 0.02962193112859479d, y: 0.48672651657229704d), new NpgsqlTypes.NpgsqlPoint(x: 0.22982134703035872d, y: 0.5303735328345168d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6814936930035416d, y: 0.33651653036980045d), new NpgsqlTypes.NpgsqlPoint(x: 0.5048555333307232d, y: 0.25266568121748656d), new NpgsqlTypes.NpgsqlPoint(x: 0.9607943025067116d, y: 0.20138035526059217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9335148099660047d, y: 0.30852707077331987d), new NpgsqlTypes.NpgsqlPoint(x: 0.16727650118548298d, y: 0.9063946091674385d), new NpgsqlTypes.NpgsqlPoint(x: 0.4498660692794092d, y: 0.2723361711611918d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1333388665118288d, y: 0.7048878641851594d), new NpgsqlTypes.NpgsqlPoint(x: 0.44031173196855233d, y: 0.9157757354466624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317849520151102d, y: 0.5015325024262103d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4124489751642264d, y: 0.5909263412906463d), new NpgsqlTypes.NpgsqlPoint(x: 0.11935558979182592d, y: 0.01873416425241714d), new NpgsqlTypes.NpgsqlPoint(x: 0.009386173884751159d, y: 0.2941370845991029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2647212377438777d, y: 0.6105804510001045d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466286895188667d, y: 0.5446928729856905d), new NpgsqlTypes.NpgsqlPoint(x: 0.023954098911286525d, y: 0.9799458662587143d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7929016567729804d, y: 0.7407301010914846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7762750324146358d, y: 0.7058256806881609d), new NpgsqlTypes.NpgsqlPoint(x: 0.3545638806031963d, y: 0.34624059916019134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25202611252295715d, y: 0.1605218348440436d), new NpgsqlTypes.NpgsqlPoint(x: 0.794466529644053d, y: 0.7883003397410673d), new NpgsqlTypes.NpgsqlPoint(x: 0.758694026908283d, y: 0.8988487379899953d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6510442564367546d, y: 0.10258716510371091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3035742741334322d, y: 0.7607763599152604d), new NpgsqlTypes.NpgsqlPoint(x: 0.15214227366639665d, y: 0.28792388877041963d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061396687204873235d, y: 0.35461353441907806d), new NpgsqlTypes.NpgsqlPoint(x: 0.27971247504643915d, y: 0.11240702492644328d), new NpgsqlTypes.NpgsqlPoint(x: 0.10196450431514703d, y: 0.5232372163552648d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44048588109601416d, y: 0.5707251213122941d), new NpgsqlTypes.NpgsqlPoint(x: 0.37103729687631715d, y: 0.3822981727842225d), new NpgsqlTypes.NpgsqlPoint(x: 0.475784087997972d, y: 0.3062436314090745d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23848427908393566d, y: 0.8358116468232448d), new NpgsqlTypes.NpgsqlPoint(x: 0.18806337239013227d, y: 0.9408805676564816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895656386235877d, y: 0.4162529157597147d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24605462837078051d, y: 0.7546481905006709d), new NpgsqlTypes.NpgsqlPoint(x: 0.6988867095312523d, y: 0.6566561724990505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078435899517395d, y: 0.8564295811501107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22202328713883057d, y: 0.3234817526871946d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862945833440843d, y: 0.05814507695998605d), new NpgsqlTypes.NpgsqlPoint(x: 0.4271101641528383d, y: 0.24289551636655815d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41118630230857545d, y: 0.8800938190879823d), new NpgsqlTypes.NpgsqlPoint(x: 0.5026906612489421d, y: 0.7470696372268827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321114311930497d, y: 0.6575671996974507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7507864250457211d, y: 0.4058790966786755d), new NpgsqlTypes.NpgsqlPoint(x: 0.6194452908171098d, y: 0.7410052135916796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499725022413403d, y: 0.08476801609166862d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23890480870011277d, y: 0.26812944620807d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552361508283835d, y: 0.0479108911538807d), new NpgsqlTypes.NpgsqlPoint(x: 0.40695421404623466d, y: 0.3786686335021966d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42631270688941125d, y: 0.6037451846255468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553736778039212d, y: 0.7977500734492817d), new NpgsqlTypes.NpgsqlPoint(x: 0.18759003749066006d, y: 0.10757993271705713d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44031531162885906d, y: 0.4048302292599417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3382900217964655d, y: 0.4513435522915227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6168318230735415d, y: 0.15765749646906813d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8816666610361492d, y: 0.5904762130824805d), new NpgsqlTypes.NpgsqlPoint(x: 0.4198639574896007d, y: 0.23050300503904486d), new NpgsqlTypes.NpgsqlPoint(x: 0.1956097323370627d, y: 0.10421336328309327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5493654876259771d, y: 0.3073032741429177d), new NpgsqlTypes.NpgsqlPoint(x: 0.03205076451730804d, y: 0.7620806836017685d), new NpgsqlTypes.NpgsqlPoint(x: 0.49547644802227486d, y: 0.10251457629070637d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44862137139267644d, y: 0.604828344381013d), new NpgsqlTypes.NpgsqlPoint(x: 0.3090676224629776d, y: 0.8416209464292105d), new NpgsqlTypes.NpgsqlPoint(x: 0.013443216896507182d, y: 0.31514193263109447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6982228943900356d, y: 0.3036172559450493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8715050670360641d, y: 0.902299979894705d), new NpgsqlTypes.NpgsqlPoint(x: 0.3712546244149594d, y: 0.23219171154099927d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8521192253629173d, y: 0.40003499989768754d), new NpgsqlTypes.NpgsqlPoint(x: 0.05326101152958518d, y: 0.06487609194285193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545632755487741d, y: 0.3227957983384442d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7450361361552202d, y: 0.1600812852701109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295637569956416d, y: 0.9731567315829118d), new NpgsqlTypes.NpgsqlPoint(x: 0.14622532265921773d, y: 0.9319257513061479d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9776255122291716d, y: 0.19696941414393176d), new NpgsqlTypes.NpgsqlPoint(x: 0.7288001506719142d, y: 0.8014955709650252d), new NpgsqlTypes.NpgsqlPoint(x: 0.24250323614700575d, y: 0.8459447446801909d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12365137348802813d, y: 0.9220773709642903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049974929154659d, y: 0.9347932547174624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6851731705509491d, y: 0.20782649925656027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1827775007447241d, y: 0.9396400982474337d), new NpgsqlTypes.NpgsqlPoint(x: 0.590094728385007d, y: 0.48763027361856626d), new NpgsqlTypes.NpgsqlPoint(x: 0.6205065729046614d, y: 0.10494392764974103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3094949710684063d, y: 0.6225303118192373d), new NpgsqlTypes.NpgsqlPoint(x: 0.414310384259447d, y: 0.08388410368743959d), new NpgsqlTypes.NpgsqlPoint(x: 0.5727665330824908d, y: 0.6006505030576641d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7321660492841809d, y: 0.38865221667340466d), new NpgsqlTypes.NpgsqlPoint(x: 0.4319616543115835d, y: 0.4922076597382319d), new NpgsqlTypes.NpgsqlPoint(x: 0.49250911201589265d, y: 0.7054468509807199d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9041290785778235d, y: 0.5119487714979648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8871250898349158d, y: 0.41257828079751d), new NpgsqlTypes.NpgsqlPoint(x: 0.75216882250171d, y: 0.95302728270472d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3369722979182136d, y: 0.06512024989197163d), new NpgsqlTypes.NpgsqlPoint(x: 0.23769138233774056d, y: 0.07351597088094808d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703235447942308d, y: 0.5437708608935445d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7354528627612756d, y: 0.7800003126981122d), new NpgsqlTypes.NpgsqlPoint(x: 0.4093054846911339d, y: 0.24602693867884406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402886109706572d, y: 0.5651190352533069d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12912610800122426d, y: 0.7736235776280328d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651896340092695d, y: 0.09808053386108162d), new NpgsqlTypes.NpgsqlPoint(x: 0.19835227759334584d, y: 0.330621492772912d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7239437061871893d, y: 0.30031590347206294d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411271346593643d, y: 0.24339453302148406d), new NpgsqlTypes.NpgsqlPoint(x: 0.36894085719852d, y: 0.1217011491212191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8800974127566868d, y: 0.24944387263594325d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969597988783824d, y: 0.4446607262279618d), new NpgsqlTypes.NpgsqlPoint(x: 0.914386396260169d, y: 0.1892531293406089d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5379760310125383d, y: 0.03583654408404535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6513393040695741d, y: 0.6214201693650382d), new NpgsqlTypes.NpgsqlPoint(x: 0.5309432131367252d, y: 0.18350301046349415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5131262666338302d, y: 0.4020989859520224d), new NpgsqlTypes.NpgsqlPoint(x: 0.9313675883425566d, y: 0.14352372794284995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6358104630897108d, y: 0.665566460126698d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8524314656251685d, y: 0.5900650619839306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824201232998715d, y: 0.9564490914721911d), new NpgsqlTypes.NpgsqlPoint(x: 0.618393508910346d, y: 0.5147363583614996d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6793067384497918d, y: 0.8525102909563433d), new NpgsqlTypes.NpgsqlPoint(x: 0.11388793965403565d, y: 0.16906059357995762d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512007763517759d, y: 0.7813961344614728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.256191979527409d, y: 0.8811976400310522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5271673064394804d, y: 0.7082795376478088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3312929472081594d, y: 0.7747740427346901d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3401796619117128d, y: 0.9037530572717731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220108207522185d, y: 0.7261954307935334d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036932252557706d, y: 0.8667578133238062d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.692899458039388d, y: 0.9213236092249316d), new NpgsqlTypes.NpgsqlPoint(x: 0.26650395008503214d, y: 0.5192008650304155d), new NpgsqlTypes.NpgsqlPoint(x: 0.15456567405614274d, y: 0.7227736486992044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44730400998360365d, y: 0.9856670555553968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8527877555345297d, y: 0.32674732572323684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200372399794235d, y: 0.22371580970057847d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6750132081467435d, y: 0.7847053178169291d), new NpgsqlTypes.NpgsqlPoint(x: 0.9819493462090829d, y: 0.525278471488667d), new NpgsqlTypes.NpgsqlPoint(x: 0.12557653748525288d, y: 0.8138241280727015d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.692227103463469d, y: 0.760797715724813d), new NpgsqlTypes.NpgsqlPoint(x: 0.23049391519218632d, y: 0.8654662398944486d), new NpgsqlTypes.NpgsqlPoint(x: 0.24231962889803738d, y: 0.045646964359900566d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.733811396970104d, y: 0.015261872730027548d), new NpgsqlTypes.NpgsqlPoint(x: 0.1030313801247198d, y: 0.019833993185007892d), new NpgsqlTypes.NpgsqlPoint(x: 0.324880500968746d, y: 0.36833784084317944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8593163971052582d, y: 0.3880786944146062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5896395981376308d, y: 0.0574929897604588d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639403797744184d, y: 0.8249735908733723d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5393561758197994d, y: 0.20054886151825202d), new NpgsqlTypes.NpgsqlPoint(x: 0.9594656123296458d, y: 0.5361172940850631d), new NpgsqlTypes.NpgsqlPoint(x: 0.6266214895269684d, y: 0.6134500803051631d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.956600295825474d, y: 0.3309483118926355d), new NpgsqlTypes.NpgsqlPoint(x: 0.10835901109020563d, y: 0.5866958840663511d), new NpgsqlTypes.NpgsqlPoint(x: 0.005966739629272855d, y: 0.7442072378987394d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36986615614406315d, y: 0.6778336738344944d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024319484343164888d, y: 0.8053343383677292d), new NpgsqlTypes.NpgsqlPoint(x: 0.31635746455705926d, y: 0.1898282683251834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3689391283843577d, y: 0.15355445768827025d), new NpgsqlTypes.NpgsqlPoint(x: 0.9691038632401481d, y: 0.16677605475419932d), new NpgsqlTypes.NpgsqlPoint(x: 0.8130379251610136d, y: 0.11625572071653567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.610179870177556d, y: 0.5006507341830471d), new NpgsqlTypes.NpgsqlPoint(x: 0.5495618402110406d, y: 0.7084204642042263d), new NpgsqlTypes.NpgsqlPoint(x: 0.3537276385849515d, y: 0.17846935797606d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4481777927834142d, y: 0.2763069167211075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4179815156876362d, y: 0.22893293407889648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169889238011213d, y: 0.4378176232378622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8298406522610948d, y: 0.0251531213391738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6200652258456523d, y: 0.7475623102798886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5808319949072844d, y: 0.889247794219482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34912393779647655d, y: 0.831660056185851d), new NpgsqlTypes.NpgsqlPoint(x: 0.4012884093191932d, y: 0.10246568589364813d), new NpgsqlTypes.NpgsqlPoint(x: 0.3278680901892659d, y: 0.6054057099960143d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7538771173623808d, y: 0.6952863107869065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8503041378566132d, y: 0.5902740056064738d), new NpgsqlTypes.NpgsqlPoint(x: 0.519427249482691d, y: 0.6763499584727198d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7842731357710954d, y: 0.9587928136541729d), new NpgsqlTypes.NpgsqlPoint(x: 0.8355317642348872d, y: 0.6300500750936742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7126198219864125d, y: 0.7596292446761852d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2939150899660584d, y: 0.1002055096327964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171811596380207d, y: 0.7902083599018885d), new NpgsqlTypes.NpgsqlPoint(x: 0.36952194321917375d, y: 0.33617290591245375d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7569302421822851d, y: 0.791722934385303d), new NpgsqlTypes.NpgsqlPoint(x: 0.115077035288353d, y: 0.58922881894374d), new NpgsqlTypes.NpgsqlPoint(x: 0.19744317071915696d, y: 0.6248563765821591d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2284990567005536d, y: 0.5736583179908188d), new NpgsqlTypes.NpgsqlPoint(x: 0.030772491736756113d, y: 0.6560721342453492d), new NpgsqlTypes.NpgsqlPoint(x: 0.021558012456511566d, y: 0.9906933954307955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4406269335371822d, y: 0.23834822731768546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134246769108963d, y: 0.5611931430323672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9109616759069854d, y: 0.1110216149700507d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7540426537302268d, y: 0.004664522461386822d), new NpgsqlTypes.NpgsqlPoint(x: 0.5690147508710816d, y: 0.03394393333317458d), new NpgsqlTypes.NpgsqlPoint(x: 0.31187060573100867d, y: 0.8079426702296519d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6289204387627557d, y: 0.6727871657914102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9470343265914904d, y: 0.7524330103315598d), new NpgsqlTypes.NpgsqlPoint(x: 0.004168885296778613d, y: 0.6529174084620305d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6803884890964658d, y: 0.9861576567828476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250627813685371d, y: 0.18744459156848325d), new NpgsqlTypes.NpgsqlPoint(x: 0.1434717356588242d, y: 0.9768565407170677d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3995518203999826d, y: 0.12663857056415495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874947216848497d, y: 0.9875632769429207d), new NpgsqlTypes.NpgsqlPoint(x: 0.18120589688773692d, y: 0.37133687355037825d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.899607187646676d, y: 0.5000877997193796d), new NpgsqlTypes.NpgsqlPoint(x: 0.0073868973885236056d, y: 0.8861540905363866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6702037316821144d, y: 0.7781246333768677d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 182,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027402052985303293d, y: 0.5003619813050091d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443559646968038d, y: 0.8724972216171362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7650301484250189d, y: 0.7913892086994977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48543900244594673d, y: 0.8827309144437399d), new NpgsqlTypes.NpgsqlPoint(x: 0.12321473109366665d, y: 0.947210398850571d), new NpgsqlTypes.NpgsqlPoint(x: 0.006575718711059886d, y: 0.7106190233031127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9632276815447467d, y: 0.9285487214878257d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230415342630569d, y: 0.29597186942020826d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838987515574989d, y: 0.47533230896368994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25287033428119765d, y: 0.980116490294355d), new NpgsqlTypes.NpgsqlPoint(x: 0.5283460159895549d, y: 0.6981750029048852d), new NpgsqlTypes.NpgsqlPoint(x: 0.06827327644110504d, y: 0.4202618607615324d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6630817695468414d, y: 0.9632859804080406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5438940670654383d, y: 0.9217647264318554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961920081196809d, y: 0.48926166087392153d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5097684514846836d, y: 0.6338238134755813d), new NpgsqlTypes.NpgsqlPoint(x: 0.685748789973957d, y: 0.2672849928116996d), new NpgsqlTypes.NpgsqlPoint(x: 0.025592129127057106d, y: 0.35106368579943614d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2086846135073852d, y: 0.002592189204346451d), new NpgsqlTypes.NpgsqlPoint(x: 0.6164624224578492d, y: 0.2935883375302589d), new NpgsqlTypes.NpgsqlPoint(x: 0.3244608879485327d, y: 0.06586176647651032d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1297196881422381d, y: 0.39593763105677626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747041768403825d, y: 0.31005290823730014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391414027385181d, y: 0.7141331175387345d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5157862971651795d, y: 0.9183227360552892d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114938859084929d, y: 0.34306467504965343d), new NpgsqlTypes.NpgsqlPoint(x: 0.43378346040243887d, y: 0.7457334949189476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6749609559634142d, y: 0.3987242471432174d), new NpgsqlTypes.NpgsqlPoint(x: 0.4455528146651305d, y: 0.09817347138380328d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605757521120827d, y: 0.858362014252303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6117891316012513d, y: 0.7340610230712985d), new NpgsqlTypes.NpgsqlPoint(x: 0.38024350971306475d, y: 0.4840735224533109d), new NpgsqlTypes.NpgsqlPoint(x: 0.5637492393803297d, y: 0.43434235020550416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4419947918178502d, y: 0.20855359642050075d), new NpgsqlTypes.NpgsqlPoint(x: 0.010231697034413845d, y: 0.3289017628321429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7109378625205279d, y: 0.8898918570304848d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 191,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6283461670946371d, y: 0.19372500842894158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802465780371421d, y: 0.22886336058971846d), new NpgsqlTypes.NpgsqlPoint(x: 0.20086387389326354d, y: 0.25410759730350685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5006903636386093d, y: 0.49511048706673655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014821428957835d, y: 0.1424493808943631d), new NpgsqlTypes.NpgsqlPoint(x: 0.921212848841301d, y: 0.8911600017376808d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08863274822775202d, y: 0.47013591771171725d), new NpgsqlTypes.NpgsqlPoint(x: 0.2299321886548793d, y: 0.32177293363717285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158732071445357d, y: 0.1467407471912302d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9966007576015004d, y: 0.15087483061161944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5487226667187096d, y: 0.04621904787012465d), new NpgsqlTypes.NpgsqlPoint(x: 0.21287729981108605d, y: 0.8327080198313962d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1316997844731984d, y: 0.5151754986490903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236476255247795d, y: 0.12151645153168777d), new NpgsqlTypes.NpgsqlPoint(x: 0.31661078392188813d, y: 0.566424492443675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39420445273468985d, y: 0.1424583553083394d), new NpgsqlTypes.NpgsqlPoint(x: 0.16363290072912096d, y: 0.7373314234135826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7697679661528979d, y: 0.6447955201190264d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24297880834811536d, y: 0.13686575515660648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878706259645055d, y: 0.537391093983229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936379837496005d, y: 0.6799512275249168d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9415802106488569d, y: 0.33845503516251985d), new NpgsqlTypes.NpgsqlPoint(x: 0.931355558082489d, y: 0.623444943862621d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962490158392392d, y: 0.4044672774958451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04520500640206804d, y: 0.10691259931848252d), new NpgsqlTypes.NpgsqlPoint(x: 0.2822436378327139d, y: 0.9079819598666299d), new NpgsqlTypes.NpgsqlPoint(x: 0.7495559277600373d, y: 0.18636053665106356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3159148735801287d, y: 0.14987935268582087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886708711450578d, y: 0.96103485778872d), new NpgsqlTypes.NpgsqlPoint(x: 0.7399683842660172d, y: 0.2841284638590299d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09473133100325704d, y: 0.9157170900703637d), new NpgsqlTypes.NpgsqlPoint(x: 0.14218122664195088d, y: 0.7424136810638539d), new NpgsqlTypes.NpgsqlPoint(x: 0.4820822079466568d, y: 0.48152396613270154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7566035340498745d, y: 0.21846646495209843d), new NpgsqlTypes.NpgsqlPoint(x: 0.013035892277143413d, y: 0.16165904071369952d), new NpgsqlTypes.NpgsqlPoint(x: 0.1678705716393789d, y: 0.7854861826741734d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2791094967394664d, y: 0.17590362361644896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797791059487105d, y: 0.893814063281162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172031292661063d, y: 0.27287608176833433d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08531829328956708d, y: 0.8898356731866911d), new NpgsqlTypes.NpgsqlPoint(x: 0.6105339988583744d, y: 0.29819126066844104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5168411761489575d, y: 0.3916008357778491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7993716063752966d, y: 0.8724222238192345d), new NpgsqlTypes.NpgsqlPoint(x: 0.58330603929056d, y: 0.1962953048379662d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054850840674622d, y: 0.0028761517248581114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.988017436506046d, y: 0.06259715126781218d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975474064421164d, y: 0.416281865827273d), new NpgsqlTypes.NpgsqlPoint(x: 0.10970959470663089d, y: 0.8889966655173774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6631776802459022d, y: 0.9972287663813222d), new NpgsqlTypes.NpgsqlPoint(x: 0.16305815118575506d, y: 0.39239721155566265d), new NpgsqlTypes.NpgsqlPoint(x: 0.6010412291456763d, y: 0.9405754446493207d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 48;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 4, query1, 48, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 1, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 86, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 4, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 144, query1, 62, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 25, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 42, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 162, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 102, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 25);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[30], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[31], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[32], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[33], false);NpgsqlPathpathArray1M.AssertModel(models[27],_testData[34], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
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
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI), typeof(NpgsqlPathpathArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                await ((INpgsqlPathArraypathArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MI>();
                var models2 = new List<NpgsqlPathpathArray1MI>();
                ((INpgsqlPathArraypathArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpatharray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA), typeof(NpgsqlPathpathArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                await ((INpgsqlPathArraypathArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathArray1MIWA>();
                var models2 = new List<NpgsqlPathpathArray1MIWA>();
                ((INpgsqlPathArraypathArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

