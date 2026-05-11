

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
    Id = 4,
    Value = 1775527158,
    ModelInner = new Int32Int32E0MI
{
    Id = 7,
    Value = 1298909028,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 11,
    Value = 1072142658,
    ModelInner = new Int32Int32E0MI
{
    Id = 11,
    Value = 1819139315,
    NullableValue = null,
},
    NullableValue = 766632160,
},
            new Int32Int32E0M
{
    Id = 19,
    Value = 695546839,
    ModelInner = new Int32Int32E0MI
{
    Id = 12,
    Value = 1844068273,
    NullableValue = 1889122951,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 21,
    Value = 1337287386,
    ModelInner = new Int32Int32E0MI
{
    Id = 21,
    Value = 1867573771,
    NullableValue = null,
},
    NullableValue = 241290280,
},
            new Int32Int32E0M
{
    Id = 28,
    Value = 1936654796,
    ModelInner = new Int32Int32E0MI
{
    Id = 29,
    Value = 7148429,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 33,
    Value = 1434920757,
    ModelInner = new Int32Int32E0MI
{
    Id = 35,
    Value = 1466692974,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 42,
    Value = 74171294,
    ModelInner = new Int32Int32E0MI
{
    Id = 43,
    Value = 1015791359,
    NullableValue = 803333987,
},
    NullableValue = 457508479,
},
            new Int32Int32E0M
{
    Id = 48,
    Value = 36576144,
    ModelInner = new Int32Int32E0MI
{
    Id = 46,
    Value = 187585839,
    NullableValue = 1021160709,
},
    NullableValue = 1435158554,
},
            new Int32Int32E0M
{
    Id = 53,
    Value = 674094398,
    ModelInner = new Int32Int32E0MI
{
    Id = 51,
    Value = 943624379,
    NullableValue = 1012641746,
},
    NullableValue = 464912698,
},
            new Int32Int32E0M
{
    Id = 60,
    Value = 953543652,
    ModelInner = new Int32Int32E0MI
{
    Id = 52,
    Value = 1936378997,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 68,
    Value = 604837030,
    ModelInner = new Int32Int32E0MI
{
    Id = 57,
    Value = 955543519,
    NullableValue = 1942163276,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 74,
    Value = 719303903,
    ModelInner = new Int32Int32E0MI
{
    Id = 64,
    Value = 337710004,
    NullableValue = null,
},
    NullableValue = 518389182,
},
            new Int32Int32E0M
{
    Id = 77,
    Value = 2073997444,
    ModelInner = new Int32Int32E0MI
{
    Id = 69,
    Value = 1300668190,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 86,
    Value = 1745416951,
    ModelInner = new Int32Int32E0MI
{
    Id = 74,
    Value = 1012950255,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 90,
    Value = 1661503938,
    ModelInner = new Int32Int32E0MI
{
    Id = 80,
    Value = 826545090,
    NullableValue = null,
},
    NullableValue = 434527711,
},
            new Int32Int32E0M
{
    Id = 95,
    Value = 728916057,
    ModelInner = new Int32Int32E0MI
{
    Id = 81,
    Value = 722346837,
    NullableValue = null,
},
    NullableValue = 1942925562,
},
            new Int32Int32E0M
{
    Id = 101,
    Value = 1475560371,
    ModelInner = new Int32Int32E0MI
{
    Id = 83,
    Value = 2134823921,
    NullableValue = 1160035856,
},
    NullableValue = 853290956,
},
            new Int32Int32E0M
{
    Id = 110,
    Value = 550632328,
    ModelInner = new Int32Int32E0MI
{
    Id = 89,
    Value = 1968791404,
    NullableValue = null,
},
    NullableValue = 720805304,
},
            new Int32Int32E0M
{
    Id = 119,
    Value = 401391074,
    ModelInner = new Int32Int32E0MI
{
    Id = 97,
    Value = 1742925950,
    NullableValue = null,
},
    NullableValue = 597100265,
},
            new Int32Int32E0M
{
    Id = 127,
    Value = 1746849868,
    ModelInner = new Int32Int32E0MI
{
    Id = 98,
    Value = 562128583,
    NullableValue = 1013694292,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 131,
    Value = 635516033,
    ModelInner = new Int32Int32E0MI
{
    Id = 101,
    Value = 1493542429,
    NullableValue = 1752627542,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 133,
    Value = 2050865602,
    ModelInner = new Int32Int32E0MI
{
    Id = 102,
    Value = 416853017,
    NullableValue = 740442447,
},
    NullableValue = 41294918,
},
            new Int32Int32E0M
{
    Id = 135,
    Value = 1040690735,
    ModelInner = new Int32Int32E0MI
{
    Id = 105,
    Value = 1140585604,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 140,
    Value = 277099953,
    ModelInner = new Int32Int32E0MI
{
    Id = 114,
    Value = 2055385947,
    NullableValue = 371534763,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 145,
    Value = 1830410498,
    ModelInner = new Int32Int32E0MI
{
    Id = 122,
    Value = 930886368,
    NullableValue = 974820967,
},
    NullableValue = 1043312781,
},
            new Int32Int32E0M
{
    Id = 146,
    Value = 2083842576,
    ModelInner = new Int32Int32E0MI
{
    Id = 128,
    Value = 1914049878,
    NullableValue = null,
},
    NullableValue = 731241436,
},
            new Int32Int32E0M
{
    Id = 152,
    Value = 526208468,
    ModelInner = new Int32Int32E0MI
{
    Id = 133,
    Value = 84721034,
    NullableValue = 983145430,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 158,
    Value = 1335250160,
    ModelInner = new Int32Int32E0MI
{
    Id = 141,
    Value = 11307315,
    NullableValue = 494303671,
},
    NullableValue = 1200249707,
},
            new Int32Int32E0M
{
    Id = 160,
    Value = 79109652,
    ModelInner = new Int32Int32E0MI
{
    Id = 144,
    Value = 462049779,
    NullableValue = 346689248,
},
    NullableValue = 665681515,
},
            new Int32Int32E0M
{
    Id = 164,
    Value = 1233728646,
    ModelInner = new Int32Int32E0MI
{
    Id = 152,
    Value = 1680216566,
    NullableValue = 58692266,
},
    NullableValue = 628927810,
},
            new Int32Int32E0M
{
    Id = 167,
    Value = 803060812,
    ModelInner = new Int32Int32E0MI
{
    Id = 161,
    Value = 1151818760,
    NullableValue = null,
},
    NullableValue = 1396915885,
},
            new Int32Int32E0M
{
    Id = 176,
    Value = 1818794871,
    ModelInner = new Int32Int32E0MI
{
    Id = 167,
    Value = 1143058394,
    NullableValue = null,
},
    NullableValue = 178170195,
},
            new Int32Int32E0M
{
    Id = 183,
    Value = 383442300,
    ModelInner = new Int32Int32E0MI
{
    Id = 172,
    Value = 1918395131,
    NullableValue = 1296191619,
},
    NullableValue = 590038050,
},
            new Int32Int32E0M
{
    Id = 189,
    Value = 1961518344,
    ModelInner = new Int32Int32E0MI
{
    Id = 175,
    Value = 2010120969,
    NullableValue = null,
},
    NullableValue = 21115803,
},
            new Int32Int32E0M
{
    Id = 195,
    Value = 984337335,
    ModelInner = new Int32Int32E0MI
{
    Id = 179,
    Value = 658787117,
    NullableValue = null,
},
    NullableValue = 2027934991,
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

