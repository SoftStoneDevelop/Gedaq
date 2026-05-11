

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
    internal partial interface IStringMArraytextMMArrayD1
    {
    }
    
    internal partial class StringMArraytextMMArrayD1 : IStringMArraytextMMArrayD1
    {


#region TestData

        private readonly StringtextMMArrayD1E1M[] _testData = new StringtextMMArrayD1E1M[]
        {
            new StringtextMMArrayD1E1M
{
    Id = 8,
    Value = 
new System.String[3]
{
"o",
"vqqlomywbg",
"thpyrfoptoxgyixljbetxw",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 16,
    Value = 
new System.String[4]
{
"bwfqmvepcc",
"fvbcljxhsciugifnufcxwukfqjcvi",
"whrcebguvqcdtslsjaqbd",
"nspxddgssiqdcpdhhqp",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.String[4]
{
"jaaayafubgmhstdhgalhfnish",
"fjceoyxoiiebsxgfrevpw",
"rsoggustmfic",
"tkyqebbdtlpamlhfsushkckhaxkq",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"m",
"x",
"gasqpvtpdothkkmdevyxf",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.String[4]
{
"cowxtgjstowmqgono",
"gmytqkdqgddrqjuhrrprdoujio",
"rbyhhfysopxvgnkjgxuuiroiaa",
"cbpqcvwgty",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"celcopnuhtnmndkohpujbsqaenb",
"ckaclfrtv",
"tyoujxdkcakoxqrubmwjgbx",
"naxtytyljfb",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 34,
    Value = 
new System.String[3]
{
"tksyjfvgihwnemrqdqm",
"uwrgnscofhywlfx",
"pxjetkbytmjaibjbaamlnqw",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.String[4]
{
"h",
"caulhdpuapsjwykmwgsgqcx",
"sfqgatlaggvemrsk",
"b",
},
    NullableValue = 
new System.String[4]
{
"bxxfchwpbynqkhqolxnaen",
"ea",
"dfs",
"lbggselh",
},
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 35,
    Value = 
new System.String[3]
{
"thwmxmsmetekow",
"djwowdcpfxavbowtme",
"hqorydn",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 37,
    Value = 
new System.String[3]
{
"rmxmvbjkdbrbmycbbcqvroij",
"njalpdcwcngyaovsxsficgkb",
"e",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.String[4]
{
"",
"cdlrilelbbyptngjhd",
"jvrswuulyetjbxvaqalvgoptvyaxq",
"tkvokkblbxfxgcu",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 38,
    Value = 
new System.String[3]
{
"dfuvad",
"",
"iilsovcoeaccqttuec",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"mnxxtbjnpvieu",
"avwrxclehmuhglvyt",
"mewpjvnklftayugmfgvbufej",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.String[4]
{
"dtxsxkbpwqcm",
"adyngracxbltmyqbnvoastqq",
"fywpfhctrepjidhxsmoe",
"ai",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.String[4]
{
"sjpl",
"pylqqdelv",
"lyvpwmfcyoafg",
"uwhuxufdcsyklnuelubxxnrlw",
},
    NullableValue = 
new System.String[4]
{
"jkjjpjeaqx",
"dausfypyjonanvadvan",
"blykskbhldtthbrathtjgetf",
"xrreixhewxp",
},
},
    NullableValue = 
new System.String[4]
{
"mtxvdlkiafcxvcxckl",
"hqjjaobpmdwhyhtineppype",
"chfgwgqhuiowpngbj",
"tppnvnyg",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.String[4]
{
"pcmrjpqvwufugbjqqp",
"fatcyyoublvhmwsujixo",
"hvlnyuxphmpity",
"naddodcug",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 51,
    Value = 
new System.String[3]
{
"cjvyycynh",
"brnuaktghrtfalk",
"cxdnqgoumoflgwcrjxpian",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.String[4]
{
"fsycwpdokc",
"pikldflsicqreeglladn",
"xefnwesmegfvmcryacqumay",
"fmohthrfgfptxlgbrhyfp",
},
    NullableValue = 
new System.String[3]
{
"xavjetdwpbdyegwfnegydsjxgsqm",
"btakshwduyabjstiki",
"fjifxuytqteudq",
},
},
    NullableValue = 
new System.String[4]
{
"flyucbdhwxjttyaaxxbcvsfplmm",
"nlpiwkjanbqafraptqlk",
"bsumifwdgqcaxnqo",
"pksltnxcttnfeaxheklob",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.String[3]
{
"llkfeorl",
"fomqjtmvgqhqgb",
"ojfglsrnklvjnkwuyqkllew",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.String[4]
{
"rwikjabcajumoiuykulksqrcg",
"ofdrnkvqbidehoxctrj",
"",
"tocya",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 31,
    Value = 
new System.String[3]
{
"bgvoi",
"frxmvjqaoqx",
"bxcwhergmovivyyfarywncfjjd",
},
    NullableValue = 
new System.String[4]
{
"honxkixmsoppjkqktcljityfpp",
"jhottejghxjpijkvleylbblg",
"obptwkdcbqgi",
"xf",
},
},
    NullableValue = 
new System.String[4]
{
"hrmklqoyqygtgmmgahrnw",
"d",
"",
"vxta",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 62,
    Value = 
new System.String[3]
{
"wcffvrywekpqrqnkyg",
"qursuivibcphgxsbo",
"",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"",
"uf",
"wcgocjnwylqnat",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 67,
    Value = 
new System.String[3]
{
"nbrpuqip",
"csryuvdhtvnmtfllt",
"m",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.String[4]
{
"rbx",
"dktfouplaip",
"mcmcrpkrbdqarrxtolflrq",
"uk",
},
    NullableValue = 
new System.String[4]
{
"ddgktllppwthdiu",
"kkmme",
"upbknofgnwifteycswttee",
"rbfhmrjuvayevsecursfgdjoqe",
},
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.String[3]
{
"biqprclytr",
"okymldxchckchmjcw",
"g",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 83,
    Value = 
new System.String[4]
{
"gmapxxnpqnimtnxvikltrkaqpdfed",
"nwdiduogdnwpwdcuusdadn",
"lqhhoocnwceqbkp",
"dhdbrrvcweqvnunlnljj",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 38,
    Value = 
new System.String[3]
{
"syvkffpw",
"ys",
"ncsehcfakugeurrdcjc",
},
    NullableValue = 
new System.String[3]
{
"f",
"cnrdivdi",
"gmrpteexs",
},
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.String[3]
{
"tdxkwrgqy",
"coyylbuodjokewwgcjtpoouhnd",
"bxsunvfeqbgfnexrelqe",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"fjqc",
"ionbcxuvbvcxq",
"fmqdxai",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.String[4]
{
"foomhnrhakkgbethghpiwodoy",
"jthrbeo",
"hmuocjsd",
"jdoqgumfgqapgbeivjgujpnfq",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.String[3]
{
"yhtsseelpfffimqvpfyohpvl",
"ouepajbwyyb",
"nait",
},
    NullableValue = 
new System.String[4]
{
"whokqcppbma",
"lj",
"ugwnigxtetaiutc",
"wqstxyowjllmstlygtwy",
},
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 102,
    Value = 
new System.String[4]
{
"vmhsbfdjgyvojgtjkfhlpy",
"hhngwtshk",
"txbtjbtadiuujxodmbikvjjdrpvm",
"pusowswgrkjshqhdirsuevlbrfd",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"aual",
"qyfgxvuelvvl",
"bnbdauvw",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.String[3]
{
"goj",
"ygwgtttjwagrvcifqs",
"pcsygtouwrgganfkxnhggkdsjl",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.String[4]
{
"ldbuuaitldubqkuywtvapwyres",
"mmnqjrslfbxgvlucsjrgevrb",
"gqomacbdavqikcaaky",
"fivhjcayg",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 108,
    Value = 
new System.String[3]
{
"meyrcftjtxqsvbjbcdb",
"ubainuqlmemtaaqmcmilgyrgdqgpl",
"phqwhhl",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.String[3]
{
"efuinpe",
"aargkcx",
"",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 57,
    Value = 
new System.String[4]
{
"gegbivmyuuxrhx",
"momcchp",
"wngumxwcntuhdffm",
"qaahkiqxj",
},
    NullableValue = 
new System.String[4]
{
"rdjjjcjcllambxlknkk",
"oepnbdgxvfnrvrakgdiobsj",
"tdboejxxuv",
"ogxnxiildbdddegcumhdtwikywmw",
},
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 121,
    Value = 
new System.String[3]
{
"ydgqhmkill",
"",
"ifui",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"rlimrlmeustj",
"qby",
"pxw",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.String[4]
{
"guv",
"adgb",
"mcvvldaennpqvnwypyiwhoq",
"ssfime",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.String[4]
{
"btrawspkyithgapshw",
"kifi",
"abuwik",
"gocwgylmihdonqqdvhuxigvmbg",
},
    NullableValue = 
new System.String[4]
{
"tm",
"dcdwphtqaiaomhmpjnjjsasolbo",
"",
"rhochlyhonnhsybytvpvv",
},
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 132,
    Value = 
new System.String[3]
{
"wauqrefjdwpv",
"pxibftaipsjjkssy",
"lx",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.String[4]
{
"csjhbsahigqloxbv",
"pkhltnsylpjdxoxbaqlntrmbeiw",
"nvtiyqwtjxisgprqhsxdmivloy",
"mljvxkhghdjghigjdelap",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.String[3]
{
"nj",
"hc",
"",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"ierh",
"mvagvd",
"s",
"vrcggsscidcwmwbspowkd",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 143,
    Value = 
new System.String[4]
{
"ovylpvxtvv",
"slkwnw",
"dvpgdqpvhodimuqlakyvwqxus",
"lcxkbrvcxoj",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 145,
    Value = 
new System.String[3]
{
"hvnhgrdtvfrwgxukuxhlrhspki",
"q",
"sujruh",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 62,
    Value = 
new System.String[3]
{
"x",
"mcrkrbtqjlovogjomfkedub",
"fnbyogtct",
},
    NullableValue = 
new System.String[3]
{
"vluffwnchhpwrlnwfqteck",
"dtyvsgcnfbrx",
"narkpvn",
},
},
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.String[4]
{
"mqr",
"admntxyasvfbhvfkwesbtaqjpdmk",
"vd",
"csdhnlofiikmakta",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 156,
    Value = 
new System.String[4]
{
"hugv",
"wyuvtekfjfceiytltjkrfuilud",
"iqxrpidfmghveulperdfiqrputkin",
"",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 71,
    Value = 
new System.String[3]
{
"kt",
"flfrkueuttd",
"cneibfudgtallky",
},
    NullableValue = 
new System.String[3]
{
"c",
"othohgolqulyynpvu",
"d",
},
},
    NullableValue = 
new System.String[3]
{
"fngwggsxyk",
"acsdfgtabx",
"dsxjvvydnoooolqlevyxmleqa",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.String[3]
{
"xhrvugunvhpnmlqnieatuoyvnrmle",
"hbwwllgx",
"ascku",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 172,
    Value = 
new System.String[3]
{
"",
"kjubaoldhwyvniryailtxe",
"bmqgtrj",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.String[4]
{
"bqoy",
"bgmd",
"mdfqwcuoc",
"rqukrehtlarqpyihebnjcuw",
},
    NullableValue = 
new System.String[4]
{
"ihm",
"kydyvopfjfgkvtfwihobovcoflold",
"loirayiwhbovms",
"kjplg",
},
},
    NullableValue = 
new System.String[4]
{
"iunxqejmjjatssmklwyytx",
"tonkavss",
"rlhe",
"totkjdkwp",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 181,
    Value = 
new System.String[3]
{
"geecbpwvmfkequyloiuxylivglaqr",
"wqtxluvtmhgcqpnujklvqbaxd",
"vdavdkva",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextMMArrayD1E1M
{
    Id = 186,
    Value = 
new System.String[3]
{
"tcgxux",
"ruogcmtwayojgjijihhjkwfxxek",
"fusosdqgyoifwgfikehn",
},
    ModelInner = new StringtextMMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.String[4]
{
"grkpfkalmygamyphiyhmuaadkwj",
"ciow",
"iltihaadstncnamoqwqsuer",
"xgquemeingqaueawdtnrjjquxibr",
},
    NullableValue = 
new System.String[4]
{
"aivthrjtmcmpywh",
"bowcynmqyuqjwlmlnkewfnvhwn",
"cehhpqmv",
"ofxyrxtfiixlygwfvtii",
},
},
    NullableValue = 
new System.String[3]
{
"mesbkouvpuhmdd",
"opfh",
"yyuimvwnxr",
},
},
            new StringtextMMArrayD1E1M
{
    Id = 191,
    Value = 
new System.String[4]
{
"yqouhsahdogtlxj",
"phsopcmujdqgliytbf",
"glpirivasexpuegmagmelgtkwa",
"bdilaabhmirbrapginvycrnif",
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmmarrayd1e1mi(
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmmarrayd1e1mi(
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
            queryMapTypes: [typeof(StringtextMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
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

                changedRows =  ((IStringMArraytextMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringMArraytextMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IStringMArraytextMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    stringtextmmarrayd1e1mi_id
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextmmarrayd1e1mi_id", 
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
                changedRows =  ((IStringMArraytextMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IStringMArraytextMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IStringMArraytextMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IStringMArraytextMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    stringtextmmarrayd1e1mi_id
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
    stringtextmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.String[]>();
                    ((NpgsqlParameter<System.String[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IStringMArraytextMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.String[]>();
                    ((NpgsqlParameter<System.String[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IStringMArraytextMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.String[]>();
                    ((NpgsqlParameter<System.String[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IStringMArraytextMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[3]
{
"mnxxtbjnpvieu",
"avwrxclehmuhglvyt",
"mewpjvnklftayugmfgvbufej",
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.String[]>();
                    ((NpgsqlParameter<System.String[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    ((NpgsqlParameter<System.String[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483629);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IStringMArraytextMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[4]
{
"mtxvdlkiafcxvcxckl",
"hqjjaobpmdwhyhtineppype",
"chfgwgqhuiowpngbj",
"tppnvnyg",
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    stringtextmmarrayd1e1mi_id
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
    stringtextmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.String[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483629)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "stringtextmmarrayd1e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[] nullable = null;
                nullable =  ((IStringMArraytextMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IStringMArraytextMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[4]
{
"flyucbdhwxjttyaaxxbcvsfplmm",
"nlpiwkjanbqafraptqlk",
"bsumifwdgqcaxnqo",
"pksltnxcttnfeaxheklob",
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[] nullable = null;
                nullable = await ((IStringMArraytextMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IStringMArraytextMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[4]
{
"hrmklqoyqygtgmmgahrnw",
"d",
"",
"vxta",
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextMMArrayD1E1M> models = null;

                models =  ((IStringMArraytextMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IStringMArraytextMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IStringMArraytextMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IStringMArraytextMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextMMArrayD1E1M> models = null;

                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IStringMArraytextMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M), typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                ((IStringMArraytextMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringMArraytextMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringMArraytextMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
LEFT JOIN public.stringtextmmarrayd1e1mi mi ON mi.id = m.stringtextmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models = await ((IStringMArraytextMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IStringMArraytextMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M), typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                ((IStringMArraytextMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IStringMArraytextMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IStringMArraytextMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
LEFT JOIN public.stringtextmmarrayd1e1mi mi ON mi.id = m.stringtextmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models = await ((IStringMArraytextMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringMArraytextMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M), typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                await((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 172;
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                ((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                 ((IStringMArraytextMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                 ((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringMArraytextMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringMArraytextMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                 ((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
LEFT JOIN public.stringtextmmarrayd1e1mi mi ON mi.id = m.stringtextmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models = await((IStringMArraytextMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringMArraytextMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        StringtextMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        StringtextMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        StringtextMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        StringtextMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        StringtextMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        StringtextMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        StringtextMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        StringtextMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        StringtextMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        StringtextMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        StringtextMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IStringMArraytextMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringMArraytextMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        StringtextMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        StringtextMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        StringtextMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        StringtextMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        StringtextMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        StringtextMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        StringtextMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        StringtextMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        StringtextMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        StringtextMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        StringtextMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        StringtextMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        StringtextMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        StringtextMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        StringtextMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        StringtextMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        StringtextMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        StringtextMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        StringtextMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M), typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                await((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 112, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextMMArrayD1E1M>();
                var models2 = new List<FlatStringtextMMArrayD1E1M>();
                ((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                 ((IStringMArraytextMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 141, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var firstItems2 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                 ((IStringMArraytextMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 112, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringMArraytextMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 145, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                await ((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 25, query1, 181, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringMArraytextMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatStringtextMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
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
FROM public.stringtextmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems1 = new List<FlatStringtextMMArrayD1E1M>();
                var secondItems2 = new List<FlatStringtextMMArrayD1E1M>();
                 ((IStringMArraytextMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 93, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatStringtextMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.stringtextmmarrayd1e1m m
LEFT JOIN public.stringtextmmarrayd1e1mi mi ON mi.id = m.stringtextmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models = await((IStringMArraytextMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IStringMArraytextMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 165))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        StringtextMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        StringtextMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        StringtextMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        StringtextMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IStringMArraytextMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IStringMArraytextMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 8, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        StringtextMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        StringtextMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        StringtextMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        StringtextMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        StringtextMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        StringtextMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        StringtextMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        StringtextMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        StringtextMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        StringtextMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        StringtextMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        StringtextMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        StringtextMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        StringtextMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        StringtextMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        StringtextMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        StringtextMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        StringtextMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        StringtextMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        StringtextMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        StringtextMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        StringtextMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        StringtextMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        StringtextMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        StringtextMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        StringtextMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        StringtextMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        StringtextMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        StringtextMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        StringtextMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        StringtextMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        StringtextMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        StringtextMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        StringtextMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        StringtextMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        StringtextMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        StringtextMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        StringtextMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        StringtextMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        StringtextMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        StringtextMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        StringtextMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        StringtextMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        StringtextMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        StringtextMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        StringtextMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        StringtextMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        StringtextMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        StringtextMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        StringtextMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        StringtextMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        StringtextMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        StringtextMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        StringtextMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        StringtextMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        StringtextMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        StringtextMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        StringtextMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        StringtextMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
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
                await using var cmd = await ((IStringMArraytextMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringMArraytextMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models = await ((IStringMArraytextMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                StringtextMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                StringtextMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                StringtextMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                StringtextMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                StringtextMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                StringtextMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                StringtextMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                StringtextMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                StringtextMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                StringtextMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringMArraytextMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringMArraytextMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models =  ((IStringMArraytextMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                StringtextMMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                StringtextMMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                StringtextMMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                StringtextMMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                StringtextMMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                StringtextMMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                StringtextMMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                StringtextMMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                StringtextMMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                StringtextMMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                StringtextMMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                StringtextMMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                StringtextMMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                StringtextMMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                StringtextMMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                StringtextMMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                StringtextMMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                StringtextMMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                StringtextMMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                StringtextMMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                StringtextMMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                StringtextMMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                StringtextMMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                StringtextMMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                StringtextMMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                StringtextMMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                StringtextMMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                StringtextMMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                StringtextMMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                StringtextMMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                StringtextMMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                StringtextMMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                StringtextMMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                StringtextMMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.binary_stringtextmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(StringtextMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringMArraytextMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringMArraytextMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringMArraytextMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringMArraytextMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_stringtextmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(StringtextMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringMArraytextMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringMArraytextMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringMArraytextMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringMArraytextMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_stringtextmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(StringtextMMArrayD1E1MI),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IStringMArraytextMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringMArraytextMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IStringMArraytextMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IStringMArraytextMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_stringtextmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(StringtextMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringMArraytextMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringMArraytextMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringMArraytextMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IStringMArraytextMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtextmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(StringtextMMArrayD1E1M),
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
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
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
FROM public.binary_stringtextmmarrayd1e1m m
LEFT JOIN public.binary_stringtextmmarrayd1e1mi mi ON mi.id = m.stringtextmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IStringMArraytextMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IStringMArraytextMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IStringMArraytextMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IStringMArraytextMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtextmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(StringtextMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models =  ((IStringMArraytextMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringMArraytextMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA), typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models1 = new List<StringtextMMArrayD1E1MIWA>();
                var models2 = new List<StringtextMMArrayD1E1MIWA>();
                await ((IStringMArraytextMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextMMArrayD1E1MIWA>();
                var models2 = new List<StringtextMMArrayD1E1MIWA>();
                ((IStringMArraytextMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models = await ((IStringMArraytextMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_stringtextmmarrayd1e1mi
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
                    StringtextMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IStringMArraytextMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_stringtextmmarrayd1e1mi
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
                    StringtextMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA), typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
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
                var models1 = new List<StringtextMMArrayD1E1MIWA>();
                var models2 = new List<StringtextMMArrayD1E1MIWA>();
                await ((IStringMArraytextMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextMMArrayD1E1MIWA>();
                var models2 = new List<StringtextMMArrayD1E1MIWA>();
                ((IStringMArraytextMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
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
                var models = await ((IStringMArraytextMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_stringtextmmarrayd1e1mi
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
                    StringtextMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IStringMArraytextMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_stringtextmmarrayd1e1mi
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
                    StringtextMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_stringtextmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MI), typeof(StringtextMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models1 = new List<StringtextMMArrayD1E1MI>();
                var models2 = new List<StringtextMMArrayD1E1MI>();
                await ((IStringMArraytextMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextMMArrayD1E1MI>();
                var models2 = new List<StringtextMMArrayD1E1MI>();
                ((IStringMArraytextMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1)),
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
                var models = await ((IStringMArraytextMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IStringMArraytextMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_stringtextmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA), typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
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
                var models1 = new List<StringtextMMArrayD1E1MIWA>();
                var models2 = new List<StringtextMMArrayD1E1MIWA>();
                await ((IStringMArraytextMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextMMArrayD1E1MIWA>();
                var models2 = new List<StringtextMMArrayD1E1MIWA>();
                ((IStringMArraytextMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(StringtextMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArraytextMMArrayD1))]
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
                var models = await ((IStringMArraytextMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IStringMArraytextMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

