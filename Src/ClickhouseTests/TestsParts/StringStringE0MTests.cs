

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
    Value = "giocjhxildmqmhklhlonxm",
    ModelInner = new StringStringE0MI
{
    Id = 8,
    Value = "afmeggludijkqlavqhstvkjouuchh",
    NullableValue = null,
},
    NullableValue = "ytqqwcf",
},
            new StringStringE0M
{
    Id = 11,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 17,
    Value = "",
    NullableValue = null,
},
    NullableValue = "kkpikglpgjmitgyhqcoqewc",
},
            new StringStringE0M
{
    Id = 19,
    Value = "udlglvwwhaobwja",
    ModelInner = new StringStringE0MI
{
    Id = 24,
    Value = "rsndjogftfeoum",
    NullableValue = null,
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 22,
    Value = "aornwxbwlcxmorutto",
    ModelInner = new StringStringE0MI
{
    Id = 28,
    Value = "jotburcoywesxnmxgkmb",
    NullableValue = null,
},
    NullableValue = "mg",
},
            new StringStringE0M
{
    Id = 27,
    Value = "gabymieukvcvgmvygar",
    ModelInner = new StringStringE0MI
{
    Id = 33,
    Value = "",
    NullableValue = "mpaqqtkajmgqwudefsys",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 28,
    Value = "lpfjweupetvrqwvtxpdiokuv",
    ModelInner = new StringStringE0MI
{
    Id = 38,
    Value = "yxjg",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 31,
    Value = "ksfqqsrtbhftkkcmccu",
    ModelInner = new StringStringE0MI
{
    Id = 46,
    Value = "ldvdorymemlynltrmsqe",
    NullableValue = "lioshcowppkqwbjyocghktlol",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 38,
    Value = "ywugyyyn",
    ModelInner = new StringStringE0MI
{
    Id = 47,
    Value = "leecwco",
    NullableValue = null,
},
    NullableValue = "pwnolw",
},
            new StringStringE0M
{
    Id = 45,
    Value = "ljwiwudxvp",
    ModelInner = new StringStringE0MI
{
    Id = 50,
    Value = "niwplfmx",
    NullableValue = null,
},
    NullableValue = "wqxyalbusjjtxhlwxhercsptcwd",
},
            new StringStringE0M
{
    Id = 54,
    Value = "vpafbjqvumcgnqlnbxocyn",
    ModelInner = new StringStringE0MI
{
    Id = 53,
    Value = "rrfntfkhquqgkwumlengajrt",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 55,
    Value = "grdakxurxggj",
    ModelInner = new StringStringE0MI
{
    Id = 59,
    Value = "",
    NullableValue = null,
},
    NullableValue = "hgkmhexytwncdch",
},
            new StringStringE0M
{
    Id = 64,
    Value = "vngkcjasvhawsjndfpnonldupk",
    ModelInner = new StringStringE0MI
{
    Id = 62,
    Value = "jojplujxrrloxd",
    NullableValue = "tdrfhhwhkm",
},
    NullableValue = "rhatw",
},
            new StringStringE0M
{
    Id = 67,
    Value = "siwhclujawegxysvopwllboynbwmj",
    ModelInner = new StringStringE0MI
{
    Id = 70,
    Value = "okwif",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 76,
    Value = "cakjkswtwxojmjcmkj",
    ModelInner = new StringStringE0MI
{
    Id = 74,
    Value = "meokqoivwknkbwpausbcjcpvaw",
    NullableValue = null,
},
    NullableValue = "dklsrnfwxhpejbyom",
},
            new StringStringE0M
{
    Id = 82,
    Value = "yaptijwnnt",
    ModelInner = new StringStringE0MI
{
    Id = 80,
    Value = "npnuvvpmcuua",
    NullableValue = null,
},
    NullableValue = "dom",
},
            new StringStringE0M
{
    Id = 84,
    Value = "vudadg",
    ModelInner = new StringStringE0MI
{
    Id = 85,
    Value = "fumksfycqsohmesgrji",
    NullableValue = "deebxhgukqmf",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 88,
    Value = "aduxkfwkfdv",
    ModelInner = new StringStringE0MI
{
    Id = 92,
    Value = "befntnkplmwypieyiwqgdwl",
    NullableValue = "uteewedngibtqdqacruufoyrodd",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 90,
    Value = "whkvymgsjacqggnnjpjijllmxckcy",
    ModelInner = new StringStringE0MI
{
    Id = 93,
    Value = "jaggaetimxtml",
    NullableValue = "pdfe",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 94,
    Value = "wppicdflw",
    ModelInner = new StringStringE0MI
{
    Id = 94,
    Value = "tpeyswqgpm",
    NullableValue = "bsqtxihvnduabofkxaapijvfqkc",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 95,
    Value = "gyptktrjehr",
    ModelInner = new StringStringE0MI
{
    Id = 95,
    Value = "",
    NullableValue = "rlqrwwbmethphetvbrsqi",
},
    NullableValue = "quvnicnhuaxjhgmsuyxbhiiwohcdk",
},
            new StringStringE0M
{
    Id = 99,
    Value = "arpmvt",
    ModelInner = new StringStringE0MI
{
    Id = 102,
    Value = "lytbowandcan",
    NullableValue = "jckpiedt",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 103,
    Value = "j",
    ModelInner = new StringStringE0MI
{
    Id = 103,
    Value = "tytqoujoevsaqppcxb",
    NullableValue = "",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 110,
    Value = "rnwgtvikcaeooenyredm",
    ModelInner = new StringStringE0MI
{
    Id = 107,
    Value = "cnphgoplbfacbtyljnsqlfiax",
    NullableValue = null,
},
    NullableValue = "hxjcbdc",
},
            new StringStringE0M
{
    Id = 118,
    Value = "kuypohgseqmjhkcysug",
    ModelInner = new StringStringE0MI
{
    Id = 116,
    Value = "hwyhpcjs",
    NullableValue = null,
},
    NullableValue = "eidhdanvuhocgig",
},
            new StringStringE0M
{
    Id = 121,
    Value = "hivuofmwglgnplphgeqlq",
    ModelInner = new StringStringE0MI
{
    Id = 117,
    Value = "p",
    NullableValue = null,
},
    NullableValue = "bngjgihcr",
},
            new StringStringE0M
{
    Id = 122,
    Value = "jjbrawbjdwfirvwgbtlecdx",
    ModelInner = new StringStringE0MI
{
    Id = 126,
    Value = "miqbclsxghcrw",
    NullableValue = "llbcf",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 127,
    Value = "kwajugtykaikcku",
    ModelInner = new StringStringE0MI
{
    Id = 132,
    Value = "ppsxpmooqjwtiyhfhycurcjjihx",
    NullableValue = "oyyscrfusyxtebspjtmiejlli",
},
    NullableValue = "jvueiwnnqshtihuilrqtrbhyup",
},
            new StringStringE0M
{
    Id = 136,
    Value = "wjoxsci",
    ModelInner = new StringStringE0MI
{
    Id = 133,
    Value = "rawwxelsuwofxifcksltsc",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 139,
    Value = "fcgxp",
    ModelInner = new StringStringE0MI
{
    Id = 141,
    Value = "ksyqlnduwwtfcnaeajyf",
    NullableValue = null,
},
    NullableValue = "hmbcojgmajawqdwgxhsbft",
},
            new StringStringE0M
{
    Id = 146,
    Value = "sukby",
    ModelInner = new StringStringE0MI
{
    Id = 147,
    Value = "brservkutrfwpqtenlxfhwafm",
    NullableValue = "kmmkdopdhaa",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 147,
    Value = "pnrosdcm",
    ModelInner = new StringStringE0MI
{
    Id = 152,
    Value = "srqvgprcyqjlycvvegobhputadckh",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 150,
    Value = "",
    ModelInner = new StringStringE0MI
{
    Id = 161,
    Value = "t",
    NullableValue = null,
},
    NullableValue = "",
},
            new StringStringE0M
{
    Id = 156,
    Value = "dbphksosgejneushgycaqaxby",
    ModelInner = new StringStringE0MI
{
    Id = 169,
    Value = "xvcdjvwyh",
    NullableValue = "surfwmswn",
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 164,
    Value = "ihmumcpisda",
    ModelInner = new StringStringE0MI
{
    Id = 174,
    Value = "kbglfqmfwksonfufygbfv",
    NullableValue = null,
},
    NullableValue = null,
},
            new StringStringE0M
{
    Id = 172,
    Value = "eniaokhknnbcfoute",
    ModelInner = new StringStringE0MI
{
    Id = 177,
    Value = "yfaulqlmnvtiwdjqjwrecvougqder",
    NullableValue = null,
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

