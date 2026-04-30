

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"wxrvvevssalcqtym",

"shnbsfpkiqiovmmrra",

"rlwbeuthuowjpjuh",

"lddieqlt",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"bqycktqxohbpjwsjmbrjnrrjm",

"cptvomjwchwbdsapummxpr",

"fhuutkjfmnlhsrr",

},
    ModelInner = new StringtextArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"c",

"hatvrxuum",

"ncbbluvctlvdbbkir",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"joevoc",

"ysqupmwgfpx",

"qydmtbyotiaulmsldwvcbwv",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"symneexuoqrcdglpsqixargbexv",

"hxmuhfyuleddmneouyhhqnayj",

"fyfvwqwbtaqkji",

"gkcaiwtkxmd",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"whnjegjnopmjhqg",

"jdqrt",

"ccgiuyinhk",

},
    ModelInner = new StringtextArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"nugqaxpmekqbgu",

"lqisdlxtmlkimjdvunjpxktondwm",

"kvduy",

"",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"aixrqnlynrinqgpj",

"vjnrlirscjojayjkvfgiy",

},
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"abjuhevjy",

"vudnaiuwbnshpgahcyqlapivdk",

"qpori",

},
},
            new StringtextArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"fgvwkmfmlco",

"vt",

"xwaskelovpyont",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"kyuxala",

"hximbcfpaipc",

"irgxjpnfcxxvse",

"qdoawftd",

},
},
            new StringtextArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vwjnxxdecyrcpfbptcfldu",

"ssmnhuuylacdccaky",

"hqjanpphpchqj",

"tngolmcqlbrxoomr",

},
    ModelInner = new StringtextArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"tmrg",

"fmkygxxmtros",

"pbmkkhfcnles",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"stakehqfnxkxltnfa",

"wwb",

"bybuaobjtii",

"vvd",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"usdequomy",

"dus",

"cduoskwxgnlimdmdjbisgkigtpcyh",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"wpfyjxmctstqjdshucfqjlmombq",

"tblcbgingvwgkbmyxh",

"dmxetrgyxjtdesornqbscytnvfga",

"ifwcoxrfurq",

},
    ModelInner = new StringtextArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"rcigpxdr",

"eridfjrpbwe",

"upgiadsmstdxtncnejliqh",

"jw",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"tqijky",

"qhiixvmkvwrqigymkyfhqnrmfghc",

"grapmefbiwyvtlu",

},
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"sbayycgitxhvrofijwy",

"sehtnenxijve",

"aj",

"lkhksmervltbimtnpyjvy",

},
},
            new StringtextArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"flxshjxjwdyqushcwtaga",

"flhxfdjteqcjhavk",

"dapcfdgayqetx",

"bwouecreg",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"lxmfuhuj",

"arjmuqky",

"gccoatkffgenggxcqnbsnuophyn",

},
    ModelInner = new StringtextArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"oxedabqjknxwkcstlni",

"xrvaincgqmcoetouipldeehfjcw",

"siftwlllbsjsrctd",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"emxwagmiodhdmw",

"abbxmhmqfsu",

"flisoxcyodmxyhh",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vbhmxqwtpupdsjqkqqtuu",

"mjxofsgsseaokecaqlqsyxfjt",

"pycapugpvapusvyypeebydyf",

},
},
            new StringtextArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yewvqodcmaleerh",

"pclsf",

"",

"oab",

},
    ModelInner = new StringtextArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vkhgvudeaglhmiea",

"qj",

"xmhibspxlfqdjp",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"sgrgfgcrke",

"gqsxmcsjynjkbu",

"",

"ihyeemfhyyekdhstknlqa",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"fcjjf",

"elrm",

"rwvitggffilntqtevcwebeggnyir",

},
    ModelInner = new StringtextArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mkhjhldsrehgkdg",

"yan",

"yahsvwjqvm",

"qx",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ddioenspula",

"dqf",

"vhavobdusknlmxtpgkm",

"tsnlrstfsm",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mosgduecvepxuwcjssdiy",

"inumawhpqot",

"clusnbrprgxcrd",

"agxuf",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"lagwkqmfyttsuccsyoqbh",

"ndaadaniaaqfokylhuylchqvlas",

