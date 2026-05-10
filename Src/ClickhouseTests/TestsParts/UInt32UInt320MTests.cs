

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
    internal partial interface IUInt32SingleTypeUInt32
    {
    }
    
    internal partial class UInt32SingleTypeUInt32 : IUInt32SingleTypeUInt32
    {


#region TestData

        private readonly UInt32UInt320M[] _testData = new UInt32UInt320M[]
        {
            new UInt32UInt320M
{
    Id = 5,
    Value = 2449092107,
    ModelInner = new UInt32UInt320MI
{
    Id = 9,
    Value = 2802244181,
    NullableValue = 1311742190,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 11,
    Value = 2607199249,
    ModelInner = new UInt32UInt320MI
{
    Id = 18,
    Value = 560635604,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 18,
    Value = 2214305544,
    ModelInner = new UInt32UInt320MI
{
    Id = 21,
    Value = 603943830,
    NullableValue = 4179911753,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 20,
    Value = 785822660,
    ModelInner = new UInt32UInt320MI
{
    Id = 29,
    Value = 2640635229,
    NullableValue = 2827101170,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 24,
    Value = 3408996860,
    ModelInner = new UInt32UInt320MI
{
    Id = 31,
    Value = 3292698902,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 30,
    Value = 1864836837,
    ModelInner = new UInt32UInt320MI
{
    Id = 37,
    Value = 1273385015,
    NullableValue = 3234929438,
},
    NullableValue = 924501030,
},
            new UInt32UInt320M
{
    Id = 36,
    Value = 4230254733,
    ModelInner = new UInt32UInt320MI
{
    Id = 43,
    Value = 2341273164,
    NullableValue = null,
},
    NullableValue = 1037665503,
},
            new UInt32UInt320M
{
    Id = 37,
    Value = 112363012,
    ModelInner = new UInt32UInt320MI
{
    Id = 44,
    Value = 857447721,
    NullableValue = 2978209456,
},
    NullableValue = 2576151574,
},
            new UInt32UInt320M
{
    Id = 41,
    Value = 3615366519,
    ModelInner = new UInt32UInt320MI
{
    Id = 46,
    Value = 169001617,
    NullableValue = 1922390689,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 49,
    Value = 892198264,
    ModelInner = new UInt32UInt320MI
{
    Id = 52,
    Value = 2318304924,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 51,
    Value = 3575897437,
    ModelInner = new UInt32UInt320MI
{
    Id = 59,
    Value = 2912144584,
    NullableValue = 1384781108,
},
    NullableValue = 757909787,
},
            new UInt32UInt320M
{
    Id = 52,
    Value = 3320752524,
    ModelInner = new UInt32UInt320MI
{
    Id = 67,
    Value = 2810075711,
    NullableValue = 3056770581,
},
    NullableValue = 1465426095,
},
            new UInt32UInt320M
{
    Id = 57,
    Value = 2660053105,
    ModelInner = new UInt32UInt320MI
{
    Id = 75,
    Value = 1573567419,
    NullableValue = null,
},
    NullableValue = 1496426950,
},
            new UInt32UInt320M
{
    Id = 62,
    Value = 2232446799,
    ModelInner = new UInt32UInt320MI
{
    Id = 81,
    Value = 2902166927,
    NullableValue = 2488560277,
},
    NullableValue = 642395082,
},
            new UInt32UInt320M
{
    Id = 65,
    Value = 3343249500,
    ModelInner = new UInt32UInt320MI
{
    Id = 89,
    Value = 3004013631,
    NullableValue = null,
},
    NullableValue = 3470614205,
},
            new UInt32UInt320M
{
    Id = 69,
    Value = 574752711,
    ModelInner = new UInt32UInt320MI
{
    Id = 93,
    Value = 3812042664,
    NullableValue = 1695483249,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 72,
    Value = 3873876869,
    ModelInner = new UInt32UInt320MI
{
    Id = 102,
    Value = 826700566,
    NullableValue = null,
},
    NullableValue = 3995112629,
},
            new UInt32UInt320M
{
    Id = 75,
    Value = 520998161,
    ModelInner = new UInt32UInt320MI
{
    Id = 110,
    Value = 609260899,
    NullableValue = 3833012152,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 81,
    Value = 1010061769,
    ModelInner = new UInt32UInt320MI
{
    Id = 117,
    Value = 4164698999,
    NullableValue = 3420221983,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 83,
    Value = 1498556901,
    ModelInner = new UInt32UInt320MI
{
    Id = 120,
    Value = 2769591856,
    NullableValue = null,
},
    NullableValue = 1953962597,
},
            new UInt32UInt320M
{
    Id = 92,
    Value = 3632245929,
    ModelInner = new UInt32UInt320MI
{
    Id = 129,
    Value = 2107210913,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 97,
    Value = 682884648,
    ModelInner = new UInt32UInt320MI
{
    Id = 138,
    Value = 2394064513,
    NullableValue = null,
},
    NullableValue = 1676704360,
},
            new UInt32UInt320M
{
    Id = 103,
    Value = 1307491845,
    ModelInner = new UInt32UInt320MI
{
    Id = 140,
    Value = 2550198816,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 112,
    Value = 1944304212,
    ModelInner = new UInt32UInt320MI
{
    Id = 141,
    Value = 3014012884,
    NullableValue = null,
},
    NullableValue = 94660458,
},
            new UInt32UInt320M
{
    Id = 113,
    Value = 2486780179,
    ModelInner = new UInt32UInt320MI
{
    Id = 142,
    Value = 3983021729,
    NullableValue = 3069721007,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 119,
    Value = 2946715828,
    ModelInner = new UInt32UInt320MI
{
    Id = 146,
    Value = 3720242312,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 125,
    Value = 669173450,
    ModelInner = new UInt32UInt320MI
{
    Id = 150,
    Value = 2458646808,
    NullableValue = 833065993,
},
    NullableValue = 869551898,
},
            new UInt32UInt320M
{
    Id = 128,
    Value = 3803354903,
    ModelInner = new UInt32UInt320MI
{
    Id = 157,
    Value = 1140758884,
    NullableValue = 1560673509,
},
    NullableValue = 1914873445,
},
            new UInt32UInt320M
{
    Id = 129,
    Value = 2878672018,
    ModelInner = new UInt32UInt320MI
{
    Id = 160,
    Value = 2174431942,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 136,
    Value = 330040926,
    ModelInner = new UInt32UInt320MI
{
    Id = 166,
    Value = 4187794797,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 138,
    Value = 2774021875,
    ModelInner = new UInt32UInt320MI
{
    Id = 168,
    Value = 2067437436,
    NullableValue = null,
},
    NullableValue = 2076165432,
},
            new UInt32UInt320M
{
    Id = 147,
    Value = 3746547552,
    ModelInner = new UInt32UInt320MI
{
    Id = 170,
    Value = 1624264069,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt320M
{
    Id = 153,
    Value = 4033000128,
    ModelInner = new UInt32UInt320MI
{
    Id = 178,
    Value = 231280609,
    NullableValue = null,
},
    NullableValue = 3866322693,
},
            new UInt32UInt320M
{
    Id = 160,
    Value = 3097383884,
    ModelInner = new UInt32UInt320MI
{
    Id = 179,
    Value = 1514104100,
    NullableValue = null,
},
    NullableValue = 2038487449,
},
            new UInt32UInt320M
{
    Id = 167,
    Value = 3865580514,
    ModelInner = new UInt32UInt320MI
{
    Id = 184,
    Value = 1888828596,
    NullableValue = 3606806117,
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
INSERT INTO gedaqtests.uint32uint320m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt32}, 
    {mi_id:Int32},
    {mi_value:UInt32}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
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
                    await ((IUInt32SingleTypeUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32SingleTypeUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32uint320m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt320M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
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
                    var models = await ((IUInt32SingleTypeUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt320M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32SingleTypeUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt320M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

