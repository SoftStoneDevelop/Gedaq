

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
    Id = 7,
    Value = "pohev",
    ModelInner = new StringStringE0MI
{
    Id = 6,
    Value = "sfa",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 14,
    Value = "sphavudwioraa",
    ModelInner = new StringStringE0MI
{
    Id = 10,
    Value = "swxvmdueykyvkex",
    NullableValue = null,
},
    NullableValue = "qbpfglq",
},
            new StringStringE0M
{
    Id = 22,
    Value = "ebgggqgmodt",
    ModelInner = new StringStringE0MI
{
    Id = 18,
    Value = "adbvjegblkvkjst",
    NullableValue = "mnsavp",
},
    NullableValue = "fcickanwmrunlonwdyqko",
},
            new StringStringE0M
{
    Id = 28,
    Value = "cipwmkdmqcrjqi",
    ModelInner = new StringStringE0MI
{
    Id = 22,
    Value = "aokfxwrtjdffulgnfjmohvmmaqkrm",
    NullableValue = "mrhghlutxdrneeroyvltofklv",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 31,
    Value = "kvt",
    ModelInner = new StringStringE0MI
{
    Id = 31,
    Value = "guwtxfnvouyjmxhojpkoumgcirk",
    NullableValue = "rwhnpvecalejypcfmfc",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 38,
    Value = "dllpekycjdghtmusvsjiasmsnscce",
    ModelInner = new StringStringE0MI
{
    Id = 39,
    Value = "sbtvldtvk",
    NullableValue = "qbtfxkdiui",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 42,
    Value = "aewpaatccvqcvttbytmkfoqg",
    ModelInner = new StringStringE0MI
{
    Id = 48,
    Value = "",
    NullableValue = null,
},
    NullableValue = "cvfxvipitqvmtwrscsqwd",
},
            new StringStringE0M
{
    Id = 49,
    Value = "l",
    ModelInner = new StringStringE0MI
{
    Id = 52,
    Value = "kqylpcpkvpnofk",
    NullableValue = null,
},
    NullableValue = "dxnga",
},
            new StringStringE0M
{
    Id = 54,
    Value = "jaxnieakrjw",
    ModelInner = new StringStringE0MI
{
    Id = 53,
    Value = "kiykhlxqcrbjwgvaokytathnuyg",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 57,
    Value = "rvbhxiw",
    ModelInner = new StringStringE0MI
{
    Id = 54,
    Value = "",
    NullableValue = null,
},
    NullableValue = "qmguyvjmccj",
},
            new StringStringE0M
{
    Id = 63,
    Value = "uguyloacfcvbpketehxqovt",
    ModelInner = new StringStringE0MI
{
    Id = 55,
    Value = "becg",
    NullableValue = "keuqvxmjlqtccxmaqtxd",
},
    NullableValue = "jvpplpvavmpabgrvcqlcflwuelnha",
},
            new StringStringE0M
{
    Id = 65,
    Value = "xqmy",
    ModelInner = new StringStringE0MI
{
    Id = 62,
    Value = "bbkxjaqtloknuyjxein",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 66,
    Value = "ywifdbnrqba",
    ModelInner = new StringStringE0MI
{
    Id = 65,
    Value = "fxqytdyuug",
    NullableValue = null,
},
    NullableValue = "unxksbelflswxsp",
},
            new StringStringE0M
{
    Id = 70,
    Value = "x",
    ModelInner = new StringStringE0MI
{
    Id = 67,
    Value = "oahxrbyhrvwqxgedighfpm",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 73,
    Value = "bycgikxqstobxqtinxyg",
    ModelInner = new StringStringE0MI
{
    Id = 74,
    Value = "uhejjylhroakecwyjxgmmp",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 75,
    Value = "qmkbearggm",
    ModelInner = new StringStringE0MI
{
    Id = 82,
    Value = "tqbxbxrcbxalqodajc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 81,
    Value = "yjnuyboiosqsaibvkrk",
    ModelInner = new StringStringE0MI
{
    Id = 85,
    Value = "hkugnbennminthedtasyqmmmc",
    NullableValue = "pnmctrl",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 85,
    Value = "jsqcfqdd",
    ModelInner = new StringStringE0MI
{
    Id = 91,
    Value = "ytaauvfvfnotmtbkgkderf",
    NullableValue = "we",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 87,
    Value = "ddib",
    ModelInner = new StringStringE0MI
{
    Id = 93,
    Value = "sooyjbsmycjwi",
    NullableValue = "gjhgddbtvguldrgsk",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 94,
    Value = "shkpspgaxlsxpmoplbvtukfyykfx",
    ModelInner = new StringStringE0MI
{
    Id = 101,
    Value = "hpnyf",
    NullableValue = null,
},
    NullableValue = "amxmrkjnmlxjfbvvqmjw",
},
            new StringStringE0M
{
    Id = 102,
    Value = "nmwi",
    ModelInner = new StringStringE0MI
{
    Id = 102,
    Value = "amupkkfagoeff",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 108,
    Value = "rtubhqgevifcantkxbhvid",
    ModelInner = new StringStringE0MI
{
    Id = 107,
    Value = "ycsmjtuuatabxjpwdjsobre",
    NullableValue = null,
},
    NullableValue = "mshwjqjmvufooibfiehwo",
},
            new StringStringE0M
{
    Id = 113,
    Value = "bsvqelgbwfif",
    ModelInner = new StringStringE0MI
{
    Id = 114,
    Value = "gfbxgmtdqe",
    NullableValue = "syinajstygommbsyjly",
},
    NullableValue = "bvwuusouxwlprjuh",
},
            new StringStringE0M
{
    Id = 121,
    Value = "pnnaxrsxx",
    ModelInner = new StringStringE0MI
{
    Id = 118,
    Value = "gtqu",
    NullableValue = "srhbtwhjfxsradsweqynkpldo",
},
    NullableValue = "xbsrtqoqytgud",
},
            new StringStringE0M
{
    Id = 128,
    Value = "sdgbwxksqkpkkdgvpuvlbxkn",
    ModelInner = new StringStringE0MI
{
    Id = 120,
    Value = "hkfmsmce",
    NullableValue = "jkrscmgmfegd",
},
    NullableValue = "qacjgifo",
},
            new StringStringE0M
{
    Id = 131,
    Value = "iohgrjdt",
    ModelInner = new StringStringE0MI
{
    Id = 124,
    Value = "ihsltxoxbfuyawqbggnwengprd",
    NullableValue = null,
},
    NullableValue = "sxdjlapgox",
},
            new StringStringE0M
{
    Id = 133,
    Value = "eleuphxavsduxvxyyuoq",
    ModelInner = new StringStringE0MI
{
    Id = 129,
    Value = "ujqmgmsxyaldmv",
    NullableValue = "vwbedsm",
},
    NullableValue = "jtywntpebfi",
},
            new StringStringE0M
{
    Id = 135,
    Value = "viw",
    ModelInner = new StringStringE0MI
{
    Id = 137,
    Value = "d",
    NullableValue = null,
},
    NullableValue = "wel",
},
            new StringStringE0M
{
    Id = 136,
    Value = "jspdcofuhvwbfbrwa",
    ModelInner = new StringStringE0MI
{
    Id = 144,
    Value = "swxdlurhctmqyoyea",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 144,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 153,
    Value = "j",
    NullableValue = "ockhk",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 145,
    Value = "ofvsrqtngsgtfqebhhvdxpmdr",
    ModelInner = new StringStringE0MI
{
    Id = 162,
    Value = "g",
    NullableValue = "eawlayytkyviubaxyoamtu",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 151,
    Value = "pahprmihpilcujhbmic",
    ModelInner = new StringStringE0MI
{
    Id = 166,
    Value = "ajcfqsp",
    NullableValue = "vqifbimehk",
},
    NullableValue = "rc",
},
            new StringStringE0M
{
    Id = 157,
    Value = "khgpr",
    ModelInner = new StringStringE0MI
{
    Id = 170,
    Value = "afjixyyeyjnmxltmicdpcdwlgqdnb",
    NullableValue = "unsgyhefodbtjwml",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 160,
    Value = "h",
    ModelInner = new StringStringE0MI
{
    Id = 175,
    Value = "smqxdptrrecwh",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 169,
    Value = "juevjivbppwxl",
    ModelInner = new StringStringE0MI
{
    Id = 183,
    Value = "epdtyaabdqwchibtxgw",
    NullableValue = null,
},
    NullableValue = "getwvnrncxmpsyopm",
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