"qlrfl",

},
},
            new StringtextArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vljveagqtsyuvc",

"ccwixrssupfajkcmocvqrexiyiwph",

"jecnyfmqqtcjtyfctwbgfysjv",

"mvjxn",

},
    ModelInner = new StringtextArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"aydwkubp",

"ylhymriatircqgvpyjcihwrma",

"cgdvodtqwobfdxjwnw",

"yufgtxjhsyivrpq",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"elocbur",

"aoiryrneiobmocxugnkoixssymfmt",

"mwxnjnb",

"aikejitqwqtorrq",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"xhflwftvsnjxpdpwhktc",

"ivhulgbb",

"vlqlmhwaty",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"frogsyrmfimbpkha",

"kptxcjnisvthqrs",

"adcobvisjobwujmtf",

"k",

},
},
            new StringtextArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vpqpjc",

"lq",

"xqjealhcmrslynlrluaxsfwr",

"",

},
    ModelInner = new StringtextArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qtqoixdvvxy",

"ntrrfnti",

"jqfhfqrwqytkavhqjaxxviwbht",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"rvefnrywpkntstpfvwfe",

"ocruyewtesaln",

"wdxgphv",

"hbcjggideybnxbwqfaqhrajlky",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"acyfxojneawjcmi",

"rknqcmjmxdnokebgtgtgs",

"ddipculqamwsrwydul",

},
    ModelInner = new StringtextArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"cflouxghvllwu",

"mivmrpoamajhnixnylnlwwwcwrn",

"sqfcnxyfgtcnoyiplbld",

"jmcdfvciwsmkuylmasww",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"wsncojpcyulaitskni",

"rinpebicipts",

"",

},
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"woscirmwjvrhsykopwrcwbkoxdn",

"vcxmuoyvumunwyxhtricpo",

"olhhjrvtpsyxc",

"lrscoqoeihkrrufmfpljqcm",

},
},
            new StringtextArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"kukttenfqqktvsppnda",

"gmnijkpnfhpgmsqcawnbbhvpky",

"eujsbywunbhhbaqsunmy",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ggsggqooqxugxhpae",

"ckjfhg",

"ciuicdkajj",

"jacjnddjh",

},
},
            new StringtextArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"flpoufjbdliqd",

"akrmvpxjueqdoocffmawbjispuik",

"kqfvvcwvcwuwwjmjqgdskhkfwfb",

},
    ModelInner = new StringtextArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"actxkk",

"xxtegdfayqpdwcbiuyhwr",

"kghxgxmvniydonblyxrtkbxlucsh",

"xjktbgyxhvdrkpluagtknk",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"chetdicquf",

"nugixsolqqyjlmyqjuoiahga",

"nmnpbmoshglunk",

"puwgihnvgxbomiiildceqiourgi",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"dwrlgxqpi",

"tt",

"pshdxxqbljntva",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"irntbwotmo",

"gemycjnjstijucjmkwup",

"llnibowdpvjoha",

},
    ModelInner = new StringtextArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"yduscglmqrsvetlmf",

"qmyblhqtvftyhss",

"aqlkiujdtegpyon",

"dqgvlaxqqijwnreugaqhvyxxfx",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"cpbmlbwjlhnpximnuqhqtwojnfnj",

"ghcdulvcpchlluovibifxoq",

"leyevofqfsnsmcdsmcjcyqjeql",

},
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"cfffmrngtgx",

"k",

"psth",

"afbjqvvusoyxdatxqvnobrns",

},
},
            new StringtextArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"p",

"qaflou",

"hbdmxfepulmnx",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"nwwjbggfhwmgqcdajvmjpcewvhbq",

"osoac",

"wwyc",

},
},
            new StringtextArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"sheprptucedykv",

"ygwqbhpvlfgmxpna",

"yqo",

},
    ModelInner = new StringtextArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mxfkqiqhhgxncnctygkkv",

"psyqlhmgxlaoiqmmmqhjbrm",

"jojrff",

"bmlybvbgdtsivnwrs",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"accpfxknsqspjhlugcmgipsmh",

"pxnlnhfaegqnmqjouofwaofebp",

"uhrxdfswhfgrtgm",

},
},
            new StringtextArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"gjnn",

"xmka",

"dr",

