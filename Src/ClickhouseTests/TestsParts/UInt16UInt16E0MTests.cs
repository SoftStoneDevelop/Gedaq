

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
    internal partial interface IUInt16SingleTypeUInt16
    {
    }
    
    internal partial class UInt16SingleTypeUInt16 : IUInt16SingleTypeUInt16
    {


#region TestData

        private readonly UInt16UInt16E0M[] _testData = new UInt16UInt16E0M[]
        {
            new UInt16UInt16E0M
{
    Id = 7,
    Value = 17763,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 1,
    Value = 51678,
    NullableValue = 41479,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 9,
    Value = 18969,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 9,
    Value = 44857,
    NullableValue = null,
},
    NullableValue = 14191,
},
            new UInt16UInt16E0M
{
    Id = 14,
    Value = 5708,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 11,
    Value = 46653,
    NullableValue = null,
},
    NullableValue = 20600,
},
            new UInt16UInt16E0M
{
    Id = 17,
    Value = 37090,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 19,
    Value = 27929,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 19,
    Value = 22282,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 22,
    Value = 3097,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 25,
    Value = 57790,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 29,
    Value = 7019,
    NullableValue = null,
},
    NullableValue = 24148,
},
            new UInt16UInt16E0M
{
    Id = 26,
    Value = 12877,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 36,
    Value = 58891,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 34,
    Value = 5288,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 42,
    Value = 29116,
    NullableValue = null,
},
    NullableValue = 59667,
},
            new UInt16UInt16E0M
{
    Id = 41,
    Value = 50943,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 50,
    Value = 64347,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 42,
    Value = 4177,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 55,
    Value = 21798,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 48,
    Value = 54074,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 62,
    Value = 18701,
    NullableValue = 51977,
},
    NullableValue = 9765,
},
            new UInt16UInt16E0M
{
    Id = 54,
    Value = 24495,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 63,
    Value = 1250,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 61,
    Value = 21654,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 69,
    Value = 54046,
    NullableValue = 55670,
},
    NullableValue = 37937,
},
            new UInt16UInt16E0M
{
    Id = 70,
    Value = 5654,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 75,
    Value = 16146,
    NullableValue = 4005,
},
    NullableValue = 51110,
},
            new UInt16UInt16E0M
{
    Id = 79,
    Value = 17310,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 79,
    Value = 7839,
    NullableValue = 46372,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 88,
    Value = 28469,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 87,
    Value = 22620,
    NullableValue = 23899,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 96,
    Value = 47632,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 96,
    Value = 25128,
    NullableValue = 44606,
},
    NullableValue = 38074,
},
            new UInt16UInt16E0M
{
    Id = 104,
    Value = 20504,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 104,
    Value = 54696,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 105,
    Value = 24907,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 107,
    Value = 59459,
    NullableValue = 14226,
},
    NullableValue = 15121,
},
            new UInt16UInt16E0M
{
    Id = 113,
    Value = 48146,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 111,
    Value = 61952,
    NullableValue = 14614,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 115,
    Value = 36786,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 117,
    Value = 42775,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 119,
    Value = 33095,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 120,
    Value = 12149,
    NullableValue = null,
},
    NullableValue = 19600,
},
            new UInt16UInt16E0M
{
    Id = 120,
    Value = 64864,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 126,
    Value = 4215,
    NullableValue = 48855,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 126,
    Value = 52777,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 135,
    Value = 43272,
    NullableValue = null,
},
    NullableValue = 31496,
},
            new UInt16UInt16E0M
{
    Id = 132,
    Value = 21479,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 136,
    Value = 10044,
    NullableValue = 49883,
},
    NullableValue = 57091,
},
            new UInt16UInt16E0M
{
    Id = 137,
    Value = 39553,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 142,
    Value = 6636,
    NullableValue = 31418,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 141,
    Value = 38626,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 143,
    Value = 4243,
    NullableValue = null,
},
    NullableValue = 35205,
},
            new UInt16UInt16E0M
{
    Id = 149,
    Value = 58797,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 145,
    Value = 22037,
    NullableValue = 11521,
},
    NullableValue = 61786,
},
            new UInt16UInt16E0M
{
    Id = 150,
    Value = 44218,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 153,
    Value = 1274,
    NullableValue = 24536,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 156,
    Value = 22974,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 157,
    Value = 22649,
    NullableValue = null,
},
    NullableValue = 51793,
},
            new UInt16UInt16E0M
{
    Id = 158,
    Value = 51437,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 162,
    Value = 12166,
    NullableValue = 63871,
},
    NullableValue = 22224,
},
            new UInt16UInt16E0M
{
    Id = 159,
    Value = 25097,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 163,
    Value = 52267,
    NullableValue = null,
},
    NullableValue = 22728,
},
            new UInt16UInt16E0M
{
    Id = 163,
    Value = 3291,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 164,
    Value = 42565,
    NullableValue = null,
},
    NullableValue = 5154,
},
            new UInt16UInt16E0M
{
    Id = 167,
    Value = 37607,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 168,
    Value = 21286,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 174,
    Value = 13813,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 175,
    Value = 63590,
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
INSERT INTO gedaqtests.uint16uint16e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt16}, 
    {mi_id:Int32},
    {mi_value:UInt16}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
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
                    await ((IUInt16SingleTypeUInt16)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16SingleTypeUInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16uint16e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16UInt16E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
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
                    var models = await ((IUInt16SingleTypeUInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16SingleTypeUInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

