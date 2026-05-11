

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
    internal partial interface IInt16SingleTypeInt16
    {
    }
    
    internal partial class Int16SingleTypeInt16 : IInt16SingleTypeInt16
    {


#region TestData

        private readonly Int16Int16E0M[] _testData = new Int16Int16E0M[]
        {
            new Int16Int16E0M
{
    Id = 5,
    Value = 11031,
    ModelInner = new Int16Int16E0MI
{
    Id = 7,
    Value = 23283,
    NullableValue = null,
},
    NullableValue = 30334,
},
            new Int16Int16E0M
{
    Id = 7,
    Value = 21194,
    ModelInner = new Int16Int16E0MI
{
    Id = 11,
    Value = 14634,
    NullableValue = 1977,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 8,
    Value = 30976,
    ModelInner = new Int16Int16E0MI
{
    Id = 18,
    Value = 14925,
    NullableValue = 10119,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 10,
    Value = 29374,
    ModelInner = new Int16Int16E0MI
{
    Id = 19,
    Value = 3445,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 12,
    Value = 30155,
    ModelInner = new Int16Int16E0MI
{
    Id = 23,
    Value = 4595,
    NullableValue = 25611,
},
    NullableValue = 11038,
},
            new Int16Int16E0M
{
    Id = 15,
    Value = 28543,
    ModelInner = new Int16Int16E0MI
{
    Id = 25,
    Value = 29361,
    NullableValue = 13015,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 23,
    Value = 26780,
    ModelInner = new Int16Int16E0MI
{
    Id = 31,
    Value = 8974,
    NullableValue = 23345,
},
    NullableValue = 2450,
},
            new Int16Int16E0M
{
    Id = 24,
    Value = 30325,
    ModelInner = new Int16Int16E0MI
{
    Id = 37,
    Value = 15338,
    NullableValue = 22061,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 27,
    Value = 21423,
    ModelInner = new Int16Int16E0MI
{
    Id = 43,
    Value = 25334,
    NullableValue = 19984,
},
    NullableValue = 12736,
},
            new Int16Int16E0M
{
    Id = 31,
    Value = 14587,
    ModelInner = new Int16Int16E0MI
{
    Id = 49,
    Value = 26950,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 39,
    Value = 26086,
    ModelInner = new Int16Int16E0MI
{
    Id = 54,
    Value = 14432,
    NullableValue = 3549,
},
    NullableValue = 23792,
},
            new Int16Int16E0M
{
    Id = 44,
    Value = 12972,
    ModelInner = new Int16Int16E0MI
{
    Id = 56,
    Value = 17245,
    NullableValue = null,
},
    NullableValue = 10705,
},
            new Int16Int16E0M
{
    Id = 46,
    Value = 24137,
    ModelInner = new Int16Int16E0MI
{
    Id = 65,
    Value = 20795,
    NullableValue = 32188,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 50,
    Value = 30156,
    ModelInner = new Int16Int16E0MI
{
    Id = 66,
    Value = 32699,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 59,
    Value = 8985,
    ModelInner = new Int16Int16E0MI
{
    Id = 67,
    Value = 6035,
    NullableValue = 5584,
},
    NullableValue = 18613,
},
            new Int16Int16E0M
{
    Id = 64,
    Value = 3267,
    ModelInner = new Int16Int16E0MI
{
    Id = 75,
    Value = 27079,
    NullableValue = 27401,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 65,
    Value = 23881,
    ModelInner = new Int16Int16E0MI
{
    Id = 84,
    Value = 26960,
    NullableValue = 18611,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 66,
    Value = 10190,
    ModelInner = new Int16Int16E0MI
{
    Id = 87,
    Value = 4485,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 69,
    Value = 27933,
    ModelInner = new Int16Int16E0MI
{
    Id = 92,
    Value = 28804,
    NullableValue = null,
},
    NullableValue = 26362,
},
            new Int16Int16E0M
{
    Id = 73,
    Value = 20080,
    ModelInner = new Int16Int16E0MI
{
    Id = 100,
    Value = 2465,
    NullableValue = 4302,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 74,
    Value = 30893,
    ModelInner = new Int16Int16E0MI
{
    Id = 106,
    Value = 7575,
    NullableValue = null,
},
    NullableValue = 17923,
},
            new Int16Int16E0M
{
    Id = 79,
    Value = 17346,
    ModelInner = new Int16Int16E0MI
{
    Id = 111,
    Value = 8665,
    NullableValue = 29977,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 82,
    Value = 22436,
    ModelInner = new Int16Int16E0MI
{
    Id = 119,
    Value = 20441,
    NullableValue = null,
},
    NullableValue = 28078,
},
            new Int16Int16E0M
{
    Id = 86,
    Value = 26757,
    ModelInner = new Int16Int16E0MI
{
    Id = 120,
    Value = 15506,
    NullableValue = null,
},
    NullableValue = 28240,
},
            new Int16Int16E0M
{
    Id = 91,
    Value = 30844,
    ModelInner = new Int16Int16E0MI
{
    Id = 126,
    Value = 18877,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 98,
    Value = 9597,
    ModelInner = new Int16Int16E0MI
{
    Id = 131,
    Value = 9996,
    NullableValue = 5971,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 104,
    Value = 7805,
    ModelInner = new Int16Int16E0MI
{
    Id = 134,
    Value = 6189,
    NullableValue = null,
},
    NullableValue = 727,
},
            new Int16Int16E0M
{
    Id = 110,
    Value = 9658,
    ModelInner = new Int16Int16E0MI
{
    Id = 142,
    Value = 15212,
    NullableValue = 23288,
},
    NullableValue = 8058,
},
            new Int16Int16E0M
{
    Id = 118,
    Value = 9101,
    ModelInner = new Int16Int16E0MI
{
    Id = 146,
    Value = 22004,
    NullableValue = null,
},
    NullableValue = 22267,
},
            new Int16Int16E0M
{
    Id = 125,
    Value = 6105,
    ModelInner = new Int16Int16E0MI
{
    Id = 148,
    Value = 3882,
    NullableValue = 2068,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 130,
    Value = 15280,
    ModelInner = new Int16Int16E0MI
{
    Id = 153,
    Value = 32281,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 134,
    Value = 28785,
    ModelInner = new Int16Int16E0MI
{
    Id = 162,
    Value = 2211,
    NullableValue = 27456,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 136,
    Value = 16306,
    ModelInner = new Int16Int16E0MI
{
    Id = 166,
    Value = 16830,
    NullableValue = null,
},
    NullableValue = 7862,
},
            new Int16Int16E0M
{
    Id = 141,
    Value = 8320,
    ModelInner = new Int16Int16E0MI
{
    Id = 168,
    Value = 23846,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16Int16E0M
{
    Id = 146,
    Value = 23588,
    ModelInner = new Int16Int16E0MI
{
    Id = 175,
    Value = 17804,
    NullableValue = null,
},
    NullableValue = 11521,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16int16e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int16}, 
    {mi_id:Int32},
    {mi_value:Int16}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypeInt16)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16), 
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
                    await ((IInt16SingleTypeInt16)this).InsertModelDbConnectionAsync(
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
                     ((IInt16SingleTypeInt16)this).InsertModelDbConnection(
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
FROM gedaqtests.int16int16e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16Int16E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16SingleTypeInt16)),
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
                    var models = await ((IInt16SingleTypeInt16)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16SingleTypeInt16)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16Int16E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

