

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
    internal partial interface IInt32SingleTypeInt32
    {
    }
    
    internal partial class Int32SingleTypeInt32 : IInt32SingleTypeInt32
    {


#region TestData

        private readonly Int32Int32E0M[] _testData = new Int32Int32E0M[]
        {
            new Int32Int32E0M
{
    Id = 7,
    Value = 934892033,
    ModelInner = new Int32Int32E0MI
{
    Id = 5,
    Value = 11076634,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 10,
    Value = 1498290856,
    ModelInner = new Int32Int32E0MI
{
    Id = 10,
    Value = 269941995,
    NullableValue = null,
},
    NullableValue = 259419121,
},
            new Int32Int32E0M
{
    Id = 12,
    Value = 813920362,
    ModelInner = new Int32Int32E0MI
{
    Id = 15,
    Value = 714656151,
    NullableValue = null,
},
    NullableValue = 2113019523,
},
            new Int32Int32E0M
{
    Id = 17,
    Value = 1645282022,
    ModelInner = new Int32Int32E0MI
{
    Id = 19,
    Value = 1769273014,
    NullableValue = 1561637079,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 19,
    Value = 2003416827,
    ModelInner = new Int32Int32E0MI
{
    Id = 28,
    Value = 2023415364,
    NullableValue = 2144820526,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 21,
    Value = 978268844,
    ModelInner = new Int32Int32E0MI
{
    Id = 35,
    Value = 771280679,
    NullableValue = 67690996,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 25,
    Value = 1265074061,
    ModelInner = new Int32Int32E0MI
{
    Id = 39,
    Value = 367072512,
    NullableValue = 299987254,
},
    NullableValue = 1523903624,
},
            new Int32Int32E0M
{
    Id = 32,
    Value = 968220915,
    ModelInner = new Int32Int32E0MI
{
    Id = 43,
    Value = 1611823593,
    NullableValue = null,
},
    NullableValue = 663845520,
},
            new Int32Int32E0M
{
    Id = 33,
    Value = 1633180689,
    ModelInner = new Int32Int32E0MI
{
    Id = 49,
    Value = 254053450,
    NullableValue = 461437466,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 41,
    Value = 1742300833,
    ModelInner = new Int32Int32E0MI
{
    Id = 53,
    Value = 1990419902,
    NullableValue = null,
},
    NullableValue = 1307441050,
},
            new Int32Int32E0M
{
    Id = 48,
    Value = 1234898744,
    ModelInner = new Int32Int32E0MI
{
    Id = 59,
    Value = 1006191428,
    NullableValue = 1976590221,
},
    NullableValue = 326128137,
},
            new Int32Int32E0M
{
    Id = 55,
    Value = 279819926,
    ModelInner = new Int32Int32E0MI
{
    Id = 65,
    Value = 814411855,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 58,
    Value = 2010572432,
    ModelInner = new Int32Int32E0MI
{
    Id = 68,
    Value = 777168727,
    NullableValue = null,
},
    NullableValue = 1619473797,
},
            new Int32Int32E0M
{
    Id = 59,
    Value = 1195939833,
    ModelInner = new Int32Int32E0MI
{
    Id = 71,
    Value = 284144715,
    NullableValue = null,
},
    NullableValue = 525959097,
},
            new Int32Int32E0M
{
    Id = 67,
    Value = 1728608258,
    ModelInner = new Int32Int32E0MI
{
    Id = 72,
    Value = 1086072453,
    NullableValue = 1836946734,
},
    NullableValue = 520924388,
},
            new Int32Int32E0M
{
    Id = 68,
    Value = 1657392507,
    ModelInner = new Int32Int32E0MI
{
    Id = 74,
    Value = 795939317,
    NullableValue = 988803555,
},
    NullableValue = 1712854656,
},
            new Int32Int32E0M
{
    Id = 75,
    Value = 634802619,
    ModelInner = new Int32Int32E0MI
{
    Id = 77,
    Value = 427268344,
    NullableValue = null,
},
    NullableValue = 1196786509,
},
            new Int32Int32E0M
{
    Id = 81,
    Value = 584637038,
    ModelInner = new Int32Int32E0MI
{
    Id = 83,
    Value = 186309685,
    NullableValue = 1915717734,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 89,
    Value = 239133535,
    ModelInner = new Int32Int32E0MI
{
    Id = 84,
    Value = 385707274,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 93,
    Value = 1009283259,
    ModelInner = new Int32Int32E0MI
{
    Id = 89,
    Value = 492806655,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 98,
    Value = 2075334819,
    ModelInner = new Int32Int32E0MI
{
    Id = 94,
    Value = 1213172551,
    NullableValue = 1668766372,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 107,
    Value = 37331896,
    ModelInner = new Int32Int32E0MI
{
    Id = 95,
    Value = 70484209,
    NullableValue = null,
},
    NullableValue = 826884309,
},
            new Int32Int32E0M
{
    Id = 116,
    Value = 677170262,
    ModelInner = new Int32Int32E0MI
{
    Id = 100,
    Value = 925089967,
    NullableValue = 817512478,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 121,
    Value = 2115639854,
    ModelInner = new Int32Int32E0MI
{
    Id = 106,
    Value = 1207609026,
    NullableValue = 778065813,
},
    NullableValue = 2131768070,
},
            new Int32Int32E0M
{
    Id = 125,
    Value = 643527987,
    ModelInner = new Int32Int32E0MI
{
    Id = 111,
    Value = 2078904643,
    NullableValue = 2050086063,
},
    NullableValue = 349291212,
},
            new Int32Int32E0M
{
    Id = 134,
    Value = 386083613,
    ModelInner = new Int32Int32E0MI
{
    Id = 113,
    Value = 899693421,
    NullableValue = 22775496,
},
    NullableValue = 1733408169,
},
            new Int32Int32E0M
{
    Id = 142,
    Value = 1370878000,
    ModelInner = new Int32Int32E0MI
{
    Id = 116,
    Value = 1495117350,
    NullableValue = 913291190,
},
    NullableValue = 1772073285,
},
            new Int32Int32E0M
{
    Id = 150,
    Value = 1233544770,
    ModelInner = new Int32Int32E0MI
{
    Id = 118,
    Value = 1377149198,
    NullableValue = null,
},
    NullableValue = 508315440,
},
            new Int32Int32E0M
{
    Id = 155,
    Value = 752940862,
    ModelInner = new Int32Int32E0MI
{
    Id = 124,
    Value = 1236996082,
    NullableValue = 1584574827,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 157,
    Value = 751003228,
    ModelInner = new Int32Int32E0MI
{
    Id = 130,
    Value = 1323750674,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 160,
    Value = 1495793400,
    ModelInner = new Int32Int32E0MI
{
    Id = 138,
    Value = 1670636624,
    NullableValue = null,
},
    NullableValue = 1208993813,
},
            new Int32Int32E0M
{
    Id = 163,
    Value = 2074356299,
    ModelInner = new Int32Int32E0MI
{
    Id = 146,
    Value = 1845268998,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 164,
    Value = 1974932134,
    ModelInner = new Int32Int32E0MI
{
    Id = 152,
    Value = 743272965,
    NullableValue = 1131893687,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 172,
    Value = 597333867,
    ModelInner = new Int32Int32E0MI
{
    Id = 158,
    Value = 852541706,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 174,
    Value = 841758264,
    ModelInner = new Int32Int32E0MI
{
    Id = 163,
    Value = 6062069,
    NullableValue = 850979771,
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
INSERT INTO gedaqtests.int32int32e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int32}, 
    {mi_id:Int32},
    {mi_value:Int32}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
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
                    await ((IInt32SingleTypeInt32)this).InsertModelDbConnectionAsync(
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
                     ((IInt32SingleTypeInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.int32int32e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32Int32E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeInt32)),
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
                    var models = await ((IInt32SingleTypeInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int32E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32SingleTypeInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int32E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

