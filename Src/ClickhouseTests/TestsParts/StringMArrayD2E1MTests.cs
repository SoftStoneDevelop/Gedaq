

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
    Id = 8,
    Value = 
new System.String[,] { { "vqqdhnsvuekigtlyeiy", "ktxbbmjcisoblfkjuytcfqx", }, { "bevvodwpqjakowlyveimud", "asw", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 5,
    Value = 
new System.String[,] { { "ypmgexlpuewdjpdrdyrmkvoyjqlab", "snfaxkqgepsgbjmhvwwph", }, { "yyhcshdrjftxlymfxrkt", "q", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 10,
    Value = 
new System.String[,] { { "wlgvdmfcpdudxkkcknp", "j", }, { "bprriebuphosjjpordmapqfrllnaf", "oqqpvyidipkpmgqqurmtot", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.String[,] { { "bbgqmrfhcodrydnbfspvtcknhngdm", "wthqvjry", }, { "luhrcbpsgrjlunbwjgrur", "kwddmoorfhmitibbgevnpytwaf", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "nytiskkgkhyknybgmsob", "uf", }, { "rrkrmokilacntp", "cpesbbjgpjvfbnqrgpdyhvgvo", }, },
},
            new StringMArrayD2E1M
{
    Id = 14,
    Value = 
new System.String[,] { { "xqpbrviybeon", "bvfitimuiupglhvgbytytxn", }, { "uvvvccltcrfyguyuas", "oxdrooucpxuudu", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.String[,] { { "pkxrxqtanfnvbpchtmdlos", "aflltrpdfnburwxcom", }, { "mgbuuhs", "wvfnvlwlrp", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 15,
    Value = 
new System.String[,] { { "kqhoeubrwcukyy", "qbvprkpesyhwusuhl", }, { "fmohjdfpedwtadhxxatyst", "ayhc", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.String[,] { { "bawusijnqgfeixtpj", "dwtofenlghx", }, { "fxijaejulx", "ufjw", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "scmipgjudeqieiyxldmqrwpogt", "qvsphkijfahretknvktngabxts", }, { "pxmrhjfscuk", "jxergrcrpx", }, },
},
            new StringMArrayD2E1M
{
    Id = 20,
    Value = 
new System.String[,] { { "qouvf", "yemwngnuvgnx", }, { "glfhooobpmpmolqcnofxu", "deucnmwrscdcpacrty", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.String[,] { { "awldgsbmf", "gijducap", }, { "", "uynmfmf", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "qvgkofjjyukpvmrwxuqbuyhodfkq", "cxbkxgjffgusyxnaqcdcknyjm", }, { "rtmiss", "vovv", }, },
},
            new StringMArrayD2E1M
{
    Id = 27,
    Value = 
new System.String[,] { { "yqgphjdjlvwdoqmgeeaox", "ktshwvlymoxncr", }, { "qfogmeqpkcofkhosww", "mtqywvnloxovyvyiaml", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.String[,] { { "sidodeqtxaqtmh", "nkbhvjkiao", }, { "tgyj", "dfbywjrnacbrxt", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 32,
    Value = 
new System.String[,] { { "cttiiqjfbnmgeqfuadgtbbei", "jebrsdaqwhc", }, { "btgvoflqpfsmwtbuyfmarvabtxlg", "xndycbpirvmtkmgyoyyvktit", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.String[,] { { "bsibxcrkvrsox", "hlejjvdnij", }, { "xlodykixxneto", "tcy", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 34,
    Value = 
new System.String[,] { { "bfruachmjgpjyhhvnvbwguxbidg", "leomknjuawuw", }, { "mxbcsdgnrlgo", "krelrswxmmngfifxcbgdeayt", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.String[,] { { "ntntwqgsbnlremauwiglpwwpv", "lxaspnwsipkris", }, { "dimwrllhjqwf", "buqekrpbaqnwmaaonw", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "xyolvkvfyoyiloulbipv", "svrxlbpw", }, { "jbufyjstbtnipacbgyfuvyjb", "xexirecfdukgdjs", }, },
},
            new StringMArrayD2E1M
{
    Id = 37,
    Value = 
new System.String[,] { { "ulditbptprjmmsjxv", "aqfyocecdyelxmtn", }, { "nwmhhjgjsekqv", "nxovivo", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.String[,] { { "dhiirkwtbig", "ldjpmofmswbkthxtchesmpwng", }, { "aufcdrqaek", "phigmnvbhelydhfhrxvxgujnmwm", }, },
    NullableValue = 
new System.String[,] { { "jptagpdegbpunbehchgdphllv", "jwcrrlmecuwqrtlrvt", }, { "dnik", "lxggrtow", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 41,
    Value = 
new System.String[,] { { "bracabnkdwnm", "eh", }, { "fhwvwxlpxawpvmkgqcogfykpeng", "tnixjumqqpaintgqpecmwrrwfvwl", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.String[,] { { "lmxerdcmfmusysnxfepk", "ecmenpcoivcwdlfsvwsbodlvxt", }, { "anahepparnuuirnmjcnsbwns", "", }, },
    NullableValue = 
new System.String[,] { { "rniqsnthmuigmrvx", "buvckwxlqtvkbg", }, { "yexyihsetjhifqmdnhyt", "wkqjobibcty", }, },
},
    NullableValue = 
new System.String[,] { { "puucpk", "dlmaydnltvrgtexs", }, { "", "nfbpkvqpttlklcjylybuhl", }, },
},
            new StringMArrayD2E1M
{
    Id = 42,
    Value = 
new System.String[,] { { "vkqikpxadwjhaegsicfuyun", "gvwngcoybbcoukeysjytpflxlci", }, { "jsxndbnhdirbpqmqkahhgwqlm", "esqmykffh", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.String[,] { { "fathhjhgwf", "fvotnmpfojilvgfqxsvwdbolegtu", }, { "drmiy", "ywvbyjcgsgitkulgldrvxins", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 48,
    Value = 
new System.String[,] { { "opjttlonxaxutiyu", "twrkdhmhwdvesvtieatr", }, { "emglkawucsuwaxbn", "faliq", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.String[,] { { "mtui", "fyhrprgrdikavvyiicvye", }, { "xoqbeqilkckaicgqwqm", "em", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "tbhrgpdl", "boegmycebksyuvnsltndncgt", }, { "a", "uvsptoyojbfhq", }, },
},
            new StringMArrayD2E1M
{
    Id = 52,
    Value = 
new System.String[,] { { "mngqryxabajw", "cnvrmgxkorbjrpsldjdmnaescoy", }, { "yafmdmnmcbvxhjdbparyuo", "xcyfaiirerorqbqnbsmyknghjrej", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.String[,] { { "myf", "mrhcpykoexijmsvdityjsm", }, { "ftxrxyvdypmupbucdboajegbdecx", "sduikqqltayqkqijavvoerlqjdxmj", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "vffdnmssmeijgjifixyif", "tbbxlp", }, { "vstrootqffdknxagayvpuo", "fcfdadsfxbwasaporh", }, },
},
            new StringMArrayD2E1M
{
    Id = 54,
    Value = 
new System.String[,] { { "dtncmjnxxflpblmscmot", "ivlnhqbcivahenrieffmwwbjkren", }, { "asvjaurutlwiioaqexouxqucf", "g", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.String[,] { { "wdrbiwnqd", "rquhnstshwlbjhxxiwbtmv", }, { "ogqbwkifhvvfjifysqjbg", "ytmqgdvlx", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "tmqcw", "ggrlhw", }, { "", "tohdjvykehqfpadfdxijsd", }, },
},
            new StringMArrayD2E1M
{
    Id = 56,
    Value = 
new System.String[,] { { "mpcihmnouoa", "heulqpmqsvegcnoguibsuitjfod", }, { "ngjfkstujrjjbhixkbr", "knujsg", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.String[,] { { "joijacqryhyoygkdbmdxchqqxl", "low", }, { "durbvgam", "slwfrntbvipluhvjephoogp", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "vdohydjpkedcnjlx", "ykibbpoyhswbrweabjnbvhakfgqd", }, { "chgfpfnenitgh", "uotbjr", }, },
},
            new StringMArrayD2E1M
{
    Id = 62,
    Value = 
new System.String[,] { { "smjwhrvv", "da", }, { "hqmkyghvljmgjibpjonyianojh", "olalvedoqivoptkxpkpvgi", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.String[,] { { "guebqwvqfratcfbjjyyjpnmswq", "rdbtjjsbpqpaafu", }, { "rvnijkildiiyoxin", "", }, },
    NullableValue = 
new System.String[,] { { "jvapcrlcjcyqnhwhelqe", "smgplbfbmkvkpmspnddvdceyhu", }, { "nldsgelmwuagr", "schwmhiqxvutx", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 66,
    Value = 
new System.String[,] { { "gmafwbrlbtixoiikiqpf", "rsegfylukmlhqj", }, { "jgxamdwqhcgvfrdreywtsxjishwj", "qhu", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.String[,] { { "dcyrxe", "cwpfhkdgauvlxhkntusrym", }, { "xnrvlxgawelrbcfptluogau", "uessdjbjaaedhpmysywgh", }, },
    NullableValue = 
new System.String[,] { { "hoyxshe", "vmkcoytayvohbgeevqvmefyvhax", }, { "anbcvdygskqbkofrwtorfb", "ahghmeftjcdsuletyg", }, },
},
    NullableValue = 
new System.String[,] { { "pgpuanvohvrhvwewquo", "eemjmprvhorkxfrxeocta", }, { "ewmmulngqusdaspjdlewkhod", "rmieohjdivkcucvfoerngf", }, },
},
            new StringMArrayD2E1M
{
    Id = 71,
    Value = 
new System.String[,] { { "jauqkasvoulkcsrnbybqtgbk", "mebwdubjuypswvtnmwgdrskjyymgn", }, { "q", "gm", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.String[,] { { "ibplxcgurelvmqrcixhgixeomsu", "mftluwhbpypyseyyvyxiohxn", }, { "lgdrmmuahcb", "ybvtntpofhihpb", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ihnpbfec", "orraqnyvbpqnmxvcsfpqfk", }, { "idrdthyhddjlux", "ffnkvdlpahthrorrev", }, },
},
            new StringMArrayD2E1M
{
    Id = 73,
    Value = 
new System.String[,] { { "b", "uaajmlbjdxldjrtivgouqfgjaxep", }, { "yrcpbawmngadabx", "asvudpn", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.String[,] { { "ivj", "qbcqkic", }, { "nbsypkodoprybd", "et", }, },
    NullableValue = 
new System.String[,] { { "elmxqecnsxrvqxwmjrhlghphbjd", "beyakbsivwjdcdvgfreojwv", }, { "yqldqaviqfkoa", "yfeowhrsnikfrggunevsivbevuhk", }, },
},
    NullableValue = 
new System.String[,] { { "niam", "jefmwjhoiqlqnbyljaorqsa", }, { "mqwaupxij", "ngxdtwppmehtjtyrqyr", }, },
},
            new StringMArrayD2E1M
{
    Id = 78,
    Value = 
new System.String[,] { { "xvihffktbyxkjbeeebxhs", "swkquypfxv", }, { "ereugodjvnrbilwgspwmjcdnm", "ksdqepfmknvsmylcwnyuuxk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.String[,] { { "rpk", "eirlvicxnbnr", }, { "tyjjafvbypbuhrnaa", "dkaxlokjtxldfhhpbygk", }, },
    NullableValue = 
new System.String[,] { { "idhrlohhbcrbcthd", "stfxxthnfsdgiyrusawmkcxiqds", }, { "", "hhmuqvqc", }, },
},
    NullableValue = 
new System.String[,] { { "jvqiqmuxd", "qxw", }, { "vsjevprxuwialssfwijfyvg", "hdbuhge", }, },
},
            new StringMArrayD2E1M
{
    Id = 85,
    Value = 
new System.String[,] { { "ppmuecybifxxlvihdglfgpyrjmg", "nqymefxcakfyhgwvmcjtw", }, { "loku", "qvoccwogxaagijjmlqswnjsvpiltt", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.String[,] { { "fsayarurbnkuuxaccwcxc", "pwdnceb", }, { "vmtuitxmhxlehkeswtqgueqcu", "yjbcu", }, },
    NullableValue = 
new System.String[,] { { "ekytwwdd", "lssbnbujhqftqjkrppnjtdaudeyl", }, { "olsdruesunmvteivpdnd", "cieli", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 92,
    Value = 
new System.String[,] { { "vpvgifgxpkkqmjoiauq", "", }, { "kpfrbfmirvsoyactliohsjxlerws", "aoiaeaxvs", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.String[,] { { "mrohwquyigkngacloodpgxcqcp", "kundao", }, { "fbklugekbqfdmukjrgcs", "kugiaievlsxhcrakrueqvg", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "fnetdfclujrldvrywql", "qrkfehentfgoyatscgdrusotd", }, { "icq", "abedbbextnpxsaewcifp", }, },
},
            new StringMArrayD2E1M
{
    Id = 93,
    Value = 
new System.String[,] { { "icrptdhhxdvhllayqhvpktvsse", "s", }, { "sigyjqabemckyrnpcugpxuaca", "", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.String[,] { { "", "cgbyne", }, { "swklyvvjavhlfdpxmqygmbqo", "juplskvtjuhvtgnndig", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 94,
    Value = 
new System.String[,] { { "qkwtlufdxpfubevtbumogqwgog", "mlcnqmpeulyrkdfjlwoaiur", }, { "jurkwenqcpbgia", "xvdbnepqapsacnhfgpfl", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 114,
    Value = 
new System.String[,] { { "ik", "jgvjxsahehuawanf", }, { "fcudfdmtur", "rcydbfcsrnlpgwliyrfndhv", }, },
    NullableValue = 
new System.String[,] { { "hgepmy", "fnrcqiptgrohij", }, { "qhiwvachvwefwsksk", "txpyisltqphgpfeerotpygk", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 97,
    Value = 
new System.String[,] { { "ogorclkwcr", "tkajardjorcysyqeepndplgpvdtm", }, { "cwoyoftyk", "gfts", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.String[,] { { "dtmevlhtrmntwvjnklnsdqa", "tewbyfspsblwutncrraruckrnmtyf", }, { "xntunigxbohravpgdfepdjbhxs", "qiefutjpwfm", }, },
    NullableValue = 
new System.String[,] { { "dudblghrax", "eduyiqlyqktmuixcigoqe", }, { "fsyqsiidmplcyaplppqprkdui", "ctwnonqymafrqnebwdfjdh", }, },
},
    NullableValue = 
new System.String[,] { { "mwjhclnquhh", "eyedabiagoetndsmurptlcafpglw", }, { "qimoiqtiygrwxsuonovdyecj", "hecdnbduruwnkkvvckltrfmaiyoeb", }, },
},
            new StringMArrayD2E1M
{
    Id = 99,
    Value = 
new System.String[,] { { "nmlfavxrookqgfwieesuw", "xjncyypmikkdlomlcjbheswv", }, { "kmantenbfhmmdgiftepqjwir", "tirkksphddkpmeqt", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 123,
    Value = 
new System.String[,] { { "vyllblngjlrtjfst", "xqcvbgmmtmetdlryfcpmfbqfhsa", }, { "jxpjbrhicxtkantijexixipicyvna", "mcrfllmdlgjtvvhoopmeueumbw", }, },
    NullableValue = 
new System.String[,] { { "oobctpxxhxmvonlflnsyri", "rlppqdacuj", }, { "vxukvyyyrnclbwhleautxagfrqmtv", "rv", }, },
},
    NullableValue = 
new System.String[,] { { "", "yoteuooqtig", }, { "xhvwimpnymexwncfsw", "xgkmdjoqcwbleqiomqmtacmimk", }, },
},
            new StringMArrayD2E1M
{
    Id = 104,
    Value = 
new System.String[,] { { "hobok", "aueibmdfgcfwilewupuoridvmbn", }, { "csjndpdjhqayb", "quddmatctyecftwiib", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.String[,] { { "srtlfbbcyjmiypiklt", "ixhrktxdqxfvq", }, { "g", "pjrinivchgynqcvpxxiopqnxllc", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "cpet", "m", }, { "ekreqjnhd", "croxchlojudbhmcgvnpkkaqrom", }, },
},
            new StringMArrayD2E1M
{
    Id = 113,
    Value = 
new System.String[,] { { "m", "rtamfutdcwulivgiwlxfqkxbwwp", }, { "tikonwquhjgdhlxlgyugfahmhvkx", "bpfitbcemcagruvvs", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 125,
    Value = 
new System.String[,] { { "xumgbpxodxulrwyuovu", "mqhdljbk", }, { "phyfirqgcqweqavusjfkryblsx", "l", }, },
    NullableValue = 
new System.String[,] { { "oxeesehxgvwkmqpwm", "lislbameqthaqhat", }, { "idalwctohigkcccvs", "l", }, },
},
    NullableValue = 
new System.String[,] { { "iiqeabyighmb", "qxucucsiqxjwtnycxtukqgs", }, { "fsxxdk", "kdebrqnh", }, },
},
            new StringMArrayD2E1M
{
    Id = 115,
    Value = 
new System.String[,] { { "rvp", "yafvqyyaatsarxsvafrenth", }, { "jqoseasysn", "vtui", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.String[,] { { "vdkijoeqjpwppltdapldqpqalahtv", "kpgxkktctnmpyuojppqdgxqypckgk", }, { "ehqlpsemcixqbsfgnwydmbvpkrlhu", "ubhkgrggciio", }, },
    NullableValue = 
new System.String[,] { { "dfh", "vnqtnyoqqlvbawfxuromkthf", }, { "fiaohtpiumagmb", "fogapibdttbgwhnrpcjcvfmhqk", }, },
},
    NullableValue = 
new System.String[,] { { "", "pmaioehyjwia", }, { "", "jyq", }, },
},
            new StringMArrayD2E1M
{
    Id = 117,
    Value = 
new System.String[,] { { "eswdnynojaldhpfontveqvaemw", "xukngip", }, { "gmyqyoxcsqteugqcrhhigwsx", "mpldiccjbvx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 142,
    Value = 
new System.String[,] { { "dxswduagaisyqkwpjhlkm", "aixwrwxugmllbgmobwyurxerido", }, { "gxxjmwkhricppbqopobp", "beobmklcofaierwokqmuqhbxkoq", }, },
    NullableValue = 
new System.String[,] { { "oyldbhawwr", "rvnbtippfeeyyxrrcuaakhqcw", }, { "lkbjgcqjvjyktuncqojyft", "jn", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 124,
    Value = 
new System.String[,] { { "yxdwdivdbmurxyiiaufuldk", "", }, { "t", "qtup", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.String[,] { { "godupbvagopiaewjnpicebixbd", "luu", }, { "mxlgpcxacuge", "vgyfqc", }, },
    NullableValue = 
new System.String[,] { { "vggbnygauqorcjkvwxysiy", "eojnvvhpfxvcajfxehmntcffjeosn", }, { "cf", "cptedw", }, },
},
    NullableValue = 
new System.String[,] { { "avl", "h", }, { "ej", "jh", }, },
},
            new StringMArrayD2E1M
{
    Id = 125,
    Value = 
new System.String[,] { { "pwtalpbsdormmdfbftxye", "wypgajvbe", }, { "bbfetyigemvyhbiwewkeihiuvcrs", "bgqkdeid", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 157,
    Value = 
new System.String[,] { { "tiysdghpm", "rxltfphwdurruhaqrbquycgupc", }, { "rifeuockuybeqmxyakmiidins", "illm", }, },
    NullableValue = 
new System.String[,] { { "kxdqhorirocceanewv", "qtmvhffxfsvogkdphmtessunvvbk", }, { "doaeaxrynmvjfdhdiwujfjri", "h", }, },
},
    NullableValue = 
new System.String[,] { { "cfcywydxmn", "wkqvtwos", }, { "xpjdcijaejuaikfdvwbrqdeud", "whnmfbkaalotadhuaimohkprqr", }, },
},
            new StringMArrayD2E1M
{
    Id = 131,
    Value = 
new System.String[,] { { "fjhii", "nohqxrxagxdpsaevfnaoqffromgml", }, { "qrjnghvxvldkcsitvcbkg", "gykehmagxpjxcpcofejbwkhmt", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.String[,] { { "yjlwcyohngdxia", "umiasiim", }, { "tygvvbqitngkavavsgod", "iyeywvfspnlfxklvxbufboybeyenh", }, },
    NullableValue = 
new System.String[,] { { "", "ufhfuuym", }, { "qslcsbbkirjoklgkhcbyuo", "alxjvgtn", }, },
},
    NullableValue = 
new System.String[,] { { "tkd", "sp", }, { "guuknjscofdxplneoyfukyvcvvjf", "fiqbigokwqcdodupehw", }, },
},
            new StringMArrayD2E1M
{
    Id = 136,
    Value = 
new System.String[,] { { "qactavpgxarpyehhvwkrxxsxaxba", "yncu", }, { "raoowvvirgn", "rfldrigloqgwuwghntetixwf", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 161,
    Value = 
new System.String[,] { { "fctcf", "dwepycotsxihjiwkaorxtwxmcfokx", }, { "yilomcc", "ktftlvplej", }, },
    NullableValue = 
new System.String[,] { { "idlehdxbfmnaghwxagmobtr", "tfdbrrgnwirspxxcrx", }, { "edbjpegufdwqbdqpbgoliyaudfka", "pagmxqnylebobmfvvle", }, },
},
    NullableValue = 
new System.String[,] { { "wfggdcyqcbwuuk", "sxcyvkkpnohfprl", }, { "ta", "pcctswpbnhjdu", }, },
},
            new StringMArrayD2E1M
{
    Id = 137,
    Value = 
new System.String[,] { { "dvd", "eaxnqsailhoffmhrcbwhboechlaym", }, { "nkeadrvlacnrjtjjebtnilncj", "sktv", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 166,
    Value = 
new System.String[,] { { "xmaudvjxxhxrsbhqixrp", "fitqaoewwfotpogkibeunjlldn", }, { "ucdf", "vwqkgsjwnbk", }, },
    NullableValue = 
new System.String[,] { { "qirhdiswrcrfaixfxwmcnw", "hpewchrtctnakxhuu", }, { "", "vamysrmmt", }, },
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

