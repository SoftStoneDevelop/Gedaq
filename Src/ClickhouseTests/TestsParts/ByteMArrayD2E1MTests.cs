

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
    Id = 6,
    Value = 
new System.Byte[,] { { 147, 213, }, { 214, 134, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Byte[,] { { 115, 112, }, { 80, 195, }, },
    NullableValue = 
new System.Byte[,] { { 246, 228, }, { 214, 126, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Byte[,] { { 103, 225, }, { 39, 126, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Byte[,] { { 206, 83, }, { 217, 13, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 33, 93, }, { 94, 172, }, },
},
            new ByteMArrayD2E1M
{
    Id = 15,
    Value = 
new System.Byte[,] { { 10, 52, }, { 56, 64, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Byte[,] { { 48, 166, }, { 223, 0, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Byte[,] { { 178, 45, }, { 103, 43, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Byte[,] { { 196, 68, }, { 247, 50, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 92, 172, }, { 69, 189, }, },
},
            new ByteMArrayD2E1M
{
    Id = 27,
    Value = 
new System.Byte[,] { { 36, 238, }, { 126, 27, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 30,
    Value = 
new System.Byte[,] { { 15, 41, }, { 219, 9, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 101, 145, }, { 119, 85, }, },
},
            new ByteMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Byte[,] { { 18, 89, }, { 76, 86, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Byte[,] { { 190, 124, }, { 204, 185, }, },
    NullableValue = 
new System.Byte[,] { { 180, 151, }, { 48, 129, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Byte[,] { { 226, 54, }, { 133, 102, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Byte[,] { { 154, 121, }, { 234, 31, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 242, 173, }, { 28, 115, }, },
},
            new ByteMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Byte[,] { { 170, 58, }, { 153, 171, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 41,
    Value = 
new System.Byte[,] { { 215, 21, }, { 59, 78, }, },
    NullableValue = 
new System.Byte[,] { { 100, 73, }, { 67, 33, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Byte[,] { { 176, 18, }, { 87, 116, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Byte[,] { { 141, 226, }, { 177, 238, }, },
    NullableValue = 
new System.Byte[,] { { 58, 139, }, { 236, 15, }, },
},
    NullableValue = 
new System.Byte[,] { { 13, 43, }, { 147, 130, }, },
},
            new ByteMArrayD2E1M
{
    Id = 51,
    Value = 
new System.Byte[,] { { 163, 180, }, { 144, 42, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Byte[,] { { 64, 113, }, { 186, 184, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 41, 117, }, { 102, 166, }, },
},
            new ByteMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Byte[,] { { 49, 55, }, { 103, 77, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Byte[,] { { 58, 82, }, { 200, 44, }, },
    NullableValue = 
new System.Byte[,] { { 67, 153, }, { 115, 194, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Byte[,] { { 103, 42, }, { 114, 152, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 71,
    Value = 
new System.Byte[,] { { 241, 180, }, { 143, 117, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 191, 48, }, { 177, 143, }, },
},
            new ByteMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Byte[,] { { 126, 196, }, { 207, 224, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Byte[,] { { 121, 49, }, { 157, 192, }, },
    NullableValue = 
new System.Byte[,] { { 166, 51, }, { 52, 157, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Byte[,] { { 48, 156, }, { 240, 14, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Byte[,] { { 116, 231, }, { 67, 90, }, },
    NullableValue = 
new System.Byte[,] { { 85, 59, }, { 161, 125, }, },
},
    NullableValue = 
new System.Byte[,] { { 189, 171, }, { 101, 9, }, },
},
            new ByteMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Byte[,] { { 187, 168, }, { 160, 236, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Byte[,] { { 140, 83, }, { 95, 27, }, },
    NullableValue = 
new System.Byte[,] { { 157, 108, }, { 240, 86, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 75,
    Value = 
new System.Byte[,] { { 179, 230, }, { 36, 246, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.Byte[,] { { 254, 207, }, { 33, 80, }, },
    NullableValue = 
new System.Byte[,] { { 218, 146, }, { 99, 20, }, },
},
    NullableValue = 
new System.Byte[,] { { 1, 215, }, { 194, 109, }, },
},
            new ByteMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Byte[,] { { 97, 253, }, { 157, 38, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Byte[,] { { 73, 4, }, { 71, 180, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Byte[,] { { 50, 219, }, { 53, 70, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 104,
    Value = 
new System.Byte[,] { { 155, 92, }, { 123, 113, }, },
    NullableValue = 
new System.Byte[,] { { 138, 220, }, { 159, 141, }, },
},
    NullableValue = 
new System.Byte[,] { { 185, 179, }, { 201, 189, }, },
},
            new ByteMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Byte[,] { { 139, 213, }, { 13, 170, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Byte[,] { { 251, 30, }, { 34, 206, }, },
    NullableValue = 
new System.Byte[,] { { 252, 132, }, { 26, 29, }, },
},
    NullableValue = 
new System.Byte[,] { { 132, 123, }, { 241, 190, }, },
},
            new ByteMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Byte[,] { { 38, 57, }, { 24, 139, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Byte[,] { { 23, 89, }, { 36, 78, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 98, 2, }, { 225, 53, }, },
},
            new ByteMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Byte[,] { { 228, 5, }, { 13, 62, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 118,
    Value = 
new System.Byte[,] { { 114, 188, }, { 69, 168, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 8, 76, }, { 93, 149, }, },
},
            new ByteMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Byte[,] { { 201, 223, }, { 38, 234, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Byte[,] { { 203, 33, }, { 107, 152, }, },
    NullableValue = 
new System.Byte[,] { { 92, 153, }, { 7, 190, }, },
},
    NullableValue = 
new System.Byte[,] { { 144, 201, }, { 53, 84, }, },
},
            new ByteMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Byte[,] { { 22, 66, }, { 56, 116, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Byte[,] { { 218, 153, }, { 247, 63, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 33, 209, }, { 7, 196, }, },
},
            new ByteMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Byte[,] { { 59, 162, }, { 180, 4, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Byte[,] { { 112, 113, }, { 54, 49, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 117, 27, }, { 217, 180, }, },
},
            new ByteMArrayD2E1M
{
    Id = 121,
    Value = 
new System.Byte[,] { { 18, 25, }, { 16, 176, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Byte[,] { { 120, 5, }, { 176, 59, }, },
    NullableValue = 
new System.Byte[,] { { 7, 154, }, { 132, 80, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Byte[,] { { 17, 162, }, { 74, 129, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Byte[,] { { 166, 216, }, { 23, 163, }, },
    NullableValue = 
new System.Byte[,] { { 103, 194, }, { 221, 210, }, },
},
    NullableValue = 
new System.Byte[,] { { 26, 117, }, { 54, 54, }, },
},
            new ByteMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Byte[,] { { 5, 148, }, { 152, 251, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Byte[,] { { 120, 179, }, { 204, 20, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 202, 139, }, { 111, 226, }, },
},
            new ByteMArrayD2E1M
{
    Id = 137,
    Value = 
new System.Byte[,] { { 171, 88, }, { 243, 115, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Byte[,] { { 155, 82, }, { 133, 126, }, },
    NullableValue = 
new System.Byte[,] { { 254, 81, }, { 4, 6, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Byte[,] { { 242, 131, }, { 209, 178, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Byte[,] { { 201, 73, }, { 74, 157, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 150,
    Value = 
new System.Byte[,] { { 140, 87, }, { 237, 151, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 167,
    Value = 
new System.Byte[,] { { 199, 69, }, { 65, 55, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Byte[,] { { 174, 178, }, { 223, 179, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 168,
    Value = 
new System.Byte[,] { { 176, 217, }, { 46, 7, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 116, 16, }, { 221, 123, }, },
},
            new ByteMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Byte[,] { { 231, 20, }, { 232, 70, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Byte[,] { { 110, 238, }, { 230, 7, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Byte[,] { { 41, 52, }, { 52, 100, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 180,
    Value = 
new System.Byte[,] { { 121, 13, }, { 22, 126, }, },
    NullableValue = 
new System.Byte[,] { { 157, 137, }, { 215, 162, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Byte[,] { { 207, 109, }, { 134, 254, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 188,
    Value = 
new System.Byte[,] { { 103, 42, }, { 84, 234, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 177,
    Value = 
new System.Byte[,] { { 159, 232, }, { 151, 83, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 192,
    Value = 
new System.Byte[,] { { 222, 143, }, { 190, 95, }, },
    NullableValue = 
new System.Byte[,] { { 207, 189, }, { 174, 68, }, },
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

