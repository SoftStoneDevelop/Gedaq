

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IStringListtextArray
    {
    }
    
    internal partial class StringListtextArray : IStringListtextArray
    {


#region TestData

        private readonly StringtextArray2M[] _testData = new StringtextArray2M[]
        {
            new StringtextArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vwoybrwtqqqkdtyahik",

"bxusedf",

"c",

"hpnkpvkotgaeqquvejqlianpcvscr",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jdqbtwblilksdiqqo",

"uynbba",

"lj",

"mkwtpkkkryihljvsrlrn",

},
},
            new StringtextArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"e",

"bkqtfuhyidhcrkiorutfvh",

"djxcnihcakmqnl",

},
    ModelInner = new StringtextArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yhxjjvmknmdiqpsxgqau",

"no",

"bbhhaptnysyjeihn",

"",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"fmowdkgkf",

"cwodv",

"odbqebv",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"pajruep",

"w",

"vidkiyp",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"csj",

"xlfvhymyp",

"gcxfhlnywoahilddlwdqoc",

"yvgvfyv",

},
},
            new StringtextArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"w",

"bcmghfkkabknqyncrmheohax",

"",

},
    ModelInner = new StringtextArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"umsnlkmxg",

"iotiukfts",

"",

"lhbypipdsmqnacsklaxnwqaflmvm",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gfcuajpjd",

"crqhmpvfgkkrgcrryd",

"jrwpnookhhklgjdbkampcpnonwsu",

},
},
            new StringtextArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yelymrytmwnyyrrrkainx",

"fuklcdxgsqhyfbpopnhtah",

"timsmv",

"lcpyyjbmcilulyir",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"cagkuaexyml",

"gm",

"mnvatfpiqjjful",

"fctusiriypjwddutihjkf",

},
},
            new StringtextArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"cxrxfdbpjcqfvyerrtxnwrpdn",

"nrlheunn",

"dufpwofacvqyladlwedlkwngkl",

},
    ModelInner = new StringtextArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"bbdwqystlksipneg",

"jgilympxcdoopfsteynrsriqtqfk",

"dbhrntfwsykdjmhnhrkwsebmwlu",

"ieetantjqscpk",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ibdln",

"cmpoahqkesynkdepwvyxnxciao",

"kkjvpemamhpdjxbe",

"dxhrpsmseo",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"lfuyyhfeeys",

"nafexjbr",

"rxegligtuejrkismwtmvv",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"uajwwjthgtsrpyf",

"ppv",

"gmdivawwaaalgvxplaqgfnxbtl",

},
},
            new StringtextArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"pdlxfovndrehgtv",

"h",

"xylintychn",

"jeyd",

},
    ModelInner = new StringtextArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"odjkacybjqshynqydlmwfag",

"etcrpbvtoehnvmttufoncqjdmexm",

"etwrtaihcwdvgftuaeyllgq",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"hjnrwnrbfdmhtpjdsxcwpcslxh",

"awpqmwvdduw",

"hitelkpxpvbmabpkwngkggtvsj",

},
},
            new StringtextArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vylbddfkwpcxhcnwiutflnxooslf",

"",

"bukthmnasntjivoioileoggx",

"cxqid",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"gxvbuobbh",

"ofpchlqgbgvkuavdmkqjkwqtmuv",

"kqvmtcoj",

"lcxsgqptvhxjvlbfmm",

},
    ModelInner = new StringtextArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"fjtuyyviw",

"ryljdsrqcj",

"uqmaeba",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"hjgj",

"yiwgnbpyqeurv",

"oqqfutlwtqhbhv",

"rkklygdjnfhxcsgfaumaqtpvoj",

},
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"apshvplfwk",

"hugclycxmidpjfamqpvdaxu",

"wcvyhgtdlgisb",

"buepfujkelgo",

},
},
            new StringtextArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"dwxujljhnjykuytchaehmxsxgx",

"xakulierlsajorvinvioqrrm",

"vtowtkghspoinegirvecadn",

"fewxlgovjmcfsx",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"mfuijgwhuhijhxwdwegvvun",

"raecspdeqkvcmxdnpjhuepujh",

"yhutusrbpfxktjrqqxpbbaphmdwun",

"upfwvdr",

},
},
            new StringtextArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"atkrignyegkyyrxyqkvsunvlrlwr",

