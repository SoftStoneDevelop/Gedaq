

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
    Id = 1,
    Value = 
new System.SByte[,] { { 64, -103, }, { -73, 80, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.SByte[,] { { 122, -112, }, { 2, -39, }, },
    NullableValue = 
new System.SByte[,] { { -125, 8, }, { 83, 93, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 2,
    Value = 
new System.SByte[,] { { -81, 77, }, { 15, 73, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.SByte[,] { { -1, -123, }, { -89, -123, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 4,
    Value = 
new System.SByte[,] { { -76, 102, }, { -72, 63, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.SByte[,] { { 100, -46, }, { 42, 101, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 18, -11, }, { 67, -88, }, },
},
            new SByteMArrayD2E1M
{
    Id = 7,
    Value = 
new System.SByte[,] { { -86, 41, }, { 72, 125, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.SByte[,] { { -83, -122, }, { 73, 13, }, },
    NullableValue = 
new System.SByte[,] { { -23, 48, }, { 26, -32, }, },
},
    NullableValue = 
new System.SByte[,] { { -62, -66, }, { 65, 125, }, },
},
            new SByteMArrayD2E1M
{
    Id = 13,
    Value = 
new System.SByte[,] { { -110, -62, }, { -102, -27, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.SByte[,] { { -28, 96, }, { 52, -66, }, },
    NullableValue = 
new System.SByte[,] { { -2, -108, }, { 44, -94, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 17,
    Value = 
new System.SByte[,] { { -19, -81, }, { 60, 99, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.SByte[,] { { 119, -20, }, { -76, 25, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 83, 33, }, { 5, -55, }, },
},
            new SByteMArrayD2E1M
{
    Id = 22,
    Value = 
new System.SByte[,] { { -125, -98, }, { 6, 13, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.SByte[,] { { -5, -82, }, { 96, -79, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 67, 109, }, { -22, -106, }, },
},
            new SByteMArrayD2E1M
{
    Id = 31,
    Value = 
new System.SByte[,] { { -127, 76, }, { 28, 73, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.SByte[,] { { 94, -110, }, { 60, 2, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 33,
    Value = 
new System.SByte[,] { { -1, 2, }, { 98, 114, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.SByte[,] { { 11, -10, }, { 89, 124, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 37,
    Value = 
new System.SByte[,] { { -87, -22, }, { -35, 12, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.SByte[,] { { 21, -24, }, { 98, 86, }, },
    NullableValue = 
new System.SByte[,] { { 125, 55, }, { 109, 107, }, },
},
    NullableValue = 
new System.SByte[,] { { -48, 74, }, { -49, 6, }, },
},
            new SByteMArrayD2E1M
{
    Id = 45,
    Value = 
new System.SByte[,] { { -127, -57, }, { 42, -31, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.SByte[,] { { -83, -107, }, { 17, -57, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 79, -54, }, { 65, -81, }, },
},
            new SByteMArrayD2E1M
{
    Id = 50,
    Value = 
new System.SByte[,] { { 5, -102, }, { -57, 73, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.SByte[,] { { -90, 15, }, { -70, 105, }, },
    NullableValue = 
new System.SByte[,] { { 58, 18, }, { 50, 38, }, },
},
    NullableValue = 
new System.SByte[,] { { -62, 43, }, { -108, 126, }, },
},
            new SByteMArrayD2E1M
{
    Id = 53,
    Value = 
new System.SByte[,] { { 100, 9, }, { 68, -63, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.SByte[,] { { -65, 93, }, { 4, -19, }, },
    NullableValue = 
new System.SByte[,] { { 62, 54, }, { -89, 64, }, },
},
    NullableValue = 
new System.SByte[,] { { 49, 53, }, { -98, -30, }, },
},
            new SByteMArrayD2E1M
{
    Id = 60,
    Value = 
new System.SByte[,] { { -39, -17, }, { 29, -6, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.SByte[,] { { -48, -99, }, { -105, 100, }, },
    NullableValue = 
new System.SByte[,] { { 84, -108, }, { -60, 8, }, },
},
    NullableValue = 
new System.SByte[,] { { -4, -83, }, { 54, -20, }, },
},
            new SByteMArrayD2E1M
{
    Id = 66,
    Value = 
new System.SByte[,] { { 124, -60, }, { -117, -80, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.SByte[,] { { 9, -51, }, { 110, -108, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -49, -7, }, { 111, -66, }, },
},
            new SByteMArrayD2E1M
{
    Id = 69,
    Value = 
new System.SByte[,] { { -45, 0, }, { 16, 88, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.SByte[,] { { 4, 86, }, { -94, -58, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 74,
    Value = 
new System.SByte[,] { { 110, -40, }, { -67, -116, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 97,
    Value = 
new System.SByte[,] { { -48, 112, }, { 85, 126, }, },
    NullableValue = 
new System.SByte[,] { { 121, -53, }, { -55, 61, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 75,
    Value = 
new System.SByte[,] { { -36, 58, }, { -34, 38, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 106,
    Value = 
new System.SByte[,] { { -1, -74, }, { -116, 100, }, },
    NullableValue = 
new System.SByte[,] { { 17, -17, }, { 85, -4, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 83,
    Value = 
new System.SByte[,] { { 61, -115, }, { -14, -105, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.SByte[,] { { 14, -5, }, { -106, -51, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 84,
    Value = 
new System.SByte[,] { { -117, 88, }, { 8, 63, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.SByte[,] { { -93, -58, }, { 125, 79, }, },
    NullableValue = 
new System.SByte[,] { { -83, 23, }, { 11, 56, }, },
},
    NullableValue = 
new System.SByte[,] { { -57, 49, }, { 26, -108, }, },
},
            new SByteMArrayD2E1M
{
    Id = 85,
    Value = 
new System.SByte[,] { { 118, -1, }, { -112, 18, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.SByte[,] { { -102, 82, }, { -46, -1, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 118, 106, }, { -10, 72, }, },
},
            new SByteMArrayD2E1M
{
    Id = 89,
    Value = 
new System.SByte[,] { { 28, 78, }, { -61, -32, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 127,
    Value = 
new System.SByte[,] { { 62, 41, }, { -120, -104, }, },
    NullableValue = 
new System.SByte[,] { { -41, 68, }, { -85, 93, }, },
},
    NullableValue = 
new System.SByte[,] { { 10, -28, }, { 111, -113, }, },
},
            new SByteMArrayD2E1M
{
    Id = 95,
    Value = 
new System.SByte[,] { { 33, 58, }, { -86, -36, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.SByte[,] { { 1, -29, }, { -117, -27, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 37, 46, }, { 53, -47, }, },
},
            new SByteMArrayD2E1M
{
    Id = 101,
    Value = 
new System.SByte[,] { { -74, -79, }, { -112, 60, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.SByte[,] { { -41, -22, }, { 66, 89, }, },
    NullableValue = 
new System.SByte[,] { { -1, -78, }, { 110, -89, }, },
},
    NullableValue = 
new System.SByte[,] { { 76, 116, }, { 88, 20, }, },
},
            new SByteMArrayD2E1M
{
    Id = 109,
    Value = 
new System.SByte[,] { { 115, 55, }, { 60, 70, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.SByte[,] { { 29, 71, }, { -61, 45, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 53, -83, }, { -60, 40, }, },
},
            new SByteMArrayD2E1M
{
    Id = 113,
    Value = 
new System.SByte[,] { { -54, 45, }, { 104, 5, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.SByte[,] { { -16, -30, }, { -39, -29, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 117,
    Value = 
new System.SByte[,] { { 113, 78, }, { 62, 39, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 162,
    Value = 
new System.SByte[,] { { -111, -116, }, { -104, -13, }, },
    NullableValue = 
new System.SByte[,] { { 123, 45, }, { 88, -42, }, },
},
    NullableValue = 
new System.SByte[,] { { -86, 42, }, { -119, -3, }, },
},
            new SByteMArrayD2E1M
{
    Id = 121,
    Value = 
new System.SByte[,] { { -47, -35, }, { 63, -30, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 164,
    Value = 
new System.SByte[,] { { 64, 33, }, { 21, -23, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 123, 0, }, { -66, 88, }, },
},
            new SByteMArrayD2E1M
{
    Id = 127,
    Value = 
new System.SByte[,] { { 17, -127, }, { 63, 52, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 173,
    Value = 
new System.SByte[,] { { 125, 85, }, { -123, -119, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -94, 17, }, { -118, -107, }, },
},
            new SByteMArrayD2E1M
{
    Id = 136,
    Value = 
new System.SByte[,] { { 70, 48, }, { 88, 53, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.SByte[,] { { -124, -19, }, { 54, 29, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -53, -9, }, { -39, 86, }, },
},
            new SByteMArrayD2E1M
{
    Id = 138,
    Value = 
new System.SByte[,] { { 42, -85, }, { -32, 54, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 183,
    Value = 
new System.SByte[,] { { -89, 54, }, { 62, 69, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 116, 64, }, { -72, 57, }, },
},
            new SByteMArrayD2E1M
{
    Id = 147,
    Value = 
new System.SByte[,] { { 1, -88, }, { -42, -105, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 188,
    Value = 
new System.SByte[,] { { -59, 67, }, { -29, 122, }, },
    NullableValue = 
new System.SByte[,] { { -49, -74, }, { -15, 56, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 154,
    Value = 
new System.SByte[,] { { -69, 80, }, { -41, -47, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 197,
    Value = 
new System.SByte[,] { { -23, 61, }, { 124, -76, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 155,
    Value = 
new System.SByte[,] { { 126, 68, }, { -31, 111, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 199,
    Value = 
new System.SByte[,] { { 3, -21, }, { -126, -22, }, },
    NullableValue = 
new System.SByte[,] { { 48, -35, }, { -42, -26, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 163,
    Value = 
new System.SByte[,] { { -81, 68, }, { -22, -18, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 203,
    Value = 
new System.SByte[,] { { -58, 80, }, { 0, -18, }, },
    NullableValue = 
new System.SByte[,] { { -49, 104, }, { 26, -107, }, },
},
    NullableValue = 
new System.SByte[,] { { -95, 31, }, { -113, -122, }, },
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

