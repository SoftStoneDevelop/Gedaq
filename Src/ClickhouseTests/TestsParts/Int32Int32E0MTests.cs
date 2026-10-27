

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
    Id = 5,
    Value = 2088369871,
    ModelInner = new Int32Int32E0MI
{
    Id = 5,
    Value = 1078832366,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 13,
    Value = 1329929638,
    ModelInner = new Int32Int32E0MI
{
    Id = 13,
    Value = 1197057436,
    NullableValue = null,
},
    NullableValue = 1736922464,
},
            new Int32Int32E0M
{
    Id = 21,
    Value = 1961582296,
    ModelInner = new Int32Int32E0MI
{
    Id = 18,
    Value = 1146767891,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 29,
    Value = 1772168356,
    ModelInner = new Int32Int32E0MI
{
    Id = 20,
    Value = 1885996337,
    NullableValue = null,
},
    NullableValue = 1760423929,
},
            new Int32Int32E0M
{
    Id = 32,
    Value = 1758863288,
    ModelInner = new Int32Int32E0MI
{
    Id = 22,
    Value = 1992199703,
    NullableValue = 1763696,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 37,
    Value = 1492687332,
    ModelInner = new Int32Int32E0MI
{
    Id = 27,
    Value = 1646966449,
    NullableValue = 1220665249,
},
    NullableValue = 36538858,
},
            new Int32Int32E0M
{
    Id = 43,
    Value = 1056362632,
    ModelInner = new Int32Int32E0MI
{
    Id = 35,
    Value = 1151792189,
    NullableValue = 530309630,
},
    NullableValue = 2061496840,
},
            new Int32Int32E0M
{
    Id = 46,
    Value = 1541183192,
    ModelInner = new Int32Int32E0MI
{
    Id = 39,
    Value = 178195429,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 47,
    Value = 1069017438,
    ModelInner = new Int32Int32E0MI
{
    Id = 46,
    Value = 935507026,
    NullableValue = null,
},
    NullableValue = 460692207,
},
            new Int32Int32E0M
{
    Id = 50,
    Value = 1129855856,
    ModelInner = new Int32Int32E0MI
{
    Id = 55,
    Value = 1323777394,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 59,
    Value = 1487279606,
    ModelInner = new Int32Int32E0MI
{
    Id = 64,
    Value = 921292025,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 62,
    Value = 1964545809,
    ModelInner = new Int32Int32E0MI
{
    Id = 69,
    Value = 1124632887,
    NullableValue = 614087264,
},
    NullableValue = 973596522,
},
            new Int32Int32E0M
{
    Id = 65,
    Value = 2033030044,
    ModelInner = new Int32Int32E0MI
{
    Id = 72,
    Value = 1928479993,
    NullableValue = null,
},
    NullableValue = 1243087127,
},
            new Int32Int32E0M
{
    Id = 68,
    Value = 477958459,
    ModelInner = new Int32Int32E0MI
{
    Id = 76,
    Value = 108056541,
    NullableValue = 1000516112,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 74,
    Value = 1541953823,
    ModelInner = new Int32Int32E0MI
{
    Id = 78,
    Value = 607594386,
    NullableValue = 1990657708,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 78,
    Value = 1990525701,
    ModelInner = new Int32Int32E0MI
{
    Id = 81,
    Value = 1592066627,
    NullableValue = 1381096854,
},
    NullableValue = 1289408399,
},
            new Int32Int32E0M
{
    Id = 81,
    Value = 1389536088,
    ModelInner = new Int32Int32E0MI
{
    Id = 82,
    Value = 216198325,
    NullableValue = 125767867,
},
    NullableValue = 1239794150,
},
            new Int32Int32E0M
{
    Id = 86,
    Value = 1178987303,
    ModelInner = new Int32Int32E0MI
{
    Id = 91,
    Value = 849231032,
    NullableValue = 1378253110,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 89,
    Value = 254279659,
    ModelInner = new Int32Int32E0MI
{
    Id = 95,
    Value = 975723153,
    NullableValue = null,
},
    NullableValue = 1101030223,
},
            new Int32Int32E0M
{
    Id = 94,
    Value = 1924111942,
    ModelInner = new Int32Int32E0MI
{
    Id = 104,
    Value = 1908069460,
    NullableValue = 352195684,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 103,
    Value = 706893750,
    ModelInner = new Int32Int32E0MI
{
    Id = 111,
    Value = 2138162791,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 107,
    Value = 295580242,
    ModelInner = new Int32Int32E0MI
{
    Id = 114,
    Value = 1929607187,
    NullableValue = 2111097404,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 112,
    Value = 245895897,
    ModelInner = new Int32Int32E0MI
{
    Id = 115,
    Value = 946115319,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 118,
    Value = 2038321108,
    ModelInner = new Int32Int32E0MI
{
    Id = 116,
    Value = 1349220078,
    NullableValue = null,
},
    NullableValue = 869562160,
},
            new Int32Int32E0M
{
    Id = 127,
    Value = 1814271585,
    ModelInner = new Int32Int32E0MI
{
    Id = 120,
    Value = 186387035,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 134,
    Value = 1743796773,
    ModelInner = new Int32Int32E0MI
{
    Id = 125,
    Value = 977169608,
    NullableValue = 1791925666,
},
    NullableValue = 1683998586,
},
            new Int32Int32E0M
{
    Id = 143,
    Value = 991493003,
    ModelInner = new Int32Int32E0MI
{
    Id = 134,
    Value = 1846405941,
    NullableValue = null,
},
    NullableValue = 562561558,
},
            new Int32Int32E0M
{
    Id = 150,
    Value = 1690785717,
    ModelInner = new Int32Int32E0MI
{
    Id = 143,
    Value = 626113676,
    NullableValue = 1020101771,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 156,
    Value = 2011220695,
    ModelInner = new Int32Int32E0MI
{
    Id = 152,
    Value = 2126063636,
    NullableValue = 1919073848,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 164,
    Value = 589724421,
    ModelInner = new Int32Int32E0MI
{
    Id = 158,
    Value = 1115950526,
    NullableValue = 795063373,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 168,
    Value = 1162031711,
    ModelInner = new Int32Int32E0MI
{
    Id = 167,
    Value = 164690421,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 177,
    Value = 821865852,
    ModelInner = new Int32Int32E0MI
{
    Id = 170,
    Value = 376604189,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 183,
    Value = 979317193,
    ModelInner = new Int32Int32E0MI
{
    Id = 178,
    Value = 1721841610,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 185,
    Value = 699709967,
    ModelInner = new Int32Int32E0MI
{
    Id = 187,
    Value = 2080410561,
    NullableValue = null,
},
    NullableValue = 333179852,
},
            new Int32Int32E0M
{
    Id = 193,
    Value = 284624816,
    ModelInner = new Int32Int32E0MI
{
    Id = 191,
    Value = 568382617,
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

