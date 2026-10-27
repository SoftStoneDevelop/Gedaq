

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
    internal partial interface IStringMArrayMArrayD1
    {
    }
    
    internal partial class StringMArrayMArrayD1 : IStringMArrayMArrayD1
    {


#region TestData

        private readonly StringMArrayD1E1M[] _testData = new StringMArrayD1E1M[]
        {
            new StringMArrayD1E1M
{
    Id = 1,
    Value = 
new System.String[4]
{
"tnaavbsqgohvor",
"uaucokooauosd",
"qgbdrmyfqainftx",
"xulebrgxsjgapbuqdxxfdrfrdneb",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.String[3]
{
"liufonhuwbjoeuccseakbrabkhiu",
"wyrtrokddvccwjejseje",
"bpehoapgpstbjgfhivmxsfwdksvva",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"nddaqjriwafuydcnuhvxgnibm",
"pwqtmhvjkhfxddfclvtgyosbyjo",
"cphtoosakdlgko",
},
},
            new StringMArrayD1E1M
{
    Id = 9,
    Value = 
new System.String[4]
{
"fdmkalrmcpaqwxn",
"dbp",
"edccd",
"eqirrxiyvbtilfbgcdxtv",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.String[3]
{
"ixgqx",
"hksgg",
"uvbbklinkynhuisifscuvvblocm",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 11,
    Value = 
new System.String[4]
{
"n",
"xktnogiqfw",
"otnvoihafulnyurxqlltwa",
"ev",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.String[3]
{
"jvfrkpmhfg",
"ohwsnwgywwoakpuncofigwqoi",
"rkmuiy",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 16,
    Value = 
new System.String[4]
{
"jvibtplfljqvenhnppswh",
"wljuraijvadoeud",
"bidsksrlklc",
"",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.String[3]
{
"tptlvbvntciffjcwvql",
"rctwxbxdfhacoshpamufhfx",
"xmxjtevhqqkqmjdirmrfbdhejpmui",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"bkqbkavnvfruhsjargpuh",
"drdumxsnlimgdcekethvahhwkucg",
"og",
},
},
            new StringMArrayD1E1M
{
    Id = 18,
    Value = 
new System.String[3]
{
"irorgbtuwloltbahcmesccqshnki",
"nswxymdccpjls",
"dndlxoo",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.String[4]
{
"bkyhyjcykehmvelcrayvgl",
"amyrgfinycvvothiarianuqvl",
"afjilqrfjhtvknqte",
"vvu",
},
    NullableValue = 
new System.String[4]
{
"gkqnkhdvlbsojyopqsqkw",
"hjysjayxuhwjve",
"crbf",
"smnlobqmmplvna",
},
},
    NullableValue = 
new System.String[4]
{
"qhxqojgp",
"lmiohqoovdm",
"ikcicfs",
"eliwtgtsntksyrpvslnwm",
},
},
            new StringMArrayD1E1M
{
    Id = 20,
    Value = 
new System.String[3]
{
"cvcmnvf",
"nojrs",
"siisfg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.String[3]
{
"eddieepilylysujsvaff",
"llxqichs",
"unxtqlpikjkdtyobswimfth",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 24,
    Value = 
new System.String[3]
{
"omicwpbbmqenwnmpvgcojt",
"jdgrigdpjbhwnufjxqkcwoqwb",
"tpmumt",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.String[3]
{
"uhkompbnkawusnt",
"pcghkomwaupfeeaweowk",
"lvjmrqeieydmjkali",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"yjvikfoefmmamyhoibrnppsu",
"ibv",
"j",
"mr",
},
},
            new StringMArrayD1E1M
{
    Id = 26,
    Value = 
new System.String[4]
{
"hnxt",
"lkh",
"",
"d",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.String[3]
{
"uugfag",
"ejhkanppk",
"ogsbugeohxkynuyd",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"rlvxohor",
"ourcckxaiavqpkprsxrvprqilpa",
"nmybnewfh",
},
},
            new StringMArrayD1E1M
{
    Id = 34,
    Value = 
new System.String[3]
{
"frgnjlqyvvfwmsnxuupbhvjfrugn",
"sfcewntpsgpqkhkfodsspsg",
"xurtajey",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.String[3]
{
"uhoetsaugppvxgjelt",
"klmcwifxflaygaf",
"anjsivulfmiokyhthykepqtoabd",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 41,
    Value = 
new System.String[3]
{
"",
"moqtqhkbgsikoint",
"wvespttbdoeo",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.String[4]
{
"tdogyxkgcpc",
"hk",
"yhimedrt",
"ucpksivnyouxdjpx",
},
    NullableValue = 
new System.String[4]
{
"rfeti",
"xyvkqinbqprhgqfecosrsekryq",
"xjpecgwrraqejbhgonbcejlctmkl",
"cwvyjansljffs",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 50,
    Value = 
new System.String[4]
{
"mdmnif",
"jwrpifykijhqenvqbkciyl",
"psutbtymavbqsefsjvyckeccttf",
"wsssifhpyfwreniwpoxc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.String[3]
{
"iprptiupyiiexuhhhjxj",
"mhpdyfkvol",
"ghscymyfmltidgmriqvksiadbwwei",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"rcbvpa",
"ak",
"uiboaifnefmjweebjrooowkm",
"ppsmpxokcdaiqitfthrlpsncl",
},
},
            new StringMArrayD1E1M
{
    Id = 59,
    Value = 
new System.String[4]
{
"qgdtg",
"nwjwqtsgtqdgaareh",
"gs",
"fpvjyfsai",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.String[4]
{
"seycqh",
"fmtoxenfitvbcwshgopjjvpcdqt",
"nnrpihmflbkikestwj",
"tel",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"nokotvobjlarwn",
"mpousodrqdbvphfuxakgcrab",
"xinylqswaj",
},
},
            new StringMArrayD1E1M
{
    Id = 61,
    Value = 
new System.String[3]
{
"pliveoaxioplrwgllrqpcs",
"asuoplmcjejjih",
"acju",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.String[4]
{
"nkvcaigsnsofcovia",
"jtkfutcakwytamowl",
"phqwejpgnwkfuyruhhasoqktoqa",
"hsngfdcicsqafkswqvrs",
},
    NullableValue = 
new System.String[3]
{
"fsmigmodrowdhqbmdyfjt",
"sgpluvaw",
"husetoorvylptguanyj",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 67,
    Value = 
new System.String[3]
{
"vmmmea",
"tyymktxh",
"jhwwwnjonxcjien",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.String[4]
{
"vsdfadgspueelmihnmgseuf",
"msecxplwx",
"rcukyinfxtdwuoogoowbqxpiq",
"jjkmscsjstjkmondivblo",
},
    NullableValue = 
new System.String[3]
{
"",
"nplarbieoay",
"tfqbdkxaimis",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 75,
    Value = 
new System.String[4]
{
"uxnnksiposvfrkuqpjiw",
"udhrhkr",
"gjxjxmrlwqbvqhheufmwtnwmewem",
"yjiaihqvomjektgvbbruxoro",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.String[3]
{
"kvslnrhnxied",
"dnokhalhnrgpcthkovbtvfweptuev",
"kvsutnabsqx",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"ssysixgpw",
"paktboygtloanuidkkfqtqgjmelf",
"pilcm",
"pcbnesdskmwknynolcv",
},
},
            new StringMArrayD1E1M
{
    Id = 77,
    Value = 
new System.String[3]
{
"evrqlmahcdvwhunhdahewdjr",
"hglnh",
"pgnuppdbsimffmmhonbiygc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.String[3]
{
"bdjbccseqf",
"cjprpakmhfkvqgstiwtrrrcwnvlp",
"ebcwowwygvcponraohujivn",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"dixilttxviifvmuulppcpslq",
"fhwasapsyudhgd",
"gbccsmnki",
},
},
            new StringMArrayD1E1M
{
    Id = 82,
    Value = 
new System.String[4]
{
"pthcrhvjfqqysrhqdxxapvdjcle",
"xm",
"icohfdy",
"sjwlxpyuqd",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.String[4]
{
"l",
"slkgbnjo",
"gpiplavjxhsewoveidxkawklb",
"",
},
    NullableValue = 
new System.String[4]
{
"gxelgnuntti",
"yceapqhoegtegxsrhaqj",
"ndbeeceyq",
"fhs",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 90,
    Value = 
new System.String[3]
{
"okmjfobe",
"gewmb",
"pfumeysyajbgyyasosjwjfncr",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.String[3]
{
"hqubedbwhatf",
"skefey",
"ovblbsdqsnoca",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 98,
    Value = 
new System.String[3]
{
"mgfkncsuyhagpkknyymnfsehxsgm",
"lirfkndcmkmbyeh",
"hhmcdmjqykwcqawvgvouutemn",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.String[3]
{
"fkocpdycmwtxowtxuwhcabuqgjs",
"hssp",
"irxyemseqcfsqjdfgap",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"d",
"mmvngtosjcbfta",
"mnjnejejjfqdad",
"tqdaqqanchqlwcqvh",
},
},
            new StringMArrayD1E1M
{
    Id = 102,
    Value = 
new System.String[3]
{
"jfxwdnidwyyitn",
"euwhuvpfgltxrcyfmrbtbw",
"g",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.String[4]
{
"acwaixoksrwcyt",
"xj",
"wwplnulujigfavxedpcjhbjaf",
"vksgcfpdic",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"jyiruanyalrigygfjlmoro",
"phrtwftkqnjhoqdqnetstt",
"",
},
},
            new StringMArrayD1E1M
{
    Id = 105,
    Value = 
new System.String[3]
{
"nt",
"nxkwnouxesaegqtu",
"efnuxxmxhncsu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.String[4]
{
"teaxkkhvluhqurfpvsrunvjxcld",
"petmxvtbmerlbxprxonxyt",
"",
"h",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"hlvasguwou",
"kguotqpw",
"ktqlkuuish",
},
},
            new StringMArrayD1E1M
{
    Id = 111,
    Value = 
new System.String[3]
{
"arrxceikmdbelarld",
"hivboixrsflsesonjgqneyquosh",
"noxycgrqjgea",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.String[3]
{
"riojjhcclksnnq",
"fnovtaxwtxlhhtpehotfscfxrkd",
"fjmgyvvhofxqpeyos",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 115,
    Value = 
new System.String[3]
{
"hw",
"wyhtend",
"tbqeymkgequakxdpeswyuchhrqdj",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.String[3]
{
"rsvckdkgsoiandqmwjebibfo",
"pyojkpyquejxrt",
"uutcoeighhpbyndegogwwd",
},
    NullableValue = 
new System.String[4]
{
"qtynmvsilspx",
"gghwkvxwwwxcpu",
"v",
"oqhvagrmxum",
},
},
    NullableValue = 
new System.String[3]
{
"dbjmxenycwhe",
"lphdyujlx",
"eqkxuvoon",
},
},
            new StringMArrayD1E1M
{
    Id = 124,
    Value = 
new System.String[4]
{
"opdogdbjctenegdbutebrqeyw",
"iyhdfthsqrqdtshcwfc",
"b",
"vxntftxfrwyjjte",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.String[4]
{
"qoekqyb",
"exhdbckbwhwqfvl",
"skaqfvd",
"ykhlmeeck",
},
    NullableValue = 
new System.String[4]
{
"ehbkbllkpdgvbstubldd",
"wioyytejdwjrxtyuqoletia",
"cvrywaiijfeqdkuvdhrcyxjuagqk",
"",
},
},
    NullableValue = 
new System.String[4]
{
"qkggqhfdxjisnbtsorsvctqfgvad",
"jdhjnndtnhqehcgwvtmwoyrurqwux",
"kyyrggnsvxaenful",
"xlemgpilkjcymcfhyjln",
},
},
            new StringMArrayD1E1M
{
    Id = 133,
    Value = 
new System.String[4]
{
"",
"fcfqlsoulwihm",
"xdkaofqqkmocxvrojcjon",
"qsyoygcljaydcshpyditphqfcd",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 122,
    Value = 
new System.String[3]
{
"cggays",
"nbuxbjwqwayihxvejpxwirnf",
"fpxtvvgaqftcfxvx",
},
    NullableValue = 
new System.String[4]
{
"jsgvfvfrnkjjm",
"ovw",
"wpoyovyvlvac",
"rvqpwxvovnfvffbd",
},
},
    NullableValue = 
new System.String[4]
{
"ofuisr",
"xhhudgntfakjmjy",
"oif",
"mllamupypuwuvt",
},
},
            new StringMArrayD1E1M
{
    Id = 134,
    Value = 
new System.String[4]
{
"yjejlrqiagp",
"qqdbmesjidwgbjcmilcuvlm",
"ygsmleehbpe",
"gjk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 126,
    Value = 
new System.String[3]
{
"iymeylnbbdjyptneevjbptfdrqae",
"oglicftyfwqwt",
"ro",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 136,
    Value = 
new System.String[3]
{
"qtqfpnvcnub",
"fwpinfmqfe",
"bwqyvvrdav",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.String[4]
{
"nrjlnymirhvn",
"wtgwrdmxsgmociujrem",
"epwpqnxuuaxevlyprcqjxrikjdhr",
"gsccgijhvsqrjsdfqvx",
},
    NullableValue = 
new System.String[3]
{
"",
"ivjnvoakgatnig",
"x",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 140,
    Value = 
new System.String[3]
{
"vljwykoxyasbnncpykcxvjetllyj",
"rsiuitcsrlshhnmxgubny",
"vslshaed",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.String[3]
{
"jhitpabxquwa",
"jorymsyhwjuytfwp",
"cmpqbnbrxwbktojssktkcyhussvk",
},
    NullableValue = 
new System.String[4]
{
"acbemotjipnqtvhqkppiqcastmmhr",
"baiirskoamocwvfclekun",
"akpv",
"sgcctnrviulwxjxnkkfuify",
},
},
    NullableValue = 
new System.String[3]
{
"jurtkkmeuyldiyadwgexpdjj",
"ijkatrhgvbxnwpeweekm",
"hkgylgjdafhmw",
},
},
            new StringMArrayD1E1M
{
    Id = 145,
    Value = 
new System.String[4]
{
"e",
"uxwdjscgyyuebrqxoaxuicmnsr",
"jpnasaejaupifbyrrkdktsaq",
"vjtwkpdycpdube",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 132,
    Value = 
new System.String[3]
{
"atggwpyi",
"b",
"hc",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"aqjgo",
"qmjmjqqnlwctchidxipa",
"h",
"oxcvrdmwc",
},
},
            new StringMArrayD1E1M
{
    Id = 149,
    Value = 
new System.String[4]
{
"",
"yvmngmeqihqttdfek",
"ul",
"brlewbcnkojccnxuvrvg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 136,
    Value = 
new System.String[3]
{
"unvsxjvymqc",
"rql",
"uigppdwdiwsru",
},
    NullableValue = 
new System.String[4]
{
"aucsajgwxlnfyqkvyjtqnyundd",
"ruhbpujtautbwgoy",
"avcsohedfcbfsiuafwomcgua",
"bcjiikcpvgttgkival",
},
},
    NullableValue = 
new System.String[3]
{
"tynulpwviieiquolwfujmwgo",
"gmwakgncr",
"vikulapyovi",
},
},
            new StringMArrayD1E1M
{
    Id = 151,
    Value = 
new System.String[3]
{
"ljuihr",
"ririhfaak",
"xipudeyumoalbxhrlukakaug",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 141,
    Value = 
new System.String[3]
{
"wojkwegueeyibaetfrav",
"gwy",
"pagqk",
},
    NullableValue = 
new System.String[4]
{
"ekehcwftxkecrkbe",
"aalnwatcotr",
"pvyqnqbjxojejjidlpuotbcjgdrqq",
"ovkfm",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 155,
    Value = 
new System.String[4]
{
"aepypqqissm",
"ayvxaevbmesxptncaibjs",
"khppascsdyhvtuchaxfqia",
"ryufpp",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.String[4]
{
"bbtwbwttrpwpeow",
"gyklgllxvkylnshxbiphjbkrcfnxk",
"w",
"iurngmxvvuvulvxmy",
},
    NullableValue = 
new System.String[3]
{
"vufptvautbpclfgdovcrxgcxqea",
"sxowpobg",
"qxnfconjbothouckbhipg",
},
},
    NullableValue = 
new System.String[4]
{
"kkfbqsttv",
"ikcacefeevrpiljjf",
"qu",
"mtyibhplseqsxdlod",
},
},
            new StringMArrayD1E1M
{
    Id = 156,
    Value = 
new System.String[3]
{
"uebijqlkmvgogvryxctrkxmrtc",
"j",
"badwpqijpbwbcrjutbtiivckbitq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 149,
    Value = 
new System.String[4]
{
"jqjymgctkwjhcxismaqslrjfnu",
"koeqtvoalerhsvyxljxtpn",
"gypsajhppyovihckdvkj",
"ccyydorikrkcllqakmkqpxqnvjq",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"cuisxbutlmxhq",
"mehalskoxu",
"pysaqsarggvneibxdfwkjlrb",
"nkfnggkokaiij",
},
},
            new StringMArrayD1E1M
{
    Id = 160,
    Value = 
new System.String[3]
{
"en",
"ghioxxwahseavu",
"mpjjjvwsjwtslcrcylwvkk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 150,
    Value = 
new System.String[3]
{
"iohbiyibnqaws",
"wfvkbnmvoghvkyiqdbdhll",
"qxhbxoaxqkhhx",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 169,
    Value = 
new System.String[4]
{
"mufpkebctsc",
"eajcteyjiqh",
"xevwhaqhpleapohmgpqjaid",
"ddbopqvsbdbcabmatfg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.String[3]
{
"bwytdllmfvhajwv",
"asjiykjauviswlrjnbxxtnuvl",
"encpndrbhndvsek",
},
    NullableValue = 
new System.String[4]
{
"pmtvrsiahdsxuxhjqqmrrivfjvmu",
"rlbgdjntqjurit",
"tafyxuvtsij",
"ryfvf",
},
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
INSERT INTO gedaqtests.stringmarrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(String)}, 
    {mi_id:Int32},
    {mi_value:Array(String)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
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
                    await ((IStringMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IStringMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.stringmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArrayMArrayD1)),
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
                    var models = await ((IStringMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IStringMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

