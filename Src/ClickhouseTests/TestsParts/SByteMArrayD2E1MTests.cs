

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
    Id = 2,
    Value = 
new System.SByte[,] { { 120, -63, }, { 27, 122, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 5,
    Value = 
new System.SByte[,] { { 60, 47, }, { 46, -110, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 46, -110, }, { 99, 68, }, },
},
            new SByteMArrayD2E1M
{
    Id = 10,
    Value = 
new System.SByte[,] { { -14, -57, }, { -115, -67, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 6,
    Value = 
new System.SByte[,] { { 24, 109, }, { 123, 123, }, },
    NullableValue = 
new System.SByte[,] { { -2, 30, }, { -96, -55, }, },
},
    NullableValue = 
new System.SByte[,] { { 21, -126, }, { 62, 26, }, },
},
            new SByteMArrayD2E1M
{
    Id = 18,
    Value = 
new System.SByte[,] { { 122, -116, }, { 112, 88, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.SByte[,] { { -47, 97, }, { 125, 90, }, },
    NullableValue = 
new System.SByte[,] { { -28, -105, }, { -106, -96, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 22,
    Value = 
new System.SByte[,] { { -46, 60, }, { -81, 50, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.SByte[,] { { 74, 113, }, { 48, 15, }, },
    NullableValue = 
new System.SByte[,] { { 80, 7, }, { 112, 0, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 26,
    Value = 
new System.SByte[,] { { -114, -127, }, { -10, -122, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.SByte[,] { { 100, 96, }, { -104, 35, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 30,
    Value = 
new System.SByte[,] { { -106, -108, }, { 112, 92, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.SByte[,] { { -100, 79, }, { 82, -119, }, },
    NullableValue = 
new System.SByte[,] { { 105, 98, }, { 86, 56, }, },
},
    NullableValue = 
new System.SByte[,] { { 79, 25, }, { 100, -56, }, },
},
            new SByteMArrayD2E1M
{
    Id = 32,
    Value = 
new System.SByte[,] { { 0, 45, }, { -34, 107, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.SByte[,] { { -58, 102, }, { 16, 117, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 37,
    Value = 
new System.SByte[,] { { 107, 55, }, { 119, -44, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.SByte[,] { { -58, 53, }, { -77, 36, }, },
    NullableValue = 
new System.SByte[,] { { 32, -77, }, { 29, 68, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 42,
    Value = 
new System.SByte[,] { { -34, -82, }, { -101, -43, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.SByte[,] { { 78, -17, }, { 75, 64, }, },
    NullableValue = 
new System.SByte[,] { { -95, 90, }, { -86, 57, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 46,
    Value = 
new System.SByte[,] { { 108, 26, }, { -67, 9, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.SByte[,] { { 64, 30, }, { -93, 37, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 54,
    Value = 
new System.SByte[,] { { -94, -65, }, { 38, 82, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.SByte[,] { { -56, -48, }, { -93, -94, }, },
    NullableValue = 
new System.SByte[,] { { -86, 101, }, { -9, 90, }, },
},
    NullableValue = 
new System.SByte[,] { { 65, -108, }, { -42, -70, }, },
},
            new SByteMArrayD2E1M
{
    Id = 60,
    Value = 
new System.SByte[,] { { -80, -29, }, { -2, -64, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 69,
    Value = 
new System.SByte[,] { { -68, -25, }, { -34, -95, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 6, -62, }, { -114, -102, }, },
},
            new SByteMArrayD2E1M
{
    Id = 69,
    Value = 
new System.SByte[,] { { 74, 110, }, { 56, 14, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.SByte[,] { { 34, -20, }, { -18, 76, }, },
    NullableValue = 
new System.SByte[,] { { -104, -8, }, { 91, -49, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 70,
    Value = 
new System.SByte[,] { { -33, -35, }, { -112, 57, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.SByte[,] { { 24, 68, }, { 55, 53, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -85, 64, }, { -86, 99, }, },
},
            new SByteMArrayD2E1M
{
    Id = 79,
    Value = 
new System.SByte[,] { { -54, 40, }, { 41, -44, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.SByte[,] { { -47, 96, }, { -67, 120, }, },
    NullableValue = 
new System.SByte[,] { { 16, 106, }, { 63, -49, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 87,
    Value = 
new System.SByte[,] { { 126, 99, }, { -127, -112, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.SByte[,] { { 94, -108, }, { -19, -83, }, },
    NullableValue = 
new System.SByte[,] { { 41, 119, }, { -62, 48, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 96,
    Value = 
new System.SByte[,] { { -64, 81, }, { 71, 126, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.SByte[,] { { 54, 6, }, { 101, 32, }, },
    NullableValue = 
new System.SByte[,] { { -59, -42, }, { 28, 14, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 105,
    Value = 
new System.SByte[,] { { 43, 87, }, { -104, -2, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.SByte[,] { { 116, -88, }, { -59, -71, }, },
    NullableValue = 
new System.SByte[,] { { 48, 2, }, { 9, 43, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 110,
    Value = 
new System.SByte[,] { { -95, -46, }, { -45, -123, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 104,
    Value = 
new System.SByte[,] { { 89, 89, }, { 94, 82, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 79, -3, }, { -52, -123, }, },
},
            new SByteMArrayD2E1M
{
    Id = 115,
    Value = 
new System.SByte[,] { { -106, 48, }, { -41, -39, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 107,
    Value = 
new System.SByte[,] { { 114, 125, }, { -51, 34, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 124,
    Value = 
new System.SByte[,] { { 16, -46, }, { -39, -47, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.SByte[,] { { -97, 94, }, { 4, 2, }, },
    NullableValue = 
new System.SByte[,] { { 4, 29, }, { -105, 93, }, },
},
    NullableValue = 
new System.SByte[,] { { -89, 122, }, { -93, 122, }, },
},
            new SByteMArrayD2E1M
{
    Id = 131,
    Value = 
new System.SByte[,] { { 120, -36, }, { 89, -11, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.SByte[,] { { 84, -110, }, { 78, -22, }, },
    NullableValue = 
new System.SByte[,] { { -57, -58, }, { 105, -24, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 139,
    Value = 
new System.SByte[,] { { -31, 98, }, { 52, 122, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.SByte[,] { { -4, -27, }, { 35, -118, }, },
    NullableValue = 
new System.SByte[,] { { -84, 123, }, { -80, -36, }, },
},
    NullableValue = 
new System.SByte[,] { { -100, -115, }, { 113, -127, }, },
},
            new SByteMArrayD2E1M
{
    Id = 140,
    Value = 
new System.SByte[,] { { 8, 44, }, { 68, 73, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 137,
    Value = 
new System.SByte[,] { { 41, -28, }, { -120, 75, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 148,
    Value = 
new System.SByte[,] { { -63, 7, }, { 91, -114, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.SByte[,] { { 18, -120, }, { -38, 21, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 156,
    Value = 
new System.SByte[,] { { 124, -47, }, { 109, -24, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 149,
    Value = 
new System.SByte[,] { { -125, -53, }, { 25, 117, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 159,
    Value = 
new System.SByte[,] { { 55, -46, }, { -84, 51, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 153,
    Value = 
new System.SByte[,] { { -35, 98, }, { -117, -127, }, },
    NullableValue = 
new System.SByte[,] { { 35, 19, }, { -123, -45, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 162,
    Value = 
new System.SByte[,] { { -103, 123, }, { 18, 118, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 156,
    Value = 
new System.SByte[,] { { 119, -45, }, { -114, -123, }, },
    NullableValue = 
new System.SByte[,] { { -124, 111, }, { 62, -31, }, },
},
    NullableValue = 
new System.SByte[,] { { 41, 40, }, { 1, -74, }, },
},
            new SByteMArrayD2E1M
{
    Id = 167,
    Value = 
new System.SByte[,] { { -57, -86, }, { 67, -56, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.SByte[,] { { 119, 2, }, { -124, -2, }, },
    NullableValue = 
new System.SByte[,] { { 119, 41, }, { -98, 26, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 174,
    Value = 
new System.SByte[,] { { -76, 118, }, { 91, 51, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 165,
    Value = 
new System.SByte[,] { { -61, -108, }, { -61, -105, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -81, -35, }, { -72, -104, }, },
},
            new SByteMArrayD2E1M
{
    Id = 178,
    Value = 
new System.SByte[,] { { -117, 33, }, { -119, -126, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 169,
    Value = 
new System.SByte[,] { { 32, 20, }, { -13, -28, }, },
    NullableValue = 
new System.SByte[,] { { -92, -15, }, { -122, -5, }, },
},
    NullableValue = 
new System.SByte[,] { { -98, 36, }, { -47, -49, }, },
},
            new SByteMArrayD2E1M
{
    Id = 186,
    Value = 
new System.SByte[,] { { -113, -76, }, { 76, 59, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 173,
    Value = 
new System.SByte[,] { { -64, -127, }, { 121, -11, }, },
    NullableValue = 
new System.SByte[,] { { 54, 94, }, { -8, -8, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 187,
    Value = 
new System.SByte[,] { { -84, 119, }, { -126, -40, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 174,
    Value = 
new System.SByte[,] { { -83, -25, }, { -79, 76, }, },
    NullableValue = 
new System.SByte[,] { { 67, -123, }, { -38, -117, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 189,
    Value = 
new System.SByte[,] { { 12, 83, }, { -85, 32, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 181,
    Value = 
new System.SByte[,] { { -50, -84, }, { 33, 106, }, },
    NullableValue = 
new System.SByte[,] { { -26, -127, }, { 104, 35, }, },
},
    NullableValue = 
new System.SByte[,] { { 34, -66, }, { 99, 103, }, },
},
            new SByteMArrayD2E1M
{
    Id = 190,
    Value = 
new System.SByte[,] { { 29, -93, }, { -31, -88, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 182,
    Value = 
new System.SByte[,] { { -37, -33, }, { 108, 34, }, },
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

