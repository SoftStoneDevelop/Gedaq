

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
    Id = 4,
    Value = 
new System.String[4]
{
"tognoflxddllbidkkurrfhcidv",
"do",
"jyieqavfjfoicqkkistwcrsiybed",
"ponfuekhm",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 12,
    Value = 
new System.String[4]
{
"abshsslknwckc",
"guyr",
"fdxgqecsegsts",
"jatarhqdwrgfmi",
},
    ModelInner = new StringtextArray1MI
{
    Id = 1,
    Value = 
new System.String[3]
{
"yoagwayqnpaboqwxmppmicjoa",
"wqdtpsembqgluingpp",
"qwhvgabpxebuyxypxohlbqeikchpr",
},
    NullableValue = 
new System.String[4]
{
"onecmcpwacqseljifkapcnarksiwp",
"evctxdxmn",
"kqkrwis",
"gpmytqalgxnnsqkdbsg",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 21,
    Value = 
new System.String[3]
{
"mdqmnuvtgmog",
"pjempotoktxtsmawibtllkelat",
"jlfsrcjvcjrxhicgppmuudqfcx",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 26,
    Value = 
new System.String[3]
{
"cctqxj",
"ke",
"hjurngkjdhg",
},
    ModelInner = new StringtextArray1MI
{
    Id = 7,
    Value = 
new System.String[3]
{
"v",
"ctlcpigtchdgxsypytkablhg",
"vebvqtnathtkppjyiumfquklbjm",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 29,
    Value = 
new System.String[4]
{
"ksfujlvghmctxnlkxgi",
"cwvhfjfacsc",
"gxeiabcagqlfedwhib",
"xarprdljq",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"tcsxop",
"ewgwprpeneogqrkjtdq",
"ofgtown",
},
},
            new StringtextArray1M
{
    Id = 37,
    Value = 
new System.String[4]
{
"dpgixpai",
"cmdryjeufgekcjl",
"hjboeivbpvyscenlfv",
"nydgthsjovprtfedacxfaltl",
},
    ModelInner = new StringtextArray1MI
{
    Id = 9,
    Value = 
new System.String[4]
{
"pmtwsybrsomveukaylfrmqtri",
"tmjwbkjwuqkwyanvrbakygsjc",
"cbtwouiqkdfmibkwxj",
"ydhkigqmnpskf",
},
    NullableValue = 
new System.String[4]
{
"jdvqiivnrmibnehxw",
"",
"fp",
"xmcsxotcenqowoqlnjqxpafa",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 38,
    Value = 
new System.String[3]
{
"jrt",
"epsyynrcthrdkutymipxasvgpixws",
"snsbefbxgkybwprurugbdox",
},
    ModelInner = null,
    NullableValue = 
new System.String[3]
{
"yapthcbnxhrgda",
"lfaswdhytlvjqqosagvkcsotrntmu",
"dxskfrcmaqlhmbljorydcnrfpd",
},
},
            new StringtextArray1M
{
    Id = 43,
    Value = 
new System.String[3]
{
"ydqyqnppuvbqed",
"jeubdchdeaick",
"ptiiktig",
},
    ModelInner = new StringtextArray1MI
{
    Id = 18,
    Value = 
new System.String[4]
{
"jpicg",
"yfqlmsjtbmipewoqlsg",
"udrwj",
"jbcvbmupxyecrslgbnn",
},
    NullableValue = 
new System.String[3]
{
"b",
"",
"lsbaofsivbgefjucdopxtvwjluhdo",
},
},
    NullableValue = 
new System.String[3]
{
"lwoiotprqwrmmkyaqamqygocgskel",
"vf",
"vge",
},
},
            new StringtextArray1M
{
    Id = 50,
    Value = 
new System.String[4]
{
"csmtqhicyl",
"joiysvqycsbk",
"tohbemmkvclruth",
"ed",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"magvuygvgmorfkr",
"uekfmhhdllxvyainu",
"vukonjmxluecoplrtj",
"dxfokv",
},
},
            new StringtextArray1M
{
    Id = 56,
    Value = 
new System.String[3]
{
"feijlrrfnchdnkuhoej",
"sns",
"ljtoiqvclyksdyissmxshlen",
},
    ModelInner = new StringtextArray1MI
{
    Id = 21,
    Value = 
new System.String[4]
{
"cyvpsnmdparkqqobsuww",
"tcidrilkx",
"qysmouqbsbyjsapesd",
"d",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 57,
    Value = 
new System.String[4]
{
"hauqdyl",
"ec",
"d",
"tjjdgxyw",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"nmanaipsorfbnttvnkknvgiyjhp",
"clncpy",
"xpxi",
"xweryty",
},
},
            new StringtextArray1M
{
    Id = 63,
    Value = 
new System.String[3]
{
"dmtqvybxtmphwslbofckearxh",
"",
"xvbxeqafikejbir",
},
    ModelInner = new StringtextArray1MI
{
    Id = 29,
    Value = 
new System.String[4]
{
"mjn",
"mmdbbdwgprjsm",
"bhv",
"mhumdvqaejwlbbywmxhpvbtpkke",
},
    NullableValue = 
new System.String[4]
{
"skwahghhybqxkj",
"fpbykngfjqkmvadcmmyxwijivm",
"obuiiucotkedqcivxldusu",
"ofxybwlocdhlxqepymxudpvcimhb",
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
"dypjrroptraswuoqaqoyndywm",
"vcoptxotcxrmminyxdoadvpgrnlf",
"qjnjrrpnlduhmjcgkfrqfjipi",
"",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"",
"vcwhlmdm",
"sewga",
"",
},
},
            new StringtextArray1M
{
    Id = 70,
    Value = 
new System.String[3]
{
"pteymtjinguhyke",
"nngcfmujwybkonuaavepquslj",
"rhuajqctu",
},
    ModelInner = new StringtextArray1MI
{
    Id = 31,
    Value = 
new System.String[3]
{
"tckonveslgfu",
"ouxumclrissl",
"xacqkyxgpikmngh",
},
    NullableValue = 
new System.String[4]
{
"tiauseicblrqlai",
"",
"doipmapg",
"kruaxuhmv",
},
},
    NullableValue = 
new System.String[3]
{
"wykfijoxtebo",
"b",
"vgyptnaemjsliepbniaigixnbb",
},
},
            new StringtextArray1M
{
    Id = 71,
    Value = 
new System.String[4]
{
"ycxoglngpwcmolk",
"whehh",
"drbxocivnuqyoqqphpsm",
"cypvfpsimyoryaucnrkfxaasafxla",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 74,
    Value = 
new System.String[3]
{
"gjcqbvq",
"obfw",
"faeeifdlefuojuikhulfkjtrpaxff",
},
    ModelInner = new StringtextArray1MI
{
    Id = 38,
    Value = 
new System.String[4]
{
"dgweke",
"dballiirgukiu",
"mcyodevbdmtpgeavricpqgkffrc",
"gdttkkvbodhfrwcyyrtmcje",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 83,
    Value = 
new System.String[3]
{
"q",
"kptnlrqf",
"useojvwmceyforoxxgcu",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 88,
    Value = 
new System.String[3]
{
"gkbrpngujjkywynbd",
"xbdbnnxxcvlxvscsecygfblujkbb",
"jdtuyfccnsjcdr",
},
    ModelInner = new StringtextArray1MI
{
    Id = 43,
    Value = 
new System.String[3]
{
"adxeankxshwnycretanrahxj",
"pbdaitrsuobcojggseumnphuuv",
"negxcmlmjlo",
},
    NullableValue = 
new System.String[3]
{
"hxkecmlijeyctoktlsxuyfspali",
"",
"osjbtcpkramcpfsdmjtdvwsxql",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 89,
    Value = 
new System.String[4]
{
"vxwnbyr",
"hldgcxflpvtsrtnkkbfjqywivrgpp",
"f",
"qdwkfdqcuvtx",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"oerypbinjrknmecyi",
"uvnsdfieotxdvuyttgffs",
"rwykaxtexywsnmruhtfoosoo",
"",
},
},
            new StringtextArray1M
{
    Id = 94,
    Value = 
new System.String[3]
{
"",
"mckk",
"ydmskvndhmyjgruthcheypsg",
},
    ModelInner = new StringtextArray1MI
{
    Id = 50,
    Value = 
new System.String[3]
{
"vgbkqecjn",
"mfk",
"lotvp",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 99,
    Value = 
new System.String[4]
{
"enaykurvbfavjxpvknyei",
"yj",
"owyinecakedfnhrexirlkxasvbo",
"bacunklhqyhvrngmocxdt",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"mcmkjrectpwuv",
"ohmdqqlcstgcqp",
"mbngijthtjjwvikvfkrigiv",
"epfuvehckltumdsyvwprbymdh",
},
},
            new StringtextArray1M
{
    Id = 103,
    Value = 
new System.String[3]
{
"iunkpkqxij",
"lyexpjqijpkhsdkvyehfoppwfc",
"ygfigwlrp",
},
    ModelInner = new StringtextArray1MI
{
    Id = 53,
    Value = 
new System.String[4]
{
"stxhawjdwusvrrorvbkfeft",
"snbrlbdumvtsg",
"sulrgocruasrbe",
"styr",
},
    NullableValue = 
new System.String[4]
{
"gtyjqcypnxooembfeudmkqnxvephy",
"dmn",
"aeolcumxpxyxlcanwxrhmrt",
"mmsuuksmlpdejfrmpulmuogajc",
},
},
    NullableValue = 
new System.String[4]
{
"deqm",
"och",
"nijrxp",
"uxrohcqjbqwhhuuk",
},
},
            new StringtextArray1M
{
    Id = 110,
    Value = 
new System.String[3]
{
"vunywgnqubxgyjiqfvyaol",
"hjkgnbwrluswodnyxvmb",
"pbivxkbtobwfup",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"swtnosfdkeecjbpubqanhoo",
"qaqujkdmngdggd",
"ibnhsedbclsyftvxmmsawawp",
"sftudeqkpkcdtrrpe",
},
},
            new StringtextArray1M
{
    Id = 116,
    Value = 
new System.String[4]
{
"wlnwuarqmkny",
"chrxegjvllgdwpq",
"lriugtiirbkbxqnxnrjbnqgl",
"pemimvfphbms",
},
    ModelInner = new StringtextArray1MI
{
    Id = 55,
    Value = 
new System.String[4]
{
"cvkqe",
"icymilqperqtspwceaoummtyto",
"lrmyjxke",
"cpwxtmehxoaegxgj",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 120,
    Value = 
new System.String[3]
{
"rtjkwgsstonhmxv",
"cjycwwqyowodmhtwnxafxvo",
"lsqdnhblxugekoayxpfclcepljqr",
},
    ModelInner = null,
    NullableValue = 
new System.String[4]
{
"vefaflvdtkhmvksudsnuyqemj",
"ghwttnlvdwqr",
"luadgxt",
"kyyjtxvyynsqlpcqqm",
},
},
            new StringtextArray1M
{
    Id = 124,
    Value = 
new System.String[4]
{
"kjoddqlygajcueprlgomiw",
"swolcknmirymbrwgtw",
"nqprslwtwhuhhkwcjtmewsvpr",
"ludkfvu",
},
    ModelInner = new StringtextArray1MI
{
    Id = 62,
    Value = 
new System.String[4]
{
"iclugoidwnolpkr",
"omudeibjxmsmsaxdserbyoifrg",
"kmtvnosaygkwufru",
"yfpmqchoihoycwcuncolwme",
},
    NullableValue = 
new System.String[3]
{
"xwxrvqrtsfmwnaqaxobfdnrmf",
"tvnetuvxxmpysruovfttdoqhlddb",
"aqjgwrfmwqymowxvyvdqejbibt",
},
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 127,
    Value = 
new System.String[4]
{
"he",
"ujifrthpmjkfufiwedeogdyp",
"dmypqfusry",
"pmyqwwsnokxqgiirdyvsldtyffeg",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 129,
    Value = 
new System.String[3]
{
"fp",
"ejfqibcaqh",
"l",
},
    ModelInner = new StringtextArray1MI
{
    Id = 65,
    Value = 
new System.String[4]
{
"kiubyyicaoohrgvvrxut",
"wlejodjapuxrnkk",
"apfdsaqtvaaxfnaobwldc",
"lcpsyufnscewtamplq",
},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 133,
    Value = 
new System.String[3]
{
"bywjbcmcmvqkmou",
"gqhptltlxtchvcctqgt",
"bvnkkdeopfgorubjxvyi",
},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray1M
{
    Id = 142,
    Value = 
new System.String[3]
{
"ahhqakgnnjglhcalrbqolct",
"eylvreetwmcqvfbnvywusnfofs",
"ugccprxabmyw",
},
    ModelInner = new StringtextArray1MI
{
    Id = 68,
    Value = 
new System.String[4]
{
"renkcfpalpaywlgeubbapbpbedw",
"yfafioym",
"dtieuggeobdwraxiciva",
"uksggwxhphadwfruxwryjaftm",
},
    NullableValue = null,
},
    NullableValue = 
new System.String[3]
{
"lymxpsqddcejbwptdisfi",
"qecbhms",
"msmcevwgpafjxnrmhyduusvlcl",
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[3]
{
"tcsxop",
"ewgwprpeneogqrkjtdq",
"ofgtown",
}));
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

                    nullable = await ((IStringArraytextArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[3]
{
"yapthcbnxhrgda",
"lfaswdhytlvjqqosagvkcsotrntmu",
"dxskfrcmaqlhmbljorydcnrfpd",
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

                    nullable = await ((IStringArraytextArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[3]
{
"lwoiotprqwrmmkyaqamqygocgskel",
"vf",
"vge",
}));
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
new System.String[4]
{
"magvuygvgmorfkr",
"uekfmhhdllxvyainu",
"vukonjmxluecoplrtj",
"dxfokv",
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.String[4]
{
"nmanaipsorfbnttvnkknvgiyjhp",
"clncpy",
"xpxi",
"xweryty",
}));
                nullable = await ((IStringArraytextArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: null,
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
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
            asPartInterface: typeof(IStringArraytextArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.stringtextarray1m m
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[27],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.stringtextarray1m m
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
FROM public.stringtextarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                 ((IStringArraytextArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                 ((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(models[2],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(models[3],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(models[4],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(models[5],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(models[6],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(models[7],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(models[8],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(models[9],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(models[10],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(models[11],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(models[12],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(models[13],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(models[14],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(models[15],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[16],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(models[2],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(models[3],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(models[4],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(models[5],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(models[6],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(models[7],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(models[8],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(models[9],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(models[10],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                 ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IStringArraytextArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    StringtextArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        StringtextArray1M.AssertModel(models[0],_testData[28], false);
                        StringtextArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        StringtextArray1M.AssertModel(models[0],_testData[2], false);
                        StringtextArray1M.AssertModel(models[1],_testData[3], false);
                        StringtextArray1M.AssertModel(models[2],_testData[4], false);
                        StringtextArray1M.AssertModel(models[3],_testData[5], false);
                        StringtextArray1M.AssertModel(models[4],_testData[6], false);
                        StringtextArray1M.AssertModel(models[5],_testData[7], false);
                        StringtextArray1M.AssertModel(models[6],_testData[8], false);
                        StringtextArray1M.AssertModel(models[7],_testData[9], false);
                        StringtextArray1M.AssertModel(models[8],_testData[10], false);
                        StringtextArray1M.AssertModel(models[9],_testData[11], false);
                        StringtextArray1M.AssertModel(models[10],_testData[12], false);
                        StringtextArray1M.AssertModel(models[11],_testData[13], false);
                        StringtextArray1M.AssertModel(models[12],_testData[14], false);
                        StringtextArray1M.AssertModel(models[13],_testData[15], false);
                        StringtextArray1M.AssertModel(models[14],_testData[16], false);
                        StringtextArray1M.AssertModel(models[15],_testData[17], false);
                        StringtextArray1M.AssertModel(models[16],_testData[18], false);
                        StringtextArray1M.AssertModel(models[17],_testData[19], false);
                        StringtextArray1M.AssertModel(models[18],_testData[20], false);
                        StringtextArray1M.AssertModel(models[19],_testData[21], false);
                        StringtextArray1M.AssertModel(models[20],_testData[22], false);
                        StringtextArray1M.AssertModel(models[21],_testData[23], false);
                        StringtextArray1M.AssertModel(models[22],_testData[24], false);
                        StringtextArray1M.AssertModel(models[23],_testData[25], false);
                        StringtextArray1M.AssertModel(models[24],_testData[26], false);
                        StringtextArray1M.AssertModel(models[25],_testData[27], false);
                        StringtextArray1M.AssertModel(models[26],_testData[28], false);
                        StringtextArray1M.AssertModel(models[27],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        StringtextArray1M.AssertModel(models[0],_testData[24], false);
                        StringtextArray1M.AssertModel(models[1],_testData[25], false);
                        StringtextArray1M.AssertModel(models[2],_testData[26], false);
                        StringtextArray1M.AssertModel(models[3],_testData[27], false);
                        StringtextArray1M.AssertModel(models[4],_testData[28], false);
                        StringtextArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        StringtextArray1M.AssertModel(models[0],_testData[10], false);
                        StringtextArray1M.AssertModel(models[1],_testData[11], false);
                        StringtextArray1M.AssertModel(models[2],_testData[12], false);
                        StringtextArray1M.AssertModel(models[3],_testData[13], false);
                        StringtextArray1M.AssertModel(models[4],_testData[14], false);
                        StringtextArray1M.AssertModel(models[5],_testData[15], false);
                        StringtextArray1M.AssertModel(models[6],_testData[16], false);
                        StringtextArray1M.AssertModel(models[7],_testData[17], false);
                        StringtextArray1M.AssertModel(models[8],_testData[18], false);
                        StringtextArray1M.AssertModel(models[9],_testData[19], false);
                        StringtextArray1M.AssertModel(models[10],_testData[20], false);
                        StringtextArray1M.AssertModel(models[11],_testData[21], false);
                        StringtextArray1M.AssertModel(models[12],_testData[22], false);
                        StringtextArray1M.AssertModel(models[13],_testData[23], false);
                        StringtextArray1M.AssertModel(models[14],_testData[24], false);
                        StringtextArray1M.AssertModel(models[15],_testData[25], false);
                        StringtextArray1M.AssertModel(models[16],_testData[26], false);
                        StringtextArray1M.AssertModel(models[17],_testData[27], false);
                        StringtextArray1M.AssertModel(models[18],_testData[28], false);
                        StringtextArray1M.AssertModel(models[19],_testData[29], false);
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
            overrideAliasPrefixs: ["item1", "item2"],
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringArraytextArray)),
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
            asPartInterface: typeof(IStringArraytextArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 88, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 56, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[20],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var query2 = @"
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                 ((IStringArraytextArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 29, query1, 124, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var firstItems2 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                 ((IStringArraytextArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 38, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[7], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[8], false);
                        FlatStringtextArray1M.AssertModel(models[2],_testData[9], false);
                        FlatStringtextArray1M.AssertModel(models[3],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(models[4],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(models[5],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(models[6],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(models[7],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(models[8],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(models[9],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(models[10],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(models[11],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(models[12],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(models[13],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(models[14],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(models[15],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(models[16],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(models[17],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(models[18],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(models[19],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(models[20],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(models[21],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(models[2],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(models[3],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(models[4],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(models[5],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(models[6],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(models[7],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(models[8],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(models[9],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(models[10],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(models[11],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(models[12],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(models[13],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[14],_testData[29], false);
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                await ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 50, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(models[2],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(models[3],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(models[4],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(models[5],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(models[6],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatStringtextArray1M.AssertModel(models[0],_testData[9], false);
                        FlatStringtextArray1M.AssertModel(models[1],_testData[10], false);
                        FlatStringtextArray1M.AssertModel(models[2],_testData[11], false);
                        FlatStringtextArray1M.AssertModel(models[3],_testData[12], false);
                        FlatStringtextArray1M.AssertModel(models[4],_testData[13], false);
                        FlatStringtextArray1M.AssertModel(models[5],_testData[14], false);
                        FlatStringtextArray1M.AssertModel(models[6],_testData[15], false);
                        FlatStringtextArray1M.AssertModel(models[7],_testData[16], false);
                        FlatStringtextArray1M.AssertModel(models[8],_testData[17], false);
                        FlatStringtextArray1M.AssertModel(models[9],_testData[18], false);
                        FlatStringtextArray1M.AssertModel(models[10],_testData[19], false);
                        FlatStringtextArray1M.AssertModel(models[11],_testData[20], false);
                        FlatStringtextArray1M.AssertModel(models[12],_testData[21], false);
                        FlatStringtextArray1M.AssertModel(models[13],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(models[14],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(models[15],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(models[16],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(models[17],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(models[18],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(models[19],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(models[20],_testData[29], false);
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
                var firstItems1 = new List<FlatStringtextArray1M>();
                var secondItems1 = new List<FlatStringtextArray1M>();
                var secondItems2 = new List<FlatStringtextArray1M>();
                 ((IStringArraytextArray)this).DbConnectionDynQuerySelectModelBatch(connection, 103, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatStringtextArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatStringtextArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatStringtextArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatStringtextArray1M.AssertModel(secondItems2[7],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringArraytextArray)this).DbConnectionSTSelectModelBatchAsync(connection, 94, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        StringtextArray1M.AssertModel(models[0],_testData[20], false);
                        StringtextArray1M.AssertModel(models[1],_testData[21], false);
                        StringtextArray1M.AssertModel(models[2],_testData[22], false);
                        StringtextArray1M.AssertModel(models[3],_testData[23], false);
                        StringtextArray1M.AssertModel(models[4],_testData[24], false);
                        StringtextArray1M.AssertModel(models[5],_testData[25], false);
                        StringtextArray1M.AssertModel(models[6],_testData[26], false);
                        StringtextArray1M.AssertModel(models[7],_testData[27], false);
                        StringtextArray1M.AssertModel(models[8],_testData[28], false);
                        StringtextArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        StringtextArray1M.AssertModel(models[0],_testData[20], false);
                        StringtextArray1M.AssertModel(models[1],_testData[21], false);
                        StringtextArray1M.AssertModel(models[2],_testData[22], false);
                        StringtextArray1M.AssertModel(models[3],_testData[23], false);
                        StringtextArray1M.AssertModel(models[4],_testData[24], false);
                        StringtextArray1M.AssertModel(models[5],_testData[25], false);
                        StringtextArray1M.AssertModel(models[6],_testData[26], false);
                        StringtextArray1M.AssertModel(models[7],_testData[27], false);
                        StringtextArray1M.AssertModel(models[8],_testData[28], false);
                        StringtextArray1M.AssertModel(models[9],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringArraytextArray)this).DbConnectionSTSelectModelBatch(connection, 99, 43))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        StringtextArray1M.AssertModel(models[0],_testData[21], false);
                        StringtextArray1M.AssertModel(models[1],_testData[22], false);
                        StringtextArray1M.AssertModel(models[2],_testData[23], false);
                        StringtextArray1M.AssertModel(models[3],_testData[24], false);
                        StringtextArray1M.AssertModel(models[4],_testData[25], false);
                        StringtextArray1M.AssertModel(models[5],_testData[26], false);
                        StringtextArray1M.AssertModel(models[6],_testData[27], false);
                        StringtextArray1M.AssertModel(models[7],_testData[28], false);
                        StringtextArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        StringtextArray1M.AssertModel(models[0],_testData[8], false);
                        StringtextArray1M.AssertModel(models[1],_testData[9], false);
                        StringtextArray1M.AssertModel(models[2],_testData[10], false);
                        StringtextArray1M.AssertModel(models[3],_testData[11], false);
                        StringtextArray1M.AssertModel(models[4],_testData[12], false);
                        StringtextArray1M.AssertModel(models[5],_testData[13], false);
                        StringtextArray1M.AssertModel(models[6],_testData[14], false);
                        StringtextArray1M.AssertModel(models[7],_testData[15], false);
                        StringtextArray1M.AssertModel(models[8],_testData[16], false);
                        StringtextArray1M.AssertModel(models[9],_testData[17], false);
                        StringtextArray1M.AssertModel(models[10],_testData[18], false);
                        StringtextArray1M.AssertModel(models[11],_testData[19], false);
                        StringtextArray1M.AssertModel(models[12],_testData[20], false);
                        StringtextArray1M.AssertModel(models[13],_testData[21], false);
                        StringtextArray1M.AssertModel(models[14],_testData[22], false);
                        StringtextArray1M.AssertModel(models[15],_testData[23], false);
                        StringtextArray1M.AssertModel(models[16],_testData[24], false);
                        StringtextArray1M.AssertModel(models[17],_testData[25], false);
                        StringtextArray1M.AssertModel(models[18],_testData[26], false);
                        StringtextArray1M.AssertModel(models[19],_testData[27], false);
                        StringtextArray1M.AssertModel(models[20],_testData[28], false);
                        StringtextArray1M.AssertModel(models[21],_testData[29], false);
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
                ((IStringArraytextArray)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models = await ((IStringArraytextArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
StringtextArray1M.AssertModel(models[0],_testData[3], false);StringtextArray1M.AssertModel(models[1],_testData[4], false);StringtextArray1M.AssertModel(models[2],_testData[5], false);StringtextArray1M.AssertModel(models[3],_testData[6], false);StringtextArray1M.AssertModel(models[4],_testData[7], false);StringtextArray1M.AssertModel(models[5],_testData[8], false);StringtextArray1M.AssertModel(models[6],_testData[9], false);StringtextArray1M.AssertModel(models[7],_testData[10], false);StringtextArray1M.AssertModel(models[8],_testData[11], false);StringtextArray1M.AssertModel(models[9],_testData[12], false);StringtextArray1M.AssertModel(models[10],_testData[13], false);StringtextArray1M.AssertModel(models[11],_testData[14], false);StringtextArray1M.AssertModel(models[12],_testData[15], false);StringtextArray1M.AssertModel(models[13],_testData[16], false);StringtextArray1M.AssertModel(models[14],_testData[17], false);StringtextArray1M.AssertModel(models[15],_testData[18], false);StringtextArray1M.AssertModel(models[16],_testData[19], false);StringtextArray1M.AssertModel(models[17],_testData[20], false);StringtextArray1M.AssertModel(models[18],_testData[21], false);StringtextArray1M.AssertModel(models[19],_testData[22], false);StringtextArray1M.AssertModel(models[20],_testData[23], false);StringtextArray1M.AssertModel(models[21],_testData[24], false);StringtextArray1M.AssertModel(models[22],_testData[25], false);StringtextArray1M.AssertModel(models[23],_testData[26], false);StringtextArray1M.AssertModel(models[24],_testData[27], false);StringtextArray1M.AssertModel(models[25],_testData[28], false);StringtextArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringArraytextArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringArraytextArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((IStringArraytextArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
StringtextArray1M.AssertModel(models[0],_testData[6], false);StringtextArray1M.AssertModel(models[1],_testData[7], false);StringtextArray1M.AssertModel(models[2],_testData[8], false);StringtextArray1M.AssertModel(models[3],_testData[9], false);StringtextArray1M.AssertModel(models[4],_testData[10], false);StringtextArray1M.AssertModel(models[5],_testData[11], false);StringtextArray1M.AssertModel(models[6],_testData[12], false);StringtextArray1M.AssertModel(models[7],_testData[13], false);StringtextArray1M.AssertModel(models[8],_testData[14], false);StringtextArray1M.AssertModel(models[9],_testData[15], false);StringtextArray1M.AssertModel(models[10],_testData[16], false);StringtextArray1M.AssertModel(models[11],_testData[17], false);StringtextArray1M.AssertModel(models[12],_testData[18], false);StringtextArray1M.AssertModel(models[13],_testData[19], false);StringtextArray1M.AssertModel(models[14],_testData[20], false);StringtextArray1M.AssertModel(models[15],_testData[21], false);StringtextArray1M.AssertModel(models[16],_testData[22], false);StringtextArray1M.AssertModel(models[17],_testData[23], false);StringtextArray1M.AssertModel(models[18],_testData[24], false);StringtextArray1M.AssertModel(models[19],_testData[25], false);StringtextArray1M.AssertModel(models[20],_testData[26], false);StringtextArray1M.AssertModel(models[21],_testData[27], false);StringtextArray1M.AssertModel(models[22],_testData[28], false);StringtextArray1M.AssertModel(models[23],_testData[29], false);
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

