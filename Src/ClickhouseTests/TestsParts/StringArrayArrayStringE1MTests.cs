

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
    internal partial interface IStringMArrayArrayArrayString
    {
    }
    
    internal partial class StringMArrayArrayArrayString : IStringMArrayArrayArrayString
    {


#region TestData

        private readonly StringArrayArrayStringE1M[] _testData = new StringArrayArrayStringE1M[]
        {
            new StringArrayArrayStringE1M
{
    Id = 2,
    Value = 
new System.String[,] { {
"csyidmribvodopgirhysle",
"spliacl", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 6,
    Value = 
new System.String[,] { {
"wvsvtwfllxpfrdsukiormf",
"", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 7,
    Value = 
new System.String[,] { {
"yfongqohoppxtupuiuluvebgelca",
"gokyxacggqafuv", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 9,
    Value = 
new System.String[,] { {
"jmiuje",
"jjlxaafavevkbem", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 12,
    Value = 
new System.String[,] { {
"dwlfjbv",
"nqwdpp", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 14,
    Value = 
new System.String[,] { {
"cwmtwxhtktyolghophsq",
"sqfneydepydrefhpbsbtmefno", } },
    NullableValue = 
new System.String[,] { {
"ypbnkaxsppspcija",
"uvwdfhgvhvfyvgmgcxnlg", } },
},
    NullableValue = 
new System.String[,] { {
"jhkfxygures",
"olwrkhojmyiap", } },
},
            new StringArrayArrayStringE1M
{
    Id = 20,
    Value = 
new System.String[,] { {
"nyxirdjnocojneaerxuidsgyl",
"jathsjmhcjbvvnnverrxkyrhxx", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 19,
    Value = 
new System.String[,] { {
"glwjcqfr",
"wrwyovvftnxpw", } },
    NullableValue = 
new System.String[,] { {
"wwnmlcmwwgkadvfijevt",
"pddmyqkdnjamnqovdaj", } },
},
    NullableValue = 
new System.String[,] { {
"nheqegcxikedyuumbihkrerub",
"olvsxeqdftcwajnx", } },
},
            new StringArrayArrayStringE1M
{
    Id = 21,
    Value = 
new System.String[,] { {
"qwarkhowejlowycihuy",
"xlyvpifav", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 25,
    Value = 
new System.String[,] { {
"sleuhjcwwegcagm",
"vlmysdwkgrt", } },
    NullableValue = 
new System.String[,] { {
"jlrjwujbywuqkrxm",
"ugpfspkmxanx", } },
},
    NullableValue = 
new System.String[,] { {
"byslscdrwixwocbgq",
"porbmrpfipxatqxk", } },
},
            new StringArrayArrayStringE1M
{
    Id = 30,
    Value = 
new System.String[,] { {
"yrsxuhpefvymdheibnpaegerqg",
"nqjveoqkng", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 27,
    Value = 
new System.String[,] { {
"xkfbjfgvqloaaqpqsyhiw",
"minxdtwmhp", } },
    NullableValue = 
new System.String[,] { {
"qdgrvbkugxptlixsdvys",
"fyeqxslvdgfadaqexrmxqyj", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 35,
    Value = 
new System.String[,] { {
"ibryfot",
"", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 34,
    Value = 
new System.String[,] { {
"hkvqkshwhqbdxsmlccdmf",
"mdrbkyndvdrqac", } },
    NullableValue = 
new System.String[,] { {
"cmk",
"bvsylwnrtxblwknthpiycwlhwx", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 37,
    Value = 
new System.String[,] { {
"vypqvlqpkjokwnsflbedqtdgekavu",
"kuwkm", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 40,
    Value = 
new System.String[,] { {
"ki",
"cwlckscwq", } },
    NullableValue = 
new System.String[,] { {
"vq",
"uayrbwskxjodypquhkyrkowqhv", } },
},
    NullableValue = 
new System.String[,] { {
"ocfvisdgbbdn",
"nhkoriqemppurkoblewqbtftjbos", } },
},
            new StringArrayArrayStringE1M
{
    Id = 44,
    Value = 
new System.String[,] { {
"fyiukpgdxcwyskmeqxj",
"ekmaffvltuitnggmrkg", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 45,
    Value = 
new System.String[,] { {
"jfelsxaqjwotcmn",
"fc", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"",
"n", } },
},
            new StringArrayArrayStringE1M
{
    Id = 49,
    Value = 
new System.String[,] { {
"laxfrmajepvatmexfb",
"jmwuvwwrxedgowbcadowlt", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 50,
    Value = 
new System.String[,] { {
"axwfbehgjkftyrlhkxlmeyyearmd",
"wklgsmdyg", } },
    NullableValue = 
new System.String[,] { {
"kbkurwtadlbk",
"xhetrotyvec", } },
},
    NullableValue = 
new System.String[,] { {
"aiwlvnukqei",
"himl", } },
},
            new StringArrayArrayStringE1M
{
    Id = 56,
    Value = 
new System.String[,] { {
"vbvboqhsxriktlwsex",
"l", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 56,
    Value = 
new System.String[,] { {
"asasqrwtcxdxfsbb",
"", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"fvrnigytxsdcw",
"witbdqf", } },
},
            new StringArrayArrayStringE1M
{
    Id = 61,
    Value = 
new System.String[,] { {
"g",
"msapbvdobqanncnopksewd", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 65,
    Value = 
new System.String[,] { {
"hhqdoeidkroq",
"w", } },
    NullableValue = 
new System.String[,] { {
"rvsvoqdjy",
"", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 64,
    Value = 
new System.String[,] { {
"umtnftryjlutfmdnihdgdwh",
"eewgkdvhtuebxdmdknnom", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 67,
    Value = 
new System.String[,] { {
"ilyenvgjo",
"aayhst", } },
    NullableValue = 
new System.String[,] { {
"ygajyjlbple",
"jpyshebkupjdexb", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 69,
    Value = 
new System.String[,] { {
"ukpfmphrxcvkqetvtloddxukj",
"gpxjqeyuanlagpurhndmokvosip", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 76,
    Value = 
new System.String[,] { {
"yxqywsbctonbgemrmkra",
"siogpgwhkjmhjetgcb", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"vlgcncunshv",
"reookaafhrlq", } },
},
            new StringArrayArrayStringE1M
{
    Id = 72,
    Value = 
new System.String[,] { {
"ogxppdrbwbsynsbyutgqqrgwjmee",
"xdknosdbisrjkrjagl", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 83,
    Value = 
new System.String[,] { {
"ky",
"gsjcxuwdexvcahvwhmeyshmpie", } },
    NullableValue = 
new System.String[,] { {
"rggspqaopfnxyxwtibf",
"qmkppfqtadmirdsjijfofjulyd", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 81,
    Value = 
new System.String[,] { {
"pgawjlporbqmcvxxk",
"whajynkwsiskotdfcemvrilpalb", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 89,
    Value = 
new System.String[,] { {
"nubdheirieshrxyfbxce",
"ajjtfhlyftvgnwjdlyfuqll", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"vjaytpvkgwjbrptuqq",
"hryslwpwplataomucblf", } },
},
            new StringArrayArrayStringE1M
{
    Id = 85,
    Value = 
new System.String[,] { {
"gjetjmbtpfuvhboxiwsg",
"bytibvrnxwfeiscfeajtgfnebgt", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 92,
    Value = 
new System.String[,] { {
"cbjfmuoiymngcvcohjtqx",
"exxmgsocicwouifdhdmaflfgtjyw", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 86,
    Value = 
new System.String[,] { {
"ipljnveefevksccc",
"ujrteajusppfttnsuehyyxk", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 93,
    Value = 
new System.String[,] { {
"yihk",
"lmayvgmrot", } },
    NullableValue = 
new System.String[,] { {
"mvyfoacjybb",
"osjjakxvjhgjcdcof", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 92,
    Value = 
new System.String[,] { {
"",
"hkxiydomxyxdsuqnkssqlb", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 95,
    Value = 
new System.String[,] { {
"xkkq",
"pxbhttyogseefrdnogsoxffx", } },
    NullableValue = 
new System.String[,] { {
"jajaviuwocncw",
"yowuxoiuuscy", } },
},
    NullableValue = 
new System.String[,] { {
"rwxoqkbvcpg",
"lggqitlmnaaxkg", } },
},
            new StringArrayArrayStringE1M
{
    Id = 94,
    Value = 
new System.String[,] { {
"daoiwq",
"tdlikrrckiwvjqkupqoxhi", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 104,
    Value = 
new System.String[,] { {
"lbawhisjemuyji",
"l", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 99,
    Value = 
new System.String[,] { {
"xnloswgblcbmubxhhhfeyolwmyxn",
"qgvhmcyynk", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 108,
    Value = 
new System.String[,] { {
"ketkt",
"oxyuygrlgthsfojvywfdejid", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"ugbnkshcdbjfjdvcw",
"oaswm", } },
},
            new StringArrayArrayStringE1M
{
    Id = 107,
    Value = 
new System.String[,] { {
"jtriiyyxbpbrk",
"odbwvlvhcioqmewmrsreeyxn", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 110,
    Value = 
new System.String[,] { {
"tfctfbyjcw",
"cxigugvn", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 111,
    Value = 
new System.String[,] { {
"ncgmhdgawegstgmaxibsrngdkmv",
"mfmmgfiulyfsgkokequrjvyngtymt", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 118,
    Value = 
new System.String[,] { {
"odttqqwpunturdikcmxxbjyiq",
"ngafxbsbyxvopcautndtv", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 119,
    Value = 
new System.String[,] { {
"pkvgeslwdd",
"rdfspjgvtjwjwsbitbicyb", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 121,
    Value = 
new System.String[,] { {
"ggndfbygehaheftbqlb",
"oqyby", } },
    NullableValue = 
new System.String[,] { {
"d",
"llaowunptjkasexeva", } },
},
    NullableValue = 
new System.String[,] { {
"sywmouxntodacoewmkcdqq",
"cflxclh", } },
},
            new StringArrayArrayStringE1M
{
    Id = 126,
    Value = 
new System.String[,] { {
"ikhhyesnj",
"hjhofciwhwvirytytla", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 130,
    Value = 
new System.String[,] { {
"cmlolcalmn",
"qoicsbmnmbusg", } },
    NullableValue = 
new System.String[,] { {
"skitimrumusvo",
"afbclbookj", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 131,
    Value = 
new System.String[,] { {
"",
"ajmai", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 134,
    Value = 
new System.String[,] { {
"ncen",
"afqwxgac", } },
    NullableValue = 
new System.String[,] { {
"dbydvlqrnwoigvfcsrasn",
"nkk", } },
},
    NullableValue = 
new System.String[,] { {
"w",
"ktvhafxhcevjxyeyybpdtw", } },
},
            new StringArrayArrayStringE1M
{
    Id = 132,
    Value = 
new System.String[,] { {
"ctnnwfai",
"qkintxofjixiabogk", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 141,
    Value = 
new System.String[,] { {
"lsmexyngwnpapnxsn",
"ai", } },
    NullableValue = 
new System.String[,] { {
"nbqkunfkmvcsrtqnyiwydtahjsha",
"mcipnsvdifwxskqqrmmsohoq", } },
},
    NullableValue = 
new System.String[,] { {
"msnrto",
"roxjjkxveqnvljevjujn", } },
},
            new StringArrayArrayStringE1M
{
    Id = 141,
    Value = 
new System.String[,] { {
"kjxqbsb",
"irrhkk", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 147,
    Value = 
new System.String[,] { {
"jxposnwwwcsclsekm",
"yomqvkdeat", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 145,
    Value = 
new System.String[,] { {
"yygjwojmcmtanklnfeq",
"syyy", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 150,
    Value = 
new System.String[,] { {
"qmlvislaurwbogqnaspiigvwqqpye",
"ayneotuhl", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 150,
    Value = 
new System.String[,] { {
"nedfowgwuenwcynsbnp",
"ecprhivutpdbnp", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 156,
    Value = 
new System.String[,] { {
"ydyudohcxrms",
"kwnxmcfjrrewhusjnupngedrmdpng", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"gxqvyuguhcvx",
"jqfoyibbofoiawjypvoytgrhmahg", } },
},
            new StringArrayArrayStringE1M
{
    Id = 159,
    Value = 
new System.String[,] { {
"fyjsgmqfhwghmamodjqxnjthvom",
"edofsgwdolbmxfhwcecmyxkp", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 165,
    Value = 
new System.String[,] { {
"labvdtrdnlpgsuksbueseq",
"rsqdvvpac", } },
    NullableValue = 
new System.String[,] { {
"dybdtgeagjgrcesaw",
"kixratwlyaiq", } },
},
    NullableValue = null,
},
            new StringArrayArrayStringE1M
{
    Id = 162,
    Value = 
new System.String[,] { {
"tnkgkkbkbgssvunakhbaakqddfyv",
"ngnxnqprocyomnoyp", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 173,
    Value = 
new System.String[,] { {
"dtgexgqqcmr",
"srkwutoumkfskks", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"cxmbbrwphrcnxogcblfexuy",
"vuhuvksdwtcvoujrsfcsdnlvuqk", } },
},
            new StringArrayArrayStringE1M
{
    Id = 165,
    Value = 
new System.String[,] { {
"rjddj",
"wfxtujxbdcv", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 179,
    Value = 
new System.String[,] { {
"tlaoasijiiwxnfayxynveeeaux",
"pudkgxdimftrmhixrgimxyyoi", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"prvhestvamhojfspcqoalgrcaiaig",
"tukrhqtfdxufvggrb", } },
},
            new StringArrayArrayStringE1M
{
    Id = 174,
    Value = 
new System.String[,] { {
"ksecfgekmor",
"qfitbtiesvplltn", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 182,
    Value = 
new System.String[,] { {
"yvuxhhnlfblpb",
"rgbchncgidvlqrliewoegyaixuj", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"ppokhalddbk",
"ycngpdpuqoxobujhsngkqqjooxvcl", } },
},
            new StringArrayArrayStringE1M
{
    Id = 183,
    Value = 
new System.String[,] { {
"uxfdky",
"cfdwodtqjsojvknkmgy", } },
    ModelInner = new StringArrayArrayString1MI
{
    Id = 183,
    Value = 
new System.String[,] { {
"oixiehngsmr",
"bepvc", } },
    NullableValue = 
new System.String[,] { {
"qrtk",
"luhprdtplhaohratf", } },
},
    NullableValue = 
new System.String[,] { {
"rwjrntjqwxpfrljwhnghnobalhqq",
"vvmwtknlgavhyvry", } },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringarrayarraystringe1m(
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
            asPartInterface: typeof(IStringMArrayArrayArrayString)),
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
                    await ((IStringMArrayArrayArrayString)this).InsertModelDbConnectionAsync(
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
                     ((IStringMArrayArrayArrayString)this).InsertModelDbConnection(
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
FROM gedaqtests.stringarrayarraystringe1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringArrayArrayStringE1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringMArrayArrayArrayString)),
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
                    var models = await ((IStringMArrayArrayArrayString)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringArrayArrayStringE1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IStringMArrayArrayArrayString)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringArrayArrayStringE1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

