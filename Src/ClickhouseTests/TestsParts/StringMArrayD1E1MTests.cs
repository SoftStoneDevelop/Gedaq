

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
    Id = 7,
    Value = 
new System.String[4]
{
"lkexbfquqpyptyxf",
"efqtvkxome",
"ogrwloomxq",
"txqkuhyakywat",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.String[4]
{
"uaayiwsqpaofnpaxkhuw",
"kgkfwpmvuboanrflaiqhs",
"jpnknplwphl",
"bunllnxwoshjhprxjfem",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"tgfynjrbytqd",
"wcgbvwblifsjvryddcei",
"wbmwtcuctfqx",
"thqsoxaixuyvigvxtxfwfqbhay",
},
},
            new StringMArrayD1E1M
{
    Id = 9,
    Value = 
new System.String[3]
{
"lumlonfuinimicgvnrrm",
"adruxgdw",
"mnrqberntxrkxioiqqefftk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.String[4]
{
"ygxjswrsqwwpnjrrnqj",
"",
"waqbktxmjkfkdvu",
"upytdqvutgpslfwfrkb",
},
    NullableValue = 
new System.String[4]
{
"mmsinxhggtpnlmrmvdxbevgl",
"vwldfxkgjbvnytdk",
"nkmojrxaqsewuhhrdqvpyg",
"wqy",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 15,
    Value = 
new System.String[3]
{
"",
"bfkhc",
"msjsxlgnvpehubcqg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.String[3]
{
"qouvmnhrwp",
"uvippjntfleibkombait",
"vo",
},
    NullableValue = 
new System.String[3]
{
"tbqpuqngbxwsnbxuoiuxoqkis",
"yrkriy",
"hvvssbntgcbtalnyclnfpn",
},
},
    NullableValue = 
new System.String[4]
{
"s",
"qgkhjietxl",
"mhn",
"qeiwfeqibtymwwhjqx",
},
},
            new StringMArrayD1E1M
{
    Id = 23,
    Value = 
new System.String[4]
{
"dmlncymsuwqqu",
"fwpjpglunujf",
"onjqpfdnh",
"wfyfrodrvaf",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.String[3]
{
"sslvbsughxqeaeletadd",
"bksivnocrxyhvwtcdtql",
"vpimcpoa",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"tcapshftnasrglitfgmujfkbhvn",
"ajqtsyhxywovuaxrun",
"srsqalvwxppcglh",
},
},
            new StringMArrayD1E1M
{
    Id = 31,
    Value = 
new System.String[4]
{
"hftndhtuyyfkooglfcwppndwtfb",
"hgwnxmobdkpkkugegkd",
"fsdddidfie",
"wfursybcmqxhudtel",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.String[4]
{
"fdamscbsckbafdgbmma",
"s",
"uypjxvamquwttwjrvtsffbvp",
"nyxbacbteevmuyideefgecvh",
},
    NullableValue = 
new System.String[4]
{
"jnt",
"ktjboittmjhppuujnxpildb",
"tnkr",
"rprblxl",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 32,
    Value = 
new System.String[3]
{
"lttsfsitvy",
"kuxegaaeybndbgwnfuxnst",
"flhjk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.String[3]
{
"",
"jwmslldwjrcrwo",
"ndboexkrat",
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
"ndfxsiplefuohhbi",
"gveucdhvddkqqpicboqwwbj",
"g",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.String[4]
{
"fxmapwhyhpksntqhdttjonhk",
"auupfctksgshbckgxqge",
"jjhdavqqqqdpvjxrqsnfjabqv",
"jhyqfjwewmaqps",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 47,
    Value = 
new System.String[3]
{
"akvrrdsshfnnsouvovotviddl",
"nmbjtweejiddm",
"sgouwrkbfxptjsvwuktqpt",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.String[3]
{
"mnntlkrttqcbwjgsnkmv",
"cnogumdspoisr",
"loovtayvsoeclddnbnty",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 50,
    Value = 
new System.String[3]
{
"bovhwkrxca",
"bnwuxdotiicafcbc",
"xyfuyedkrgq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.String[4]
{
"cnskobofgkcxmssxskjjrljivnuhg",
"fjmbnutyxis",
"hjdaxgsgnarrhlq",
"metxfvaffsdqpw",
},
    NullableValue = 
new System.String[3]
{
"uiix",
"uen",
"qy",
},
},
    NullableValue = 
new System.String[4]
{
"kpbrmwanwqulptdwfftm",
"oijalvbaiivofpoqtturxk",
"",
"hxmjdfqhclahrqmhuoxqvpdyxy",
},
},
            new StringMArrayD1E1M
{
    Id = 55,
    Value = 
new System.String[4]
{
"smbxvcwnylano",
"relgfeekhjxrrxeieedepxpco",
"ypqyqtnacqaypxncigankxstrvg",
"lpamcwpe",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.String[3]
{
"rjflttffrtlosvjxptos",
"mdsfnbrh",
"gsgcixcrcpapchbktbmkoboaamds",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"jmnjfhagkityeo",
"huwg",
"kqdksjbmcwixhqcugcdaqdhyjg",
},
},
            new StringMArrayD1E1M
{
    Id = 60,
    Value = 
new System.String[4]
{
"sjyrhtntmkisoft",
"tlqctoapk",
"idwesbjforyl",
"pwcejgctbgnuvojjskagfiov",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.String[4]
{
"wgrprkopxbyxjdmtmycyntjsvbhb",
"kyfssnj",
"mfqqtwgentonll",
"ycltslm",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"fsmbslwggjixyjogk",
"qbrdqssbnechdlqcsmsoqvllacvy",
"hmdoetesiopjfcje",
},
},
            new StringMArrayD1E1M
{
    Id = 69,
    Value = 
new System.String[3]
{
"frtuhqtlktmrvmoi",
"ukuwxymtsffepqhgvm",
"odhhxueuqpugajyyvousqiph",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.String[4]
{
"xnvhbjvjtmnbiwjqfsap",
"phfsuuluhqpkrrlosmlteugmpn",
"gvlw",
"atwvelvr",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"hayffcyyvhwyuwpkatul",
"kevoccxxbdr",
"gpxcdrsuvwitjbcspwnc",
},
},
            new StringMArrayD1E1M
{
    Id = 78,
    Value = 
new System.String[4]
{
"empcspemdwjfiryrianygscdxd",
"khirqhih",
"hitglwuaypycbakudv",
"rofvvwsnb",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.String[4]
{
"ajxhvmcrmnceqyxbkarcrwpojl",
"xaxtgptkulljwdm",
"ae",
"pqlfanihq",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 87,
    Value = 
new System.String[4]
{
"btvewxkamfchls",
"aodixaejrlkqwwvwdpkhpybxhtvyt",
"wcuxsoijnyyrh",
"jlrnrrkrcnqme",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.String[4]
{
"kygxkuxouppiooaxjxkgnoffaflet",
"ikbhatjgklgssuxvvxgxxlklavh",
"rfacioqmboqwokoybbbxhjewlyqh",
"vfmhssytoltxrack",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"agp",
"rcfwtiecvgtuqkhhkxpjxvmcs",
"bpfhetlajfpevrme",
},
},
            new StringMArrayD1E1M
{
    Id = 94,
    Value = 
new System.String[3]
{
"wmgonucxdlvtoe",
"vqryqtyhrmk",
"rpwkqtthwtjdkwelnhdk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.String[3]
{
"oqwukphkhcxftcjrp",
"ofvpfbcjqeatewlyhntnx",
"kimvgeympfpkshoiwqeinvagltj",
},
    NullableValue = 
new System.String[3]
{
"qjxkwwbbswqwuyndjka",
"vshbhi",
"ovmfsmaosafej",
},
},
    NullableValue = 
new System.String[4]
{
"ghyg",
"ueioqhxubiqgubntekxseytbssrwf",
"oujvqdf",
"cssvfxqipgyhvkpgecyjkifj",
},
},
            new StringMArrayD1E1M
{
    Id = 98,
    Value = 
new System.String[3]
{
"ynewoh",
"mkjiwpyqsq",
"lqcyanlaomhakqykg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.String[4]
{
"ioajxgxgwoeyelqylvrobwisvp",
"lqwmaqplvwhlyxya",
"gqcgcnnxerbdiemkbmhcgfpjbltsl",
"qsbdhfjiwqamqlfembimicbsteo",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 101,
    Value = 
new System.String[3]
{
"ipnokwcghbtwempscefdthcpg",
"iuyppiwno",
"j",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.String[4]
{
"guon",
"ylvb",
"iltqvswpowuy",
"reojhveukhcfsjleexgbpsdxlabb",
},
    NullableValue = 
new System.String[4]
{
"jmakrctxhja",
"udmdipgqvtbwxuqlr",
"hkgstktwolkmfdssgr",
"lnkhcktc",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 107,
    Value = 
new System.String[4]
{
"uvkwffmrprddymqykd",
"seib",
"ggyesmhpvjixtqbcthrtlottm",
"bktoffqthhqgbot",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.String[3]
{
"oibhaeynyssusmexvetk",
"prfsjuqulwtpgdwddil",
"lisudxjntokuqxcgutpopvxtbfgro",
},
    NullableValue = 
new System.String[4]
{
"dtdyqxyaphgleihvofliso",
"fkhdgolmurb",
"ahcqscwqfhdkxjoobsfknfky",
"bbpvqi",
},
},
    NullableValue = 
new System.String[4]
{
"rhqhd",
"mkipgh",
"ocwjigvdfg",
"twfys",
},
},
            new StringMArrayD1E1M
{
    Id = 115,
    Value = 
new System.String[4]
{
"hpvqq",
"btvdtnadxpcvacyxtkf",
"gahguoqtoc",
"kfnsbwxfhwtbnpvll",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.String[4]
{
"omjtufta",
"xiepdchvnnatghi",
"ofrymnmyamhoubcsecasm",
"dofjvxcnxsw",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"surwjyyxojj",
"encayayjebdif",
"vaeifrvvgergmmescpdx",
},
},
            new StringMArrayD1E1M
{
    Id = 117,
    Value = 
new System.String[4]
{
"oncmkruxpwl",
"xesdshtkg",
"ldphyamvnpmekcdjxibmurwjijrf",
"in",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.String[4]
{
"gbur",
"agawcrsxt",
"uasa",
"rgeplfsflrrni",
},
    NullableValue = 
new System.String[4]
{
"gttiqbcofqjxg",
"snscohhqisdkwqbmfjm",
"",
"lhguaqjwvi",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 126,
    Value = 
new System.String[3]
{
"",
"dbtvpcosnfucalwlvu",
"cfhccyso",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.String[4]
{
"iwheaybhgsxvcyivel",
"vyhyihkpmbipo",
"sg",
"kdrugbirxnbvrgmjxxkeur",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"hdhvgokldcvfjjxrwy",
"laahnkbyddxv",
"wsoigufhgdy",
"qvksohifq",
},
},
            new StringMArrayD1E1M
{
    Id = 127,
    Value = 
new System.String[3]
{
"bretanjgwwefvcjytd",
"halqduplwubifqpwsmbr",
"pcxxvnlwousdgpwoa",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.String[4]
{
"fukgwjnbguvbarrjccfcaugmltu",
"ygprvnjtvhohgfmgnieqgf",
"vxoehjobaivnnmkcmkwgbnwswe",
"mbubrulsuhnkuklqcuwuq",
},
    NullableValue = 
new System.String[4]
{
"bgnlg",
"ts",
"omy",
"ljpuflywhqxfdljcov",
},
},
    NullableValue = 
new System.String[3]
{
"omrqmsgnvjiomwtsvk",
"ebaxhxbpjokywmkglpjevpi",
"xmouhacxrxxgvpvsgqeptxoyfcmcq",
},
},
            new StringMArrayD1E1M
{
    Id = 136,
    Value = 
new System.String[4]
{
"kwaiukolcaiewbggncpkvpocj",
"n",
"ljuyxkjpgnqihiilbsqibjimeq",
"nytgurwud",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.String[3]
{
"ltdnycjrodwmkiv",
"kvuc",
"bohlwcbrx",
},
    NullableValue = 
new System.String[4]
{
"qxsnt",
"mptedrrjpuxaveinvimxxcf",
"mfdtuwophmrexfpxlkelbuavf",
"fjhquvnltqqjefjyend",
},
},
    NullableValue = 
new System.String[4]
{
"mrwgkmetsyhkmucioikkyk",
"okndbiuectnpvwpahiw",
"jvtqsylqcbpolhopoukihklapvy",
"dksueemwdhsistecig",
},
},
            new StringMArrayD1E1M
{
    Id = 145,
    Value = 
new System.String[4]
{
"mweakswipxonqhbsqhepwtnqs",
"smdjcqonbomptroarmadudpi",
"c",
"sbrcjuhgojqytx",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 108,
    Value = 
new System.String[4]
{
"uhojbyl",
"uuqaiwbdqqgextrbevfplrot",
"maemwigshbedjoj",
"niufxguxjahbmb",
},
    NullableValue = 
new System.String[4]
{
"",
"qxbhffjlwifekbkghotf",
"esuhkvimkolgyme",
"",
},
},
    NullableValue = 
new System.String[4]
{
"fdhcnhqabnsqnggu",
"bxdwlcjpavdt",
"wqcl",
"",
},
},
            new StringMArrayD1E1M
{
    Id = 148,
    Value = 
new System.String[3]
{
"hdxhffdg",
"ttiwoltyslgybep",
"umhvobteegdwqnrtspam",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 117,
    Value = 
new System.String[3]
{
"tugaueaafv",
"hejfdyvbocdlleitcyrqewla",
"osqlbmbj",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"n",
"trivmtpkfxuinraaurgioc",
"pg",
},
},
            new StringMArrayD1E1M
{
    Id = 154,
    Value = 
new System.String[4]
{
"b",
"oq",
"fgxttcsnhcfjqfkyvxhw",
"vcaalitpdagrnxwjushlhty",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.String[4]
{
"uuo",
"ppkul",
"vwiujiycqi",
"tlpfqfexuqeycmmphwxfjnrvmvrj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 157,
    Value = 
new System.String[4]
{
"wsnd",
"oko",
"yskarsguwwctwotyghnr",
"fayntdc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.String[3]
{
"nmyrqiehtbmipxuualeqvyilv",
"avi",
"hop",
},
    NullableValue = 
new System.String[4]
{
"vgswyykaqslbhpkofxp",
"inxtokjtc",
"gwbtrsyaumo",
"aravadk",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 164,
    Value = 
new System.String[3]
{
"ehxnpwcdwhdeisu",
"lloxtil",
"kupmf",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 130,
    Value = 
new System.String[4]
{
"tvdnsdiwcdbqk",
"jrk",
"",
"uldwvsyifu",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 166,
    Value = 
new System.String[4]
{
"uffvkjjfarjaaymewvqtu",
"sjalucsysui",
"ouyntuixrgqfmkyrpkhgbkvxfsk",
"rtuigjcc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.String[3]
{
"nucad",
"wstxpho",
"neqkjoejbhyveuomujj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 171,
    Value = 
new System.String[4]
{
"hccusv",
"hkfeoyfyhvm",
"",
"klpkfnk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.String[4]
{
"fcx",
"auoyyuxciyqsnjuouegitryag",
"gapcyohddwrjcfmuvryaactqjkag",
"ie",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"dnrnpxtrxtillovxd",
"l",
"kmfomfxpsylarkkghrsf",
"jhawxvsrrnhtjjxwyglh",
},
},
            new StringMArrayD1E1M
{
    Id = 177,
    Value = 
new System.String[3]
{
"yirrhxlnlojpsx",
"xy",
"a",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 150,
    Value = 
new System.String[4]
{
"rfqjqdoskcjqv",
"pswqafadk",
"lirfkw",
"dttnarejcifviecbxxv",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"jdffenxvlbaqarrgikxxmhotnmuf",
"ibxwssjrllxtfhwangncntgjj",
"stvsucbicogrtj",
"rdqnlbdcljxqdjdyygfsyyyheity",
},
},
            new StringMArrayD1E1M
{
    Id = 185,
    Value = 
new System.String[3]
{
"nhqhpxtkdby",
"pwuxruanuasidobskjsrivanfgmd",
"dcdcqbabwlqldusb",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 153,
    Value = 
new System.String[3]
{
"jittdnpryiwptl",
"bbxxytduvlqqgidmfxoss",
"vwwuhxocxwkmrv",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 190,
    Value = 
new System.String[3]
{
"jni",
"ddrjmjid",
"m",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.String[3]
{
"yptkmorpljgajyhkisnmivxglrse",
"bsgeafeavoxdsb",
"xxkrdsieyqgkslvxlpgr",
},
    NullableValue = 
new System.String[4]
{
"cqd",
"pjrblscnberdigshkhvsyd",
"aaq",
"ktawjds",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 195,
    Value = 
new System.String[4]
{
"f",
"xasyrdfqcmurvhdptib",
"bmdydumarhorkhtw",
"awvu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.String[4]
{
"wphrfdrrsrpqovwnwttlf",
"lfiaoxblwgjyqjnoytlcdttkbm",
"rcsqm",
"x",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 198,
    Value = 
new System.String[4]
{
"pwefnqiibvdyddresw",
"dnhwnumvubkomwfiyldniucymyk",
"iyuipwqdqtj",
"fixubpnudmlyvisremgfuyljxju",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.String[4]
{
"xtrkqe",
"mjomelhgdraqlmbrfvshqnvun",
"oayaqnabpbmosn",
"oewacddwjpclecqbgcx",
},
    NullableValue = 
new System.String[3]
{
"xvequgbdvjeulbcbpexmvrp",
"khusp",
"xhtsevjknbghasqkdnuaultgwoqs",
},
},
    NullableValue = 
new System.String[3]
{
"orqrbgncgkingvrwhupqpvsvw",
"kjxkadbik",
"jyldmdjg",
},
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

