

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

        private readonly StringString0M[] _testData = new StringString0M[]
        {
            new StringString0M
{
    Id = 3,
    Value = "csutcfuulxybtywoxjllas",
    ModelInner = new StringString0MI
{
    Id = 4,
    Value = "yrxc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 11,
    Value = "mopdgfvdrsskr",
    ModelInner = new StringString0MI
{
    Id = 12,
    Value = "hmrsiykrifejadcnuhp",
    NullableValue = "qtrpchosatadixsxvtlucnw",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 12,
    Value = "gi",
    ModelInner = new StringString0MI
{
    Id = 20,
    Value = "hntnppk",
    NullableValue = null,
},
    NullableValue = "nljvhwojkuvkfggxxdogqlucpg",
},
            new StringString0M
{
    Id = 13,
    Value = "vxjgrbcfmgykclmhe",
    ModelInner = new StringString0MI
{
    Id = 26,
    Value = "vgofi",
    NullableValue = "cjjjqdixquohopbfmetgudxu",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 16,
    Value = "ahvwktiwoy",
    ModelInner = new StringString0MI
{
    Id = 32,
    Value = "bjsklpeh",
    NullableValue = "ehoqdbpgopp",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 24,
    Value = "dgcnacijscj",
    ModelInner = new StringString0MI
{
    Id = 34,
    Value = "rrlhfvqiuju",
    NullableValue = null,
},
    NullableValue = "pfpyecxvsdusrucimxsfxackmok",
},
            new StringString0M
{
    Id = 31,
    Value = "wavcfybpslqpoejbifaqx",
    ModelInner = new StringString0MI
{
    Id = 38,
    Value = "x",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 38,
    Value = "agpxvvcpoywlnfjpucag",
    ModelInner = new StringString0MI
{
    Id = 43,
    Value = "jcnxsjrmixhfrfcohfacdjonk",
    NullableValue = "vljushdygwcxhu",
},
    NullableValue = "nds",
},
            new StringString0M
{
    Id = 40,
    Value = "bp",
    ModelInner = new StringString0MI
{
    Id = 48,
    Value = "mfbimarccasfxrddkcepb",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 48,
    Value = "bubhnaurevmkivvd",
    ModelInner = new StringString0MI
{
    Id = 55,
    Value = "esidnwaalkgatxdggewygyjvnh",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 53,
    Value = "ippfrtlreddvwyqbpunkvlbcuk",
    ModelInner = new StringString0MI
{
    Id = 63,
    Value = "thl",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 61,
    Value = "oiuevhpcferehbhmdsiiwxo",
    ModelInner = new StringString0MI
{
    Id = 70,
    Value = "ldldfyystwstmrs",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 62,
    Value = "cxfkplyjuidkkwpea",
    ModelInner = new StringString0MI
{
    Id = 72,
    Value = "trignfrfqcsmdmnxao",
    NullableValue = "dgknwovineylhgvydffxyplnl",
},
    NullableValue = "tekpsuatbkqpdbyngokdsie",
},
            new StringString0M
{
    Id = 65,
    Value = "",
    ModelInner = new StringString0MI
{
    Id = 76,
    Value = "ranpwejdbmtddjtt",
    NullableValue = null,
},
    NullableValue = "trtuyjnfnljdmkqscsf",
},
            new StringString0M
{
    Id = 73,
    Value = "vrjqlq",
    ModelInner = new StringString0MI
{
    Id = 79,
    Value = "oai",
    NullableValue = "ubtnoovujeswgundyxgyfg",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 74,
    Value = "estupjtqabrplrv",
    ModelInner = new StringString0MI
{
    Id = 82,
    Value = "hv",
    NullableValue = null,
},
    NullableValue = "hrpncwfbwgekvgbtog",
},
            new StringString0M
{
    Id = 80,
    Value = "visymcitlacrrtweyhvnnesoxjdyr",
    ModelInner = new StringString0MI
{
    Id = 85,
    Value = "fjkunrq",
    NullableValue = "jahmvtirmvn",
},
    NullableValue = "bvpvqhnldcqexqim",
},
            new StringString0M
{
    Id = 82,
    Value = "isysngxelvjva",
    ModelInner = new StringString0MI
{
    Id = 94,
    Value = "blfcq",
    NullableValue = null,
},
    NullableValue = "ogqdvjdgumrgqialp",
},
            new StringString0M
{
    Id = 88,
    Value = "hqpjhhlybdin",
    ModelInner = new StringString0MI
{
    Id = 96,
    Value = "jo",
    NullableValue = null,
},
    NullableValue = "lbpuobhltmlpmxlsat",
},
            new StringString0M
{
    Id = 90,
    Value = "vpwexofyf",
    ModelInner = new StringString0MI
{
    Id = 101,
    Value = "jlfxnuqeinuvuuemi",
    NullableValue = "rlbmsxhntgfaxdqpqf",
},
    NullableValue = "ek",
},
            new StringString0M
{
    Id = 94,
    Value = "wegjlbaefqmkjwunkvtjoev",
    ModelInner = new StringString0MI
{
    Id = 109,
    Value = "hbbhtoqxfjo",
    NullableValue = "fnmjifyo",
},
    NullableValue = "caiwjykgfcegrpfkr",
},
            new StringString0M
{
    Id = 96,
    Value = "cppeqahh",
    ModelInner = new StringString0MI
{
    Id = 114,
    Value = "jakvkdyivmnomchefkygyacx",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 97,
    Value = "fowxu",
    ModelInner = new StringString0MI
{
    Id = 123,
    Value = "idllcnmomorogrjjir",
    NullableValue = "sty",
},
    NullableValue = "ahpnuhfqgchwrdj",
},
            new StringString0M
{
    Id = 98,
    Value = "egoyixwntm",
    ModelInner = new StringString0MI
{
    Id = 130,
    Value = "jxgygjqnxugoebh",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 101,
    Value = "arnsqwwcwchmqctafgnmtaxkpbc",
    ModelInner = new StringString0MI
{
    Id = 138,
    Value = "gntlfrxnentyeuwd",
    NullableValue = null,
},
    NullableValue = "kpiqlpdpfvtm",
},
            new StringString0M
{
    Id = 106,
    Value = "fabggondv",
    ModelInner = new StringString0MI
{
    Id = 147,
    Value = "pjkqrqmbncryuvedfrebuceddhr",
    NullableValue = null,
},
    NullableValue = "qjckbggovdenrnj",
},
            new StringString0M
{
    Id = 115,
    Value = "taxavumqcxymwxdlhmuobdnbdkeuk",
    ModelInner = new StringString0MI
{
    Id = 155,
    Value = "jffcxoclvkimbptgrninr",
    NullableValue = null,
},
    NullableValue = "toangluhjwbadcmounxqkrc",
},
            new StringString0M
{
    Id = 121,
    Value = "dubgwauxvrfjn",
    ModelInner = new StringString0MI
{
    Id = 163,
    Value = "estitdmnvlkmmmdkdq",
    NullableValue = "uhhymacvobmknmegvdst",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 123,
    Value = "ghkhxbnhxtnslir",
    ModelInner = new StringString0MI
{
    Id = 170,
    Value = "bfxfrsbrklivtime",
    NullableValue = null,
},
    NullableValue = "djrwgsiyitcjorqktitacgf",
},
            new StringString0M
{
    Id = 130,
    Value = "",
    ModelInner = new StringString0MI
{
    Id = 176,
    Value = "qwthmfwethivchuhyieifegjshyj",
    NullableValue = null,
},
    NullableValue = "uryo",
},
            new StringString0M
{
    Id = 139,
    Value = "igsinubensngctx",
    ModelInner = new StringString0MI
{
    Id = 177,
    Value = "wksmvvaufrvujvpytdgapatrwe",
    NullableValue = null,
},
    NullableValue = "rocedgakk",
},
            new StringString0M
{
    Id = 143,
    Value = "gyjmdupwjvf",
    ModelInner = new StringString0MI
{
    Id = 179,
    Value = "mhdenoitbuianavfvtoxwaqhpciww",
    NullableValue = "ietat",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 144,
    Value = "vhlwujftdojhvqu",
    ModelInner = new StringString0MI
{
    Id = 186,
    Value = "boumbuajjmudixmqt",
    NullableValue = null,
},
    NullableValue = "nxijhxntorgtpuyh",
},
            new StringString0M
{
    Id = 151,
    Value = "oowfko",
    ModelInner = new StringString0MI
{
    Id = 188,
    Value = "wbsi",
    NullableValue = "",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 154,
    Value = "gxq",
    ModelInner = new StringString0MI
{
    Id = 192,
    Value = "hnviorhcoolnj",
    NullableValue = "vfmkl",
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.stringstring0m(
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
FROM gedaqtests.stringstring0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(StringString0M)],
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
                    StringString0M.AssertModel(models[0],_testData[i], false);
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
                    StringString0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

