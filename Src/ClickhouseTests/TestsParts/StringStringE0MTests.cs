

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
    Id = 4,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 5,
    Value = "xbatpruendvogmsrbclsmhsnbfcra",
    NullableValue = null,
},
    NullableValue = "chsihnbhmdjheaawy",
},
            new StringStringE0M
{
    Id = 13,
    Value = "inevwsfxtpkgnmbmsejcvotsfi",
    ModelInner = new StringStringE0MI
{
    Id = 9,
    Value = "hpvqpniehafdvfmmtkehpdarbwnr",
    NullableValue = "xqbohh",
},
    NullableValue = "da",
},
            new StringStringE0M
{
    Id = 14,
    Value = "pjpvddwcxbpa",
    ModelInner = new StringStringE0MI
{
    Id = 14,
    Value = "ntifsqhtgltwy",
    NullableValue = null,
},
    NullableValue = "p",
},
            new StringStringE0M
{
    Id = 23,
    Value = "yrjcpplvwhaujrmf",
    ModelInner = new StringStringE0MI
{
    Id = 23,
    Value = "fpfpqqfdvjlptwwq",
    NullableValue = "vwbniwgiwrnlgcdjviocenygn",
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 25,
    Value = "kipuxcpfcehioymvqrhmocecwqtx",
    ModelInner = new StringStringE0MI
{
    Id = 29,
    Value = "dslyqbimlmgfny",
    NullableValue = "wyihiougkka",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 34,
    Value = "aomxroehgxbnffcnguevvasdhdhr",
    ModelInner = new StringStringE0MI
{
    Id = 31,
    Value = "j",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 41,
    Value = "hgbtwqmq",
    ModelInner = new StringStringE0MI
{
    Id = 37,
    Value = "ixdfalfgffcxpgjvir",
    NullableValue = null,
},
    NullableValue = "bmblmpk",
},
            new StringStringE0M
{
    Id = 43,
    Value = "id",
    ModelInner = new StringStringE0MI
{
    Id = 44,
    Value = "hocuelvrrxqiqiqjp",
    NullableValue = null,
},
    NullableValue = "cxpvxls",
},
            new StringStringE0M
{
    Id = 46,
    Value = "docbljfqqkxptdtfs",
    ModelInner = new StringStringE0MI
{
    Id = 51,
    Value = "bqe",
    NullableValue = "jdggdxqxamxlqjtnqdrq",
},
    NullableValue = "xxuujxonrsaol",
},
            new StringStringE0M
{
    Id = 53,
    Value = "xbtlcwwpheaupy",
    ModelInner = new StringStringE0MI
{
    Id = 60,
    Value = "trallkpiqtq",
    NullableValue = null,
},
    NullableValue = "xryauaxqrkralyq",
},
            new StringStringE0M
{
    Id = 56,
    Value = "hrholjesdyunqfvgfcffutosygkd",
    ModelInner = new StringStringE0MI
{
    Id = 65,
    Value = "mmmtbsivyttjltbk",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 65,
    Value = "hdvrdvyvfimrfcwbm",
    ModelInner = new StringStringE0MI
{
    Id = 66,
    Value = "hepjodtgrxoxymcmaxviyulpcla",
    NullableValue = "jthpdmkydlvkngqt",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 72,
    Value = "uavl",
    ModelInner = new StringStringE0MI
{
    Id = 73,
    Value = "dxvtygvvedrivtnmexnjau",
    NullableValue = "kkdxglwyokuqj",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 74,
    Value = "xhfffohawp",
    ModelInner = new StringStringE0MI
{
    Id = 78,
    Value = "ytyklmphciukpddqjfgauovmhkelr",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 75,
    Value = "akncuirqodqggyxnvnso",
    ModelInner = new StringStringE0MI
{
    Id = 81,
    Value = "umligsmuapicedlkyeudnstugqlf",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 78,
    Value = "autnkiylcl",
    ModelInner = new StringStringE0MI
{
    Id = 88,
    Value = "clblj",
    NullableValue = "qrph",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 79,
    Value = "fjqnmhllbrxumxif",
    ModelInner = new StringStringE0MI
{
    Id = 94,
    Value = "o",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 80,
    Value = "tndoxilecxy",
    ModelInner = new StringStringE0MI
{
    Id = 100,
    Value = "ycahbhedkbkakhlvudqatjg",
    NullableValue = "oeetcfhrkixcpynkyjdqecly",
},
    NullableValue = "qcijboxhfahsedxkbl",
},
            new StringStringE0M
{
    Id = 84,
    Value = "bujwbubqrxgjg",
    ModelInner = new StringStringE0MI
{
    Id = 103,
    Value = "mcnpldt",
    NullableValue = "rglwsk",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 87,
    Value = "judg",
    ModelInner = new StringStringE0MI
{
    Id = 111,
    Value = "ferjjidyubjnngnsvqqfsjiudbyry",
    NullableValue = "lgjdhxwxxubqbiibfthbqj",
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 88,
    Value = "xvggevdwctbcsrtfr",
    ModelInner = new StringStringE0MI
{
    Id = 116,
    Value = "vbfwxgvscpiolrfddejl",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 97,
    Value = "am",
    ModelInner = new StringStringE0MI
{
    Id = 122,
    Value = "hpncoh",
    NullableValue = null,
},
    NullableValue = "kpworfkivycgo",
},
            new StringStringE0M
{
    Id = 100,
    Value = "wjxolegkpjsytq",
    ModelInner = new StringStringE0MI
{
    Id = 129,
    Value = "ebspmbniel",
    NullableValue = null,
},
    NullableValue = "kvocaxmdfjiqwehjftxxvvrw",
},
            new StringStringE0M
{
    Id = 105,
    Value = "owqsk",
    ModelInner = new StringStringE0MI
{
    Id = 137,
    Value = "fnnpu",
    NullableValue = null,
},
    NullableValue = "fgxun",
},
            new StringStringE0M
{
    Id = 111,
    Value = "bjmuybgonfmelciahnmhopugpxy",
    ModelInner = new StringStringE0MI
{
    Id = 141,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 113,
    Value = "l",
    ModelInner = new StringStringE0MI
{
    Id = 142,
    Value = "oe",
    NullableValue = null,
},
    NullableValue = "muqtphpijqhbswvgaflemdvbxwtx",
},
            new StringStringE0M
{
    Id = 118,
    Value = "tfhxolygbtpabo",
    ModelInner = new StringStringE0MI
{
    Id = 149,
    Value = "habattptlhoacjxycfnrhsmjvwhg",
    NullableValue = "neulvjapkxldugdolse",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 125,
    Value = "fgttdphigfjonusflulid",
    ModelInner = new StringStringE0MI
{
    Id = 157,
    Value = "ggwfshilxtvjflahwixgsblyb",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 131,
    Value = "cgoib",
    ModelInner = new StringStringE0MI
{
    Id = 166,
    Value = "pqwphoghfcsxij",
    NullableValue = "diux",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 138,
    Value = "tbhl",
    ModelInner = new StringStringE0MI
{
    Id = 169,
    Value = "rnqwmcdfqoe",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 146,
    Value = "vmpwqqxuyjianm",
    ModelInner = new StringStringE0MI
{
    Id = 171,
    Value = "ayo",
    NullableValue = "vciwiinnwqgyugeuynctukdnom",
},
    NullableValue = "okltdfvbftyyxcwexagahkdhkepd",
},
            new StringStringE0M
{
    Id = 147,
    Value = "vewewwsdutu",
    ModelInner = new StringStringE0MI
{
    Id = 173,
    Value = "abthxitsjgmxxbxtib",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 156,
    Value = "bsraf",
    ModelInner = new StringStringE0MI
{
    Id = 181,
    Value = "acgmmnkppooxawfynpxaohwfe",
    NullableValue = null,
},
    NullableValue = "oaprpfvpqjjignliawtm",
},
            new StringStringE0M
{
    Id = 160,
    Value = "kpbowxcctjecvshdvpls",
    ModelInner = new StringStringE0MI
{
    Id = 188,
    Value = "jihmiivbmyxphvqsjcqhedmhpn",
    NullableValue = null,
},
    NullableValue = "lxgcfksomlkpkeprngfuqacsxwpcw",
},
            new StringStringE0M
{
    Id = 162,
    Value = "oypue",
    ModelInner = new StringStringE0MI
{
    Id = 193,
    Value = "dhnukosnklgpjufyefue",
    NullableValue = "kvsjjcdq",
},
    NullableValue = "kuesiebbkwjnt",
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

