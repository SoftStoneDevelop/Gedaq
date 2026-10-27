

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
    Id = 4,
    Value = 
new System.Byte[,] { { 52, 91, }, { 168, 156, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Byte[,] { { 133, 246, }, { 242, 214, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 8, 193, }, { 32, 217, }, },
},
            new ByteMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Byte[,] { { 92, 93, }, { 146, 77, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 4,
    Value = 
new System.Byte[,] { { 166, 12, }, { 73, 177, }, },
    NullableValue = 
new System.Byte[,] { { 178, 145, }, { 43, 206, }, },
},
    NullableValue = 
new System.Byte[,] { { 103, 79, }, { 80, 171, }, },
},
            new ByteMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Byte[,] { { 214, 112, }, { 182, 86, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Byte[,] { { 75, 27, }, { 13, 24, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 105, 130, }, { 91, 148, }, },
},
            new ByteMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Byte[,] { { 212, 245, }, { 77, 11, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 12,
    Value = 
new System.Byte[,] { { 82, 186, }, { 199, 87, }, },
    NullableValue = 
new System.Byte[,] { { 176, 135, }, { 91, 47, }, },
},
    NullableValue = 
new System.Byte[,] { { 245, 58, }, { 56, 109, }, },
},
            new ByteMArrayD2E1M
{
    Id = 26,
    Value = 
new System.Byte[,] { { 187, 181, }, { 124, 9, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Byte[,] { { 156, 43, }, { 234, 63, }, },
    NullableValue = 
new System.Byte[,] { { 172, 80, }, { 197, 211, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 35,
    Value = 
new System.Byte[,] { { 6, 225, }, { 252, 86, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Byte[,] { { 145, 110, }, { 2, 210, }, },
    NullableValue = 
new System.Byte[,] { { 139, 48, }, { 147, 196, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 44,
    Value = 
new System.Byte[,] { { 246, 13, }, { 157, 78, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Byte[,] { { 197, 251, }, { 146, 112, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Byte[,] { { 217, 133, }, { 0, 139, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Byte[,] { { 109, 23, }, { 226, 151, }, },
    NullableValue = 
new System.Byte[,] { { 96, 230, }, { 148, 179, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Byte[,] { { 216, 154, }, { 84, 125, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Byte[,] { { 119, 103, }, { 139, 55, }, },
    NullableValue = 
new System.Byte[,] { { 217, 71, }, { 168, 232, }, },
},
    NullableValue = 
new System.Byte[,] { { 28, 236, }, { 77, 230, }, },
},
            new ByteMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Byte[,] { { 151, 138, }, { 19, 91, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Byte[,] { { 125, 38, }, { 27, 37, }, },
    NullableValue = 
new System.Byte[,] { { 124, 112, }, { 64, 28, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Byte[,] { { 4, 199, }, { 150, 209, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Byte[,] { { 45, 132, }, { 18, 106, }, },
    NullableValue = 
new System.Byte[,] { { 178, 200, }, { 20, 86, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Byte[,] { { 29, 199, }, { 182, 220, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 48,
    Value = 
new System.Byte[,] { { 192, 39, }, { 158, 210, }, },
    NullableValue = 
new System.Byte[,] { { 49, 162, }, { 66, 120, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Byte[,] { { 248, 130, }, { 41, 45, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Byte[,] { { 139, 180, }, { 146, 168, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 76, 240, }, { 95, 131, }, },
},
            new ByteMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Byte[,] { { 192, 15, }, { 63, 179, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Byte[,] { { 6, 4, }, { 189, 159, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 76,
    Value = 
new System.Byte[,] { { 245, 49, }, { 207, 147, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Byte[,] { { 88, 153, }, { 88, 149, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Byte[,] { { 49, 125, }, { 157, 175, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Byte[,] { { 62, 142, }, { 103, 75, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Byte[,] { { 5, 86, }, { 195, 55, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Byte[,] { { 122, 166, }, { 230, 143, }, },
    NullableValue = 
new System.Byte[,] { { 75, 47, }, { 45, 28, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Byte[,] { { 26, 187, }, { 135, 247, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Byte[,] { { 34, 35, }, { 77, 94, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 170, 49, }, { 41, 220, }, },
},
            new ByteMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Byte[,] { { 94, 242, }, { 111, 161, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Byte[,] { { 209, 151, }, { 184, 83, }, },
    NullableValue = 
new System.Byte[,] { { 206, 103, }, { 192, 63, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Byte[,] { { 68, 140, }, { 176, 200, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 82,
    Value = 
new System.Byte[,] { { 80, 184, }, { 251, 31, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 16, 8, }, { 166, 204, }, },
},
            new ByteMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Byte[,] { { 116, 22, }, { 91, 223, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Byte[,] { { 104, 30, }, { 215, 61, }, },
    NullableValue = 
new System.Byte[,] { { 41, 115, }, { 136, 14, }, },
},
    NullableValue = 
new System.Byte[,] { { 201, 38, }, { 20, 194, }, },
},
            new ByteMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Byte[,] { { 136, 67, }, { 179, 28, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Byte[,] { { 39, 15, }, { 247, 197, }, },
    NullableValue = 
new System.Byte[,] { { 204, 151, }, { 90, 67, }, },
},
    NullableValue = 
new System.Byte[,] { { 166, 163, }, { 157, 112, }, },
},
            new ByteMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Byte[,] { { 50, 92, }, { 77, 239, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Byte[,] { { 28, 29, }, { 142, 185, }, },
    NullableValue = 
new System.Byte[,] { { 23, 199, }, { 21, 249, }, },
},
    NullableValue = 
new System.Byte[,] { { 203, 64, }, { 115, 179, }, },
},
            new ByteMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Byte[,] { { 36, 141, }, { 173, 41, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 98,
    Value = 
new System.Byte[,] { { 254, 198, }, { 65, 107, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 111,
    Value = 
new System.Byte[,] { { 24, 82, }, { 193, 111, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 99,
    Value = 
new System.Byte[,] { { 231, 145, }, { 109, 57, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 69, 7, }, { 183, 113, }, },
},
            new ByteMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Byte[,] { { 162, 196, }, { 104, 172, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Byte[,] { { 104, 30, }, { 9, 128, }, },
    NullableValue = 
new System.Byte[,] { { 201, 201, }, { 92, 29, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Byte[,] { { 85, 6, }, { 81, 203, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Byte[,] { { 7, 169, }, { 243, 110, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Byte[,] { { 17, 229, }, { 14, 199, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Byte[,] { { 64, 163, }, { 247, 193, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 34, 82, }, { 124, 182, }, },
},
            new ByteMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Byte[,] { { 22, 10, }, { 45, 75, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Byte[,] { { 94, 179, }, { 243, 33, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 195, 28, }, { 165, 227, }, },
},
            new ByteMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Byte[,] { { 246, 6, }, { 146, 178, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Byte[,] { { 245, 23, }, { 105, 147, }, },
    NullableValue = 
new System.Byte[,] { { 60, 235, }, { 125, 220, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 139,
    Value = 
new System.Byte[,] { { 244, 45, }, { 233, 113, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Byte[,] { { 78, 13, }, { 168, 10, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 254, 92, }, { 163, 127, }, },
},
            new ByteMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Byte[,] { { 225, 51, }, { 240, 54, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Byte[,] { { 1, 163, }, { 217, 240, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 204, 221, }, { 217, 57, }, },
},
            new ByteMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Byte[,] { { 18, 125, }, { 254, 167, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Byte[,] { { 45, 87, }, { 212, 200, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 130, 40, }, { 254, 211, }, },
},
            new ByteMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Byte[,] { { 21, 170, }, { 54, 85, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Byte[,] { { 138, 124, }, { 127, 175, }, },
    NullableValue = 
new System.Byte[,] { { 220, 191, }, { 142, 212, }, },
},
    NullableValue = 
new System.Byte[,] { { 216, 18, }, { 130, 124, }, },
},
            new ByteMArrayD2E1M
{
    Id = 164,
    Value = 
new System.Byte[,] { { 203, 215, }, { 41, 46, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 148,
    Value = 
new System.Byte[,] { { 156, 187, }, { 215, 20, }, },
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

