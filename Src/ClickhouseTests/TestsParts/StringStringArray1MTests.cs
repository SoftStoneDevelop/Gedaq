

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
    internal partial interface IStringArrayStringArray
    {
    }
    
    internal partial class StringArrayStringArray : IStringArrayStringArray
    {


#region TestData

        private readonly StringStringArray1M[] _testData = new StringStringArray1M[]
        {
            new StringStringArray1M
{
    Id = 5,
    Value = 
new System.String[4]
{
"jsugmgtvtovyxoubmju",
"joorhwa",
"ucqtevostwyxgnfxwmoivtubeyc",
"kaybbumldekaetlhbdunkhd",
},
    ModelInner = new StringStringArray1MI
{
    Id = 6,
    Value = 
new System.String[3]
{
"ccrbc",
"qhvgyrefodgtuwedlscklofyfeye",
"wfnlaggsr",
},
    NullableValue = 
new System.String[3]
{
"hvvcegff",
"hxbirwsakpq",
"sbnipxadrobpymadliixefyie",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 10,
    Value = 
new System.String[3]
{
"pglegijgycyeothhqpdrvfmneii",
"jqkbabkkaxfmgt",
"xcfgruvaqocgyxbfwprcmucburx",
},
    ModelInner = new StringStringArray1MI
{
    Id = 15,
    Value = 
new System.String[3]
{
"s",
"ebtawtchpmlntkwlnlxr",
"jeyivlkbkrtkmrowqrjkhqp",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 15,
    Value = 
new System.String[3]
{
"utvqjvwwnmy",
"sboxjyl",
"muqvteopsfqhqjbmqmogxa",
},
    ModelInner = new StringStringArray1MI
{
    Id = 17,
    Value = 
new System.String[4]
{
"wyhkgogynkkuddrfwdefvnohwg",
"ojymvfhaimlkvvwiabb",
"rxuhdikjjhqteteunnc",
"ghl",
},
    NullableValue = 
new System.String[3]
{
"ramw",
"jnsogccmkmbodyxfujxpitauld",
"qngxoutboiruxamtevlolqelqhq",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 24,
    Value = 
new System.String[3]
{
"ybducsxwcbgiuwltkwsvyvrnoyv",
"cpukqikufbpgqliiddvltb",
"jxpvallf",
},
    ModelInner = new StringStringArray1MI
{
    Id = 22,
    Value = 
new System.String[3]
{
"wyp",
"iojccuqnvbhcjkhfbqqti",
"ocpxudlblphlcumnltsjmi",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 32,
    Value = 
new System.String[4]
{
"hvsnoyh",
"fagfnolqajp",
"jxm",
"pbso",
},
    ModelInner = new StringStringArray1MI
{
    Id = 31,
    Value = 
new System.String[3]
{
"",
"clwgfxihlg",
"xpmyulttoaflqigknkdcvkwbyhr",
},
    NullableValue = 
new System.String[4]
{
"rilufvpwtvxuabo",
"yqueik",
"rs",
"bcjn",
},
},
    NullableValue = 
new System.String[4]
{
"ryqqgwlg",
"",
"uwcypiyudndyqyxxmrvu",
"jdvwhhijvx",
},
},
            new StringStringArray1M
{
    Id = 38,
    Value = 
new System.String[3]
{
"w",
"bncrlkevxibrc",
"gdcgko",
},
    ModelInner = new StringStringArray1MI
{
    Id = 35,
    Value = 
new System.String[4]
{
"vdbwtrmjtkuoyikmfqckvlge",
"smeugodoqubhalhmqupapjvmcrnk",
"gvwqgnmtovgfn",
"dvlxgatlyeqqmqlmbkrjt",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 39,
    Value = 
new System.String[3]
{
"ytbumhqdjordb",
"obqhcvrfdxfc",
"itsysevbunvhlmehtcclmrxalkwo",
},
    ModelInner = new StringStringArray1MI
{
    Id = 36,
    Value = 
new System.String[4]
{
"iwtlsxwxxislbmeklsgjqyhsgma",
"dgukiftgidxv",
"sjniqtuyfvll",
"aeoyqdfsk",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"huaakwythpj",
"polruttmfydpdtmuptqcacb",
"wdlbwcp",
"mdctumwenwjlcahwhmmugfwwjqmlh",
},
},
            new StringStringArray1M
{
    Id = 46,
    Value = 
new System.String[3]
{
"ugiarwhi",
"whsfktqll",
"oo",
},
    ModelInner = new StringStringArray1MI
{
    Id = 41,
    Value = 
new System.String[3]
{
"khgyiutcc",
"uabwabcyebtvaubbsarfxhrmeqex",
"stebbegvbjajvnujajn",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"",
"hqxqcjqtchoy",
"ujwfawtgkpovgdecsktvmtpafvqx",
},
},
            new StringStringArray1M
{
    Id = 47,
    Value = 
new System.String[3]
{
"paiskifbraxpdxerjqknfa",
"hjwaahuityannquxh",
"sohwayccchnujsld",
},
    ModelInner = new StringStringArray1MI
{
    Id = 44,
    Value = 
new System.String[3]
{
"ssqcuwtfrfejcxrhgysqq",
"kahbiodlx",
"mfmnrfecjiqnvujvqqvmt",
},
    NullableValue = 
new System.String[3]
{
"tkk",
"uo",
"mebwwwumsopwaeqrmvcgppdmidsr",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 51,
    Value = 
new System.String[3]
{
"evaxhruqwmmavryckw",
"ghbflqbhvieeodgcufukflt",
"nbrwjqqek",
},
    ModelInner = new StringStringArray1MI
{
    Id = 47,
    Value = 
new System.String[4]
{
"rlkoqlfntdtuuesyedwrq",
"uqfgoxhb",
"dffcibjoovswluj",
"yvwta",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"khjairxjmfkhrfhsyr",
"aghgmcodllhqeegq",
"hrraq",
},
},
            new StringStringArray1M
{
    Id = 52,
    Value = 
new System.String[4]
{
"bldphlfesabtgflsiiqydonmd",
"raukxpqmchrjp",
"vj",
"oeamfuvhfwsvc",
},
    ModelInner = new StringStringArray1MI
{
    Id = 48,
    Value = 
new System.String[3]
{
"p",
"vpbig",
"iehmaeaxt",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 61,
    Value = 
new System.String[3]
{
"jydwirm",
"",
"novgmsbtkhhyhfqpbktflsoesb",
},
    ModelInner = new StringStringArray1MI
{
    Id = 52,
    Value = 
new System.String[4]
{
"bopnva",
"yvwngsuq",
"cajinjmwksgocutvfyxvj",
"bifmtfarejop",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 66,
    Value = 
new System.String[3]
{
"qqxfgshaxrpynpsydeibalwnhdot",
"qhaoctwarvrsaqrdywktejif",
"kcqwlnqrunnsafstgdnfmetskc",
},
    ModelInner = new StringStringArray1MI
{
    Id = 61,
    Value = 
new System.String[4]
{
"bsvnhpespcuffegmalssgddkglhyo",
"rpomgsfpgovarmlpqh",
"fmiucdufsxcodnmrm",
"bxsk",
},
    NullableValue = 
new System.String[4]
{
"xcilcj",
"jnpyhprsxaycccvnujyaeqpf",
"uolc",
"xenlukyhunspuoppbimqudcatcxid",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 74,
    Value = 
new System.String[4]
{
"yfqmelxcaviobguo",
"ryokcbbgyydrkoljgoyqwewxqhpi",
"w",
"ffhunmxa",
},
    ModelInner = new StringStringArray1MI
{
    Id = 66,
    Value = 
new System.String[4]
{
"fhxkqsejvybqkmjiyusglcwwnsmn",
"osvwvrftiviuxbh",
"ofuat",
"d",
},
    NullableValue = 
new System.String[3]
{
"dogyalinuonneurgkkow",
"onvplaw",
"",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 75,
    Value = 
new System.String[4]
{
"gugwinyvegdvnxsiayejkkucakbib",
"qgvbhjuypo",
"",
"cdd",
},
    ModelInner = new StringStringArray1MI
{
    Id = 71,
    Value = 
new System.String[4]
{
"rokhy",
"mfudocgwkveh",
"epn",
"veojgvsbnlelxpiduuqarkxqgumgr",
},
    NullableValue = 
new System.String[3]
{
"fegimmvmlsk",
"fc",
"sjipnrvitgywwbgtil",
},
},
    NullableValue = 
new System.String[3]
{
"dnsuicno",
"biooetspoiifdiphmfvdniumltbx",
"unluvb",
},
},
            new StringStringArray1M
{
    Id = 80,
    Value = 
new System.String[4]
{
"j",
"vvklt",
"oo",
"dolliocfpvxkyhrdkamuxhmvabjm",
},
    ModelInner = new StringStringArray1MI
{
    Id = 78,
    Value = 
new System.String[4]
{
"lyxoksgpljqgapycrmxvetxroil",
"wohhtebjryqokm",
"dyrwl",
"oippddgbw",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 86,
    Value = 
new System.String[4]
{
"enjbnofydbm",
"k",
"m",
"nt",
},
    ModelInner = new StringStringArray1MI
{
    Id = 85,
    Value = 
new System.String[3]
{
"nmpc",
"mswdtoewvkntidt",
"lyrptneaiiit",
},
    NullableValue = 
new System.String[4]
{
"lovyuvkilycsgtw",
"prrsoqpjcev",
"rmlb",
"iafhoquhotopwxqkqrwhvjxrxb",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 95,
    Value = 
new System.String[3]
{
"sjwnckriwraasulyc",
"uphkedgcsqhabvfarnpo",
"tmbt",
},
    ModelInner = new StringStringArray1MI
{
    Id = 90,
    Value = 
new System.String[3]
{
"ubbdscidigqatdvufomowusic",
"o",
"okidu",
},
    NullableValue = 
new System.String[3]
{
"wojrdlhrta",
"jw",
"rupkgfwpndf",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 101,
    Value = 
new System.String[4]
{
"kyrjqxwsvdrtroncjcok",
"fliodvndtgocxkb",
"jkrcceyfynasgil",
"oskjkuscnymxm",
},
    ModelInner = new StringStringArray1MI
{
    Id = 91,
    Value = 
new System.String[3]
{
"swunhkdmyexsmtkqj",
"fsamokamyagapcwdbiwngvkyrf",
"uygnldmujfuprcnqdrmqq",
},
    NullableValue = 
new System.String[4]
{
"nfxbfdaopetmx",
"omguhcyfqiasoh",
"cqjscxbk",
"ewnmjleqjxvytxioostjldrlpept",
},
},
    NullableValue = 
new System.String[3]
{
"syghdukkgltch",
"ordgscdrwelg",
"hohdoql",
},
},
            new StringStringArray1M
{
    Id = 107,
    Value = 
new System.String[4]
{
"",
"aydcqqnheutes",
"",
"xxvahotruuocdxsxgtixjtyc",
},
    ModelInner = new StringStringArray1MI
{
    Id = 99,
    Value = 
new System.String[3]
{
"pdm",
"nmarxxvcpata",
"lqmnpwaegnatolloo",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 116,
    Value = 
new System.String[4]
{
"kstcnnwxiwvp",
"wx",
"dtkpdgmeybgefhjm",
"lnjlvklaktisvoxnnpdqbutu",
},
    ModelInner = new StringStringArray1MI
{
    Id = 106,
    Value = 
new System.String[3]
{
"oywhulnpcskbugjbslx",
"lexjshfqjyax",
"",
},
    NullableValue = 
new System.String[4]
{
"kkxeytliigcchu",
"vxpdhhislbuqujvmjuhacabuji",
"gfhuuplgbidbkkdhpfasqawlmjub",
"jetiswjjgynexkkhfn",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 117,
    Value = 
new System.String[3]
{
"mqsh",
"vbhibtvcyl",
"ilnpjce",
},
    ModelInner = new StringStringArray1MI
{
    Id = 109,
    Value = 
new System.String[3]
{
"ihfutigqtgadod",
"mhpkxpvakytbeckjuuxhobpkg",
"exdlwygjahfvdkyrfpt",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"",
"txrwsshqesrxrleooqgprswrq",
"mmdiemylikdcrnyeyyjigmdte",
},
},
            new StringStringArray1M
{
    Id = 118,
    Value = 
new System.String[3]
{
"xkouskvpl",
"rg",
"evtnrekykwcmgbhcpd",
},
    ModelInner = new StringStringArray1MI
{
    Id = 112,
    Value = 
new System.String[3]
{
"qcqhsbstdoehhxqifcjbducqrvofy",
"avrry",
"whikckytye",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"nawd",
"moxagcmlqivgckqx",
"ctpy",
},
},
            new StringStringArray1M
{
    Id = 124,
    Value = 
new System.String[3]
{
"ijajkufqerjvostsysnrsseetjsx",
"vqtkptgfqgnuoh",
"ebwehewhlgahbpny",
},
    ModelInner = new StringStringArray1MI
{
    Id = 121,
    Value = 
new System.String[4]
{
"qqvrcqiai",
"ewdaytcbnpcsdapgxahnntaejin",
"hdxyfsrlcfoesywjovwhi",
"xjwuwkrbssrlvnervhkvr",
},
    NullableValue = 
new System.String[3]
{
"rsthqcidkebpytxhegllvvh",
"igivfwqsejashrqomvtvonc",
"phakxrkxhpekhraqmkinuvqid",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 130,
    Value = 
new System.String[4]
{
"labyvbavxdaushno",
"orcecx",
"gsv",
"jdlhjg",
},
    ModelInner = new StringStringArray1MI
{
    Id = 122,
    Value = 
new System.String[4]
{
"vaqia",
"bbfhn",
"icsophvktupupnqg",
"llhpvijjcoauxmpreebtco",
},
    NullableValue = 
new System.String[4]
{
"wjujdodniisnlfiqbstr",
"qrvntmptxvjx",
"gyamroshkcyjebluoibrwhkkm",
"ddacqnhrjboamsdnws",
},
},
    NullableValue = 
new System.String[3]
{
"mbae",
"gnxqxmrikaxjknhtumt",
"mxorigxtryemiyjf",
},
},
            new StringStringArray1M
{
    Id = 139,
    Value = 
new System.String[4]
{
"hd",
"lqbsdtkydchtn",
"fyeepmyefftjlclikysfvynxaifa",
"tolfhn",
},
    ModelInner = new StringStringArray1MI
{
    Id = 128,
    Value = 
new System.String[4]
{
"ahjffrecwrdivmlkhogpcomsfkqcl",
"ajigjowksg",
"vxvtexjerilqwuajyujahruychnx",
"ljbvimckjpgmccwop",
},
    NullableValue = 
new System.String[4]
{
"oipxaono",
"bebsodltcaqfdfsxbumqioqdoq",
"ticyuibamfautqgouuhpckwjshht",
"cvbbp",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 140,
    Value = 
new System.String[4]
{
"jkjejddnvgalyxxma",
"kpmukqrdobcorodhqoanvkggsyavf",
"duwsdbnbgctlbyiewmkqhpthapl",
"toslisxkbmfhxltk",
},
    ModelInner = new StringStringArray1MI
{
    Id = 137,
    Value = 
new System.String[4]
{
"rjyhxwutqwxtxskihosmwyylqn",
"pekrgwlfhdgj",
"wxrjsxcpme",
"adsugcxhxpgpefktsrkx",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 146,
    Value = 
new System.String[3]
{
"qpmyhgwempgfhrmwfptksm",
"b",
"lnuofsdtacgfrwhcuhqglygjgs",
},
    ModelInner = new StringStringArray1MI
{
    Id = 144,
    Value = 
new System.String[3]
{
"aecuvktrytrcfkyvithvxinqd",
"hksyuknscvfxbhdwpoomgnkuqwem",
"ecmseqgbyvr",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"rvp",
"nqhcojcxmgeynypfqd",
"nlnklej",
},
},
            new StringStringArray1M
{
    Id = 154,
    Value = 
new System.String[4]
{
"p",
"yblwjjurwqsbpiwcijemocp",
"iiociyhwsjddxhaqgsilojt",
"ohhkamvhmwxbvnkpvigxyfdop",
},
    ModelInner = new StringStringArray1MI
{
    Id = 145,
    Value = 
new System.String[3]
{
"onrcmshqokcd",
"apink",
"ubxxiso",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"ocmspves",
"tcthcdfqtemyvxgqrsumdleu",
"sewoixrlwsqdxqcqbgrdciaahavo",
"uxkywawatgsfyrxlwurcytw",
},
},
            new StringStringArray1M
{
    Id = 158,
    Value = 
new System.String[3]
{
"hwcxmkiohltheidmuy",
"nhvquwdoifransqlang",
"moscvflmkp",
},
    ModelInner = new StringStringArray1MI
{
    Id = 151,
    Value = 
new System.String[4]
{
"ekhkrtrkwl",
"kb",
"wwnocdmi",
"mlydwbpikctchearkfjwn",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"abihovlchlpniovlpst",
"ouxqf",
"shbbdtpqnvuobnwlgijkdy",
},
},
            new StringStringArray1M
{
    Id = 167,
    Value = 
new System.String[3]
{
"bhig",
"ba",
"hnujevwiyfugbpkm",
},
    ModelInner = new StringStringArray1MI
{
    Id = 156,
    Value = 
new System.String[3]
{
"apmuxfwptgfia",
"dwxbxlgyewnylkqbsbegaa",
"",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 174,
    Value = 
new System.String[3]
{
"",
"mmtuepqgrvuu",
"a",
},
    ModelInner = new StringStringArray1MI
{
    Id = 161,
    Value = 
new System.String[3]
{
"xxmgviycegfvwfxjybbqffhfgd",
"olvuiwlicgqotsho",
"pwtrpwoon",
},
    NullableValue = 
new System.String[4]
{
"yy",
"lkffwhhvawgdu",
"rufvggvuukklvffqnonjncjbgss",
"sldqdtenqtknwgbluxryyahtwj",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 175,
    Value = 
new System.String[4]
{
"uo",
"juvckwfcid",
"xuccnuabrfytxifjvnse",
"ptcytyuqtjcsvovrrsb",
},
    ModelInner = new StringStringArray1MI
{
    Id = 168,
    Value = 
new System.String[3]
{
"mxb",
"nomlcvpdfasjpqysqwkuxcyjvexh",
"srpmxijdpbfyqqju",
},
    NullableValue = 
new System.String[3]
{
"alvxmmkulxecpcn",
"ymawuvt",
"plbjedtibmyx",
},
},
    NullableValue = null,
},
            new StringStringArray1M
{
    Id = 180,
    Value = 
new System.String[3]
{
"ftcxdxxwxsadt",
"wacsftj",
"aecsanjsdfecobxqv",
},
    ModelInner = new StringStringArray1MI
{
    Id = 172,
    Value = 
new System.String[3]
{
"kblybibmwfpdxblsnleokj",
"mnemmtjagty",
"imlwdmrptbxn",
},
    NullableValue = 
new System.String[4]
{
"srh",
"sfmqeiqjyv",
"rp",
"rtddtai",
},
},
    NullableValue = 
new System.String[3]
{
"ba",
"ylqbjg",
"tifylojs",
},
},
            new StringStringArray1M
{
    Id = 189,
    Value = 
new System.String[3]
{
"mvuxfpktfpptta",
"o",
"rnknvcehelnagfgjwoyevooyfxp",
},
    ModelInner = new StringStringArray1MI
{
    Id = 177,
    Value = 
new System.String[3]
{
"vfvgqs",
"akckavr",
"pnumjkdtmmntavkkfgrn",
},
    NullableValue = 
new System.String[3]
{
"ojdpfyykandqkjquypqdlwvpeghs",
"irotphcheimfbpyvbjtnjdcopbwo",
"gtginaxbnknpvvcweimnnjpsk",
},
},
    NullableValue = 
new System.String[4]
{
"bqwlgixmlwmggnkuuinrjuvm",
"dv",
"ovngertunhkbrcgmxqxr",
"krgwnmjunuwejxdxtvyhofoomtit",
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringstringarray1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:String[]}, 
    {mi_id:Int32},
    {mi_value:String[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArrayStringArray)),
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
                    await ((IStringArrayStringArray)this).InsertModelDbConnectionAsync(
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
                     ((IStringArrayStringArray)this).InsertModelDbConnection(
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
FROM gedaqtests.stringstringarray1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringStringArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArrayStringArray)),
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
                    var models = await ((IStringArrayStringArray)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringStringArray1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IStringArrayStringArray)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringStringArray1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

