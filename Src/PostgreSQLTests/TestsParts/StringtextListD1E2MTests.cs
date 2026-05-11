

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
    internal partial interface IStringListtextListD1
    {
    }
    
    internal partial class StringListtextListD1 : IStringListtextListD1
    {


#region TestData

        private readonly StringtextListD1E2M[] _testData = new StringtextListD1E2M[]
        {
            new StringtextListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"sutltcgbbtjpl",

"fvmnsnvkoiekikg",

"rasklhjrabc",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"ejblnglllulmionsyyojeer",

"fsaiebadamlbx",

"aoikkvqogamtpmyadtatgmlpxsju",

"yufwkwjkqixvv",

},
},
            new StringtextListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"kdigmbhyjwobseeledoaleib",

"ghfbwhlftsyn",

"yslwkeonvvtdxutgepwpfijtkyfc",

"",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"gbpxokgukbwxrvhtfiuyuansvqvoq",

"rsijklakikhq",

"lqxuprvcyepyqdgwgjbstv",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"pbcmovioayweafbuqqnttgn",

"smlaywqyysywbkh",

"bpmdxtlpkncncntotmoeponwbakew",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vthhofuflomfhfkefotrgmjmiquc",

"xly",

"vpfbxlqnqwet",

},
},
            new StringtextListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mhqpdjflwibb",

"cbeib",

"",

"dtnv",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"eltykcacxndbvigybn",

"uctvlywgpnur",

"n",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"esiykostcndte",

"pffmimvhejepdatgforfobrptmpr",

"lxmkexgukpx",

"ktyrmaahthm",

},
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"cnksijgniskrwj",

"vysanvwrqkirmyx",

"x",

"twkyqrsydkvcgpltobwboayjgjyjc",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jrrenpcqnqoc",

"wwtwfxbnmqethpnra",

"usvhlhl",

"tjthnwtxpngwivwqfktmmuwaoem",

},
},
            new StringtextListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"mdqphcoolfsiyrlmhofnvilfxst",

"pwomgsambhq",

"a",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"cnqnivfae",

"vxprvtyd",

"ajfnokgvxodxbts",

"lxcrifcorbmwynkre",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"o",

"nllieiwdsafkrycdi",

"jecrvtwndqitewkmkkxmaqwgevit",

},
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"r",

"nodqytjfjlyayomevmbol",

"cxvgsiavrvkskamojhwmeaiyketp",

"quoavekdjdwsanjlcxbqkq",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"itgkqvxqcyfqiudhvitapklapmxk",

"tiojunpiloldqlsfvsynrivarifp",

"ibdxvksmdvscoilnmkjtbtqnei",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"kw",

"twptqvbcuthasthsmkutmqhyy",

"gqe",

"fqdxdlxbkhbqtihkylwespsspd",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"ayiiyljbcid",

"apyafjkebtngxkxgnflleybk",

"owlfjsbknodaduyjvwojjseb",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"tbb",

"rctokqtaogxdffommokmlxppy",

"vswhu",

"lkhbhuqndmagfgfycdtunndcbqyb",

},
},
            new StringtextListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"lnpveiaspkturiytspysqucnwd",

"vln",

"doqckntnbtratoknxmcteh",

"kqyheya",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"cfaewgaritwg",

"nraoxrs",

"jlgdpbheeqivokej",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"inbfiwevpjuyvhelfqmbgnh",

"iolssndielytqvswbqkn",

"esymgbpvqrnftdxb",

},
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"ornyppcvotqd",

"xiaovxauufddwjakmxcdwpfpt",

"hcwrhcyb",

},
},
            new StringtextListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"dywmnfjrwxvbebfmwaq",

"cjklxghpvqpmswexrlyycwhe",

"kyixpharfkjonrebxxtnvvwupmai",

"fdhq",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"pxuwhaabxflkyjyofochbymgvpxct",

"smqmojedwjelvmwfxn",

"gltqhybrnr",

