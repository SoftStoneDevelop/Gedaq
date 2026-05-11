

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
    internal partial interface IUInt32MArrayArrayArrayUInt32
    {
    }
    
    internal partial class UInt32MArrayArrayArrayUInt32 : IUInt32MArrayArrayArrayUInt32
    {


#region TestData

        private readonly UInt32ArrayArrayUInt32E1M[] _testData = new UInt32ArrayArrayUInt32E1M[]
        {
            new UInt32ArrayArrayUInt32E1M
{
    Id = 9,
    Value = 
new System.UInt32[,] { {
3221999452,
2348699178, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 2,
    Value = 
new System.UInt32[,] { {
460454935,
632939797, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 18,
    Value = 
new System.UInt32[,] { {
3121996117,
491303515, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 4,
    Value = 
new System.UInt32[,] { {
3746502980,
2983283979, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 24,
    Value = 
new System.UInt32[,] { {
2882851597,
3273476908, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 12,
    Value = 
new System.UInt32[,] { {
2092666247,
1176130475, } },
    NullableValue = 
new System.UInt32[,] { {
2537726449,
8883496, } },
},
    NullableValue = 
new System.UInt32[,] { {
1003999213,
513727040, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 30,
    Value = 
new System.UInt32[,] { {
1319956918,
3969242541, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 20,
    Value = 
new System.UInt32[,] { {
158444147,
4019211495, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
511822882,
690795777, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 39,
    Value = 
new System.UInt32[,] { {
352328916,
2471328100, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 24,
    Value = 
new System.UInt32[,] { {
195842111,
2346177925, } },
    NullableValue = 
new System.UInt32[,] { {
4236084796,
941824038, } },
},
    NullableValue = 
new System.UInt32[,] { {
3624139733,
1074682718, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 46,
    Value = 
new System.UInt32[,] { {
452576678,
3894420101, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 33,
    Value = 
new System.UInt32[,] { {
1707181997,
1347673185, } },
    NullableValue = 
new System.UInt32[,] { {
2102427819,
2145601508, } },
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 51,
    Value = 
new System.UInt32[,] { {
2106641699,
63062522, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 36,
    Value = 
new System.UInt32[,] { {
1274444926,
4170327742, } },
    NullableValue = 
new System.UInt32[,] { {
1473282758,
2124773897, } },
},
    NullableValue = 
new System.UInt32[,] { {
821971117,
902366055, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 60,
    Value = 
new System.UInt32[,] { {
184424927,
4226805753, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 42,
    Value = 
new System.UInt32[,] { {
1543043521,
4146746641, } },
    NullableValue = 
new System.UInt32[,] { {
2054958970,
4249827196, } },
},
    NullableValue = 
new System.UInt32[,] { {
1761052093,
4007249162, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 62,
    Value = 
new System.UInt32[,] { {
3994556755,
1831105597, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 48,
    Value = 
new System.UInt32[,] { {
2822540287,
491902312, } },
    NullableValue = 
new System.UInt32[,] { {
526879114,
2217591449, } },
},
    NullableValue = 
new System.UInt32[,] { {
838305205,
4118180031, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 71,
    Value = 
new System.UInt32[,] { {
560595738,
2762847130, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 54,
    Value = 
new System.UInt32[,] { {
1784986697,
279081601, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 78,
    Value = 
new System.UInt32[,] { {
640092041,
626424076, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 63,
    Value = 
new System.UInt32[,] { {
1970823417,
3016782055, } },
    NullableValue = 
new System.UInt32[,] { {
2261092347,
881972332, } },
},
    NullableValue = 
new System.UInt32[,] { {
390848600,
2086000158, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 86,
    Value = 
new System.UInt32[,] { {
2650575849,
272349571, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 68,
    Value = 
new System.UInt32[,] { {
755304827,
3435451850, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 95,
    Value = 
new System.UInt32[,] { {
4260570681,
108220415, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 75,
    Value = 
new System.UInt32[,] { {
1518800716,
1500374366, } },
    NullableValue = 
new System.UInt32[,] { {
3523639205,
4068208510, } },
},
    NullableValue = 
new System.UInt32[,] { {
162809588,
1800412403, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 100,
    Value = 
new System.UInt32[,] { {
3225161146,
2665787933, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 82,
    Value = 
new System.UInt32[,] { {
324145526,
3483330143, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 103,
    Value = 
new System.UInt32[,] { {
1911016073,
69753047, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 90,
    Value = 
new System.UInt32[,] { {
2416959001,
3911600023, } },
    NullableValue = 
new System.UInt32[,] { {
818244019,
656617684, } },
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 105,
    Value = 
new System.UInt32[,] { {
1775364951,
3915418324, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 91,
    Value = 
new System.UInt32[,] { {
3141644838,
1181849663, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 109,
    Value = 
new System.UInt32[,] { {
2211728630,
2975646945, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 99,
    Value = 
new System.UInt32[,] { {
2272686736,
2863773243, } },
    NullableValue = 
new System.UInt32[,] { {
1501990163,
3668445370, } },
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 111,
    Value = 
new System.UInt32[,] { {
3865062764,
1351758860, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 103,
    Value = 
new System.UInt32[,] { {
4280490730,
453066200, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
3443030890,
3260875944, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 116,
    Value = 
new System.UInt32[,] { {
2059190850,
3475715376, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 106,
    Value = 
new System.UInt32[,] { {
733108457,
2530880391, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
624428854,
127487787, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 122,
    Value = 
new System.UInt32[,] { {
3993225180,
203899544, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 112,
    Value = 
new System.UInt32[,] { {
3169624665,
3274634414, } },
    NullableValue = 
new System.UInt32[,] { {
3331597776,
3807173350, } },
},
    NullableValue = 
new System.UInt32[,] { {
1241497761,
600127636, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 124,
    Value = 
new System.UInt32[,] { {
3847488038,
2787983428, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 116,
    Value = 
new System.UInt32[,] { {
981836911,
532100787, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 125,
    Value = 
new System.UInt32[,] { {
4012334536,
3641998359, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 124,
    Value = 
new System.UInt32[,] { {
4218196559,
1840474715, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 132,
    Value = 
new System.UInt32[,] { {
1308744367,
2562815850, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 129,
    Value = 
new System.UInt32[,] { {
2513059123,
4096943441, } },
    NullableValue = 
new System.UInt32[,] { {
1894902805,
3602042815, } },
},
    NullableValue = 
new System.UInt32[,] { {
2511145421,
3431609009, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 134,
    Value = 
new System.UInt32[,] { {
892202070,
3538388996, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 131,
    Value = 
new System.UInt32[,] { {
554305046,
2254297087, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
1238185889,
1354635847, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 137,
    Value = 
new System.UInt32[,] { {
549273464,
271105956, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 137,
    Value = 
new System.UInt32[,] { {
2635741647,
952474531, } },
    NullableValue = 
new System.UInt32[,] { {
3820386175,
3837511488, } },
},
    NullableValue = 
new System.UInt32[,] { {
1455186454,
974486130, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 145,
    Value = 
new System.UInt32[,] { {
375482513,
3702334633, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 142,
    Value = 
new System.UInt32[,] { {
1750276682,
1046036223, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
1223888501,
2045488040, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 150,
    Value = 
new System.UInt32[,] { {
683658995,
3649075131, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 145,
    Value = 
new System.UInt32[,] { {
661325209,
856789218, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
2138460425,
369159449, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 153,
    Value = 
new System.UInt32[,] { {
4136275059,
734448491, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 152,
    Value = 
new System.UInt32[,] { {
3931118715,
3546262769, } },
    NullableValue = 
new System.UInt32[,] { {
4127773724,
2381515764, } },
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 154,
    Value = 
new System.UInt32[,] { {
294739553,
3112064709, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 155,
    Value = 
new System.UInt32[,] { {
4242410386,
2257107288, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 162,
    Value = 
new System.UInt32[,] { {
3245495665,
692340238, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 158,
    Value = 
new System.UInt32[,] { {
1889097286,
999874729, } },
    NullableValue = 
new System.UInt32[,] { {
2694227080,
3310631858, } },
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 169,
    Value = 
new System.UInt32[,] { {
4118818611,
260535135, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 167,
    Value = 
new System.UInt32[,] { {
1110930928,
4105823140, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 177,
    Value = 
new System.UInt32[,] { {
1942636667,
2515101997, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 175,
    Value = 
new System.UInt32[,] { {
3964448804,
2593473609, } },
    NullableValue = 
new System.UInt32[,] { {
8802149,
3756880433, } },
},
    NullableValue = 
new System.UInt32[,] { {
1208967239,
4093094726, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 183,
    Value = 
new System.UInt32[,] { {
1254162800,
950726139, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 182,
    Value = 
new System.UInt32[,] { {
2927748551,
2660793305, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
123980048,
233968498, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 186,
    Value = 
new System.UInt32[,] { {
1302680880,
1140626818, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 188,
    Value = 
new System.UInt32[,] { {
4123883514,
291485280, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
4153888238,
1881739283, } },
},
            new UInt32ArrayArrayUInt32E1M
{
    Id = 189,
    Value = 
new System.UInt32[,] { {
2199143698,
2700770837, } },
    ModelInner = new UInt32ArrayArrayUInt321MI
{
    Id = 189,
    Value = 
new System.UInt32[,] { {
2567781729,
1787276001, } },
    NullableValue = 
new System.UInt32[,] { {
3700495251,
1537340704, } },
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
INSERT INTO gedaqtests.uint32arrayarrayuint32e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt32))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt32))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayArrayArrayUInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32[,]), 
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
                    await ((IUInt32MArrayArrayArrayUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32MArrayArrayArrayUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32arrayarrayuint32e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32ArrayArrayUInt32E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayArrayArrayUInt32)),
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
                    var models = await ((IUInt32MArrayArrayArrayUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32ArrayArrayUInt32E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32MArrayArrayArrayUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32ArrayArrayUInt32E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

