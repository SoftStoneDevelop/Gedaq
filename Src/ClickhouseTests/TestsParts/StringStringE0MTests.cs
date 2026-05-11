

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
    Id = 8,
    Value = "ymwkfxnjprbyibclaintcg",
    ModelInner = new StringStringE0MI
{
    Id = 4,
    Value = "otwosrahwkcwyswrisxukxqp",
    NullableValue = "sa",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 12,
    Value = "qqdfpt",
    ModelInner = new StringStringE0MI
{
    Id = 9,
    Value = "qtpkvecr",
    NullableValue = "figbiltsmrhlsluby",
},
    NullableValue = "afblxfuqcptpgsu",
},
            new StringStringE0M
{
    Id = 15,
    Value = "fnbjusrhtbicgr",
    ModelInner = new StringStringE0MI
{
    Id = 17,
    Value = "pmaujysuilnhykuogscxpbfq",
    NullableValue = null,
},
    NullableValue = "mydxhgdpkoye",
},
            new StringStringE0M
{
    Id = 18,
    Value = "bncwavpquhrdltmsmosaxuraydyl",
    ModelInner = new StringStringE0MI
{
    Id = 20,
    Value = "meerlubsgldkyx",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 20,
    Value = "tbuqehsbuboq",
    ModelInner = new StringStringE0MI
{
    Id = 23,
    Value = "mksggtu",
    NullableValue = null,
},
    NullableValue = "cla",
},
            new StringStringE0M
{
    Id = 21,
    Value = "rycyrvwjkijtslx",
    ModelInner = new StringStringE0MI
{
    Id = 28,
    Value = "onvibhhtuwoytfhfdsfp",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 27,
    Value = "fwtfupxofytethtlgimclskrrf",
    ModelInner = new StringStringE0MI
{
    Id = 31,
    Value = "afwdihjahkahntqalhi",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 29,
    Value = "xijxyixoqgsydbdxc",
    ModelInner = new StringStringE0MI
{
    Id = 37,
    Value = "jdppoedsaufqst",
    NullableValue = "fngqphreuofoxxuuca",
},
    NullableValue = "pcrectnhghwrhflvnvjol",
},
            new StringStringE0M
{
    Id = 31,
    Value = "cwilgcprojinxlhdvn",
    ModelInner = new StringStringE0MI
{
    Id = 42,
    Value = "cinmruwlpijewwtxiekqicoparx",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 33,
    Value = "banxsgsxgwpkbnhpyosxoyssfl",
    ModelInner = new StringStringE0MI
{
    Id = 44,
    Value = "himeq",
    NullableValue = "yxgapjc",
},
    NullableValue = "igrtsecpsjyrsrfmpcgfb",
},
            new StringStringE0M
{
    Id = 39,
    Value = "ejjtbejhjjsqjogprerlgkxkhiq",
    ModelInner = new StringStringE0MI
{
    Id = 48,
    Value = "qujxlyymea",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 42,
    Value = "nqpcm",
    ModelInner = new StringStringE0MI
{
    Id = 49,
    Value = "tcjexydwubgrvhlyobinme",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 47,
    Value = "mrspxobrbvvvqplvocerrqfjscgo",
    ModelInner = new StringStringE0MI
{
    Id = 50,
    Value = "mrvkgslpmpyfbijckfmscjam",
    NullableValue = "pmeexehffywxbi",
},
    NullableValue = "gnameenidkoetvfxxwugg",
},
            new StringStringE0M
{
    Id = 56,
    Value = "murireotwe",
    ModelInner = new StringStringE0MI
{
    Id = 55,
    Value = "hfuuksi",
    NullableValue = "riuleympftsghvfrv",
},
    NullableValue = "dcdlbjgtfhd",
},
            new StringStringE0M
{
    Id = 60,
    Value = "kbewsadcnis",
    ModelInner = new StringStringE0MI
{
    Id = 59,
    Value = "hcoafwemerypauiqoyouam",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 61,
    Value = "wadxh",
    ModelInner = new StringStringE0MI
{
    Id = 60,
    Value = "fk",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 64,
    Value = "ho",
    ModelInner = new StringStringE0MI
{
    Id = 68,
    Value = "xqofuexwreo",
    NullableValue = "kcbfrnyrpsdwpcsxeddp",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 68,
    Value = "jpanvtmyhnbgg",
    ModelInner = new StringStringE0MI
{
    Id = 73,
    Value = "tivgvjcsfnhpr",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 70,
    Value = "yctim",
    ModelInner = new StringStringE0MI
{
    Id = 80,
    Value = "bopdhppcyk",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 73,
    Value = "wi",
    ModelInner = new StringStringE0MI
{
    Id = 81,
    Value = "sxmaguvxiiynacayxt",
    NullableValue = null,
},
    NullableValue = "brcavio",
},
            new StringStringE0M
{
    Id = 76,
    Value = "u",
    ModelInner = new StringStringE0MI
{
    Id = 82,
    Value = "prjbqkxumfmyofmkdgdqw",
    NullableValue = null,
},
    NullableValue = "fsyte",
},
            new StringStringE0M
{
    Id = 83,
    Value = "vhqwmscjumsbcfj",
    ModelInner = new StringStringE0MI
{
    Id = 88,
    Value = "onyvfqsmtwpilqwtqvlmecy",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 85,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 93,
    Value = "qowwpltpjfghgcefeu",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 89,
    Value = "fvrsibyrifcchsbylxvvxsqa",
    ModelInner = new StringStringE0MI
{
    Id = 102,
    Value = "oio",
    NullableValue = "jtseq",
},
    NullableValue = "crugccoqoeqqfhuexsnbp",
},
            new StringStringE0M
{
    Id = 91,
    Value = "puchokmlxgdxdo",
    ModelInner = new StringStringE0MI
{
    Id = 110,
    Value = "gmgyxmrcusiowvmmqhxsce",
    NullableValue = null,
},
    NullableValue = "rljavwulsxwtdlefdw",
},
            new StringStringE0M
{
    Id = 100,
    Value = "xextpufrgwlccmihpfma",
    ModelInner = new StringStringE0MI
{
    Id = 116,
    Value = "kcmtmx",
    NullableValue = "p",
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 108,
    Value = "htyjmmlpxwjblab",
    ModelInner = new StringStringE0MI
{
    Id = 118,
    Value = "fkygrlpnefqrdjpyh",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 117,
    Value = "vgmvtby",
    ModelInner = new StringStringE0MI
{
    Id = 119,
    Value = "wevassllgdqpohiedsttmjt",
    NullableValue = null,
},
    NullableValue = "lp",
},
            new StringStringE0M
{
    Id = 126,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 128,
    Value = "ukfuequaadywjckfmppx",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 135,
    Value = "rlyplvdcwkdiyfuie",
    ModelInner = new StringStringE0MI
{
    Id = 137,
    Value = "k",
    NullableValue = "bwlmnrugriowxvea",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 138,
    Value = "madfugaou",
    ModelInner = new StringStringE0MI
{
    Id = 143,
    Value = "xwgppotknqvqrpy",
    NullableValue = "fjfofjqmfgdnycldyemvxt",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 147,
    Value = "ymmv",
    ModelInner = new StringStringE0MI
{
    Id = 144,
    Value = "ckppetvfcttsbtxnsvfx",
    NullableValue = "auugkaelhnweowwssftjtsbn",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 154,
    Value = "oi",
    ModelInner = new StringStringE0MI
{
    Id = 147,
    Value = "rpskjhcmspxbb",
    NullableValue = null,
},
    NullableValue = "p",
},
            new StringStringE0M
{
    Id = 155,
    Value = "yyibaacynild",
    ModelInner = new StringStringE0MI
{
    Id = 156,
    Value = "ngqbwgvehurrtlkds",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 162,
    Value = "kjolmckabqnodnblonjcrkjrwvkmg",
    ModelInner = new StringStringE0MI
{
    Id = 163,
    Value = "iwky",
    NullableValue = "luxugkpsebkrmysnjhxwnknaeyrw",
},
    NullableValue = "rtjvttsloqjaa",
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

