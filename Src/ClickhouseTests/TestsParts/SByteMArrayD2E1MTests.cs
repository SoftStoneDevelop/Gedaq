

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
new System.SByte[,] { { 107, 77, }, { 83, 1, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.SByte[,] { { -51, 51, }, { -59, 33, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 77, -74, }, { 71, 102, }, },
},
            new SByteMArrayD2E1M
{
    Id = 16,
    Value = 
new System.SByte[,] { { 20, 43, }, { 53, 46, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.SByte[,] { { -39, 99, }, { 71, 122, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -111, -31, }, { -69, 3, }, },
},
            new SByteMArrayD2E1M
{
    Id = 19,
    Value = 
new System.SByte[,] { { -51, -95, }, { 42, 75, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.SByte[,] { { -43, 107, }, { -102, -65, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 27,
    Value = 
new System.SByte[,] { { 58, -71, }, { -64, -60, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.SByte[,] { { -119, 0, }, { -16, 77, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 36,
    Value = 
new System.SByte[,] { { -84, -30, }, { 31, 89, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.SByte[,] { { -62, 62, }, { 1, -14, }, },
    NullableValue = 
new System.SByte[,] { { 94, -88, }, { -96, -31, }, },
},
    NullableValue = 
new System.SByte[,] { { 54, 70, }, { -89, -1, }, },
},
            new SByteMArrayD2E1M
{
    Id = 40,
    Value = 
new System.SByte[,] { { -90, 22, }, { 94, -1, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.SByte[,] { { 86, -89, }, { 13, 112, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 45,
    Value = 
new System.SByte[,] { { 44, 24, }, { -115, 54, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.SByte[,] { { -127, -3, }, { -78, -112, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -78, -68, }, { 55, -36, }, },
},
            new SByteMArrayD2E1M
{
    Id = 53,
    Value = 
new System.SByte[,] { { -27, 70, }, { 86, -52, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.SByte[,] { { 48, 112, }, { 28, 91, }, },
    NullableValue = 
new System.SByte[,] { { -6, -71, }, { -104, -39, }, },
},
    NullableValue = 
new System.SByte[,] { { -44, -108, }, { 17, 111, }, },
},
            new SByteMArrayD2E1M
{
    Id = 56,
    Value = 
new System.SByte[,] { { 29, 100, }, { 100, 85, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.SByte[,] { { 22, -57, }, { -89, 108, }, },
    NullableValue = 
new System.SByte[,] { { 125, 49, }, { -61, 34, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 61,
    Value = 
new System.SByte[,] { { -36, -103, }, { 9, -86, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.SByte[,] { { 119, 81, }, { -125, -56, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 65,
    Value = 
new System.SByte[,] { { -100, -56, }, { -13, -108, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.SByte[,] { { 40, -40, }, { 5, -60, }, },
    NullableValue = 
new System.SByte[,] { { -82, -125, }, { 38, 24, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 72,
    Value = 
new System.SByte[,] { { -43, -18, }, { 9, -85, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.SByte[,] { { 68, -33, }, { 119, 20, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -115, -23, }, { 41, 113, }, },
},
            new SByteMArrayD2E1M
{
    Id = 73,
    Value = 
new System.SByte[,] { { 124, 21, }, { 75, -34, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.SByte[,] { { 76, -42, }, { 85, 112, }, },
    NullableValue = 
new System.SByte[,] { { -71, 66, }, { -97, 15, }, },
},
    NullableValue = 
new System.SByte[,] { { 89, 46, }, { -15, -118, }, },
},
            new SByteMArrayD2E1M
{
    Id = 74,
    Value = 
new System.SByte[,] { { -123, 2, }, { -48, 39, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.SByte[,] { { 45, -69, }, { 117, 91, }, },
    NullableValue = 
new System.SByte[,] { { 38, -15, }, { -53, 37, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 75,
    Value = 
new System.SByte[,] { { 41, -75, }, { -99, -84, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.SByte[,] { { -13, -73, }, { 114, -109, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 82,
    Value = 
new System.SByte[,] { { -19, -105, }, { -44, 9, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.SByte[,] { { 24, 9, }, { 118, -115, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 34, -45, }, { 68, 108, }, },
},
            new SByteMArrayD2E1M
{
    Id = 89,
    Value = 
new System.SByte[,] { { 81, -68, }, { -41, -79, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 93,
    Value = 
new System.SByte[,] { { -68, -16, }, { 35, -118, }, },
    NullableValue = 
new System.SByte[,] { { 75, -30, }, { 25, 101, }, },
},
    NullableValue = 
new System.SByte[,] { { 36, -75, }, { 85, -85, }, },
},
            new SByteMArrayD2E1M
{
    Id = 97,
    Value = 
new System.SByte[,] { { 93, -27, }, { 64, -62, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 101,
    Value = 
new System.SByte[,] { { 42, 78, }, { -122, -97, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 102,
    Value = 
new System.SByte[,] { { 3, 117, }, { 37, 102, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 107,
    Value = 
new System.SByte[,] { { 96, -63, }, { -3, 14, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 104,
    Value = 
new System.SByte[,] { { -21, 116, }, { -95, -50, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 110,
    Value = 
new System.SByte[,] { { -24, -106, }, { -110, 4, }, },
    NullableValue = 
new System.SByte[,] { { 25, -77, }, { -29, -48, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 113,
    Value = 
new System.SByte[,] { { -102, 59, }, { -3, -99, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.SByte[,] { { -7, -124, }, { -122, 126, }, },
    NullableValue = 
new System.SByte[,] { { -52, 4, }, { -42, -65, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 119,
    Value = 
new System.SByte[,] { { 120, -88, }, { -11, 10, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.SByte[,] { { 60, 85, }, { 105, -1, }, },
    NullableValue = 
new System.SByte[,] { { 4, 81, }, { -124, -51, }, },
},
    NullableValue = 
new System.SByte[,] { { -1, 82, }, { -3, -29, }, },
},
            new SByteMArrayD2E1M
{
    Id = 120,
    Value = 
new System.SByte[,] { { -112, -8, }, { -101, 55, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.SByte[,] { { 92, 89, }, { 26, -70, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 74, -42, }, { 99, -10, }, },
},
            new SByteMArrayD2E1M
{
    Id = 129,
    Value = 
new System.SByte[,] { { 48, -77, }, { -72, 14, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 125,
    Value = 
new System.SByte[,] { { 89, 2, }, { 112, -15, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 134,
    Value = 
new System.SByte[,] { { -3, 89, }, { 8, -26, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.SByte[,] { { 118, -96, }, { -104, -47, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 136,
    Value = 
new System.SByte[,] { { -119, 108, }, { 6, 23, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.SByte[,] { { 64, 105, }, { -63, 16, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 141,
    Value = 
new System.SByte[,] { { -72, -13, }, { -57, -99, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 138,
    Value = 
new System.SByte[,] { { -57, 18, }, { -88, -29, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 117, -97, }, { -45, 13, }, },
},
            new SByteMArrayD2E1M
{
    Id = 144,
    Value = 
new System.SByte[,] { { -21, -122, }, { 3, -103, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 143,
    Value = 
new System.SByte[,] { { 106, 30, }, { 15, 46, }, },
    NullableValue = 
new System.SByte[,] { { -41, -9, }, { -16, 33, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 149,
    Value = 
new System.SByte[,] { { -43, 83, }, { 108, -72, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 148,
    Value = 
new System.SByte[,] { { 40, 72, }, { 84, -109, }, },
    NullableValue = 
new System.SByte[,] { { -118, 109, }, { 117, 79, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 154,
    Value = 
new System.SByte[,] { { -101, -111, }, { -115, 80, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.SByte[,] { { 7, 87, }, { 66, -16, }, },
    NullableValue = 
new System.SByte[,] { { 69, 101, }, { -39, 36, }, },
},
    NullableValue = 
new System.SByte[,] { { 26, -66, }, { 76, 22, }, },
},
            new SByteMArrayD2E1M
{
    Id = 160,
    Value = 
new System.SByte[,] { { 59, 68, }, { -11, -80, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 163,
    Value = 
new System.SByte[,] { { 73, -71, }, { -24, -75, }, },
    NullableValue = 
new System.SByte[,] { { 59, 117, }, { -79, 14, }, },
},
    NullableValue = null,
},
            new SByteMArrayD2E1M
{
    Id = 164,
    Value = 
new System.SByte[,] { { -75, 85, }, { -39, 69, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 164,
    Value = 
new System.SByte[,] { { 36, 123, }, { -79, -48, }, },
    NullableValue = 
new System.SByte[,] { { -50, 113, }, { -92, -71, }, },
},
    NullableValue = 
new System.SByte[,] { { -106, -120, }, { -70, -41, }, },
},
            new SByteMArrayD2E1M
{
    Id = 165,
    Value = 
new System.SByte[,] { { -114, 30, }, { -54, -52, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 168,
    Value = 
new System.SByte[,] { { 68, 55, }, { 37, 44, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 44, 29, }, { -115, 8, }, },
},
            new SByteMArrayD2E1M
{
    Id = 169,
    Value = 
new System.SByte[,] { { -76, 80, }, { 120, 2, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 175,
    Value = 
new System.SByte[,] { { 68, 39, }, { -57, 99, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { 111, -61, }, { 107, -115, }, },
},
            new SByteMArrayD2E1M
{
    Id = 170,
    Value = 
new System.SByte[,] { { -121, 99, }, { 40, -17, }, },
    ModelInner = new SByteMArrayD2E1MI
{
    Id = 184,
    Value = 
new System.SByte[,] { { 68, 7, }, { -118, -1, }, },
    NullableValue = null,
},
    NullableValue = 
new System.SByte[,] { { -24, 9, }, { 90, 60, }, },
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