"whuglnigkg",

"ralgavaaoti",

"lwmbaulpdhkxlburm",

},
    ModelInner = new StringtextArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ekdvfxgujsrnidoaqvaakavkuywh",

"bcetwvaxoxqquwkxkse",

"lfc",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"frbgaktqjypfhmwmuxq",

"hveetc",

},
},
            new StringtextArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"osfk",

"midfvpqnqepemopi",

"jaexydokaopmvapsyrowisluypsxn",

"fukgmow",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"uwbxypesbyhvwrvpf",

"uorst",

"hidvfhq",

},
    ModelInner = new StringtextArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"kowxjhulxyjtwnahxblwibajp",

"apfbkgsbavbltiextttnjhkcgh",

"jiuwlivqohnxuvoynxvwjqxpypy",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"kvmxlyicpfydprnhwpm",

"ersxliseblwld",

"n",

"jbbsjxccsfrdtgddn",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"cxreyeptaya",

"xttnskwnpthlkaskjyclkahqq",

"",

},
    ModelInner = new StringtextArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"dxngwym",

"cgkixtuekjebkwusbjpseu",

"mdinhvjao",

"",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ctdomyyahx",

"dbtafwwmgdgwdpxaxebtwcqqt",

"wp",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"rgkiqeshus",

"n",

"k",

},
},
            new StringtextArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"qlqxmfyewwfbkorfajrvca",

"nmpqaaejxue",

"bueqikgmbpmtntxdtegluyiswmjuf",

"qaieklcwhofntcoiauwpsvl",

},
    ModelInner = new StringtextArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"peydxwbcxmcfsjk",

"ngupsqxpqcr",

"rvonrlgllmdxv",

"qo",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vnvjjkhhuhxwsvypkqkmkyow",

"cmeigivuycvrgrilwlqwnmuhslymm",

"nutcinfqwkuxprysvkxr",

},
},
            new StringtextArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"nhxffoexmmvdhsno",

"lbhixwkaakgamuabcsiqpmhbq",

"ugp",

"dfxxenosvg",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"xmmmktuje",

"",

"kv",

"iuhbybtjblrdxjkikubtc",

},
},
            new StringtextArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"atitmpnltkq",

"gfblgalodu",

"kxjvfoimadvcqmacwmlkteenvgkfc",

"mexndugmgfbxbrhrsvki",

},
    ModelInner = new StringtextArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"tyadpemtcklfopnfymveyosbg",

"otijpcrfimcxergfjyatgttxphgvt",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eiucpiesjqxdlvfpoqypugnuigo",

"jygitkbqyqodynyjtlctqe",

"hbovonjtjrvk",

"fudinchkmrainap",

},
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"udcgmydi",

"ofbji",

"sfgcmlegxwijbqtutsbsif",

},
},
            new StringtextArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"kjdrmyqn",

"eeepppmviteqkiqfimgsqg",

"givrpbhjingukudlsxoq",

"bcryuurigabka",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"opufocafi",

"kvpgmhqljn",

"w",

"pqcxabegrkojsdviumtqusin",

},
},
            new StringtextArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ewjahiidwicvlxtraxybadwianrjf",

"evmcnanrqipcbtns",

"fuefdabcwwvncitemhoacvkca",

},
    ModelInner = new StringtextArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"bxacydceiyiwuwqhagbwin",

"nxur",

"",

"vistxnljbjbmbqljolcvp",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"r",

"uvyslo",

"sawu",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"eaeagttlsgfi",

"bfjuqvonasybqrix",

"ekbks",

},
},
            new StringtextArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"gpxqwlkj",

"maxlsvpjwfjfurtquthbpm",

"idcmvnyqqxhohusuqxfoo",

},
    ModelInner = new StringtextArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"jygmoxitgbjwqidfksu",

"txseywg",

"unottmtbfen",

"oscuoulwadoxqgssospmdpo",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"yshxuddmyq",

"unqvmbcmimjbhktaqnhvkdmvd",

"fwhinviioyihsxoqe",

},
},
            new StringtextArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"knyjjfiqgboknstaagyn",

"yfgjepdxigupdosdxoc",

"kncv",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"kdbbpnnlnljwlirvpfrwtlafhaewg",

"",

