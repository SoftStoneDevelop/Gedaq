

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
    Value = "qenkxcsxeqrs",
    ModelInner = new StringString0MI
{
    Id = 7,
    Value = "lergfastpf",
    NullableValue = "ihwajyalwpebdppyyqttxyfc",
},
    NullableValue = "rjdymhucdeheioubocimrcknqfqmp",
},
            new StringStringE0M
{
    Id = 9,
    Value = "tlixvxxknodemvjvfwprkeyija",
    ModelInner = new StringString0MI
{
    Id = 8,
    Value = "kpb",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 13,
    Value = "yjsnllvwdfg",
    ModelInner = new StringString0MI
{
    Id = 17,
    Value = "sgjfte",
    NullableValue = "wccdqsqrwgnowskp",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 14,
    Value = "qgdutjjefrkoqdyast",
    ModelInner = new StringString0MI
{
    Id = 24,
    Value = "hcqcdajpemfiiokbbbpyc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 22,
    Value = "obpeaaocbyfirjfdfl",
    ModelInner = new StringString0MI
{
    Id = 25,
    Value = "ogshinvetdebuvfrdt",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 29,
    Value = "aalusumliwyxqm",
    ModelInner = new StringString0MI
{
    Id = 27,
    Value = "ud",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 36,
    Value = "cj",
    ModelInner = new StringString0MI
{
    Id = 29,
    Value = "hsabfsepainvpyf",
    NullableValue = null,
},
    NullableValue = "judtwqpxynru",
},
            new StringStringE0M
{
    Id = 38,
    Value = "wuopydssyisxdgp",
    ModelInner = new StringString0MI
{
    Id = 36,
    Value = "sutndihhthfnphlwqwihqyvio",
    NullableValue = null,
},
    NullableValue = "ivqwtgroefyalyqxuqgfhketnx",
},
            new StringStringE0M
{
    Id = 40,
    Value = "qh",
    ModelInner = new StringString0MI
{
    Id = 40,
    Value = "tfsgynartqxfrxsrdkvcaxbbd",
    NullableValue = "ofatyahheolxdhglannqpmgttcwof",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 46,
    Value = "dkqspmcoodmntyqgu",
    ModelInner = new StringString0MI
{
    Id = 42,
    Value = "mmteaejoouyjhygdqraeq",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 48,
    Value = "vquhcvktyyfibmprorpqgpsxiday",
    ModelInner = new StringString0MI
{
    Id = 46,
    Value = "inqi",
    NullableValue = null,
},
    NullableValue = "qoufhtgmhyftjislgln",
},
            new StringStringE0M
{
    Id = 50,
    Value = "fmwpuekjswu",
    ModelInner = new StringString0MI
{
    Id = 47,
    Value = "dkndubi",
    NullableValue = "arjqrykeoalirvydnimxagdt",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 52,
    Value = "b",
    ModelInner = new StringString0MI
{
    Id = 54,
    Value = "rhofentwxbfvfrshx",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 57,
    Value = "ddohpxoiiojthoki",
    ModelInner = new StringString0MI
{
    Id = 61,
    Value = "lfoqbakghtevvwfuqeseojbic",
    NullableValue = "bcmfvqufxrknqpslybwihc",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 63,
    Value = "otgwigshtb",
    ModelInner = new StringString0MI
{
    Id = 65,
    Value = "tpkceggxnjvjaijdqvpkmnjbjhhce",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 64,
    Value = "qr",
    ModelInner = new StringString0MI
{
    Id = 73,
    Value = "",
    NullableValue = "awrlyunoipkwxrilmuibcyyw",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 72,
    Value = "ulctcudhisjsimtvklmhyhpjotw",
    ModelInner = new StringString0MI
{
    Id = 82,
    Value = "qsddfpggrstcgkioaflwkwhfnpin",
    NullableValue = null,
},
    NullableValue = "we",
},
            new StringStringE0M
{
    Id = 74,
    Value = "fnljbbjeysmamkql",
    ModelInner = new StringString0MI
{
    Id = 90,
    Value = "rh",
    NullableValue = null,
},
    NullableValue = "mfrdxwtwjlmiwwusuowimav",
},
            new StringStringE0M
{
    Id = 76,
    Value = "inqukhhsen",
    ModelInner = new StringString0MI
{
    Id = 99,
    Value = "lpiymxnbkqxlyy",
    NullableValue = "iajjyigrahrbtclqvxlyweqckfuq",
},
    NullableValue = "ghsxumu",
},
            new StringStringE0M
{
    Id = 79,
    Value = "lemkpdu",
    ModelInner = new StringString0MI
{
    Id = 106,
    Value = "upitsomrrrkls",
    NullableValue = null,
},
    NullableValue = "psstuvenyoat",
},
            new StringStringE0M
{
    Id = 81,
    Value = "pwbwxakplkrqtlgsyayqgg",
    ModelInner = new StringString0MI
{
    Id = 112,
    Value = "",
    NullableValue = "sqgr",
},
    NullableValue = "oiftudws",
},
            new StringStringE0M
{
    Id = 82,
    Value = "kvtuhnrnxjcbvvxgwkiwefswc",
    ModelInner = new StringString0MI
{
    Id = 121,
    Value = "ghsjcoecp",
    NullableValue = null,
},
    NullableValue = "s",
},
            new StringStringE0M
{
    Id = 88,
    Value = "frllpxnqldbydnvkaxxr",
    ModelInner = new StringString0MI
{
    Id = 128,
    Value = "dhfuyv",
    NullableValue = "futoticsdrqhbgxiehrahnrpbf",
},
    NullableValue = "klcsanrarfgrnwtrdyldn",
},
            new StringStringE0M
{
    Id = 90,
    Value = "rttogbqiwgqmgjryoflcjag",
    ModelInner = new StringString0MI
{
    Id = 131,
    Value = "upkyguxrgsyyjovmnvjw",
    NullableValue = null,
},
    NullableValue = "mynfevoahvyygutvltfmipdu",
},
            new StringStringE0M
{
    Id = 99,
    Value = "p",
    ModelInner = new StringString0MI
{
    Id = 133,
    Value = "r",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 103,
    Value = "jodbwdkba",
    ModelInner = new StringString0MI
{
    Id = 138,
    Value = "kigghtqwetsvkxgjjjueojpqlcyne",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 109,
    Value = "brv",
    ModelInner = new StringString0MI
{
    Id = 147,
    Value = "ohlgicausvwqabfslfumkpwhqnjec",
    NullableValue = null,
},
    NullableValue = "hajucsw",
},
            new StringStringE0M
{
    Id = 110,
    Value = "bbmsuwsprcpqkqskovnipmobgvofa",
    ModelInner = new StringString0MI
{
    Id = 154,
    Value = "",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 119,
    Value = "jltfdeiukpfavnugbs",
    ModelInner = new StringString0MI
{
    Id = 156,
    Value = "wdwqdophtxkkgjggnmruaxmkmlqh",
    NullableValue = null,
},
    NullableValue = "msbn",
},
            new StringStringE0M
{
    Id = 124,
    Value = "qdfvqfqqkrhuqwt",
    ModelInner = new StringString0MI
{
    Id = 163,
    Value = "etrirjimvkgbpwamtpfvhcwxstwmn",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 131,
    Value = "lvrrdwdbfwecoqrvyxxvngexsyl",
    ModelInner = new StringString0MI
{
    Id = 171,
    Value = "kuscgdkgcbdutfspowj",
    NullableValue = null,
},
    NullableValue = "nkvnpvptnw",
},
            new StringStringE0M
{
    Id = 137,
    Value = "xvcnmxfl",
    ModelInner = new StringString0MI
{
    Id = 174,
    Value = "jrvlmucyj",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 142,
    Value = "ujvpirwovummsmiawj",
    ModelInner = new StringString0MI
{
    Id = 179,
    Value = "duoiyymqleqlsnjugjmcf",
    NullableValue = "hbjtdvekafqissfriuiumm",
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 150,
    Value = "rtnxxonajdryamiyemeffxrr",
    ModelInner = new StringString0MI
{
    Id = 180,
    Value = "nnywybkfeksfnkygtnvvjul",
    NullableValue = "pt",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 151,
    Value = "rpxflrkcd",
    ModelInner = new StringString0MI
{
    Id = 182,
    Value = "xhrulhcmetsjxgvgjkghvuodmoyjv",
    NullableValue = null,
},
    NullableValue = "ofjnnkinyajarafaatkwy",
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

