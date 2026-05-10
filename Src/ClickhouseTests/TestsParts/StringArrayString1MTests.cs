

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
    internal partial interface IStringArrayArrayString
    {
    }
    
    internal partial class StringArrayArrayString : IStringArrayArrayString
    {


#region TestData

        private readonly StringArrayString1M[] _testData = new StringArrayString1M[]
        {
            new StringArrayString1M
{
    Id = 3,
    Value = 
new System.String[4]
{
"bvugveusnlbnkwk",
"kncspeawby",
"up",
"idxegboxxhgydkbdfppvnumh",
},
    ModelInner = new StringArrayString1MI
{
    Id = 1,
    Value = 
new System.String[3]
{
"ui",
"mvre",
"cr",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"apohukrmmcsqxspwdfh",
"ivscyrxfargtgiso",
"wlpdnoyr",
"bjt",
},
},
            new StringArrayString1M
{
    Id = 7,
    Value = 
new System.String[4]
{
"q",
"prvwqgt",
"bqjxnxj",
"pkdidwlrphlnw",
},
    ModelInner = new StringArrayString1MI
{
    Id = 4,
    Value = 
new System.String[4]
{
"pvgqkfwefnsqncaocdfum",
"octcbkgkantjnfysulvopfgy",
"ruqvfxfcyxjgnheektyrtoykl",
"ndthcxpyn",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 12,
    Value = 
new System.String[4]
{
"",
"wsjbws",
"yve",
"kbiedlenb",
},
    ModelInner = new StringArrayString1MI
{
    Id = 10,
    Value = 
new System.String[4]
{
"sfupvnsoxpxqegsk",
"kvqepkytteslxcgrhsnghxsws",
"agwn",
"dvyxbhbqdllvv",
},
    NullableValue = 
new System.String[4]
{
"mbtcbinxfcskpxq",
"euibutaonshfmwminols",
"tptinrkeqieqkyvlfkjjb",
"dbfnfnq",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 18,
    Value = 
new System.String[3]
{
"onnirucogmjvntglxjjpvlwiqvtfd",
"xwukcgmttubawohkagawl",
"qcjftbexmjjsfbfsapfgmyklyk",
},
    ModelInner = new StringArrayString1MI
{
    Id = 16,
    Value = 
new System.String[4]
{
"fesdn",
"doxri",
"simyfflroiswj",
"",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"bjpuxkxloajhxiphcfx",
"ibd",
"",
"eyrkmxperklu",
},
},
            new StringArrayString1M
{
    Id = 20,
    Value = 
new System.String[3]
{
"menoehrixpmafvuxjrqlwcahnri",
"nbvgnshlfwnnejwhpbvpky",
"ufkggcmdcfjvx",
},
    ModelInner = new StringArrayString1MI
{
    Id = 17,
    Value = 
new System.String[3]
{
"aetfagv",
"mvygbwxndqqoksfrsbunrri",
"blvrcobdsffaebvibdf",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 22,
    Value = 
new System.String[4]
{
"qjevsfrkftoi",
"ojmohqruocfld",
"ac",
"ubphypabicmfxv",
},
    ModelInner = new StringArrayString1MI
{
    Id = 21,
    Value = 
new System.String[3]
{
"uvwnstmlgrpfejihj",
"jkoqqqtyfavvseildlegus",
"hfxmkccvrexalbm",
},
    NullableValue = 
new System.String[3]
{
"krmjno",
"ldyqypjcqnoyllpln",
"ig",
},
},
    NullableValue = 
new System.String[4]
{
"ysrtfnwpmtviwynatmecjcx",
"nerlfkidlwqd",
"chtvysipaplvtmjuuxgdhsckufjl",
"k",
},
},
            new StringArrayString1M
{
    Id = 26,
    Value = 
new System.String[4]
{
"cqfaepqprugmjx",
"m",
"oireuqdvv",
"qkkawchabyowtnxiwfmvo",
},
    ModelInner = new StringArrayString1MI
{
    Id = 27,
    Value = 
new System.String[3]
{
"eexfnueafuyqpbqsddbyxabagcqw",
"mtkvlet",
"puagykdqmbmsacvnfttnwnpwt",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"barutfwrpweigjbyedpmifrux",
"lermfqmxemf",
"",
},
},
            new StringArrayString1M
{
    Id = 31,
    Value = 
new System.String[3]
{
"cvqrctsx",
"ljkuatxlukeoysbmcjdp",
"kxakwebnmxqpqvawbgnenifvrpkea",
},
    ModelInner = new StringArrayString1MI
{
    Id = 32,
    Value = 
new System.String[4]
{
"gjnpmyxdqeaswegfiqdf",
"unjjwcttfbdjtwqqgbyovosewws",
"nohnaa",
"gbhyagiybdj",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"aabdosnythsf",
"gqrnsancshrvsaavcrsqqaqp",
"uywdnapomjpjfwh",
"",
},
},
            new StringArrayString1M
{
    Id = 40,
    Value = 
new System.String[3]
{
"rurjgfxtdk",
"kprbnwygtagpksbmfrucldnb",
"echtvhuv",
},
    ModelInner = new StringArrayString1MI
{
    Id = 37,
    Value = 
new System.String[3]
{
"slunjisbviajkbyp",
"yekxkgnxnxuewkogk",
"bqopdnjqvtiahbkqkc",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 42,
    Value = 
new System.String[4]
{
"imts",
"qq",
"ascqatfhbqklwbqhy",
"squipwjtdtx",
},
    ModelInner = new StringArrayString1MI
{
    Id = 38,
    Value = 
new System.String[4]
{
"lvihjaibqoyjqmp",
"vwmsspoholx",
"mvxafotdjbgqhnpedwuvc",
"urhsmhygowmxxx",
},
    NullableValue = 
new System.String[3]
{
"dsevlneltfhltl",
"soeplmjhtvcynxmqlfwq",
"epdmfbxkcbuxhvkij",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 49,
    Value = 
new System.String[4]
{
"dpiakglxbqkc",
"nlbcgwawbnaebgutqbdsguf",
"uaofbe",
"ugummdvpfytveqfgrbklvrqa",
},
    ModelInner = new StringArrayString1MI
{
    Id = 41,
    Value = 
new System.String[4]
{
"hyotcdehsnsjhffvoajpdqqyrqvvs",
"llffvfecxkbohe",
"eyhoyonrgvnggs",
"",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 55,
    Value = 
new System.String[3]
{
"jjbwltcqqrqtrsayytyxxktap",
"ndesdgpb",
"xiqmhmbpmfvnvutujjmxhltuu",
},
    ModelInner = new StringArrayString1MI
{
    Id = 44,
    Value = 
new System.String[4]
{
"xlcstdclcrasuhqyitssegemqueld",
"rnhkn",
"xbarjiplabyvwg",
"mfdiyyysdtbbpnhqvprkjjis",
},
    NullableValue = 
new System.String[3]
{
"",
"kdsxnudyqmfyqfxcrqx",
"l",
},
},
    NullableValue = 
new System.String[3]
{
"ikvmujy",
"ofvseuxrgcjbthumqnn",
"o",
},
},
            new StringArrayString1M
{
    Id = 57,
    Value = 
new System.String[3]
{
"aa",
"phhm",
"kywwmhllnu",
},
    ModelInner = new StringArrayString1MI
{
    Id = 51,
    Value = 
new System.String[3]
{
"exoevbabjcnvduppceyfaog",
"tasgnyllqdtyjgw",
"jktjwgxur",
},
    NullableValue = 
new System.String[3]
{
"vbknhgvvumgtypre",
"kxqmpaihcudrwnicurlhpdybvi",
"ottncg",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 60,
    Value = 
new System.String[3]
{
"hnwovxd",
"",
"ydvbngp",
},
    ModelInner = new StringArrayString1MI
{
    Id = 58,
    Value = 
new System.String[4]
{
"frewndbdfeaw",
"hixjlipnlfkudqxlsefesdera",
"bviuxyrfvxiyvqid",
"qpisxrlbkrebokt",
},
    NullableValue = 
new System.String[4]
{
"xfyfvtluerukcdffjcnlsf",
"auikfondchm",
"vphkdn",
"byhstqalrfgdwvavtd",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 62,
    Value = 
new System.String[3]
{
"lvndnwuguvwbhkjohxyupecr",
"tpxyfhamduxrndgjwenpagyrlnui",
"cktoweyyofjhqosjlijhqws",
},
    ModelInner = new StringArrayString1MI
{
    Id = 65,
    Value = 
new System.String[3]
{
"rugwkpnhguwhjgmnhap",
"yqdvhboeqqkpsqkvci",
"ifribf",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"emdttmijawpaolkpbydvrcqty",
"ouslqiakekdtnnwvluinxpxpqmd",
"rxpwbddeainfjqmycynvysvu",
"rlppevpkoetvhfpkmglmpaqxmtfww",
},
},
            new StringArrayString1M
{
    Id = 69,
    Value = 
new System.String[3]
{
"y",
"ybbitsfgexydsyygtddxorrn",
"ldxxkeykqr",
},
    ModelInner = new StringArrayString1MI
{
    Id = 67,
    Value = 
new System.String[3]
{
"vhgggnpbvkgrohpxepr",
"qchqsxjdykmomcchrcmyiuoxaccyh",
"qrdkorbkykcooropo",
},
    NullableValue = 
new System.String[3]
{
"ckannh",
"oipxnqteeqh",
"weuqyijlmlxrmpfydarstv",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 71,
    Value = 
new System.String[3]
{
"ssxgrdlplliqmeittbxnb",
"dgbipajspdbxyrtusqguposmwmge",
"bfrdypsuka",
},
    ModelInner = new StringArrayString1MI
{
    Id = 73,
    Value = 
new System.String[4]
{
"hpqqyvekswi",
"nepggcvbhudxlttmhcar",
"blfpaqsvnxpbfcmbpopickafvd",
"kkxgkiwvkpmkxckampvhcubplx",
},
    NullableValue = 
new System.String[4]
{
"dosclujixjjmtavufgq",
"",
"fgayelbpagcoo",
"iygghvqgr",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 72,
    Value = 
new System.String[3]
{
"cjni",
"posge",
"ogngbuykrggi",
},
    ModelInner = new StringArrayString1MI
{
    Id = 80,
    Value = 
new System.String[3]
{
"ltaqjahncxmlqkuxcvsxwdkhgucb",
"ujqmtqdaofcutm",
"nhtihmhitxnaalrta",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 78,
    Value = 
new System.String[4]
{
"iaoynqmgiwbvtjnaathmhwkjphvh",
"vdxdnosuw",
"ohptsijjfhbhhbrc",
"gyhpxaphylmyvliblgfvbqna",
},
    ModelInner = new StringArrayString1MI
{
    Id = 81,
    Value = 
new System.String[4]
{
"fdxnojwpps",
"nduykcqcvoweexjbmx",
"xamwcxyrpjpcgefd",
"oafrkurrhsegbmh",
},
    NullableValue = 
new System.String[4]
{
"qdyupwgdqpvclnsq",
"qyqabpscktkosycdqaeqaku",
"vdmpkvajjagkpahbaffpw",
"dsgsw",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 83,
    Value = 
new System.String[3]
{
"tmcaefplvjfmgcpl",
"esfqnpepguhcfmxth",
"aghijtrbfsmygixeynb",
},
    ModelInner = new StringArrayString1MI
{
    Id = 89,
    Value = 
new System.String[3]
{
"yjhrqnsbqbhccff",
"vue",
"moufmnlgkxleqgswgdpvffgo",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 91,
    Value = 
new System.String[3]
{
"rbti",
"idpbivb",
"jktkoxobbcgkmmjdr",
},
    ModelInner = new StringArrayString1MI
{
    Id = 90,
    Value = 
new System.String[4]
{
"cvqwoaurbvfooiajjd",
"nstfrpfxelkgdsmauwcgd",
"q",
"rjusevbkgjdjqqlagoc",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"uklxemobkbvjmauxjoxnrh",
"gkovfnc",
"ruxndrvvibnstvscgnhmju",
},
},
            new StringArrayString1M
{
    Id = 99,
    Value = 
new System.String[4]
{
"jjgjhjdfeswa",
"pdrsyk",
"mspltnfnwoiykbdclesardu",
"lqpqlcjxheriminwowrorsxhbnbm",
},
    ModelInner = new StringArrayString1MI
{
    Id = 94,
    Value = 
new System.String[3]
{
"bpkxpxvqqqkpbayitijhhp",
"sncduxteqpnlpcwolviluijfoy",
"xxpvedaapfvlqsdubjqpeyf",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"nrsooxqkejcbudem",
"anuxbmkhkrcmugfifwcphok",
"qfqoaqjfupvmlfdmyhadulpk",
"nxkag",
},
},
            new StringArrayString1M
{
    Id = 104,
    Value = 
new System.String[4]
{
"mob",
"brkxwvcxqhfqloxclfhhfmpcgipyn",
"qxltkeyyufiokojpyinoi",
"lypf",
},
    ModelInner = new StringArrayString1MI
{
    Id = 101,
    Value = 
new System.String[4]
{
"hvkqsqedsugfwfpylblwyuvwml",
"eniymfdcfir",
"qlkohutlmwlvqkfoekcxebekjcqo",
"uohegem",
},
    NullableValue = 
new System.String[3]
{
"",
"npylfjrmdvgmrhctxmscemaykxb",
"akviyvywhuofakjl",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 110,
    Value = 
new System.String[3]
{
"tihrmcujdnublkwtsscporvkadbel",
"lygws",
"tabpqgoopvyfxgwwilbmxxkhjjsbe",
},
    ModelInner = new StringArrayString1MI
{
    Id = 108,
    Value = 
new System.String[3]
{
"dtpailnkn",
"ukwygqavcnylknbnqovfiad",
"aoeimsoejcixjls",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"qvjxmaxhfw",
"otfasphfehksy",
"mhy",
"dpfbek",
},
},
            new StringArrayString1M
{
    Id = 112,
    Value = 
new System.String[3]
{
"deix",
"dqcdwyatkxqioxodlicedfcoa",
"qjrwmcdgqpbcbcxtattsboo",
},
    ModelInner = new StringArrayString1MI
{
    Id = 109,
    Value = 
new System.String[3]
{
"bhy",
"rpauht",
"wbvjnvhpk",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 119,
    Value = 
new System.String[3]
{
"hkkvvemekeeatn",
"",
"x",
},
    ModelInner = new StringArrayString1MI
{
    Id = 117,
    Value = 
new System.String[4]
{
"olekivt",
"psxv",
"ycxgcmwjslocr",
"bicqcimaasghnjrkdlhxypg",
},
    NullableValue = 
new System.String[4]
{
"xrqdjqnvkfrhyjns",
"nhyskkngghcgcnkw",
"asdgkiulm",
"urnifbwub",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 121,
    Value = 
new System.String[4]
{
"bfcukd",
"ysxmmei",
"ddo",
"kiwylveukakwh",
},
    ModelInner = new StringArrayString1MI
{
    Id = 120,
    Value = 
new System.String[4]
{
"xxqhnymfdgbk",
"ltixhammxloqvxtphqxcv",
"ulaohvrvrmauemo",
"ypxpcsglxbcr",
},
    NullableValue = 
new System.String[4]
{
"fqnfplxybelitnbqrpffeonvihio",
"buaxcgcqtptu",
"yamwv",
"gaxuptgfokbmsknouhgx",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 124,
    Value = 
new System.String[4]
{
"ycqourvoiace",
"y",
"wrevrt",
"",
},
    ModelInner = new StringArrayString1MI
{
    Id = 127,
    Value = 
new System.String[3]
{
"wsudbabuic",
"adunuvtbvxmijlaxu",
"oocxq",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"",
"kltncnqumgbagfaswfh",
"effpyitiplbqkvbpxxkgxbmfkb",
},
},
            new StringArrayString1M
{
    Id = 126,
    Value = 
new System.String[4]
{
"llchptpsdfgyvqnukcqjddevpsba",
"cahgjcfbggqxqjjgfpy",
"ivifqtlojusc",
"dgamq",
},
    ModelInner = new StringArrayString1MI
{
    Id = 135,
    Value = 
new System.String[3]
{
"ldlctepupqojyot",
"obuwl",
"kfuitapmnquess",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 133,
    Value = 
new System.String[4]
{
"cjhbphatkwnkehivpwkkj",
"jvj",
"pikbqbejujb",
"pobmwwvyl",
},
    ModelInner = new StringArrayString1MI
{
    Id = 138,
    Value = 
new System.String[3]
{
"i",
"ykuwklgrubsrbibqbaiu",
"damxokilhpkegta",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"flrcjdpa",
"pkuhoiguahtnscrpjfdxxooti",
"lwoyguqk",
},
},
            new StringArrayString1M
{
    Id = 136,
    Value = 
new System.String[4]
{
"",
"jajjyxnsawt",
"",
"irtgjcdhqkfedwjdfbmvi",
},
    ModelInner = new StringArrayString1MI
{
    Id = 142,
    Value = 
new System.String[4]
{
"ygcpxtiwnegiootoqgxqtkph",
"ejwtvhfrofcwnxjycv",
"pmyhjj",
"m",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 143,
    Value = 
new System.String[4]
{
"fluglwxphgfbj",
"vlfudumhccmkiyichdy",
"nsvqufqoarcdfnttw",
"dttb",
},
    ModelInner = new StringArrayString1MI
{
    Id = 144,
    Value = 
new System.String[3]
{
"vpltpukjsbyf",
"cjthkxmjkdtlnynsfsfrdefbwq",
"uem",
},
    NullableValue = 
new System.String[4]
{
"i",
"qyibopksdflf",
"swkglgbgagubixnxbf",
"bshlgpmsvbyorq",
},
},
    NullableValue = 
new System.String[4]
{
"peljruypvxriviqtq",
"ueafqcq",
"ycrmfjgocwqgejhbgljxx",
"oogjggoxdwioeiifxynntjkq",
},
},
            new StringArrayString1M
{
    Id = 152,
    Value = 
new System.String[3]
{
"nisrokck",
"ir",
"indhibakthrrhadgrfdtt",
},
    ModelInner = new StringArrayString1MI
{
    Id = 147,
    Value = 
new System.String[3]
{
"turkjw",
"mghwmxn",
"sxeampmfrccesx",
},
    NullableValue = 
new System.String[4]
{
"gmjrkfjeiuxutoeprjkuyys",
"jlqpcangfjjwth",
"juhnftkcyilrdq",
"wdltjerilvtqqxalbds",
},
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 156,
    Value = 
new System.String[3]
{
"drlody",
"mwfvfteoerhjgbknphfeejaxhtf",
"famlrfuweysw",
},
    ModelInner = new StringArrayString1MI
{
    Id = 148,
    Value = 
new System.String[3]
{
"cwdbxupmnncxsxwply",
"bjqpkjhtkticqavgfgdgoennoxah",
"sw",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayString1M
{
    Id = 165,
    Value = 
new System.String[3]
{
"bvdpbaqoursbsoscowwuprjojkddp",
"tsdiarirqecsmxnxhflesmn",
"dmbpgwqxddsxtjxpdfarfi",
},
    ModelInner = new StringArrayString1MI
{
    Id = 155,
    Value = 
new System.String[3]
{
"b",
"fixlqrmaat",
"colhexbkqjrtwph",
},
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
INSERT INTO gedaqtests.stringarraystring1m(
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
            asPartInterface: typeof(IStringArrayArrayString)),
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
                    await ((IStringArrayArrayString)this).InsertModelDbConnectionAsync(
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
                     ((IStringArrayArrayString)this).InsertModelDbConnection(
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
FROM gedaqtests.stringarraystring1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringArrayString1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArrayArrayString)),
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
                    var models = await ((IStringArrayArrayString)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringArrayString1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IStringArrayArrayString)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringArrayString1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

