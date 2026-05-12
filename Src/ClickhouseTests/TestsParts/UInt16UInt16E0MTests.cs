

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
    internal partial interface IUInt16SingleTypeUInt16
    {
    }
    
    internal partial class UInt16SingleTypeUInt16 : IUInt16SingleTypeUInt16
    {


#region TestData

        private readonly UInt16UInt16E0M[] _testData = new UInt16UInt16E0M[]
        {
            new UInt16UInt16E0M
{
    Id = 7,
    Value = 54710,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 5,
    Value = 19185,
    NullableValue = 32727,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 15,
    Value = 56960,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 6,
    Value = 19055,
    NullableValue = 6420,
},
    NullableValue = 64042,
},
            new UInt16UInt16E0M
{
    Id = 21,
    Value = 56152,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 13,
    Value = 49410,
    NullableValue = null,
},
    NullableValue = 22071,
},
            new UInt16UInt16E0M
{
    Id = 28,
    Value = 54567,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 20,
    Value = 53441,
    NullableValue = 808,
},
    NullableValue = 43420,
},
            new UInt16UInt16E0M
{
    Id = 31,
    Value = 45568,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 22,
    Value = 44677,
    NullableValue = null,
},
    NullableValue = 26415,
},
            new UInt16UInt16E0M
{
    Id = 35,
    Value = 27391,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 30,
    Value = 11707,
    NullableValue = 64392,
},
    NullableValue = 8982,
},
            new UInt16UInt16E0M
{
    Id = 36,
    Value = 56281,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 37,
    Value = 50079,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 39,
    Value = 52727,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 40,
    Value = 36770,
    NullableValue = 31466,
},
    NullableValue = 26946,
},
            new UInt16UInt16E0M
{
    Id = 40,
    Value = 28218,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 48,
    Value = 26563,
    NullableValue = 37663,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 41,
    Value = 44906,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 52,
    Value = 44018,
    NullableValue = 28804,
},
    NullableValue = 10745,
},
            new UInt16UInt16E0M
{
    Id = 45,
    Value = 37294,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 57,
    Value = 62502,
    NullableValue = 37929,
},
    NullableValue = 49458,
},
            new UInt16UInt16E0M
{
    Id = 49,
    Value = 37239,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 64,
    Value = 64367,
    NullableValue = 41571,
},
    NullableValue = 17374,
},
            new UInt16UInt16E0M
{
    Id = 53,
    Value = 34343,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 71,
    Value = 65519,
    NullableValue = 3589,
},
    NullableValue = 30232,
},
            new UInt16UInt16E0M
{
    Id = 59,
    Value = 12583,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 80,
    Value = 2439,
    NullableValue = null,
},
    NullableValue = 42603,
},
            new UInt16UInt16E0M
{
    Id = 62,
    Value = 43787,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 85,
    Value = 25620,
    NullableValue = 52047,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 70,
    Value = 53421,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 94,
    Value = 52552,
    NullableValue = 41886,
},
    NullableValue = 18238,
},
            new UInt16UInt16E0M
{
    Id = 72,
    Value = 6277,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 103,
    Value = 36173,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 81,
    Value = 21614,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 107,
    Value = 2120,
    NullableValue = null,
},
    NullableValue = 13935,
},
            new UInt16UInt16E0M
{
    Id = 84,
    Value = 10552,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 110,
    Value = 16682,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 92,
    Value = 4708,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 113,
    Value = 53028,
    NullableValue = 36738,
},
    NullableValue = 57612,
},
            new UInt16UInt16E0M
{
    Id = 94,
    Value = 44100,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 117,
    Value = 26183,
    NullableValue = null,
},
    NullableValue = 39768,
},
            new UInt16UInt16E0M
{
    Id = 96,
    Value = 52362,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 118,
    Value = 48292,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 100,
    Value = 6367,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 119,
    Value = 51932,
    NullableValue = null,
},
    NullableValue = 27146,
},
            new UInt16UInt16E0M
{
    Id = 109,
    Value = 61632,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 122,
    Value = 38729,
    NullableValue = null,
},
    NullableValue = 59974,
},
            new UInt16UInt16E0M
{
    Id = 118,
    Value = 20002,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 123,
    Value = 22546,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 120,
    Value = 24353,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 130,
    Value = 6362,
    NullableValue = 28072,
},
    NullableValue = null,
},
            new UInt16UInt16E0M
{
    Id = 121,
    Value = 3361,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 138,
    Value = 35222,
    NullableValue = 35416,
},
    NullableValue = 15922,
},
            new UInt16UInt16E0M
{
    Id = 128,
    Value = 32953,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 140,
    Value = 38418,
    NullableValue = null,
},
    NullableValue = 18977,
},
            new UInt16UInt16E0M
{
    Id = 132,
    Value = 15901,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 143,
    Value = 65481,
    NullableValue = null,
},
    NullableValue = 57549,
},
            new UInt16UInt16E0M
{
    Id = 136,
    Value = 57401,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 144,
    Value = 15426,
    NullableValue = null,
},
    NullableValue = 34694,
},
            new UInt16UInt16E0M
{
    Id = 145,
    Value = 34344,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 151,
    Value = 64514,
    NullableValue = 41691,
},
    NullableValue = 29851,
},
            new UInt16UInt16E0M
{
    Id = 152,
    Value = 27832,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 160,
    Value = 53820,
    NullableValue = null,
},
    NullableValue = 25787,
},
            new UInt16UInt16E0M
{
    Id = 159,
    Value = 20930,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 165,
    Value = 33738,
    NullableValue = null,
},
    NullableValue = 40476,
},
            new UInt16UInt16E0M
{
    Id = 161,
    Value = 5870,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 167,
    Value = 35092,
    NullableValue = 32852,
},
    NullableValue = 53350,
},
            new UInt16UInt16E0M
{
    Id = 163,
    Value = 26817,
    ModelInner = new UInt16UInt16E0MI
{
    Id = 171,
    Value = 49137,
    NullableValue = null,
},
    NullableValue = 55391,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint16uint16e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt16}, 
    {mi_id:Int32},
    {mi_value:UInt16}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16), 
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
                    await ((IUInt16SingleTypeUInt16)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16SingleTypeUInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16uint16e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16UInt16E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16SingleTypeUInt16)),
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
                    var models = await ((IUInt16SingleTypeUInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16SingleTypeUInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16UInt16E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

