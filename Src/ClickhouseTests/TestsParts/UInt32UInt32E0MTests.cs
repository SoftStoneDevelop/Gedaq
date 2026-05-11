

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

        private readonly UInt32UInt32E0M[] _testData = new UInt32UInt32E0M[]
        {
            new UInt32UInt32E0M
{
    Id = 9,
    Value = 1611811100,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 5,
    Value = 3240798575,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 10,
    Value = 2860892490,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 8,
    Value = 2466835342,
    NullableValue = 543434499,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 15,
    Value = 2294942233,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 11,
    Value = 2160973960,
    NullableValue = null,
},
    NullableValue = 450540780,
},
            new UInt32UInt32E0M
{
    Id = 19,
    Value = 2034874487,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 13,
    Value = 1848415035,
    NullableValue = 690086295,
},
    NullableValue = 3226659085,
},
            new UInt32UInt32E0M
{
    Id = 21,
    Value = 3697096635,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 20,
    Value = 90679850,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 23,
    Value = 1623824313,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 22,
    Value = 908940807,
    NullableValue = 1700726029,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 31,
    Value = 875132871,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 27,
    Value = 1430274172,
    NullableValue = 1466067790,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 36,
    Value = 708930019,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 33,
    Value = 672039436,
    NullableValue = null,
},
    NullableValue = 347839271,
},
            new UInt32UInt32E0M
{
    Id = 41,
    Value = 48986869,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 41,
    Value = 2746864634,
    NullableValue = null,
},
    NullableValue = 1596545741,
},
            new UInt32UInt32E0M
{
    Id = 49,
    Value = 2580333336,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 43,
    Value = 2093593871,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 56,
    Value = 2367900157,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 50,
    Value = 890635097,
    NullableValue = 3122028597,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 59,
    Value = 502890917,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 58,
    Value = 1408773726,
    NullableValue = 2933558832,
},
    NullableValue = 3252619293,
},
            new UInt32UInt32E0M
{
    Id = 61,
    Value = 4289051094,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 63,
    Value = 3761841204,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 62,
    Value = 842356556,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 64,
    Value = 282020595,
    NullableValue = 3001581332,
},
    NullableValue = 2988668744,
},
            new UInt32UInt32E0M
{
    Id = 71,
    Value = 1900072141,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 73,
    Value = 3581220579,
    NullableValue = 27162013,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 79,
    Value = 2974005472,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 77,
    Value = 50227464,
    NullableValue = 3594901382,
},
    NullableValue = 2655026478,
},
            new UInt32UInt32E0M
{
    Id = 86,
    Value = 3304928028,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 86,
    Value = 991522787,
    NullableValue = null,
},
    NullableValue = 2734905346,
},
            new UInt32UInt32E0M
{
    Id = 94,
    Value = 2346528279,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 90,
    Value = 34087757,
    NullableValue = 3739788412,
},
    NullableValue = 2614741076,
},
            new UInt32UInt32E0M
{
    Id = 98,
    Value = 2103558761,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 97,
    Value = 3270776588,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 104,
    Value = 1328007263,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 98,
    Value = 1762598115,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 109,
    Value = 4090077102,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 106,
    Value = 3292729253,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 117,
    Value = 1593322364,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 114,
    Value = 4113004455,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 123,
    Value = 2980368433,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 120,
    Value = 1164915324,
    NullableValue = 401496083,
},
    NullableValue = 1028354925,
},
            new UInt32UInt32E0M
{
    Id = 124,
    Value = 166851059,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 122,
    Value = 2651781028,
    NullableValue = 3186591008,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 133,
    Value = 521982905,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 125,
    Value = 812905267,
    NullableValue = 527397236,
},
    NullableValue = 3315751975,
},
            new UInt32UInt32E0M
{
    Id = 138,
    Value = 212906886,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 126,
    Value = 3287309691,
    NullableValue = 520103175,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 145,
    Value = 821477759,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 131,
    Value = 221984218,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 148,
    Value = 553452881,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 133,
    Value = 3494676424,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 151,
    Value = 1246634359,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 136,
    Value = 3118146838,
    NullableValue = 3885020536,
},
    NullableValue = 1725789939,
},
            new UInt32UInt32E0M
{
    Id = 160,
    Value = 2165029257,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 142,
    Value = 1104901665,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 164,
    Value = 3348608528,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 146,
    Value = 1377463659,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 169,
    Value = 550876587,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 149,
    Value = 1892354342,
    NullableValue = null,
},
    NullableValue = 289673907,
},
            new UInt32UInt32E0M
{
    Id = 172,
    Value = 2199954159,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 150,
    Value = 3857003423,
    NullableValue = 2468708475,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 176,
    Value = 2096143339,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 156,
    Value = 3424942480,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 183,
    Value = 2951768862,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 160,
    Value = 2796819643,
    NullableValue = 2726978617,
},
    NullableValue = 3398997774,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint32uint32e0m(
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
FROM gedaqtests.uint32uint32e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt32E0M)],
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
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
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
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