"nuhcip",

},
},
            new StringtextListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"mhfehsappjnycymosdsvydsafyrt",

"mpgdvvgi",

"golyalwmnwnomiuuetldhida",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"fkomnbc",

"obgwhlc",

"gwuekp",

"eyijitcojrkxpiiwvppapdupmad",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"lkeninrlqkgmkwiv",

"tdewkwdnxmaiggrnwih",

},
},
            new StringtextListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"kywymdrmcovyjhhixogkkel",

"vangfcviqeciydhnhsgxutcuu",

"hcuyd",

"lokfejtpghohagpfw",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"eymdhpmkycyfyxbtdkfbggoqnmybr",

"aquukherbnvxfsnxoslhloeckog",

"jjakn",

"pvwvcwynfcycwmeiulltayhstutvl",

},
},
            new StringtextListD1E2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"u",

"hotnrepydemfhlmsrjdksllded",

"ccnshpvqjatokeeyqtk",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"pmekehuxdwrrnerwqn",

"daxmlriewp",

"ajncytmruxhiirkrganfcefxcdyaw",

"mcxuih",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"dlndvuiid",

"dcppqaovsbbc",

"ukl",

"nevdcnynswkuvqhnmudqsvwixmbt",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"fonkvsmmophkkibgcm",

"qvujuvvjohkwiqrepssyrkvy",

"enkli",

},
},
            new StringtextListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"mmmsskeamwncxkuicdqqdtxaeiibw",

"lvy",

"kmjyfmlctpfurchmxxcmmlxc",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"tjaytenttxysbhxopaibvkuvvdjgl",

"jdn",

"ciapqsqolglcjsh",

"dyloooja",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"mmkumursjswjsgqrpfrnmdilixd",

"mtpkerwvqgwpkbtajgorqou",

"mwepcprtsbggobthuu",

"njkyprrgsdbwxbjowuypui",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"kvlnpva",

"jhmjfwbnadlaisfwdhb",

"hyktkj",

"ulonfwafccnciwoddyylvaduw",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"gbwmkcauxoxsqijurv",

"haycesxwlitbfsqyp",

"hrdgb",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"mjnhopfebhoalcklvmsomw",

"kqtjeymndxwxgeijagtjtldstaqjh",

"rhftflqpwwqlyvmmqm",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"nuagwpwhwlbipylrplkgjcktqwt",

"iypqnbsexajafwftoqsek",

"wueomvruhyhrruofeoqpj",

"utqbhbljmxljxoqhhgoldodgj",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"fjyqcynymfonydnuxwaraxpyaql",

"iy",

"cyccnq",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"jffdkxntghyhcnpuyxxcjeoqkd",

"unfvpmtxqb",

"ymdttrdkcwyfbvfafjd",

"qsbkamryacvbypew",

},
},
            new StringtextListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qpsrmxgoayjohvdlsqxfmcmybrgfy",

"nopoyxqbkmhihmgakakj",

"jnrtmxeer",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qwkajciiyarhkvhfpdu",

"xydudeudeetawjsk",

"jubvnjffgpjmepoechqfqm",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"hcewnasqsuindjrdpgmfvqxltnio",

"buiduwyysdoxinsxosyrnfsbnws",

"curnhrtllnfwnrwtqdgueyxm",

"fpighpjuvim",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"lrpdhbgqdxtaerwpgurtidrlxkgaw",

"uwgrlgtcqlhwaqwnsbjujpgasce",

"oyoubhailfrtyvftcpscjixgh",

"u",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"mbw",

"ubgugsdmeh",

"com",

},
},
            new StringtextListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"qwjlcliehhwxsgvebljpxshsvn",

"hdhu",

"dieuidl",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"tesboo",

"hbt",

"yunijtlgfovbwlemsjegaph",

"mwibixvibxqbigvlfdtqo",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vxvjmivjtseubeafqfy",

"wyepixkttxccutel",

"ixxpagptie",

},
},
            new StringtextListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"psccrsh",

