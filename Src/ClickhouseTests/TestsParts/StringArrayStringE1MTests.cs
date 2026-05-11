

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
    internal partial interface IStringMArrayArrayString
    {
    }
    
    internal partial class StringMArrayArrayString : IStringMArrayArrayString
    {


#region TestData

        private readonly StringArrayStringE1M[] _testData = new StringArrayStringE1M[]
        {
            new StringArrayStringE1M
{
    Id = 3,
    Value = 
new System.String[3]
{
"detbvnlqxv",
"onhifkaymospvfp",
"rueopjsrdgwtkhesuiqbddchulh",
},
    ModelInner = new StringArrayString1MI
{
    Id = 7,
    Value = 
new System.String[3]
{
"",
"bbafbormyeymu",
"slyfeuaexo",
},
    NullableValue = 
new System.String[4]
{
"qyloaiswcwdomn",
"hduveakb",
"xdacpwlsvrpfjjxcftigrdd",
"wgwqohpicpyxoalcwtnebcpvrb",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 12,
    Value = 
new System.String[4]
{
"suegnuhubchvtdefpiwpgoypgjyjd",
"hjmttocxchjx",
"kalr",
"ifmfxvvpsfbkggy",
},
    ModelInner = new StringArrayString1MI
{
    Id = 13,
    Value = 
new System.String[4]
{
"lgwwwlvdvr",
"tippojwhktajlymjxtondjgatdww",
"xttlwkctwwplalleivbggevuerbt",
"fckbxilp",
},
    NullableValue = 
new System.String[4]
{
"edphaspoqlrrpyomvn",
"dhehfqncorqjfafbqjoxa",
"iqs",
"fpwvlwbewhtpjyymcrbguwmynpcs",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 18,
    Value = 
new System.String[4]
{
"rvmdbjgeihmrkecr",
"wssdsnabaowpccbb",
"btrqqdwwgyewkwrdmjwjkg",
"sfibotwsjvruxvsvigslj",
},
    ModelInner = new StringArrayString1MI
{
    Id = 21,
    Value = 
new System.String[3]
{
"s",
"cibxevlgqjbuecgetspturrta",
"ptwrnapdfpmklgwqonvefw",
},
    NullableValue = 
new System.String[3]
{
"agyuuvxiwhpesy",
"ivaqfsx",
"ltyhpltedccjjydtrktbmckls",
},
},
    NullableValue = 
new System.String[3]
{
"ukgiwwwqelxi",
"halmsjolqjflgbcvkushcejit",
"kqkitegkfarglcinnq",
},
},
            new StringArrayStringE1M
{
    Id = 27,
    Value = 
new System.String[3]
{
"wktlekuarnubcqyeqeaviebelv",
"pdwoavndewqnqcnhjdfon",
"ve",
},
    ModelInner = new StringArrayString1MI
{
    Id = 27,
    Value = 
new System.String[4]
{
"cixdeeinbmqoxhrdppfok",
"gnuysv",
"uvwhoglxkg",
"wjawrqqiwcbqovjufdnjwlqk",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 30,
    Value = 
new System.String[4]
{
"iblccawovkojdlxgcfy",
"qhwhewabxcopwoiqgioi",
"wnioaqgouavdsf",
"hgih",
},
    ModelInner = new StringArrayString1MI
{
    Id = 30,
    Value = 
new System.String[4]
{
"hmrlniwinibuwvnarksbsj",
"fcu",
"jxbqpoihiraxxkgbxyuys",
"mloledxei",
},
    NullableValue = 
new System.String[4]
{
"srosnjfhbmtescfcsubmmexibm",
"kxyor",
"eiajdwgeqpufudtqk",
"uptlttjviksgcvrfvuhrygj",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 39,
    Value = 
new System.String[4]
{
"odcthjgfusu",
"ds",
"kxaykeinlsrdbnogkwvsgrc",
"fepfqfnwonfhuvcd",
},
    ModelInner = new StringArrayString1MI
{
    Id = 37,
    Value = 
new System.String[4]
{
"lwmiugngomfq",
"tvxchntukpnx",
"wxsuvrmhcjqxpdpcvysefvphfrp",
"jtynrhrwtpkxvyncfahiyxbd",
},
    NullableValue = 
new System.String[3]
{
"ivbehjyhmetmwytfbwhgtfbpces",
"jsqceo",
"yttv",
},
},
    NullableValue = 
new System.String[4]
{
"",
"ilkdgovvhrbvuugoldcaieuxy",
"",
"qlwejaffnjjepdieu",
},
},
            new StringArrayStringE1M
{
    Id = 47,
    Value = 
new System.String[4]
{
"jhsdykovwxbxecurcojtenrncd",
"siovwwupfkpumiebptadjfamhefd",
"rwvn",
"hxrvohexnefgsoyxkewkfaagtoc",
},
    ModelInner = new StringArrayString1MI
{
    Id = 41,
    Value = 
new System.String[4]
{
"hwu",
"wskseapewflqndp",
"dmxgbprlnntimtjowaignsiklee",
"vyqjsiqawtnpxdvha",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 52,
    Value = 
new System.String[4]
{
"i",
"qfxowidueqpqfhyisooqrcv",
"spn",
"gcyygsxfeuqwghgisrfe",
},
    ModelInner = new StringArrayString1MI
{
    Id = 49,
    Value = 
new System.String[3]
{
"oatpcjjajhyedacurtlsidfw",
"pxb",
"mrjj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 59,
    Value = 
new System.String[3]
{
"cxxntdbnhduqudgirxsimclog",
"vhlvcqsfq",
"ttcmfmtouvpmuxqorfrlsuer",
},
    ModelInner = new StringArrayString1MI
{
    Id = 57,
    Value = 
new System.String[4]
{
"gcg",
"cvwmfcuwpst",
"nstqj",
"igkpvrktfhxgarvdtmubopys",
},
    NullableValue = 
new System.String[3]
{
"",
"sqeenpy",
"",
},
},
    NullableValue = 
new System.String[4]
{
"otjyfblkdflrefpbbitmoqby",
"vhyt",
"cgaeonsy",
"rogjueffmklc",
},
},
            new StringArrayStringE1M
{
    Id = 63,
    Value = 
new System.String[4]
{
"hofq",
"kgorhxvdcaieyblaspxwqsp",
"rtsybxaxurxtjiry",
"iolitbarmkbslnkblqeseay",
},
    ModelInner = new StringArrayString1MI
{
    Id = 63,
    Value = 
new System.String[4]
{
"ghhyxc",
"xdjhjlcs",
"jjhnsjdfcnomkvmdgtbfin",
"hujpnbxu",
},
    NullableValue = 
new System.String[3]
{
"weljsaeoyqqhvvlncqrs",
"aupo",
"m",
},
},
    NullableValue = 
new System.String[4]
{
"g",
"tettnvlymropqlmratcacod",
"jpyjcpaubkbhkrqlpske",
"cpsmquhnpwxyilpxomgsedxbt",
},
},
            new StringArrayStringE1M
{
    Id = 69,
    Value = 
new System.String[4]
{
"yswvi",
"ssktptmxgpussangi",
"qlntcmbolputbbqncjtitoqbgtq",
"ktrlthxfntqgrkdkvt",
},
    ModelInner = new StringArrayString1MI
{
    Id = 65,
    Value = 
new System.String[3]
{
"hnkswjulskdtirosmaallrxwaab",
"aaqdvqljejwxfjgydrskwbtrcypw",
"xmwwjuqvxm",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 72,
    Value = 
new System.String[4]
{
"vcuyumpymi",
"eenleloin",
"ieicenvgwqen",
"vmqqeooqailiphwmgfb",
},
    ModelInner = new StringArrayString1MI
{
    Id = 70,
    Value = 
new System.String[3]
{
"xljlfirhexsogehynxnnkl",
"gipp",
"vtaaplluxebyyvyaonxdehn",
},
    NullableValue = 
new System.String[4]
{
"two",
"lavvf",
"ymvwsxchdgvvqswyrfq",
"prqacsyk",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 76,
    Value = 
new System.String[3]
{
"mamitej",
"donlnqkqvgkdgfa",
"vneq",
},
    ModelInner = new StringArrayString1MI
{
    Id = 72,
    Value = 
new System.String[4]
{
"iksrdei",
"jwwj",
"a",
"eq",
},
    NullableValue = 
new System.String[3]
{
"kpofbidfheulcnuglhncsnsulfe",
"x",
"qygkvxyjfstrkjtxwrohut",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 84,
    Value = 
new System.String[3]
{
"tmncwhqgvkdwcxxwwdtmssjntctrx",
"btfrw",
"spv",
},
    ModelInner = new StringArrayString1MI
{
    Id = 79,
    Value = 
new System.String[3]
{
"iighucqotwgfqexprfrwg",
"llfrraqaciqcafrwxvouo",
"nxsvejepnjnpspteils",
},
    NullableValue = 
new System.String[4]
{
"rinfofbudlr",
"nrylgol",
"iojruiiaeuvkujuhdgccgafqxqfr",
"srilr",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 87,
    Value = 
new System.String[3]
{
"lvbealvgimfjcgsfwcajwtckc",
"qbcklax",
"hbehfk",
},
    ModelInner = new StringArrayString1MI
{
    Id = 87,
    Value = 
new System.String[3]
{
"hwekkmgiaocupv",
"uuquevn",
"wjxpxy",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"emmucnsvmkyadwnqtowglgla",
"jamfhbymrbimsvkkp",
"yilopxoimvasvcew",
"thgknmmfamedggrv",
},
},
            new StringArrayStringE1M
{
    Id = 94,
    Value = 
new System.String[3]
{
"eoghh",
"umvfvtabpqkkyg",
"jtjiovllcens",
},
    ModelInner = new StringArrayString1MI
{
    Id = 92,
    Value = 
new System.String[4]
{
"kxeniuloiwqosjjfhsrau",
"kxelkjfhavnlonkqjgbnvv",
"opimrhfcbhsvgmmutlqbybfqq",
"fljlufhimkegsqvpfuxq",
},
    NullableValue = 
new System.String[3]
{
"jfyw",
"riwev",
"tqnolpe",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 98,
    Value = 
new System.String[3]
{
"kssxdbfhxbihkvkhkywjg",
"insqgfbqqmmx",
"rcsosggovblbsutdgurgbmrlwc",
},
    ModelInner = new StringArrayString1MI
{
    Id = 98,
    Value = 
new System.String[3]
{
"ifjmefufkmybprcthanwfbfncwm",
"",
"mikyv",
},
    NullableValue = 
new System.String[4]
{
"sxvsketeekqffhobqgitgiqmm",
"jlxnddfgkhnguquunwwii",
"ifskjadyq",
"rwtilsm",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 104,
    Value = 
new System.String[4]
{
"eeyngicxixmkxfflywq",
"bvmfuidjtltcy",
"ye",
"lpqilwfwvbccpmgj",
},
    ModelInner = new StringArrayString1MI
{
    Id = 105,
    Value = 
new System.String[4]
{
"uhsyqsumorudcwvloqtnaiaanbb",
"fulbhggr",
"",
"crfofbkdflkrxsccvleifmlocyta",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"",
"dncqthmpvcbefte",
"xjebixkmpoggg",
},
},
            new StringArrayStringE1M
{
    Id = 113,
    Value = 
new System.String[4]
{
"kehhelfanrpespywbtqlcxkjqjpc",
"dbbfnysgteaccsijuqyo",
"nah",
"vvhkwjmoneynrdjhnihrldlmpy",
},
    ModelInner = new StringArrayString1MI
{
    Id = 113,
    Value = 
new System.String[4]
{
"jjdwssspyfyupgxloiugisqdvdx",
"ydblkbypmyyk",
"kue",
"eavknibu",
},
    NullableValue = 
new System.String[4]
{
"g",
"gqwujxgr",
"yspoddctwhewymgrfayvnymepyfps",
"wwtfshuucmyigxvfkvyk",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 117,
    Value = 
new System.String[4]
{
"mssngmdtdthc",
"xghlefvjesrvouqgbgk",
"ixjokxane",
"lalopavfguyoymu",
},
    ModelInner = new StringArrayString1MI
{
    Id = 121,
    Value = 
new System.String[3]
{
"niwerfxnfpqrndylkdpwwlulici",
"efgdaeh",
"gxvqwwivmmwpwspq",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"rnkyhgsxexpkn",
"qnlrwrgxb",
"",
"oaenihhjumpf",
},
},
            new StringArrayStringE1M
{
    Id = 124,
    Value = 
new System.String[3]
{
"kfsjvimdkkvljl",
"qfpqqd",
"ub",
},
    ModelInner = new StringArrayString1MI
{
    Id = 122,
    Value = 
new System.String[4]
{
"nrfnelpkiwkcryv",
"ftuspqo",
"idbkqqbshalubrulwvghomi",
"dapmabisayetiiprrxakwwpl",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 125,
    Value = 
new System.String[4]
{
"unceapkbwfgdwcepavuhiusy",
"cfcibpcjbvgqxuhlxq",
"mpjrkiaqdxdaiptmphrplmb",
"ii",
},
    ModelInner = new StringArrayString1MI
{
    Id = 131,
    Value = 
new System.String[4]
{
"venlcymguntdqumeweixoh",
"ftmwvuygllppw",
"mcfyqqtx",
"gitnkqliv",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"dfm",
"tqttbqwateiokpqd",
"dsiwtkjpuxgqtjbyh",
"",
},
},
            new StringArrayStringE1M
{
    Id = 128,
    Value = 
new System.String[3]
{
"ningmjkatc",
"kdkx",
"vxqhslcofp",
},
    ModelInner = new StringArrayString1MI
{
    Id = 132,
    Value = 
new System.String[4]
{
"yltbdnvdbtqthn",
"xvytyrtqqcvsotful",
"eyqohqtwfegnitlbvceeagoh",
"qqcfepx",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 135,
    Value = 
new System.String[4]
{
"krorygofky",
"oguggklubkyjtssvlvgsbl",
"vsuqeuemdeayjo",
"liepn",
},
    ModelInner = new StringArrayString1MI
{
    Id = 138,
    Value = 
new System.String[4]
{
"xgugcuqxiduifpolka",
"lutcvxmxpejtq",
"fkkdyqecwbdumpegtyqt",
"hntvjqkwhgjlldmbestntxanvakn",
},
    NullableValue = 
new System.String[3]
{
"jepwxxk",
"yrxtprtnti",
"ydgnmtdelbeqxcpxpoihlwyyin",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 139,
    Value = 
new System.String[4]
{
"hvmmtksjkgephycvhvicxvflk",
"jmjuj",
"yuqqppbhegsdskutqfvtmlt",
"nkfhfhgikckyhouoeqnrawmoeanql",
},
    ModelInner = new StringArrayString1MI
{
    Id = 145,
    Value = 
new System.String[4]
{
"aogimtdrfthxdwnwodkpkg",
"awihc",
"scvgnsffudhtbtbbetjnjilpe",
"laebbamrrdfqijq",
},
    NullableValue = 
new System.String[3]
{
"spknuxotwdgbtjblrxxecullk",
"hofvtetiilmtefugaj",
"sxyitsvvpplmw",
},
},
    NullableValue = 
new System.String[4]
{
"veqkqnfok",
"goieiaqubcshrqhrwcin",
"orrakgxpjastt",
"qexsbthjux",
},
},
            new StringArrayStringE1M
{
    Id = 144,
    Value = 
new System.String[3]
{
"dcvkicihymiyjnkywnumbfdjjrx",
"vuowhkwkffuwkgpmxfgphg",
"emmbfmobjoygawvvgdqsrqwujaxv",
},
    ModelInner = new StringArrayString1MI
{
    Id = 154,
    Value = 
new System.String[3]
{
"yhktpbwtalsroxsryrmbrffkjx",
"hiq",
"bttgyho",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 147,
    Value = 
new System.String[4]
{
"nbq",
"pqbd",
"qixrpenqrlh",
"smrvspuxyaqyawegifkjqtiais",
},
    ModelInner = new StringArrayString1MI
{
    Id = 161,
    Value = 
new System.String[4]
{
"vlrgfmuhfeyeieiqqrmetytfgyiux",
"uqgkfagnltbaxbcvgelad",
"e",
"wwvq",
},
    NullableValue = 
new System.String[4]
{
"dsmmj",
"wwuewakatgniwernmjkhq",
"kyagkooafiandglwx",
"lvwrrqp",
},
},
    NullableValue = 
new System.String[3]
{
"l",
"rgvdkit",
"gnl",
},
},
            new StringArrayStringE1M
{
    Id = 151,
    Value = 
new System.String[3]
{
"wgynnikikfgmydarsufkiet",
"wdotcrfprw",
"bwv",
},
    ModelInner = new StringArrayString1MI
{
    Id = 167,
    Value = 
new System.String[4]
{
"vytylvtslltolahunaxe",
"orqwdwhnggiobgu",
"whrcdemilcvwovau",
"icmnngwpqkfspgktycb",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 160,
    Value = 
new System.String[3]
{
"cyoejgtkjvgxogagckvawgw",
"luchsstkcreptbxoew",
"edkktyxtnpcatvxqtcb",
},
    ModelInner = new StringArrayString1MI
{
    Id = 170,
    Value = 
new System.String[3]
{
"fqscqyaaralide",
"agwicrgkehjxtgdqkdvgfpsgrppsp",
"rfndgklmom",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 162,
    Value = 
new System.String[4]
{
"jnuwpavhuqjqctmcvmp",
"faxubffshehw",
"sxphtj",
"ecgadhodiwatkumf",
},
    ModelInner = new StringArrayString1MI
{
    Id = 172,
    Value = 
new System.String[4]
{
"holjbkfjegfsotbkctv",
"diqorwefgpvwytcedsg",
"ggxhqlpybpmtfol",
"jupftluxdec",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 164,
    Value = 
new System.String[3]
{
"mgmjxlretpmuqlbkqxqwcugwsh",
"hykowfemnhecsswkkgxmyempjfj",
"dgyqeidv",
},
    ModelInner = new StringArrayString1MI
{
    Id = 177,
    Value = 
new System.String[3]
{
"qaytkekxdrhdvpugylusj",
"jdofwokkf",
"ykmfjdhbudf",
},
    NullableValue = 
new System.String[4]
{
"cigtpchxtcntuxf",
"wcworlhuhhmryhynjywwwp",
"nupboxclgopgmadrtgarnv",
"jehrinshmoaptvthatswx",
},
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 172,
    Value = 
new System.String[4]
{
"tjpjvky",
"egcucnrvxnb",
"tdtxlsiu",
"lsooxmqsdvevqrkuhvqbqjpkgn",
},
    ModelInner = new StringArrayString1MI
{
    Id = 184,
    Value = 
new System.String[4]
{
"bg",
"mynlcfvrrbuccmyngidei",
"gccwxsgaimavhc",
"iyjvsbksgbxqrfkuymopskabgrrhs",
},
    NullableValue = 
new System.String[4]
{
"dnrdtjmogwrrehkwpq",
"xnf",
"jchtkkfgtoubhw",
"dwmmf",
},
},
    NullableValue = 
new System.String[4]
{
"mtriomvwoxfjsnjpnbs",
"nyagjkfgtgl",
"jyuvuqpcmlfd",
"spfnhfrrqljdvfhrtuwqx",
},
},
            new StringArrayStringE1M
{
    Id = 179,
    Value = 
new System.String[3]
{
"dinwdmo",
"qdjtaogvpql",
"twlwtpmowvtgypebyvx",
},
    ModelInner = new StringArrayString1MI
{
    Id = 186,
    Value = 
new System.String[4]
{
"upvwgrleyd",
"scqkrdgjfbwqw",
"uhiokjywdavvunbashs",
"jkqoepo",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayStringE1M
{
    Id = 184,
    Value = 
new System.String[4]
{
"rewqjrxpy",
"ocvmaotqevunvfggtkshxc",
"esf",
"vkygltspmwxt",
},
    ModelInner = new StringArrayString1MI
{
    Id = 188,
    Value = 
new System.String[3]
{
"",
"sihbqhfpmfsirnjjumomts",
"xcyntpccxkasrajmqw",
},
    NullableValue = 
new System.String[4]
{
"riohaaagwyteyxecfvxgkegfftpc",
"gqvrjbgdmkcekstup",
"uxdponusgwtublw",
"bdflujwtmxxjodmjjwuc",
},
},
    NullableValue = 
new System.String[4]
{
"gfypmcxirvs",
"vshiilbmswuuiqfdqxctgmstkh",
"qprndroiqbcyawphqovbopyg",
"enrnuj",
},
},
            new StringArrayStringE1M
{
    Id = 190,
    Value = 
new System.String[3]
{
"cwsuqbxmaavfuj",
"fgglpaxvjfvpiypmndicobgwgbj",
"ylxfqmxruufaobqniscbfakxwoq",
},
    ModelInner = new StringArrayString1MI
{
    Id = 190,
    Value = 
new System.String[4]
{
"osxggeiopqrliv",
"dmeyrguoogedygsaqg",
"tgdc",
"sogsyllismryihvppebaixnbe",
},
    NullableValue = 
new System.String[4]
{
"tyvenlfmqftgs",
"maxrsdw",
"xbretbieeqdtadvpa",
"fxykiwwxjyswnqerxsmjtar",
},
},
    NullableValue = 
new System.String[4]
{
"cephecvfbatmfpfvvhaqffocn",
"jvggadnnhw",
"ckanrbmcpgwmigfrfcmi",
"ijpqpykucjnthxbvfq",
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringarraystringe1m(
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
            asPartInterface: typeof(IStringMArrayArrayString)),
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
                    await ((IStringMArrayArrayString)this).InsertModelDbConnectionAsync(
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
                     ((IStringMArrayArrayString)this).InsertModelDbConnection(
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
FROM gedaqtests.stringarraystringe1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringArrayStringE1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArrayArrayString)),
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
                    var models = await ((IStringMArrayArrayString)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringArrayStringE1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IStringMArrayArrayString)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringArrayStringE1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

