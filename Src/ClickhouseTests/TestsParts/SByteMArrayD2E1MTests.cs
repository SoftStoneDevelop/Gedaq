

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
    internal partial interface ISByteMArrayMArrayD2
    {
    }
    
    internal partial class SByteMArrayMArrayD2 : ISByteMArrayMArrayD2
    {


#region TestData

        private readonly SByteMArrayD2E1M[] _testData = new SByteMArrayD2E1M[]
        {
            new SByteMArrayD2E1M
{
    Id = 6,
    Value = 
new System.SByte[,] { { -23, 30, }, { -29, -80, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.SByte[,] { { 31, -27, }, { 25, 45, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 8,
    Value = 
new System.SByte[,] { { 111, 63, }, { 52, -11, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.SByte[,] { { -89, -111, }, { -86, -100, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 11,
    Value = 
new System.SByte[,] { { -114, -105, }, { 105, 58, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.SByte[,] { { 43, 94, }, { 16, -112, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 109, -104, }, { 51, -17, }, },
},
            new SByteMArrayD2E1M
{
    Id = 17,
    Value = 
new System.SByte[,] { { 100, -13, }, { 3, -49, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.SByte[,] { { 42, -36, }, { -126, -45, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 20,
    Value = 
new System.SByte[,] { { 26, 57, }, { -60, 21, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.SByte[,] { { 64, -75, }, { 107, 110, }, },
    NullableValue = 
new System.SByte[,] { { 55, 53, }, { -61, -128, }, },
},
    NullableValue = 
new System.SByte[,] { { 103, 124, }, { -1, -75, }, },
},
            new SByteMArrayD2E1M
{
    Id = 28,
    Value = 
new System.SByte[,] { { -12, -37, }, { -47, 12, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.SByte[,] { { -10, 32, }, { 86, 125, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -59, -46, }, { 53, -8, }, },
},
            new SByteMArrayD2E1M
{
    Id = 31,
    Value = 
new System.SByte[,] { { -121, 13, }, { -50, 104, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.SByte[,] { { -8, -87, }, { 23, -12, }, },
    NullableValue = 
new System.SByte[,] { { 48, -23, }, { 24, 84, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 37,
    Value = 
new System.SByte[,] { { -26, -2, }, { 2, 49, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.SByte[,] { { -38, -117, }, { -29, -105, }, },
    NullableValue = 
new System.SByte[,] { { -106, 85, }, { -98, -90, }, },
},
    NullableValue = 
new System.SByte[,] { { 43, -6, }, { -108, -50, }, },
},
            new SByteMArrayD2E1M
{
    Id = 45,
    Value = 
new System.SByte[,] { { 9, 89, }, { 27, 95, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.SByte[,] { { 94, -110, }, { 71, 98, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 53,
    Value = 
new System.SByte[,] { { -88, -18, }, { 83, -7, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.SByte[,] { { -108, 46, }, { 68, -105, }, },
    NullableValue = 
new System.SByte[,] { { 54, 66, }, { 87, -102, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 60,
    Value = 
new System.SByte[,] { { 74, -23, }, { 86, 53, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.SByte[,] { { 118, -96, }, { -63, -116, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 64,
    Value = 
new System.SByte[,] { { -120, -99, }, { -62, 27, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.SByte[,] { { 98, 45, }, { -42, -107, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 8, 81, }, { 52, -32, }, },
},
            new SByteMArrayD2E1M
{
    Id = 72,
    Value = 
new System.SByte[,] { { 107, 121, }, { -88, 121, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.SByte[,] { { 81, 57, }, { -104, -113, }, },
    NullableValue = 
new System.SByte[,] { { 0, -74, }, { -59, 39, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 77,
    Value = 
new System.SByte[,] { { -119, 59, }, { -49, -20, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.SByte[,] { { 46, -3, }, { 122, -112, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 83,
    Value = 
new System.SByte[,] { { 15, -115, }, { 68, -117, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.SByte[,] { { -25, 1, }, { -27, 17, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 85,
    Value = 
new System.SByte[,] { { -2, 68, }, { -15, -18, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.SByte[,] { { -47, -118, }, { 112, 120, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 94,
    Value = 
new System.SByte[,] { { -33, -26, }, { -118, 36, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.SByte[,] { { 21, -76, }, { -2, 44, }, },
    NullableValue = 
new System.SByte[,] { { -81, -55, }, { 10, -85, }, },
},
    NullableValue = 
new System.SByte[,] { { 67, -30, }, { 111, 96, }, },
},
            new SByteMArrayD2E1M
{
    Id = 95,
    Value = 
new System.SByte[,] { { 71, -88, }, { -81, 56, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.SByte[,] { { 56, -127, }, { 107, -63, }, },
    NullableValue = 
new System.SByte[,] { { -61, 84, }, { 96, -63, }, },
},
    NullableValue = 
new System.SByte[,] { { 124, -94, }, { -23, 117, }, },
},
            new SByteMArrayD2E1M
{
    Id = 96,
    Value = 
new System.SByte[,] { { 117, 47, }, { -124, 125, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.SByte[,] { { -83, -124, }, { 21, -88, }, },
    NullableValue = 
new System.SByte[,] { { -108, -16, }, { 13, 7, }, },
},
    NullableValue = 
new System.SByte[,] { { -113, 85, }, { -21, 12, }, },
},
            new SByteMArrayD2E1M
{
    Id = 97,
    Value = 
new System.SByte[,] { { -100, -62, }, { 66, -125, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.SByte[,] { { -126, 94, }, { 126, -44, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 18, 71, }, { 89, 18, }, },
},
            new SByteMArrayD2E1M
{
    Id = 106,
    Value = 
new System.SByte[,] { { 18, 13, }, { -117, 95, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.SByte[,] { { -3, -15, }, { 89, -117, }, },
    NullableValue = 
new System.SByte[,] { { -48, -91, }, { -86, -105, }, },
},
    NullableValue = 
new System.SByte[,] { { 123, 78, }, { 46, -24, }, },
},
            new SByteMArrayD2E1M
{
    Id = 109,
    Value = 
new System.SByte[,] { { -32, 27, }, { -113, 7, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.SByte[,] { { 32, -30, }, { -9, -32, }, },
    NullableValue = 
new System.SByte[,] { { -65, 96, }, { 113, -85, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 117,
    Value = 
new System.SByte[,] { { -78, 59, }, { -90, -112, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.SByte[,] { { 6, 51, }, { 67, 111, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -26, -125, }, { -86, 12, }, },
},
            new SByteMArrayD2E1M
{
    Id = 118,
    Value = 
new System.SByte[,] { { 50, -120, }, { 99, 119, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.SByte[,] { { 94, -79, }, { 53, -51, }, },
    NullableValue = 
new System.SByte[,] { { 126, 50, }, { 107, -66, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 125,
    Value = 
new System.SByte[,] { { 27, 72, }, { 102, 103, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 115,
    Value = 
new System.SByte[,] { { -54, -88, }, { -53, 57, }, },
    NullableValue = 
new System.SByte[,] { { 44, -68, }, { -27, 70, }, },
},
    NullableValue = 
new System.SByte[,] { { -19, 105, }, { -68, -58, }, },
},
            new SByteMArrayD2E1M
{
    Id = 134,
    Value = 
new System.SByte[,] { { -63, -40, }, { 47, 119, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.SByte[,] { { 63, 115, }, { 23, -90, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 135,
    Value = 
new System.SByte[,] { { -123, -100, }, { -13, 30, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.SByte[,] { { -52, 72, }, { 2, -61, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -19, 59, }, { -2, 80, }, },
},
            new SByteMArrayD2E1M
{
    Id = 139,
    Value = 
new System.SByte[,] { { -1, 60, }, { -11, 104, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.SByte[,] { { 20, 5, }, { 121, 25, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 147,
    Value = 
new System.SByte[,] { { -98, 125, }, { -91, -32, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.SByte[,] { { -113, 42, }, { 75, 18, }, },
    NullableValue = 
new System.SByte[,] { { -80, 33, }, { -86, 97, }, },
},
    NullableValue = 
new System.SByte[,] { { 88, 58, }, { -28, -70, }, },
},
            new SByteMArrayD2E1M
{
    Id = 153,
    Value = 
new System.SByte[,] { { 12, 50, }, { -29, 106, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 142,
    Value = 
new System.SByte[,] { { -107, 77, }, { 63, 67, }, },
    NullableValue = 
new System.SByte[,] { { -48, 122, }, { -104, -21, }, },
},
    NullableValue = 
new System.SByte[,] { { 121, -89, }, { -25, 99, }, },
},
            new SByteMArrayD2E1M
{
    Id = 154,
    Value = 
new System.SByte[,] { { -52, -119, }, { -112, -28, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 149,
    Value = 
new System.SByte[,] { { -71, 122, }, { 76, -12, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 160,
    Value = 
new System.SByte[,] { { -40, 98, }, { 69, -98, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 155,
    Value = 
new System.SByte[,] { { -75, 46, }, { 40, 20, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 105, 46, }, { -121, -2, }, },
},
            new SByteMArrayD2E1M
{
    Id = 169,
    Value = 
new System.SByte[,] { { 110, 109, }, { 9, 65, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 161,
    Value = 
new System.SByte[,] { { 4, -12, }, { 0, 27, }, },
    NullableValue = 
new System.SByte[,] { { 73, -98, }, { 107, -109, }, },
},
    NullableValue = 
new System.SByte[,] { { 64, 38, }, { 115, -79, }, },
},
            new SByteMArrayD2E1M
{
    Id = 174,
    Value = 
new System.SByte[,] { { 59, -57, }, { -29, 124, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 167,
    Value = 
new System.SByte[,] { { 119, -42, }, { -68, -119, }, },
    NullableValue = 
new System.SByte[,] { { -72, 84, }, { 62, -116, }, },
},
    NullableValue = 
new System.SByte[,] { { -50, -17, }, { 55, -113, }, },
},
            new SByteMArrayD2E1M
{
    Id = 179,
    Value = 
new System.SByte[,] { { 23, -73, }, { -4, -104, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 171,
    Value = 
new System.SByte[,] { { -85, 78, }, { -115, -128, }, },
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
INSERT INTO gedaqtests.sbytemarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int8))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int8))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.SByte[,]), 
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
                    await ((ISByteMArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((ISByteMArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.sbytemarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(SByteMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(ISByteMArrayMArrayD2)),
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
                    var models = await ((ISByteMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((ISByteMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    SByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

