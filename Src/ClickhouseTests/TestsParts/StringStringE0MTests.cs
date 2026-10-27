

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
    internal partial interface IStringSingleTypeString
    {
    }
    
    internal partial class StringSingleTypeString : IStringSingleTypeString
    {


#region TestData

        private readonly StringStringE0M[] _testData = new StringStringE0M[]
        {
            new StringStringE0M
{
    Id = 6,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 1,
    Value = "xmbjxfvkclorikgwy",
    NullableValue = "eki",
},
    NullableValue = "tooctfiyqfxarjm",
},
            new StringStringE0M
{
    Id = 11,
    Value = "fhectvyrmutepkcxgst",
    ModelInner = new StringStringE0MI
{
    Id = 8,
    Value = "",
    NullableValue = "kmd",
},
    NullableValue = "vhwbibgfjouibj",
},
            new StringStringE0M
{
    Id = 15,
    Value = "f",
    ModelInner = new StringStringE0MI
{
    Id = 13,
    Value = "ihdcrjg",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 21,
    Value = "qlgyhifwkvjovijwutuylyrpkmji",
    ModelInner = new StringStringE0MI
{
    Id = 20,
    Value = "bebbdwjfbn",
    NullableValue = null,
},
    NullableValue = "pwtjlkyxhpqculconj",
},
            new StringStringE0M
{
    Id = 28,
    Value = "m",
    ModelInner = new StringStringE0MI
{
    Id = 22,
    Value = "nu",
    NullableValue = "oqdevcecgkvdtdrdseg",
},
    NullableValue = "rkeqegdyyoxuknfrtwf",
},
            new StringStringE0M
{
    Id = 31,
    Value = "goqisjwgeodfgndxmmrtxfhgnbgp",
    ModelInner = new StringStringE0MI
{
    Id = 25,
    Value = "vao",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 35,
    Value = "fvtabksadlowfwidujjvb",
    ModelInner = new StringStringE0MI
{
    Id = 30,
    Value = "rveubuinguo",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 41,
    Value = "vwhvmiikiirbryyjaqybtftpg",
    ModelInner = new StringStringE0MI
{
    Id = 38,
    Value = "mehmxfflqsqpqbmaysrqvmoauo",
    NullableValue = "ostixp",
},
    NullableValue = "ensyw",
},
            new StringStringE0M
{
    Id = 50,
    Value = "mqrfjvjplaknlpqoltqyi",
    ModelInner = new StringStringE0MI
{
    Id = 47,
    Value = "b",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 54,
    Value = "wybidojpbmluqk",
    ModelInner = new StringStringE0MI
{
    Id = 55,
    Value = "kgrfmxwxmpmbgixjl",
    NullableValue = null,
},
    NullableValue = "dsyvdavssbgpbi",
},
            new StringStringE0M
{
    Id = 57,
    Value = "wabtyufiihuplgkjjfpkvkh",
    ModelInner = new StringStringE0MI
{
    Id = 60,
    Value = "caasdfdcs",
    NullableValue = null,
},
    NullableValue = "shhiw",
},
            new StringStringE0M
{
    Id = 65,
    Value = "wllnopivuxnmlflfbfchrtibesfav",
    ModelInner = new StringStringE0MI
{
    Id = 68,
    Value = "jsfshdkblnufgkfrtf",
    NullableValue = "stichyfmqxc",
},
    NullableValue = "vjihmdkkfikvtso",
},
            new StringStringE0M
{
    Id = 70,
    Value = "djdtwucmemgygibquoufb",
    ModelInner = new StringStringE0MI
{
    Id = 76,
    Value = "reegcqnjeexthxjgsejic",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 74,
    Value = "ogofjggxrwwlaalykd",
    ModelInner = new StringStringE0MI
{
    Id = 79,
    Value = "fjowm",
    NullableValue = null,
},
    NullableValue = "nf",
},
            new StringStringE0M
{
    Id = 78,
    Value = "vjvrnmvvtkswn",
    ModelInner = new StringStringE0MI
{
    Id = 80,
    Value = "tx",
    NullableValue = "wmfisdmyhgwrfmrbfofrv",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 87,
    Value = "jovvunsmejgiqjd",
    ModelInner = new StringStringE0MI
{
    Id = 86,
    Value = "uajyhwnirnilloycxxyptn",
    NullableValue = "eqoapcgjvfpjjhnoruab",
},
    NullableValue = "tkwvbndbrkqfvywdtixdkhkn",
},
            new StringStringE0M
{
    Id = 94,
    Value = "hm",
    ModelInner = new StringStringE0MI
{
    Id = 89,
    Value = "odyxgttdnyqhcdcpypxjldybdeb",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 101,
    Value = "cfufohflkdorua",
    ModelInner = new StringStringE0MI
{
    Id = 95,
    Value = "dnweikxfhv",
    NullableValue = "bqxsvskqejyjemdscovjsjwglplbm",
},
    NullableValue = "bx",
},
            new StringStringE0M
{
    Id = 102,
    Value = "csiuqbftgjxf",
    ModelInner = new StringStringE0MI
{
    Id = 98,
    Value = "baxyvgjqsptnrycdvtvgupgff",
    NullableValue = "iljeai",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 103,
    Value = "waoopgjubn",
    ModelInner = new StringStringE0MI
{
    Id = 106,
    Value = "ome",
    NullableValue = null,
},
    NullableValue = "xvvqcxpoisayomowicc",
},
            new StringStringE0M
{
    Id = 108,
    Value = "bbryjpxhkxepfawvmigeooev",
    ModelInner = new StringStringE0MI
{
    Id = 112,
    Value = "a",
    NullableValue = "q",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 117,
    Value = "kqtffvupdvvtmdeectunf",
    ModelInner = new StringStringE0MI
{
    Id = 115,
    Value = "irmbapupqtlmbclcxxvnukfdraux",
    NullableValue = null,
},
    NullableValue = "vrboebexpthorgakfpkq",
},
            new StringStringE0M
{
    Id = 126,
    Value = "ocmrbqlab",
    ModelInner = new StringStringE0MI
{
    Id = 116,
    Value = "tbjvphhmmbqwdjiuu",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 127,
    Value = "hhecqmvdsohlcmvfgqepe",
    ModelInner = new StringStringE0MI
{
    Id = 121,
    Value = "k",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 132,
    Value = "rpdj",
    ModelInner = new StringStringE0MI
{
    Id = 129,
    Value = "qavepxrgyfbyqjbvtksj",
    NullableValue = null,
},
    NullableValue = "kaebyhnrhvwimxsdjyvuvh",
},
            new StringStringE0M
{
    Id = 138,
    Value = "gkxiksavtowswmcm",
    ModelInner = new StringStringE0MI
{
    Id = 137,
    Value = "",
    NullableValue = null,
},
    NullableValue = "ajc",
},
            new StringStringE0M
{
    Id = 145,
    Value = "rjytdlfph",
    ModelInner = new StringStringE0MI
{
    Id = 145,
    Value = "ttgihxlsyefoaocnneo",
    NullableValue = null,
},
    NullableValue = "jxwdyptutsxp",
},
            new StringStringE0M
{
    Id = 151,
    Value = "mnctwntanoygvihymtyauhpa",
    ModelInner = new StringStringE0MI
{
    Id = 153,
    Value = "fpcm",
    NullableValue = "iyt",
},
    NullableValue = "mpncoohiacnkhuspxtsab",
},
            new StringStringE0M
{
    Id = 160,
    Value = "emnr",
    ModelInner = new StringStringE0MI
{
    Id = 162,
    Value = "mojcprrjyxtokvufrwxwumhigdq",
    NullableValue = "tvmikfhjneqwyfoelsunjvtmdjfd",
},
    NullableValue = "worhanigejepqsebdogtwm",
},
            new StringStringE0M
{
    Id = 166,
    Value = "nqlctusfgljhfkmujtkmaisj",
    ModelInner = new StringStringE0MI
{
    Id = 168,
    Value = "mhnowuegtj",
    NullableValue = "ktaydxucddunggoibbogm",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 173,
    Value = "nswec",
    ModelInner = new StringStringE0MI
{
    Id = 173,
    Value = "dpmcqawupewlkbokxk",
    NullableValue = "ggmwvbqvoxouneq",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 176,
    Value = "cjus",
    ModelInner = new StringStringE0MI
{
    Id = 176,
    Value = "aqofkfsawxavthfqdtpqgvinjyiyh",
    NullableValue = "irfcpxhdbgwrqkxewbacyqoyqr",
},
    NullableValue = "crqypms",
},
            new StringStringE0M
{
    Id = 177,
    Value = "mpqhklptxdtcbqibxx",
    ModelInner = new StringStringE0MI
{
    Id = 181,
    Value = "otcldvqdxlyca",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 180,
    Value = "bppexpreqchncu",
    ModelInner = new StringStringE0MI
{
    Id = 185,
    Value = "jifdvpt",
    NullableValue = "aumbmeiawjnxmcfvrbeamaxxcun",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 188,
    Value = "ajjydseqv",
    ModelInner = new StringStringE0MI
{
    Id = 190,
    Value = "upqdfguogvlcsvlnqjsdoeauh",
    NullableValue = "aetmriyptxadnig",
},
    NullableValue = "eqtxejb",
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringstringe0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:String}, 
    {mi_id:Int32},
    {mi_value:String}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypeString)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.String), 
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
                    await ((IStringSingleTypeString)this).InsertModelDbConnectionAsync(
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
                     ((IStringSingleTypeString)this).InsertModelDbConnection(
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
FROM gedaqtests.stringstringe0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringStringE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IStringSingleTypeString)),
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
                    var models = await ((IStringSingleTypeString)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringStringE0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IStringSingleTypeString)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    StringStringE0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

