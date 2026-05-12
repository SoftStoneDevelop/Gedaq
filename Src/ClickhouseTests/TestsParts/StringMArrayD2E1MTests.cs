

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IStringMArrayMArrayD2
    {
    }
    
    internal partial class StringMArrayMArrayD2 : IStringMArrayMArrayD2
    {


#region TestData

        private readonly StringMArrayD2E1M[] _testData = new StringMArrayD2E1M[]
        {
            new StringMArrayD2E1M
{
    Id = 9,
    Value = 
new System.String[,] { { "mjuousqtjscrubaniingvpmw", "drutl", }, { "vsktlsswsefmwlclm", "foypnbe", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.String[,] { { "roevxmxscegbahawehjevxhcwduor", "acpawmb", }, { "ooehjs", "fbxxsegwnlgiibvqorg", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 14,
    Value = 
new System.String[,] { { "lfwambjldcwaqvwjlfccqtvotx", "xfswemjdhlpqmetgfxeeuipthapxl", }, { "otbaqnpsmtdmxabyqksigyb", "nje", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.String[,] { { "nminsatjgwawkfmkqv", "sljyjcpmetdrp", }, { "mqpxkpumq", "ayjvfjukufclsnwnwwrwcp", }, },
    NullableValue = 
new System.String[,] { { "fhoxwfukhdrxtvkvkgj", "dlklxkgafrsusfmpmgxon", }, { "kocqqvmhfjekdvcwjqe", "lptxiibrtliuadpuugep", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 20,
    Value = 
new System.String[,] { { "s", "cfwuqpimrhdjvgcgsqtkwtkxvll", }, { "ejaxqvbsgxuyy", "ovlvkmriaywiblcdnfyos", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.String[,] { { "sqwimrvykfrunsbrprwnxnveh", "uq", }, { "", "xgppmvqsrxxjegprygquetskmpro", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 28,
    Value = 
new System.String[,] { { "rinjcgjyxfrtcqgmvuugpttrevilu", "rekwcjrrjpo", }, { "de", "dpce", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.String[,] { { "v", "tbrpjaypfpujpxcdfol", }, { "kmung", "uhcp", }, },
    NullableValue = 
new System.String[,] { { "ewwcyr", "", }, { "bixaqutuauqpyvqvfffggii", "jof", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 33,
    Value = 
new System.String[,] { { "egwrcivudpuohmr", "ynusoxysnawoestasqhuyhkom", }, { "ubxgtfopppobqqvclmfekh", "pcehuvulecidq", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.String[,] { { "cgwfctdnucrokaivjthfqtm", "nfnepuquvhrocxyvxynitqp", }, { "oln", "ggngjdnbqjmhevuai", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 40,
    Value = 
new System.String[,] { { "ihpkdvdpihmqbujmjcp", "", }, { "wl", "vyfbniowwwjilyieuilorpakkj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.String[,] { { "byvjwpnmwbgihocytxxdldyh", "wqd", }, { "", "eyfcevq", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "lobj", "csvcmkiqgqhwcrayxwdaoph", }, { "infkbfwvfh", "xsioxqeduptlkqppm", }, },
},
            new StringMArrayD2E1M
{
    Id = 46,
    Value = 
new System.String[,] { { "hmwfilemdc", "fblfbudufrhjvedbusdyvucmml", }, { "fgehmytomtg", "vhfxmqvwxfdfdgksilewm", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.String[,] { { "hfqewehvkqjrovgtvh", "akdwamhxptsxujgjegnabqxqlbrqq", }, { "sxllgo", "vorikbgrrubadn", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "vtvbu", "nsdmlojecmlxvuqyo", }, { "lewhfxytoixdwqxuty", "ijcplxycfncbgwu", }, },
},
            new StringMArrayD2E1M
{
    Id = 53,
    Value = 
new System.String[,] { { "bdpaldvj", "cv", }, { "e", "gqlkpengkphjais", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.String[,] { { "amnspnxnotlhxdjv", "ldhonj", }, { "orfuajqpapxwerxhms", "bdjhocmveunbhpux", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ublhtupbomugtwbkfimqutdwme", "sckgugr", }, { "vluovnxtrmlfm", "chjg", }, },
},
            new StringMArrayD2E1M
{
    Id = 56,
    Value = 
new System.String[,] { { "nlmowhcrvcjfvmtboevhanmpymd", "rcadtrrfjreoxf", }, { "cddyjcqefivnvl", "wqoqkbncnu", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.String[,] { { "ofjaacvotiujnsftgrbcjoy", "tlniveufwjjbkqpva", }, { "tljfcftw", "bbsyivovyrdaxgyirssfvdlxqbywg", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 59,
    Value = 
new System.String[,] { { "kby", "kkfqptdyuowjeuhtgyasqyp", }, { "kgiq", "nfnxhthsqrpveixlfliujxnlvim", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.String[,] { { "shuoolpypmbjfetdulomn", "orartdkqtoytlysmdcypaqtdbkp", }, { "vqntgeoglpfvjtmvqgvvyvineb", "mpptdtwlnnchcrpenlcshweofwyu", }, },
    NullableValue = 
new System.String[,] { { "mquidshkdttowfaejgofwapcjna", "lnqqnglxdptmquurwvnh", }, { "lnajydufsgafqqkbciqxjytscggl", "alvaw", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 67,
    Value = 
new System.String[,] { { "mibryekdpihavcjqdmefgsji", "yxtaqywwfeebcujtmwuwwnovcx", }, { "qjdlvtaxvykydtlwiwshvbytafl", "u", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.String[,] { { "fskbmpgkmbbpoa", "nbwueyngsnvqtpga", }, { "nckgpcmbuckgxnsstq", "jhgmetatjucuqtcmqqefcefpqofa", }, },
    NullableValue = 
new System.String[,] { { "furuge", "emxuhd", }, { "lvyxtghsveodvjoegrofqrpvvn", "iwrlbopemi", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 73,
    Value = 
new System.String[,] { { "pgp", "ybvfgexsdtuyq", }, { "vvnlxchx", "nmagyyhochojekpno", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.String[,] { { "smlt", "avxwo", }, { "", "trosgfslffq", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "dnbaeytwqluffhwr", "heavjkqkofsucoyongk", }, { "ybmhpwepgpekmbudk", "dhprjojowlmdmvhk", }, },
},
            new StringMArrayD2E1M
{
    Id = 78,
    Value = 
new System.String[,] { { "nlbha", "iwecimyndswvv", }, { "wfpvyofqxx", "wlkkntdfbncxjieyltmonjufjunhg", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.String[,] { { "", "dkspjlbjvqkcavwkdy", }, { "jj", "dyvnqbgomofubpuaf", }, },
    NullableValue = 
new System.String[,] { { "lop", "s", }, { "tbndquhejbdodhfesggqsry", "pkqtig", }, },
},
    NullableValue = 
new System.String[,] { { "daheqdxexbpnokumpaqmmfw", "kmntgssmlfsllkgddxgchclro", }, { "xvnqlhytmkkswc", "atgxcd", }, },
},
            new StringMArrayD2E1M
{
    Id = 79,
    Value = 
new System.String[,] { { "iycqmaukjwiecer", "", }, { "exmnb", "agvnsihgfhpeiotksgtsk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.String[,] { { "qd", "r", }, { "nctgtvkewry", "aiaeemshkyfmfjmcmlxrbbdwscug", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 81,
    Value = 
new System.String[,] { { "akeeclnnboyameegygptldjkbkek", "wstgyofygrdolyxlepovajbeiq", }, { "sbdjqgwxujxsbolpj", "mcpoaqhfysofobjiylasauotuxe", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.String[,] { { "fixr", "yl", }, { "cxhqawiiaeluubjvxmqewla", "p", }, },
    NullableValue = 
new System.String[,] { { "guw", "fccwofrmcxiyxmlni", }, { "varbjivbau", "eduyokuniucvnapkikwx", }, },
},
    NullableValue = 
new System.String[,] { { "", "kxfvmu", }, { "ikbfbjflqcbjrchkcnnbd", "twjfhgesjpqvci", }, },
},
            new StringMArrayD2E1M
{
    Id = 88,
    Value = 
new System.String[,] { { "ghghorohvmsmdv", "ebnbawxgiusedmqpvctsnsrmcdp", }, { "fkwnhw", "sqdes", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.String[,] { { "wyphio", "bsdewnmqbbet", }, { "psgrwndqkoqt", "vhuuhfxbtbejmgpq", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "mk", "bxbeycmpponsx", }, { "rdfneeuh", "ovbebeeihtkmkrsqrcjassk", }, },
},
            new StringMArrayD2E1M
{
    Id = 95,
    Value = 
new System.String[,] { { "qbgbrejnwibmxpjrbbnrrwv", "nnuh", }, { "rlhvyxdswixspncrg", "hluwbgb", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.String[,] { { "dtgfpjdkvccvwqk", "xmibvjsisy", }, { "igfjrbdl", "lsfaiivbvjdk", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "hisadsgullfcsusopx", "perhpcaejgbqxtlqp", }, { "dafywqgvxsckchx", "curdqlgajeiiicxg", }, },
},
            new StringMArrayD2E1M
{
    Id = 101,
    Value = 
new System.String[,] { { "upoucujulvykyfrk", "ghtbyxjtsshjmf", }, { "wpneaopdijoybqtos", "hfix", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.String[,] { { "rnmyuvrm", "rhunbxgfsyrnlm", }, { "dieoqbpbhewmliwh", "lujkgsvxtlvhxsryockstqxk", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 109,
    Value = 
new System.String[,] { { "rhrpu", "lrkvcccnwhasdvytfjywpbscwan", }, { "jlniddyxhwvqplot", "vxeenihsvumb", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.String[,] { { "dwxmxhfldyysnt", "vyfwtlxgxdcoolgwevedny", }, { "rvodctcwmuepxloeiwdroybrv", "scofevkv", }, },
    NullableValue = 
new System.String[,] { { "bue", "egnoqslm", }, { "ttdxkaambqdabtncxrmuwmewkr", "ewtuaywuq", }, },
},
    NullableValue = 
new System.String[,] { { "rwstpf", "orjscycgmtimilllcngmp", }, { "", "tugtlkcsjlhbj", }, },
},
            new StringMArrayD2E1M
{
    Id = 116,
    Value = 
new System.String[,] { { "qbttjlgibausfmq", "xhhndmnnbpckbngrnsriagagyhx", }, { "hysywbfqwwabokioohfuhcmvadh", "ktheyabl", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.String[,] { { "jgcegfegjg", "hwpljuhunvylfj", }, { "mafefylekkattumjvsbbsea", "n", }, },
    NullableValue = 
new System.String[,] { { "wfwborpky", "wnikrjdkvxgfoct", }, { "msablwuwhpsie", "b", }, },
},
    NullableValue = 
new System.String[,] { { "h", "prveojdktphjpjvy", }, { "mdbfctiackbrwxkhw", "gfsldmuqvjorddlykejtqi", }, },
},
            new StringMArrayD2E1M
{
    Id = 122,
    Value = 
new System.String[,] { { "hwbrrhewwvrbhxmqqhicrmm", "aadtccy", }, { "atreaecwbbkhiicfatec", "lebkxf", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.String[,] { { "igptemcjvlrokkjyrxsg", "axlfrwnmeclcw", }, { "ixgpqwowesbjeg", "jmiikvjd", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 123,
    Value = 
new System.String[,] { { "xbcoqaqophankmvjfspfj", "pgwrcfiqfbcpnn", }, { "xddtloyokqdqfjbyjaqvbv", "kvgjtsjmmvcgtyayg", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.String[,] { { "csjmoemrqtjragduv", "cwbtpk", }, { "jgqfipdngkdjnxbbh", "uiqm", }, },
    NullableValue = 
new System.String[,] { { "twblodenxjh", "hncjxupa", }, { "tnmp", "dkuiuaybs", }, },
},
    NullableValue = 
new System.String[,] { { "tqcdgfybsysilxkras", "ugychoohecaowqpadoustdjba", }, { "yksenevfhkqojkreexpilchtyxjgn", "", }, },
},
            new StringMArrayD2E1M
{
    Id = 128,
    Value = 
new System.String[,] { { "wwkupjrwcgludmmqflstsagoi", "wpvqjbooipx", }, { "iagdvtwxwkhkayi", "sphsruljduhfyki", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 89,
    Value = 
new System.String[,] { { "tqbpfkhmuibiu", "yvydrfcppdhjooafmkwd", }, { "vklxpotiqfmvsghhthcesthix", "oyinecsuthj", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "wmvrdhkyno", "dqtgcbnnrv", }, { "ikunfbjxpcgxgbubwj", "lqlyqdmksnsudocybgpcbhfyxej", }, },
},
            new StringMArrayD2E1M
{
    Id = 134,
    Value = 
new System.String[,] { { "ptlqqmhgybkjppxigtadbwwuj", "qodoftrovnej", }, { "vansouyutpmyjy", "fsyqwblutfxd", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 97,
    Value = 
new System.String[,] { { "d", "ovdkppqyeiswl", }, { "kajaugdoadwsyirjfj", "mpvivvimrhtfgtfhrvsqb", }, },
    NullableValue = 
new System.String[,] { { "kketaslcjcmrnq", "ocidmeltf", }, { "wab", "k", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 143,
    Value = 
new System.String[,] { { "ypp", "deicstxqgtmtejripuniwp", }, { "ritnvbodnjroqwbehleyfkqkk", "myiqjhqfwieauveidwpmwkimsbup", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 98,
    Value = 
new System.String[,] { { "rywjthrr", "hobdcww", }, { "dbbcqgrsalcr", "w", }, },
    NullableValue = 
new System.String[,] { { "kikvumimemrqkvidfbucbasff", "oxsbfsmhvfflriptafg", }, { "jwovqqqefxrrlrusesghsyt", "hdikifgawlumgfxjfqqdtqxq", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 147,
    Value = 
new System.String[,] { { "npebtkyqqnqhwyixpe", "cslpcgkvqlsnnhix", }, { "fq", "ebeebccdsihdahihcslvee", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.String[,] { { "ipenur", "x", }, { "jamasxxfhgqar", "rctjhrjnkoqvtldximhwfaqvy", }, },
    NullableValue = 
new System.String[,] { { "jyrfonkwqccdjmlakgnalsrj", "nbkjjvixjklqcl", }, { "ihnfjvrmyasytwhgbjeebo", "rolajnjfleq", }, },
},
    NullableValue = 
new System.String[,] { { "byhdfbnpfrlfkgpsduvsglq", "rdyqnduvnitwldgtrvs", }, { "bkae", "sthbunkegndggovwpjydpscgqv", }, },
},
            new StringMArrayD2E1M
{
    Id = 148,
    Value = 
new System.String[,] { { "jielfxq", "armbteji", }, { "dmvwyrxdmlihtmoklfr", "ow", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 106,
    Value = 
new System.String[,] { { "otkn", "aisgvpvevexn", }, { "jeaeeskdadoptgscaijnjp", "jnhsp", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 157,
    Value = 
new System.String[,] { { "acttrvugerjfuyqp", "muybedljrmwct", }, { "ogktgwfapwxwgwscgdlbtfj", "iaxlmoujvilogwcntuc", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.String[,] { { "fparxqlsrivtfigsdqqmxoemexulw", "eibtk", }, { "", "gg", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "rcqlnpakqqgxyjknqoslov", "kbvh", }, { "mkmkmhorvoywmtq", "apwagknrpivqjripwleuv", }, },
},
            new StringMArrayD2E1M
{
    Id = 160,
    Value = 
new System.String[,] { { "itvvironpwypt", "xmimsehpgpio", }, { "xfciiaqthsiefod", "scdlsmmnvpgqvhwpxymcwvja", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.String[,] { { "xguivsilktqwotycf", "qmemvehsn", }, { "peaufjmgjclpguslwruqjbc", "eqdrnuhhlfeonwvfgaqmmsic", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 167,
    Value = 
new System.String[,] { { "kvqbb", "jyfafvjyh", }, { "ddjijoatanmdtyfbxswhqivsgeo", "ffivnxoxoyicxbml", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.String[,] { { "", "xyjuaeyutkippfaayqxvtkvu", }, { "pberpmenydyycjh", "jeucuihpixjogpuwqsxeqcqm", }, },
    NullableValue = 
new System.String[,] { { "aruhksjjbwbcxobmfskmttmax", "hidujelkpwgvu", }, { "wvetfwerkumpxndlvjwxvrfowya", "lxnhfrykjwgflionkbgsjwdevit", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 170,
    Value = 
new System.String[,] { { "mfaggxlphirrtmuf", "lmpxrqtfhgqbqvwukwj", }, { "kdkffg", "jlmxomufkiaymfbjplwmjex", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.String[,] { { "gwxw", "uvv", }, { "qrunardagdfn", "kpgxufrgcxwassym", }, },
    NullableValue = 
new System.String[,] { { "r", "oykxtxhqjhfskvjvuijsqejautti", }, { "tqcro", "huwprjmhuhudbaxygduppbng", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 176,
    Value = 
new System.String[,] { { "nogdmkiqonw", "dqf", }, { "bgflobcecelpdjq", "bqtx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.String[,] { { "dcjxgfjwiphy", "pyfhygiuncjwbvwdldykgxyi", }, { "simobkhnjvdvcfvtqgdqhfhkbsa", "lrdejawohmm", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "caiqqbpbvwrelkjhimavjjaljo", "jy", }, { "tuwvcrinokhy", "saatyaakcrkpbdlfv", }, },
},
            new StringMArrayD2E1M
{
    Id = 182,
    Value = 
new System.String[,] { { "", "wucngavfcoteootxgxrlttumlv", }, { "", "cdvneenamj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.String[,] { { "ikuhqelsjhqbps", "pgxmry", }, { "lndrqyregoycljajkwasti", "ejncarrmhdgdk", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "kixfafcliyftxbnglbncoyxyuyl", "hqmijhrpbnuybumgsvuipoid", }, { "uwvvs", "voscafmgwcmyhdf", }, },
},
            new StringMArrayD2E1M
{
    Id = 189,
    Value = 
new System.String[,] { { "wdc", "", }, { "yxqplejblp", "ijwcepdgjxut", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.String[,] { { "gccwpfyicbg", "csiwpfvituindxnemgrcamqhydkug", }, { "plhjdyqasisgjwsk", "qnwnbrusiklohwmvvdlyuyk", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 190,
    Value = 
new System.String[,] { { "pdyjysvbx", "ahnonfqpuuffpyvlcriooiegyltr", }, { "keueplpfwdqmuebdtfaxbtuytvp", "nyeapkcmedfrhkshqtxgmc", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 166,
    Value = 
new System.String[,] { { "", "mettgsmim", }, { "qygeexswyxylbxieeiiokljo", "hblnmkyavhomaye", }, },
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringmarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(String))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(String))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IStringMArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IStringMArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.stringmarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IStringMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IStringMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

