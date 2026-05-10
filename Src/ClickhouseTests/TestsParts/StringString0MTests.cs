

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
    Value = "dfo",
    ModelInner = new StringString0MI
{
    Id = 8,
    Value = "hvpcyimwhsi",
    NullableValue = null,
},
    NullableValue = "qapafqwmbkhcvipsgboq",
},
            new StringString0M
{
    Id = 11,
    Value = "opssuxoajxarhxdrudr",
    ModelInner = new StringString0MI
{
    Id = 10,
    Value = "",
    NullableValue = null,
},
    NullableValue = "os",
},
            new StringString0M
{
    Id = 14,
    Value = "lmsxsvoqlnrtcurtbokyawrk",
    ModelInner = new StringString0MI
{
    Id = 18,
    Value = "sugpdjnhppvbgipnalxaaryjgn",
    NullableValue = "juxiiahyd",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 16,
    Value = "wyluafolclqspbdhygjyugmab",
    ModelInner = new StringString0MI
{
    Id = 27,
    Value = "puupyjafuxnecvtxxm",
    NullableValue = "flfacgyuifumxax",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 25,
    Value = "bfm",
    ModelInner = new StringString0MI
{
    Id = 28,
    Value = "fhl",
    NullableValue = "nusyvvnvw",
},
    NullableValue = "aiecaobicbh",
},
            new StringString0M
{
    Id = 28,
    Value = "fjjnvhvo",
    ModelInner = new StringString0MI
{
    Id = 30,
    Value = "rrrdiexsmikxmcttgha",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 32,
    Value = "npxtpdii",
    ModelInner = new StringString0MI
{
    Id = 39,
    Value = "ad",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 39,
    Value = "jjvnjjklrisxnydkxg",
    ModelInner = new StringString0MI
{
    Id = 47,
    Value = "tpieshpnahhltoewfw",
    NullableValue = null,
},
    NullableValue = "giu",
},
            new StringString0M
{
    Id = 47,
    Value = "kgilbctbkggkxrq",
    ModelInner = new StringString0MI
{
    Id = 56,
    Value = "jjlme",
    NullableValue = "ytqvmygeivpcqifinlvnq",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 50,
    Value = "piqqiepp",
    ModelInner = new StringString0MI
{
    Id = 63,
    Value = "cjpttrhjyva",
    NullableValue = "xtjlpuvhexngv",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 51,
    Value = "uabcyflkwpgytvv",
    ModelInner = new StringString0MI
{
    Id = 66,
    Value = "vpoluxmhtshtrsyyutqj",
    NullableValue = null,
},
    NullableValue = "njslwostdstygvqtbjij",
},
            new StringString0M
{
    Id = 58,
    Value = "wtltudopbrhuahtovlxmlercy",
    ModelInner = new StringString0MI
{
    Id = 73,
    Value = "fxnucuwoihwpidlpiv",
    NullableValue = null,
},
    NullableValue = "gmggmnfndddouqokfmklgr",
},
            new StringString0M
{
    Id = 67,
    Value = "riyaenfycsuvfpydlcftwoqd",
    ModelInner = new StringString0MI
{
    Id = 82,
    Value = "vwigdclhtfglgffdqoiukl",
    NullableValue = "eucjnrhqqfakyqrncxcyupiobbw",
},
    NullableValue = "gyyykijhvyfkoar",
},
            new StringString0M
{
    Id = 70,
    Value = "bpgbg",
    ModelInner = new StringString0MI
{
    Id = 88,
    Value = "eex",
    NullableValue = "hfgxxuirsijorghxnhrphuknw",
},
    NullableValue = "datvnedwsidntxv",
},
            new StringString0M
{
    Id = 77,
    Value = "xejtaepstsgmio",
    ModelInner = new StringString0MI
{
    Id = 95,
    Value = "pe",
    NullableValue = "girlihhanhoqsulxtgfdtyj",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 84,
    Value = "nhgmkijwcikoflwqlcpveklam",
    ModelInner = new StringString0MI
{
    Id = 103,
    Value = "y",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 93,
    Value = "wnehtngsobprmmnsrpfh",
    ModelInner = new StringString0MI
{
    Id = 107,
    Value = "mxrtf",
    NullableValue = "mihapmbewkxnblrpiigpegv",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 94,
    Value = "gjga",
    ModelInner = new StringString0MI
{
    Id = 114,
    Value = "lfeloccnwrku",
    NullableValue = "dynqpybxkuinpouldgmv",
},
    NullableValue = "pyrxgasovmfxtvwxupjqfoakjk",
},
            new StringString0M
{
    Id = 99,
    Value = "",
    ModelInner = new StringString0MI
{
    Id = 120,
    Value = "gsejjnbaknbfntiapuwayhuafo",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 103,
    Value = "gjrxlrrulltfwxcvjjpthsbrnciot",
    ModelInner = new StringString0MI
{
    Id = 125,
    Value = "mswobqcetbrarnccaj",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 109,
    Value = "mq",
    ModelInner = new StringString0MI
{
    Id = 127,
    Value = "mmwnqcqgfmmslkuvxrfecsdst",
    NullableValue = "fratijsjfvbwtbkpqvatffscbc",
},
    NullableValue = "iytujpvbjkvydbwdwipqsmilfrlfy",
},
            new StringString0M
{
    Id = 116,
    Value = "rredolibrsijuikldremdfmuyyjd",
    ModelInner = new StringString0MI
{
    Id = 136,
    Value = "civdhgpkokqhxvhwmfpyjkujidr",
    NullableValue = "cayawiyeogbjaknabr",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 120,
    Value = "fgjesqoomjhsvakupljfvq",
    ModelInner = new StringString0MI
{
    Id = 144,
    Value = "yf",
    NullableValue = null,
},
    NullableValue = "gspgfqskgkmiffoajoutnveyaphe",
},
            new StringString0M
{
    Id = 126,
    Value = "ykkwwkulxcyrsojaffewawgxdo",
    ModelInner = new StringString0MI
{
    Id = 151,
    Value = "nucjnjxxjvepsnaoifivmuj",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 131,
    Value = "",
    ModelInner = new StringString0MI
{
    Id = 153,
    Value = "ob",
    NullableValue = null,
},
    NullableValue = "vhniisvvhyvmdxwocqprgcdpjkx",
},
            new StringString0M
{
    Id = 134,
    Value = "qxgxmtsylitlgvcwaswrlgnfwdgtl",
    ModelInner = new StringString0MI
{
    Id = 155,
    Value = "kvlaculvduersugbsvkgfkqv",
    NullableValue = "uxbmsotdymdqaemhrhriexwop",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 141,
    Value = "yyfjmhnjlxedbntrkb",
    ModelInner = new StringString0MI
{
    Id = 159,
    Value = "h",
    NullableValue = null,
},
    NullableValue = "nuk",
},
            new StringString0M
{
    Id = 145,
    Value = "wxdnndotlxydwbildidfjbpg",
    ModelInner = new StringString0MI
{
    Id = 160,
    Value = "kihtjnqbhkbghepfriujrjithutwx",
    NullableValue = "pqxmaysuxnikj",
},
    NullableValue = "ibceqmaslcdfh",
},
            new StringString0M
{
    Id = 147,
    Value = "wlgdhtxbgkrsicivvqmjp",
    ModelInner = new StringString0MI
{
    Id = 162,
    Value = "vsrlishbtn",
    NullableValue = "dsytddswdnraqecgwkou",
},
    NullableValue = "opgjsss",
},
            new StringString0M
{
    Id = 154,
    Value = "bnuqwpislsp",
    ModelInner = new StringString0MI
{
    Id = 164,
    Value = "pt",
    NullableValue = "fplgtvitypcc",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 163,
    Value = "agxqucikaddqd",
    ModelInner = new StringString0MI
{
    Id = 168,
    Value = "aljbxmrqg",
    NullableValue = null,
},
    NullableValue = "qsvoh",
},
            new StringString0M
{
    Id = 165,
    Value = "oasnyyqhhioyc",
    ModelInner = new StringString0MI
{
    Id = 175,
    Value = "ynxcuwjvsluxovi",
    NullableValue = null,
},
    NullableValue = "joaiu",
},
            new StringString0M
{
    Id = 167,
    Value = "ohjtinfjfyfpsgnitcwy",
    ModelInner = new StringString0MI
{
    Id = 183,
    Value = "whqqnoxlkobeithjafatknogtkm",
    NullableValue = "bygbgegbgk",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 174,
    Value = "vihdgcvislheskbbdcqsemqja",
    ModelInner = new StringString0MI
{
    Id = 187,
    Value = "bdiaqidkqbkobvsrb",
    NullableValue = "fchwqti",
},
    NullableValue = null,
},
            new StringString0M
{
    Id = 176,
    Value = "wqhhkpfjgwdgi",
    ModelInner = new StringString0MI
{
    Id = 194,
    Value = "ilwhhojfaelcplpygmqkxjmyglx",
    NullableValue = null,
},
    NullableValue = "wartemkhehqxssfsmvol",
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