"ffqhvleqnvujwsheuuavhmukx",

"suwdvboexsoefksexdgr",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"afplfigmytkdpefu",

"iydmwhwpjjbxqaraysljqxof",

"jniqcwmtytrbdvo",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"bcqvctbjyseipcychspeoywnqlm",

"svhdrf",

"xeaegiigcuismnifxlhxvmnxrrly",

"mwegbcypxuqiangvkmgymtcqrpeya",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"fjojowb",

"qywltqkyuijk",

"n",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(3)
{
"vhqguyvvfvtkl",

"uhjhsgiuufbcupygvhjwwwvsbfck",

"smxyojvncdlv",

},
},
            new StringtextListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"cxnsrvbcpfsbspsf",

"lgdovkyaxcnuvybkpuxxinnfediwd",

"tjrcinfdk",

"vadtrxqfcdcsgalrvmk",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"hjhqtmdexofgkyaoyrvgk",

"tyedvtwgvvpeuvyrujttwrip",

"yjknekknjgwfdp",

},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"lhwx",

"iuwpeexdlqfekneblshstl",

"lweibldhi",

"hscowcw",

},
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"wineesljbsi",

"gloounxkj",

"gcwshljbhlegipwvixuowldw",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"sduscbajgygsurxtv",

"",

"auvctr",

"",

},
},
            new StringtextListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"btididfnxo",

"lhgnvrlous",

"ryxqmforrleadlgjkwnceyp",

"evkghathmiubgupqlctyppdfrppg",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"atywgxfvxvjtkc",

"ndpkkjbfqpvttwfrxjkxitos",

"riccxqwecfovwjthqhq",

"bmyapwjgqbumf",

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"isxqlssjwcqljyioshuqhrxyyory",

"wjsaoyatrwfcpngyxmfrwrqjlmdji",

"bddeghobyta",

"ahqxgxuk",

},
},
            new StringtextListD1E2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"misnybaluv",

"xdvdfyrhwqjxtumpsurfiik",

"tbc",

"ouputuiyx",

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.String>(4)
{
"rwd",

"obucgeyflkknqgxubu",

"dfganqjevaewndpuammfuys",

"qukoclqqwbcdtfs",

},
},
            new StringtextListD1E2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"gdasqsqbgsesighsqwf",

"smsgs",

"ippgdjr",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"",

"oxvv",

"cupyuxvenvcdafyuva",

"lbppcgvhmgvqvsnlf",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"chxvoaglpqwirkoshwtvqhg",

"lxgpmdxsqdqdcexvi",

"",

},
    ModelInner = null,
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"",

"dajuvchtaumhdprwkfsmo",

