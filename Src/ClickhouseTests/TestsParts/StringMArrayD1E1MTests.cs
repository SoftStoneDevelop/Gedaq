

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
    Id = 4,
    Value = 
new System.String[3]
{
"spckhoemmpnuoipvgmqnweg",
"htpfgqgprtk",
"fsyduxblxsjckvsxqcen",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.String[3]
{
"jphcxchtdmyfwbya",
"jscifcdrvqwosfpmp",
"kw",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"cqryuyw",
"ogauoneufhch",
"",
"kdtvrgccm",
},
},
            new StringMArrayD1E1M
{
    Id = 9,
    Value = 
new System.String[3]
{
"yr",
"qllhge",
"ryhnnoful",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.String[3]
{
"bdhantrslg",
"ehhwvmqwunkvuxprhhdypxwcmvo",
"pjoqtck",
},
    NullableValue = 
new System.String[3]
{
"toblulc",
"f",
"bcmfsbiwouimswnboeu",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 11,
    Value = 
new System.String[3]
{
"ahlc",
"rnmhboiathxkgiwqogodwixwygllt",
"taglnuts",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.String[4]
{
"metwjtusidg",
"ugdwplwbxjwpk",
"cai",
"xomshhke",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 15,
    Value = 
new System.String[3]
{
"mhdmbqiqukadkwm",
"ynowhxiojvmquskgfyevlqvrshm",
"mbiagadtprasiegsuux",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.String[3]
{
"cbsobxysfhsfarkxsmniw",
"ffdlxrhsojo",
"gkycutrguwv",
},
    NullableValue = 
new System.String[4]
{
"cpnfjqphf",
"dudeqvtfatagplsqjnjpuhnsg",
"khnmx",
"nmuyxbsbkswumygyafjaufncr",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 20,
    Value = 
new System.String[4]
{
"xlfiwnavrewfetuoqodtcswvtrf",
"nwvuidyixbwdxo",
"bidyksxabe",
"x",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.String[4]
{
"tphcdadylycflnsrjvfakqsrdjdll",
"bxawkyrfnvviaq",
"henmmoqtm",
"hujjywhstrqbqcweicgbwbrifvbk",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 24,
    Value = 
new System.String[4]
{
"occobqneekllmucowagapsojgjdg",
"ggnpnyu",
"s",
"lhdajqyudcethgsptufw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.String[4]
{
"oby",
"iwaxsuxfdqlqpkjegjwjfrubtsbrf",
"wfjbwfqstvdmbwnhstsssoqju",
"ntacodklevhbg",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"ckhynltodtvsbyhswclglywnghflp",
"",
"iqujprqgordodomquyhb",
"kjw",
},
},
            new StringMArrayD1E1M
{
    Id = 29,
    Value = 
new System.String[4]
{
"yrbwsjwyeyvsnaosxprsar",
"thyndoafmkffelvlqj",
"ild",
"clobxgfpqhyplmctvxtaoaljt",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.String[4]
{
"agvylkwsoqidgafxrprgxtxvmyl",
"ssxrxaxilwrttnnwmmjtohnqs",
"kecogix",
"nbugokfrbxeabrelqoombhet",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"lua",
"kifaf",
"vtchkmukrugxntbngq",
},
},
            new StringMArrayD1E1M
{
    Id = 38,
    Value = 
new System.String[3]
{
"spdwjvugyvxxjonuyfe",
"axvlstjfrvocsgejxku",
"jwcigcwdrpeklxtaciphp",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.String[4]
{
"lsnqbgkrfyovmaxdka",
"fuoonubsyehvqa",
"sslknbqldacncymfhxrfbt",
"vgrmkm",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 46,
    Value = 
new System.String[4]
{
"dofeuyhsjm",
"trbxhjpvwomugljtbq",
"dujbqyrjamtdhtpghvyoxw",
"vtbdosgfbjofakyu",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.String[4]
{
"ee",
"ip",
"crnbuhqixqvd",
"iddht",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 55,
    Value = 
new System.String[4]
{
"q",
"qgrtcpfi",
"miiwkemctwbwgvclg",
"ritsigmfwvpaavkjlanasrxmtk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.String[4]
{
"jpctxtkjcyf",
"khwafhaykaflaaotmicrjtdwivxt",
"qsoydhmxkefsfiiuqbnmnxgfnr",
"msjjhkxpubwrpbuebtfei",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"qa",
"whbveetqet",
"btctwjslmgnxghkwwexauxenxk",
},
},
            new StringMArrayD1E1M
{
    Id = 60,
    Value = 
new System.String[4]
{
"ojadqwxof",
"ymkiohpcfdytcyacjdvc",
"cmoftqkxan",
"vbwnopxtilwyafbtuwckcpeq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.String[4]
{
"yoseutsoukcjqgngpl",
"twjabiyryqg",
"nr",
"eojxppg",
},
    NullableValue = 
new System.String[3]
{
"onucgocvklygvydx",
"hxueqfknb",
"nchna",
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
"gkqmhihhxgsybmjwpwmhkm",
"nqqsmxgtu",
"ggrhygayxxdpqb",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.String[4]
{
"mgsrjxabxcwceacbu",
"pej",
"dbdwiiqmqxjceypnuhldiw",
"dwsvqcqhoo",
},
    NullableValue = 
new System.String[4]
{
"inwvnhvxhjqnrracefplibfbs",
"fuiqsuoj",
"jkhesjmydsayryusy",
"hsxbgsbujmeuaxgildehn",
},
},
    NullableValue = 
new System.String[4]
{
"tagcbwyvhwrrawjm",
"yy",
"ptsqoygxovr",
"kjpnrccaiorsypmemtinmtdgth",
},
},
            new StringMArrayD1E1M
{
    Id = 69,
    Value = 
new System.String[4]
{
"gy",
"xnnrqiegf",
"fvbwi",
"lxfgxqqdyv",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.String[3]
{
"uqtmtd",
"tedovufsglbhfauixdicxf",
"ffwonewceceyhrnay",
},
    NullableValue = 
new System.String[3]
{
"galkakaukxjmn",
"jgbtegsktov",
"dxiachqkoltqosynettbmdhm",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 78,
    Value = 
new System.String[3]
{
"mabevpne",
"g",
"djnxgsihkpw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.String[4]
{
"quvogrdxkcwrsqpktixvowuujy",
"tvlojwlwaixqieh",
"ajucyjnggtkaqrvhwu",
"f",
},
    NullableValue = 
new System.String[3]
{
"cniydoypisjqmuuhkmtmmsi",
"yhbtwhhrwjljlrxdupkuaxa",
"rxnmprfxtasrbvvl",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 86,
    Value = 
new System.String[3]
{
"embapgndwgiiqqbgdujrimy",
"opmgljywdboboyeihvc",
"asidkmd",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.String[3]
{
"dtjshqpxoebneghplflbq",
"tnudoupw",
"lkdnnbrtpm",
},
    NullableValue = 
new System.String[4]
{
"kaim",
"ahfjauvaaciprgssiokqxk",
"uybttvk",
"eixwircgiwmrlvvueik",
},
},
    NullableValue = 
new System.String[3]
{
"ij",
"to",
"crbxtnet",
},
},
            new StringMArrayD1E1M
{
    Id = 91,
    Value = 
new System.String[4]
{
"pontgqgfj",
"gmfingtbiivrkqfmxyxxbwwkk",
"ccalcowhapwd",
"kncwkrgve",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.String[4]
{
"tvtpdkjyt",
"mrvpiulumhsnby",
"ansrtjpmytqwiebchoh",
"edaxolgsetqqemhhissc",
},
    NullableValue = 
new System.String[3]
{
"mhn",
"lryyhyfkatbopwa",
"goyjttxakoxbuasajpdwtsrhlpglg",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 97,
    Value = 
new System.String[4]
{
"sxmoywjomjuvsvviksblm",
"aavowvtvbtlijxrpoqmmcvy",
"luravvqwnrbtfrv",
"pnsusmtvhusw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 91,
    Value = 
new System.String[4]
{
"tylyelibplwdpwxudaqgsvqgp",
"wijrolhrsyaobulap",
"actpugimyjhhaitbppvn",
"brpvyisbtjux",
},
    NullableValue = 
new System.String[3]
{
"ti",
"yfhfwrimepmluyjvdppeniuud",
"agnnrrsscskl",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 98,
    Value = 
new System.String[3]
{
"mrtexkhucdsmyjxcnxctcfyykdeu",
"ooapsew",
"usfbtaffs",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 94,
    Value = 
new System.String[4]
{
"cnufvndldxrmtmvcxjpjtrp",
"xauqkbqvdjsdxunkepw",
"fy",
"qqrqedsouduykwm",
},
    NullableValue = 
new System.String[3]
{
"cpqrecaitnqo",
"fogdsvcccx",
"rckoipvuxaljfxspbrxbp",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 105,
    Value = 
new System.String[4]
{
"ljv",
"byjl",
"rmky",
"xvnphhvyaseakgqxivxk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 98,
    Value = 
new System.String[4]
{
"",
"jsnxtt",
"sfaxue",
"xooq",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 107,
    Value = 
new System.String[4]
{
"cgmvnbqtvirwtbytnekvv",
"emmglvrxb",
"scn",
"pbufxshqukv",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 100,
    Value = 
new System.String[3]
{
"fchxikupahgfitfxqbymfawqipxt",
"iwgtvdrsqkkqjqj",
"egadiycpyvcleqfyk",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"ttkqwhbe",
"ioablyyfnvnj",
"mumbstigtrymnmhudesqp",
},
},
            new StringMArrayD1E1M
{
    Id = 114,
    Value = 
new System.String[4]
{
"dnnfmt",
"mverbnsyty",
"gkrbxm",
"nclhsayaxkbwmbkjmuvlwsbed",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 105,
    Value = 
new System.String[4]
{
"wrmwym",
"yglrjfkmjodtcgwogcitvpvv",
"fkqcd",
"sbh",
},
    NullableValue = 
new System.String[3]
{
"xroowckwtcpwvbdq",
"lvbdsaijv",
"fcbjfnmmfdte",
},
},
    NullableValue = 
new System.String[4]
{
"efkuosrmnfmojyocgtqicje",
"mccgnbaqi",
"lotskpgbplfelhtfopomwnitof",
"ygrywgqntdim",
},
},
            new StringMArrayD1E1M
{
    Id = 119,
    Value = 
new System.String[4]
{
"amukv",
"gwuxutebgpttrlmauotyvminb",
"dlcpvtdp",
"jhmqjeleqsoclubydk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 110,
    Value = 
new System.String[3]
{
"uneqvdjfjsdulfhqas",
"ggamfkkbiiaccalqunubk",
"enpxddxjlfpwwcpgubtpndpbti",
},
    NullableValue = 
new System.String[4]
{
"p",
"xfjsnpefqbuvyfygwhskfgaifq",
"iv",
"c",
},
},
    NullableValue = 
new System.String[3]
{
"ouusxslhgjixmb",
"ira",
"",
},
},
            new StringMArrayD1E1M
{
    Id = 128,
    Value = 
new System.String[3]
{
"gpcarafb",
"vsxflsvnavtoebijfr",
"iq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.String[3]
{
"iqbtxyluotcbpwcd",
"pdgrh",
"ymxaevcvigpks",
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
"raiciusqhlwthygdyelflvie",
"qiycoxlgdsfhrnvejdakghdsjip",
"ieipxpksdscf",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.String[3]
{
"",
"ui",
"euphwctf",
},
    NullableValue = 
new System.String[3]
{
"pvqfpav",
"ginnuxjxiffpktycqlfvneyo",
"vcnyxgiafjqwam",
},
},
    NullableValue = 
new System.String[4]
{
"ckekkkpwwiudsrswdmqvqmbexnvap",
"rfydruitcped",
"ftdjmjtsbgas",
"kvpfguyojkbovvdajcyj",
},
},
            new StringMArrayD1E1M
{
    Id = 145,
    Value = 
new System.String[3]
{
"ohrc",
"xij",
"aw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.String[4]
{
"pdiaurglggxfjrxbmlsholqxv",
"qbawhgjssjnykv",
"jvfnkvrutouqrrfnpsuxfclf",
"oqyjoiobxovvnwckbivgobydp",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"ebyrer",
"feptuefcxlwwl",
"jqecppinugpbygsc",
},
},
            new StringMArrayD1E1M
{
    Id = 148,
    Value = 
new System.String[3]
{
"ybhul",
"mrrfxlboqgnxl",
"ubkxudemytptyqfcrya",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.String[4]
{
"cfgdgkccblffhauxieeepnvnogjnh",
"tptpcslcjpm",
"vlqeeyjlvvltjnhoqolinqkojp",
"ueijlkeukg",
},
    NullableValue = 
new System.String[3]
{
"ofghirrafaxv",
"dpycovkl",
"gcpvmjjojhvebxr",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 151,
    Value = 
new System.String[3]
{
"ytumxog",
"aexiiuu",
"yguukpulo",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.String[4]
{
"lwf",
"fedtglyfytecas",
"rwavcpiwxpwulpxvjtxljhltl",
"ieokegjnipyswccmsc",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"rtvvytjlmityfjgfktjxseb",
"viukyx",
"yg",
},
},
            new StringMArrayD1E1M
{
    Id = 155,
    Value = 
new System.String[4]
{
"qlwuojtnraavanc",
"r",
"yjpsatlbxupkyojedwvrpnxbua",
"ldmmielmxjqtjmrwiribnmjfl",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 141,
    Value = 
new System.String[4]
{
"hloecgxiahrhcuaqcto",
"cdmw",
"dksocebnpfbhopnsdibpp",
"tulikxblwtclojbyq",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 163,
    Value = 
new System.String[4]
{
"arqmpw",
"hgyf",
"lvwvioydtxctbcjhyuqjdpby",
"pyqkjrguotdcpkimixrfixcbr",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 146,
    Value = 
new System.String[3]
{
"bnapskqjuuhmqmxiogpo",
"xmbfcxhpwayqctirdnf",
"rhcikhxjhaweynb",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 168,
    Value = 
new System.String[4]
{
"otmu",
"cepvpabppjjeyepavon",
"kxelktgefgcy",
"syjycds",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 150,
    Value = 
new System.String[3]
{
"isvdrudrtow",
"vexkcogypqxvpwqxaumetfwn",
"vcafgxybachhrhwupfnslfbay",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"bjmbsajuqvysxn",
"iaangldoapbjorp",
"eovlvgbfrcufwj",
"sbngulm",
},
},
            new StringMArrayD1E1M
{
    Id = 176,
    Value = 
new System.String[4]
{
"pnehv",
"snajfqschaqmgyy",
"nievppojhywgd",
"jfyfrry",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 151,
    Value = 
new System.String[3]
{
"vatojvowyj",
"lpfmftsftwhslbbtjviyfysws",
"vecnrewdghpuk",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 181,
    Value = 
new System.String[4]
{
"mqhdcwxkfsmgdwmktbcqhwhrdxxki",
"awhcrpmjoyjolwexunphuaisjg",
"y",
"jkxovw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 153,
    Value = 
new System.String[3]
{
"gtsvuruqrxjobh",
"isnngtackdrvvqthxghp",
"rahhts",
},
    NullableValue = 
new System.String[3]
{
"c",
"kpqutyejflejngmdayacskwolwq",
"kldqetpdekiuukjtkqnfmuvdyj",
},
},
    NullableValue = 
new System.String[3]
{
"ygycgolikcspyoevsgiirewujcqro",
"ehifldebtbfhtbw",
"lwlfimqgpapinssisxwcotf",
},
},
            new StringMArrayD1E1M
{
    Id = 182,
    Value = 
new System.String[4]
{
"hbcmselk",
"pqvackuhgwg",
"hbuumbmgjbgnnrprlbf",
"dvxcrxbytnbdyw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 158,
    Value = 
new System.String[4]
{
"rbs",
"xygvnrwsaxaoixhwkwyevivax",
"tadcnadvnmonsbigismdoayuc",
"hbbd",
},
    NullableValue = 
new System.String[4]
{
"fqhlxetuhgkxaixnwjnmoanbneale",
"idecotyephhvkbb",
"pyuaevkfyoyhrbnlmyfgccst",
"q",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 185,
    Value = 
new System.String[3]
{
"sg",
"meywlqgmoxxefxcwrlvqxbvjnkt",
"iyhosdbrl",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.String[3]
{
"wnvkcogftdhbahcgimn",
"wpwjprftglhpayfhuovs",
"ydxvsl",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 192,
    Value = 
new System.String[3]
{
"xm",
"ypytotpqbntglpqjkvuylbw",
"gtvvrmusyvmswkjkdnerqoduc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 165,
    Value = 
new System.String[3]
{
"hqyderlylqvaelrabx",
"lawif",
"hjbviijdspwebs",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"naqtnf",
"fpprml",
"xashkomxbpjtgxq",
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