"hwcl",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ybkmsuqvoorwfkpr",

"wamiaqfjwrohc",

"yrrxmyapdhxantryhwamcanemoh",

"mpslylgxxsanvnxfhysomibhe",

},
},
            new StringtextArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wfsurgvgrp",

"bamgibfffmpvegycxeqsntaknadk",

"wqalckiggclimrob",

},
    ModelInner = new StringtextArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"vxfljektvgnrlvxefcndl",

"narnvlfpvtdskwbvdv",

"mvarhjfovkukodaodrfthu",

"aiwpjrage",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"g",

"mibsyk",

"mtongflhabcvlyqmhdq",

},
},
    NullableValue = null,
},
            new StringtextArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"tphoowxylhapryrqocpnwu",

"odwuqkwiiamyylowkom",

"xofqjp",

"tfnad",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"lusw",

"vbqoovhrud",

},
},
            new StringtextArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"heqp",

"yqayrljin",

"ncraornjyhgbctumjqpabmmuwd",

"mpwtpcxhvxdkfv",

},
    ModelInner = new StringtextArray2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"symgewuyq",

"vnuwqcxpgjfepocm",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"aupu",

"lipstya",

"jcbrpxnphshdljmssk",

"arqevegitvwrfkw",

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 108;
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
                await ((IStringListtextArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[25],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(models[12],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(models[13],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(models[14],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(models[15],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[16],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[17],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[18],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[19],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[20],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[21],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[22],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[23],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[24],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        StringtextArray2M.AssertModel(models[0],_testData[10], false);
                        StringtextArray2M.AssertModel(models[1],_testData[11], false);
                        StringtextArray2M.AssertModel(models[2],_testData[12], false);
                        StringtextArray2M.AssertModel(models[3],_testData[13], false);
                        StringtextArray2M.AssertModel(models[4],_testData[14], false);
                        StringtextArray2M.AssertModel(models[5],_testData[15], false);
                        StringtextArray2M.AssertModel(models[6],_testData[16], false);
                        StringtextArray2M.AssertModel(models[7],_testData[17], false);
                        StringtextArray2M.AssertModel(models[8],_testData[18], false);
                        StringtextArray2M.AssertModel(models[9],_testData[19], false);
                        StringtextArray2M.AssertModel(models[10],_testData[20], false);
                        StringtextArray2M.AssertModel(models[11],_testData[21], false);
                        StringtextArray2M.AssertModel(models[12],_testData[22], false);
                        StringtextArray2M.AssertModel(models[13],_testData[23], false);
                        StringtextArray2M.AssertModel(models[14],_testData[24], false);
                        StringtextArray2M.AssertModel(models[15],_testData[25], false);
                        StringtextArray2M.AssertModel(models[16],_testData[26], false);
                        StringtextArray2M.AssertModel(models[17],_testData[27], false);
                        StringtextArray2M.AssertModel(models[18],_testData[28], false);
                        StringtextArray2M.AssertModel(models[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        StringtextArray2M.AssertModel(models[0],_testData[1], false);
                        StringtextArray2M.AssertModel(models[1],_testData[2], false);
                        StringtextArray2M.AssertModel(models[2],_testData[3], false);
                        StringtextArray2M.AssertModel(models[3],_testData[4], false);
                        StringtextArray2M.AssertModel(models[4],_testData[5], false);
                        StringtextArray2M.AssertModel(models[5],_testData[6], false);
                        StringtextArray2M.AssertModel(models[6],_testData[7], false);
                        StringtextArray2M.AssertModel(models[7],_testData[8], false);
                        StringtextArray2M.AssertModel(models[8],_testData[9], false);
                        StringtextArray2M.AssertModel(models[9],_testData[10], false);
                        StringtextArray2M.AssertModel(models[10],_testData[11], false);
                        StringtextArray2M.AssertModel(models[11],_testData[12], false);
                        StringtextArray2M.AssertModel(models[12],_testData[13], false);
                        StringtextArray2M.AssertModel(models[13],_testData[14], false);
                        StringtextArray2M.AssertModel(models[14],_testData[15], false);
                        StringtextArray2M.AssertModel(models[15],_testData[16], false);
                        StringtextArray2M.AssertModel(models[16],_testData[17], false);
                        StringtextArray2M.AssertModel(models[17],_testData[18], false);
                        StringtextArray2M.AssertModel(models[18],_testData[19], false);
                        StringtextArray2M.AssertModel(models[19],_testData[20], false);
                        StringtextArray2M.AssertModel(models[20],_testData[21], false);
                        StringtextArray2M.AssertModel(models[21],_testData[22], false);
                        StringtextArray2M.AssertModel(models[22],_testData[23], false);
                        StringtextArray2M.AssertModel(models[23],_testData[24], false);
                        StringtextArray2M.AssertModel(models[24],_testData[25], false);
                        StringtextArray2M.AssertModel(models[25],_testData[26], false);
                        StringtextArray2M.AssertModel(models[26],_testData[27], false);
                        StringtextArray2M.AssertModel(models[27],_testData[28], false);
                        StringtextArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        StringtextArray2M.AssertModel(models[0],_testData[7], false);
                        StringtextArray2M.AssertModel(models[1],_testData[8], false);
                        StringtextArray2M.AssertModel(models[2],_testData[9], false);
                        StringtextArray2M.AssertModel(models[3],_testData[10], false);
                        StringtextArray2M.AssertModel(models[4],_testData[11], false);
                        StringtextArray2M.AssertModel(models[5],_testData[12], false);
                        StringtextArray2M.AssertModel(models[6],_testData[13], false);
                        StringtextArray2M.AssertModel(models[7],_testData[14], false);
                        StringtextArray2M.AssertModel(models[8],_testData[15], false);
                        StringtextArray2M.AssertModel(models[9],_testData[16], false);
                        StringtextArray2M.AssertModel(models[10],_testData[17], false);
                        StringtextArray2M.AssertModel(models[11],_testData[18], false);
                        StringtextArray2M.AssertModel(models[12],_testData[19], false);
                        StringtextArray2M.AssertModel(models[13],_testData[20], false);
                        StringtextArray2M.AssertModel(models[14],_testData[21], false);
                        StringtextArray2M.AssertModel(models[15],_testData[22], false);
                        StringtextArray2M.AssertModel(models[16],_testData[23], false);
                        StringtextArray2M.AssertModel(models[17],_testData[24], false);
                        StringtextArray2M.AssertModel(models[18],_testData[25], false);
                        StringtextArray2M.AssertModel(models[19],_testData[26], false);
                        StringtextArray2M.AssertModel(models[20],_testData[27], false);
                        StringtextArray2M.AssertModel(models[21],_testData[28], false);
                        StringtextArray2M.AssertModel(models[22],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                await ((IStringListtextArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 7, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                await ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 108, query1, 4, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[27],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatStringtextArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                 ((IStringListtextArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[29], false);
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
                 ((IStringListtextArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 119, query1, 75, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IStringListtextArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 119, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[12],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[13],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[14],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[15],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[16],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[17],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[18],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[19],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[20],_testData[29], false);
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
                await ((IStringListtextArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 7, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IStringListtextArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 87, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(models[4],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(models[5],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(models[6],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(models[7],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(models[8],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[9],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[10],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatStringtextArray2M.AssertModel(models[0],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(models[1],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(models[2],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(models[3],_testData[29], false);
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
                 ((IStringListtextArray)this).DbConnectionDynQuerySelectModelBatch(connection, 108, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatStringtextArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatStringtextArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatStringtextArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatStringtextArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IStringListtextArray)this).DbConnectionSTSelectModelBatchAsync(connection, 32, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        StringtextArray2M.AssertModel(models[0],_testData[14], false);
                        StringtextArray2M.AssertModel(models[1],_testData[15], false);
                        StringtextArray2M.AssertModel(models[2],_testData[16], false);
                        StringtextArray2M.AssertModel(models[3],_testData[17], false);
                        StringtextArray2M.AssertModel(models[4],_testData[18], false);
                        StringtextArray2M.AssertModel(models[5],_testData[19], false);
                        StringtextArray2M.AssertModel(models[6],_testData[20], false);
                        StringtextArray2M.AssertModel(models[7],_testData[21], false);
                        StringtextArray2M.AssertModel(models[8],_testData[22], false);
                        StringtextArray2M.AssertModel(models[9],_testData[23], false);
                        StringtextArray2M.AssertModel(models[10],_testData[24], false);
                        StringtextArray2M.AssertModel(models[11],_testData[25], false);
                        StringtextArray2M.AssertModel(models[12],_testData[26], false);
                        StringtextArray2M.AssertModel(models[13],_testData[27], false);
                        StringtextArray2M.AssertModel(models[14],_testData[28], false);
                        StringtextArray2M.AssertModel(models[15],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IStringListtextArray)this).DbConnectionSTSelectModelBatch(connection, 32, 22))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        StringtextArray2M.AssertModel(models[0],_testData[6], false);
                        StringtextArray2M.AssertModel(models[1],_testData[7], false);
                        StringtextArray2M.AssertModel(models[2],_testData[8], false);
                        StringtextArray2M.AssertModel(models[3],_testData[9], false);
                        StringtextArray2M.AssertModel(models[4],_testData[10], false);
                        StringtextArray2M.AssertModel(models[5],_testData[11], false);
                        StringtextArray2M.AssertModel(models[6],_testData[12], false);
                        StringtextArray2M.AssertModel(models[7],_testData[13], false);
                        StringtextArray2M.AssertModel(models[8],_testData[14], false);
                        StringtextArray2M.AssertModel(models[9],_testData[15], false);
                        StringtextArray2M.AssertModel(models[10],_testData[16], false);
                        StringtextArray2M.AssertModel(models[11],_testData[17], false);
                        StringtextArray2M.AssertModel(models[12],_testData[18], false);
                        StringtextArray2M.AssertModel(models[13],_testData[19], false);
                        StringtextArray2M.AssertModel(models[14],_testData[20], false);
                        StringtextArray2M.AssertModel(models[15],_testData[21], false);
                        StringtextArray2M.AssertModel(models[16],_testData[22], false);
                        StringtextArray2M.AssertModel(models[17],_testData[23], false);
                        StringtextArray2M.AssertModel(models[18],_testData[24], false);
                        StringtextArray2M.AssertModel(models[19],_testData[25], false);
                        StringtextArray2M.AssertModel(models[20],_testData[26], false);
                        StringtextArray2M.AssertModel(models[21],_testData[27], false);
                        StringtextArray2M.AssertModel(models[22],_testData[28], false);
                        StringtextArray2M.AssertModel(models[23],_testData[29], false);
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
                ((IStringListtextArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((IStringListtextArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
StringtextArray2M.AssertModel(models[0],_testData[9], false);StringtextArray2M.AssertModel(models[1],_testData[10], false);StringtextArray2M.AssertModel(models[2],_testData[11], false);StringtextArray2M.AssertModel(models[3],_testData[12], false);StringtextArray2M.AssertModel(models[4],_testData[13], false);StringtextArray2M.AssertModel(models[5],_testData[14], false);StringtextArray2M.AssertModel(models[6],_testData[15], false);StringtextArray2M.AssertModel(models[7],_testData[16], false);StringtextArray2M.AssertModel(models[8],_testData[17], false);StringtextArray2M.AssertModel(models[9],_testData[18], false);StringtextArray2M.AssertModel(models[10],_testData[19], false);StringtextArray2M.AssertModel(models[11],_testData[20], false);StringtextArray2M.AssertModel(models[12],_testData[21], false);StringtextArray2M.AssertModel(models[13],_testData[22], false);StringtextArray2M.AssertModel(models[14],_testData[23], false);StringtextArray2M.AssertModel(models[15],_testData[24], false);StringtextArray2M.AssertModel(models[16],_testData[25], false);StringtextArray2M.AssertModel(models[17],_testData[26], false);StringtextArray2M.AssertModel(models[18],_testData[27], false);StringtextArray2M.AssertModel(models[19],_testData[28], false);StringtextArray2M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringListtextArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringListtextArray)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((IStringListtextArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
StringtextArray2M.AssertModel(models[0],_testData[21], false);StringtextArray2M.AssertModel(models[1],_testData[22], false);StringtextArray2M.AssertModel(models[2],_testData[23], false);StringtextArray2M.AssertModel(models[3],_testData[24], false);StringtextArray2M.AssertModel(models[4],_testData[25], false);StringtextArray2M.AssertModel(models[5],_testData[26], false);StringtextArray2M.AssertModel(models[6],_testData[27], false);StringtextArray2M.AssertModel(models[7],_testData[28], false);StringtextArray2M.AssertModel(models[8],_testData[29], false);
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 0; i < 6; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringListtextArray)this).DynQuerySelectImportModelInnerAsync(connection);
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

        [Test, Order(0)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextArray2MIWA>(2);
                for (int i = 4; i < 10; i++)
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringListtextArray)this).DynQuerySelectImportModelInner(connection);
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(StringtextArray2MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextArray2MI>(2);
                for (int i = 8; i < 14; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IStringListtextArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringListtextArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(0)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<StringtextArray2MI>(2);
                for (int i = 12; i < 18; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IStringListtextArray)this).ImportModelInner(connection, importCollection);
                var models = ((IStringListtextArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<StringtextArray2M>(15);

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
                ((IStringListtextArray)this).ImportModel(connection, importCollection);
                var models = ((IStringListtextArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                StringtextArray2M.AssertModel(models[0],_testData[0], false);
                StringtextArray2M.AssertModel(models[1],_testData[1], false);
                StringtextArray2M.AssertModel(models[2],_testData[2], false);
                StringtextArray2M.AssertModel(models[3],_testData[3], false);
                StringtextArray2M.AssertModel(models[4],_testData[4], false);
                StringtextArray2M.AssertModel(models[5],_testData[5], false);
                StringtextArray2M.AssertModel(models[6],_testData[6], false);
                StringtextArray2M.AssertModel(models[7],_testData[7], false);
                StringtextArray2M.AssertModel(models[8],_testData[8], false);
                StringtextArray2M.AssertModel(models[9],_testData[9], false);
                StringtextArray2M.AssertModel(models[10],_testData[10], false);
                StringtextArray2M.AssertModel(models[11],_testData[11], false);
                StringtextArray2M.AssertModel(models[12],_testData[12], false);
                StringtextArray2M.AssertModel(models[13],_testData[13], false);
                StringtextArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IStringListtextArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IStringListtextArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                StringtextArray2M.AssertModel(models[0],_testData[0], false);
                StringtextArray2M.AssertModel(models[1],_testData[1], false);
                StringtextArray2M.AssertModel(models[2],_testData[2], false);
                StringtextArray2M.AssertModel(models[3],_testData[3], false);
                StringtextArray2M.AssertModel(models[4],_testData[4], false);
                StringtextArray2M.AssertModel(models[5],_testData[5], false);
                StringtextArray2M.AssertModel(models[6],_testData[6], false);
                StringtextArray2M.AssertModel(models[7],_testData[7], false);
                StringtextArray2M.AssertModel(models[8],_testData[8], false);
                StringtextArray2M.AssertModel(models[9],_testData[9], false);
                StringtextArray2M.AssertModel(models[10],_testData[10], false);
                StringtextArray2M.AssertModel(models[11],_testData[11], false);
                StringtextArray2M.AssertModel(models[12],_testData[12], false);
                StringtextArray2M.AssertModel(models[13],_testData[13], false);
                StringtextArray2M.AssertModel(models[14],_testData[14], false);
                StringtextArray2M.AssertModel(models[15],_testData[15], false);
                StringtextArray2M.AssertModel(models[16],_testData[16], false);
                StringtextArray2M.AssertModel(models[17],_testData[17], false);
                StringtextArray2M.AssertModel(models[18],_testData[18], false);
                StringtextArray2M.AssertModel(models[19],_testData[19], false);
                StringtextArray2M.AssertModel(models[20],_testData[20], false);
                StringtextArray2M.AssertModel(models[21],_testData[21], false);
                StringtextArray2M.AssertModel(models[22],_testData[22], false);
                StringtextArray2M.AssertModel(models[23],_testData[23], false);
                StringtextArray2M.AssertModel(models[24],_testData[24], false);
                StringtextArray2M.AssertModel(models[25],_testData[25], false);
                StringtextArray2M.AssertModel(models[26],_testData[26], false);
                StringtextArray2M.AssertModel(models[27],_testData[27], false);
                StringtextArray2M.AssertModel(models[28],_testData[28], false);
                StringtextArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_stringtextarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(StringtextArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IStringListtextArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringListtextArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

