

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
new System.Byte[,] { { 105, 105, }, { 48, 139, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Byte[,] { { 193, 222, }, { 42, 22, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 148, 91, }, { 11, 73, }, },
},
            new ByteMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Byte[,] { { 210, 253, }, { 242, 20, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Byte[,] { { 101, 244, }, { 27, 91, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 220, 117, }, { 165, 112, }, },
},
            new ByteMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Byte[,] { { 250, 88, }, { 146, 141, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Byte[,] { { 17, 109, }, { 80, 135, }, },
    NullableValue = 
new System.Byte[,] { { 113, 81, }, { 138, 3, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Byte[,] { { 159, 153, }, { 223, 5, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Byte[,] { { 236, 127, }, { 192, 130, }, },
    NullableValue = 
new System.Byte[,] { { 221, 126, }, { 233, 75, }, },
},
    NullableValue = 
new System.Byte[,] { { 61, 194, }, { 19, 120, }, },
},
            new ByteMArrayD2E1M
{
    Id = 33,
    Value = 
new System.Byte[,] { { 58, 186, }, { 240, 229, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Byte[,] { { 102, 71, }, { 102, 44, }, },
    NullableValue = 
new System.Byte[,] { { 78, 55, }, { 46, 86, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Byte[,] { { 163, 205, }, { 189, 107, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Byte[,] { { 57, 152, }, { 198, 129, }, },
    NullableValue = 
new System.Byte[,] { { 250, 189, }, { 223, 46, }, },
},
    NullableValue = 
new System.Byte[,] { { 165, 95, }, { 22, 10, }, },
},
            new ByteMArrayD2E1M
{
    Id = 41,
    Value = 
new System.Byte[,] { { 160, 99, }, { 223, 246, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Byte[,] { { 180, 130, }, { 147, 59, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 139, 224, }, { 168, 165, }, },
},
            new ByteMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Byte[,] { { 153, 224, }, { 11, 200, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Byte[,] { { 195, 179, }, { 93, 254, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 5, 6, }, { 190, 161, }, },
},
            new ByteMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Byte[,] { { 229, 106, }, { 134, 197, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Byte[,] { { 135, 227, }, { 40, 6, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Byte[,] { { 76, 83, }, { 166, 1, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Byte[,] { { 93, 45, }, { 172, 82, }, },
    NullableValue = 
new System.Byte[,] { { 108, 6, }, { 148, 187, }, },
},
    NullableValue = 
new System.Byte[,] { { 160, 227, }, { 71, 228, }, },
},
            new ByteMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Byte[,] { { 143, 165, }, { 237, 209, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Byte[,] { { 103, 128, }, { 14, 225, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 120, 199, }, { 134, 112, }, },
},
            new ByteMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Byte[,] { { 150, 82, }, { 69, 248, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Byte[,] { { 235, 253, }, { 117, 199, }, },
    NullableValue = 
new System.Byte[,] { { 144, 91, }, { 241, 209, }, },
},
    NullableValue = 
new System.Byte[,] { { 183, 233, }, { 60, 75, }, },
},
            new ByteMArrayD2E1M
{
    Id = 77,
    Value = 
new System.Byte[,] { { 149, 139, }, { 163, 57, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 75,
    Value = 
new System.Byte[,] { { 10, 142, }, { 165, 114, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Byte[,] { { 16, 51, }, { 12, 212, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Byte[,] { { 49, 67, }, { 228, 163, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Byte[,] { { 64, 95, }, { 68, 170, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Byte[,] { { 228, 37, }, { 125, 210, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Byte[,] { { 250, 253, }, { 164, 111, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Byte[,] { { 220, 2, }, { 169, 85, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 209, 151, }, { 5, 225, }, },
},
            new ByteMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Byte[,] { { 1, 250, }, { 200, 236, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Byte[,] { { 139, 17, }, { 203, 235, }, },
    NullableValue = 
new System.Byte[,] { { 103, 28, }, { 208, 109, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Byte[,] { { 209, 234, }, { 99, 92, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Byte[,] { { 23, 161, }, { 220, 92, }, },
    NullableValue = 
new System.Byte[,] { { 29, 46, }, { 100, 116, }, },
},
    NullableValue = 
new System.Byte[,] { { 208, 85, }, { 94, 213, }, },
},
            new ByteMArrayD2E1M
{
    Id = 96,
    Value = 
new System.Byte[,] { { 109, 208, }, { 137, 185, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Byte[,] { { 59, 79, }, { 160, 249, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Byte[,] { { 182, 66, }, { 30, 227, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Byte[,] { { 168, 99, }, { 37, 125, }, },
    NullableValue = 
new System.Byte[,] { { 231, 127, }, { 105, 117, }, },
},
    NullableValue = 
new System.Byte[,] { { 209, 193, }, { 91, 241, }, },
},
            new ByteMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Byte[,] { { 201, 65, }, { 74, 183, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Byte[,] { { 113, 107, }, { 217, 167, }, },
    NullableValue = 
new System.Byte[,] { { 152, 200, }, { 20, 7, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Byte[,] { { 178, 51, }, { 40, 200, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Byte[,] { { 99, 181, }, { 30, 120, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 126,
    Value = 
new System.Byte[,] { { 184, 138, }, { 42, 245, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Byte[,] { { 225, 53, }, { 176, 235, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 151, 107, }, { 58, 112, }, },
},
            new ByteMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Byte[,] { { 18, 163, }, { 74, 218, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 123,
    Value = 
new System.Byte[,] { { 200, 166, }, { 18, 171, }, },
    NullableValue = 
new System.Byte[,] { { 127, 155, }, { 25, 174, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 129,
    Value = 
new System.Byte[,] { { 80, 92, }, { 219, 67, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 131,
    Value = 
new System.Byte[,] { { 37, 122, }, { 108, 44, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 210, 253, }, { 53, 87, }, },
},
            new ByteMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Byte[,] { { 30, 93, }, { 170, 147, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Byte[,] { { 162, 124, }, { 230, 162, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Byte[,] { { 248, 253, }, { 131, 68, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Byte[,] { { 131, 169, }, { 188, 196, }, },
    NullableValue = 
new System.Byte[,] { { 248, 116, }, { 15, 148, }, },
},
    NullableValue = 
new System.Byte[,] { { 69, 97, }, { 5, 235, }, },
},
            new ByteMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Byte[,] { { 21, 243, }, { 42, 89, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 142,
    Value = 
new System.Byte[,] { { 252, 13, }, { 57, 56, }, },
    NullableValue = 
new System.Byte[,] { { 72, 208, }, { 122, 152, }, },
},
    NullableValue = 
new System.Byte[,] { { 41, 141, }, { 127, 67, }, },
},
            new ByteMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Byte[,] { { 242, 74, }, { 254, 79, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 146,
    Value = 
new System.Byte[,] { { 134, 2, }, { 160, 105, }, },
    NullableValue = 
new System.Byte[,] { { 172, 114, }, { 227, 100, }, },
},
    NullableValue = 
new System.Byte[,] { { 122, 220, }, { 168, 129, }, },
},
            new ByteMArrayD2E1M
{
    Id = 149,
    Value = 
new System.Byte[,] { { 244, 7, }, { 197, 246, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Byte[,] { { 184, 141, }, { 175, 156, }, },
    NullableValue = 
new System.Byte[,] { { 125, 220, }, { 173, 162, }, },
},
    NullableValue = 
new System.Byte[,] { { 50, 193, }, { 218, 97, }, },
},
            new ByteMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Byte[,] { { 86, 194, }, { 196, 136, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Byte[,] { { 184, 192, }, { 236, 27, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Byte[,] { { 121, 110, }, { 28, 212, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 160,
    Value = 
new System.Byte[,] { { 97, 221, }, { 95, 245, }, },
    NullableValue = 
new System.Byte[,] { { 207, 78, }, { 93, 123, }, },
},
    NullableValue = 
new System.Byte[,] { { 212, 140, }, { 154, 196, }, },
},
            new ByteMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Byte[,] { { 143, 87, }, { 47, 110, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 169,
    Value = 
new System.Byte[,] { { 144, 12, }, { 227, 180, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 252, 243, }, { 92, 190, }, },
},
            new ByteMArrayD2E1M
{
    Id = 167,
    Value = 
new System.Byte[,] { { 211, 152, }, { 38, 75, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 177,
    Value = 
new System.Byte[,] { { 245, 15, }, { 245, 117, }, },
    NullableValue = 
new System.Byte[,] { { 7, 254, }, { 132, 139, }, },
},
    NullableValue = 
new System.Byte[,] { { 222, 213, }, { 3, 251, }, },
},
            new ByteMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Byte[,] { { 4, 194, }, { 229, 251, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 180,
    Value = 
new System.Byte[,] { { 112, 14, }, { 211, 88, }, },
    NullableValue = 
new System.Byte[,] { { 6, 244, }, { 198, 192, }, },
},
    NullableValue = 
new System.Byte[,] { { 191, 43, }, { 124, 191, }, },
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

