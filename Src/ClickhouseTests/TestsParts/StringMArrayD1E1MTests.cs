

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
    Id = 6,
    Value = 
new System.String[4]
{
"unkniec",
"dcvowwqvte",
"yqrjjbpfljjseymlhbrkojuexjvr",
"xa",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 1,
    Value = 
new System.String[3]
{
"r",
"xqdt",
"atarrbcatqkjdiobh",
},
    NullableValue = 
new System.String[3]
{
"qnsj",
"myonduayubegy",
"tmmnjgbxbocyoduhnfjcf",
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
"qslwpjnpdcphhmhonhdn",
"qtleulnn",
"peppiottvvxhjn",
"snfygupfwknaoceaqocrvqiw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.String[4]
{
"daoal",
"ewdnbn",
"",
"infuehkmnb",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"dlowstahhorr",
"lowinbuwnb",
"qn",
},
},
            new StringMArrayD1E1M
{
    Id = 18,
    Value = 
new System.String[3]
{
"dkqdb",
"dlfveekhnei",
"giaovtoffkpnfy",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.String[3]
{
"uwygjmctekkbbvapcewdddwovljk",
"uopyhvpveigue",
"euyhkullipoywlyx",
},
    NullableValue = 
new System.String[4]
{
"otlhkfnuticmuvxsixa",
"ttkexnmnm",
"jemgxaphbjnoitjcfjueosqvoxnnt",
"wvirqfeykgysi",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 23,
    Value = 
new System.String[4]
{
"kclopdkvcwphgcvknsajhvm",
"gh",
"vrh",
"rvsdlgeaxojbndbudi",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.String[3]
{
"vt",
"sk",
"ktvtqdvjyvnkvjrehvpskojqshnhg",
},
    NullableValue = 
new System.String[3]
{
"rbqeyvawbxmgjkqxxveneigryjs",
"lwesaxlrabhtrfpyuvojsi",
"amvrruyh",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 25,
    Value = 
new System.String[4]
{
"qgwmuyelxxdqixrkhkyxcjqgs",
"gxfcvdgiyliitofpkdejdqlkih",
"ataebpbwbtflhjks",
"uvuxlno",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 20,
    Value = 
new System.String[4]
{
"aaofpshanqiaf",
"bdvtnayqfqegpnnegncjdneea",
"dimw",
"dunsmthayggsxomvgaivkhtdgtyo",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 31,
    Value = 
new System.String[3]
{
"yfrofdgigvxvr",
"qgfemonnxhgsraaayxwpblnv",
"lvtyeycatgfgsrxa",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.String[3]
{
"lwfbusuwnbaae",
"rnoxvjjf",
"nbbuaweghdtdgsyvjvjilwfc",
},
    NullableValue = 
new System.String[4]
{
"pvncqguruewbgkfsocj",
"ovtbf",
"",
"hwnwenrrnno",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 36,
    Value = 
new System.String[3]
{
"kgxxqwoeijwsfdql",
"tgtachnrvccnbrvograa",
"",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.String[4]
{
"wlphssabvupcbrtpeweovlhlgxqit",
"ehdutlosuxocqasdibiygvnxenrt",
"fsolomrnwodkyw",
"ghjdea",
},
    NullableValue = 
new System.String[3]
{
"cqxbgrmbiddmdbyddqefptfas",
"bihxqfvvga",
"jfhwhfcmrbnfmogyvvdlfbbvfmxt",
},
},
    NullableValue = 
new System.String[4]
{
"mcbevitejyvs",
"wfpkvfumquimsah",
"bsumujpfcjbiws",
"bexmesra",
},
},
            new StringMArrayD1E1M
{
    Id = 41,
    Value = 
new System.String[4]
{
"rypvwyx",
"rmsghaaq",
"yrvmjuqaskgeshmnjl",
"",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.String[4]
{
"etnfo",
"yjqhqfcjhrwlchs",
"ptwnhrfxjaecpyuwhcsquu",
"xvsghlbemqor",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 47,
    Value = 
new System.String[3]
{
"rpjgewvh",
"ktjfojkdkygx",
"cnfvkedjtdan",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.String[4]
{
"oicpjsrkxxwi",
"tgxylplftndwwbrhpmmjglwfa",
"yndppulcbnhubgv",
"hgxuvqe",
},
    NullableValue = 
new System.String[4]
{
"kincoeinqjgwjeagwprnxvojht",
"ygbpcahk",
"fgvhlh",
"uepkvbtncok",
},
},
    NullableValue = 
new System.String[4]
{
"rsohlj",
"lxutqulfs",
"tmkvvqfxovwwlsnhyqtxnffu",
"jjfarckuwtdoayirc",
},
},
            new StringMArrayD1E1M
{
    Id = 51,
    Value = 
new System.String[3]
{
"we",
"gulnqmmlkfd",
"wwr",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.String[4]
{
"flyiepd",
"lchrqxtifpvdbtxekxxeh",
"ysstihsr",
"ipjcdplqoqlam",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"k",
"lfcos",
"jvwanthtvxmpgtatcviqt",
},
},
            new StringMArrayD1E1M
{
    Id = 52,
    Value = 
new System.String[3]
{
"kbdbbsc",
"qdmibydhhgtenaeubrhlgkkdsq",
"wrx",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.String[3]
{
"lhysmpjjx",
"yanvmmcvnisyltdrjdtegdd",
"yscmdkxkcmgce",
},
    NullableValue = 
new System.String[4]
{
"ph",
"kdlreghsrbbpqwtqkyxb",
"ysyuhnrhhocqvucrwji",
"",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 55,
    Value = 
new System.String[4]
{
"efphgtxtbjxebyindawssxcbho",
"fwllowwdewvbpaqkk",
"tnorxbqqeicpfnrbuhmjrcooewaj",
"utwuujw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.String[4]
{
"njoxrgt",
"vsfywisustfwshgppccmadkycksu",
"bsdruuwjjbfdmp",
"vnx",
},
    NullableValue = 
new System.String[4]
{
"msxxgbjasydswqyrgwffcqkso",
"snceqwkbeuruhtuvlncmrxekqf",
"dsw",
"elgvnaqtwspiqmhpxhvplllhe",
},
},
    NullableValue = 
new System.String[4]
{
"ftajnpjegudoytjorusteysnbv",
"nfvtxqvbkemf",
"ofwqjeaopjgtrbsy",
"mewqkewvilmojyajrnnyjefpyuoup",
},
},
            new StringMArrayD1E1M
{
    Id = 62,
    Value = 
new System.String[4]
{
"ix",
"ytrcwktqajaiunrxdtpex",
"twbdgjhur",
"o",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.String[3]
{
"trqeiabovuafrlhfn",
"almii",
"fkh",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"xlnjoiscjpvypbuorh",
"aphjkpdbvmrirulcuatjncmihk",
"osqkyglrk",
"yhxkpsgormopnvfrx",
},
},
            new StringMArrayD1E1M
{
    Id = 71,
    Value = 
new System.String[4]
{
"inxbwhbpfamxbugmwxwyxmdp",
"ydlqkphydqvqflcdqvkcvegwygyg",
"wjvaqpvkgdfjbifpbnwt",
"gbdfajafbogf",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.String[3]
{
"kven",
"wse",
"kahbbpgnjygcifnivjsgvfgwh",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 78,
    Value = 
new System.String[4]
{
"jkwkbfbaeyqjoggtfyhpbe",
"plbqw",
"aifvwrftrfyfcqydim",
"snyfsmhyqcqt",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.String[3]
{
"diraliiqqgohubfwfyni",
"fyldkbpirsmiukwtd",
"mbhexxuqnygxoytmnloxqhjhassfj",
},
    NullableValue = 
new System.String[3]
{
"jkpxnuhevwpabbr",
"ydpmiopajiwcwxxpaxqdqdco",
"uiacrwulbudkvjcbhjtj",
},
},
    NullableValue = 
new System.String[4]
{
"qcymwdwuvnjeeh",
"jeb",
"sebetybu",
"ururkqepenqkpijehighimjyttb",
},
},
            new StringMArrayD1E1M
{
    Id = 85,
    Value = 
new System.String[4]
{
"ainfxucyilpijrf",
"djpoighlc",
"lfr",
"tkuaitnadapwptrjotmhgndhjai",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.String[3]
{
"hfkkrwfdhggbspchkcjxdkrmuwtkq",
"qnlihqyxiheeg",
"parbtgkhsgvoucytghgeggbsfnn",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 87,
    Value = 
new System.String[3]
{
"h",
"ioiokeynqbnsvhmehjtxwyle",
"jixjmabkp",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.String[4]
{
"rvhipmwf",
"pwiyidcpafsmo",
"mox",
"jwm",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 92,
    Value = 
new System.String[3]
{
"lnnrmlvvgjafuqslwrmvas",
"dctshkpyoalqwruclhqlqr",
"xutpjnoohbfeaumwbmuesl",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 85,
    Value = 
new System.String[3]
{
"q",
"xhwffsiguwisojddofaaywofviilm",
"g",
},
    NullableValue = 
new System.String[3]
{
"uhrnpguwborwkwmrvy",
"lglxdxhinnkrmbvepyrluqky",
"hjufhbfmhafwmk",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 93,
    Value = 
new System.String[4]
{
"wpgnpgantrghthjqldomlxawpyp",
"byvyfslkuapsuhlyhsgrsaog",
"hk",
"g",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.String[4]
{
"bfxpuxwwcdqfon",
"lifeayafo",
"pwbrkxpmkxxidltgddgeqnsirtf",
"clmftmwqxwjdwtmnjwo",
},
    NullableValue = 
new System.String[4]
{
"luuprr",
"salttxgm",
"evgr",
"vtyamqrlbxouy",
},
},
    NullableValue = 
new System.String[3]
{
"raohf",
"lyrsanneiwxfdqfwxcxegc",
"bdovfnpdgv",
},
},
            new StringMArrayD1E1M
{
    Id = 98,
    Value = 
new System.String[4]
{
"fypkg",
"kuxydgmgpinweijwwdy",
"iaveikutyhxy",
"oiaovcmtqvcpkjapgefxdfmwg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 96,
    Value = 
new System.String[4]
{
"ukfpfqtagltvgvhvmlyqkfth",
"ythxvqbsumhmacb",
"oryr",
"gyxmakbgl",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 107,
    Value = 
new System.String[3]
{
"kdnwsrqktqotkbgwtue",
"rprix",
"qfhqenaceydvclc",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 99,
    Value = 
new System.String[4]
{
"fbsefqdjpylia",
"",
"lebwievtpdrqwoqvvkgpkqrarde",
"yrntrpjhbilqcynevyectemppro",
},
    NullableValue = 
new System.String[3]
{
"gdicxnksupdmosixctccknrs",
"nvetfbrebgldu",
"nuxeekhxhsgcanhrkfqvqulolt",
},
},
    NullableValue = 
new System.String[3]
{
"",
"xyvkeijtwakrxgbb",
"rgttlw",
},
},
            new StringMArrayD1E1M
{
    Id = 110,
    Value = 
new System.String[3]
{
"nltdbcdsjnruulxdkwqewetgb",
"aktptqouehqymj",
"yxjnrxncgxavlxgwolakmvsubptfw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 100,
    Value = 
new System.String[3]
{
"btjquuwgcmcjcntnbywxifo",
"uuyvevkksixftgfphdtbvqp",
"qewcgjqttogqxpbpd",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 111,
    Value = 
new System.String[3]
{
"rgedgdqpmbwcjofaeqnlflq",
"sbsiwkjyngktrfemwttq",
"habg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.String[3]
{
"qvxlqjagtwstdmeuran",
"usumf",
"wcsxcwprrbgoyjywale",
},
    NullableValue = 
new System.String[4]
{
"pstuardwthjdfhax",
"ayuwwdlbffcnogwffbdl",
"pt",
"jfvdbjxiemfehlsircvdgxp",
},
},
    NullableValue = 
new System.String[4]
{
"ipigsmhwgwsfohnytij",
"obdshlernrsyykjyixna",
"geivdxtbuqrevxyctcm",
"nohbwrcrgvctltqhwhghkhdg",
},
},
            new StringMArrayD1E1M
{
    Id = 117,
    Value = 
new System.String[4]
{
"lipwrlu",
"etdfwymb",
"ocnvatchn",
"tlnxedw",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 115,
    Value = 
new System.String[3]
{
"qyidns",
"cbwppsnfixaqwgcwfglhmsow",
"wgejbtheny",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"qjysvltuowvwklnqvbo",
"frvtqvn",
"pmfunvthfdih",
"xhgceyxlwwdsweacfjckgjiimt",
},
},
            new StringMArrayD1E1M
{
    Id = 123,
    Value = 
new System.String[4]
{
"fudbkvxrogiklbthgydsbvyns",
"tiny",
"hualcbnc",
"ou",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.String[4]
{
"ukqbrdaafqlcujfuqvqvbuqk",
"kvuupv",
"uctxxwaoukmxylrw",
"gkrcrvsnlcfuvruiv",
},
    NullableValue = 
new System.String[4]
{
"jlwbkfqemgfhanwlondogmh",
"fqksmln",
"txvvey",
"brhqkctghqthjuxaswsvoepvqyo",
},
},
    NullableValue = 
new System.String[3]
{
"",
"xipx",
"hmfoypifkhylqccis",
},
},
            new StringMArrayD1E1M
{
    Id = 124,
    Value = 
new System.String[3]
{
"gkxxioocqna",
"tshqpuvx",
"wldgdwfbogyusmkpcay",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.String[4]
{
"lehwqqeyejqrivptvfjy",
"tojsrpvovlf",
"ifwderihfkklcxkhei",
"b",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"heonvsgipfyoysd",
"ljumcxnrthpwymfvfotiejkoxaw",
"fdvckuxtpllylw",
"wfhtbem",
},
},
            new StringMArrayD1E1M
{
    Id = 131,
    Value = 
new System.String[3]
{
"qlhviu",
"",
"jytxofprpugoa",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 126,
    Value = 
new System.String[4]
{
"kiwftjiulilsgyvbncgayvi",
"rx",
"gxvyhscbflocswsoguuqc",
"qjpcxiyrvmnae",
},
    NullableValue = 
new System.String[4]
{
"iyplsa",
"poeaeychsurxhioedcnqcfxq",
"wrjolhgqgssfrsostrnvv",
"hnifolrwlilqckexvdudliat",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 139,
    Value = 
new System.String[3]
{
"raulcuhdpqrawed",
"mrhavvlfwtiakjdqtcapdjvev",
"mewdjrjgxcakbtimixwnbvq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.String[3]
{
"jcuxcqriasewhw",
"tbulrgh",
"wkmthujss",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 142,
    Value = 
new System.String[3]
{
"kdolyykceeashc",
"jsiinqn",
"tvkg",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 130,
    Value = 
new System.String[4]
{
"q",
"myr",
"ycaeigxipyxyrsagpaffuhs",
"hrvnfjtt",
},
    NullableValue = 
new System.String[3]
{
"",
"wcwrfmsscarbdvqft",
"ukjeldniqkaonltaqtdpvecbali",
},
},
    NullableValue = 
new System.String[3]
{
"xs",
"omvuons",
"invfkhlltrighrtqlqevdbj",
},
},
            new StringMArrayD1E1M
{
    Id = 146,
    Value = 
new System.String[4]
{
"hdxrdusxokemugg",
"vpd",
"jmxnojltvhuqagoado",
"",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 131,
    Value = 
new System.String[4]
{
"jgtpddnrmrpmtnglnaryjrvmytsk",
"gwiuweskjtomccvatccgbg",
"gcpaymoulfpckxijaqrbxlkstxk",
"eriqtu",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 152,
    Value = 
new System.String[3]
{
"tpxeymgwejpsvvhmuy",
"bjevapfybnlpyrhlrekkgyw",
"aiokcwq",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 139,
    Value = 
new System.String[4]
{
"kdgddjvsvd",
"",
"kjhagck",
"ocvtqo",
},
    NullableValue = 
new System.String[4]
{
"eieqowarojdredmjncwtjknqb",
"vhhipiqnyabndrifijnra",
"anflkatsarahmbwpxlkqx",
"tmgrgyvdyiugwcpfyprcl",
},
},
    NullableValue = 
new System.String[4]
{
"xmlaybk",
"hhnwya",
"boks",
"jwdncoerxbiwyu",
},
},
            new StringMArrayD1E1M
{
    Id = 156,
    Value = 
new System.String[3]
{
"mkqjd",
"tkfqaq",
"kabakptdrppkcfrmnrabb",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 147,
    Value = 
new System.String[3]
{
"jysydtj",
"vojbvnaj",
"jwtvgtxsfjruscnwnlbrn",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 165,
    Value = 
new System.String[4]
{
"lhve",
"fjkkikxiwykfpbbdas",
"yjfwusss",
"qhejbpxreunfyk",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.String[4]
{
"iaxpklmympfjbyivgekva",
"lckovslmoi",
"rcya",
"pjqktppdmmkdur",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 167,
    Value = 
new System.String[3]
{
"stlvbjsfpxxyfmkn",
"mwqgn",
"akbtkwsksdtxsbsgdwoqjvjkaokah",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 159,
    Value = 
new System.String[4]
{
"nualgbweswqfqebssbvef",
"dyuqykpykjvdlaovrbyjogucusau",
"kpcsv",
"bsipfnhw",
},
    NullableValue = 
new System.String[3]
{
"ckqxjngaytydtsd",
"syqoy",
"rarbprufdjdrblyqlxeibprvdh",
},
},
    NullableValue = null,
},
            new StringMArrayD1E1M
{
    Id = 171,
    Value = 
new System.String[3]
{
"ljyrmkomejewyvuyc",
"nkgtolfnlriqyci",
"xpqgyksiwdycqsxftxufho",
},
    ModelInner = new StringMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.String[4]
{
"ufaxjhyiolwktwmiuocsqmjl",
"sy",
"fs",
"kpmxjgusci",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"afsek",
"hrrok",
"spyuxyhplsq",
"dlaotgcnmhxnghv",
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

