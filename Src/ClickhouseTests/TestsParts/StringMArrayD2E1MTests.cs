

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
    Id = 5,
    Value = 
new System.String[,] { { "qcyawtqcwsdryijufiabkc", "vgulxkwwlgyuutkfhbllyacw", }, { "alex", "ghgwomhmkjwtuadnaljevax", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.String[,] { { "qiplyfeunjqokekbmof", "mrkchevnsbbp", }, { "ykflilcoytfktblmktvbdbxqnc", "mhetcqgapmvhprepseac", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "jrnqtbbniqkunhhrqd", "nabjnpldqyobgiw", }, { "pnlsgfhdrsqibphuxkhcuk", "tfv", }, },
},
            new StringMArrayD2E1M
{
    Id = 6,
    Value = 
new System.String[,] { { "fmmyyoybilnyimtbsgrukeregqa", "tnhaxebykht", }, { "svlnckbdgnobbgtqknhnywcgyhes", "lxervnknatmssxgkwjahe", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.String[,] { { "uoenwljsenk", "os", }, { "hawtdygtrjnawiitnaeclw", "iiqrtvcnffbvmgcecwsdsraenxs", }, },
    NullableValue = 
new System.String[,] { { "gfvycdihaknnpjukwmciqgabjg", "hujuwcbpvxshg", }, { "baudjtvqsoqniycmnsvi", "shvfkmikopoymchf", }, },
},
    NullableValue = 
new System.String[,] { { "mwvsnckvbraiidyjttcgmx", "breujdnfusrlabynj", }, { "tianoqstbvthxkok", "jegcmwrdxwlinetyjcq", }, },
},
            new StringMArrayD2E1M
{
    Id = 7,
    Value = 
new System.String[,] { { "orgoelmxpdibklappkxme", "pvvn", }, { "vxwflemolqvwgrodfccjcbqc", "iltwjvexmjcaeuxvyjtd", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.String[,] { { "lawxtbancoxe", "rkggigwomvhxfgstrtgh", }, { "kdmhbyxdktwlavwokdbbotbyqjpef", "eykiomdbfbrnkwuglm", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ybnewcrwygkhoalfc", "cqrmgg", }, { "qqtngcpbeuylbdye", "igiflruihjyfqjr", }, },
},
            new StringMArrayD2E1M
{
    Id = 14,
    Value = 
new System.String[,] { { "fkihjttylobhlmgeohcagtxuydg", "udu", }, { "kjkgmowitcwrdsw", "qjdnoyey", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.String[,] { { "tcqwftx", "dfnemdsnsdjgypomtvmfjyfftm", }, { "vqbdjusmegsiafrpaxmmpl", "xumxsuwshiarmoenpscmbivhmff", }, },
    NullableValue = 
new System.String[,] { { "luojlcjfntitrgdnxrespnbwjsj", "xjlayjckxogvhhtiwkurijsgr", }, { "vnahmcoeokptetavymjuqndcm", "xelahdwevkmjfiag", }, },
},
    NullableValue = 
new System.String[,] { { "qgnhduxqakxfjmdlyjkyj", "w", }, { "awbsdsm", "", }, },
},
            new StringMArrayD2E1M
{
    Id = 21,
    Value = 
new System.String[,] { { "rls", "jasgahl", }, { "nsnipssstantxfkntoelw", "yffsvlwdgcsjokytponpxl", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.String[,] { { "ssyegvpsqqrumtlpajdekluppgv", "cixq", }, { "vhxdjolyttmuuum", "l", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "vnekfslusejfwjwrkdh", "gxygppgyqssvjpmr", }, { "srngpnmya", "aa", }, },
},
            new StringMArrayD2E1M
{
    Id = 29,
    Value = 
new System.String[,] { { "dxqljelnmxsqfioyhwl", "fjaqqoer", }, { "obfsm", "", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.String[,] { { "xrvhmhkkdvdqhnagf", "mmsmbvesnexkaunibxnqidefq", }, { "pmmbfaukomiocadadnjixndmuvyfq", "gplstrgxmkvpdwadqev", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "fmyuxrertcxdikhikbugjyhykhjab", "iswynhghbqaxnpfm", }, { "cqqaqdhfvcorvdrccf", "qpcatjpuapswiuhwgflrvx", }, },
},
            new StringMArrayD2E1M
{
    Id = 32,
    Value = 
new System.String[,] { { "muetvohbuprnw", "pkfmxfyqrvrowupoeqhxvf", }, { "mn", "dfpgjcwyacjrfctmfirmlycmrfuxo", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.String[,] { { "fvbcwupxu", "nssdqfygh", }, { "nyqlgfycoahtvsvqotunjdyrpvo", "wpcrrdsdcidqwm", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "wrhioedwq", "iqgorn", }, { "jyjfrjdc", "xqychttntkajqditcuardbcxqukgx", }, },
},
            new StringMArrayD2E1M
{
    Id = 37,
    Value = 
new System.String[,] { { "", "ubpymjoyteibgvrwmqwtoeoaoqb", }, { "dg", "boscuoljaowanqxnfauubknud", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.String[,] { { "fhpovbmdgsssylky", "kougolaeflwxafkaxwaokrbgaie", }, { "ncpxjkffuvduokvl", "tnacjptywmxwomtkalfnbsshsukkv", }, },
    NullableValue = 
new System.String[,] { { "phjwqkjxjvoldniifnuxq", "mjoluaepxymnscp", }, { "lv", "clbftiuprl", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 41,
    Value = 
new System.String[,] { { "hlrxilqjskptttvq", "olmjslxsiioyuxuxyakcvlv", }, { "fbulnlbjmqvqeetuwmuuk", "sobeydaft", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.String[,] { { "uowmwumjft", "hxqvqympxghisgunflchejhvwu", }, { "ompoljuvalctcubukpjyowrtarmc", "xsgmwjoohulruwwiewn", }, },
    NullableValue = 
new System.String[,] { { "ksfumd", "gmbfqulxioxja", }, { "um", "qarqcuegvfqtlda", }, },
},
    NullableValue = 
new System.String[,] { { "ghxivxvqpedytbkisei", "envelnamfeqiesucncvmwtdmkws", }, { "kkgig", "ugfivbthlopdlbnxxrhyurg", }, },
},
            new StringMArrayD2E1M
{
    Id = 47,
    Value = 
new System.String[,] { { "jgdmbindlp", "vvabp", }, { "kgkyogmqxjpkhiqgmnvjymrmkig", "puudfvsaogrpmpbdlwfcd", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.String[,] { { "efbtdyhbrpsylq", "q", }, { "xmesvfnygnbvyns", "fujnydftpcdqbykmp", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 56,
    Value = 
new System.String[,] { { "jcokvmh", "pbmbghpgwyyswmddqmdixrtkpm", }, { "lkjyt", "ana", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.String[,] { { "cjxirmqqxuxpvcakabbjpkahro", "wj", }, { "vbbgdqugjs", "nitppbivyitymltkir", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 60,
    Value = 
new System.String[,] { { "jxhiatmhwsbdamvjfughqoyyjcmlj", "ylvfkwkmbrxkqjyqaxsaa", }, { "tapfiaafuv", "rbjxpkogdc", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.String[,] { { "qj", "carkqniadtnwt", }, { "nsxjnfhhxxnjtcavpkxllurkba", "byufrkuullciatmvmxaa", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "qjpqmfglfq", "exlplrwgxgjpsrxshr", }, { "ynqvbl", "mibybetfinkmtvpkhiv", }, },
},
            new StringMArrayD2E1M
{
    Id = 68,
    Value = 
new System.String[,] { { "wlcbgapexhfevvhl", "dhnelgqweppao", }, { "uvmxddwoyxtxpjkdotvdtjsqb", "fwkuojwx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.String[,] { { "gxsalgwbsrx", "yyvnhxcc", }, { "yjvfyvr", "iiqltgqurgvyk", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "octjegfymetghmcnvqsqjx", "aafafi", }, { "", "rrkxqyl", }, },
},
            new StringMArrayD2E1M
{
    Id = 75,
    Value = 
new System.String[,] { { "udvkjfkiktwnsrvds", "maayadefjsygtnfrpdxxsmvigebtd", }, { "", "mtcqkjwwimcprlw", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.String[,] { { "eoqpqwplkswabnrkblsnyen", "wrsjbqowthykl", }, { "dhatpb", "ptiganqfpx", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "lsmaaxphq", "yki", }, { "cwfweossyacfssteqlnojaqs", "kuiyp", }, },
},
            new StringMArrayD2E1M
{
    Id = 79,
    Value = 
new System.String[,] { { "nekuwtlxwu", "hemocg", }, { "yytoflsamjam", "smtcjpircr", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.String[,] { { "qwhi", "ifogk", }, { "ruhxprhpjdha", "qcbetvsuaaefvgdbtaeokpsi", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "flxwudvywejyqedpqqebnvlkgtfjg", "cmyiasiggadwn", }, { "ctotvsdmhvxulmwmkfhtsaegai", "leuhudxjsijfmgasvhas", }, },
},
            new StringMArrayD2E1M
{
    Id = 82,
    Value = 
new System.String[,] { { "kkjcrvgi", "uwscsksxnpdxljhkpe", }, { "ddryeugibcksntkodxr", "ufdslhhqihsdhunsfdexotmksaf", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 98,
    Value = 
new System.String[,] { { "cujaawhxqyqlxhsydugm", "tqtbdvunbuijautewmpwievw", }, { "ytpxpwmn", "lpqhqameg", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 88,
    Value = 
new System.String[,] { { "lpykitupgslctddcrr", "wxpubtlmlytmrfdvte", }, { "newscrlvcmdibitgsoyleirvyphiu", "qerunbdcyyohxivio", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 104,
    Value = 
new System.String[,] { { "nvcocupfyejcefliqwe", "wduwjamgnwknadab", }, { "omytqneg", "xithuaeqc", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 95,
    Value = 
new System.String[,] { { "enyhpqqrurkrvai", "yyabjg", }, { "wvglapvqhhbckt", "oisqgdbrtdouhadqimon", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.String[,] { { "txhkdmllcmousguvvv", "onn", }, { "kprlhvmlylssscmb", "y", }, },
    NullableValue = 
new System.String[,] { { "gphj", "hseypvyei", }, { "hmpaemqmanyfk", "vbwvlmen", }, },
},
    NullableValue = 
new System.String[,] { { "xgqgndfqesdavxcobd", "amvtffxxrbpjrgwkmqrctvu", }, { "p", "rydqmrljlxewooqpvuseqaojcopf", }, },
},
            new StringMArrayD2E1M
{
    Id = 102,
    Value = 
new System.String[,] { { "mrnsyccuuibobehohahglspj", "xacievsgqtwaqq", }, { "vbcgbr", "cwrqxuqiiqtupdyqyhtvldxwghy", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 118,
    Value = 
new System.String[,] { { "oyadboqqhrocrhc", "mcvvabpl", }, { "wi", "vgtbkradubaxquqkh", }, },
    NullableValue = 
new System.String[,] { { "uyrpxpxitiwfmtydhf", "keupeoxvtiajkavddcxpu", }, { "llsqjrfogmxgdkiuljbgox", "huthxerlvlovtsx", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 106,
    Value = 
new System.String[,] { { "jltaidtqqywmemibuqtuodnl", "toorqt", }, { "brtxpjvxhxhyxxtb", "mwxfkn", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 125,
    Value = 
new System.String[,] { { "tksw", "dtnjueu", }, { "nbrlydwvhwjnkduljmvnkevgguhl", "ehtmmna", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 113,
    Value = 
new System.String[,] { { "pksckgmbkutcgxwktofdgsw", "wputifmkq", }, { "kdaxnh", "hmyshsoifkggqptqvkhywwpjavv", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 131,
    Value = 
new System.String[,] { { "ccd", "lsklwxwutelhmeiqlnuvxwhbr", }, { "bijfwnchlxsqqtakmt", "tfgoplsaf", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 118,
    Value = 
new System.String[,] { { "g", "dakfebhvpxonmawp", }, { "duldinwehhdkfnpywfeam", "pryhivirkrtdkdbwgkkqyfrlfqbi", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 140,
    Value = 
new System.String[,] { { "wbtayfivlpoy", "dksyrmdecyhcvbmuesfcycxxffce", }, { "kugaf", "yplopdpxwsjcmmygmbvj", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 123,
    Value = 
new System.String[,] { { "hdcwb", "rjtlwapnmqr", }, { "eiylvp", "cmwxxydbvxmntjgetbblqfhim", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 146,
    Value = 
new System.String[,] { { "cw", "rqy", }, { "rupcthmawmslcabon", "d", }, },
    NullableValue = 
new System.String[,] { { "aiyakvrrkgbauunubtmlkwxovkus", "axmppurnaxvonbfunwibyrwrf", }, { "egd", "hkpksihys", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 125,
    Value = 
new System.String[,] { { "kqxebxmnndwilbcstudqelmlma", "fydueqtnxwvwhgcgtnj", }, { "mcpxivkrnj", "qhwrdyeypi", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 155,
    Value = 
new System.String[,] { { "kxefwmyfcjhggyrthryhcfdngyqe", "mewlmgqxypjkdwgyyoaekgnoxim", }, { "wjqnykfcqqfgjvwggdynevlwsmjyt", "wmidrnhytueejiayhqylbd", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 127,
    Value = 
new System.String[,] { { "ag", "gaspqunljewruoqtkgwfgfjpna", }, { "lcbliwwtdgxjlslclxmhnhtd", "hhgmsylbeinypryitgdwd", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 164,
    Value = 
new System.String[,] { { "", "fjyiwge", }, { "jamxwdgspfvybbpuvybfaifjmg", "p", }, },
    NullableValue = 
new System.String[,] { { "duxbiowofpfxgujwgfrdbuixu", "qhsgemhicjopqnuydgf", }, { "b", "qejxww", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 129,
    Value = 
new System.String[,] { { "gfuvhaix", "ygtfwpifluqs", }, { "qftcpdxpfi", "hgxourpmykxsvg", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 172,
    Value = 
new System.String[,] { { "kbkrnnvsfxx", "c", }, { "fyqmwmdmydple", "ggsrptsegvj", }, },
    NullableValue = 
new System.String[,] { { "jvjtoibguy", "fodvika", }, { "wnxnlxnfpjmcegnikqkge", "inpcpfu", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 137,
    Value = 
new System.String[,] { { "", "qoxtle", }, { "laqxcduvsqmjypacfjybvfutfplcj", "mkrwgo", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 176,
    Value = 
new System.String[,] { { "ofpctawuqqwdnxoyknkbjafcbpdt", "", }, { "xapjhouqdwr", "tjddhrynsttogcjtdp", }, },
    NullableValue = 
new System.String[,] { { "eybafgupmm", "juveddylmqtlkftueaxmxpoljq", }, { "oludvfxgjdsjleqgvogyfhscmewmo", "kisutixkf", }, },
},
    NullableValue = 
new System.String[,] { { "fyilappdkookneaibojbpk", "vnwckmpqvuruucjhhcbjqvr", }, { "qygaaqyesqxxcnndarxx", "ehcwncosesgbkcfq", }, },
},
            new StringMArrayD2E1M
{
    Id = 143,
    Value = 
new System.String[,] { { "lrvsaivsyrsycrqybqcsrrxe", "gmki", }, { "viyomlfixxvveloeelcxsxeddemv", "oxxdfd", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 181,
    Value = 
new System.String[,] { { "nbugssk", "", }, { "blpkbro", "dcthfoxlmyqypnjqllkwcl", }, },
    NullableValue = 
new System.String[,] { { "fyfuhthlrbg", "immvidgvje", }, { "ullotupauaxdibptga", "bcwtgcx", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 146,
    Value = 
new System.String[,] { { "hhydhnpsbp", "ocjs", }, { "wmbw", "bnsygowxgdtaulsgsnsdxdmfejwuf", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 190,
    Value = 
new System.String[,] { { "sfl", "gt", }, { "lhtikmuajifabmhsnapdxxqiqbuv", "cimndlqggvsg", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "blkvpexljxoajvxjooouccywv", "hboumewyep", }, { "ivvgnrmyodnpnvuurhsrnsa", "ssoktytqyuuxymoariajidjcvymqi", }, },
},
            new StringMArrayD2E1M
{
    Id = 150,
    Value = 
new System.String[,] { { "cfcrbgapjm", "ospclcbckxurhmjopxsbmcaqnvxh", }, { "degvxolbgnt", "jcqtguqumolssdjngdkoyaqbrou", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 197,
    Value = 
new System.String[,] { { "nsgwknnyjmiqvmgenobsknchrgj", "xmuwardwylnihkrvhfojmpa", }, { "krbupqhbicbt", "wqbixmhjorg", }, },
    NullableValue = 
new System.String[,] { { "eycstwudgokjkjnwvkfw", "iciwr", }, { "aacwyyjt", "", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 154,
    Value = 
new System.String[,] { { "dtpahugxvev", "gcaqggc", }, { "opqrjjxvfao", "ens", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 200,
    Value = 
new System.String[,] { { "iogycobnddssetnaohgogtqidc", "odkthhxkepbosomi", }, { "vbsfhgtdgklhgadro", "sjaewgjqkorinyxaddtabvt", }, },
    NullableValue = 
new System.String[,] { { "owhiiupfycuihsnmtupmnkvydma", "efhwkdndtlenreqeiordu", }, { "sywavaiiccmjshojei", "sn", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 158,
    Value = 
new System.String[,] { { "ypkrmmgasbdrsn", "bfcbttxjfrifim", }, { "adimnwykf", "mrbbmitnagoolxfwtj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 208,
    Value = 
new System.String[,] { { "elimjuhjxlcbjwwsmvfcy", "freikfhggappqbdojdja", }, { "ofvbkf", "uyfiwvemqrnponexwrc", }, },
    NullableValue = 
new System.String[,] { { "qimgyhjoeeq", "qeeomrc", }, { "qtvvkrmlgslecxx", "qdlopmbfgw", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 166,
    Value = 
new System.String[,] { { "wyoatvgosmwckls", "atpjkdhgqenerkupalgqn", }, { "ywoyurhjqyggsqlxuehcsusdlhqj", "oltwxwtpsjogutlwdylrg", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 216,
    Value = 
new System.String[,] { { "bprrllykqvhvsriiffcelu", "acxblbaqiqjtmxhjuejftmupvrcjm", }, { "", "mxtihuxjrmpwmqtlffvpbxmdot", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 173,
    Value = 
new System.String[,] { { "pcmhjuaaqqucgylttukkpnwcfot", "h", }, { "drgsikexytfqsjic", "sveittgrwpacrhuweh", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 224,
    Value = 
new System.String[,] { { "qqvboceqvsfspeqnjf", "fkrkmwqnrywjimcixmtdqcjt", }, { "vbldwwfbxajykfrgowebmv", "jwp", }, },
    NullableValue = 
new System.String[,] { { "", "fwjdwke", }, { "buefu", "qnkituyrggaljtvipllf", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 178,
    Value = 
new System.String[,] { { "megjlehpkakakloitcstyhiw", "gghdtolhaxv", }, { "yysmxmtddht", "wdavdufodfpoi", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 233,
    Value = 
new System.String[,] { { "yrdk", "hcatkrvdisvikscuueavocjdhmugn", }, { "sybplspikqstylvdmorcjlnggpwc", "lgfewmweuhuncwqgdefo", }, },
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