"bvsggfboesrbahmhbdwmbwolifphl",

},
    ModelInner = new StringtextListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.String>(3)
{
"vspxvmnahxukpkoubveejikrogh",

"fddpqcxog",

"mhjpcqmjmxuughphrtwgdwxvpu",

},
    NullableValue = null,
},
    NullableValue = null,
},
            new StringtextListD1E2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<System.String>(4)
{
"lihfrukuqjymbaqybnsvukmcjo",

"ufnmpykakxcfb",

"wcyvluxeuwhppaqhoyidjvynjmqeh",

"dcssmehauhxbuakcwlmarachu",

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextlistd1e2mi(
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
            asPartInterface: typeof(IStringListtextListD1)),
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
INSERT INTO public.stringtextlistd1e2mi(
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
            queryMapTypes: [typeof(StringtextListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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

                changedRows =  ((IStringListtextListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IStringListtextListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IStringListtextListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IStringListtextListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IStringListtextListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IStringListtextListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IStringListtextListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextlistd1e2m(
	id,
    value,
    nullablevalue,
    stringtextlistd1e2mi_id
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
            asPartInterface: typeof(IStringListtextListD1)), 
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
                methodParametrName: "stringtextlistd1e2mi_id", 
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
                changedRows =  ((IStringListtextListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IStringListtextListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IStringListtextListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IStringListtextListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextlistd1e2m(
	id,
    value,
    nullablevalue,
    stringtextlistd1e2mi_id
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
    stringtextlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.stringtextlistd1e2m(
	id,
    value,
    nullablevalue,
    stringtextlistd1e2mi_id
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
    stringtextlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                methodParametrName: "stringtextlistd1e2mi_id", 
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
                List<StringtextListD1E2M> models = null;

                models =  ((IStringListtextListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IStringListtextListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IStringListtextListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IStringListtextListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<StringtextListD1E2M> models = null;

                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IStringListtextListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                StringtextListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextListD1E2M), typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                ((IStringListtextListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IStringListtextListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IStringListtextListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
LEFT JOIN public.stringtextlistd1e2mi mi ON mi.id = m.stringtextlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models = await ((IStringListtextListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IStringListtextListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextListD1E2M), typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                ((IStringListtextListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IStringListtextListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IStringListtextListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
LEFT JOIN public.stringtextlistd1e2mi mi ON mi.id = m.stringtextlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models = await ((IStringListtextListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IStringListtextListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextListD1E2M), typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                await((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                ((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                 ((IStringListtextListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                 ((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IStringListtextListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IStringListtextListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                 ((IStringListtextListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
LEFT JOIN public.stringtextlistd1e2mi mi ON mi.id = m.stringtextlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models = await((IStringListtextListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        StringtextListD1E2M.AssertModel(models[0],_testData[18], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[19], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[20], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[21], false);
                        StringtextListD1E2M.AssertModel(models[4],_testData[22], false);
                        StringtextListD1E2M.AssertModel(models[5],_testData[23], false);
                        StringtextListD1E2M.AssertModel(models[6],_testData[24], false);
                        StringtextListD1E2M.AssertModel(models[7],_testData[25], false);
                        StringtextListD1E2M.AssertModel(models[8],_testData[26], false);
                        StringtextListD1E2M.AssertModel(models[9],_testData[27], false);
                        StringtextListD1E2M.AssertModel(models[10],_testData[28], false);
                        StringtextListD1E2M.AssertModel(models[11],_testData[29], false);
                        StringtextListD1E2M.AssertModel(models[12],_testData[30], false);
                        StringtextListD1E2M.AssertModel(models[13],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[14],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[15],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        StringtextListD1E2M.AssertModel(models[0],_testData[4], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[5], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[6], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[7], false);
                        StringtextListD1E2M.AssertModel(models[4],_testData[8], false);
                        StringtextListD1E2M.AssertModel(models[5],_testData[9], false);
                        StringtextListD1E2M.AssertModel(models[6],_testData[10], false);
                        StringtextListD1E2M.AssertModel(models[7],_testData[11], false);
                        StringtextListD1E2M.AssertModel(models[8],_testData[12], false);
                        StringtextListD1E2M.AssertModel(models[9],_testData[13], false);
                        StringtextListD1E2M.AssertModel(models[10],_testData[14], false);
                        StringtextListD1E2M.AssertModel(models[11],_testData[15], false);
                        StringtextListD1E2M.AssertModel(models[12],_testData[16], false);
                        StringtextListD1E2M.AssertModel(models[13],_testData[17], false);
                        StringtextListD1E2M.AssertModel(models[14],_testData[18], false);
                        StringtextListD1E2M.AssertModel(models[15],_testData[19], false);
                        StringtextListD1E2M.AssertModel(models[16],_testData[20], false);
                        StringtextListD1E2M.AssertModel(models[17],_testData[21], false);
                        StringtextListD1E2M.AssertModel(models[18],_testData[22], false);
                        StringtextListD1E2M.AssertModel(models[19],_testData[23], false);
                        StringtextListD1E2M.AssertModel(models[20],_testData[24], false);
                        StringtextListD1E2M.AssertModel(models[21],_testData[25], false);
                        StringtextListD1E2M.AssertModel(models[22],_testData[26], false);
                        StringtextListD1E2M.AssertModel(models[23],_testData[27], false);
                        StringtextListD1E2M.AssertModel(models[24],_testData[28], false);
                        StringtextListD1E2M.AssertModel(models[25],_testData[29], false);
                        StringtextListD1E2M.AssertModel(models[26],_testData[30], false);
                        StringtextListD1E2M.AssertModel(models[27],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[28],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[29],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[30],_testData[34], false);
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
                var models = ((IStringListtextListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 178;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        StringtextListD1E2M.AssertModel(models[0],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        StringtextListD1E2M.AssertModel(models[0],_testData[10], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[11], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[12], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[13], false);
                        StringtextListD1E2M.AssertModel(models[4],_testData[14], false);
                        StringtextListD1E2M.AssertModel(models[5],_testData[15], false);
                        StringtextListD1E2M.AssertModel(models[6],_testData[16], false);
                        StringtextListD1E2M.AssertModel(models[7],_testData[17], false);
                        StringtextListD1E2M.AssertModel(models[8],_testData[18], false);
                        StringtextListD1E2M.AssertModel(models[9],_testData[19], false);
                        StringtextListD1E2M.AssertModel(models[10],_testData[20], false);
                        StringtextListD1E2M.AssertModel(models[11],_testData[21], false);
                        StringtextListD1E2M.AssertModel(models[12],_testData[22], false);
                        StringtextListD1E2M.AssertModel(models[13],_testData[23], false);
                        StringtextListD1E2M.AssertModel(models[14],_testData[24], false);
                        StringtextListD1E2M.AssertModel(models[15],_testData[25], false);
                        StringtextListD1E2M.AssertModel(models[16],_testData[26], false);
                        StringtextListD1E2M.AssertModel(models[17],_testData[27], false);
                        StringtextListD1E2M.AssertModel(models[18],_testData[28], false);
                        StringtextListD1E2M.AssertModel(models[19],_testData[29], false);
                        StringtextListD1E2M.AssertModel(models[20],_testData[30], false);
                        StringtextListD1E2M.AssertModel(models[21],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[22],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[23],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextListD1E2M), typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
            asPartInterface: typeof(IStringListtextListD1)),
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
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                await((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 70, query1, 70, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatStringtextListD1E2M>();
                var models2 = new List<FlatStringtextListD1E2M>();
                ((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatStringtextListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                 ((IStringListtextListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 62, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var firstItems2 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                 ((IStringListtextListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatStringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
            asPartInterface: typeof(IStringListtextListD1)),
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
            asPartInterface: typeof(IStringListtextListD1)),
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IStringListtextListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IStringListtextListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 104, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatStringtextListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[31],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                await ((IStringListtextListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 104, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IStringListtextListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatStringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IStringListtextListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 159, query1, 167, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatStringtextListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
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
FROM public.stringtextlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems1 = new List<FlatStringtextListD1E2M>();
                var secondItems2 = new List<FlatStringtextListD1E2M>();
                 ((IStringListtextListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 67, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatStringtextListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatStringtextListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatStringtextListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.stringtextlistd1e2m m
LEFT JOIN public.stringtextlistd1e2mi mi ON mi.id = m.stringtextlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models = await((IStringListtextListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IStringListtextListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 167, 178))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        StringtextListD1E2M.AssertModel(models[0],_testData[29], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[30], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[4],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        StringtextListD1E2M.AssertModel(models[0],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[34], false);
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
                var models = ((IStringListtextListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    StringtextListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IStringListtextListD1)this).DbConnectionSTSelectModelBatch(connection, 83, 178))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        StringtextListD1E2M.AssertModel(models[0],_testData[13], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[14], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[15], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[16], false);
                        StringtextListD1E2M.AssertModel(models[4],_testData[17], false);
                        StringtextListD1E2M.AssertModel(models[5],_testData[18], false);
                        StringtextListD1E2M.AssertModel(models[6],_testData[19], false);
                        StringtextListD1E2M.AssertModel(models[7],_testData[20], false);
                        StringtextListD1E2M.AssertModel(models[8],_testData[21], false);
                        StringtextListD1E2M.AssertModel(models[9],_testData[22], false);
                        StringtextListD1E2M.AssertModel(models[10],_testData[23], false);
                        StringtextListD1E2M.AssertModel(models[11],_testData[24], false);
                        StringtextListD1E2M.AssertModel(models[12],_testData[25], false);
                        StringtextListD1E2M.AssertModel(models[13],_testData[26], false);
                        StringtextListD1E2M.AssertModel(models[14],_testData[27], false);
                        StringtextListD1E2M.AssertModel(models[15],_testData[28], false);
                        StringtextListD1E2M.AssertModel(models[16],_testData[29], false);
                        StringtextListD1E2M.AssertModel(models[17],_testData[30], false);
                        StringtextListD1E2M.AssertModel(models[18],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[19],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[20],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        StringtextListD1E2M.AssertModel(models[0],_testData[31], false);
                        StringtextListD1E2M.AssertModel(models[1],_testData[32], false);
                        StringtextListD1E2M.AssertModel(models[2],_testData[33], false);
                        StringtextListD1E2M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IStringListtextListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IStringListtextListD1)this).SetDbConnectionSelectModelParametrs(cmd, 45);
                var models = await ((IStringListtextListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                StringtextListD1E2M.AssertModel(models[0],_testData[6], false);
                StringtextListD1E2M.AssertModel(models[1],_testData[7], false);
                StringtextListD1E2M.AssertModel(models[2],_testData[8], false);
                StringtextListD1E2M.AssertModel(models[3],_testData[9], false);
                StringtextListD1E2M.AssertModel(models[4],_testData[10], false);
                StringtextListD1E2M.AssertModel(models[5],_testData[11], false);
                StringtextListD1E2M.AssertModel(models[6],_testData[12], false);
                StringtextListD1E2M.AssertModel(models[7],_testData[13], false);
                StringtextListD1E2M.AssertModel(models[8],_testData[14], false);
                StringtextListD1E2M.AssertModel(models[9],_testData[15], false);
                StringtextListD1E2M.AssertModel(models[10],_testData[16], false);
                StringtextListD1E2M.AssertModel(models[11],_testData[17], false);
                StringtextListD1E2M.AssertModel(models[12],_testData[18], false);
                StringtextListD1E2M.AssertModel(models[13],_testData[19], false);
                StringtextListD1E2M.AssertModel(models[14],_testData[20], false);
                StringtextListD1E2M.AssertModel(models[15],_testData[21], false);
                StringtextListD1E2M.AssertModel(models[16],_testData[22], false);
                StringtextListD1E2M.AssertModel(models[17],_testData[23], false);
                StringtextListD1E2M.AssertModel(models[18],_testData[24], false);
                StringtextListD1E2M.AssertModel(models[19],_testData[25], false);
                StringtextListD1E2M.AssertModel(models[20],_testData[26], false);
                StringtextListD1E2M.AssertModel(models[21],_testData[27], false);
                StringtextListD1E2M.AssertModel(models[22],_testData[28], false);
                StringtextListD1E2M.AssertModel(models[23],_testData[29], false);
                StringtextListD1E2M.AssertModel(models[24],_testData[30], false);
                StringtextListD1E2M.AssertModel(models[25],_testData[31], false);
                StringtextListD1E2M.AssertModel(models[26],_testData[32], false);
                StringtextListD1E2M.AssertModel(models[27],_testData[33], false);
                StringtextListD1E2M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IStringListtextListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IStringListtextListD1)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((IStringListtextListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                StringtextListD1E2M.AssertModel(models[0],_testData[21], false);
                StringtextListD1E2M.AssertModel(models[1],_testData[22], false);
                StringtextListD1E2M.AssertModel(models[2],_testData[23], false);
                StringtextListD1E2M.AssertModel(models[3],_testData[24], false);
                StringtextListD1E2M.AssertModel(models[4],_testData[25], false);
                StringtextListD1E2M.AssertModel(models[5],_testData[26], false);
                StringtextListD1E2M.AssertModel(models[6],_testData[27], false);
                StringtextListD1E2M.AssertModel(models[7],_testData[28], false);
                StringtextListD1E2M.AssertModel(models[8],_testData[29], false);
                StringtextListD1E2M.AssertModel(models[9],_testData[30], false);
                StringtextListD1E2M.AssertModel(models[10],_testData[31], false);
                StringtextListD1E2M.AssertModel(models[11],_testData[32], false);
                StringtextListD1E2M.AssertModel(models[12],_testData[33], false);
                StringtextListD1E2M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_stringtextlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(StringtextListD1E2MIWA),
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
            asPartInterface: typeof(IStringListtextListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringListtextListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringListtextListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringListtextListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringListtextListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_stringtextlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(StringtextListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringListtextListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_stringtextlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IStringListtextListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringListtextListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_stringtextlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IStringListtextListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_stringtextlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(StringtextListD1E2MI),
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
            asPartInterface: typeof(IStringListtextListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IStringListtextListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringListtextListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IStringListtextListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IStringListtextListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_stringtextlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(StringtextListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IStringListtextListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IStringListtextListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new StringtextListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IStringListtextListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IStringListtextListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_stringtextlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
stringtextlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(StringtextListD1E2M),
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
            asPartInterface: typeof(IStringListtextListD1))]
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
FROM public.binary_stringtextlistd1e2m m
LEFT JOIN public.binary_stringtextlistd1e2mi mi ON mi.id = m.stringtextlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<StringtextListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IStringListtextListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IStringListtextListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<StringtextListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IStringListtextListD1)this).ImportModel(connection, importCollection);
                var models = ((IStringListtextListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    StringtextListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    stringtextlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(StringtextListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models =  ((IStringListtextListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IStringListtextListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    StringtextListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA), typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models1 = new List<StringtextListD1E2MIWA>();
                var models2 = new List<StringtextListD1E2MIWA>();
                await ((IStringListtextListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextListD1E2MIWA>();
                var models2 = new List<StringtextListD1E2MIWA>();
                ((IStringListtextListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models = await ((IStringListtextListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_stringtextlistd1e2mi
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
                    StringtextListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IStringListtextListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_stringtextlistd1e2mi
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
                    StringtextListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA), typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
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
                var models1 = new List<StringtextListD1E2MIWA>();
                var models2 = new List<StringtextListD1E2MIWA>();
                await ((IStringListtextListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextListD1E2MIWA>();
                var models2 = new List<StringtextListD1E2MIWA>();
                ((IStringListtextListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_stringtextlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
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
                var models = await ((IStringListtextListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_stringtextlistd1e2mi
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
                    StringtextListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IStringListtextListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_stringtextlistd1e2mi
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
                    StringtextListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_stringtextlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MI), typeof(StringtextListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models1 = new List<StringtextListD1E2MI>();
                var models2 = new List<StringtextListD1E2MI>();
                await ((IStringListtextListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextListD1E2MI>();
                var models2 = new List<StringtextListD1E2MI>();
                ((IStringListtextListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1)),
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
                var models = await ((IStringListtextListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IStringListtextListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_stringtextlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA), typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
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
                var models1 = new List<StringtextListD1E2MIWA>();
                var models2 = new List<StringtextListD1E2MIWA>();
                await ((IStringListtextListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<StringtextListD1E2MIWA>();
                var models2 = new List<StringtextListD1E2MIWA>();
                ((IStringListtextListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_stringtextlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(StringtextListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringListtextListD1))]
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
                var models = await ((IStringListtextListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IStringListtextListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    StringtextListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

