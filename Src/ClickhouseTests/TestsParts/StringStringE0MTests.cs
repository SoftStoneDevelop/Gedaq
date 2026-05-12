

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
    Value = "hlpvweirhivh",
    ModelInner = new StringStringE0MI
{
    Id = 7,
    Value = "ygrxdwqhfebhms",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 9,
    Value = "dpgddjbjxjemxijwhd",
    ModelInner = new StringStringE0MI
{
    Id = 15,
    Value = "aohtfcccxqrmqmixvwdltjgeol",
    NullableValue = "awhyhxduhudhveeeokvmjppkk",
},
    NullableValue = "jqiil",
},
            new StringStringE0M
{
    Id = 17,
    Value = "g",
    ModelInner = new StringStringE0MI
{
    Id = 17,
    Value = "awwcsxfqxttskovj",
    NullableValue = "xhxti",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 20,
    Value = "iluejga",
    ModelInner = new StringStringE0MI
{
    Id = 23,
    Value = "qmpyp",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 27,
    Value = "bjyhbymoynbkoomysbqrxp",
    ModelInner = new StringStringE0MI
{
    Id = 27,
    Value = "rttw",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 34,
    Value = "ikmlqardhywdbbkoeqmim",
    ModelInner = new StringStringE0MI
{
    Id = 34,
    Value = "hsgyvmlqlfkkvmohuclrvqy",
    NullableValue = null,
},
    NullableValue = "x",
},
            new StringStringE0M
{
    Id = 42,
    Value = "gjsmkxwbtmvrvmmgkxabesrbclww",
    ModelInner = new StringStringE0MI
{
    Id = 36,
    Value = "jwtmedmujsoulo",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 46,
    Value = "jqogjbbl",
    ModelInner = new StringStringE0MI
{
    Id = 40,
    Value = "dsqvmypjcjmgnvqyysw",
    NullableValue = null,
},
    NullableValue = "uvjpiyoeopwtqjsnufitkjmkt",
},
            new StringStringE0M
{
    Id = 51,
    Value = "bvmcfufiggwcvufr",
    ModelInner = new StringStringE0MI
{
    Id = 49,
    Value = "iq",
    NullableValue = "danhhmsjoliawgcoyhbli",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 57,
    Value = "sdbboxmpcxaxdnlfddrn",
    ModelInner = new StringStringE0MI
{
    Id = 55,
    Value = "rgftgtwtqtrrt",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 64,
    Value = "qxnuoddjnmi",
    ModelInner = new StringStringE0MI
{
    Id = 61,
    Value = "wqvaovsgtuwg",
    NullableValue = "kyse",
},
    NullableValue = "xglem",
},
            new StringStringE0M
{
    Id = 69,
    Value = "yxllqdkxbtebf",
    ModelInner = new StringStringE0MI
{
    Id = 70,
    Value = "sjywfomdobckvgimospclmfgkex",
    NullableValue = null,
},
    NullableValue = "bjfqipymwxfxdqstrckbidkvullur",
},
            new StringStringE0M
{
    Id = 71,
    Value = "thbpfbsxxtlksqagprworyly",
    ModelInner = new StringStringE0MI
{
    Id = 78,
    Value = "kflgmcrx",
    NullableValue = "ptvxckjuvtbawrmdfcbloomf",
},
    NullableValue = "yedwcpmtiy",
},
            new StringStringE0M
{
    Id = 79,
    Value = "jo",
    ModelInner = new StringStringE0MI
{
    Id = 87,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 82,
    Value = "qntumt",
    ModelInner = new StringStringE0MI
{
    Id = 93,
    Value = "h",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 89,
    Value = "xfgrxkqtwarhvwdega",
    ModelInner = new StringStringE0MI
{
    Id = 102,
    Value = "xghsgdyicsuddkqtcdxxywvqakcdw",
    NullableValue = null,
},
    NullableValue = "qdlm",
},
            new StringStringE0M
{
    Id = 92,
    Value = "uhflxichul",
    ModelInner = new StringStringE0MI
{
    Id = 104,
    Value = "vgdnrfydjovklkenqjn",
    NullableValue = null,
},
    NullableValue = "butwmyldwgwplpjq",
},
            new StringStringE0M
{
    Id = 99,
    Value = "welktywflnyuopbvutjbmbc",
    ModelInner = new StringStringE0MI
{
    Id = 109,
    Value = "lsuqkdxvpmujvchfn",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 101,
    Value = "aqbxomwvlvyrkvqi",
    ModelInner = new StringStringE0MI
{
    Id = 110,
    Value = "lupfhjrxxibuwhn",
    NullableValue = null,
},
    NullableValue = "haeeykagcsbsum",
},
            new StringStringE0M
{
    Id = 110,
    Value = "nwviycrxwebekquol",
    ModelInner = new StringStringE0MI
{
    Id = 115,
    Value = "xxioqjetaottlthulvryqix",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 118,
    Value = "y",
    ModelInner = new StringStringE0MI
{
    Id = 117,
    Value = "rdcueljpvgjsuwvovyimrpw",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 119,
    Value = "onmu",
    ModelInner = new StringStringE0MI
{
    Id = 126,
    Value = "wsviswpuytuo",
    NullableValue = "vj",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 126,
    Value = "u",
    ModelInner = new StringStringE0MI
{
    Id = 132,
    Value = "rvviyocrdyavxuffkpmlgrfjwcq",
    NullableValue = "reyiivuvijloygovoiawtethspet",
},
    NullableValue = "bnw",
},
            new StringStringE0M
{
    Id = 128,
    Value = "luqrfxmhkrmepevhh",
    ModelInner = new StringStringE0MI
{
    Id = 136,
    Value = "gobptaaeqpvnnqhchvmaegargbvr",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 131,
    Value = "dltxrr",
    ModelInner = new StringStringE0MI
{
    Id = 142,
    Value = "ejqikbdbtfafovfucspyplmwys",
    NullableValue = "wlowrfdavgnaqkjqjubghjnhoimc",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 135,
    Value = "ji",
    ModelInner = new StringStringE0MI
{
    Id = 145,
    Value = "kw",
    NullableValue = null,
},
    NullableValue = "vwixkhjlfopklecvapfqbvvbdht",
},
            new StringStringE0M
{
    Id = 143,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 153,
    Value = "ilstsamou",
    NullableValue = null,
},
    NullableValue = "fqvwhqeflbunodbwikatskeyxprtx",
},
            new StringStringE0M
{
    Id = 152,
    Value = "blsxjsv",
    ModelInner = new StringStringE0MI
{
    Id = 157,
    Value = "bgeqk",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 156,
    Value = "gsguegwwukftwwaebmihjcmocan",
    ModelInner = new StringStringE0MI
{
    Id = 158,
    Value = "jipypf",
    NullableValue = "ffmwwnidapystwlgjbyuuy",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 158,
    Value = "rumuvxxvnkssdqafwsddwlqp",
    ModelInner = new StringStringE0MI
{
    Id = 162,
    Value = "pnsnaxpafpmldwtfbibkktb",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 166,
    Value = "imjmvhbosiihjcaocqdygqrcyv",
    ModelInner = new StringStringE0MI
{
    Id = 168,
    Value = "qqqxwtytbsjnkgysci",
    NullableValue = "uvvsystpkjhupeymkeeywla",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 175,
    Value = "ydxchvqmgmpyqqhbmayocrlr",
    ModelInner = new StringStringE0MI
{
    Id = 175,
    Value = "nahn",
    NullableValue = "juxttaokcx",
},
    NullableValue = "jkunkw",
},
            new StringStringE0M
{
    Id = 181,
    Value = "iok",
    ModelInner = new StringStringE0MI
{
    Id = 184,
    Value = "suiuykr",
    NullableValue = "pjqibhwjomvodrbsie",
},
    NullableValue = "i",
},
            new StringStringE0M
{
    Id = 182,
    Value = "oof",
    ModelInner = new StringStringE0MI
{
    Id = 187,
    Value = "yfdpgwlndsgvvoupfhesoporvi",
    NullableValue = "kqpywhbayfukjdksbvhbjiwmkn",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 191,
    Value = "jpaunkcnnqjmwjnsulpvwycetowaw",
    ModelInner = new StringStringE0MI
{
    Id = 196,
    Value = "jnkrmxnqwmgccrxfalfasompcckp",
    NullableValue = "alqbruisoqaqievxxfwg",
},
    NullableValue = "xobnxtykuukybkldaqocwybjlnbqr",
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

