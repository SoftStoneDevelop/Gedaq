

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
    Id = 8,
    Value = 
new System.String[4]
{
"ynlcxsoulw",
"tddaosmnk",
"upvlmqjfyrracfpscc",
"xemrwpftuscjtkqjusitdcmp",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.String[3]
{
"iwfpkxvffuisbkvaqvccx",
"nmrfemstveenqramwwukwr",
"ablrctyiagnldbqnaoaulhie",
},
    NullableValue = 
new System.String[4]
{
"oagndmukpjmiqtudbnguvgfanrrpb",
"nsstgwdwpuhqxwdhsybfp",
"vnvm",
"lpapmupeevvsvrfjcwdggre",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 11,
    Value = 
new System.String[4]
{
"afrlwtxmebwtvnfxoenlshcx",
"kbacslhtoxpvwmypqm",
"xmwofvcqwhagr",
"alpeenjkuksiaqaefjvva",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.String[4]
{
"osooujnlinefvckavnyvcqnfm",
"urlawkxqitcltnfumocditany",
"wfjyybmspyvtwgvd",
"voc",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 20,
    Value = 
new System.String[4]
{
"htfxpgfcvhjmxlcpdsfmhkmfaqay",
"jbqermusgsihhfawtmaxjuat",
"bgpqt",
"thufkajpftq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.String[4]
{
"",
"n",
"rsxynxjjybdbpdubdvtrp",
"m",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 27,
    Value = 
new System.String[4]
{
"igbtlvwifoanofoxtskpdgexn",
"eilpsjsonsuul",
"fgahlfbtj",
"blcliajgnkuqmjnwouklkgufm",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.String[3]
{
"hbyerhnxhfedfcwkbtmtim",
"qpdiotpnpdehdlvah",
"wtvpmhouyewedhfpnkubbxtar",
},
    NullableValue = 
new System.String[3]
{
"mftqoooselw",
"iafiatwhsukd",
"smtsgentq",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 36,
    Value = 
new System.String[4]
{
"cmnvnglxntkuoeddsxmx",
"kwakgmevxhxgtjsvbjthlbtrv",
"okefqqinvkq",
"yhuggrailmttcmrl",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.String[3]
{
"xrgslhhfojfadeljhnoh",
"gkaacyundplpeskf",
"oeouvdvpknheaxwtisnwfjo",
},
    NullableValue = 
new System.String[4]
{
"ovhwgagihmfyteta",
"lygyssfckvnsxkldsimgneyw",
"ywxdfwovqntqusujq",
"dsnrauwfooqoxn",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 42,
    Value = 
new System.String[4]
{
"vxumduqqavhywjvwettdnuardltt",
"ugmarhdlsgrexijub",
"yfeeaquu",
"ftaqpfnfdtayedjmqjoayoptj",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.String[3]
{
"tdmul",
"fgdbbsiqiooxsarrdhusulh",
"ijldefkeecw",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"ndeyedcwfjaixjeepaqpqpoioftg",
"eliaspv",
"wnaufferbwepfukwo",
"djsqgfatrvymorfshhlqrkk",
},
},
            new StringMArrayD1E1M
{
    Id = 45,
    Value = 
new System.String[3]
{
"wqlaksfikulfqrupgdiftbkgxpd",
"hjq",
"fppiregbijkravhyospgyymp",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.String[3]
{
"fabeiuiyfgwatwthvcu",
"ifstgtyixonseuvip",
"lehsp",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"bbrffxvjyeseqqmsmpffwrpx",
"kvuhkjfdfqeqsqaceetlhgoaus",
"rrxgejksxtfqephwwpejehrmiv",
},
},
            new StringMArrayD1E1M
{
    Id = 47,
    Value = 
new System.String[4]
{
"jsip",
"kllaypetcuaevoygqoupfd",
"pattsaohycabysxtsgcruu",
"anwtbjxqixbmmjgsvyccvbuby",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.String[3]
{
"utlxsgnawwbuckdxrkwl",
"tipbxwtjtofedikcdbyseu",
"jjnqiqj",
},
    NullableValue = 
new System.String[4]
{
"jaclcvmjitkdafrmmigvud",
"tqlpxbmbt",
"pbrqtxb",
"xvlxexan",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 54,
    Value = 
new System.String[3]
{
"",
"vunwjpk",
"tbqpuqqrrijqsrenybcfljr",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.String[4]
{
"mumorhcduqfbp",
"erplflditotyusjxpc",
"wufurxhfrumhvkmgsuohxy",
"qrssvqjvbadeisovps",
},
    NullableValue = 
new System.String[4]
{
"hbexc",
"xnahhmysbmksdqg",
"cptuinvwlxvmcn",
"dnuqgrbwbillcgi",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 59,
    Value = 
new System.String[4]
{
"ovgghusxcqglahwblwl",
"pqclbkhapevlrndyir",
"gljnhciqbpotnkkmsbamn",
"gytsqjfuibdisxholjrdkxhy",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.String[3]
{
"mdyptutewqbniqxarckftodkb",
"xuyt",
"iarldkyqlsjxskajkcaalj",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"pfljbgxctnancqbuqspxdar",
"bgk",
"i",
"rjsaixjyuuobqsuipmuwbofsbtp",
},
},
            new StringMArrayD1E1M
{
    Id = 66,
    Value = 
new System.String[3]
{
"qsbfqfhoyfajtbutpxcil",
"cgkv",
"vvwdmix",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.String[3]
{
"mutnximudxhrt",
"dyjovjxavslonisqrcigoavclvq",
"",
},
    NullableValue = 
new System.String[4]
{
"gheixuhdcyi",
"mqhdjskmxkcv",
"xtpqbheatrxeic",
"alvxcvsqxvbuawyxnmxgxhts",
},
},
    NullableValue = 
new System.String[3]
{
"wgsulnrykcsaxavhtp",
"wrlmjsqdbvjfvgavviy",
"ucxboaadxyqdvuhwtub",
},
},
            new StringMArrayD1E1M
{
    Id = 74,
    Value = 
new System.String[4]
{
"hrxlrbhlshflwl",
"dkoyhebbeepyqfhfb",
"neopleearvgmt",
"c",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.String[3]
{
"etqyqhbiffqrmna",
"f",
"pqndhlfjxresekylmwqhklyyeqrx",
},
    NullableValue = 
new System.String[3]
{
"figenxcorvwaxjyt",
"hqejogithbivqmnuscbinqd",
"orafarvdvhnrtklgpop",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 75,
    Value = 
new System.String[3]
{
"sibnjplnlhi",
"rltajpw",
"wcdkwutavjihcc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.String[3]
{
"drulymaoavymvwe",
"uygffcmclmr",
"hjtusgqrmgpnkxkxmpm",
},
    NullableValue = 
new System.String[3]
{
"ok",
"qyenxvxjgbweumoabcha",
"",
},
},
    NullableValue = 
new System.String[4]
{
"bucsbgsfnpqdhkggfhoswg",
"ipcyhqeuemmqulnqtefilgrtpagj",
"hh",
"",
},
},
            new StringMArrayD1E1M
{
    Id = 82,
    Value = 
new System.String[4]
{
"piotmwsjujgdynhmqxywbhtxfubmd",
"xmwfujkleabxiujtv",
"joyh",
"hmegyreiautkfdpumw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.String[3]
{
"htoubxcavofoxnbuqthhdpusxidv",
"clpjrfoqm",
"xjmdngjteoxmlmepjotrrt",
},
    NullableValue = 
new System.String[4]
{
"ruhaphvbkxfo",
"bgxsvwndony",
"hxliqtjsvuoqu",
"xwdqdvqrgam",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 84,
    Value = 
new System.String[4]
{
"",
"vdwhoqkshhifvngmxmobrrh",
"bykwmoryonxlm",
"ydnotaebivcqjcbxpsufph",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.String[4]
{
"gjnvodpbcwlxi",
"ndlblwmctikjnxrqbkkvom",
"kleusfmprecli",
"lsihrqvtvebcdhjaokfbino",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"urwoebfgfvxcmousnwehe",
"yueieusgpoiov",
"yugwvusfbmkkofigwiuyrboiescn",
},
},
            new StringMArrayD1E1M
{
    Id = 89,
    Value = 
new System.String[3]
{
"qbtulgmckwletcinvcgnyjlape",
"xuhe",
"jj",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.String[3]
{
"jpunnfsc",
"hvroxfymkhmwsmpukjrrbykuxs",
"dmrdbrwtyq",
},
    NullableValue = 
new System.String[3]
{
"abfsgtypyhkdyxrobgkvhblqbd",
"edkdsxovnvwpnobwjijguhshoorbf",
"wqueqqlqhawbhkyjtrjvd",
},
},
    NullableValue = 
new System.String[3]
{
"edkuvwwvrodlmfqsktgsto",
"kmsyxvcraefxccrnebembi",
"crnmxgihfhhuj",
},
},
            new StringMArrayD1E1M
{
    Id = 90,
    Value = 
new System.String[3]
{
"tkbsnxgnsitryhygdlnmjbm",
"tte",
"fobtdrwpcjbsumyttusu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.String[4]
{
"pe",
"xswphs",
"dwyrvtybjpafxphhxbverwk",
"ukbeuokgiigixgblkefm",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 95,
    Value = 
new System.String[4]
{
"cvhngfdegsukhcnfrpmw",
"ulprfs",
"g",
"lgydpxgvivwlimmenn",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 88,
    Value = 
new System.String[4]
{
"dfoqupysrd",
"ppcgddbxh",
"eapqkkneybkwrlkrma",
"trwvtuuvqicustltdclichn",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 97,
    Value = 
new System.String[4]
{
"dffpleaaoqjuihojhldtmkv",
"wnsqvmwutychbwoccnu",
"wrvdtenkmsktkayqahpcnr",
"vwfkb",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 92,
    Value = 
new System.String[3]
{
"rgrolfba",
"uxaknbpqtji",
"gbelyhqs",
},
    NullableValue = 
new System.String[3]
{
"jguklpmoncqbrgmajwrtckuwaxk",
"krnptcfhmfrbapfrmrjimrwa",
"eeyuktcskcrc",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 104,
    Value = 
new System.String[4]
{
"oyyjrnoyrdhnkxnkpdxre",
"rmqiq",
"pbqjc",
"gwlgaxeuh",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 98,
    Value = 
new System.String[4]
{
"rwhuqtagpunbffjborwsrorv",
"odtei",
"euwffkeocainanlmod",
"lhmmubilkvuiypqhrfnayfn",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"cp",
"wx",
"oqskggrnnjbqmmogskmboebfayifr",
"qrhyqkpcbifvetlshcun",
},
},
            new StringMArrayD1E1M
{
    Id = 109,
    Value = 
new System.String[3]
{
"eulxbpytsieabxdondyddmgbdpdr",
"yyscvgul",
"v",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.String[4]
{
"hjojehnuoshjpy",
"sewgqh",
"t",
"wp",
},
    NullableValue = 
new System.String[3]
{
"hprkihgshlv",
"sen",
"reljtatv",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 117,
    Value = 
new System.String[4]
{
"ugiy",
"",
"hwditouildus",
"qu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.String[4]
{
"crfayvvawm",
"frrmdja",
"ppjwqmnibubtsvvxvpkfxufhlf",
"iweasgxqtvqfgsmvohwmhovr",
},
    NullableValue = 
new System.String[4]
{
"erfufxsbgmnoewf",
"epotlbtcodym",
"kjtibhcf",
"vc",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 124,
    Value = 
new System.String[3]
{
"n",
"quegjjvyrgrrvmyw",
"anuq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 107,
    Value = 
new System.String[3]
{
"seadnwaydryx",
"yjjvargkdyinguw",
"dhva",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"wsqsnmbttqesqixdbwh",
"wjpclecqsekayxukv",
"baixsthvawbbaxrxmkwriflvb",
},
},
            new StringMArrayD1E1M
{
    Id = 130,
    Value = 
new System.String[3]
{
"vjftwynhodwkjgsgjjdj",
"bjkttbobyxcsv",
"lgxlsguqhvpamxvmytfs",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.String[4]
{
"ltgjlqbgbxonhxlronfa",
"rlggsejknirbpbisuuajqktxhcr",
"jrdfbhbefacum",
"ta",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 134,
    Value = 
new System.String[3]
{
"sbclr",
"ojquasuabaubxdxjawdhbq",
"oetdxvgc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 110,
    Value = 
new System.String[4]
{
"nbjgglnbgrxlpjtamt",
"vysucxrxkufudergpbopncgyixrv",
"bmkefptdbrcatwknvlg",
"k",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 135,
    Value = 
new System.String[4]
{
"mo",
"wnndpigdfsxkaxoehsp",
"awownfivudbeghnvxxcyhlifnxyfm",
"mkfeki",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.String[3]
{
"tmentbnxwawxuucnjxofmkjeqq",
"rylcqogglccqq",
"snmaxvilqhtcwleytavtrbq",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"tqwyjsvwjsvkhkujsjffqgxfahtc",
"bsyvfrrunoph",
"cxxvddxqxnlvggcxhjlf",
},
},
            new StringMArrayD1E1M
{
    Id = 139,
    Value = 
new System.String[3]
{
"boaxuhuemiddcdouinnxljcdvd",
"b",
"pqenwfdiellelqkhbauvprevbe",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 122,
    Value = 
new System.String[4]
{
"lniukks",
"jqrfqtolhdsldtgxivb",
"kwrnqtjmokhfi",
"lwisdsruj",
},
    NullableValue = 
new System.String[4]
{
"rxnvhajnvgnkfionlwr",
"fcu",
"quehoyqejmhpxvxdbbynwbvvyva",
"mmscnu",
},
},
    NullableValue = 
new System.String[3]
{
"yvvpnpumdkjgqmgo",
"gfvyugs",
"lfhvafxdxmjjxbfv",
},
},
            new StringMArrayD1E1M
{
    Id = 143,
    Value = 
new System.String[4]
{
"dhwqyikj",
"tbamskdsmedq",
"jrtqcemfxtlkgoaeionehjhgicyu",
"rgynxlebgbts",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.String[4]
{
"xkfqrkgmo",
"imuituwgdbrymllimldjdlxn",
"uwpkfxdxbwartwtkqemyicnxeiy",
"fgbnhpdojjhbdfntyuq",
},
    NullableValue = 
new System.String[3]
{
"dmrmuemmetodhgtultrrdemqletkw",
"jqcfdjbhumiigqfof",
"lyqocpoyjhnwovkcopjchaem",
},
},
    NullableValue = 
new System.String[3]
{
"mgawpfksmthkijw",
"rbavryfljuajfbam",
"itioxilhvjtnxdspslt",
},
},
            new StringMArrayD1E1M
{
    Id = 144,
    Value = 
new System.String[4]
{
"nymgeciojhgyvqflwdvxrbbgsgxkt",
"ogyaspbumqsmhhhalycem",
"lapk",
"",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 132,
    Value = 
new System.String[3]
{
"ovhbsfxpyoytguwxqbxrbiil",
"gmtic",
"ahb",
},
    NullableValue = 
new System.String[4]
{
"cdg",
"uuqjdfogxsnuclkjb",
"dikrqujrrobwjomjmpdemfeufymoe",
"vvnntonuffqfcfnl",
},
},
    NullableValue = 
new System.String[3]
{
"",
"inwwnixrlmb",
"dwabhnmjrpag",
},
},
            new StringMArrayD1E1M
{
    Id = 147,
    Value = 
new System.String[4]
{
"romhgskvrdrluowmlojcqannxbw",
"picmrwpbgmpgtfvovdmftnuyms",
"vufx",
"mwbnackqjrrj",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 133,
    Value = 
new System.String[4]
{
"yjxxiyapexdenskh",
"wkahxwv",
"rqylemxpemoiyuwlkykcdcshnpc",
"hlkqgskriitxgqkidsytrvdgo",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 151,
    Value = 
new System.String[3]
{
"xnyyxdigaseadrbssxfnnsw",
"lne",
"pitpylnklt",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 138,
    Value = 
new System.String[4]
{
"hmvqbnokxbagnah",
"d",
"ldokuqhexuyo",
"blnpanwyrektvcbanqsixcbnkomra",
},
    NullableValue = 
new System.String[3]
{
"mrfjmsmwghkjtlmcwasaipbbx",
"plhtlpghy",
"mdrclmiur",
},
},
    NullableValue = 
new System.String[3]
{
"gnsenbmkinacydfbqjvfssdwck",
"oomgsuxxf",
"ehtcrtco",
},
},
            new StringMArrayD1E1M
{
    Id = 159,
    Value = 
new System.String[4]
{
"fagranvppaerd",
"dnxhrtdauo",
"cvnmduojmjkjluefkxsoxe",
"ijsm",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 142,
    Value = 
new System.String[3]
{
"xh",
"yooofjauctngkwfngxkm",
"mfhbyvjebcmrdkqmhqvnetqbm",
},
    NullableValue = 
new System.String[4]
{
"cgtenyxtgcekpnqpren",
"iwditvhernjfukkqsi",
"uchexerjacmitbch",
"roxjterjinglqqhqofhtamxae",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 166,
    Value = 
new System.String[4]
{
"hmfiobmmlbskhfvbjqcn",
"xqtjpixrq",
"lshb",
"uagamgk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.String[4]
{
"phkeapurtqvmtyu",
"ypbyphik",
"",
"mtrgpmevifjwcpmkvoyx",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"qhviwhacrugbknubahmunglxr",
"fuldgrgjovxapqfxuvhjryvt",
"ustkblr",
"btae",
},
},
            new StringMArrayD1E1M
{
    Id = 171,
    Value = 
new System.String[3]
{
"nfqdeljaxycjrdgnxewsrmnaj",
"fianvalwssqgucbgx",
"udv",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 150,
    Value = 
new System.String[4]
{
"nmatsxtxrysxfwyekdenwftmoe",
"rivksrpgsetvwdisqagt",
"ehkcmotbmqktdlyppgudmcrjmmgc",
"fuunhcjbjnhcsvksdqkdapx",
},
    NullableValue = 
new System.String[4]
{
"",
"lpsgycoqytxlehlbobmrvnqyk",
"tuxmcpiecju",
"ncsdgaqboohllcgjthtiua",
},
},
    NullableValue = 
new System.String[4]
{
"swrfnmqxsvjq",
"otmftwsfonidji",
"",
"marbrwreqqdiymulnvpajlamoq",
},
},
            new StringMArrayD1E1M
{
    Id = 177,
    Value = 
new System.String[3]
{
"ylkcgbkfjsijkecvpgotmdvafn",
"lfkeuvoyhbrnukbfqmgtttx",
"hv",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 157,
    Value = 
new System.String[4]
{
"",
"wdoesebgexunh",
"evbkftybkjpmsjp",
"xospdwkqmsssboif",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"ak",
"twjgrslfuhbfnihmobqu",
"bstmdrojfbqa",
"bkahkmlilvlxafmsmgud",
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

