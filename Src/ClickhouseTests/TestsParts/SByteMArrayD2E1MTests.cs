

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
    Id = 7,
    Value = 
new System.SByte[,] { { 98, 83, }, { 34, -126, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.SByte[,] { { 13, -41, }, { 43, 32, }, },
    NullableValue = 
new System.SByte[,] { { -74, -120, }, { 0, -111, }, },
},
    NullableValue = 
new System.SByte[,] { { 50, 0, }, { -117, 59, }, },
},
            new SByteMArrayD2E1M
{
    Id = 13,
    Value = 
new System.SByte[,] { { -55, -25, }, { -15, 66, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.SByte[,] { { 72, -88, }, { -128, 110, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -15, 1, }, { -25, 4, }, },
},
            new SByteMArrayD2E1M
{
    Id = 22,
    Value = 
new System.SByte[,] { { -124, -84, }, { 68, 126, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.SByte[,] { { -46, 85, }, { 113, -41, }, },
    NullableValue = 
new System.SByte[,] { { -53, -116, }, { 71, 24, }, },
},
    NullableValue = 
new System.SByte[,] { { -112, 51, }, { -120, 50, }, },
},
            new SByteMArrayD2E1M
{
    Id = 29,
    Value = 
new System.SByte[,] { { 60, -70, }, { -28, -78, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.SByte[,] { { -79, -92, }, { 20, 59, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 34, 111, }, { 121, 12, }, },
},
            new SByteMArrayD2E1M
{
    Id = 33,
    Value = 
new System.SByte[,] { { 18, -71, }, { 2, -39, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 29,
    Value = 
new System.SByte[,] { { 90, 104, }, { -62, -114, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 41,
    Value = 
new System.SByte[,] { { 7, 118, }, { 55, -4, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.SByte[,] { { 102, -124, }, { 115, 107, }, },
    NullableValue = 
new System.SByte[,] { { 106, 20, }, { 9, 118, }, },
},
    NullableValue = 
new System.SByte[,] { { 64, 27, }, { 83, -17, }, },
},
            new SByteMArrayD2E1M
{
    Id = 49,
    Value = 
new System.SByte[,] { { 24, -121, }, { 32, 84, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.SByte[,] { { 39, 7, }, { 59, 93, }, },
    NullableValue = 
new System.SByte[,] { { 85, -107, }, { -103, -14, }, },
},
    NullableValue = 
new System.SByte[,] { { -5, -115, }, { -36, 20, }, },
},
            new SByteMArrayD2E1M
{
    Id = 54,
    Value = 
new System.SByte[,] { { 57, -114, }, { -43, -118, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.SByte[,] { { -18, -85, }, { 42, 41, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 0, 44, }, { -51, -123, }, },
},
            new SByteMArrayD2E1M
{
    Id = 63,
    Value = 
new System.SByte[,] { { -106, -89, }, { -49, -88, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.SByte[,] { { 71, 114, }, { 56, 84, }, },
    NullableValue = 
new System.SByte[,] { { -28, 90, }, { -7, -7, }, },
},
    NullableValue = 
new System.SByte[,] { { 115, -39, }, { 24, 77, }, },
},
            new SByteMArrayD2E1M
{
    Id = 71,
    Value = 
new System.SByte[,] { { -86, 89, }, { 88, -3, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.SByte[,] { { 68, -20, }, { -10, -42, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 74,
    Value = 
new System.SByte[,] { { 38, 122, }, { -42, -19, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.SByte[,] { { 32, 15, }, { -62, 67, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -53, -96, }, { -14, 4, }, },
},
            new SByteMArrayD2E1M
{
    Id = 81,
    Value = 
new System.SByte[,] { { -20, -128, }, { 90, -17, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.SByte[,] { { 113, -10, }, { 60, -45, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 88, 109, }, { 104, 37, }, },
},
            new SByteMArrayD2E1M
{
    Id = 90,
    Value = 
new System.SByte[,] { { 99, -37, }, { -50, 32, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.SByte[,] { { -80, -76, }, { -11, 95, }, },
    NullableValue = 
new System.SByte[,] { { 18, 111, }, { 2, 38, }, },
},
    NullableValue = 
new System.SByte[,] { { -126, -117, }, { -77, -87, }, },
},
            new SByteMArrayD2E1M
{
    Id = 91,
    Value = 
new System.SByte[,] { { -71, 12, }, { 17, 55, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.SByte[,] { { -2, -100, }, { -59, 98, }, },
    NullableValue = 
new System.SByte[,] { { -41, 45, }, { -120, 70, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 97,
    Value = 
new System.SByte[,] { { 65, -6, }, { 32, 77, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.SByte[,] { { 11, 117, }, { 42, 72, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -25, -13, }, { 50, -52, }, },
},
            new SByteMArrayD2E1M
{
    Id = 100,
    Value = 
new System.SByte[,] { { 123, 38, }, { -62, -120, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.SByte[,] { { 126, -38, }, { 87, -59, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 104,
    Value = 
new System.SByte[,] { { 108, -101, }, { 55, -20, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.SByte[,] { { -119, 120, }, { -15, 88, }, },
    NullableValue = 
new System.SByte[,] { { -94, 99, }, { 91, -88, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 108,
    Value = 
new System.SByte[,] { { -2, 44, }, { -115, 99, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.SByte[,] { { -21, -4, }, { 99, 69, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 116,
    Value = 
new System.SByte[,] { { -104, -7, }, { 113, 79, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.SByte[,] { { -46, -105, }, { -89, -66, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 124,
    Value = 
new System.SByte[,] { { 119, -8, }, { 17, -127, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.SByte[,] { { -100, 118, }, { -61, -115, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -22, -71, }, { 29, 104, }, },
},
            new SByteMArrayD2E1M
{
    Id = 131,
    Value = 
new System.SByte[,] { { -16, -18, }, { 116, 8, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.SByte[,] { { 84, -85, }, { -20, 28, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 136,
    Value = 
new System.SByte[,] { { -105, 72, }, { 98, 72, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.SByte[,] { { -26, -64, }, { -6, -71, }, },
    NullableValue = 
new System.SByte[,] { { 52, -28, }, { 59, -121, }, },
},
    NullableValue = 
new System.SByte[,] { { 123, 0, }, { 36, 6, }, },
},
            new SByteMArrayD2E1M
{
    Id = 138,
    Value = 
new System.SByte[,] { { -109, -102, }, { -121, -125, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.SByte[,] { { -117, 98, }, { 8, 109, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 92, 116, }, { 54, -125, }, },
},
            new SByteMArrayD2E1M
{
    Id = 139,
    Value = 
new System.SByte[,] { { -26, 46, }, { -66, -5, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 125,
    Value = 
new System.SByte[,] { { 12, -128, }, { -102, -120, }, },
    NullableValue = 
new System.SByte[,] { { 93, -111, }, { -16, -16, }, },
},
    NullableValue = 
new System.SByte[,] { { -41, -90, }, { -27, -33, }, },
},
            new SByteMArrayD2E1M
{
    Id = 144,
    Value = 
new System.SByte[,] { { -106, -12, }, { -9, -81, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.SByte[,] { { -51, 14, }, { 109, -113, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 153,
    Value = 
new System.SByte[,] { { 98, 123, }, { 107, 52, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.SByte[,] { { -19, -110, }, { -60, 25, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 30, 8, }, { -73, 110, }, },
},
            new SByteMArrayD2E1M
{
    Id = 158,
    Value = 
new System.SByte[,] { { 49, 72, }, { 80, 84, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 146,
    Value = 
new System.SByte[,] { { 64, -50, }, { 55, -11, }, },
    NullableValue = 
new System.SByte[,] { { 40, 22, }, { -98, -10, }, },
},
    NullableValue = 
new System.SByte[,] { { -12, 68, }, { 71, 69, }, },
},
            new SByteMArrayD2E1M
{
    Id = 163,
    Value = 
new System.SByte[,] { { 73, 22, }, { -125, -108, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.SByte[,] { { -80, -40, }, { 116, -28, }, },
    NullableValue = 
new System.SByte[,] { { -63, -111, }, { 123, -74, }, },
},
    NullableValue = 
new System.SByte[,] { { 14, 52, }, { -116, -112, }, },
},
            new SByteMArrayD2E1M
{
    Id = 168,
    Value = 
new System.SByte[,] { { -93, -74, }, { 117, -114, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 156,
    Value = 
new System.SByte[,] { { 48, -61, }, { 30, 125, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 174,
    Value = 
new System.SByte[,] { { -44, -98, }, { 109, 28, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.SByte[,] { { -17, 16, }, { 16, -8, }, },
    NullableValue = 
new System.SByte[,] { { 44, -41, }, { 51, 113, }, },
},
    NullableValue = 
new System.SByte[,] { { 24, -112, }, { -9, 81, }, },
},
            new SByteMArrayD2E1M
{
    Id = 182,
    Value = 
new System.SByte[,] { { -118, -53, }, { -47, 70, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 167,
    Value = 
new System.SByte[,] { { -61, 9, }, { -123, 16, }, },
    NullableValue = 
new System.SByte[,] { { 59, -100, }, { -42, 30, }, },
},
    NullableValue = 
new System.SByte[,] { { -94, -123, }, { 97, 100, }, },
},
            new SByteMArrayD2E1M
{
    Id = 189,
    Value = 
new System.SByte[,] { { -45, -123, }, { -19, -47, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 169,
    Value = 
new System.SByte[,] { { -104, 111, }, { -10, 4, }, },
    NullableValue = 
new System.SByte[,] { { -52, -92, }, { 48, 24, }, },
},
    NullableValue = 
new System.SByte[,] { { 84, -25, }, { -73, -61, }, },
},
            new SByteMArrayD2E1M
{
    Id = 196,
    Value = 
new System.SByte[,] { { -103, -88, }, { 119, 93, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 174,
    Value = 
new System.SByte[,] { { -95, 113, }, { -58, -63, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 205,
    Value = 
new System.SByte[,] { { -79, 100, }, { 91, -124, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 176,
    Value = 
new System.SByte[,] { { -95, -113, }, { -49, 16, }, },
    NullableValue = 
new System.SByte[,] { { 34, 102, }, { 35, -65, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 206,
    Value = 
new System.SByte[,] { { 64, 65, }, { -93, -59, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 179,
    Value = 
new System.SByte[,] { { 31, 76, }, { -127, -33, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 54, 80, }, { 78, -36, }, },
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