"kau",

},
},
            new StringtextArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"nmmvxnknevwlugcqxvmolmfpwfy",

"uqiwcdx",

"sfeopntectayvgvjjxelphsa",

},
    ModelInner = new StringtextArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"wocktkwurvnqlafdpdby",

"ibmtbr",

"cameeqqsihjqalyghxwncpqh",

"osswnejriajxtmflxparx",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"dogl",

"qtsjt",

"fwuenqcuusyaulfrxerhjfew",

"oaitvkqjmtbuirnlsbxl",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ifjndapjglxsmdijngkchn",

"jmu",

"vwuxrndkymptneaekprvlxlstbg",

"uh",

},
},
            new StringtextArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"eddoufupvrxivlktlll",

"fwnjlmkrldxjfijjt",

"mviqscpiwedoniqmbfnyochjntdkk",

},
    ModelInner = new StringtextArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"wiyicghyygjoqbvrjp",

"ttmxfvxyvnlgxriuovegtfqpwj",

"lbkbkihyajirtvjljipmpq",

"tejguelbwihvj",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pawjjmghaakphpbthuwkvuoh",

"nuxrpctnsqanyw",

"swgnrgitdxbqksn",

"vhkmrfieaxteyu",

},
},
            new StringtextArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ubdijqtehalahtjnlfoltuwlxhyv",

"svrnt",

"tbfxcarru",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"kbwvlvrbuievmorcamgcwvsqmrc",

"mrptktomsutbljpguafqdawxm",

"tfs",

"rbwcf",

},
    ModelInner = new StringtextArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"yxtmvxuv",

"pl",

"bcihpriwlokdsewmdxhuekfegir",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jekmaioxfiydsxfjohrgxiyrjvni",

"equih",

"ac",

"kfiorvsbjdpxjaimj",

},
},
            new StringtextArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"enoesekojcxfkafrruqmaqch",

"omcyndjcc",

"jmskjndjgq",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"gbfwelmabw",

"ikrwuuqayb",

"crhsvtkrejireip",

},
},
            new StringtextArray2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"xrdptttaqnowd",

"tvsmunxdtaflejofcmpwbsuf",

"lprclntcmfaskit",

},
    ModelInner = new StringtextArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"oqikfryjelbsxvhgrsdesday",

"bmwubgipssslkvu",

"xladiqqlgivcetsnqsxavgjj",

"swaungtshwrxkxwywmnfrotqkvfkd",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"",

"yehkukwdnbvwbqoisd",

"hmpvfd",

"ovcvblqivnxv",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"fidtmcsyifnhcifjn",

"jmofvwjmv",

"ocnvhpejewgt",

},
},
            new StringtextArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qjwbcfhue",

"ywejnkxwonaycidvbwcwnisxmylro",

"uwhkckkjdlrkenear",

},
    ModelInner = new StringtextArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"jioegaxrypqmgrmjqwadtanyemig",

"uoxbyugwn",

"hjukhk",

"stmyxsryhxdrhnqv",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"jpwvqehiya",

"lvviwhdnmhnqmicbqosxlpdbvjp",

"cfqhtupgebkgtbkw",

"y",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vgil",

"moyvhxonphiijnfdos",

