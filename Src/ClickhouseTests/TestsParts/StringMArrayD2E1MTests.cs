

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
new System.String[,] { { "eavoygctmnuaggs", "pddskpgixl", }, { "ey", "xstvebwnvcew", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.String[,] { { "", "mbcfb", }, { "vpufximwxkyl", "vkilijrwtygnrkgsrxacpnfovdrj", }, },
    NullableValue = 
new System.String[,] { { "xvsxshnwligyjr", "jngrqgkhmechdtykssrxjnsuqj", }, { "miweoqetidekickjdhu", "nl", }, },
},
    NullableValue = 
new System.String[,] { { "hamtlawajnbcv", "djwexawpssktpoebtf", }, { "w", "b", }, },
},
            new StringMArrayD2E1M
{
    Id = 13,
    Value = 
new System.String[,] { { "clchev", "n", }, { "sujpeednkovfiuavpimqgtc", "rrfbbsaj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.String[,] { { "aprsehgylc", "ksqhkypypooryibsktfwijygefg", }, { "vtjwgtbmpxxctlrg", "etnkxkisqwtbfxufi", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "eivrsbjpyxtewrdefjxycbvbou", "aukbhkhlpcqxutmxfdbcn", }, { "jbpgopkalkvrsebsxsc", "ccslsngsyrttppiwdyubdlx", }, },
},
            new StringMArrayD2E1M
{
    Id = 18,
    Value = 
new System.String[,] { { "qvrfylgdjtrhqjqrcrl", "wjwjxr", }, { "ymuwccmivbarhqeslxglmq", "hqhphqdnodnofnbnstsusmpoe", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.String[,] { { "n", "xhwjxkqbbfyrmedvslmncrddhe", }, { "vvqtxuciyinmjdgh", "ulihcup", }, },
    NullableValue = 
new System.String[,] { { "btxietajniftkltcbxondigtpshrh", "whrslwkdhgmaum", }, { "mwh", "gfqqw", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 24,
    Value = 
new System.String[,] { { "asrmvjecl", "ktyijheidjrgmugxqefjqu", }, { "tnenmw", "qfuqvlixruath", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.String[,] { { "x", "skbvnavlvfvilwpjllhhmpwmbkowv", }, { "dbvughytlqklqcpaplc", "ofphhvkmwxnokwevebtkytxmcrod", }, },
    NullableValue = 
new System.String[,] { { "xmwvqpfiimxqqypyypreprafchu", "gfgnrmklmpololutfnspohrscg", }, { "dat", "hr", }, },
},
    NullableValue = 
new System.String[,] { { "u", "qarjqlcjr", }, { "apg", "odxaelhvntbel", }, },
},
            new StringMArrayD2E1M
{
    Id = 28,
    Value = 
new System.String[,] { { "kbdwjbjqilmpdnxrurfyrm", "seirdxh", }, { "sr", "xo", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.String[,] { { "lcwbthnsbnmhwoyaqxfsyix", "xu", }, { "tsqc", "mmenuyuibrsk", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 32,
    Value = 
new System.String[,] { { "meuygtfvsiaxkl", "ajcfwviqjqekjyms", }, { "stirpwrkvovemxt", "bgbrsrqlnvkmtmsatlqnipxkmvgjm", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.String[,] { { "stmhlxyxohg", "exmbmybkljremopbi", }, { "lguvnrgrhsqecyj", "mwokyaxn", }, },
    NullableValue = 
new System.String[,] { { "lujmqfl", "lllrlmlcthqeytxubhvjnlc", }, { "ankuupfcdgjwrbonnrybw", "uicdfjjplvhehoxwngvkkfpg", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 38,
    Value = 
new System.String[,] { { "abgwioucik", "dfnuaeyoxqxqctqq", }, { "jsbgnpmdwmp", "xayelnxxrwx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.String[,] { { "dvqvsokbadnbpwuaim", "wf", }, { "pclixydiiotrrb", "xselukmfbn", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "nb", "dpvogpmunujxqdpcmbdw", }, { "cpgkcrjfcoduwanssv", "ukjpqhtihwfjtelumau", }, },
},
            new StringMArrayD2E1M
{
    Id = 40,
    Value = 
new System.String[,] { { "dhpakxncun", "xejgsitlacaivh", }, { "dncslvambdwxb", "f", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.String[,] { { "fcfxaubymdpubticpqmrsok", "dqlkeqfpfrlb", }, { "wkvqkdodqiku", "jlvwclqjff", }, },
    NullableValue = 
new System.String[,] { { "gstoorqocvtooctuohhqluaobosc", "gkklpdgtjqdxfohqik", }, { "orjcvpuychhpxqlcs", "hdreuwwfktkxphaulgf", }, },
},
    NullableValue = 
new System.String[,] { { "vmropfivotqmeousplcdw", "jadkjmobrfwohvysktjkwspqrly", }, { "nuihverlghdmlbwwyyqvpfvfmfm", "kma", }, },
},
            new StringMArrayD2E1M
{
    Id = 43,
    Value = 
new System.String[,] { { "puhxaaeugqohdjjvkctmjnjfw", "ipuvoi", }, { "wrxasvhuqprb", "somk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.String[,] { { "jebgetyphxykjnycsnionv", "pbhgbbxvxwmgknof", }, { "yqyhf", "ytxubbbiirpnjoewhokkpyqsef", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 46,
    Value = 
new System.String[,] { { "qphwuckudiolofnjyrjos", "qrkmhiqggxr", }, { "rtngfsweeqto", "x", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.String[,] { { "rrrnrgabvbjqllldwrgyhwpelirhu", "fpfhvq", }, { "kas", "cjugjfenfuwececm", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 49,
    Value = 
new System.String[,] { { "bcxgituhadfokentgieafvhlrn", "shfihtgsxausvdojvvqnbpdc", }, { "ufqeqpglqcsieqxklesrrxmrimfu", "hgsflkrimhocfkjcwh", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.String[,] { { "vdfuxkssafsogprrgnkykgbxbcrb", "kehfsjnmxeoflavpmxxohufaddq", }, { "", "mxmlhhsondavdwswhsjf", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 53,
    Value = 
new System.String[,] { { "hltqnfikmenwtplagk", "ockptya", }, { "uddwhfimukbokfjyav", "bxl", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.String[,] { { "dxy", "tbeyyyqynahjwkeufxrdiu", }, { "nbqgvsxrjvoiyhfifwjiacrhsx", "noeticbycgbdkxqgjd", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 61,
    Value = 
new System.String[,] { { "", "drorekgcbdjgmuddahrxfxhce", }, { "cxhxiknexiymqmesb", "e", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.String[,] { { "naij", "kv", }, { "auiiqacesnnsjlyjoyjhof", "sptkbxewnvnwvuxhkmygmv", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 64,
    Value = 
new System.String[,] { { "qpwonepkdkn", "wrmvgwkfaargfjqjwdxtdcp", }, { "qsg", "xksbbjcj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 62,
    Value = 
new System.String[,] { { "brirnbkd", "yuallley", }, { "rakonahrxufaqtao", "", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 71,
    Value = 
new System.String[,] { { "ykhoxqmgnxbsetcvavvegdifgvvq", "xhsubvqrbqdoggeovaivbc", }, { "iu", "cylecetxgopqvrekuutemux", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.String[,] { { "vyikdecclhndgbievfvfvbdn", "wcpojcrmgeu", }, { "wgplj", "pvvlsmyxbakrxnfgtotubwww", }, },
    NullableValue = 
new System.String[,] { { "pjuwaupegwrtmnajoqkctblact", "idxmtykvmxmwfkxshqvr", }, { "fbvkmhmppesyqsrbcjs", "sxcwefwdwkhbrkwsbdftmuoqwr", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 78,
    Value = 
new System.String[,] { { "jyqcrj", "eawiuipokdlbgxtjtjgwlxkxmf", }, { "lhusmebfwrnvpqgryclotvdjkwtbx", "qegemrblahmphfjib", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.String[,] { { "fnllgalsaisgjxregqfolse", "inlchdiwaw", }, { "ixlfwtpjhcloqayivrvrw", "wulfqwxaenmjgopnglwq", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 80,
    Value = 
new System.String[,] { { "b", "rffejvdlvxmqfcrjjjkbvhjtsa", }, { "xu", "lwgiaagsop", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.String[,] { { "ygdjovctafhskbpxwwdwkrjdpt", "eohx", }, { "kfrhjqvpkobqvrjfgaywydf", "", }, },
    NullableValue = 
new System.String[,] { { "sicnlrmjhimyjoqk", "lcjrofsqosupsotdoel", }, { "efvylltbfubxxkrertffnq", "bjjvhhka", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 85,
    Value = 
new System.String[,] { { "ip", "tnpvdcowypf", }, { "", "rnilcvbctvsmahyye", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.String[,] { { "xqygiugxbmnhdaehvxg", "tcbfanblatjipieprknvktelwc", }, { "amtgf", "etsjladrwdgx", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "vrmpeoljhhgmiwdtosamoxtegm", "lcbvjxgnogwabfhliyeik", }, { "xpqvjrfrm", "txmcfknqcqahqnghahxdrenoobke", }, },
},
            new StringMArrayD2E1M
{
    Id = 89,
    Value = 
new System.String[,] { { "qhwf", "jyvpokcyrxovobgncrhmesgdi", }, { "", "gorph", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.String[,] { { "dtbcckdbuefsy", "cmxabyxqkqwuqgqeeghnodqpgwfoh", }, { "lbqwcedc", "mrjkfva", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 91,
    Value = 
new System.String[,] { { "ydeenaudxndjtgyejmbljlpjoi", "mpkacyarxljdygvkhkbvv", }, { "", "vuwjirk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.String[,] { { "o", "m", }, { "fug", "tvfhctpobexknriphs", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "jlccubkkaiylydergfgtqgyb", "mdwwwqwknrkd", }, { "lpwtxivxrjdqkhtmjxcl", "wbtrkfpaerkhap", }, },
},
            new StringMArrayD2E1M
{
    Id = 92,
    Value = 
new System.String[,] { { "wjkksyiqkgbgpgisrhuhngwuafks", "srkjiopsmbtifeednjmhhwc", }, { "rmnfbeoupbhqqffh", "swtehajrteqtacvxatehdjn", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.String[,] { { "gcerjii", "goj", }, { "kfkcjujl", "j", }, },
    NullableValue = 
new System.String[,] { { "smgxgwi", "amyavdvliaiju", }, { "anxxk", "gxbic", }, },
},
    NullableValue = 
new System.String[,] { { "ecsbxuivgdaesbiffgmya", "yderjbefwtnlvxxpjkqkjigmthgb", }, { "uvajsmsu", "hnbwcdujrvmnaljdeqbs", }, },
},
            new StringMArrayD2E1M
{
    Id = 96,
    Value = 
new System.String[,] { { "eexfiphppmdtmjoecuopia", "jyv", }, { "bvuhejlanwiqheitcghvc", "pmgeulfs", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.String[,] { { "qwxnmk", "ancbvquotowbarsaomhvooh", }, { "vwnwkrccmrxawcrpqyb", "rwwwfdy", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "iekx", "anwdnldurfaals", }, { "prt", "toxumeamkwubnifsu", }, },
},
            new StringMArrayD2E1M
{
    Id = 99,
    Value = 
new System.String[,] { { "otsowtvtdfuwlcmftr", "jvldu", }, { "oxhnnrkqruyfc", "ahx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.String[,] { { "bgmmiqpuhqbgvermesjowany", "mbmbaqik", }, { "ovdxopvqvplvwjkba", "ffkgkuhhljdimrwegl", }, },
    NullableValue = 
new System.String[,] { { "qwavyquulctdduc", "efkcgdbnjchyajqliycw", }, { "olqeqwbwukgwirmtemxsdenpjcrf", "jllo", }, },
},
    NullableValue = 
new System.String[,] { { "hl", "rmbkekvdetvvwriwxbjpjyl", }, { "pajekx", "aqhlhpjfridfnbdennll", }, },
},
            new StringMArrayD2E1M
{
    Id = 104,
    Value = 
new System.String[,] { { "xasvlwmkefhcgncdbqidlh", "auetuhjwmqptiqguryyohdgnrtxsn", }, { "imxmuylfhmtls", "fnhqupdttovpcghmwrhdc", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.String[,] { { "prweduwtfntrprinxnwf", "qxdfxihxmujfufjlrprqodwv", }, { "cokngdxyqn", "vayaujoyidnijxgbhitxt", }, },
    NullableValue = 
new System.String[,] { { "kephgkbdstcpbwmejpvitifjn", "wcuevnsye", }, { "uejqntq", "o", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 107,
    Value = 
new System.String[,] { { "uulbqxjiytncatxlpldcjjqt", "fphwylwjinq", }, { "fuuwplpofdyxqpxbjeupy", "vftx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.String[,] { { "enruhuslyprjnyiijlljlv", "ooeurfedhi", }, { "", "jbompjflhii", }, },
    NullableValue = 
new System.String[,] { { "dojjxjbrbvxqalrqbdqk", "dbybpmaccqoigqkeltydt", }, { "casynbvotlhhoeemuq", "gorp", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 115,
    Value = 
new System.String[,] { { "xdqhoburgerwgxomptgrak", "ocbiottfxnjmafeuvbkstilkkrqlg", }, { "aqyomvcffgoqjoydm", "ikqfoijvhmrhxrymvaj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.String[,] { { "pwfpahbfhtciddpssynsrjbekvaad", "yolhiohnk", }, { "skjnkfniyncnjdejn", "cbreo", }, },
    NullableValue = 
new System.String[,] { { "xidj", "fjbfkacj", }, { "mupvccwyns", "prbshuhvgkngmkmb", }, },
},
    NullableValue = 
new System.String[,] { { "g", "jikjepwpwiuamhvmqcqg", }, { "b", "ocoiybolsshqbixjq", }, },
},
            new StringMArrayD2E1M
{
    Id = 122,
    Value = 
new System.String[,] { { "gehqehlalijxdpkhya", "rqpwygpnsjyxssacbtmcoexi", }, { "lviepsdwdgsdunyojemv", "ajpvnniduxjvarg", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 118,
    Value = 
new System.String[,] { { "rpahkdicklliy", "vdvjhcyded", }, { "pijwowxjepkdhbj", "", }, },
    NullableValue = 
new System.String[,] { { "qewtrxspx", "", }, { "ta", "inwbaagqhbllyddpoluiorfbihfp", }, },
},
    NullableValue = 
new System.String[,] { { "jl", "qbipmasc", }, { "cvjrtwkasbqnmfis", "dedqlhdabnn", }, },
},
            new StringMArrayD2E1M
{
    Id = 123,
    Value = 
new System.String[,] { { "ugrbtord", "fxqwxywvdvqqmhxsahymqeayknh", }, { "aseqaoxwknvhfodtk", "uusrmwakqscxbkcfktxgunupi", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 123,
    Value = 
new System.String[,] { { "efjpayqthlrpnqisphhqrfkkmp", "", }, { "so", "dflypmk", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 131,
    Value = 
new System.String[,] { { "b", "gxhanctejtad", }, { "njonimmsksyq", "dcuxvnfijop", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 130,
    Value = 
new System.String[,] { { "plntfbwohokhatbd", "hmmeeps", }, { "pkw", "xhhrkbpltsdwiohrxhxfeqm", }, },
    NullableValue = 
new System.String[,] { { "lf", "wxqfyaolbvf", }, { "mjmtisgaynyugohrpng", "qloi", }, },
},
    NullableValue = 
new System.String[,] { { "mucjeqsghnmiuxeuuaq", "", }, { "sbykcqhywdvgqjldhkvehcbx", "giigaymotjjovlkjvqkbrunhuagur", }, },
},
            new StringMArrayD2E1M
{
    Id = 132,
    Value = 
new System.String[,] { { "stwujhyodqsseclejymkv", "vdbiuc", }, { "qvqcsjxnnwfrncukyhqfotdpyus", "tnavtfllcl", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.String[,] { { "ncspxcvxeadjaleicqlbcjdephlf", "onuyicpcjuuwpxdckkveteki", }, { "hjqvqlqkohwmdcudqf", "gfdja", }, },
    NullableValue = 
new System.String[,] { { "", "pgthjsoxilijtd", }, { "gaqxlusstshmxhusduu", "vfrqxgeibduuksppsrlmtejdman", }, },
},
    NullableValue = 
new System.String[,] { { "ivydiuptwbco", "sfgbyuxvfkccovuutpgv", }, { "qqcfmq", "", }, },
},
            new StringMArrayD2E1M
{
    Id = 140,
    Value = 
new System.String[,] { { "fgpydnxkmcpifxtvqriruuosyyq", "jakiljs", }, { "sifwrovbhujwoduk", "gaigmnmftr", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.String[,] { { "ihaxttlliw", "dxhlipqkrmxlgrhmdxatvskrlwf", }, { "qqjmaqgbomwsg", "qdyxnojbnpaojp", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "agqvnqpvfvpg", "kdmipmyxae", }, { "fpprkrjsfgduhmepkybvamfwqaa", "thlsiuhbucu", }, },
},
            new StringMArrayD2E1M
{
    Id = 146,
    Value = 
new System.String[,] { { "ynkfkqof", "tsrklqw", }, { "dsevldoqjeb", "xtmkqiil", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.String[,] { { "fjrlnpjohbwbbcqo", "crbvhfyddjlckkbo", }, { "yapinuspkoafuhnobss", "eosjyfaylrwotxhtninbysqgehi", }, },
    NullableValue = 
new System.String[,] { { "yvebkn", "svjvqlnse", }, { "ipybptbvtgdwwcapmgxasytj", "hpquaopmasufrmuxtqwjepc", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 152,
    Value = 
new System.String[,] { { "lumymetrutm", "budkcqykvgeurpoyp", }, { "gmqilmvipgdtvykcuqfldpcksdm", "xisnibnkjoaeeumisvxxowijnvy", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 143,
    Value = 
new System.String[,] { { "tjxrsmyqwqihtstybhxpbpcpadt", "uoutplqpdtgdkxbhfpwttirmwxq", }, { "glelmuu", "goqgvxrnvxtpnsxtmqhltbw", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 157,
    Value = 
new System.String[,] { { "kumbjsbakpvmqyuquxdrjxuleqt", "sokngqn", }, { "ddwqccchdkjbcci", "txrissylegywvkfukcgxlcoulqjxs", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 148,
    Value = 
new System.String[,] { { "fufgrkjtiwsal", "qbrckwii", }, { "bdvksubmlpnowibbiouhqyf", "fdaqmihmjehtntlfbryfo", }, },
    NullableValue = 
new System.String[,] { { "nhfy", "yusqarabxtnbntldg", }, { "jkoriubumdp", "pa", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 162,
    Value = 
new System.String[,] { { "ftqpbpujwxkgyyotriwypbahy", "sylrxwlumll", }, { "ifbepiprnsomdjxjltbeqa", "mdggxwlqujngwqapc", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 152,
    Value = 
new System.String[,] { { "tyyryliqx", "caicbonexnqvqmlsjqdh", }, { "", "ouhyhlsbvhgjeeawyymujsg", }, },
    NullableValue = 
new System.String[,] { { "ahnecsoqtexmxjgcfesxchryhy", "fgvvcblyuxildjfsbrtq", }, { "bq", "whcrusbthsdaexaaq", }, },
},
    NullableValue = 
new System.String[,] { { "rfacuieuqguqkhomfuwhlmryy", "cjwslankof", }, { "utvbshwususkhfixcssirttghuemy", "i", }, },
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

