

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
new System.Byte[,] { { 174, 70, }, { 222, 71, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 2,
    Value = 
new System.Byte[,] { { 234, 248, }, { 142, 172, }, },
    NullableValue = 
new System.Byte[,] { { 218, 188, }, { 183, 170, }, },
},
    NullableValue = 
new System.Byte[,] { { 76, 9, }, { 17, 172, }, },
},
            new ByteMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Byte[,] { { 122, 141, }, { 96, 53, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 10,
    Value = 
new System.Byte[,] { { 129, 22, }, { 164, 83, }, },
    NullableValue = 
new System.Byte[,] { { 194, 142, }, { 105, 49, }, },
},
    NullableValue = 
new System.Byte[,] { { 184, 79, }, { 128, 73, }, },
},
            new ByteMArrayD2E1M
{
    Id = 22,
    Value = 
new System.Byte[,] { { 130, 149, }, { 72, 48, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Byte[,] { { 90, 215, }, { 173, 33, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 23,
    Value = 
new System.Byte[,] { { 186, 201, }, { 134, 26, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Byte[,] { { 214, 127, }, { 155, 243, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Byte[,] { { 40, 155, }, { 226, 36, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Byte[,] { { 13, 137, }, { 34, 108, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Byte[,] { { 148, 129, }, { 47, 167, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Byte[,] { { 145, 135, }, { 243, 245, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 211, 59, }, { 194, 201, }, },
},
            new ByteMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Byte[,] { { 64, 62, }, { 88, 58, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 32,
    Value = 
new System.Byte[,] { { 194, 70, }, { 107, 150, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Byte[,] { { 111, 137, }, { 216, 22, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Byte[,] { { 167, 121, }, { 213, 149, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 48,
    Value = 
new System.Byte[,] { { 122, 224, }, { 130, 222, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Byte[,] { { 21, 241, }, { 25, 91, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 49, 81, }, { 151, 140, }, },
},
            new ByteMArrayD2E1M
{
    Id = 54,
    Value = 
new System.Byte[,] { { 203, 97, }, { 242, 13, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Byte[,] { { 225, 100, }, { 20, 91, }, },
    NullableValue = 
new System.Byte[,] { { 222, 40, }, { 79, 65, }, },
},
    NullableValue = 
new System.Byte[,] { { 69, 251, }, { 222, 127, }, },
},
            new ByteMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Byte[,] { { 207, 178, }, { 167, 50, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Byte[,] { { 69, 37, }, { 181, 103, }, },
    NullableValue = 
new System.Byte[,] { { 138, 188, }, { 107, 237, }, },
},
    NullableValue = 
new System.Byte[,] { { 132, 41, }, { 87, 40, }, },
},
            new ByteMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Byte[,] { { 176, 24, }, { 167, 214, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 54,
    Value = 
new System.Byte[,] { { 131, 53, }, { 117, 189, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 201, 34, }, { 223, 45, }, },
},
            new ByteMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Byte[,] { { 79, 111, }, { 50, 188, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Byte[,] { { 215, 239, }, { 85, 66, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Byte[,] { { 172, 109, }, { 201, 196, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Byte[,] { { 34, 166, }, { 177, 146, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Byte[,] { { 247, 253, }, { 172, 3, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Byte[,] { { 6, 152, }, { 162, 148, }, },
    NullableValue = 
new System.Byte[,] { { 198, 222, }, { 108, 120, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Byte[,] { { 92, 250, }, { 7, 199, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Byte[,] { { 140, 95, }, { 91, 60, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Byte[,] { { 93, 182, }, { 108, 47, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Byte[,] { { 103, 81, }, { 122, 188, }, },
    NullableValue = 
new System.Byte[,] { { 132, 85, }, { 196, 44, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Byte[,] { { 45, 72, }, { 51, 88, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Byte[,] { { 39, 155, }, { 84, 169, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 248, 177, }, { 15, 106, }, },
},
            new ByteMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Byte[,] { { 8, 69, }, { 248, 121, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 97,
    Value = 
new System.Byte[,] { { 41, 121, }, { 128, 3, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 101,
    Value = 
new System.Byte[,] { { 99, 192, }, { 14, 154, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 101,
    Value = 
new System.Byte[,] { { 14, 108, }, { 150, 113, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 144, 239, }, { 41, 54, }, },
},
            new ByteMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Byte[,] { { 49, 33, }, { 237, 144, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Byte[,] { { 117, 206, }, { 182, 114, }, },
    NullableValue = 
new System.Byte[,] { { 34, 217, }, { 216, 87, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Byte[,] { { 72, 121, }, { 224, 246, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 109,
    Value = 
new System.Byte[,] { { 137, 57, }, { 165, 156, }, },
    NullableValue = 
new System.Byte[,] { { 160, 6, }, { 109, 39, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 109,
    Value = 
new System.Byte[,] { { 10, 250, }, { 50, 1, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.Byte[,] { { 17, 179, }, { 16, 93, }, },
    NullableValue = 
new System.Byte[,] { { 191, 15, }, { 80, 139, }, },
},
    NullableValue = 
new System.Byte[,] { { 250, 253, }, { 112, 79, }, },
},
            new ByteMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Byte[,] { { 215, 216, }, { 25, 125, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Byte[,] { { 234, 239, }, { 148, 212, }, },
    NullableValue = 
new System.Byte[,] { { 193, 135, }, { 11, 234, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Byte[,] { { 20, 159, }, { 113, 126, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Byte[,] { { 62, 57, }, { 178, 69, }, },
    NullableValue = 
new System.Byte[,] { { 2, 182, }, { 32, 212, }, },
},
    NullableValue = 
new System.Byte[,] { { 96, 24, }, { 155, 217, }, },
},
            new ByteMArrayD2E1M
{
    Id = 117,
    Value = 
new System.Byte[,] { { 90, 152, }, { 245, 190, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 127,
    Value = 
new System.Byte[,] { { 43, 218, }, { 251, 39, }, },
    NullableValue = 
new System.Byte[,] { { 58, 184, }, { 10, 28, }, },
},
    NullableValue = 
new System.Byte[,] { { 0, 123, }, { 116, 91, }, },
},
            new ByteMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Byte[,] { { 236, 204, }, { 184, 84, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Byte[,] { { 112, 192, }, { 28, 240, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Byte[,] { { 124, 10, }, { 44, 161, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Byte[,] { { 53, 218, }, { 70, 111, }, },
    NullableValue = 
new System.Byte[,] { { 50, 112, }, { 172, 62, }, },
},
    NullableValue = 
new System.Byte[,] { { 158, 218, }, { 152, 72, }, },
},
            new ByteMArrayD2E1M
{
    Id = 133,
    Value = 
new System.Byte[,] { { 14, 211, }, { 230, 29, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 146,
    Value = 
new System.Byte[,] { { 103, 7, }, { 250, 181, }, },
    NullableValue = 
new System.Byte[,] { { 16, 59, }, { 81, 136, }, },
},
    NullableValue = 
new System.Byte[,] { { 153, 76, }, { 58, 56, }, },
},
            new ByteMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Byte[,] { { 106, 151, }, { 155, 107, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Byte[,] { { 117, 184, }, { 169, 239, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Byte[,] { { 225, 183, }, { 249, 89, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Byte[,] { { 29, 43, }, { 225, 43, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 152,
    Value = 
new System.Byte[,] { { 137, 246, }, { 178, 130, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Byte[,] { { 123, 226, }, { 201, 40, }, },
    NullableValue = 
new System.Byte[,] { { 76, 234, }, { 204, 101, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Byte[,] { { 243, 10, }, { 110, 39, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 157,
    Value = 
new System.Byte[,] { { 131, 91, }, { 190, 230, }, },
    NullableValue = 
new System.Byte[,] { { 100, 238, }, { 160, 141, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 163,
    Value = 
new System.Byte[,] { { 251, 179, }, { 186, 79, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 161,
    Value = 
new System.Byte[,] { { 178, 1, }, { 44, 36, }, },
    NullableValue = 
new System.Byte[,] { { 206, 164, }, { 100, 118, }, },
},
    NullableValue = null,
},
            new ByteMArrayD2E1M
{
    Id = 168,
    Value = 
new System.Byte[,] { { 111, 36, }, { 230, 197, }, },
    ModelInner = new ByteMArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Byte[,] { { 139, 12, }, { 175, 152, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Byte[,] { { 235, 25, }, { 9, 107, }, },
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

