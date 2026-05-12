

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
    Id = 9,
    Value = "lkfjyqcklfca",
    ModelInner = new StringStringE0MI
{
    Id = 2,
    Value = "lknobedhdpphggmrpndif",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 14,
    Value = "uirdnlcrbsyrnkfdoiphtoblp",
    ModelInner = new StringStringE0MI
{
    Id = 9,
    Value = "wjkfsjj",
    NullableValue = "tflgdpiowf",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 16,
    Value = "gbhldbkecqyxue",
    ModelInner = new StringStringE0MI
{
    Id = 16,
    Value = "ftpyadnwmanweo",
    NullableValue = null,
},
    NullableValue = "pbd",
},
            new StringStringE0M
{
    Id = 21,
    Value = "posdnobspwgcielhcmipwerey",
    ModelInner = new StringStringE0MI
{
    Id = 20,
    Value = "gpwcsqghfoglygmantykvxkxabpv",
    NullableValue = "aprib",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 28,
    Value = "cfxpoajqubvgkybgbyoqosiojqqj",
    ModelInner = new StringStringE0MI
{
    Id = 29,
    Value = "hrcnoppnwmddivfymxoxp",
    NullableValue = null,
},
    NullableValue = "nrn",
},
            new StringStringE0M
{
    Id = 29,
    Value = "ykmbyrobjjsmmfedpcahq",
    ModelInner = new StringStringE0MI
{
    Id = 37,
    Value = "hroycu",
    NullableValue = "kdcrbtplubmteekcgehw",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 36,
    Value = "lgadmvjrnwjxkkkfpywuu",
    ModelInner = new StringStringE0MI
{
    Id = 41,
    Value = "ygfcayrpe",
    NullableValue = null,
},
    NullableValue = "vbogemkmcfxgwabc",
},
            new StringStringE0M
{
    Id = 44,
    Value = "itijyotce",
    ModelInner = new StringStringE0MI
{
    Id = 43,
    Value = "phtqmbfhearnnobjgwggdfuqbtf",
    NullableValue = null,
},
    NullableValue = "qcqmvptvnp",
},
            new StringStringE0M
{
    Id = 45,
    Value = "jpdcdnyoymnnqfsdfefkeqbvcu",
    ModelInner = new StringStringE0MI
{
    Id = 45,
    Value = "ofuxkib",
    NullableValue = "jniqg",
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 48,
    Value = "jbtajosidmmrlshwimkyx",
    ModelInner = new StringStringE0MI
{
    Id = 52,
    Value = "cbqiyrpggjxlf",
    NullableValue = "skyshccrotcrws",
},
    NullableValue = "ysptwjcrtlpveldfyppedoepyxs",
},
            new StringStringE0M
{
    Id = 54,
    Value = "ujbwqqfjnsncd",
    ModelInner = new StringStringE0MI
{
    Id = 58,
    Value = "uxseksf",
    NullableValue = "cfvsfmp",
},
    NullableValue = "dwwxmjijosvbby",
},
            new StringStringE0M
{
    Id = 61,
    Value = "gspackywgwy",
    ModelInner = new StringStringE0MI
{
    Id = 61,
    Value = "vep",
    NullableValue = "wvguvgaywvwx",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 70,
    Value = "rnjkcssk",
    ModelInner = new StringStringE0MI
{
    Id = 65,
    Value = "ppaplxnrfvuipsomlkhupkm",
    NullableValue = "prjyxplepdlekpauxwanmtcwsr",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 76,
    Value = "jdvunggwclsldodfiqhfvtear",
    ModelInner = new StringStringE0MI
{
    Id = 66,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 85,
    Value = "se",
    ModelInner = new StringStringE0MI
{
    Id = 69,
    Value = "llkffmcijfqralxvfggxgsxlpfim",
    NullableValue = "iohyxukhvhssjyxepwmukmx",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 92,
    Value = "cydkqluqlwwaxrvqnxiusyleijwm",
    ModelInner = new StringStringE0MI
{
    Id = 73,
    Value = "xhnxipx",
    NullableValue = null,
},
    NullableValue = "veb",
},
            new StringStringE0M
{
    Id = 98,
    Value = "vvvpowqcnoue",
    ModelInner = new StringStringE0MI
{
    Id = 77,
    Value = "xnshjidbqstigkaflybssrt",
    NullableValue = "aghbxbtuilyimkbtxkwfdlevcq",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 107,
    Value = "my",
    ModelInner = new StringStringE0MI
{
    Id = 84,
    Value = "bgaphfrglinmggevqectbabnc",
    NullableValue = "oaxoun",
},
    NullableValue = "ltgkadorcpdoaddjmnerglokac",
},
            new StringStringE0M
{
    Id = 111,
    Value = "ynyqjvuksre",
    ModelInner = new StringStringE0MI
{
    Id = 86,
    Value = "kiyjnekporercynvkbdcbgrguv",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 118,
    Value = "wifnjpwfduahbqsijbssfoke",
    ModelInner = new StringStringE0MI
{
    Id = 92,
    Value = "lyttsosun",
    NullableValue = "dxgdhnxepskwngsbtmpsi",
},
    NullableValue = "ehrxfblgvxl",
},
            new StringStringE0M
{
    Id = 121,
    Value = "wmqlkegg",
    ModelInner = new StringStringE0MI
{
    Id = 98,
    Value = "qtqxbqsv",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 125,
    Value = "weyinkeuordunmxajnltpb",
    ModelInner = new StringStringE0MI
{
    Id = 105,
    Value = "qkhdyllqcuhocpjamevmw",
    NullableValue = "byhunnubwypqqim",
},
    NullableValue = "tvwipgldxqasjselamkokcofiqe",
},
            new StringStringE0M
{
    Id = 133,
    Value = "sbumvnrwq",
    ModelInner = new StringStringE0MI
{
    Id = 113,
    Value = "gxewuwrpqkfefps",
    NullableValue = "saluskfjpsshpfqriihnpoo",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 137,
    Value = "mejhibunhxhqjbnowjyusjsnball",
    ModelInner = new StringStringE0MI
{
    Id = 117,
    Value = "lfrtrhrqmxxqc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 139,
    Value = "ugexdb",
    ModelInner = new StringStringE0MI
{
    Id = 123,
    Value = "vspldgyhasifo",
    NullableValue = "cgrlmybjtxjutjgm",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 147,
    Value = "ofrwdynsscxmssfxkrfqxsfubnl",
    ModelInner = new StringStringE0MI
{
    Id = 127,
    Value = "aawsjisoudbfjjakhnvfftostswx",
    NullableValue = "pt",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 149,
    Value = "rmkpuivhdiauevkjgfceotlgpifkv",
    ModelInner = new StringStringE0MI
{
    Id = 136,
    Value = "gkegtfeuduihsdpvxcb",
    NullableValue = null,
},
    NullableValue = "twr",
},
            new StringStringE0M
{
    Id = 158,
    Value = "lsyahaolysjroshd",
    ModelInner = new StringStringE0MI
{
    Id = 144,
    Value = "dvawwildmmkkrjhwi",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 161,
    Value = "jciitxu",
    ModelInner = new StringStringE0MI
{
    Id = 150,
    Value = "tetkjyxmbdgimfvqumthmjgcfa",
    NullableValue = "xoyiygsocfouflaoxesjxuiikr",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 162,
    Value = "lusuejctpyno",
    ModelInner = new StringStringE0MI
{
    Id = 153,
    Value = "vhyiysuggcokjobwqbedmco",
    NullableValue = "ywhvbqldlrqwr",
},
    NullableValue = "nflkxmsbjlnqcvhrmoea",
},
            new StringStringE0M
{
    Id = 167,
    Value = "rx",
    ModelInner = new StringStringE0MI
{
    Id = 155,
    Value = "u",
    NullableValue = "kghjlnbr",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 173,
    Value = "gblpqtedy",
    ModelInner = new StringStringE0MI
{
    Id = 164,
    Value = "arxfgumigljfxfsuhwhcmeemuest",
    NullableValue = null,
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 179,
    Value = "fjiemhjmcvrgsknvngovwkdnaqqw",
    ModelInner = new StringStringE0MI
{
    Id = 166,
    Value = "wtgjebicxwamidhdiewguto",
    NullableValue = "mwghobvjepkspkjapomvtrkicv",
},
    NullableValue = "nys",
},
            new StringStringE0M
{
    Id = 183,
    Value = "vxsdrypn",
    ModelInner = new StringStringE0MI
{
    Id = 173,
    Value = "rtlwie",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 192,
    Value = "gdtqltmqemrcjergekbkth",
    ModelInner = new StringStringE0MI
{
    Id = 176,
    Value = "isoydjlmonkli",
    NullableValue = "dfyyuerlkmcwnrowuird",
},
    NullableValue = "",
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

