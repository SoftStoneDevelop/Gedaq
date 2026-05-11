

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
    Id = 9,
    Value = 
new System.Byte[,] { { 214, 199, }, { 190, 82, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 5,
    Value = 
new System.Byte[,] { { 129, 189, }, { 112, 33, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 11,
    Value = 
new System.Byte[,] { { 30, 182, }, { 43, 218, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Byte[,] { { 9, 149, }, { 31, 220, }, },
    NullableValue = 
new System.Byte[,] { { 252, 156, }, { 190, 167, }, },
},
    NullableValue = 
new System.Byte[,] { { 54, 14, }, { 166, 112, }, },
},
            new ByteMArrayD2E1M
{
    Id = 14,
    Value = 
new System.Byte[,] { { 239, 124, }, { 66, 29, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Byte[,] { { 186, 137, }, { 252, 3, }, },
    NullableValue = 
new System.Byte[,] { { 171, 150, }, { 206, 138, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Byte[,] { { 40, 166, }, { 115, 251, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Byte[,] { { 33, 48, }, { 244, 199, }, },
    NullableValue = 
new System.Byte[,] { { 8, 14, }, { 117, 72, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Byte[,] { { 166, 45, }, { 253, 87, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Byte[,] { { 195, 191, }, { 72, 100, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Byte[,] { { 115, 24, }, { 177, 96, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Byte[,] { { 180, 102, }, { 194, 76, }, },
    NullableValue = 
new System.Byte[,] { { 67, 48, }, { 241, 207, }, },
},
    NullableValue = 
new System.Byte[,] { { 86, 120, }, { 187, 93, }, },
},
            new ByteMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Byte[,] { { 81, 120, }, { 177, 164, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Byte[,] { { 157, 201, }, { 223, 247, }, },
    NullableValue = 
new System.Byte[,] { { 150, 230, }, { 44, 219, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Byte[,] { { 28, 32, }, { 192, 137, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Byte[,] { { 20, 159, }, { 180, 11, }, },
    NullableValue = 
new System.Byte[,] { { 247, 102, }, { 233, 147, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Byte[,] { { 113, 235, }, { 241, 239, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Byte[,] { { 232, 132, }, { 108, 218, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 151, 44, }, { 13, 28, }, },
},
            new ByteMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Byte[,] { { 235, 78, }, { 154, 113, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Byte[,] { { 99, 35, }, { 169, 140, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 72, 61, }, { 171, 156, }, },
},
            new ByteMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Byte[,] { { 216, 64, }, { 109, 244, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Byte[,] { { 196, 116, }, { 25, 129, }, },
    NullableValue = 
new System.Byte[,] { { 55, 173, }, { 102, 57, }, },
},
    NullableValue = 
new System.Byte[,] { { 24, 215, }, { 16, 12, }, },
},
            new ByteMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Byte[,] { { 87, 111, }, { 73, 196, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Byte[,] { { 168, 97, }, { 63, 65, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Byte[,] { { 182, 44, }, { 165, 184, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Byte[,] { { 57, 111, }, { 148, 73, }, },
    NullableValue = 
new System.Byte[,] { { 36, 224, }, { 237, 222, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Byte[,] { { 81, 69, }, { 229, 116, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Byte[,] { { 63, 73, }, { 197, 74, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Byte[,] { { 238, 247, }, { 216, 168, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Byte[,] { { 252, 98, }, { 181, 130, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Byte[,] { { 65, 218, }, { 111, 133, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Byte[,] { { 100, 57, }, { 212, 0, }, },
    NullableValue = 
new System.Byte[,] { { 105, 178, }, { 239, 198, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Byte[,] { { 220, 149, }, { 132, 45, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Byte[,] { { 241, 108, }, { 173, 66, }, },
    NullableValue = 
new System.Byte[,] { { 164, 233, }, { 27, 173, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Byte[,] { { 12, 168, }, { 54, 224, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.Byte[,] { { 202, 7, }, { 156, 65, }, },
    NullableValue = 
new System.Byte[,] { { 124, 11, }, { 199, 43, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Byte[,] { { 233, 198, }, { 144, 231, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 98,
    Value = 
new System.Byte[,] { { 102, 134, }, { 46, 185, }, },
    NullableValue = 
new System.Byte[,] { { 60, 213, }, { 234, 72, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Byte[,] { { 249, 82, }, { 228, 155, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Byte[,] { { 9, 143, }, { 149, 120, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Byte[,] { { 223, 1, }, { 195, 16, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Byte[,] { { 102, 51, }, { 161, 148, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 223, 245, }, { 216, 50, }, },
},
            new ByteMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Byte[,] { { 103, 41, }, { 14, 46, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 104,
    Value = 
new System.Byte[,] { { 108, 105, }, { 122, 5, }, },
    NullableValue = 
new System.Byte[,] { { 57, 122, }, { 75, 33, }, },
},
    NullableValue = 
new System.Byte[,] { { 43, 229, }, { 105, 127, }, },
},
            new ByteMArrayD2E1M
{
    Id = 140,
    Value = 
new System.Byte[,] { { 200, 164, }, { 115, 2, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Byte[,] { { 6, 129, }, { 41, 127, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 142,
    Value = 
new System.Byte[,] { { 176, 44, }, { 122, 103, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 114,
    Value = 
new System.Byte[,] { { 204, 176, }, { 109, 74, }, },
    NullableValue = 
new System.Byte[,] { { 205, 219, }, { 195, 33, }, },
},
    NullableValue = 
new System.Byte[,] { { 77, 116, }, { 110, 207, }, },
},
            new ByteMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Byte[,] { { 117, 215, }, { 84, 32, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Byte[,] { { 105, 105, }, { 16, 112, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 135, 48, }, { 138, 94, }, },
},
            new ByteMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Byte[,] { { 179, 144, }, { 149, 71, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Byte[,] { { 44, 169, }, { 132, 199, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Byte[,] { { 55, 2, }, { 43, 235, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Byte[,] { { 186, 128, }, { 187, 124, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Byte[,] { { 162, 179, }, { 250, 99, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 129,
    Value = 
new System.Byte[,] { { 97, 161, }, { 93, 151, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Byte[,] { { 149, 58, }, { 7, 216, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Byte[,] { { 65, 27, }, { 80, 218, }, },
    NullableValue = 
new System.Byte[,] { { 178, 149, }, { 136, 35, }, },
},
    NullableValue = 
new System.Byte[,] { { 66, 195, }, { 116, 156, }, },
},
            new ByteMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Byte[,] { { 248, 17, }, { 50, 223, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 138,
    Value = 
new System.Byte[,] { { 144, 179, }, { 78, 129, }, },
    NullableValue = 
new System.Byte[,] { { 188, 78, }, { 233, 219, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Byte[,] { { 230, 188, }, { 219, 130, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 140,
    Value = 
new System.Byte[,] { { 202, 164, }, { 79, 192, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 172, 32, }, { 19, 139, }, },
},
            new ByteMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Byte[,] { { 37, 225, }, { 1, 222, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Byte[,] { { 156, 250, }, { 25, 98, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Byte[,] { { 35, 43, }, { 50, 140, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 150,
    Value = 
new System.Byte[,] { { 1, 68, }, { 14, 158, }, },
    NullableValue = 
new System.Byte[,] { { 195, 124, }, { 45, 54, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 181,
    Value = 
new System.Byte[,] { { 98, 1, }, { 177, 86, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Byte[,] { { 253, 1, }, { 7, 16, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 46, 104, }, { 24, 221, }, },
},
            new ByteMArrayD2E1M
{
    Id = 183,
    Value = 
new System.Byte[,] { { 95, 141, }, { 77, 132, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Byte[,] { { 11, 197, }, { 232, 206, }, },
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

