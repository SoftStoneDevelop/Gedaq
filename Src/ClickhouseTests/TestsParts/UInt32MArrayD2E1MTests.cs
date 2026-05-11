

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
    internal partial interface IUInt32MArrayMArrayD2
    {
    }
    
    internal partial class UInt32MArrayMArrayD2 : IUInt32MArrayMArrayD2
    {


#region TestData

        private readonly UInt32MArrayD2E1M[] _testData = new UInt32MArrayD2E1M[]
        {
            new UInt32MArrayD2E1M
{
    Id = 6,
    Value = 
new System.UInt32[,] { {
526355833,
1649461180, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.UInt32[,] { {
1602672035,
570264418, } },
    NullableValue = 
new System.UInt32[,] { {
2227885336,
624914197, } },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 15,
    Value = 
new System.UInt32[,] { {
199508570,
251319033, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.UInt32[,] { {
3779039802,
3803758722, } },
    NullableValue = 
new System.UInt32[,] { {
2040977493,
3757041918, } },
},
    NullableValue = 
new System.UInt32[,] { {
3279604954,
1330217099, } },
},
            new UInt32MArrayD2E1M
{
    Id = 21,
    Value = 
new System.UInt32[,] { {
1136697546,
116911483, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 12,
    Value = 
new System.UInt32[,] { {
2374277847,
133895256, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
2657497999,
2487603358, } },
},
            new UInt32MArrayD2E1M
{
    Id = 22,
    Value = 
new System.UInt32[,] { {
1027313545,
3724366896, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.UInt32[,] { {
2242298962,
4177394222, } },
    NullableValue = 
new System.UInt32[,] { {
590569925,
525721828, } },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 26,
    Value = 
new System.UInt32[,] { {
2720441661,
593082040, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 16,
    Value = 
new System.UInt32[,] { {
3004406500,
2212417947, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
4097847892,
3926299519, } },
},
            new UInt32MArrayD2E1M
{
    Id = 34,
    Value = 
new System.UInt32[,] { {
889584562,
1070035267, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt32[,] { {
1871336985,
4228974181, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
1789298859,
2743425173, } },
},
            new UInt32MArrayD2E1M
{
    Id = 39,
    Value = 
new System.UInt32[,] { {
813043516,
1249847073, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.UInt32[,] { {
1538546935,
3983064752, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 41,
    Value = 
new System.UInt32[,] { {
3070999866,
3034871169, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.UInt32[,] { {
3432366073,
3617753592, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
2447249406,
2325231674, } },
},
            new UInt32MArrayD2E1M
{
    Id = 46,
    Value = 
new System.UInt32[,] { {
542085770,
978747174, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 39,
    Value = 
new System.UInt32[,] { {
2879174842,
4179654064, } },
    NullableValue = 
new System.UInt32[,] { {
2522820183,
534805594, } },
},
    NullableValue = 
new System.UInt32[,] { {
839723014,
2762150631, } },
},
            new UInt32MArrayD2E1M
{
    Id = 49,
    Value = 
new System.UInt32[,] { {
1507578232,
1072191191, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 44,
    Value = 
new System.UInt32[,] { {
3705027818,
604136831, } },
    NullableValue = 
new System.UInt32[,] { {
3283406709,
3392602627, } },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 52,
    Value = 
new System.UInt32[,] { {
4038182151,
3565677630, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt32[,] { {
2438589202,
811687042, } },
    NullableValue = 
new System.UInt32[,] { {
3645386797,
4037697564, } },
},
    NullableValue = 
new System.UInt32[,] { {
1279155711,
4252508179, } },
},
            new UInt32MArrayD2E1M
{
    Id = 61,
    Value = 
new System.UInt32[,] { {
3804205484,
1007513747, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 47,
    Value = 
new System.UInt32[,] { {
183658696,
799425852, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
2651309934,
1217939261, } },
},
            new UInt32MArrayD2E1M
{
    Id = 64,
    Value = 
new System.UInt32[,] { {
3089458431,
2170366211, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.UInt32[,] { {
2961549592,
781608883, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 66,
    Value = 
new System.UInt32[,] { {
362530173,
84253739, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 56,
    Value = 
new System.UInt32[,] { {
779140662,
4187748247, } },
    NullableValue = 
new System.UInt32[,] { {
3608681591,
4061069680, } },
},
    NullableValue = 
new System.UInt32[,] { {
1026287649,
557587460, } },
},
            new UInt32MArrayD2E1M
{
    Id = 69,
    Value = 
new System.UInt32[,] { {
4239242886,
3346060937, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.UInt32[,] { {
4184294400,
999084521, } },
    NullableValue = 
new System.UInt32[,] { {
1464599755,
2713489801, } },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 75,
    Value = 
new System.UInt32[,] { {
821068750,
2935515208, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.UInt32[,] { {
207333882,
991770521, } },
    NullableValue = 
new System.UInt32[,] { {
494607652,
3514982514, } },
},
    NullableValue = 
new System.UInt32[,] { {
1024693966,
2540946664, } },
},
            new UInt32MArrayD2E1M
{
    Id = 77,
    Value = 
new System.UInt32[,] { {
215655343,
305239346, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 74,
    Value = 
new System.UInt32[,] { {
4182055340,
501237785, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 81,
    Value = 
new System.UInt32[,] { {
2563805500,
3847157636, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt32[,] { {
3663902188,
821434033, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 84,
    Value = 
new System.UInt32[,] { {
1055230496,
3562669846, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.UInt32[,] { {
4254222063,
1982301482, } },
    NullableValue = 
new System.UInt32[,] { {
138299370,
1689246733, } },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 87,
    Value = 
new System.UInt32[,] { {
3698027801,
26245479, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.UInt32[,] { {
2262493697,
3472439494, } },
    NullableValue = 
new System.UInt32[,] { {
2652525104,
1478537847, } },
},
    NullableValue = 
new System.UInt32[,] { {
2258444487,
2075056587, } },
},
            new UInt32MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt32[,] { {
1042560749,
882949588, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.UInt32[,] { {
2625903041,
1364600758, } },
    NullableValue = 
new System.UInt32[,] { {
1193891643,
3100471191, } },
},
    NullableValue = 
new System.UInt32[,] { {
2607248768,
3633212068, } },
},
            new UInt32MArrayD2E1M
{
    Id = 94,
    Value = 
new System.UInt32[,] { {
1907938271,
3075514762, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.UInt32[,] { {
2515656159,
935829007, } },
    NullableValue = 
new System.UInt32[,] { {
4222210264,
3792426460, } },
},
    NullableValue = 
new System.UInt32[,] { {
400066715,
624869642, } },
},
            new UInt32MArrayD2E1M
{
    Id = 103,
    Value = 
new System.UInt32[,] { {
4084711290,
573172337, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.UInt32[,] { {
1690898982,
3273041385, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 112,
    Value = 
new System.UInt32[,] { {
4222596122,
3264575159, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.UInt32[,] { {
536142670,
2170669441, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
2649467220,
4242730791, } },
},
            new UInt32MArrayD2E1M
{
    Id = 121,
    Value = 
new System.UInt32[,] { {
2180388464,
363095539, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.UInt32[,] { {
1861165924,
3147600290, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 128,
    Value = 
new System.UInt32[,] { {
2156673334,
688798828, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.UInt32[,] { {
1646876286,
717835467, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 136,
    Value = 
new System.UInt32[,] { {
3622372330,
1590876727, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 144,
    Value = 
new System.UInt32[,] { {
1309961556,
2214866585, } },
    NullableValue = 
new System.UInt32[,] { {
3619196062,
3723674773, } },
},
    NullableValue = 
new System.UInt32[,] { {
2673157890,
369276715, } },
},
            new UInt32MArrayD2E1M
{
    Id = 140,
    Value = 
new System.UInt32[,] { {
1405587192,
1028674277, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.UInt32[,] { {
1184360133,
4004947257, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
521029941,
1967616948, } },
},
            new UInt32MArrayD2E1M
{
    Id = 148,
    Value = 
new System.UInt32[,] { {
3786214330,
2205653073, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.UInt32[,] { {
729256515,
4080414376, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
3338023196,
2605903063, } },
},
            new UInt32MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt32[,] { {
3138647546,
2665741685, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.UInt32[,] { {
3008029330,
3810807557, } },
    NullableValue = 
new System.UInt32[,] { {
1114461552,
4066225309, } },
},
    NullableValue = 
new System.UInt32[,] { {
259408935,
3083254388, } },
},
            new UInt32MArrayD2E1M
{
    Id = 158,
    Value = 
new System.UInt32[,] { {
1151281658,
3758145383, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 167,
    Value = 
new System.UInt32[,] { {
648495987,
2277709600, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 167,
    Value = 
new System.UInt32[,] { {
4241668375,
1098970013, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 173,
    Value = 
new System.UInt32[,] { {
645530201,
2929037976, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
961452562,
2675277570, } },
},
            new UInt32MArrayD2E1M
{
    Id = 170,
    Value = 
new System.UInt32[,] { {
1130192550,
1586211298, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 177,
    Value = 
new System.UInt32[,] { {
200897100,
3634006361, } },
    NullableValue = 
new System.UInt32[,] { {
3885273356,
3054892111, } },
},
    NullableValue = null,
},
            new UInt32MArrayD2E1M
{
    Id = 176,
    Value = 
new System.UInt32[,] { {
4047382253,
1610100876, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 180,
    Value = 
new System.UInt32[,] { {
2197492153,
501535719, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt32[,] { {
2198844745,
162739397, } },
},
            new UInt32MArrayD2E1M
{
    Id = 184,
    Value = 
new System.UInt32[,] { {
1441666445,
1291323593, } },
    ModelInner = new UInt32MArrayD2E1MI
{
    Id = 186,
    Value = 
new System.UInt32[,] { {
3883785994,
3193415996, } },
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
INSERT INTO gedaqtests.uint32marrayd2e1m(
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
            asPartInterface: typeof(IUInt32MArrayMArrayD2)),
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
                    await ((IUInt32MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32MArrayMArrayD2)),
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
                    var models = await ((IUInt32MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

