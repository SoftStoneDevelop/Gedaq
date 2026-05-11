

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
    Id = 6,
    Value = 
new System.String[3]
{
"lfjdnltedugokcderrignghegdfag",
"aiswykkpskinmmehliqqhhyg",
"pwmphlorbkkxpiakcgfrovipew",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.String[3]
{
"itprxy",
"qh",
"",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 10,
    Value = 
new System.String[4]
{
"jwxfmkb",
"kwbrxgacrvmojh",
"ppmnxmemutpf",
"",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.String[4]
{
"vfudx",
"vchidhgoyvoykpuieydpfretvv",
"kltddpeqxhmcgh",
"axosghexrpajex",
},
    NullableValue = 
new System.String[4]
{
"jnohbhypuvxkyxhuuj",
"opxawucmdpnpqairoeppcff",
"rxehofofsjybquvfxlhjmry",
"evenwfl",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 18,
    Value = 
new System.String[4]
{
"cfhfrhqxdruioscs",
"hfytqbnomoehopregjttcesw",
"jtvrmienrdjdssddmo",
"nukrlfuacyjpg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.String[4]
{
"duybjalwuhovmpbsptdn",
"agptwlxsvdwsukobmydhkcbhrfrqy",
"efusaejabgkbxt",
"igwyffakiqb",
},
    NullableValue = 
new System.String[3]
{
"or",
"payvpshau",
"rtsbsxqpcl",
},
},
    NullableValue = 
new System.String[4]
{
"mqejlqgppuocxjjuj",
"stdexgxh",
"bprmykvm",
"phoqmonslidtuscbxmu",
},
},
            new StringMArrayD1E1M
{
    Id = 24,
    Value = 
new System.String[4]
{
"exnplnnuvbjymyrbi",
"tqg",
"oneqsnjrpp",
"nmiydqrh",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.String[4]
{
"fgrujkerlarc",
"uiewcgvtkqiehldyinwmatxojddpw",
"hkclyoehknkiicmdwykgajowf",
"pdcyvcwajhgdnabwhbniddyyuqtwi",
},
    NullableValue = 
new System.String[4]
{
"dtmwuvpkwcrhxstsinitmrs",
"uqa",
"yganrfvaxxykutlf",
"qsnjhgxftldkph",
},
},
    NullableValue = 
new System.String[4]
{
"aakufycdurwaix",
"thanjijgleaxl",
"kokiujl",
"udejtpsedcy",
},
},
            new StringMArrayD1E1M
{
    Id = 30,
    Value = 
new System.String[3]
{
"rjhjvxfdqhphknovkjj",
"ktgsqihhxl",
"hlmfbjnuvtklebmixyjpxqbbbknl",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.String[4]
{
"eeupysffowelbo",
"kitvcexofhhv",
"",
"tehy",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 36,
    Value = 
new System.String[4]
{
"ryssljdcdrx",
"cafndkstyepakddxgeipdp",
"osjgqquionee",
"n",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.String[4]
{
"eytktiggkcwnoo",
"pvbeb",
"lsy",
"uspkyjxmil",
},
    NullableValue = 
new System.String[4]
{
"s",
"phoreibnxiqfjwaga",
"",
"jxewswoqdat",
},
},
    NullableValue = 
new System.String[3]
{
"kpsgmqx",
"yt",
"ffrddqjoerbqksxew",
},
},
            new StringMArrayD1E1M
{
    Id = 43,
    Value = 
new System.String[4]
{
"hwitn",
"raagsejypjmcktpeojiws",
"gjmhrgobxgifjtvbftvldywpu",
"noakwpulsori",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.String[4]
{
"ybasxcmgnnqktwnvcahgvictydmx",
"cvasaqrcwkrghbxbqyvuytqaxdgcf",
"arpaumliugwmtkbi",
"pecgtcuopythtdtiimseodfse",
},
    NullableValue = 
new System.String[4]
{
"upjqudyjihtxuxrmmgswqq",
"qorwugdweirgqcxyfyb",
"ltkpe",
"qegiljpgafvkwgbcxe",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 46,
    Value = 
new System.String[4]
{
"ermo",
"cmiangkkppyacdjonxuepwby",
"xpyepwpmycqcvrklnn",
"tmqxgxwabdanlygpdovvgkkgljo",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.String[4]
{
"xbwdsfr",
"crqcsstt",
"lov",
"qfgaqstmlixdnqjnnp",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"qqsumlnncqxhocpud",
"waeqsqlkpmvnb",
"aqybn",
"jpvdhwppvv",
},
},
            new StringMArrayD1E1M
{
    Id = 55,
    Value = 
new System.String[3]
{
"ohxdbvmstxtwohtm",
"goflnbfthjavmhayhewanmw",
"lieahjhlmdxlerepjkratkivv",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.String[4]
{
"qtsfyofrdabflupkmpormjrg",
"jnsibomugafsgqqsprbewdmywl",
"hyjspuduyhgpnt",
"qvjhgyqtsbelq",
},
    NullableValue = 
new System.String[4]
{
"vlwhlyk",
"qtpcsokhtk",
"xwvya",
"qwumxriai",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 61,
    Value = 
new System.String[3]
{
"cahwpwonrplglkqabbc",
"isan",
"tvyqdlyfmchk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.String[4]
{
"v",
"ytloqxpffufavluonvxqb",
"xqrvgbt",
"mwhlwabxrlputiwxlsdpmlbit",
},
    NullableValue = 
new System.String[4]
{
"gjilmrpppcmbwllx",
"ibxfmhwusgbhwvgbmmnijeuaskbb",
"fqwdiohrrkeqnfmvu",
"dwktenkfjlyg",
},
},
    NullableValue = 
new System.String[3]
{
"",
"mvsprydyimuyhjjkxqsikthvroox",
"dkxgkbefouifbdqefbph",
},
},
            new StringMArrayD1E1M
{
    Id = 62,
    Value = 
new System.String[4]
{
"bgjgomomxliya",
"ivybpgjhhtg",
"whvrtuiqhmpvtvpl",
"nkyegibrbahmldqjlwtrdvlrc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.String[3]
{
"euww",
"ujnwxiinm",
"efiblfvqemxiiboxbbekwixibdwjj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 67,
    Value = 
new System.String[3]
{
"qc",
"d",
"qrafkqusxymybmofsueaymgy",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.String[3]
{
"aq",
"pvomftlbwcbatpol",
"bmsqfdtauyrwifjt",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"loqprkdguvohvtnamvjd",
"oi",
"bbxassiyqjbxeagwewmhwiwmgb",
"fgscfqlhvmorw",
},
},
            new StringMArrayD1E1M
{
    Id = 73,
    Value = 
new System.String[3]
{
"dybviodvmjjhvsm",
"wryqyughdvovaayonlnjqwixwnlel",
"kgrkjyyufplgnxktwtmhr",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.String[4]
{
"sojy",
"pxqmmmhqtfwkjwluybearoqywy",
"oascpfm",
"gaxtae",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"",
"jnypwntohytbnfmxpgj",
"b",
"qgcqjk",
},
},
            new StringMArrayD1E1M
{
    Id = 80,
    Value = 
new System.String[3]
{
"xthrlhmv",
"ydttfjxxyotaxpkb",
"wjetpdbn",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 66,
    Value = 
new System.String[3]
{
"piyfodahmhqwgnfwyaxb",
"wdckukbjewtbrlefyh",
"bnvrueqkodduflgw",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"rkfwkygboufrxig",
"sg",
"pjamwvneoetubbmqqlecwyttrlf",
},
},
            new StringMArrayD1E1M
{
    Id = 83,
    Value = 
new System.String[4]
{
"hxtowkbgygbssnjktgohav",
"rtqajeodoevbfxxgaviiuk",
"mopmtnehhma",
"ajifgxxjuffdqcu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.String[4]
{
"dstomsahgramac",
"",
"jldvliqmtwqjndrmx",
"ecphacdttewirsbmucxlqhsbp",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 84,
    Value = 
new System.String[3]
{
"vjrsvrtqwhctassdpuninbu",
"oqbnoirwoehmnrxqjtqqgogo",
"ysqlsoxkp",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.String[4]
{
"qshufqnlo",
"a",
"aelfdygadbyyeecwkytsavknc",
"errysa",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"oujj",
"bfunrxvxlrjdfcbcewxeewtgp",
"ltuawgtjh",
"odqydbhyuvqljwn",
},
},
            new StringMArrayD1E1M
{
    Id = 91,
    Value = 
new System.String[4]
{
"vhxtgahdgrvmjobxkfayfceyvc",
"airpytisambjxfml",
"",
"bkjjiggviwh",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.String[3]
{
"pwigpmrbe",
"fvkmaeyfpodlafoylagrlsj",
"akmrjtstheugadwmkoygjwnyrd",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"okgeyyxbhsuttncnjfwrl",
"wbwadniubbwioqhjod",
"bldddosbxltesdl",
"kfyaej",
},
},
            new StringMArrayD1E1M
{
    Id = 95,
    Value = 
new System.String[3]
{
"wlqfhuuumnjbviqteeh",
"auljxfduqkfiy",
"cua",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.String[4]
{
"amvghyk",
"oruiulynf",
"wbyuv",
"u",
},
    NullableValue = 
new System.String[3]
{
"olsioneltjsdit",
"mdcbyfhafu",
"kqxdtob",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 96,
    Value = 
new System.String[3]
{
"ksqvtotqjhfwftni",
"yppwqism",
"okqlscoddlxn",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.String[4]
{
"m",
"qymf",
"rxiywkuxldndkjlemxudn",
"sgsljvlhfgqtauj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 99,
    Value = 
new System.String[3]
{
"amkcu",
"onelpfblcsawtrb",
"iosrorpfksmlnq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.String[3]
{
"p",
"discaxskfjfiwjbr",
"etwhgl",
},
    NullableValue = 
new System.String[4]
{
"jrxqyitdgkvknmjgvlweht",
"xukjeomdkewaiptueipkb",
"yfa",
"fcbydithnhneyjiikrurdxldeyhaq",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 103,
    Value = 
new System.String[4]
{
"vywdgsndqrrvvvdtiiyin",
"crsbyinhmyxdhbgiwtorjkjsqvpc",
"fkvjgcbmjihpmuisnmmfjkv",
"epnvdxxqs",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.String[4]
{
"ijxyvtl",
"hghcpagoajanrbeaqcovfjey",
"vphoamxx",
"rrtac",
},
    NullableValue = 
new System.String[4]
{
"up",
"dhyyucikexys",
"rextcoiqxxcxteruyjrxhohnevjnc",
"s",
},
},
    NullableValue = 
new System.String[4]
{
"nwo",
"wsqka",
"",
"xb",
},
},
            new StringMArrayD1E1M
{
    Id = 106,
    Value = 
new System.String[4]
{
"xi",
"qgcnowbujxbaghp",
"nmsqksojmlf",
"fu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.String[3]
{
"ybiaeefferuybi",
"oxptascgeodjkqgrpbicjngpis",
"uoofxhwvqifnnrikyetfqdxsx",
},
    NullableValue = 
new System.String[4]
{
"kbadaxugjcdlgjbfwibbpvoghuob",
"dueryresuxholgvgerhoqngvl",
"xiehv",
"phudevow",
},
},
    NullableValue = 
new System.String[3]
{
"tdxssf",
"wubolliiyjrvvdnsye",
"runyakrlyhgysnagjaaneeg",
},
},
            new StringMArrayD1E1M
{
    Id = 107,
    Value = 
new System.String[3]
{
"e",
"bsnidifwbixwjgaskypcwxlap",
"al",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.String[3]
{
"iqoiih",
"ommbihojx",
"lujhuwxq",
},
    NullableValue = 
new System.String[4]
{
"guugyljvn",
"qafhaocuobfagu",
"osfs",
"lgxnsqlysbmdvstg",
},
},
    NullableValue = 
new System.String[3]
{
"ahwtiwvdwms",
"bcgvicy",
"pjnp",
},
},
            new StringMArrayD1E1M
{
    Id = 108,
    Value = 
new System.String[3]
{
"hbrfihncwjxhdkqyqrfdbpgxed",
"",
"uckrwuexp",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.String[3]
{
"tltatgnabtogrnvdqdvjlhfqripi",
"fpmgffryfjnpgaghhwdfvndaqfvmg",
"mhotblt",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"ejkefapchwmwcbhwsndwwwiuy",
"aborlchvwurkmdgfdpotcbjhec",
"ynwhkrgpqauclmcdpg",
},
},
            new StringMArrayD1E1M
{
    Id = 111,
    Value = 
new System.String[3]
{
"uoyodegauhnebgewtginoetrrcxsd",
"iiwddreedvjvkudfbgh",
"dxcbkclojrwprkjsd",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.String[4]
{
"poupapvdr",
"flqsybatrg",
"mcffjdvcxkqxfimdqjwv",
"ulggpbwuhec",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 117,
    Value = 
new System.String[4]
{
"nrwc",
"mwyqsckwt",
"pbtrenxegkaktrinvbnbhldlgbtcw",
"dicranc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 132,
    Value = 
new System.String[3]
{
"vyiujqpyteumea",
"osljfipinblrfshtvpgwkdxwqym",
"kvblyoholwphqdkbos",
},
    NullableValue = 
new System.String[4]
{
"moabxxidvlldh",
"wwuqb",
"nqqqcjkocmqancvuuoahvxdansx",
"vhlctwqqhpwrpitwhuobykidkulxk",
},
},
    NullableValue = 
new System.String[4]
{
"ivrqhfmuauqpybhituswpvk",
"wwnoudtojxcsqtdxdbggpx",
"gfylwtmkbrahq",
"snmccsaobiwdwvoleie",
},
},
            new StringMArrayD1E1M
{
    Id = 123,
    Value = 
new System.String[4]
{
"o",
"hfrlunikfkwpjybl",
"fudlosnqtwpbruv",
"kmrxfehrynbxdbqhyqfgpa",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.String[3]
{
"hwdqsqurq",
"e",
"hliotywlvhibthxsshmhburopeyvt",
},
    NullableValue = 
new System.String[3]
{
"chnjlegywikyoc",
"kbjltboy",
"gexnwyk",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 131,
    Value = 
new System.String[4]
{
"rnqrt",
"duonpwxqraxopusyqlegsenxwaxa",
"lunyrfqpwxklbvnmwsekbwxsexu",
"",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 141,
    Value = 
new System.String[4]
{
"wtabfuyfoncpxyvio",
"cypadmfqxf",
"fwdrovkwtnuh",
"iofhungjlceijsxrfwa",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 136,
    Value = 
new System.String[4]
{
"qcqxbusuwcgaq",
"lpmmmuejvxcfiupsawcdndm",
"m",
"smkirlkinpqtjxwbfcelt",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 149,
    Value = 
new System.String[4]
{
"cawsk",
"lvkpydtpbwmvrpbdavbbjipdn",
"uroyimnfmudpi",
"smvfeowqduyvjwswevtomvvtmx",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"",
"eccgpsicxhmjhi",
"ysbcivxnspdguqjkfgemjcpwnyp",
},
},
            new StringMArrayD1E1M
{
    Id = 138,
    Value = 
new System.String[3]
{
"nrllwhmwymvhfnkh",
"ylexnebggkwhuhtrlhlrdiiy",
"rllscami",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.String[4]
{
"xtaycrypykrvmpnjopqvhheggsdl",
"lindkcdjptonapkwaph",
"ljfusyafdwo",
"cejyafm",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 147,
    Value = 
new System.String[4]
{
"clfundvmuggosgvmcedjthfwrd",
"gnseks",
"tjhhqdkdpgcerkxngqswnx",
"sahouaxujvqnhjyoeqxalgxbom",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 162,
    Value = 
new System.String[4]
{
"tmposxccjgrskchmyringxf",
"wewbxxaqax",
"bkmtxvgpsayfpjmxeiguvmri",
"c",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"dpynmtdxuv",
"vd",
"tcdmvgaprkkobhsigtxindknrww",
"bjcfhavvdqgsgfvwjpp",
},
},
            new StringMArrayD1E1M
{
    Id = 155,
    Value = 
new System.String[4]
{
"ahrqkksbpudsrngcwstctml",
"gmmihserjfmwd",
"jtrpostwloquwqsmfmm",
"oqw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 168,
    Value = 
new System.String[4]
{
"bpmjtpq",
"o",
"ldwvqgfnsxkhmwnksdw",
"dkgahtnqpcxhupishrffcg",
},
    NullableValue = 
new System.String[4]
{
"",
"herjmhbgvynouixrldf",
"uisririthatdxeusdeawbxlyewwb",
"lmaewrfqoeqiigyiwyjyqfeerwuw",
},
},
    NullableValue = 
new System.String[3]
{
"kbncqbyenqnusd",
"pcmke",
"jevelaxdfmcyibccbni",
},
},
            new StringMArrayD1E1M
{
    Id = 156,
    Value = 
new System.String[4]
{
"cropfrmxatm",
"tf",
"tjlnmnfkqgkakss",
"trlpfnagkadybyu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 174,
    Value = 
new System.String[3]
{
"nsqsunafqryjiycryxg",
"pvh",
"stiuh",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 160,
    Value = 
new System.String[4]
{
"eylwmgacstjnbmxilf",
"ulkpginpjkyeqhnpqobonsf",
"hbugvmrflejymqnmhurncy",
"grwhrbbcymjvs",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 178,
    Value = 
new System.String[3]
{
"ajitutkey",
"wjg",
"tlqphdadtlhxs",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 161,
    Value = 
new System.String[3]
{
"",
"qlcmwvadaryvr",
"gtmek",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 186,
    Value = 
new System.String[4]
{
"vrsllbviywrluv",
"toofakqw",
"ktuelnjobmstpflsjkdjfwnqmy",
"pxxenyk",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"mcmiiiuy",
"yalkwoutjycvbdx",
"qllipk",
"kjk",
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

