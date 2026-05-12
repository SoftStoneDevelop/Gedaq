

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
    Value = 782542315,
    ModelInner = new Int32Int32E0MI
{
    Id = 6,
    Value = 144227668,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 8,
    Value = 1403799625,
    ModelInner = new Int32Int32E0MI
{
    Id = 11,
    Value = 325342940,
    NullableValue = 2027543831,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 9,
    Value = 808828414,
    ModelInner = new Int32Int32E0MI
{
    Id = 17,
    Value = 916494240,
    NullableValue = null,
},
    NullableValue = 1364422058,
},
            new Int32Int32E0M
{
    Id = 16,
    Value = 991884370,
    ModelInner = new Int32Int32E0MI
{
    Id = 23,
    Value = 1030233484,
    NullableValue = 1599274681,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 21,
    Value = 1727629393,
    ModelInner = new Int32Int32E0MI
{
    Id = 30,
    Value = 344889983,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 30,
    Value = 1293932960,
    ModelInner = new Int32Int32E0MI
{
    Id = 39,
    Value = 1858032679,
    NullableValue = null,
},
    NullableValue = 232542487,
},
            new Int32Int32E0M
{
    Id = 33,
    Value = 2045714956,
    ModelInner = new Int32Int32E0MI
{
    Id = 40,
    Value = 1049690565,
    NullableValue = 333988337,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 39,
    Value = 138100276,
    ModelInner = new Int32Int32E0MI
{
    Id = 41,
    Value = 921378349,
    NullableValue = 1417308215,
},
    NullableValue = 1617044636,
},
            new Int32Int32E0M
{
    Id = 43,
    Value = 696729213,
    ModelInner = new Int32Int32E0MI
{
    Id = 47,
    Value = 50018323,
    NullableValue = null,
},
    NullableValue = 1466106869,
},
            new Int32Int32E0M
{
    Id = 49,
    Value = 1955421418,
    ModelInner = new Int32Int32E0MI
{
    Id = 56,
    Value = 1185341805,
    NullableValue = null,
},
    NullableValue = 236974309,
},
            new Int32Int32E0M
{
    Id = 53,
    Value = 1127669527,
    ModelInner = new Int32Int32E0MI
{
    Id = 62,
    Value = 80492115,
    NullableValue = 613433167,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 59,
    Value = 1397209471,
    ModelInner = new Int32Int32E0MI
{
    Id = 70,
    Value = 818714141,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 67,
    Value = 514864224,
    ModelInner = new Int32Int32E0MI
{
    Id = 78,
    Value = 1592128086,
    NullableValue = 1552076110,
},
    NullableValue = 511291630,
},
            new Int32Int32E0M
{
    Id = 73,
    Value = 2106151987,
    ModelInner = new Int32Int32E0MI
{
    Id = 87,
    Value = 949697612,
    NullableValue = 2020077824,
},
    NullableValue = 1168343113,
},
            new Int32Int32E0M
{
    Id = 82,
    Value = 1280460740,
    ModelInner = new Int32Int32E0MI
{
    Id = 95,
    Value = 592472574,
    NullableValue = 2095200830,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 87,
    Value = 2039496011,
    ModelInner = new Int32Int32E0MI
{
    Id = 98,
    Value = 563328813,
    NullableValue = null,
},
    NullableValue = 136761546,
},
            new Int32Int32E0M
{
    Id = 93,
    Value = 64243372,
    ModelInner = new Int32Int32E0MI
{
    Id = 107,
    Value = 2089442190,
    NullableValue = null,
},
    NullableValue = 475982253,
},
            new Int32Int32E0M
{
    Id = 96,
    Value = 1557918746,
    ModelInner = new Int32Int32E0MI
{
    Id = 111,
    Value = 96208580,
    NullableValue = 772294891,
},
    NullableValue = 653606439,
},
            new Int32Int32E0M
{
    Id = 99,
    Value = 1817060493,
    ModelInner = new Int32Int32E0MI
{
    Id = 115,
    Value = 168387294,
    NullableValue = 1054356209,
},
    NullableValue = 252564759,
},
            new Int32Int32E0M
{
    Id = 108,
    Value = 1606220518,
    ModelInner = new Int32Int32E0MI
{
    Id = 124,
    Value = 1811151550,
    NullableValue = null,
},
    NullableValue = 425220680,
},
            new Int32Int32E0M
{
    Id = 110,
    Value = 274209906,
    ModelInner = new Int32Int32E0MI
{
    Id = 130,
    Value = 1281461023,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 112,
    Value = 449525254,
    ModelInner = new Int32Int32E0MI
{
    Id = 139,
    Value = 864383756,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 121,
    Value = 281899358,
    ModelInner = new Int32Int32E0MI
{
    Id = 145,
    Value = 848883044,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 125,
    Value = 859700026,
    ModelInner = new Int32Int32E0MI
{
    Id = 147,
    Value = 629149299,
    NullableValue = 1224574639,
},
    NullableValue = 43799803,
},
            new Int32Int32E0M
{
    Id = 130,
    Value = 1351810494,
    ModelInner = new Int32Int32E0MI
{
    Id = 153,
    Value = 1033380513,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 135,
    Value = 1272875852,
    ModelInner = new Int32Int32E0MI
{
    Id = 158,
    Value = 1248530817,
    NullableValue = 1526435649,
},
    NullableValue = 32530387,
},
            new Int32Int32E0M
{
    Id = 144,
    Value = 55872986,
    ModelInner = new Int32Int32E0MI
{
    Id = 164,
    Value = 1173668350,
    NullableValue = 1970019927,
},
    NullableValue = 1157631445,
},
            new Int32Int32E0M
{
    Id = 150,
    Value = 1268190147,
    ModelInner = new Int32Int32E0MI
{
    Id = 169,
    Value = 1684532194,
    NullableValue = 179459173,
},
    NullableValue = 2106220755,
},
            new Int32Int32E0M
{
    Id = 153,
    Value = 1377210064,
    ModelInner = new Int32Int32E0MI
{
    Id = 170,
    Value = 1890595260,
    NullableValue = 1777512033,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 160,
    Value = 2012112201,
    ModelInner = new Int32Int32E0MI
{
    Id = 176,
    Value = 1307935299,
    NullableValue = null,
},
    NullableValue = 1049580364,
},
            new Int32Int32E0M
{
    Id = 162,
    Value = 557657523,
    ModelInner = new Int32Int32E0MI
{
    Id = 182,
    Value = 724168572,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 168,
    Value = 959937572,
    ModelInner = new Int32Int32E0MI
{
    Id = 183,
    Value = 1447712684,
    NullableValue = 657345064,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 171,
    Value = 1081552049,
    ModelInner = new Int32Int32E0MI
{
    Id = 192,
    Value = 438234869,
    NullableValue = 1698464326,
},
    NullableValue = 181863114,
},
            new Int32Int32E0M
{
    Id = 178,
    Value = 2144936157,
    ModelInner = new Int32Int32E0MI
{
    Id = 198,
    Value = 1003660891,
    NullableValue = 330492293,
},
    NullableValue = 1249295332,
},
            new Int32Int32E0M
{
    Id = 183,
    Value = 813395483,
    ModelInner = new Int32Int32E0MI
{
    Id = 203,
    Value = 821657730,
    NullableValue = null,
},
    NullableValue = 972600491,
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

