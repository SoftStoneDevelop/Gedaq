

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
    internal partial interface IByteMArrayMArrayD2
    {
    }
    
    internal partial class ByteMArrayMArrayD2 : IByteMArrayMArrayD2
    {


#region TestData

        private readonly ByteMArrayD2E1M[] _testData = new ByteMArrayD2E1M[]
        {
            new ByteMArrayD2E1M
{
    Id = 1,
    Value = 
new System.Byte[,] { { 21, 128, }, { 182, 127, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Byte[,] { { 252, 249, }, { 43, 97, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 8,
    Value = 
new System.Byte[,] { { 2, 52, }, { 130, 242, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Byte[,] { { 211, 23, }, { 209, 155, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Byte[,] { { 177, 88, }, { 26, 68, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Byte[,] { { 251, 131, }, { 14, 42, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 190, 60, }, { 145, 72, }, },
},
            new ByteMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Byte[,] { { 82, 107, }, { 226, 169, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Byte[,] { { 13, 138, }, { 100, 172, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 74, 180, }, { 116, 67, }, },
},
            new ByteMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Byte[,] { { 165, 114, }, { 64, 144, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Byte[,] { { 64, 244, }, { 130, 138, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 102, 238, }, { 26, 151, }, },
},
            new ByteMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Byte[,] { { 149, 72, }, { 216, 118, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Byte[,] { { 70, 126, }, { 169, 227, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 214, 191, }, { 208, 117, }, },
},
            new ByteMArrayD2E1M
{
    Id = 31,
    Value = 
new System.Byte[,] { { 251, 137, }, { 247, 20, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Byte[,] { { 251, 71, }, { 69, 169, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Byte[,] { { 118, 168, }, { 5, 131, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Byte[,] { { 40, 97, }, { 143, 176, }, },
    NullableValue = 
new System.Byte[,] { { 132, 119, }, { 241, 67, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Byte[,] { { 120, 237, }, { 226, 12, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Byte[,] { { 32, 227, }, { 205, 72, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Byte[,] { { 69, 156, }, { 106, 60, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Byte[,] { { 240, 158, }, { 7, 169, }, },
    NullableValue = 
new System.Byte[,] { { 14, 165, }, { 178, 200, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 57,
    Value = 
new System.Byte[,] { { 211, 223, }, { 9, 92, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Byte[,] { { 182, 59, }, { 31, 75, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Byte[,] { { 241, 237, }, { 221, 230, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Byte[,] { { 188, 227, }, { 54, 147, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 88, 41, }, { 192, 239, }, },
},
            new ByteMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Byte[,] { { 34, 113, }, { 69, 204, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Byte[,] { { 35, 243, }, { 189, 165, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 24, 222, }, { 166, 221, }, },
},
            new ByteMArrayD2E1M
{
    Id = 75,
    Value = 
new System.Byte[,] { { 62, 27, }, { 196, 112, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Byte[,] { { 219, 151, }, { 5, 150, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Byte[,] { { 48, 146, }, { 26, 158, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Byte[,] { { 192, 129, }, { 71, 146, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 109, 113, }, { 3, 47, }, },
},
            new ByteMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Byte[,] { { 163, 48, }, { 115, 251, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Byte[,] { { 204, 244, }, { 132, 183, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 122, 46, }, { 136, 192, }, },
},
            new ByteMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Byte[,] { { 134, 90, }, { 214, 118, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Byte[,] { { 129, 24, }, { 161, 17, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Byte[,] { { 200, 182, }, { 89, 111, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Byte[,] { { 192, 119, }, { 228, 87, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Byte[,] { { 205, 14, }, { 148, 190, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Byte[,] { { 67, 180, }, { 150, 3, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Byte[,] { { 140, 220, }, { 83, 56, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Byte[,] { { 234, 58, }, { 212, 7, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 163, 190, }, { 13, 20, }, },
},
            new ByteMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Byte[,] { { 226, 14, }, { 202, 52, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Byte[,] { { 51, 69, }, { 159, 17, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Byte[,] { { 6, 96, }, { 251, 63, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Byte[,] { { 55, 73, }, { 59, 97, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 137, 210, }, { 193, 225, }, },
},
            new ByteMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Byte[,] { { 236, 181, }, { 81, 157, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Byte[,] { { 199, 7, }, { 44, 111, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 249, 26, }, { 154, 185, }, },
},
            new ByteMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Byte[,] { { 1, 169, }, { 231, 74, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Byte[,] { { 108, 79, }, { 1, 218, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 63, 8, }, { 251, 50, }, },
},
            new ByteMArrayD2E1M
{
    Id = 125,
    Value = 
new System.Byte[,] { { 90, 126, }, { 210, 163, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Byte[,] { { 155, 97, }, { 40, 87, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Byte[,] { { 165, 38, }, { 29, 93, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Byte[,] { { 45, 100, }, { 104, 199, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Byte[,] { { 205, 17, }, { 31, 146, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Byte[,] { { 33, 54, }, { 126, 65, }, },
    NullableValue = 
new System.Byte[,] { { 158, 218, }, { 113, 60, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Byte[,] { { 3, 36, }, { 8, 23, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 131,
    Value = 
new System.Byte[,] { { 16, 45, }, { 187, 148, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Byte[,] { { 212, 10, }, { 139, 135, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 140,
    Value = 
new System.Byte[,] { { 56, 59, }, { 64, 224, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 147,
    Value = 
new System.Byte[,] { { 25, 178, }, { 78, 134, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Byte[,] { { 117, 240, }, { 127, 81, }, },
    NullableValue = 
new System.Byte[,] { { 210, 65, }, { 186, 130, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Byte[,] { { 123, 183, }, { 197, 56, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Byte[,] { { 68, 217, }, { 33, 181, }, },
    NullableValue = 
new System.Byte[,] { { 72, 179, }, { 229, 119, }, },
},
    NullableValue = 
new System.Byte[,] { { 29, 88, }, { 171, 218, }, },
},
            new ByteMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Byte[,] { { 216, 159, }, { 147, 46, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 157,
    Value = 
new System.Byte[,] { { 68, 238, }, { 168, 228, }, },
    NullableValue = 
new System.Byte[,] { { 229, 240, }, { 26, 181, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Byte[,] { { 123, 130, }, { 21, 151, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 166,
    Value = 
new System.Byte[,] { { 205, 150, }, { 151, 6, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 25, 118, }, { 96, 103, }, },
},
            new ByteMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Byte[,] { { 108, 80, }, { 240, 32, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 167,
    Value = 
new System.Byte[,] { { 93, 102, }, { 247, 65, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 203, 41, }, { 25, 33, }, },
},
            new ByteMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Byte[,] { { 85, 187, }, { 45, 205, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 176,
    Value = 
new System.Byte[,] { { 120, 246, }, { 131, 105, }, },
    NullableValue = 
new System.Byte[,] { { 43, 163, }, { 17, 198, }, },
},
    NullableValue = 
new System.Byte[,] { { 244, 162, }, { 224, 60, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.bytemarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt8))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt8))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Byte[,]), 
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
                    await ((IByteMArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IByteMArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.bytemarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(ByteMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IByteMArrayMArrayD2)),
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
                    var models = await ((IByteMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IByteMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    ByteMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

