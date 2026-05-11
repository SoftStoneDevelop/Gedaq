

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
    Id = 7,
    Value = 
new System.String[,] { {
"gfbnrbixqafqfuiwwqtedofxsgxbn",
"wjoduolawxcvvabtr", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.String[,] { {
"tdsqldwuoudnicr",
"ljagak", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"bgourgskoeocucisknxjeao",
"tksdyqopapedeqm", } },
},
            new StringMArrayD2E1M
{
    Id = 13,
    Value = 
new System.String[,] { {
"hbdqhxbg",
"ourglfqotulveuyjdjcewvboikkw", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.String[,] { {
"fqxibxvwxhlywmlrwtylmejy",
"jvvsfjsfjvtpwadsssmtilm", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"stxvxudqvxollljdabfihvjt",
"fdacxjgkio", } },
},
            new StringMArrayD2E1M
{
    Id = 21,
    Value = 
new System.String[,] { {
"hvglsplesy",
"qmnqgvyminisofnnsww", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.String[,] { {
"qdpsffksuphdfbgxsedvwi",
"raulhkaeceyo", } },
    NullableValue = 
new System.String[,] { {
"cqeutbjwhmtkhehwlcaydtipgdoh",
"jxxovdhssasnkelu", } },
},
    NullableValue = 
new System.String[,] { {
"cngbuppfqobn",
"ibtrej", } },
},
            new StringMArrayD2E1M
{
    Id = 24,
    Value = 
new System.String[,] { {
"qpkgsblcvppifnt",
"wdaqugavdaillbxsag", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.String[,] { {
"rneobuqvpkunwhcetaown",
"vnbitjn", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 28,
    Value = 
new System.String[,] { {
"ss",
"jhnvtnivjocxwjilarbbqxeliny", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.String[,] { {
"jbvfxuuffee",
"bcqxsgb", } },
    NullableValue = 
new System.String[,] { {
"gyvnrmpgvtl",
"erbsilrblqxbxudg", } },
},
    NullableValue = 
new System.String[,] { {
"qbjnwpydnihwpywtrakdp",
"jdjirb", } },
},
            new StringMArrayD2E1M
{
    Id = 33,
    Value = 
new System.String[,] { {
"gdlxnfuogy",
"ivfqpevtgkbtmt", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.String[,] { {
"uiqbrntnht",
"kenncdmsqmwppckbaosaekihrmpid", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 34,
    Value = 
new System.String[,] { {
"swycltdudsforbgkxqknlofvwc",
"qi", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.String[,] { {
"wqyyhpeebwmo",
"gmpcjesabumrkpq", } },
    NullableValue = 
new System.String[,] { {
"rjaospp",
"oktslytqbvykliynlncsokemor", } },
},
    NullableValue = 
new System.String[,] { {
"amfhgxuvlaswuulycwifhackhysh",
"nygey", } },
},
            new StringMArrayD2E1M
{
    Id = 35,
    Value = 
new System.String[,] { {
"usyh",
"qbfhxo", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.String[,] { {
"dhskbfqncqwixcfrnwkajlgjfd",
"ysp", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"kv",
"wgekt", } },
},
            new StringMArrayD2E1M
{
    Id = 43,
    Value = 
new System.String[,] { {
"rxgajvsd",
"iutvwvcjniyiawsa", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.String[,] { {
"eopactxixfa",
"wepbyewtfrymjrvovfekdklqircn", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"fggsqxuc",
"sqnidhyblfcyfjwuqtfn", } },
},
            new StringMArrayD2E1M
{
    Id = 52,
    Value = 
new System.String[,] { {
"rvihuqranscalofrfldlidvrfv",
"cqnjobwwfkyhtyvfgmpijmp", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.String[,] { {
"dfnyknhj",
"yxgbqci", } },
    NullableValue = 
new System.String[,] { {
"vdrffhciw",
"jbmbueghmfohy", } },
},
    NullableValue = 
new System.String[,] { {
"fvlfdjdbdswlidtyb",
"dxagpyqsusvtwnnhbrwkgmii", } },
},
            new StringMArrayD2E1M
{
    Id = 58,
    Value = 
new System.String[,] { {
"ohstguflpewfgjbji",
"lyglihioedpjsfctabvycagiwce", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.String[,] { {
"fyorhgbynihjvwthpsgwws",
"tpksihmgaleepgugcoljuc", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 66,
    Value = 
new System.String[,] { {
"yamlbbsoncxkblgte",
"mkpr", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.String[,] { {
"fxfledbmaeuadirxugqyrmpvevgr",
"jtpmemtfflpmkurrinrs", } },
    NullableValue = 
new System.String[,] { {
"hiyfpiifuokgrwubf",
"yiq", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 75,
    Value = 
new System.String[,] { {
"brdpsjbbbhhhkelajow",
"uowyjyskal", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.String[,] { {
"ma",
"hghtyechqfwb", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"rqvodundoqvnojttyknuvsuj",
"akrartyttwlunxp", } },
},
            new StringMArrayD2E1M
{
    Id = 81,
    Value = 
new System.String[,] { {
"julgdiatpnnwakibvidjyfoakw",
"by", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.String[,] { {
"skjvnu",
"mostgniysogdhgnddbebvcjvrnx", } },
    NullableValue = 
new System.String[,] { {
"lpwsylarpridym",
"qoyjgjqfqxfqphllfbgpoupav", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 82,
    Value = 
new System.String[,] { {
"b",
"avsmqxnjodmpajoxgbltebncjhip", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.String[,] { {
"oschhcsgbopa",
"", } },
    NullableValue = 
new System.String[,] { {
"njoaumpgdoeksg",
"kqmpjbuwccvahuqfbprugm", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 87,
    Value = 
new System.String[,] { {
"vemqlrgdap",
"lufgwwbsnfeccxvmikugqfpfhfh", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.String[,] { {
"rlmrpivfdapmt",
"frcfuffavaxqo", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"xklnaslwxdfwsocdipplbttrgshyj",
"phqxbkv", } },
},
            new StringMArrayD2E1M
{
    Id = 91,
    Value = 
new System.String[,] { {
"qgbanhdtjqctqidrhrxwgcniwo",
"ydy", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.String[,] { {
"gcingfswomjtxtigqnnc",
"ehpmkxiagptiwysmthaq", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"hhluxa",
"tjpbr", } },
},
            new StringMArrayD2E1M
{
    Id = 93,
    Value = 
new System.String[,] { {
"dgnjufimfqfgvgoatmqw",
"jud", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.String[,] { {
"s",
"givoqpyfgdsqmpxoojtqtmxpio", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 99,
    Value = 
new System.String[,] { {
"otuhfcytvuopt",
"oyurhiifafuhxn", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.String[,] { {
"mcto",
"ed", } },
    NullableValue = 
new System.String[,] { {
"nn",
"slfrymxaofhqvpmquqmpd", } },
},
    NullableValue = 
new System.String[,] { {
"jlgwjdcofyxwftpytki",
"oagxdnpixwkwrkelngogk", } },
},
            new StringMArrayD2E1M
{
    Id = 105,
    Value = 
new System.String[,] { {
"ipwkasmlcrvcpr",
"gmwhgyqeqyvoebiwduj", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 98,
    Value = 
new System.String[,] { {
"hwftesihg",
"xncekxkcoalkunnpcpvifaeg", } },
    NullableValue = null,
},
    NullableValue = 
new System.String[,] { {
"dgewowtybvvqbqeqbiqvfqom",
"vlvdadbogkvvntjr", } },
},
            new StringMArrayD2E1M
{
    Id = 114,
    Value = 
new System.String[,] { {
"aqyiptvybcw",
"oclwcoqmiufclgep", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.String[,] { {
"tcfrrtbwdlmespkcanwbmim",
"qjsbwtnywpwugghjndrwvjvd", } },
    NullableValue = 
new System.String[,] { {
"dcktcuvlacjuodkgmpcr",
"ajmlfpvmpqbpgeiivypwkc", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 122,
    Value = 
new System.String[,] { {
"pdlxqwbhiicgrxuhxt",
"uuk", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.String[,] { {
"ardhthbgkjkqfhwklrjxhdbxsag",
"ivipqsccfasxrifj", } },
    NullableValue = 
new System.String[,] { {
"kfbhdirohysqe",
"hx", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 128,
    Value = 
new System.String[,] { {
"cvbd",
"sucujgbrjaidv", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.String[,] { {
"akdlifpwsipeqyxtuydxlupdbw",
"uxgnbfffjcapfelyxb", } },
    NullableValue = 
new System.String[,] { {
"tsvufnyafjohxsehxxprkvlyn",
"nvu", } },
},
    NullableValue = 
new System.String[,] { {
"j",
"gsegqxcygfshjvkyyogqisqguqlee", } },
},
            new StringMArrayD2E1M
{
    Id = 135,
    Value = 
new System.String[,] { {
"fyabqtrnmoifxvoolvpnso",
"pkdwuurqljmejoj", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.String[,] { {
"pfebipbnyafqaylvtgjgpdh",
"btptpyholttt", } },
    NullableValue = 
new System.String[,] { {
"sdvctpveagkcihtopgxilxdofauop",
"irspkvblbcykvqdsc", } },
},
    NullableValue = 
new System.String[,] { {
"eftsbuwnres",
"hmbbgjn", } },
},
            new StringMArrayD2E1M
{
    Id = 141,
    Value = 
new System.String[,] { {
"u",
"thtvbwvhhtiohoodbghbhjgj", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.String[,] { {
"bayksdkjvxquwssi",
"thgnecxbyfnchvqdraxgdpl", } },
    NullableValue = 
new System.String[,] { {
"uwhhjlvyqnkrcto",
"dlmexuxuhffsnljr", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 144,
    Value = 
new System.String[,] { {
"wsmbgdrxuuphlntpthaanceluvnjj",
"kkwsppapqtqfruxsvopdtsdcvtsn", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 127,
    Value = 
new System.String[,] { {
"jjoopslfighqiphykurdscankdc",
"iiwrkkerqorihlgkjcpuiqinxpss", } },
    NullableValue = 
new System.String[,] { {
"tmhskgj",
"tuh", } },
},
    NullableValue = 
new System.String[,] { {
"jmqmm",
"a", } },
},
            new StringMArrayD2E1M
{
    Id = 146,
    Value = 
new System.String[,] { {
"cysflqwc",
"uopbgccng", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 129,
    Value = 
new System.String[,] { {
"fofsiggqesqrshg",
"nm", } },
    NullableValue = 
new System.String[,] { {
"rhumgefnsigldrvrluabnysa",
"xltmlculnwoxrxth", } },
},
    NullableValue = 
new System.String[,] { {
"nvjjkxoxchgjnodfmlivagwkk",
"yvydufsnmrh", } },
},
            new StringMArrayD2E1M
{
    Id = 148,
    Value = 
new System.String[,] { {
"tvovgldvjnrjwqppk",
"rypppvyttdalvsvykgmtdchwosmqa", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.String[,] { {
"qillrva",
"riwfrsrvlbavowyhqnftdyg", } },
    NullableValue = 
new System.String[,] { {
"jsxgcahcmb",
"bnodwfs", } },
},
    NullableValue = 
new System.String[,] { {
"mattdgbq",
"yogrjebuvkgttcuhrobh", } },
},
            new StringMArrayD2E1M
{
    Id = 154,
    Value = 
new System.String[,] { {
"sfaiuobimwfcuuhstwhqva",
"xdnxe", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.String[,] { {
"cocjf",
"ocogccjvvmjqwswhdxoyrllfwiymg", } },
    NullableValue = 
new System.String[,] { {
"",
"c", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 155,
    Value = 
new System.String[,] { {
"eda",
"pjxjahnginrliyq", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.String[,] { {
"vxasuccxiqtxcsadqdhbpco",
"uejnsfcnqlopeom", } },
    NullableValue = 
new System.String[,] { {
"cv",
"ds", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 159,
    Value = 
new System.String[,] { {
"lsehjeoanpi",
"sfggbwelcarsiyhcmkdtslgjiep", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.String[,] { {
"mcpkrjjasewoltbarxxfrhjd",
"ostmjbmqvxs", } },
    NullableValue = 
new System.String[,] { {
"sqhvm",
"dfqevswqhxk", } },
},
    NullableValue = 
new System.String[,] { {
"mhxbqiolrhhgslkgofvskdb",
"swdtflkjn", } },
},
            new StringMArrayD2E1M
{
    Id = 162,
    Value = 
new System.String[,] { {
"rqmbialnhpus",
"ilkviebnhcj", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.String[,] { {
"dajfpwmqkrshtairf",
"hiidupcpmccmxblqskljswmhqdovc", } },
    NullableValue = 
new System.String[,] { {
"xjsspfruc",
"oop", } },
},
    NullableValue = 
new System.String[,] { {
"vvackymbxcodrmweckqspk",
"ewojyisrqymdxd", } },
},
            new StringMArrayD2E1M
{
    Id = 165,
    Value = 
new System.String[,] { {
"puetdokrgturpbhbfdsbicxbyc",
"cjmvenkvdrvyoehvqtyhwbwv", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 163,
    Value = 
new System.String[,] { {
"vdtysv",
"whpmeyfrwxsaiiunrarvccofihu", } },
    NullableValue = 
new System.String[,] { {
"fsiqwsaejn",
"leiwvlnftxxb", } },
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 166,
    Value = 
new System.String[,] { {
"xgwr",
"tbighporhhajhmoe", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 170,
    Value = 
new System.String[,] { {
"prqmskhefcfsbj",
"", } },
    NullableValue = null,
},
    NullableValue = null,
},
            new StringMArrayD2E1M
{
    Id = 167,
    Value = 
new System.String[,] { {
"djvvhjdxfewckvwhqwbqdrdq",
"ehnygrbxmdpqkigrdpj", } },
    ModelInner = new StringMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.String[,] { {
"eeeasbdltkcnggklbhditnmmgmnk",
"jnfgundrcq", } },
    NullableValue = 
new System.String[,] { {
"mpvarxapx",
"rhnjcsmrvolimf", } },
},
    NullableValue = 
new System.String[,] { {
"kpbu",
"fqnrrhlyn", } },
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

