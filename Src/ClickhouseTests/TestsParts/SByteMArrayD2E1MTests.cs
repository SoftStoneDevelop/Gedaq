

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
    Id = 9,
    Value = 
new System.SByte[,] { { 60, -41, }, { 120, -24, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.SByte[,] { { 66, 2, }, { 90, 9, }, },
    NullableValue = 
new System.SByte[,] { { -19, -127, }, { 43, -127, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 13,
    Value = 
new System.SByte[,] { { 119, -110, }, { 112, -38, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.SByte[,] { { 96, 70, }, { 18, 91, }, },
    NullableValue = 
new System.SByte[,] { { 48, -127, }, { -74, -4, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 16,
    Value = 
new System.SByte[,] { { 79, -40, }, { -119, 62, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.SByte[,] { { -112, 24, }, { -38, -84, }, },
    NullableValue = 
new System.SByte[,] { { 88, -77, }, { 84, -55, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 20,
    Value = 
new System.SByte[,] { { -84, 56, }, { -96, -39, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 20,
    Value = 
new System.SByte[,] { { 78, 68, }, { -31, -63, }, },
    NullableValue = 
new System.SByte[,] { { -117, 49, }, { 39, -95, }, },
},
    NullableValue = 
new System.SByte[,] { { 67, 101, }, { -84, 18, }, },
},
            new SByteMArrayD2E1M
{
    Id = 26,
    Value = 
new System.SByte[,] { { -7, -78, }, { 103, 75, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.SByte[,] { { -55, -87, }, { 102, 43, }, },
    NullableValue = 
new System.SByte[,] { { 49, 125, }, { -32, 76, }, },
},
    NullableValue = 
new System.SByte[,] { { 31, -68, }, { -27, -123, }, },
},
            new SByteMArrayD2E1M
{
    Id = 28,
    Value = 
new System.SByte[,] { { 70, -81, }, { 118, 85, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.SByte[,] { { -27, -83, }, { 49, -94, }, },
    NullableValue = 
new System.SByte[,] { { -22, 60, }, { 54, -11, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 31,
    Value = 
new System.SByte[,] { { 121, 107, }, { -74, 91, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.SByte[,] { { -85, 123, }, { 57, 68, }, },
    NullableValue = 
new System.SByte[,] { { -74, -128, }, { 44, -106, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 40,
    Value = 
new System.SByte[,] { { 36, 77, }, { -30, -117, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.SByte[,] { { -82, -8, }, { -97, -49, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 42,
    Value = 
new System.SByte[,] { { -96, -29, }, { 94, 93, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.SByte[,] { { -2, 53, }, { -116, 109, }, },
    NullableValue = 
new System.SByte[,] { { 98, -116, }, { -86, -88, }, },
},
    NullableValue = 
new System.SByte[,] { { -73, -29, }, { -56, 93, }, },
},
            new SByteMArrayD2E1M
{
    Id = 48,
    Value = 
new System.SByte[,] { { -79, -80, }, { -117, 26, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.SByte[,] { { -21, -38, }, { 116, -8, }, },
    NullableValue = 
new System.SByte[,] { { -28, -38, }, { 33, -95, }, },
},
    NullableValue = 
new System.SByte[,] { { -18, -48, }, { -48, 5, }, },
},
            new SByteMArrayD2E1M
{
    Id = 53,
    Value = 
new System.SByte[,] { { 6, 21, }, { 101, -74, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.SByte[,] { { 48, -35, }, { -91, 41, }, },
    NullableValue = 
new System.SByte[,] { { 75, -23, }, { -11, -49, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 59,
    Value = 
new System.SByte[,] { { 16, -23, }, { -78, -83, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.SByte[,] { { -98, -37, }, { 36, 72, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 5, 49, }, { -108, 21, }, },
},
            new SByteMArrayD2E1M
{
    Id = 67,
    Value = 
new System.SByte[,] { { 61, -92, }, { -56, -15, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.SByte[,] { { -20, 94, }, { -94, -65, }, },
    NullableValue = 
new System.SByte[,] { { -80, 4, }, { 122, 120, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 72,
    Value = 
new System.SByte[,] { { 70, -67, }, { -57, 101, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.SByte[,] { { -111, 125, }, { 58, -99, }, },
    NullableValue = 
new System.SByte[,] { { -60, -125, }, { -20, -79, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 76,
    Value = 
new System.SByte[,] { { -110, 97, }, { -35, -118, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.SByte[,] { { -54, 93, }, { 58, 88, }, },
    NullableValue = 
new System.SByte[,] { { 8, -120, }, { -68, -29, }, },
},
    NullableValue = 
new System.SByte[,] { { 87, -4, }, { -35, -82, }, },
},
            new SByteMArrayD2E1M
{
    Id = 81,
    Value = 
new System.SByte[,] { { -20, -101, }, { -24, 75, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.SByte[,] { { 9, 89, }, { 20, 64, }, },
    NullableValue = 
new System.SByte[,] { { -120, 20, }, { -71, 18, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 82,
    Value = 
new System.SByte[,] { { 31, 18, }, { -15, -62, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.SByte[,] { { 93, 91, }, { -37, 114, }, },
    NullableValue = 
new System.SByte[,] { { 110, 108, }, { -102, -50, }, },
},
    NullableValue = 
new System.SByte[,] { { -72, 126, }, { -79, 119, }, },
},
            new SByteMArrayD2E1M
{
    Id = 88,
    Value = 
new System.SByte[,] { { 102, -24, }, { 91, -38, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.SByte[,] { { -112, 103, }, { 74, 33, }, },
    NullableValue = 
new System.SByte[,] { { 51, -63, }, { 69, -91, }, },
},
    NullableValue = 
new System.SByte[,] { { -81, -15, }, { 23, 74, }, },
},
            new SByteMArrayD2E1M
{
    Id = 90,
    Value = 
new System.SByte[,] { { 123, 14, }, { -71, 28, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.SByte[,] { { 35, 85, }, { 91, -92, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 91,
    Value = 
new System.SByte[,] { { -115, -104, }, { 65, 21, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.SByte[,] { { 10, -36, }, { -107, 14, }, },
    NullableValue = 
new System.SByte[,] { { -76, 6, }, { -28, -66, }, },
},
    NullableValue = 
new System.SByte[,] { { -101, -13, }, { 105, 63, }, },
},
            new SByteMArrayD2E1M
{
    Id = 96,
    Value = 
new System.SByte[,] { { 111, 72, }, { 124, -27, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.SByte[,] { { 16, 121, }, { -79, 78, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 118, -91, }, { -127, 41, }, },
},
            new SByteMArrayD2E1M
{
    Id = 103,
    Value = 
new System.SByte[,] { { -37, -73, }, { 43, 74, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.SByte[,] { { 5, -97, }, { -13, 122, }, },
    NullableValue = 
new System.SByte[,] { { 91, -82, }, { -46, -13, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 106,
    Value = 
new System.SByte[,] { { 21, 56, }, { 44, -12, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.SByte[,] { { -51, 95, }, { -86, 103, }, },
    NullableValue = 
new System.SByte[,] { { 61, 24, }, { 17, 108, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 109,
    Value = 
new System.SByte[,] { { 110, -50, }, { -22, -53, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.SByte[,] { { 117, 36, }, { 124, -46, }, },
    NullableValue = 
new System.SByte[,] { { 31, 3, }, { -124, -108, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 114,
    Value = 
new System.SByte[,] { { -2, 84, }, { -107, -122, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.SByte[,] { { -11, 113, }, { -83, -23, }, },
    NullableValue = 
new System.SByte[,] { { -34, -121, }, { 122, 100, }, },
},
    NullableValue = 
new System.SByte[,] { { -36, 62, }, { -43, 56, }, },
},
            new SByteMArrayD2E1M
{
    Id = 122,
    Value = 
new System.SByte[,] { { -26, 90, }, { 77, -3, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.SByte[,] { { -8, 98, }, { -57, 27, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 127,
    Value = 
new System.SByte[,] { { 51, -76, }, { -50, -93, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 129,
    Value = 
new System.SByte[,] { { -24, -3, }, { 4, 121, }, },
    NullableValue = 
new System.SByte[,] { { -21, -57, }, { 71, 88, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 135,
    Value = 
new System.SByte[,] { { 73, 73, }, { -97, 67, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.SByte[,] { { 99, -70, }, { -78, 97, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 65, -32, }, { -75, 37, }, },
},
            new SByteMArrayD2E1M
{
    Id = 140,
    Value = 
new System.SByte[,] { { -117, -79, }, { -121, 28, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 137,
    Value = 
new System.SByte[,] { { -72, -62, }, { 66, 29, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 58, 6, }, { 103, -113, }, },
},
            new SByteMArrayD2E1M
{
    Id = 142,
    Value = 
new System.SByte[,] { { -87, -25, }, { -76, 86, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.SByte[,] { { 4, 26, }, { -123, 8, }, },
    NullableValue = 
new System.SByte[,] { { 103, 113, }, { 50, 44, }, },
},
    NullableValue = 
new System.SByte[,] { { 59, 19, }, { 74, -20, }, },
},
            new SByteMArrayD2E1M
{
    Id = 148,
    Value = 
new System.SByte[,] { { -79, -8, }, { 39, 92, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 148,
    Value = 
new System.SByte[,] { { -10, 90, }, { 90, 15, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 149,
    Value = 
new System.SByte[,] { { 13, 22, }, { 100, 57, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 157,
    Value = 
new System.SByte[,] { { -115, 22, }, { 31, 109, }, },
    NullableValue = 
new System.SByte[,] { { -14, 5, }, { -106, 96, }, },
},
    NullableValue = 
new System.SByte[,] { { 64, -55, }, { 108, -6, }, },
},
            new SByteMArrayD2E1M
{
    Id = 156,
    Value = 
new System.SByte[,] { { 111, 52, }, { 29, -96, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.SByte[,] { { -90, -11, }, { 4, 98, }, },
    NullableValue = 
new System.SByte[,] { { -116, -105, }, { 106, 25, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 162,
    Value = 
new System.SByte[,] { { 67, 40, }, { 26, 99, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 164,
    Value = 
new System.SByte[,] { { -88, 114, }, { 80, -85, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -83, -28, }, { 24, -109, }, },
},
            new SByteMArrayD2E1M
{
    Id = 165,
    Value = 
new System.SByte[,] { { -95, -83, }, { 35, -1, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 166,
    Value = 
new System.SByte[,] { { 61, -12, }, { 83, 73, }, },
    NullableValue = 
new System.SByte[,] { { -96, 102, }, { -77, -119, }, },
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

