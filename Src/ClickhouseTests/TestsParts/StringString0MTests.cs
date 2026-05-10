

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
    Id = 6,
    Value = "qskibsstvvo",
    ModelInner = new StringString0MI
{
    Id = 5,
    Value = "ydjv",
    NullableValue = null,
},
    NullableValue = "ikflqql",
},
            new StringString0M
{
    Id = 10,
    Value = "nbdvmt",
    ModelInner = new StringString0MI
{
    Id = 10,
    Value = "lbnounmykmkfitlmcovnbl",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 16,
    Value = "qrcifmhjpg",
    ModelInner = new StringString0MI
{
    Id = 13,
    Value = "bauyhjxtgmtquqatkuy",
    NullableValue = "wpkjbtdrwbyxugehspafiydtyqrsl",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 18,
    Value = "dvnw",
    ModelInner = new StringString0MI
{
    Id = 20,
    Value = "dtvsgajwstjxdrfebneovbew",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 27,
    Value = "dpxrkhhgdrtssrfdnunasaorxp",
    ModelInner = new StringString0MI
{
    Id = 21,
    Value = "vyhqjdpynpmul",
    NullableValue = "uuevsgqwdiaqfgewbcicjxgw",
},
    NullableValue = "ieqvqtdk",
},
            new StringString0M
{
    Id = 33,
    Value = "squonirmxpexmcfeisch",
    ModelInner = new StringString0MI
{
    Id = 22,
    Value = "qfvvkywmnwgjlaaacdrgpk",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 37,
    Value = "idhfrhnscrruntnpqgdmyokjlsp",
    ModelInner = new StringString0MI
{
    Id = 29,
    Value = "ojirkrnsteyxasdcu",
    NullableValue = null,
},
    NullableValue = "ylsxokj",
},
            new StringString0M
{
    Id = 42,
    Value = "ptbntwid",
    ModelInner = new StringString0MI
{
    Id = 38,
    Value = "sgbmpbwoflxkeopsyc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 50,
    Value = "thxmnlthgcah",
    ModelInner = new StringString0MI
{
    Id = 47,
    Value = "",
    NullableValue = "kmxjqnsllphifx",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 53,
    Value = "oneerfeqynriderpof",
    ModelInner = new StringString0MI
{
    Id = 50,
    Value = "kjwfssbboqkysrwfnwaqmugshka",
    NullableValue = "odk",
},
    NullableValue = "cienmftjmdmjqxvoh",
},
            new StringString0M
{
    Id = 54,
    Value = "olunovnrenscvvtxmxbvanapmhe",
    ModelInner = new StringString0MI
{
    Id = 56,
    Value = "dctnemrnj",
    NullableValue = "rxfowdtwvvjlxsquuctfkmrkyrcq",
},
    NullableValue = "arvxyawgaljicfpyndwoqahu",
},
            new StringString0M
{
    Id = 57,
    Value = "sejljwctajmxp",
    ModelInner = new StringString0MI
{
    Id = 58,
    Value = "xolayty",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 65,
    Value = "itenuvtnjdqwyylhnhvohueuqw",
    ModelInner = new StringString0MI
{
    Id = 63,
    Value = "trkpetkyfcggaryqhvlpnlqd",
    NullableValue = "ifsyyeblxiltki",
},
    NullableValue = "obiycwgyypayrkhsebyqvtfappu",
},
            new StringString0M
{
    Id = 67,
    Value = "rjwlhjlvafymvsuqpiixcaqibjcn",
    ModelInner = new StringString0MI
{
    Id = 72,
    Value = "jiukxmhjo",
    NullableValue = "d",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 68,
    Value = "myeowxptwnqnqfufafrqaevnonm",
    ModelInner = new StringString0MI
{
    Id = 81,
    Value = "chdekpeowyaxhpyp",
    NullableValue = "lwslvm",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 72,
    Value = "lflkdjbclfq",
    ModelInner = new StringString0MI
{
    Id = 86,
    Value = "tpmumjccgtbqdrinpfnysoxcykov",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 73,
    Value = "ob",
    ModelInner = new StringString0MI
{
    Id = 94,
    Value = "qlni",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 80,
    Value = "algybjatophqwdvyfh",
    ModelInner = new StringString0MI
{
    Id = 98,
    Value = "htecvh",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 82,
    Value = "xwn",
    ModelInner = new StringString0MI
{
    Id = 102,
    Value = "fttjnntm",
    NullableValue = null,
},
    NullableValue = "thjphglbsxffiuygsvrmysnm",
},
            new StringString0M
{
    Id = 89,
    Value = "uaosattwi",
    ModelInner = new StringString0MI
{
    Id = 111,
    Value = "uasrvhlnyhogcmdkkdbqlt",
    NullableValue = "wf",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 95,
    Value = "bipnopkylvtdfvckh",
    ModelInner = new StringString0MI
{
    Id = 120,
    Value = "ulgpdmxyprymqoxpdfcfbc",
    NullableValue = null,
},
    NullableValue = "xcuhy",
},
            new StringString0M
{
    Id = 102,
    Value = "bcpqahtncs",
    ModelInner = new StringString0MI
{
    Id = 123,
    Value = "psdcavrtpfqfsugfmdtliaeeb",
    NullableValue = "fhdvfbudwtqxemhlvprwwhf",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 103,
    Value = "jailnuduamofuybvys",
    ModelInner = new StringString0MI
{
    Id = 129,
    Value = "vewxdlioawbuudjduicekif",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 112,
    Value = "iqfkryhvivketabgeflpdhsvepqwp",
    ModelInner = new StringString0MI
{
    Id = 133,
    Value = "wxhvuv",
    NullableValue = null,
},
    NullableValue = "dwylnyrjvlfyleoyojagymbrge",
},
            new StringString0M
{
    Id = 117,
    Value = "gmupupilnpwdfcgcymggo",
    ModelInner = new StringString0MI
{
    Id = 142,
    Value = "ofyahuq",
    NullableValue = null,
},
    NullableValue = "hlduiyfarqnqobxe",
},
            new StringString0M
{
    Id = 125,
    Value = "effumlnhpgvjb",
    ModelInner = new StringString0MI
{
    Id = 147,
    Value = "pmqjhylarltipgnhg",
    NullableValue = null,
},
    NullableValue = "mjocpmxlfptuh",
},
            new StringString0M
{
    Id = 127,
    Value = "jypmqyrmlanapilysjebdkueysadn",
    ModelInner = new StringString0MI
{
    Id = 149,
    Value = "ppqwkmmlsmahkqvfaoovwd",
    NullableValue = null,
},
    NullableValue = "xpomuq",
},
            new StringString0M
{
    Id = 135,
    Value = "bybarxpadqrbtcpmdjqueh",
    ModelInner = new StringString0MI
{
    Id = 150,
    Value = "dxcasjrhrjj",
    NullableValue = "ujpogoywyxwdjobltvajp",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 138,
    Value = "pnwvivypuwkpjctxiitcgnyyarmx",
    ModelInner = new StringString0MI
{
    Id = 157,
    Value = "myqmblrkiektrqhyvuhbgtvyfp",
    NullableValue = "cbobejjtcovsdiltssxuxy",
},
    NullableValue = "rtdomadbwiuyqgc",
},
            new StringString0M
{
    Id = 140,
    Value = "fcwysxbfyji",
    ModelInner = new StringString0MI
{
    Id = 165,
    Value = "scnrobbfmqyiwckoewjeakimv",
    NullableValue = "hrkspckfvamdswy",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 144,
    Value = "ewppmbagdoseiqtjjduvmywlj",
    ModelInner = new StringString0MI
{
    Id = 166,
    Value = "pdbjgkrqvynmmqtsavwtsivb",
    NullableValue = "qb",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 153,
    Value = "ngslawbacqauymyd",
    ModelInner = new StringString0MI
{
    Id = 167,
    Value = "inxweixeyrixiyntgdcelyu",
    NullableValue = null,
},
    NullableValue = "fejfw",
},
            new StringString0M
{
    Id = 159,
    Value = "jlxotldddkjhuyd",
    ModelInner = new StringString0MI
{
    Id = 170,
    Value = "tvoynvlsygje",
    NullableValue = "qsqnxtumguvmcx",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 167,
    Value = "jiunjyrowfwvkgkssfkrhiuthtlg",
    ModelInner = new StringString0MI
{
    Id = 173,
    Value = "lsreg",
    NullableValue = null,
},
    NullableValue = "finfjpmkbhckn",
},
            new StringString0M
{
    Id = 175,
    Value = "efbmnrjxxbphiam",
    ModelInner = new StringString0MI
{
    Id = 178,
    Value = "nsjxppc",
    NullableValue = "ybigmrasgubkuomvnnir",
},
    NullableValue = "nlhaftjsyjtpcsknkrf",
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

