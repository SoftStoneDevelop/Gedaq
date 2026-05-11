

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
new System.String[,] { { "jtnjdjirrmtwnhwarwysuk", "faprfbargs", }, { "on", "pyxynrsasuhpmlebow", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.String[,] { { "bqfceugfqvymrodt", "xagxkgjuphgsobnmatv", }, { "uumbsutch", "ixcastetgykhksoxssbfjktq", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 12,
    Value = 
new System.String[,] { { "sdhewjhblm", "ffokfamnqeiusxnist", }, { "pwwwcacjtdvwhxakw", "pycbdxugcoda", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.String[,] { { "ylwrttioiyqcquxbir", "lxdskeauupjbcitioiw", }, { "xoblaomnushoxpcdg", "ksqonrpsbhxomyeelqntabpkew", }, },
    NullableValue = 
new System.String[,] { { "", "pl", }, { "usnudfdi", "hgaahstp", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 18,
    Value = 
new System.String[,] { { "lacixccbunysijtsyutd", "wirrxv", }, { "dj", "ersjlqoncqbnsvijvolvxfldb", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.String[,] { { "q", "qpoeqhpoilkhpxmis", }, { "rjxyoak", "avdjqlkmjgcywo", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "kfqjjxnbcgwc", "kcdjirrigxbdmdvgaudbwtu", }, { "vwsnqvkrbdhqprgbkbwituhj", "xfufkbpkxcolcmefyilbaqcb", }, },
},
            new StringMArrayD2E1M
{
    Id = 22,
    Value = 
new System.String[,] { { "gxeejennkyqcldmbnaeieyvxs", "ovduty", }, { "ntwmrfudwpulpsg", "ahbauvhscweqxidvtbxtfemn", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.String[,] { { "sxacaargwwdmch", "ycniyhoioxcisqugexsyp", }, { "isxpqqwhxqjapkokjcfmahrhmderc", "elvrflxcvbfny", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "go", "elgmvqrbilrmfcbdfwlydfgepgd", }, { "efvstqxjgbrtco", "awvyksolpuve", }, },
},
            new StringMArrayD2E1M
{
    Id = 30,
    Value = 
new System.String[,] { { "poblk", "nokpyrhxnttumtovh", }, { "xtyllfcfhnbmxmwovt", "msbhuioxeaowmkhctjaf", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.String[,] { { "ev", "jwbvomhqxdawapaq", }, { "hhhmwloaifypupoaywtseuypfr", "lvnpvkokljhjtqqdthnspummvisyr", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 36,
    Value = 
new System.String[,] { { "sbpvxvgsfoccgwburbtjuij", "kb", }, { "cdjbnuhehjhryiwp", "qvkhpfi", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.String[,] { { "nkmcvyfqfbcckqgekbyfvffjhohmx", "ihspvokxgl", }, { "ctstmdahvpkwmnhyuremhadofji", "txouci", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "psdnkukmj", "btssngwjiqdv", }, { "uwekcmcrt", "dms", }, },
},
            new StringMArrayD2E1M
{
    Id = 37,
    Value = 
new System.String[,] { { "gmhnubsndiaeyeekqdpxjkkgxq", "ffg", }, { "iwcloyrbbeuabpfaakieisowbwv", "yjnrbevvxcgcokdfbwbuk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.String[,] { { "dbhedpmubtmplwjpakb", "vanavajtpt", }, { "q", "fpldrrlv", }, },
    NullableValue = 
new System.String[,] { { "iwxhnytke", "gigoxxvvxlyeelnrsxiobwtjjvgv", }, { "kcyolwltcdueimdph", "xulsimxsptsxxaudntmeyapiwgb", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 39,
    Value = 
new System.String[,] { { "ysdlfjayp", "nmujufrqgpasdukmjlxtssucdrw", }, { "othdhfdogtioamgcbxtpgnj", "w", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.String[,] { { "imctbpiepquslvct", "xtjes", }, { "pkgepwxbgaussokiskdrfejfi", "dqgtleuxkhdl", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 48,
    Value = 
new System.String[,] { { "pnbjsansefleoqywvrugd", "jsngqhjbdvlbovdhsn", }, { "yhwgrfxatfemcshf", "xgjsjspssynrumvmcyexoijxp", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.String[,] { { "jxqwyv", "qdmybjhuojumdwm", }, { "ksevuxwrrastirptmtful", "u", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 57,
    Value = 
new System.String[,] { { "qrdgyf", "eijo", }, { "uqymmwvouoaohdjdontnvxmgi", "xigsqnyswkpxkbejranpfqbikkh", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.String[,] { { "amrmqmeqqfyaskpcqc", "ucooiyky", }, { "hdrymkyhujfamykysjfniyn", "eoboxrmaotnmfkftcugfus", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 65,
    Value = 
new System.String[,] { { "lag", "gltf", }, { "ynhriihmspeafa", "jdccjolgkpbyrqnlpq", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.String[,] { { "kvl", "qjre", }, { "oaqvcioqfekwlqjluw", "caeorvuclymc", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "jnfcjawhwbnpqeeykvgjc", "kdjsyokagtotdycyyterj", }, { "guteintxpkhyswlcdlrcm", "efigscpmpekgwqeyjhwwouoti", }, },
},
            new StringMArrayD2E1M
{
    Id = 73,
    Value = 
new System.String[,] { { "exlnjvdxniuetiksfoj", "rruhhwiosssgsludoxsiveqkhg", }, { "omc", "gpqajnfluxyhvldt", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.String[,] { { "iibicxduuqxvshtkxawnprafebd", "qsqpvrimdl", }, { "frxxoqwbsxrhlwpsmclampwcglx", "kcuwmmctsbb", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "la", "jngeansbaayluheahmhqslsnlluf", }, { "qfciugio", "wx", }, },
},
            new StringMArrayD2E1M
{
    Id = 82,
    Value = 
new System.String[,] { { "ikpaghuajbrilxhflxtmr", "scfunnfnvcjopxkhdflabnxnwuth", }, { "jitlaucdxtmnfonhxcuubelimttd", "smrghsddvmctjingwsna", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.String[,] { { "sagolkasobqhitsxipuxoyagx", "ggyspacmwpenkdrmlqnrvojdc", }, { "kvpvncvkyoccchuf", "wmttfmtnlqowcetqnbfnfjhb", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 90,
    Value = 
new System.String[,] { { "kdnugslrdopmi", "boyqulgjjpdk", }, { "okovm", "r", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.String[,] { { "jjbybsfgmnygbwjmvdo", "nymojkbbobykldmwgiaws", }, { "jvnssnqbwkyihrvdburhbbsie", "nniubtpnmmdrvpdyxariai", }, },
    NullableValue = 
new System.String[,] { { "gpruwqdphc", "dtbcybwwtxtqhphsoj", }, { "wvigxtgnnqmauxpewhwdbhubmggev", "qcwbpgfsmvskpds", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 95,
    Value = 
new System.String[,] { { "wexcyscqtkhxahdku", "cfvuxgphcgrexqebemebkkx", }, { "ghunjusoeb", "qurtrufuivyipbet", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.String[,] { { "rnlvjwmmvojjojl", "", }, { "bpyjm", "cfaqocdtuvay", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 99,
    Value = 
new System.String[,] { { "bbommbmlnbnkd", "jjhxgyihlepsnmh", }, { "wyipfouvblsdpq", "qqlpqgbvrrhdcqfx", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.String[,] { { "tgdpfvdoyfld", "qa", }, { "cavkf", "pmdlkrr", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 103,
    Value = 
new System.String[,] { { "bbuvqrhk", "krsxbrbwpwjunilkodxo", }, { "uwjsbxooeraplmpswfigsmbum", "kaojiaeobnrxauralcptkvhsxdeke", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.String[,] { { "acsetvskyicrdcrqbfcqtifjxpdss", "nfhki", }, { "yin", "rktldbo", }, },
    NullableValue = 
new System.String[,] { { "hoxgsnuimrsxxupt", "flhvwbdandxuyeqor", }, { "tslcxmydmhsgtjglddsakvbpaa", "aogriofmjjtqpvpipcugoeawlyhm", }, },
},
    NullableValue = 
new System.String[,] { { "b", "glrdcusjmwahemtctbagokoeaujad", }, { "ligkvwcpiqbxxfx", "uykxympntloqsfspotbqmx", }, },
},
            new StringMArrayD2E1M
{
    Id = 111,
    Value = 
new System.String[,] { { "bfrbicuyamwrfstueps", "cuvwmgehabnxigukqraa", }, { "pcnrjkdjd", "gxdeqqujitcwfrrolehcbas", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.String[,] { { "yiqqcvnoopaigyqkjraorc", "sfnnuuaoiasovyltiimuouih", }, { "m", "ygbawcerladtikeqtf", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 116,
    Value = 
new System.String[,] { { "iessnvrgxcbat", "eugbaydcmteqjh", }, { "tr", "qceajkxdiwptdipcs", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.String[,] { { "nhveilxnvflliawrcv", "i", }, { "nkwqjbmrumuhvrmifqp", "pbxxdkubwd", }, },
    NullableValue = 
new System.String[,] { { "gnpxatomhoybprjesh", "kphxmxeaodubgkoxbps", }, { "cxjiharxcdevdt", "oxevpntwnhlddldcnpwthvigs", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 120,
    Value = 
new System.String[,] { { "x", "qaapjipufklnpmmp", }, { "ylndutrwmjd", "olwivclhmpvn", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 100,
    Value = 
new System.String[,] { { "btmblxspg", "ajqgg", }, { "ierokqatjkwre", "rtt", }, },
    NullableValue = 
new System.String[,] { { "vymahlirloub", "lyafadmgfgqwudspteqtyg", }, { "oqfwkmg", "aneeprucocxlkgt", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 125,
    Value = 
new System.String[,] { { "cblbhlpwvekjdvtdrtaosaevpaval", "kglmsagfnfxvbqejeft", }, { "mblunbaewpvvb", "pwr", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 101,
    Value = 
new System.String[,] { { "nmicxmcccqovx", "slnmchh", }, { "bfunkgjr", "llbqklunhoifxys", }, },
    NullableValue = 
new System.String[,] { { "jojgfcywfxexqhvvtcicuf", "xmtdvehlbhvpbuti", }, { "salpedopgaqygceaxiwbypqhewhk", "nhhuprittpenuvhwvjyhssemac", }, },
},
    NullableValue = 
new System.String[,] { { "lovmwvlhqshlrkqn", "hqaqvwkplynpjtltbvdnrsmqtno", }, { "dwbbuwnciybornaaqfloyhosk", "nnenqusunwnuwtyj", }, },
},
            new StringMArrayD2E1M
{
    Id = 134,
    Value = 
new System.String[,] { { "ydwi", "bvxuxkdgaynrwtansie", }, { "r", "hxxmjctfueismuyftvkoaciu", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.String[,] { { "vlhrmnexsj", "ippmbeb", }, { "icmistfvihydnqxosmx", "rxoegcabtevfhwrsywjlgkt", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 136,
    Value = 
new System.String[,] { { "qlpcpfhndced", "hexibyrkprekfjwglgxlnompbdbbj", }, { "mrityigsgc", "hqxe", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.String[,] { { "nujqlgbektfwinmctejwptr", "jdpg", }, { "afywpudyfun", "dxnbplatoaqqvlunvvpthspobreo", }, },
    NullableValue = 
new System.String[,] { { "ircembokqxuhejlgscinjxgi", "rdlefliffdostbhpbo", }, { "rcqfqxgwxjthpihb", "serl", }, },
},
    NullableValue = 
new System.String[,] { { "hjngkpsepeurscbmprp", "fnkjmawovnyojyivlyooar", }, { "chlaclehyfiubbdfgmlliqi", "hbhmmqisjhiijticrhhcv", }, },
},
            new StringMArrayD2E1M
{
    Id = 143,
    Value = 
new System.String[,] { { "titupbgrkvcwtwoycqouep", "aylenkwcqy", }, { "fpimbyuwqogsgsfbxytxwyvl", "fccqatmubhrvbsrxjhgb", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.String[,] { { "uevdddlx", "m", }, { "nfytbdx", "ecirmhetbckpextlcrelp", }, },
    NullableValue = 
new System.String[,] { { "phipkymjcxssgdclvjonllbujusl", "", }, { "khssnnndlepddjgvyxmo", "qyffwg", }, },
},
    NullableValue = 
new System.String[,] { { "sitpsonbsmduatipgfvoghipaepuh", "blsuudloqtfp", }, { "vndgiafucwdhg", "ysfxsysxkvhrlnio", }, },
},
            new StringMArrayD2E1M
{
    Id = 151,
    Value = 
new System.String[,] { { "ier", "ewjggwfnyde", }, { "bxknepinldshckmpsqn", "fsaiyhbssihgqxomwbvk", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.String[,] { { "agpunabwugqcauccspuvmko", "ui", }, { "ftodgpjkguaiokcyqdnoqhwoagac", "lcojvxxfyiqofumpcxe", }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 153,
    Value = 
new System.String[,] { { "mwdopvm", "rhwomltajqxds", }, { "yuywqjbnkwra", "u", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.String[,] { { "kdyxtwecrhbnapxgtxiacpsmrvd", "ibffigfklbp", }, { "qrwwxyba", "ygrltqefttyqapnuupsp", }, },
    NullableValue = 
new System.String[,] { { "jpagneddaynvrygovxarmuovypdx", "tnsic", }, { "bpwcgsavvlelgahsmvjed", "meqxoyveucadkvdlhl", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 158,
    Value = 
new System.String[,] { { "ksvgoqprnlpfkenjoupghnmvrnv", "xtnnuvnpxvmddvjitgyrxyrtomp", }, { "hbgdygdgrjjvfgqouwb", "meyrmydhcexnaurusfth", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.String[,] { { "hqgxngr", "xmpkpbraefgwvdsgq", }, { "qfkjfclwqptjvle", "exgaueyycjcynppswxcolrhiwf", }, },
    NullableValue = 
new System.String[,] { { "ddytabpagbebrpyou", "kmgbtqtbavntiiufpyct", }, { "eobkrpyaymrivfjbun", "eef", }, },
},
    NullableValue = 
new System.String[,] { { "xqhfxywtqe", "ntwdusnwgj", }, { "llcgycjmlktmohie", "bogujktnkixmvyylg", }, },
},
            new StringMArrayD2E1M
{
    Id = 167,
    Value = 
new System.String[,] { { "vkulwdjmqqspuokmxxehanjawmbhm", "oeitadfaeicgthc", }, { "bgrirsnfjsbwqttriulsg", "igoxxswqjga", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 129,
    Value = 
new System.String[,] { { "epq", "hnmrmdvbamhpyqknmalbc", }, { "vy", "gmathjsetrjwvvt", }, },
    NullableValue = 
new System.String[,] { { "dycpsvehiigvpm", "misoxmevnovykiuqcvp", }, { "jnhxf", "jejqftdwcmbpfavoqgotntrd", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 170,
    Value = 
new System.String[,] { { "xbmlxjvvrcfryyaygckign", "qrvivdlpfjqwhkcjxiiujsfaiytoo", }, { "tdhhmwocuuvtevq", "dnsnyuawlbvedcnqe", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.String[,] { { "ndqclttmjycliihbcvfdci", "pceyeraanxnr", }, { "cb", "ayc", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "dfypeigbuw", "jhlftdgrhykwsdmyrkqwyuvrnijno", }, { "sirmxjxomlwrnakcsllrmsl", "ceyeoodriatjrkclgaorek", }, },
},
            new StringMArrayD2E1M
{
    Id = 175,
    Value = 
new System.String[,] { { "uowiqbhuyvkpdhdhuuibnllbqett", "pmwwwjsiajvewxprhfgmhwd", }, { "uvtqwjo", "yjetwadoxepmrsgnexrvmek", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.String[,] { { "ntekxxguahbdmowawdwbsjryxakcv", "enshhnboyacfpeudrvbc", }, { "yxvesymjlbiiomkisfmrsffyk", "btjuhfebbrldxxjytcte", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "kfhkqpsbxdsqaljkysbydng", "hknplkwsvfodaaqqkekbvwyc", }, { "vfbfp", "lgdqbtvgglmj", }, },
},
            new StringMArrayD2E1M
{
    Id = 179,
    Value = 
new System.String[,] { { "cwvfuawnlhewht", "axdjiyepokotbwqjsaewoiljpr", }, { "lvdytysqjpwouvgvnewatn", "mtbbiro", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 145,
    Value = 
new System.String[,] { { "kfbpyouc", "eawejfjrxpupbykxpwnfruh", }, { "irjkuymlwjugtstovasfvghcpeehr", "xgrbnwuebgkstmfsmcfgonurdm", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "ydyrnkkkkmlyv", "yx", }, { "ioyseadesmnkenfspbas", "xswtosssnjxdoijsybdklmsgsvllj", }, },
},
            new StringMArrayD2E1M
{
    Id = 182,
    Value = 
new System.String[,] { { "jwxkejwclpkgnefpgfmblub", "jfj", }, { "ngtlqpopweifpjnlmoir", "xxbpsarytdn", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.String[,] { { "cxkyamdipkpyuxajljemvslvgp", "jehaanhtowqbxvxbxsmbwqn", }, { "bbr", "pepaxipcyjkopyaqixwdtvt", }, },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { { "yqojilgb", "rcgbhjjklcalcvhastkvbk", }, { "gfdgtpiygjr", "xqigvexosk", }, },
},
            new StringMArrayD2E1M
{
    Id = 188,
    Value = 
new System.String[,] { { "vbceqjtpdhtatwlwfqvivmvu", "xpajsqiqcj", }, { "nekjuccji", "pmgojvdiqxvpqillssfuitqd", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.String[,] { { "xj", "aokj", }, { "nc", "e", }, },
    NullableValue = 
new System.String[,] { { "xajmqarpjinrqyle", "muqrbglulmlftxltssmdk", }, { "gfn", "curuiyctrkrn", }, },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 193,
    Value = 
new System.String[,] { { "xyhepevciysgdgbuw", "ueljyuupymkfejqippkxlpl", }, { "mpulntukobejaavli", "ht", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 162,
    Value = 
new System.String[,] { { "okfosrplhbqopggjtsybef", "obatqalfqthqjbdsj", }, { "", "ihswmojollwgaqo", }, },
    NullableValue = 
new System.String[,] { { "qxwrlfojumyvprjvm", "pufmbyktgofg", }, { "oeuvpeyqmdllhegsvjhyc", "mavya", }, },
},
    NullableValue = 
new System.String[,] { { "dgxvtxaojchtvunjfuleynklei", "rvwbpjpbstfqjhajqfmjqavod", }, { "xpvwopnxvxyisswbhqsp", "jiym", }, },
},
            new StringMArrayD2E1M
{
    Id = 199,
    Value = 
new System.String[,] { { "bjjpus", "babxtswelkkatcjvgrgbimrvlsd", }, { "iylbpgoqspqqwaertbseqqhdwa", "lcxpqkrfj", }, },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 163,
    Value = 
new System.String[,] { { "fqflnyhgfdmxynkpphj", "mhnpbfayoqmshquawshhqnuvfy", }, { "vwrmk", "ddxseltgwk", }, },
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

