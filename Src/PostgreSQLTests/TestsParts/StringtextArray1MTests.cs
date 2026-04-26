

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
    internal partial interface IStringArraytextArray
    {
    }
    
    internal partial class StringArraytextArray : IStringArraytextArray
    {


#region TestData

        private readonly StringtextArray1M[] _testData = new StringtextArray1M[]
        {
            new StringtextArray1M
{
    Id = 9,
    Value = 
new System.String[3]
{
"yh",
"iavqacwwsuhgtwvlnqtfvekkbgw",
"ksmhesvbeeuyntgxyggsdwmrfd",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 13,
    Value = 
new System.String[4]
{
"wtypujbhnmiaeiecd",
"evyjvqavukwymckigcoqyijbnp",
"coaukipciqkxcxpsttstvldv",
"iyhvcktefthd",
},
    ModelInner = new StringtextArray1MI
{
    Id = 6,
    Value = 
new System.String[4]
{
"aioavtebxxgudsguuudyt",
"lnicqqmertwypt",
"fbypwwntusfvxnxjsqyihrhiou",
"icnjnodhockdekbqdd",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 19,
    Value = 
new System.String[3]
{
"sklikpjkhxaqhbkrjsuuwradqaqm",
"jkousiilldfopdjiwfmtyaula",
"",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"",
"esyjinmcgttuk",
"vjmriariybksmnevxwnfpb",
},
},
            new StringtextArray1M
{
    Id = 20,
    Value = 
new System.String[3]
{
"abqxtsqf",
"dmshwfiklupfbknhe",
"iaowrdffucryood",
},
    ModelInner = new StringtextArray1MI
{
    Id = 7,
    Value = 
new System.String[4]
{
"uhrqig",
"wbluihygxrwcedxll",
"bvrklaodjlesqcbc",
"",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 22,
    Value = 
new System.String[3]
{
"ybsiqaqkwgctlsbstpri",
"yjengeiibluugassfbn",
"ovqdvwsmkejxqxfdwoxpyvov",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 30,
    Value = 
new System.String[4]
{
"witlvplsdtht",
"mysetmbocplyplvyrgftrr",
"yvwpeuajhpcfqqhteptua",
"utjrrdbhpgfldyxbyuybcgbadwsj",
},
    ModelInner = new StringtextArray1MI
{
    Id = 10,
    Value = 
new System.String[3]
{
"wqlhcjtwtjloo",
"bjmdujliwjewrbmvnawsqcdal",
"kvjmkweexvciineypinwdvqcs",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"bqdywupsprmjjvoqvdtj",
"jnsnwjhekevutfenkta",
"cq",
"tevdhspht",
},
},
            new StringtextArray1M
{
    Id = 37,
    Value = 
new System.String[3]
{
"",
"gypyjgpuxilhmdtyidxvddsnsuv",
"ekhy",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 45,
    Value = 
new System.String[4]
{
"wlwqgeoenqtlgwcvmkldomarxb",
"vexwamdqhxrrlsimaeuoyr",
"gsi",
"vavlxtydgmgklejnyxxoeu",
},
    ModelInner = new StringtextArray1MI
{
    Id = 19,
    Value = 
new System.String[4]
{
"qtxkptcemidhegtvyuwisuemwbmvu",
"rbdhylppvjrldfdcx",
"wrsfqehpnnul",
"gbolwr",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 51,
    Value = 
new System.String[4]
{
"",
"",
"eoiqir",
"sejvhp",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"olvy",
"dcnv",
"vyemgbqcgyipblphhiftcfuwjwfn",
},
},
            new StringtextArray1M
{
    Id = 59,
    Value = 
new System.String[4]
{
"ttf",
"b",
"sshlbtgw",
"hayykpk",
},
    ModelInner = new StringtextArray1MI
{
    Id = 27,
    Value = 
new System.String[3]
{
"wbicpsfqbxjbme",
"br",
"sphnulisayamskurgwrphhjoo",
},
    NullableValue = 
new System.String[3]
{
"uxehsmgplwmyjybcp",
"fmmmsqyqvxn",
"jfbwwqudctajuedvpanh",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 67,
    Value = 
new System.String[4]
{
"sxdrgvqmt",
"dnlnuntsrac",
"mwjmgrct",
"bfikiwitodscesnjgabdcsshyrj",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 76,
    Value = 
new System.String[4]
{
"ogwisquptmiryglyfjnttsjjgslt",
"wandsrplamsekbubcno",
"awi",
"cbxxnrpxsosxyc",
},
    ModelInner = new StringtextArray1MI
{
    Id = 28,
    Value = 
new System.String[3]
{
"tguyxnbwhpmnyjxpvvqmcjmy",
"kignbcnngticrr",
"giartljvwwktesuuxsrjm",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[4]
{
"",
"iygjakxjfefhbrwaxsvdhsyjdw",
"dxcqtwmwaewjxttshhnfbooscrgnh",
"fgruqaynofsik",
},
},
            new StringtextArray1M
{
    Id = 79,
    Value = 
new System.String[3]
{
"ocyin",
"dvs",
"",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 80,
    Value = 
new System.String[3]
{
"jcptejmevbaxy",
"nvlvxrsbbfnnvrtvbkwbiovkhh",
"xqu",
},
    ModelInner = new StringtextArray1MI
{
    Id = 29,
    Value = 
new System.String[4]
{
"dmea",
"nvwipfgibclwvssxndwlfdbr",
"qpuuvhufd",
"tli",
},
    NullableValue = 
new System.String[4]
{
"vj",
"jxoqjwuhvlmsklxjftyc",
"ijtjwfteaxvqwvt",
"cwxd",
},
},
    NullableValue = 
new System.String[3]
{
"imc",
"esldsjxoxrbevojn",
"eesmhtonumpqqyhf",
},
},
            new StringtextArray1M
{
    Id = 86,
    Value = 
new System.String[3]
{
"jtekiqixeunr",
"kmpvh",
"otbivlndqpsagltvpbqksir",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 91,
    Value = 
new System.String[4]
{
"iipfdssuuehjgqgmurixdfhqf",
"olhpqmi",
"acfuxjjpopefybnidne",
"ddtp",
},
    ModelInner = new StringtextArray1MI
{
    Id = 31,
    Value = 
new System.String[3]
{
"mxcwgqkf",
"qysuoofctvfpujgfggqarucuyvkc",
"fhsoqnhrbf",
},
    NullableValue = 
new System.String[3]
{
"vgwsykewjyffrqdrvpmylcvdiq",
"jaux",
"ojqsjbjljfma",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 96,
    Value = 
new System.String[3]
{
"hrlfgxgjaplrswnvdcg",
"i",
"ycdximdkunwul",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"lx",
"cwlc",
"qfktki",
"skpsl",
},
},
            new StringtextArray1M
{
    Id = 102,
    Value = 
new System.String[4]
{
"drwmsaolqwxipb",
"jdbwpmstunehdhvgixkuin",
"jwrldcbpcagxvf",
"rfevndbbfvcubwsxtoirvs",
},
    ModelInner = new StringtextArray1MI
{
    Id = 36,
    Value = 
new System.String[3]
{
"hayyy",
"joshogsuyabh",
"evkhpxjhagpcyslhpfv",
},
    NullableValue = 
new System.String[4]
{
"bxvvxsciidxiqvgsf",
"o",
"sgdqmgf",
"qxlaflciehbuvpion",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 107,
    Value = 
new System.String[4]
{
"awhftkriirqjawgytx",
"iakyhppk",
"ljbcpylcpfdutfaidgxodvqtbvhh",
"",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"yqqyvtlbcb",
"imjhcnxjelqjpuqhf",
"iocltrokgsxh",
"clvwsbdmrhgpr",
},
},
            new StringtextArray1M
{
    Id = 109,
    Value = 
new System.String[3]
{
"rdanxolmkxhupwjcfilio",
"ucoohaxtyjd",
"mrjqpkvgrdkelbdcvff",
},
    ModelInner = new StringtextArray1MI
{
    Id = 44,
    Value = 
new System.String[3]
{
"iegwvjaxnjh",
"a",
"qpsysua",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"nfevkwyshmlshjjjrobkpyhouwq",
"a",
"tdnkhqeystpnhrkqbv",
},
},
            new StringtextArray1M
{
    Id = 112,
    Value = 
new System.String[4]
{
"uumm",
"",
"iqevbbhjugjhhlejemt",
"aydjyiepf",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"tffca",
"feulgstilnjchfj",
"wmtixdpmaxxnwa",
},
},
            new StringtextArray1M
{
    Id = 113,
    Value = 
new System.String[4]
{
"halmrakbkurwfxqqfaluanhp",
"mcvjyfmgwoue",
"huihhrcrkkxxdysmbrvlkyahqma",
"mjaxhuvxdsxnv",
},
    ModelInner = new StringtextArray1MI
{
    Id = 46,
    Value = 
new System.String[3]
{
"fskkkygxjyoqcow",
"cqirvptnufbhjrujokk",
"epvguhgufsdirxibeu",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 121,
    Value = 
new System.String[4]
{
"av",
"fdnwploqybcbqpjgjhfqoh",
"kuobojak",
"vcilt",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 124,
    Value = 
new System.String[4]
{
"tpqswvyisgruw",
"m",
"h",
"klfpgdyvkbivhjfhd",
},
    ModelInner = new StringtextArray1MI
{
    Id = 49,
    Value = 
new System.String[3]
{
"yjxkpyddmcgu",
"tqpaytoplfyiyggdfp",
"sllbmfbmcmytnwcr",
},
    NullableValue = 
new System.String[4]
{
"gydcbjvjjbikoj",
"cukepxfwjswug",
"qndxl",
"yxvbpksbw",
},
},
    NullableValue = 
new System.String[4]
{
"cowdyvgftlxqblxqvypxskufyuhq",
"qegtikeivkflihhi",
"jkbxb",
"tuunkitkex",
},
},
            new StringtextArray1M
{
    Id = 132,
    Value = 
new System.String[4]
{
"ybcwdejrarvwmlb",
"ksqgnsymnfipypobwha",
"l",
"tdqoojuiggqgplycqfa",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 139,
    Value = 
new System.String[4]
{
"gusbxoj",
"uapenqcfftfrvgqojfvqhsexwdnek",
"xlpkduqnqwrfqinybiprym",
"mdjrgtgjllmygvaqvqvx",
},
    ModelInner = new StringtextArray1MI
{
    Id = 55,
    Value = 
new System.String[3]
{
"",
"jpgbwkoxtwurrgcsacvrbr",
"sypebvpuqrulcqdwftymh",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 148,
    Value = 
new System.String[4]
{
"yqgqtdtyveyibbjbiwsfkamscdlhe",
"pdbfbpurfrqnkcvgllc",
"xqqtycdkurtoslbdu",
"lsms",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"jqks",
"vgurpm",
"",
},
},
            new StringtextArray1M
{
    Id = 156,
    Value = 
new System.String[3]
{
"urevboknx",
"pskduolqmqddlwgxflcifixrjkehg",
"rxweekewhicfslkceyjqcaih",
},
    ModelInner = new StringtextArray1MI
{
    Id = 58,
    Value = 
new System.String[3]
{
"wdfrdvgvtlqbdmma",
"kcyexewrshstsnlthiamipksieib",
"togyteqmsuvrkysf",
},
    NullableValue = 
new System.String[3]
{
"riesohlsskbhhioe",
"wqjspujgbvkyebnyj",
"kbiwcmabrceujbpualhlntloe",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 160,
    Value = 
new System.String[3]
{
"bgyqvethn",
"akrdiawalwmsclusqnwqugc",
"alrmmeic",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"tdsambbel",
"yfuupavvuuk",
"isvfjuqud",
},
},
            new StringtextArray1M
{
    Id = 162,
    Value = 
new System.String[4]
{
"ksqmovfbgovpangdgx",
"wlqrx",
"woxhxwnimebgqoyp",
"cyyfejkfbnwnaj",
},
    ModelInner = new StringtextArray1MI
{
    Id = 62,
    Value = 
new System.String[3]
{
"qpyex",
"iuxowatldbnjppixnwjqe",
"yljxmbkylhc",
},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray1mi(
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
            asPartInterface: typeof(IStringArraytextArray)),
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
INSERT INTO public.stringtextarray1mi(
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
            queryMapTypes: [typeof(StringtextArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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

                changedRows =  ((IStringArraytextArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringArraytextArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IStringArraytextArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringArraytextArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IStringArraytextArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IStringArraytextArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IStringArraytextArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray1m(
	id,
    value,
    nullablevalue,
    stringtextarray1mi_id
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
            asPartInterface: typeof(IStringArraytextArray)), 
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
                methodParametrName: "stringtextarray1mi_id", 
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
                changedRows =  ((IStringArraytextArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IStringArraytextArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IStringArraytextArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IStringArraytextArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray1m(
	id,
    value,
    nullablevalue,
    stringtextarray1mi_id
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
    stringtextarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(StringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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

                    nullable =  ((IStringArraytextArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IStringArraytextArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[4]
{
"bqdywupsprmjjvoqvdtj",
"jnsnwjhekevutfenkta",
"cq",
"tevdhspht",
}));
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

                    nullable = await ((IStringArraytextArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((IStringArraytextArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextarray1m(
	id,
    value,
    nullablevalue,
    stringtextarray1mi_id
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
    stringtextarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(StringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
                methodParametrName: "stringtextarray1mi_id", 
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
                nullable =  ((IStringArraytextArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[3]
{
"olvy",
"dcnv",
"vyemgbqcgyipblphhiftcfuwjwfn",
}));
                nullable =  ((IStringArraytextArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.String[] nullable = null;
                nullable = await ((IStringArraytextArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IStringArraytextArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[4]
{
"",
"iygjakxjfefhbrwaxsvdhsyjdw",
"dxcqtwmwaewjxttshhnfbooscrgnh",
"fgruqaynofsik",
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextArray1M> models = null;

                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IStringArraytextArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextArray1M> models = null;

                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IStringArraytextArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray1M), typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                ((IStringArraytextArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringArraytextArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringArraytextArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextarray1m m
LEFT JOIN public.stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
                var models = await ((IStringArraytextArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IStringArraytextArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray1M), typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                ((IStringArraytextArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IStringArraytextArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IStringArraytextArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextarray1m m
LEFT JOIN public.stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
                var models = await ((IStringArraytextArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringArraytextArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray1M), typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                await((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                ((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringArraytextArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray1m m
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatStringtextArray1M.AssertModel(models[0],_testData[7], false);FlatStringtextArray1M.AssertModel(models[1],_testData[8], false);FlatStringtextArray1M.AssertModel(models[2],_testData[9], false);FlatStringtextArray1M.AssertModel(models[3],_testData[10], false);FlatStringtextArray1M.AssertModel(models[4],_testData[11], false);FlatStringtextArray1M.AssertModel(models[5],_testData[12], false);FlatStringtextArray1M.AssertModel(models[6],_testData[13], false);FlatStringtextArray1M.AssertModel(models[7],_testData[14], false);FlatStringtextArray1M.AssertModel(models[8],_testData[15], false);FlatStringtextArray1M.AssertModel(models[9],_testData[16], false);FlatStringtextArray1M.AssertModel(models[10],_testData[17], false);FlatStringtextArray1M.AssertModel(models[11],_testData[18], false);FlatStringtextArray1M.AssertModel(models[12],_testData[19], false);FlatStringtextArray1M.AssertModel(models[13],_testData[20], false);FlatStringtextArray1M.AssertModel(models[14],_testData[21], false);FlatStringtextArray1M.AssertModel(models[15],_testData[22], false);FlatStringtextArray1M.AssertModel(models[16],_testData[23], false);FlatStringtextArray1M.AssertModel(models[17],_testData[24], false);FlatStringtextArray1M.AssertModel(models[18],_testData[25], false);FlatStringtextArray1M.AssertModel(models[19],_testData[26], false);FlatStringtextArray1M.AssertModel(models[20],_testData[27], false);FlatStringtextArray1M.AssertModel(models[21],_testData[28], false);FlatStringtextArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatStringtextArray1M.AssertModel(models[0],_testData[28], false);FlatStringtextArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray1m m
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatStringtextArray1M.AssertModel(models[0],_testData[13], false);FlatStringtextArray1M.AssertModel(models[1],_testData[14], false);FlatStringtextArray1M.AssertModel(models[2],_testData[15], false);FlatStringtextArray1M.AssertModel(models[3],_testData[16], false);FlatStringtextArray1M.AssertModel(models[4],_testData[17], false);FlatStringtextArray1M.AssertModel(models[5],_testData[18], false);FlatStringtextArray1M.AssertModel(models[6],_testData[19], false);FlatStringtextArray1M.AssertModel(models[7],_testData[20], false);FlatStringtextArray1M.AssertModel(models[8],_testData[21], false);FlatStringtextArray1M.AssertModel(models[9],_testData[22], false);FlatStringtextArray1M.AssertModel(models[10],_testData[23], false);FlatStringtextArray1M.AssertModel(models[11],_testData[24], false);FlatStringtextArray1M.AssertModel(models[12],_testData[25], false);FlatStringtextArray1M.AssertModel(models[13],_testData[26], false);FlatStringtextArray1M.AssertModel(models[14],_testData[27], false);FlatStringtextArray1M.AssertModel(models[15],_testData[28], false);FlatStringtextArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatStringtextArray1M.AssertModel(models[0],_testData[1], false);FlatStringtextArray1M.AssertModel(models[1],_testData[2], false);FlatStringtextArray1M.AssertModel(models[2],_testData[3], false);FlatStringtextArray1M.AssertModel(models[3],_testData[4], false);FlatStringtextArray1M.AssertModel(models[4],_testData[5], false);FlatStringtextArray1M.AssertModel(models[5],_testData[6], false);FlatStringtextArray1M.AssertModel(models[6],_testData[7], false);FlatStringtextArray1M.AssertModel(models[7],_testData[8], false);FlatStringtextArray1M.AssertModel(models[8],_testData[9], false);FlatStringtextArray1M.AssertModel(models[9],_testData[10], false);FlatStringtextArray1M.AssertModel(models[10],_testData[11], false);FlatStringtextArray1M.AssertModel(models[11],_testData[12], false);FlatStringtextArray1M.AssertModel(models[12],_testData[13], false);FlatStringtextArray1M.AssertModel(models[13],_testData[14], false);FlatStringtextArray1M.AssertModel(models[14],_testData[15], false);FlatStringtextArray1M.AssertModel(models[15],_testData[16], false);FlatStringtextArray1M.AssertModel(models[16],_testData[17], false);FlatStringtextArray1M.AssertModel(models[17],_testData[18], false);FlatStringtextArray1M.AssertModel(models[18],_testData[19], false);FlatStringtextArray1M.AssertModel(models[19],_testData[20], false);FlatStringtextArray1M.AssertModel(models[20],_testData[21], false);FlatStringtextArray1M.AssertModel(models[21],_testData[22], false);FlatStringtextArray1M.AssertModel(models[22],_testData[23], false);FlatStringtextArray1M.AssertModel(models[23],_testData[24], false);FlatStringtextArray1M.AssertModel(models[24],_testData[25], false);FlatStringtextArray1M.AssertModel(models[25],_testData[26], false);FlatStringtextArray1M.AssertModel(models[26],_testData[27], false);FlatStringtextArray1M.AssertModel(models[27],_testData[28], false);FlatStringtextArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.stringtextarray1m m
LEFT JOIN public.stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(StringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSelectModelDynParBatchConfig()
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
                var models = await((IStringArraytextArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
StringtextArray1M.AssertModel(models[0],_testData[1], false);StringtextArray1M.AssertModel(models[1],_testData[2], false);StringtextArray1M.AssertModel(models[2],_testData[3], false);StringtextArray1M.AssertModel(models[3],_testData[4], false);StringtextArray1M.AssertModel(models[4],_testData[5], false);StringtextArray1M.AssertModel(models[5],_testData[6], false);StringtextArray1M.AssertModel(models[6],_testData[7], false);StringtextArray1M.AssertModel(models[7],_testData[8], false);StringtextArray1M.AssertModel(models[8],_testData[9], false);StringtextArray1M.AssertModel(models[9],_testData[10], false);StringtextArray1M.AssertModel(models[10],_testData[11], false);StringtextArray1M.AssertModel(models[11],_testData[12], false);StringtextArray1M.AssertModel(models[12],_testData[13], false);StringtextArray1M.AssertModel(models[13],_testData[14], false);StringtextArray1M.AssertModel(models[14],_testData[15], false);StringtextArray1M.AssertModel(models[15],_testData[16], false);StringtextArray1M.AssertModel(models[16],_testData[17], false);StringtextArray1M.AssertModel(models[17],_testData[18], false);StringtextArray1M.AssertModel(models[18],_testData[19], false);StringtextArray1M.AssertModel(models[19],_testData[20], false);StringtextArray1M.AssertModel(models[20],_testData[21], false);StringtextArray1M.AssertModel(models[21],_testData[22], false);StringtextArray1M.AssertModel(models[22],_testData[23], false);StringtextArray1M.AssertModel(models[23],_testData[24], false);StringtextArray1M.AssertModel(models[24],_testData[25], false);StringtextArray1M.AssertModel(models[25],_testData[26], false);StringtextArray1M.AssertModel(models[26],_testData[27], false);StringtextArray1M.AssertModel(models[27],_testData[28], false);StringtextArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
StringtextArray1M.AssertModel(models[0],_testData[7], false);StringtextArray1M.AssertModel(models[1],_testData[8], false);StringtextArray1M.AssertModel(models[2],_testData[9], false);StringtextArray1M.AssertModel(models[3],_testData[10], false);StringtextArray1M.AssertModel(models[4],_testData[11], false);StringtextArray1M.AssertModel(models[5],_testData[12], false);StringtextArray1M.AssertModel(models[6],_testData[13], false);StringtextArray1M.AssertModel(models[7],_testData[14], false);StringtextArray1M.AssertModel(models[8],_testData[15], false);StringtextArray1M.AssertModel(models[9],_testData[16], false);StringtextArray1M.AssertModel(models[10],_testData[17], false);StringtextArray1M.AssertModel(models[11],_testData[18], false);StringtextArray1M.AssertModel(models[12],_testData[19], false);StringtextArray1M.AssertModel(models[13],_testData[20], false);StringtextArray1M.AssertModel(models[14],_testData[21], false);StringtextArray1M.AssertModel(models[15],_testData[22], false);StringtextArray1M.AssertModel(models[16],_testData[23], false);StringtextArray1M.AssertModel(models[17],_testData[24], false);StringtextArray1M.AssertModel(models[18],_testData[25], false);StringtextArray1M.AssertModel(models[19],_testData[26], false);StringtextArray1M.AssertModel(models[20],_testData[27], false);StringtextArray1M.AssertModel(models[21],_testData[28], false);StringtextArray1M.AssertModel(models[22],_testData[29], false);
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
                var models = ((IStringArraytextArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
StringtextArray1M.AssertModel(models[0],_testData[27], false);StringtextArray1M.AssertModel(models[1],_testData[28], false);StringtextArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
StringtextArray1M.AssertModel(models[0],_testData[1], false);StringtextArray1M.AssertModel(models[1],_testData[2], false);StringtextArray1M.AssertModel(models[2],_testData[3], false);StringtextArray1M.AssertModel(models[3],_testData[4], false);StringtextArray1M.AssertModel(models[4],_testData[5], false);StringtextArray1M.AssertModel(models[5],_testData[6], false);StringtextArray1M.AssertModel(models[6],_testData[7], false);StringtextArray1M.AssertModel(models[7],_testData[8], false);StringtextArray1M.AssertModel(models[8],_testData[9], false);StringtextArray1M.AssertModel(models[9],_testData[10], false);StringtextArray1M.AssertModel(models[10],_testData[11], false);StringtextArray1M.AssertModel(models[11],_testData[12], false);StringtextArray1M.AssertModel(models[12],_testData[13], false);StringtextArray1M.AssertModel(models[13],_testData[14], false);StringtextArray1M.AssertModel(models[14],_testData[15], false);StringtextArray1M.AssertModel(models[15],_testData[16], false);StringtextArray1M.AssertModel(models[16],_testData[17], false);StringtextArray1M.AssertModel(models[17],_testData[18], false);StringtextArray1M.AssertModel(models[18],_testData[19], false);StringtextArray1M.AssertModel(models[19],_testData[20], false);StringtextArray1M.AssertModel(models[20],_testData[21], false);StringtextArray1M.AssertModel(models[21],_testData[22], false);StringtextArray1M.AssertModel(models[22],_testData[23], false);StringtextArray1M.AssertModel(models[23],_testData[24], false);StringtextArray1M.AssertModel(models[24],_testData[25], false);StringtextArray1M.AssertModel(models[25],_testData[26], false);StringtextArray1M.AssertModel(models[26],_testData[27], false);StringtextArray1M.AssertModel(models[27],_testData[28], false);StringtextArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray1M), typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                await((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextArray1M>();
                var models2 = new List<FlatStringtextArray1M>();
                ((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringArraytextArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray1m m
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 22, query1, 107, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatStringtextArray1M.AssertModel(models[0],_testData[5], false);FlatStringtextArray1M.AssertModel(models[1],_testData[6], false);FlatStringtextArray1M.AssertModel(models[2],_testData[7], false);FlatStringtextArray1M.AssertModel(models[3],_testData[8], false);FlatStringtextArray1M.AssertModel(models[4],_testData[9], false);FlatStringtextArray1M.AssertModel(models[5],_testData[10], false);FlatStringtextArray1M.AssertModel(models[6],_testData[11], false);FlatStringtextArray1M.AssertModel(models[7],_testData[12], false);FlatStringtextArray1M.AssertModel(models[8],_testData[13], false);FlatStringtextArray1M.AssertModel(models[9],_testData[14], false);FlatStringtextArray1M.AssertModel(models[10],_testData[15], false);FlatStringtextArray1M.AssertModel(models[11],_testData[16], false);FlatStringtextArray1M.AssertModel(models[12],_testData[17], false);FlatStringtextArray1M.AssertModel(models[13],_testData[18], false);FlatStringtextArray1M.AssertModel(models[14],_testData[19], false);FlatStringtextArray1M.AssertModel(models[15],_testData[20], false);FlatStringtextArray1M.AssertModel(models[16],_testData[21], false);FlatStringtextArray1M.AssertModel(models[17],_testData[22], false);FlatStringtextArray1M.AssertModel(models[18],_testData[23], false);FlatStringtextArray1M.AssertModel(models[19],_testData[24], false);FlatStringtextArray1M.AssertModel(models[20],_testData[25], false);FlatStringtextArray1M.AssertModel(models[21],_testData[26], false);FlatStringtextArray1M.AssertModel(models[22],_testData[27], false);FlatStringtextArray1M.AssertModel(models[23],_testData[28], false);FlatStringtextArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatStringtextArray1M.AssertModel(models[0],_testData[19], false);FlatStringtextArray1M.AssertModel(models[1],_testData[20], false);FlatStringtextArray1M.AssertModel(models[2],_testData[21], false);FlatStringtextArray1M.AssertModel(models[3],_testData[22], false);FlatStringtextArray1M.AssertModel(models[4],_testData[23], false);FlatStringtextArray1M.AssertModel(models[5],_testData[24], false);FlatStringtextArray1M.AssertModel(models[6],_testData[25], false);FlatStringtextArray1M.AssertModel(models[7],_testData[26], false);FlatStringtextArray1M.AssertModel(models[8],_testData[27], false);FlatStringtextArray1M.AssertModel(models[9],_testData[28], false);FlatStringtextArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringArraytextArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextarray1m m
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelBatch(connection, 30, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatStringtextArray1M.AssertModel(models[0],_testData[6], false);FlatStringtextArray1M.AssertModel(models[1],_testData[7], false);FlatStringtextArray1M.AssertModel(models[2],_testData[8], false);FlatStringtextArray1M.AssertModel(models[3],_testData[9], false);FlatStringtextArray1M.AssertModel(models[4],_testData[10], false);FlatStringtextArray1M.AssertModel(models[5],_testData[11], false);FlatStringtextArray1M.AssertModel(models[6],_testData[12], false);FlatStringtextArray1M.AssertModel(models[7],_testData[13], false);FlatStringtextArray1M.AssertModel(models[8],_testData[14], false);FlatStringtextArray1M.AssertModel(models[9],_testData[15], false);FlatStringtextArray1M.AssertModel(models[10],_testData[16], false);FlatStringtextArray1M.AssertModel(models[11],_testData[17], false);FlatStringtextArray1M.AssertModel(models[12],_testData[18], false);FlatStringtextArray1M.AssertModel(models[13],_testData[19], false);FlatStringtextArray1M.AssertModel(models[14],_testData[20], false);FlatStringtextArray1M.AssertModel(models[15],_testData[21], false);FlatStringtextArray1M.AssertModel(models[16],_testData[22], false);FlatStringtextArray1M.AssertModel(models[17],_testData[23], false);FlatStringtextArray1M.AssertModel(models[18],_testData[24], false);FlatStringtextArray1M.AssertModel(models[19],_testData[25], false);FlatStringtextArray1M.AssertModel(models[20],_testData[26], false);FlatStringtextArray1M.AssertModel(models[21],_testData[27], false);FlatStringtextArray1M.AssertModel(models[22],_testData[28], false);FlatStringtextArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatStringtextArray1M.AssertModel(models[0],_testData[22], false);FlatStringtextArray1M.AssertModel(models[1],_testData[23], false);FlatStringtextArray1M.AssertModel(models[2],_testData[24], false);FlatStringtextArray1M.AssertModel(models[3],_testData[25], false);FlatStringtextArray1M.AssertModel(models[4],_testData[26], false);FlatStringtextArray1M.AssertModel(models[5],_testData[27], false);FlatStringtextArray1M.AssertModel(models[6],_testData[28], false);FlatStringtextArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
FROM public.stringtextarray1m m
LEFT JOIN public.stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(StringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IStringArraytextArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionSelectModelBatchAsync(connection, 121, 91))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
StringtextArray1M.AssertModel(models[0],_testData[23], false);StringtextArray1M.AssertModel(models[1],_testData[24], false);StringtextArray1M.AssertModel(models[2],_testData[25], false);StringtextArray1M.AssertModel(models[3],_testData[26], false);StringtextArray1M.AssertModel(models[4],_testData[27], false);StringtextArray1M.AssertModel(models[5],_testData[28], false);StringtextArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
StringtextArray1M.AssertModel(models[0],_testData[16], false);StringtextArray1M.AssertModel(models[1],_testData[17], false);StringtextArray1M.AssertModel(models[2],_testData[18], false);StringtextArray1M.AssertModel(models[3],_testData[19], false);StringtextArray1M.AssertModel(models[4],_testData[20], false);StringtextArray1M.AssertModel(models[5],_testData[21], false);StringtextArray1M.AssertModel(models[6],_testData[22], false);StringtextArray1M.AssertModel(models[7],_testData[23], false);StringtextArray1M.AssertModel(models[8],_testData[24], false);StringtextArray1M.AssertModel(models[9],_testData[25], false);StringtextArray1M.AssertModel(models[10],_testData[26], false);StringtextArray1M.AssertModel(models[11],_testData[27], false);StringtextArray1M.AssertModel(models[12],_testData[28], false);StringtextArray1M.AssertModel(models[13],_testData[29], false);
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
                var models = ((IStringArraytextArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionSelectModelBatch(connection, 45, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
StringtextArray1M.AssertModel(models[0],_testData[8], false);StringtextArray1M.AssertModel(models[1],_testData[9], false);StringtextArray1M.AssertModel(models[2],_testData[10], false);StringtextArray1M.AssertModel(models[3],_testData[11], false);StringtextArray1M.AssertModel(models[4],_testData[12], false);StringtextArray1M.AssertModel(models[5],_testData[13], false);StringtextArray1M.AssertModel(models[6],_testData[14], false);StringtextArray1M.AssertModel(models[7],_testData[15], false);StringtextArray1M.AssertModel(models[8],_testData[16], false);StringtextArray1M.AssertModel(models[9],_testData[17], false);StringtextArray1M.AssertModel(models[10],_testData[18], false);StringtextArray1M.AssertModel(models[11],_testData[19], false);StringtextArray1M.AssertModel(models[12],_testData[20], false);StringtextArray1M.AssertModel(models[13],_testData[21], false);StringtextArray1M.AssertModel(models[14],_testData[22], false);StringtextArray1M.AssertModel(models[15],_testData[23], false);StringtextArray1M.AssertModel(models[16],_testData[24], false);StringtextArray1M.AssertModel(models[17],_testData[25], false);StringtextArray1M.AssertModel(models[18],_testData[26], false);StringtextArray1M.AssertModel(models[19],_testData[27], false);StringtextArray1M.AssertModel(models[20],_testData[28], false);StringtextArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
StringtextArray1M.AssertModel(models[0],_testData[23], false);StringtextArray1M.AssertModel(models[1],_testData[24], false);StringtextArray1M.AssertModel(models[2],_testData[25], false);StringtextArray1M.AssertModel(models[3],_testData[26], false);StringtextArray1M.AssertModel(models[4],_testData[27], false);StringtextArray1M.AssertModel(models[5],_testData[28], false);StringtextArray1M.AssertModel(models[6],_testData[29], false);
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
                await using var cmd = await ((IStringArraytextArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringArraytextArray)this).SetDbConnectionSelectModelParametrs(cmd, 79);
                var models = await ((IStringArraytextArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
StringtextArray1M.AssertModel(models[0],_testData[13], false);StringtextArray1M.AssertModel(models[1],_testData[14], false);StringtextArray1M.AssertModel(models[2],_testData[15], false);StringtextArray1M.AssertModel(models[3],_testData[16], false);StringtextArray1M.AssertModel(models[4],_testData[17], false);StringtextArray1M.AssertModel(models[5],_testData[18], false);StringtextArray1M.AssertModel(models[6],_testData[19], false);StringtextArray1M.AssertModel(models[7],_testData[20], false);StringtextArray1M.AssertModel(models[8],_testData[21], false);StringtextArray1M.AssertModel(models[9],_testData[22], false);StringtextArray1M.AssertModel(models[10],_testData[23], false);StringtextArray1M.AssertModel(models[11],_testData[24], false);StringtextArray1M.AssertModel(models[12],_testData[25], false);StringtextArray1M.AssertModel(models[13],_testData[26], false);StringtextArray1M.AssertModel(models[14],_testData[27], false);StringtextArray1M.AssertModel(models[15],_testData[28], false);StringtextArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringArraytextArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringArraytextArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models =  ((IStringArraytextArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
StringtextArray1M.AssertModel(models[0],_testData[21], false);StringtextArray1M.AssertModel(models[1],_testData[22], false);StringtextArray1M.AssertModel(models[2],_testData[23], false);StringtextArray1M.AssertModel(models[3],_testData[24], false);StringtextArray1M.AssertModel(models[4],_testData[25], false);StringtextArray1M.AssertModel(models[5],_testData[26], false);StringtextArray1M.AssertModel(models[6],_testData[27], false);StringtextArray1M.AssertModel(models[7],_testData[28], false);StringtextArray1M.AssertModel(models[8],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(StringtextArray1MI)],
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
            asPartInterface: typeof(IStringArraytextArray))]
        private void ImportModelInnerConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_stringtextarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(StringtextArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<StringtextArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IStringArraytextArray)this).ImportModelInner(connection, importCollection);
                var models = ((IStringArraytextArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IStringArraytextArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IStringArraytextArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtextarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(StringtextArray1M)],
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
            asPartInterface: typeof(IStringArraytextArray))]
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
FROM public.binary_stringtextarray1m m
LEFT JOIN public.binary_stringtextarray1mi mi ON mi.id = m.stringtextarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(StringtextArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<StringtextArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IStringArraytextArray)this).ImportModel(connection, importCollection);
                var models = ((IStringArraytextArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                StringtextArray1M.AssertModel(models[0],_testData[0], false);
                StringtextArray1M.AssertModel(models[1],_testData[1], false);
                StringtextArray1M.AssertModel(models[2],_testData[2], false);
                StringtextArray1M.AssertModel(models[3],_testData[3], false);
                StringtextArray1M.AssertModel(models[4],_testData[4], false);
                StringtextArray1M.AssertModel(models[5],_testData[5], false);
                StringtextArray1M.AssertModel(models[6],_testData[6], false);
                StringtextArray1M.AssertModel(models[7],_testData[7], false);
                StringtextArray1M.AssertModel(models[8],_testData[8], false);
                StringtextArray1M.AssertModel(models[9],_testData[9], false);
                StringtextArray1M.AssertModel(models[10],_testData[10], false);
                StringtextArray1M.AssertModel(models[11],_testData[11], false);
                StringtextArray1M.AssertModel(models[12],_testData[12], false);
                StringtextArray1M.AssertModel(models[13],_testData[13], false);
                StringtextArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IStringArraytextArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IStringArraytextArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                StringtextArray1M.AssertModel(models[0],_testData[0], false);
                StringtextArray1M.AssertModel(models[1],_testData[1], false);
                StringtextArray1M.AssertModel(models[2],_testData[2], false);
                StringtextArray1M.AssertModel(models[3],_testData[3], false);
                StringtextArray1M.AssertModel(models[4],_testData[4], false);
                StringtextArray1M.AssertModel(models[5],_testData[5], false);
                StringtextArray1M.AssertModel(models[6],_testData[6], false);
                StringtextArray1M.AssertModel(models[7],_testData[7], false);
                StringtextArray1M.AssertModel(models[8],_testData[8], false);
                StringtextArray1M.AssertModel(models[9],_testData[9], false);
                StringtextArray1M.AssertModel(models[10],_testData[10], false);
                StringtextArray1M.AssertModel(models[11],_testData[11], false);
                StringtextArray1M.AssertModel(models[12],_testData[12], false);
                StringtextArray1M.AssertModel(models[13],_testData[13], false);
                StringtextArray1M.AssertModel(models[14],_testData[14], false);
                StringtextArray1M.AssertModel(models[15],_testData[15], false);
                StringtextArray1M.AssertModel(models[16],_testData[16], false);
                StringtextArray1M.AssertModel(models[17],_testData[17], false);
                StringtextArray1M.AssertModel(models[18],_testData[18], false);
                StringtextArray1M.AssertModel(models[19],_testData[19], false);
                StringtextArray1M.AssertModel(models[20],_testData[20], false);
                StringtextArray1M.AssertModel(models[21],_testData[21], false);
                StringtextArray1M.AssertModel(models[22],_testData[22], false);
                StringtextArray1M.AssertModel(models[23],_testData[23], false);
                StringtextArray1M.AssertModel(models[24],_testData[24], false);
                StringtextArray1M.AssertModel(models[25],_testData[25], false);
                StringtextArray1M.AssertModel(models[26],_testData[26], false);
                StringtextArray1M.AssertModel(models[27],_testData[27], false);
                StringtextArray1M.AssertModel(models[28],_testData[28], false);
                StringtextArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtextarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(StringtextArray1M)],
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
            asPartInterface: typeof(IStringArraytextArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringArraytextArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringArraytextArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(StringtextArray1MI)],
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
            asPartInterface: typeof(IStringArraytextArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringArraytextArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringArraytextArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

