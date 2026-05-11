

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
"cncpeecitnsgfftrg",
"gwrfysvlnxhhktlkykwbx",
"wcuppfdgphwckrceicrutukdkj",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.String[3]
{
"sjbnxigyqrlqj",
"bnieserptjxycjphyidofylc",
"vdqhhgksavdnctwohpqyaifcbiehr",
},
    NullableValue = 
new System.String[3]
{
"ovopqagrt",
"qshrhoicnehkhukfwmvdaoxo",
"",
},
},
    NullableValue = 
new System.String[4]
{
"v",
"gexvjoxrsixfnqous",
"fjohmrjfenadslvpfqigckxvi",
"efnjlabdobnfirwlfqymvkjkame",
},
},
            new StringMArrayD1E1M
{
    Id = 9,
    Value = 
new System.String[3]
{
"ewffnueqgsn",
"qtuxrvdbmlqosbrjpjnwhtcs",
"tdhgdoxuvcbcleueo",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.String[4]
{
"xelugk",
"n",
"grdvjpkjjuljdglgvqhngbcduj",
"wvlbgotgmkthohtsmq",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"rx",
"wtytlt",
"ahbatpdwb",
"prasurhpcletqqrlwqbvfe",
},
},
            new StringMArrayD1E1M
{
    Id = 17,
    Value = 
new System.String[3]
{
"fedoefosonbsdxebvqrbs",
"sxxviphvoayvpacmtpsnwvyigmw",
"jnvmoxykettlacbbxnadqk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.String[4]
{
"mqmxkforrokcoi",
"ahiajlihocqocnrnkirhh",
"irrkclrbofpyscfqafvslkwofiafk",
"xvkiaeftdyxnpqscidbyfmivj",
},
    NullableValue = 
new System.String[3]
{
"aarbodkiusay",
"jjraubngawreyp",
"kypwtsibpgbspxps",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 19,
    Value = 
new System.String[4]
{
"",
"djibsowfmhknqptbealbmmtey",
"iljrbpyctojsyp",
"xwlxjsosrclslppar",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.String[3]
{
"l",
"uhjxtropdfaycjlcqafxr",
"nirxmkb",
},
    NullableValue = 
new System.String[3]
{
"kjhfvhhicv",
"v",
"thmjsadhhpqgr",
},
},
    NullableValue = 
new System.String[4]
{
"hwsoukcjvspjoi",
"yvfe",
"uhcafdvk",
"dqum",
},
},
            new StringMArrayD1E1M
{
    Id = 25,
    Value = 
new System.String[3]
{
"wumcqgmufqhvvltluxhbaq",
"eksvxyc",
"vnuqywsbsvdlneikhrtyka",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.String[3]
{
"osjapobyroatlwnrlkyq",
"pfrntdddregybxbescxweujbe",
"hvctvlxinhxiljhpcnkgfku",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 30,
    Value = 
new System.String[4]
{
"hccmq",
"ximvqvxwufhs",
"khhahoobjoonld",
"tdocwvpdeenldrwnpomxttig",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.String[3]
{
"lhbytgndjyqqremxtaxcbm",
"",
"sfmfwhawrkakfbgaounjfuwkdxwv",
},
    NullableValue = 
new System.String[4]
{
"bumrngbotixjvbfykpdlura",
"ybgsfymoewacx",
"oudgcjeroqhqtsqrkfyn",
"uoucjwvdhmf",
},
},
    NullableValue = 
new System.String[4]
{
"fyhoilyx",
"vhsdbtxlrr",
"lnedddqdktqvnk",
"iqtxxgrxmohlrjksjekfw",
},
},
            new StringMArrayD1E1M
{
    Id = 32,
    Value = 
new System.String[3]
{
"oitwsyhvevwlk",
"pkqmwmavixlkyjv",
"yvjrdxyvgeddeoocfcopsxyqrvbd",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.String[3]
{
"gceanbndwc",
"sonorqbhcxphjuo",
"edrnijogvsixfbwjihqo",
},
    NullableValue = 
new System.String[3]
{
"rueawxjnstgkhjynvakltxsihc",
"tddtqyxorxcodjcxotbhfvw",
"wrx",
},
},
    NullableValue = 
new System.String[3]
{
"nufeu",
"bpsxmyerqnawrjdncxmcssj",
"tksachvviuitrrjvivuk",
},
},
            new StringMArrayD1E1M
{
    Id = 41,
    Value = 
new System.String[4]
{
"tssibmfdiqmjfvmnjkblf",
"gpufjmjpbxosxkchbpakcpltjvyho",
"vmmvstklclucswoiyonhdpgl",
"rbelesebsinboqvbladijl",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.String[4]
{
"",
"yfuuqpbwujvliv",
"",
"yewgbhqhbquyyejilnbs",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 48,
    Value = 
new System.String[3]
{
"jqekuxoehhbwvdtvoserydsceawy",
"ifrpfakssmpoowpahtupthx",
"ijdmwgqbt",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.String[4]
{
"hycqoxrkqvncgognpbdelywgog",
"rrbdgtkpwlulwuxg",
"acxlfaqgufccthdunsop",
"atxuiuoe",
},
    NullableValue = 
new System.String[3]
{
"pqdmihdaqs",
"mhyorjfv",
"rtsrmynpxeasbtjivkwscbifr",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 57,
    Value = 
new System.String[3]
{
"gyebqjocminnshkpgyvcdbjlxbca",
"hdliimvffxuopkt",
"tyqfspxlyq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 40,
    Value = 
new System.String[4]
{
"e",
"cqpmhtpmxplmntfcnhiwa",
"jqiknmpchxy",
"niqege",
},
    NullableValue = 
new System.String[3]
{
"osy",
"qfsygcbunqbrxkrf",
"hahsdywjnehsdq",
},
},
    NullableValue = 
new System.String[3]
{
"prskohdxemhmfpdjnywfnimuoons",
"irukktisuyldvanpcjpnllidpocp",
"isqekrsfxiwdkotwlc",
},
},
            new StringMArrayD1E1M
{
    Id = 60,
    Value = 
new System.String[3]
{
"bucvfpxjykexqmnxxqm",
"idsqhiegqqygdugpkeprairdb",
"kxjw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.String[4]
{
"orbtenedinknjtqk",
"eywolejcpqrpcvejkcsxd",
"ojvohifth",
"vvudcssndi",
},
    NullableValue = 
new System.String[4]
{
"ajbmafucdcdionc",
"jffuy",
"xtuyqsuewoxajuswqqwvrju",
"pqgw",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 62,
    Value = 
new System.String[3]
{
"oxqxynxmtauenv",
"",
"rsseurkbhfrwlbjxgfyfnun",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.String[4]
{
"fyghqvpsxuci",
"v",
"lxrnieufdwlstaupfmjsdcckml",
"gnsmwuopfrptijjypnes",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 70,
    Value = 
new System.String[4]
{
"kk",
"nj",
"sxclgaf",
"hupifspmenjeimmkmff",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.String[4]
{
"qxbqvgtvalnyqcjsbeocdawgeqw",
"rgka",
"nofxubcebixxspnlnpkqt",
"fcnpscbolwduyhwepu",
},
    NullableValue = 
new System.String[4]
{
"ewpqpocrdbefrfpdqgkhiqjxsda",
"ea",
"kekfvoruruguypgkaghkxa",
"kfkdhdkfclqqmeyuyfbmvpuof",
},
},
    NullableValue = 
new System.String[4]
{
"y",
"uuvl",
"ylgcdexlg",
"nkvqebtnxmfdxrdhcbglumncad",
},
},
            new StringMArrayD1E1M
{
    Id = 77,
    Value = 
new System.String[3]
{
"ejqtfmlmxwyyjhwenjaffm",
"c",
"okpybqd",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.String[4]
{
"chjngkiasphl",
"jscurmgcjkuawrwjnmvyavugbo",
"fsow",
"nmkgkrkliyqicwnj",
},
    NullableValue = 
new System.String[3]
{
"kfqck",
"kwgsauy",
"ldikrdpnuobwncwrkpgcvxfimwa",
},
},
    NullableValue = 
new System.String[3]
{
"tdjovdwuvlndxurkktettvjbx",
"rkssnpmec",
"jsocvvaqaftbp",
},
},
            new StringMArrayD1E1M
{
    Id = 83,
    Value = 
new System.String[3]
{
"elpcbedtmjlmj",
"pdshncmdmnhmg",
"x",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.String[4]
{
"iltkgxxouakraxt",
"yos",
"ifyujp",
"duojhrlvldlxhnurvve",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"heocapjjrwurjmotplawcniylt",
"pegwrujsve",
"lkkkioldlrigauoljdebxpfddpw",
},
},
            new StringMArrayD1E1M
{
    Id = 86,
    Value = 
new System.String[3]
{
"yobcgrragmalitr",
"plygkyunwsxfktvhnlggtevmo",
"jangadipajcbanmdcesutuc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.String[4]
{
"lhbphgag",
"crdhvwmiwwindtwughyvj",
"l",
"mxqwpmflqtixhnhsoaacpwwewkwo",
},
    NullableValue = 
new System.String[3]
{
"coar",
"klrrvmwnjdrbkgcfyiiv",
"m",
},
},
    NullableValue = 
new System.String[3]
{
"krdgrkfqcukhijieatgxkksvoctu",
"x",
"u",
},
},
            new StringMArrayD1E1M
{
    Id = 94,
    Value = 
new System.String[3]
{
"mxbibpowu",
"oojyptuswspssjiasekkbjv",
"aqshmoejbpjesvm",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.String[4]
{
"neytttkducyxcgcf",
"",
"wl",
"blerkxsrdrbjjyrm",
},
    NullableValue = 
new System.String[4]
{
"upfkoy",
"osrspjfcainnncpdrgvnkm",
"araqetgljbxsmgdlojnwivbrex",
"uaxwxeghshgtwuivomdkr",
},
},
    NullableValue = 
new System.String[4]
{
"vjlskiiiwbnaviyvcjlwaikumh",
"aivfqlorcwpcfvwlncctg",
"flwfqtevmmdmecnviwdpvq",
"ryunxn",
},
},
            new StringMArrayD1E1M
{
    Id = 103,
    Value = 
new System.String[4]
{
"gxpnptfoiupnlfef",
"dm",
"mdlmjgrhwu",
"pkemophfpofpthacpehbg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.String[4]
{
"cu",
"miiklogrlaq",
"uemasnsqgn",
"csbgignavrjpcepbmhutx",
},
    NullableValue = 
new System.String[3]
{
"ffbhsbopuytgpyscviyym",
"ediwr",
"mjewgggkobspkr",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 108,
    Value = 
new System.String[3]
{
"mcewsjybtjhpbbifinqtldhdis",
"iggrarvhcll",
"gevbjiqidwumhhilwouxkwa",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.String[4]
{
"vibdlwaowdsyrbpsrogb",
"qvm",
"xymndehickdsptxuukstllcdnjmlf",
"enqntqtxlgawqbnidaacpxdej",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"badpqxjqjgiwfavpgjxcnbtntdsk",
"jxoycylvpjr",
"wa",
},
},
            new StringMArrayD1E1M
{
    Id = 111,
    Value = 
new System.String[3]
{
"cmpdckqssamfoqd",
"qapviknxci",
"chrqfcdsyaaex",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.String[3]
{
"wvwsmfkf",
"aopwwdy",
"ddjgqdw",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 115,
    Value = 
new System.String[4]
{
"l",
"dfecnorydmvohc",
"dobtrrdw",
"beujq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.String[4]
{
"xskrroqfyowncokb",
"cpcylgs",
"gxqbvdsdbmpjpxawifodpuqu",
"qgypnwkjhxqjpc",
},
    NullableValue = 
new System.String[3]
{
"vrgxylbhykctb",
"pdkmdxmn",
"jpgpif",
},
},
    NullableValue = 
new System.String[4]
{
"aafryvlekidxbcskcjlgga",
"rtmrgxyjh",
"dfpfqhtxyybheqixsnofvw",
"qbplcbwaific",
},
},
            new StringMArrayD1E1M
{
    Id = 118,
    Value = 
new System.String[4]
{
"bnfeiwyiu",
"vwqnfjeijpuequcxhnycqbgmxakgk",
"tcfyyvsrbeexykgkgily",
"eh",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.String[4]
{
"oaahtjnytjkwgvwivyjhxjlr",
"aupjk",
"phyegwuhefyymyrumsymds",
"xtokradpyhnsa",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 120,
    Value = 
new System.String[3]
{
"mxykwdkrwwmaqkuuooa",
"ovnrntmamj",
"xukywrajoh",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.String[4]
{
"sllhwthmeavlgkwqrrojgg",
"qrpdpsbrqn",
"lsglyqlmgmuiitgjaam",
"paejwpkflrwrq",
},
    NullableValue = 
new System.String[4]
{
"ttpfer",
"qawiytdvapgjdo",
"umj",
"kigjimnshe",
},
},
    NullableValue = 
new System.String[4]
{
"anryytywehnd",
"hoyagnnxmr",
"krqwdgvnytyhprep",
"fflgnwwun",
},
},
            new StringMArrayD1E1M
{
    Id = 124,
    Value = 
new System.String[3]
{
"orbnonocujcgbrirtblvuof",
"guafhdd",
"pqq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 118,
    Value = 
new System.String[3]
{
"namtvlkbin",
"omeqmbgfkmckj",
"emxudfjg",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"pxrepkpva",
"fjytjhctmholmyvjhpjv",
"xjeuhqniulkgleqvmkotdkbjuuev",
"phdtfoejgevtpnrcjfg",
},
},
            new StringMArrayD1E1M
{
    Id = 131,
    Value = 
new System.String[3]
{
"sxhveokfvxia",
"",
"vq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 125,
    Value = 
new System.String[4]
{
"",
"hewxvpftqnvbchm",
"aalakkcjahjcjmvgmjgneq",
"qjqdekhj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 137,
    Value = 
new System.String[3]
{
"slucixom",
"pycvlwksqfsgnjbituwcdalbqov",
"luvfgglkynv",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 127,
    Value = 
new System.String[3]
{
"idcfkjvfhurlqjbycpo",
"",
"ljrkfwocj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 144,
    Value = 
new System.String[4]
{
"bgkerkiduihlkeeqvwswhplqgva",
"smvsy",
"rhdorxbmqvunqcajtiwyoelcd",
"aoyavjxxaapvqycvgew",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 132,
    Value = 
new System.String[3]
{
"mjjfpxjyowfelprkjkpuual",
"snf",
"htnjsn",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 146,
    Value = 
new System.String[3]
{
"mjoemypkrxhelswppi",
"txpdulsvrtvwuwsukurgpewpgsb",
"asrdvcblgdhpoinhejaadqbwdgot",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 141,
    Value = 
new System.String[4]
{
"uavosxxuvijshvwikpcodfcgmgq",
"tjirasammxtx",
"huenemccvcssdbfajhkicshc",
"ixkcmksheqcbfaxbktayhox",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 150,
    Value = 
new System.String[3]
{
"skjxjvlikfcigbigkcvlfhxde",
"kkeovandeecvbr",
"jsjgajea",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 146,
    Value = 
new System.String[4]
{
"kbytirtvjpeblemyyxdynnmya",
"aendqgbytjedmolqjdpttyatcwto",
"woxchgwxdlioh",
"gxafxnem",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"kgicauedcdbeh",
"yhmpatufqj",
"oqoghmwmmhmfscgwjalceslba",
},
},
            new StringMArrayD1E1M
{
    Id = 153,
    Value = 
new System.String[3]
{
"spkfsdubdlojnptqlqnsbgi",
"tfm",
"xdxmckedatpgk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 151,
    Value = 
new System.String[3]
{
"bvpavytbsgkdkenfixjvrjqqjjn",
"qpvpqwijcuwhvnrhluhmalmvg",
"fljrksatgobjewrplpiwa",
},
    NullableValue = 
new System.String[4]
{
"lf",
"ashtauofndxjd",
"hyirjbsrgwoctfjqkulgo",
"qsevipqdisclrhikpj",
},
},
    NullableValue = 
new System.String[4]
{
"vdtx",
"ahuyqlnxuonkqoxyoxhc",
"dbkuqjnqcpj",
"xdlmebqshwyxaiu",
},
},
            new StringMArrayD1E1M
{
    Id = 156,
    Value = 
new System.String[3]
{
"ntlexqfo",
"ppqdodednubrmwoblvfeq",
"svvmvfbbuoepiylnspojyoxnvcwb",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 152,
    Value = 
new System.String[3]
{
"qvwvxoydyeieveyifhnj",
"",
"kipfetogyw",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"auygxagmwmifurlmrdpkfj",
"",
"ayoerlo",
"ubhwwrblmtr",
},
},
            new StringMArrayD1E1M
{
    Id = 163,
    Value = 
new System.String[4]
{
"ajpwhxkxhkctipfbixxxkga",
"mtebjewensdofmusvru",
"duyyrf",
"qatyskbbujyniorwpuarnecedcrjj",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.String[3]
{
"lkxqduknhnbgjirqqlvbnawhljefj",
"mqiefrcvivfmmjlgemde",
"cqnufmnekvjlxlnq",
},
    NullableValue = 
new System.String[4]
{
"t",
"wrvimikc",
"ukbaqgvnkbrnfplwiuojuxxt",
"hsedrkqnhbhkxgiwlfg",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 170,
    Value = 
new System.String[3]
{
"jvmdqffotcoomdkqicqqowqk",
"ibrlvoufdijlwmhdhmfilnfd",
"k",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 163,
    Value = 
new System.String[4]
{
"ntghcovukghskrlox",
"npvrmvtajshfaaxe",
"rbfwt",
"rdmmynxrobuahgrdthlainoi",
},
    NullableValue = 
new System.String[4]
{
"bxllybymjahsayfy",
"lnnedkqavjmgt",
"iqqvssof",
"qldthoheashjrbm",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 174,
    Value = 
new System.String[4]
{
"cdhqkxgroeghcgsusnob",
"whgq",
"iokrgdidu",
"nsccwddyeiheokygmqddlyj",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 168,
    Value = 
new System.String[4]
{
"uapoudiplumovbhtb",
"nxebshnh",
"glsfmxoohjva",
"tthhm",
},
    NullableValue = 
new System.String[3]
{
"aiueiegerugoc",
"vq",
"wpyspjxtdjxdbwbfmydktfhfvb",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 181,
    Value = 
new System.String[4]
{
"geubniybmhukpubhbtiowpd",
"akossvjjapxylflhphinsq",
"dtrwgdnsnxfvgpaypapc",
"ptolpddqdmykiynw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 171,
    Value = 
new System.String[3]
{
"ebguiaukylnvuedkpyucb",
"ihucpidtidpyj",
"lccupbwekufgkaohtm",
},
    NullableValue = 
new System.String[4]
{
"onuwpxrodusufoqeeidhpgslprysx",
"lmwlilyudsxtfpimglx",
"scighrucxuyafrttmbbdsjwrhh",
"wxxvdeqsji",
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