"qcjgivoqapgbobwgf",

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(StringtextArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IStringListtextArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringListtextArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IStringListtextArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringListtextArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IStringListtextArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IStringListtextArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IStringListtextArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2m(
	id,
    value,
    nullablevalue,
    stringtextarray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IStringListtextArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IStringListtextArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IStringListtextArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IStringListtextArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2m(
	id,
    value,
    nullablevalue,
    stringtextarray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    stringtextarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(StringtextArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray2m(
	id,
    value,
    nullablevalue,
    stringtextarray2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    stringtextarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(StringtextArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.String>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextarray2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextArray2M> models = null;

                models =  ((IStringListtextArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IStringListtextArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IStringListtextArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IStringListtextArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextArray2M> models = null;

                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IStringListtextArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray2M), typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                ((IStringListtextArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringListtextArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringListtextArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextarray2m m
LEFT JOIN public.stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringListtextArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringListtextArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray2M), typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                ((IStringListtextArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IStringListtextArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IStringListtextArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextarray2m m
LEFT JOIN public.stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringListtextArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringListtextArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray2M), typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                await((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                 ((IStringListtextArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                 ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringListtextArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[12],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[13],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[14],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[15],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(models[16],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(models[17],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(models[18],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[19],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringListtextArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(models[12],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(models[13],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(models[14],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[15],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[16],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[17],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[18],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[19],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[20],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[21],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[22],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[23],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[24],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(models[25],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(models[26],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(models[27],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[28],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                 ((IStringListtextArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextarray2m m
LEFT JOIN public.stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(StringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringListtextArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        StringtextArray2M.AssertModel(models[0],_testData[2], false);
                        StringtextArray2M.AssertModel(models[1],_testData[3], false);
                        StringtextArray2M.AssertModel(models[2],_testData[4], false);
                        StringtextArray2M.AssertModel(models[3],_testData[5], false);
                        StringtextArray2M.AssertModel(models[4],_testData[6], false);
                        StringtextArray2M.AssertModel(models[5],_testData[7], false);
                        StringtextArray2M.AssertModel(models[6],_testData[8], false);
                        StringtextArray2M.AssertModel(models[7],_testData[9], false);
                        StringtextArray2M.AssertModel(models[8],_testData[10], false);
                        StringtextArray2M.AssertModel(models[9],_testData[11], false);
                        StringtextArray2M.AssertModel(models[10],_testData[12], false);
                        StringtextArray2M.AssertModel(models[11],_testData[13], false);
                        StringtextArray2M.AssertModel(models[12],_testData[14], false);
                        StringtextArray2M.AssertModel(models[13],_testData[15], false);
                        StringtextArray2M.AssertModel(models[14],_testData[16], false);
                        StringtextArray2M.AssertModel(models[15],_testData[17], false);
                        StringtextArray2M.AssertModel(models[16],_testData[18], false);
                        StringtextArray2M.AssertModel(models[17],_testData[19], false);
                        StringtextArray2M.AssertModel(models[18],_testData[20], false);
                        StringtextArray2M.AssertModel(models[19],_testData[21], false);
                        StringtextArray2M.AssertModel(models[20],_testData[22], false);
                        StringtextArray2M.AssertModel(models[21],_testData[23], false);
                        StringtextArray2M.AssertModel(models[22],_testData[24], false);
                        StringtextArray2M.AssertModel(models[23],_testData[25], false);
                        StringtextArray2M.AssertModel(models[24],_testData[26], false);
                        StringtextArray2M.AssertModel(models[25],_testData[27], false);
                        StringtextArray2M.AssertModel(models[26],_testData[28], false);
                        StringtextArray2M.AssertModel(models[27],_testData[29], false);
                        StringtextArray2M.AssertModel(models[28],_testData[30], false);
                        StringtextArray2M.AssertModel(models[29],_testData[31], false);
                        StringtextArray2M.AssertModel(models[30],_testData[32], false);
                        StringtextArray2M.AssertModel(models[31],_testData[33], false);
                        StringtextArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        StringtextArray2M.AssertModel(models[0],_testData[9], false);
                        StringtextArray2M.AssertModel(models[1],_testData[10], false);
                        StringtextArray2M.AssertModel(models[2],_testData[11], false);
                        StringtextArray2M.AssertModel(models[3],_testData[12], false);
                        StringtextArray2M.AssertModel(models[4],_testData[13], false);
                        StringtextArray2M.AssertModel(models[5],_testData[14], false);
                        StringtextArray2M.AssertModel(models[6],_testData[15], false);
                        StringtextArray2M.AssertModel(models[7],_testData[16], false);
                        StringtextArray2M.AssertModel(models[8],_testData[17], false);
                        StringtextArray2M.AssertModel(models[9],_testData[18], false);
                        StringtextArray2M.AssertModel(models[10],_testData[19], false);
                        StringtextArray2M.AssertModel(models[11],_testData[20], false);
                        StringtextArray2M.AssertModel(models[12],_testData[21], false);
                        StringtextArray2M.AssertModel(models[13],_testData[22], false);
                        StringtextArray2M.AssertModel(models[14],_testData[23], false);
                        StringtextArray2M.AssertModel(models[15],_testData[24], false);
                        StringtextArray2M.AssertModel(models[16],_testData[25], false);
                        StringtextArray2M.AssertModel(models[17],_testData[26], false);
                        StringtextArray2M.AssertModel(models[18],_testData[27], false);
                        StringtextArray2M.AssertModel(models[19],_testData[28], false);
                        StringtextArray2M.AssertModel(models[20],_testData[29], false);
                        StringtextArray2M.AssertModel(models[21],_testData[30], false);
                        StringtextArray2M.AssertModel(models[22],_testData[31], false);
                        StringtextArray2M.AssertModel(models[23],_testData[32], false);
                        StringtextArray2M.AssertModel(models[24],_testData[33], false);
                        StringtextArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringListtextArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        StringtextArray2M.AssertModel(models[0],_testData[20], false);
                        StringtextArray2M.AssertModel(models[1],_testData[21], false);
                        StringtextArray2M.AssertModel(models[2],_testData[22], false);
                        StringtextArray2M.AssertModel(models[3],_testData[23], false);
                        StringtextArray2M.AssertModel(models[4],_testData[24], false);
                        StringtextArray2M.AssertModel(models[5],_testData[25], false);
                        StringtextArray2M.AssertModel(models[6],_testData[26], false);
                        StringtextArray2M.AssertModel(models[7],_testData[27], false);
                        StringtextArray2M.AssertModel(models[8],_testData[28], false);
                        StringtextArray2M.AssertModel(models[9],_testData[29], false);
                        StringtextArray2M.AssertModel(models[10],_testData[30], false);
                        StringtextArray2M.AssertModel(models[11],_testData[31], false);
                        StringtextArray2M.AssertModel(models[12],_testData[32], false);
                        StringtextArray2M.AssertModel(models[13],_testData[33], false);
                        StringtextArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        StringtextArray2M.AssertModel(models[0],_testData[32], false);
                        StringtextArray2M.AssertModel(models[1],_testData[33], false);
                        StringtextArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray2M), typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                await((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 130, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray2M>();
                var models2 = new List<FlatStringtextArray2M>();
                ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                 ((IStringListtextArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var firstItems2 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                 ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 159, query1, 142, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringListtextArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 13, query1, 75, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(models[12],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(models[13],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(models[14],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(models[15],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(models[16],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[17],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[18],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[19],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[20],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[21],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[22],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[23],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[24],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[25],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[26],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(models[27],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(models[28],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(models[29],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[30],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[12],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[13],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(models[14],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(models[15],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(models[16],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[17],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                await ((IStringListtextArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 17, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringListtextArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 150, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.stringtextarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray2M>();
                var secondItems1 = new List<FlatStringtextArray2M>();
                var secondItems2 = new List<FlatStringtextArray2M>();
                 ((IStringListtextArray)this).DbConnectionDynQuerySelectModelBatch(connection, 45, query1, 58, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.stringtextarray2m m
LEFT JOIN public.stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(StringtextArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IStringListtextArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextArray)this).DbConnectionSTSelectModelBatchAsync(connection, 17, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        StringtextArray2M.AssertModel(models[0],_testData[4], false);
                        StringtextArray2M.AssertModel(models[1],_testData[5], false);
                        StringtextArray2M.AssertModel(models[2],_testData[6], false);
                        StringtextArray2M.AssertModel(models[3],_testData[7], false);
                        StringtextArray2M.AssertModel(models[4],_testData[8], false);
                        StringtextArray2M.AssertModel(models[5],_testData[9], false);
                        StringtextArray2M.AssertModel(models[6],_testData[10], false);
                        StringtextArray2M.AssertModel(models[7],_testData[11], false);
                        StringtextArray2M.AssertModel(models[8],_testData[12], false);
                        StringtextArray2M.AssertModel(models[9],_testData[13], false);
                        StringtextArray2M.AssertModel(models[10],_testData[14], false);
                        StringtextArray2M.AssertModel(models[11],_testData[15], false);
                        StringtextArray2M.AssertModel(models[12],_testData[16], false);
                        StringtextArray2M.AssertModel(models[13],_testData[17], false);
                        StringtextArray2M.AssertModel(models[14],_testData[18], false);
                        StringtextArray2M.AssertModel(models[15],_testData[19], false);
                        StringtextArray2M.AssertModel(models[16],_testData[20], false);
                        StringtextArray2M.AssertModel(models[17],_testData[21], false);
                        StringtextArray2M.AssertModel(models[18],_testData[22], false);
                        StringtextArray2M.AssertModel(models[19],_testData[23], false);
                        StringtextArray2M.AssertModel(models[20],_testData[24], false);
                        StringtextArray2M.AssertModel(models[21],_testData[25], false);
                        StringtextArray2M.AssertModel(models[22],_testData[26], false);
                        StringtextArray2M.AssertModel(models[23],_testData[27], false);
                        StringtextArray2M.AssertModel(models[24],_testData[28], false);
                        StringtextArray2M.AssertModel(models[25],_testData[29], false);
                        StringtextArray2M.AssertModel(models[26],_testData[30], false);
                        StringtextArray2M.AssertModel(models[27],_testData[31], false);
                        StringtextArray2M.AssertModel(models[28],_testData[32], false);
                        StringtextArray2M.AssertModel(models[29],_testData[33], false);
                        StringtextArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        StringtextArray2M.AssertModel(models[0],_testData[30], false);
                        StringtextArray2M.AssertModel(models[1],_testData[31], false);
                        StringtextArray2M.AssertModel(models[2],_testData[32], false);
                        StringtextArray2M.AssertModel(models[3],_testData[33], false);
                        StringtextArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringListtextArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextArray)this).DbConnectionSTSelectModelBatch(connection, 49, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        StringtextArray2M.AssertModel(models[0],_testData[11], false);
                        StringtextArray2M.AssertModel(models[1],_testData[12], false);
                        StringtextArray2M.AssertModel(models[2],_testData[13], false);
                        StringtextArray2M.AssertModel(models[3],_testData[14], false);
                        StringtextArray2M.AssertModel(models[4],_testData[15], false);
                        StringtextArray2M.AssertModel(models[5],_testData[16], false);
                        StringtextArray2M.AssertModel(models[6],_testData[17], false);
                        StringtextArray2M.AssertModel(models[7],_testData[18], false);
                        StringtextArray2M.AssertModel(models[8],_testData[19], false);
                        StringtextArray2M.AssertModel(models[9],_testData[20], false);
                        StringtextArray2M.AssertModel(models[10],_testData[21], false);
                        StringtextArray2M.AssertModel(models[11],_testData[22], false);
                        StringtextArray2M.AssertModel(models[12],_testData[23], false);
                        StringtextArray2M.AssertModel(models[13],_testData[24], false);
                        StringtextArray2M.AssertModel(models[14],_testData[25], false);
                        StringtextArray2M.AssertModel(models[15],_testData[26], false);
                        StringtextArray2M.AssertModel(models[16],_testData[27], false);
                        StringtextArray2M.AssertModel(models[17],_testData[28], false);
                        StringtextArray2M.AssertModel(models[18],_testData[29], false);
                        StringtextArray2M.AssertModel(models[19],_testData[30], false);
                        StringtextArray2M.AssertModel(models[20],_testData[31], false);
                        StringtextArray2M.AssertModel(models[21],_testData[32], false);
                        StringtextArray2M.AssertModel(models[22],_testData[33], false);
                        StringtextArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        StringtextArray2M.AssertModel(models[0],_testData[23], false);
                        StringtextArray2M.AssertModel(models[1],_testData[24], false);
                        StringtextArray2M.AssertModel(models[2],_testData[25], false);
                        StringtextArray2M.AssertModel(models[3],_testData[26], false);
                        StringtextArray2M.AssertModel(models[4],_testData[27], false);
                        StringtextArray2M.AssertModel(models[5],_testData[28], false);
                        StringtextArray2M.AssertModel(models[6],_testData[29], false);
                        StringtextArray2M.AssertModel(models[7],_testData[30], false);
                        StringtextArray2M.AssertModel(models[8],_testData[31], false);
                        StringtextArray2M.AssertModel(models[9],_testData[32], false);
                        StringtextArray2M.AssertModel(models[10],_testData[33], false);
                        StringtextArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IStringListtextArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringListtextArray)this).SetDbConnectionSelectModelParametrs(cmd, 161);
                var models = await ((IStringListtextArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                StringtextArray2M.AssertModel(models[0],_testData[31], false);
                StringtextArray2M.AssertModel(models[1],_testData[32], false);
                StringtextArray2M.AssertModel(models[2],_testData[33], false);
                StringtextArray2M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringListtextArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringListtextArray)this).SetDbConnectionSelectModelParametrs(cmd, 36);
                var models =  ((IStringListtextArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                StringtextArray2M.AssertModel(models[0],_testData[8], false);
                StringtextArray2M.AssertModel(models[1],_testData[9], false);
                StringtextArray2M.AssertModel(models[2],_testData[10], false);
                StringtextArray2M.AssertModel(models[3],_testData[11], false);
                StringtextArray2M.AssertModel(models[4],_testData[12], false);
                StringtextArray2M.AssertModel(models[5],_testData[13], false);
                StringtextArray2M.AssertModel(models[6],_testData[14], false);
                StringtextArray2M.AssertModel(models[7],_testData[15], false);
                StringtextArray2M.AssertModel(models[8],_testData[16], false);
                StringtextArray2M.AssertModel(models[9],_testData[17], false);
                StringtextArray2M.AssertModel(models[10],_testData[18], false);
                StringtextArray2M.AssertModel(models[11],_testData[19], false);
                StringtextArray2M.AssertModel(models[12],_testData[20], false);
                StringtextArray2M.AssertModel(models[13],_testData[21], false);
                StringtextArray2M.AssertModel(models[14],_testData[22], false);
                StringtextArray2M.AssertModel(models[15],_testData[23], false);
                StringtextArray2M.AssertModel(models[16],_testData[24], false);
                StringtextArray2M.AssertModel(models[17],_testData[25], false);
                StringtextArray2M.AssertModel(models[18],_testData[26], false);
                StringtextArray2M.AssertModel(models[19],_testData[27], false);
                StringtextArray2M.AssertModel(models[20],_testData[28], false);
                StringtextArray2M.AssertModel(models[21],_testData[29], false);
                StringtextArray2M.AssertModel(models[22],_testData[30], false);
                StringtextArray2M.AssertModel(models[23],_testData[31], false);
                StringtextArray2M.AssertModel(models[24],_testData[32], false);
                StringtextArray2M.AssertModel(models[25],_testData[33], false);
                StringtextArray2M.AssertModel(models[26],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(StringtextArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringListtextArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringListtextArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringListtextArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringListtextArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(StringtextArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringListtextArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringListtextArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringListtextArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringListtextArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(StringtextArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(StringtextArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IStringListtextArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringListtextArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IStringListtextArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IStringListtextArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(StringtextArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringListtextArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringListtextArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringListtextArray)this).ImportModelInner(connection, importCollection);
                var models = ((IStringListtextArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtextarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(StringtextArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_stringtextarray2m m
LEFT JOIN public.binary_stringtextarray2mi mi ON mi.id = m.stringtextarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(StringtextArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IStringListtextArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IStringListtextArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IStringListtextArray)this).ImportModel(connection, importCollection);
                var models = ((IStringListtextArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtextarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(StringtextArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringListtextArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringListtextArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA), typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MIWA>();
                var models2 = new List<StringtextArray2MIWA>();
                await ((IStringListtextArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MIWA>();
                var models2 = new List<StringtextArray2MIWA>();
                ((IStringListtextArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringListtextArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_stringtextarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringListtextArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_stringtextarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA), typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MIWA>();
                var models2 = new List<StringtextArray2MIWA>();
                await ((IStringListtextArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MIWA>();
                var models2 = new List<StringtextArray2MIWA>();
                ((IStringListtextArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringListtextArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_stringtextarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringListtextArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_stringtextarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MI), typeof(StringtextArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MI>();
                var models2 = new List<StringtextArray2MI>();
                await ((IStringListtextArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MI>();
                var models2 = new List<StringtextArray2MI>();
                ((IStringListtextArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629),
                (NpgsqlTypes.NpgsqlDbType)(-2147483629)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringListtextArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringListtextArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA), typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MIWA>();
                var models2 = new List<StringtextArray2MIWA>();
                await ((IStringListtextArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<StringtextArray2MIWA>();
                var models2 = new List<StringtextArray2MIWA>();
                ((IStringListtextArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IStringListtextArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IStringListtextArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

