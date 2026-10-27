

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
    Id = 6,
    Value = 
new System.String[,] { { "wryawhxckkljcbrr", "vuql", }, { "urmvqrknetgkayaewgxotonwse", "mcmnoohtucfeewveycgngtpwot", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 5,
    Value = 
new System.String[,] { { "imjsloelarrrfqsyfkufmgegwd", "fdnbdxfraj", }, { "aoeegvhcpkcisfjdcwqi", "lukowecywesgvkucrexxnbdsph", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "jqxtuybmlulrtirc", "kcuruuukbbuhasyf", }, { "jscic", "ybwlqtjjwifvyyyxisg", }, },
},
            new StringMArrayD2E1M
{
    Id = 15,
    Value = 
new System.String[,] { { "pkiwjccruy", "purovskmphuerrkpyngvrn", }, { "vd", "kcloodxkgtteiqoq", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.String[,] { { "rfcbdoukmbqiiw", "oiyce", }, { "xuhlugqikm", "rfvutgxerjkjjkgpxhlx", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 17,
    Value = 
new System.String[,] { { "nakyxlimnrrgranrslx", "qslttjumipnlaqomrmm", }, { "ddgnxysp", "l", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.String[,] { { "xxhcvsuqny", "auvla", }, { "ntefhxsylaphjugk", "sou", }, },
    NullableValue = 
new System.String[,] { { "mocmdeoevpfexmywkue", "ltglgmwiwuliugxvwocpalwm", }, { "pertliyhcnvpl", "yshpurrrip", }, },
},
    NullableValue = 
new System.String[,] { { "rfnspvyptjcpupvfii", "nosljelpbwwayvxvaanyxf", }, { "drqbsqdsimijgygjkcleonjykhlka", "ssrxlordpfhvoymktxfrlvdbivd", }, },
},
            new StringMArrayD2E1M
{
    Id = 25,
    Value = 
new System.String[,] { { "yq", "rnliy", }, { "nyqeulpvwntfbfrbwixubso", "ywlntqdegoxegevavijikda", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.String[,] { { "nhghvpwhbjfybculnxtjempi", "ngysqfev", }, { "", "vvpfgpeojehwdcvv", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "wbjjeblxesqfrrqj", "gmmemgiyvq", }, { "qkhrgnfclw", "iicaaeojcexoq", }, },
},
            new StringMArrayD2E1M
{
    Id = 28,
    Value = 
new System.String[,] { { "ilqluxvpp", "pawmimpptnfordrdvbjklk", }, { "ykmd", "mhaxoogwywlgk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.String[,] { { "uaojbgbmyjp", "bcamgepqvplsvgsdgn", }, { "oqebuneuthmbpqjudttthmttmkosb", "xjybssvrdctokww", }, },
    NullableValue = 
new System.String[,] { { "dtjudvadfueg", "jaunsbqtdih", }, { "tupcofchyg", "fncdkyarvgcxlskcovam", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 36,
    Value = 
new System.String[,] { { "ijxhnabxjwfmdsweqbhbxl", "dvlokqflyppxilvmcuwkom", }, { "iwp", "mhbkvhgtfgtqfuqsfb", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.String[,] { { "n", "uryihsk", }, { "itlelrpdrcwat", "arixth", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 45,
    Value = 
new System.String[,] { { "knkudfnimckcpnsxdebpio", "qdptorkttsgqjgmn", }, { "gcijhywabnbdvmxaaugnkijw", "jrgo", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.String[,] { { "ehsvyapdvarmbdhojscfb", "gnjxdwpxuxquiurjqees", }, { "hucrcnqlorgyswgshdrsfcdvukid", "qlgmiukcpudailqeqsmgomvwft", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "yxwskcxsauqksphidd", "aiusemtxk", }, { "wvofudcknsbdujkchxxbt", "jkglytrfkcfiam", }, },
},
            new StringMArrayD2E1M
{
    Id = 51,
    Value = 
new System.String[,] { { "dysce", "eooimkcgihdxmqlmbtplafrqsnm", }, { "mqmtrhjakpcrffufntlmafiiny", "dngdiekosse", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.String[,] { { "gmvkqnxjjxwlmxvsrykn", "jfvsgtpgjnmcjnxnu", }, { "bpkmryrftqmucepkradvb", "joxilm", }, },
    NullableValue = 
new System.String[,] { { "anko", "usvaqjvpijwlq", }, { "jalxjdnumtsdklgmwiuvckqljtm", "kugvhghxwodlvwoxgukxmnwyiiwa", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 60,
    Value = 
new System.String[,] { { "vptjuoqxsnpesp", "pesgtxbgkkbaohvlk", }, { "ggicjcasvxqchcmwwcturq", "bcdnxjrvhcgoukwchdkwgwptyjvb", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.String[,] { { "ohawvxcdynnyxxowfgu", "xitvllfkconbxicdrwsuwqiu", }, { "cjydcudqwlthksgdngepommpsi", "mbkpqrldgjhexmbrygougcfitwsw", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 65,
    Value = 
new System.String[,] { { "fnw", "rispcbplcnxrrxefhbwruxuectcq", }, { "slsvqwwijekslcucdsemoyfsuy", "fgx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.String[,] { { "nehlkiqmvyfraahvxkcsrjmkg", "ochpviepslxvmibrjtwpldleuc", }, { "ri", "jsoogok", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ckkdshko", "", }, { "srklruqhdhtmmieahnuqajnebwysh", "ibbovjckhknkffxsouktuiunbsx", }, },
},
            new StringMArrayD2E1M
{
    Id = 67,
    Value = 
new System.String[,] { { "hgcidgruancrnfqi", "ee", }, { "ljlayxtoas", "frkkhimpsvngxwcoswoqetih", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.String[,] { { "gkwloxjbckhoujmsi", "", }, { "mgokvraciowxwbyotueggrcml", "orrlwxypsuvjsgpwkgmefwfb", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 70,
    Value = 
new System.String[,] { { "rskte", "nurgafk", }, { "ewcg", "qh", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.String[,] { { "xyhurywreppskhwdkyni", "vwufvplpdyfidnvdcs", }, { "", "icwuymrjhrgrexhutgvyprubl", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 77,
    Value = 
new System.String[,] { { "bpnm", "uphinbpjm", }, { "wi", "dwptufpsneveqjgjydbpmatcucqq", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.String[,] { { "lmxhbdjluldvhtedbmmtgoevj", "jxqqblm", }, { "tphoqyrgrmfbejblve", "kodgyfwclkabgft", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "", "qisvspdxveqfvuvrxnxpwsxspwmb", }, { "vscsukdhaj", "camshq", }, },
},
            new StringMArrayD2E1M
{
    Id = 86,
    Value = 
new System.String[,] { { "lnkglicdkmirdqthvltbuehyiaotw", "bcjmlhenrdlbeplpyeucbq", }, { "kxyjwmrfepsyvwnutcmgwj", "qkeshgcrlngxtxb", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.String[,] { { "mqsnvrvwddnnmeojhnngyta", "lpyxdypdtpapbuohojt", }, { "jjjbrcwvanpuohxogqsdpwexonq", "", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 93,
    Value = 
new System.String[,] { { "irwnjgw", "jvgeu", }, { "sjyty", "cxxnnvtnmxecilxgcpwsqwuos", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.String[,] { { "w", "", }, { "sammlnsk", "ogofyrfqgbwm", }, },
    NullableValue = 
new System.String[,] { { "cxvspnfirpibw", "owwapcwvpnsfgtb", }, { "ibhkgwciwmjuivacehkwilgovi", "kdfpjeimcjrpameyayywbm", }, },
},
    NullableValue = 
new System.String[,] { { "nyjnecdaiubjargsbnffqmdfwt", "jxyyupxoqocidsylktxcqikcogkuu", }, { "rvbxxnhiknqgyxiybkenuteeour", "esu", }, },
},
            new StringMArrayD2E1M
{
    Id = 94,
    Value = 
new System.String[,] { { "sbvykpokgfll", "eudcyavydbonit", }, { "nwoyv", "mtmimjmnaqkdlyme", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.String[,] { { "xorfxnvbdgxprpxrnmxgcvaadkq", "ibrqths", }, { "vhlsidwksw", "kxgdsqcgodu", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ybnloofsybjv", "jehoves", }, { "folkmavflnkioawtskmmpp", "swtjsoccvlfenyg", }, },
},
            new StringMArrayD2E1M
{
    Id = 101,
    Value = 
new System.String[,] { { "jdthbypmeyanpnpx", "tbfrbgmbqflbhlku", }, { "gatsojbi", "mdmcrvh", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.String[,] { { "ahvgapumoybrv", "nbpcwhbvndmgw", }, { "elonfbfnsn", "agqjxkdnushkknuqhysmbjmoyxbjp", }, },
    NullableValue = 
new System.String[,] { { "jtvwitsqaftnfwxiudgo", "yh", }, { "tlaptnlnkbvwwnsktseidr", "ye", }, },
},
    NullableValue = 
new System.String[,] { { "vtqocdreynktehjy", "tweriimmrvhvxlilqarlwxbfhyiqm", }, { "a", "pdvqapmfmm", }, },
},
            new StringMArrayD2E1M
{
    Id = 110,
    Value = 
new System.String[,] { { "yps", "avupharhtsmyrqbf", }, { "txkjrmseumxyglvupbgdrmyitejfs", "dbaoxlfvbdqulchmxgblr", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.String[,] { { "kemlgadobwmcnbshf", "s", }, { "oskkmkmyfanbl", "ffddvgnkhyrthpdjpi", }, },
    NullableValue = 
new System.String[,] { { "fafny", "lnx", }, { "acroqruqshsijypabrhuhrmamjyyv", "hxohsbqwcuaspqrcdlmnyivsmpfbk", }, },
},
    NullableValue = 
new System.String[,] { { "ywqrxwqpm", "ckfst", }, { "nywblfrxawhkicxhaw", "rwvecldvecmbnjtsgpeejpf", }, },
},
            new StringMArrayD2E1M
{
    Id = 113,
    Value = 
new System.String[,] { { "assyvgdiqwqdineqtihouaepg", "ffl", }, { "aieudtvkvjnw", "gfuscwhffcsshfbxcwbl", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 104,
    Value = 
new System.String[,] { { "asacknbfmhumbgnb", "", }, { "ukuvqry", "qhadjywbbtsbbkggegjkjb", }, },
    NullableValue = 
new System.String[,] { { "ujkp", "opnitanksjrstnsbhmtslurm", }, { "gdyi", "tlnvhenfxccaguqpkkgaflg", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 114,
    Value = 
new System.String[,] { { "gbxljnsbrqhkgtrwawwub", "lwltybaf", }, { "hcxpthhswhqgqibgcpf", "ebuogjmdgvqkvw", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 107,
    Value = 
new System.String[,] { { "cvdpvgtaegg", "sviyiw", }, { "qwpogoubycjnysubnkhbrjgdspip", "jyslaptftloqwwivgwfrcjyuh", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ibddjrwsloy", "gehf", }, { "hodlytf", "aorbiivhksi", }, },
},
            new StringMArrayD2E1M
{
    Id = 115,
    Value = 
new System.String[,] { { "icukwiduai", "ewrklikjelnjuwugflblp", }, { "brwqnymlxb", "efcddlxwkbetkeowxxdfj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.String[,] { { "cloba", "ytvhrxbeoclfnmy", }, { "habbbndervb", "nepelvolgimxxngil", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 122,
    Value = 
new System.String[,] { { "rlqgaokijuricejenm", "fhyftrwowxqaebtdj", }, { "obaixrvephrdsqsvn", "cgbovouujjukyahstcrgei", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.String[,] { { "t", "ghaxuueosjpac", }, { "pgnpvpbunjvt", "abipiwxdlymnwdkjqqxuhmooenbg", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 123,
    Value = 
new System.String[,] { { "yifnqqrhdwyebqeyqep", "iafadinaxbpltcppqmvusieyo", }, { "gpcaklbwgt", "cejfyfggslxhwtxxswdiiiqfti", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.String[,] { { "ukykxhmlre", "btqyqfldgrfvddeuhyuhhqdflif", }, { "uvebgmoaqpsveancfe", "rhvlkvirotjxftvycbyfaxa", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 124,
    Value = 
new System.String[,] { { "q", "h", }, { "wupjdqi", "qidlssqvfaph", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.String[,] { { "vyhuxdianueacjlpbsrbbhgdxv", "sesbubreexdtxxupmckskbynpe", }, { "aevbhqruyffkuotki", "kgyyvglfhnhahxygh", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ueixckfstbh", "ek", }, { "sydlouqrmdwuwwykifixs", "uqougefxdjcgtoeunkxwapfn", }, },
},
            new StringMArrayD2E1M
{
    Id = 133,
    Value = 
new System.String[,] { { "ssfyprpcgoxituqwxme", "mevrjbpixyuhpdhlsonscjchvciw", }, { "qteadlxiemeuaemplxfy", "kk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 127,
    Value = 
new System.String[,] { { "vrrisqqgx", "apxanqjxjcva", }, { "s", "r", }, },
    NullableValue = 
new System.String[,] { { "nqvdbrtefckcvmpjpiey", "mxlgdhdmdqlaora", }, { "npstgsmlkudpjpqtvymlsdxtvdk", "btasrripblaagkypjxvy", }, },
},
    NullableValue = 
new System.String[,] { { "mcafcrush", "jjqarjbnukcouswjekbkbsa", }, { "emjnikdgoykkdpyjkns", "moovjrfh", }, },
},
            new StringMArrayD2E1M
{
    Id = 135,
    Value = 
new System.String[,] { { "hqyuhsvtejlasqbbukngfcpkea", "ybkownkiwscygovfnnnhuptnt", }, { "gegcjbayfdonkmgshhjdihvlynus", "stjjidlcajxnoasaelgiu", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.String[,] { { "hjkrxhrkrdgkixtwnrid", "ti", }, { "lwnevfl", "bdf", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 139,
    Value = 
new System.String[,] { { "uatnvnrwglijukvosbvkjet", "ubbjrloufkvvohi", }, { "mqbghnhvfadceamrghqhhuuafq", "kjrljoakduwpsaohpla", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 138,
    Value = 
new System.String[,] { { "sskxmeyrptxdkwfwsl", "dafvpqgaldvjtk", }, { "uejatlff", "qfmlewopbvuvdnjjfacuijnowuc", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 146,
    Value = 
new System.String[,] { { "qvdkulyerworbudp", "miodnkggjuqag", }, { "gavicqkvdwbjrlkfokdlpjoqgg", "vhjsccgmqdxcclq", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 145,
    Value = 
new System.String[,] { { "updqkeuccbfxiwvtbedongndys", "unpvdcebxp", }, { "tbyyak", "ulfnppwcdjtblsrrola", }, },
    NullableValue = 
new System.String[,] { { "kfdkrgkainjjrrwyvaabaepm", "eqatbtrywblytompqdkdjotolh", }, { "epelfsxjrrkqcakyblbgrawopmex", "iiquchlgtdu", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 155,
    Value = 
new System.String[,] { { "tddpvygoptlupip", "o", }, { "qohdjnshckijtlrvdguhhffo", "tiaoywf", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 148,
    Value = 
new System.String[,] { { "lmxscpcmdyfceprbfqu", "kljucnxkarjj", }, { "biifdbbchfmcfwogktlifrk", "emj", }, },
    NullableValue = 
new System.String[,] { { "uinigrgcvotxgcxea", "rhlkrclpe", }, { "cxwecvsfqrotomjwjqxdcvijn", "lpbhus", }, },
},
    NullableValue = 
new System.String[,] { { "n", "srpadfvcoygvldjmvgf", }, { "fbaktluajhtskgoolddbtf", "asleiqunpdt", }, },
},
            new StringMArrayD2E1M
{
    Id = 161,
    Value = 
new System.String[,] { { "qrkoqkauug", "tohaoecravajdtqmr", }, { "lunghjkhflrmgjqbsusf", "nnlowein", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.String[,] { { "hrdkaxkuu", "jvmkcpmxafxpnntpoelnmtfgf", }, { "sfbmubotiuydumtymjkxrupvtm", "eky", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "bdfckhlvhpnkpyxtbroul", "rytjvtf", }, { "cyimygjaivem", "bklyyhrlllaycybrnlc", }, },
},
            new StringMArrayD2E1M
{
    Id = 169,
    Value = 
new System.String[,] { { "cashfnwpv", "rkchuycep", }, { "wthhbdtsfhjoarci", "hbyrylofyfgxflugvysbajcedrlmq", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.String[,] { { "rhnyxkyavypudxqddreiwxl", "n", }, { "xnfdiogyohtw", "trmrahy", }, },
    NullableValue = 
new System.String[,] { { "ldbrrixobxydnmyjufpyyy", "wh", }, { "ltdrinssmulleijoqgtypqvgsroe", "pyitxjlhwusvp", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 174,
    Value = 
new System.String[,] { { "oddneuuoejcrxj", "swxxsldmayassgmeunwykpo", }, { "blnmlgjdlcodpxruggfvgqwr", "k", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 155,
    Value = 
new System.String[,] { { "", "hotlkhusfyvqc", }, { "nnlyoknukyptwuktwrjqv", "mkqavoohjkadmtmji", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "inxedeectrqy", "mfxtyio", }, { "vktsleyqnvpcleqmelrgvahsxsik", "qr", }, },
},
            new StringMArrayD2E1M
{
    Id = 182,
    Value = 
new System.String[,] { { "xvbomxrootyykftpcienhwflyexk", "nvsphqtmgdlmvmkqskrluws", }, { "mywokxaermhjrnx", "aiox", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 161,
    Value = 
new System.String[,] { { "wttpuaanmg", "qrrcbgluplybhajaarfxurm", }, { "mbshlciqeiw", "ynaequrgakdmx", }, },
    NullableValue = 
new System.String[,] { { "uxivbaqbblwpj", "qlebiokiwckuliictvdpxkufmd", }, { "modduynuoasbmqivsuqcbsvqy", "ocptpbgfadrpovqvbrtwloyfgua", }, },
},
    NullableValue = 
new System.String[,] { { "pmdxggvxmggnmdrhyjvwxfiyce", "nixwsitpufnjukrfnjhytkccyfft", }, { "eatjyfvxh", "qcpegtmfuxr", }, },
},
            new StringMArrayD2E1M
{
    Id = 188,
    Value = 
new System.String[,] { { "xvtdjxlmxpjosl", "kugfglljxdoqoasjhdavpsbgcm", }, { "vmpkheicxurwjlbo", "lqmaml", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 167,
    Value = 
new System.String[,] { { "hkkaqrlscduwlgwuofanpkqwd", "baqpqkisrmmriymppb", }, { "s", "wxjxgnbjjbjhsblxxorw", }, },
    NullableValue = 
new System.String[,] { { "mtwdwmosaanceehomrnmtmlys", "gkpfijvfycqsdkokwtfu", }, { "b", "wluudjrnodynroxlth", }, },
},
    NullableValue = 
new System.String[,] { { "fvgrjah", "jiicupsaumsrmpweusg", }, { "fkjongktphwfevgbgksb", "nndydybjwksqbpjfrea", }, },
},
            new StringMArrayD2E1M
{
    Id = 190,
    Value = 
new System.String[,] { { "sbldiwslvptulp", "tyyfbpgajljs", }, { "omfhmyyjqf", "w", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.String[,] { { "pokutvrwqrgutmeybc", "bhmfrbduwpnwhqf", }, { "ihukylehtihxgphgxkdpqk", "iwrsbkilvujxekwlhackipx", }, },
    NullableValue = 
new System.String[,] { { "qrqfvjsq", "bnaawvrxgwokfeug", }, { "hnbehvudswvjqsaeishgoh", "bfsgtuxoicbnj", }, },
},
    NullableValue = 
new System.String[,] { { "exxwnqsd", "jffmtelnwaargvoddaisoxwsnv", }, { "nbyq", "cufjuugebhfbrswwl", }, },
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

