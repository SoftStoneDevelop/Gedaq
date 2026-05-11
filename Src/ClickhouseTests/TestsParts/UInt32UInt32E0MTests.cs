

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
    internal partial interface IUInt32SingleTypeUInt32
    {
    }
    
    internal partial class UInt32SingleTypeUInt32 : IUInt32SingleTypeUInt32
    {


#region TestData

        private readonly UInt32UInt32E0M[] _testData = new UInt32UInt32E0M[]
        {
            new UInt32UInt32E0M
{
    Id = 3,
    Value = 2740526273,
    ModelInner = new UInt32UInt320MI
{
    Id = 5,
    Value = 93267358,
    NullableValue = 1115018148,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 9,
    Value = 1339687411,
    ModelInner = new UInt32UInt320MI
{
    Id = 13,
    Value = 3518331281,
    NullableValue = 2846641493,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 16,
    Value = 3170323808,
    ModelInner = new UInt32UInt320MI
{
    Id = 19,
    Value = 3832566353,
    NullableValue = 456174806,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 25,
    Value = 93955529,
    ModelInner = new UInt32UInt320MI
{
    Id = 23,
    Value = 3165760810,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 33,
    Value = 4141953987,
    ModelInner = new UInt32UInt320MI
{
    Id = 24,
    Value = 3654964682,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 42,
    Value = 2073286431,
    ModelInner = new UInt32UInt320MI
{
    Id = 32,
    Value = 761881585,
    NullableValue = 1001139971,
},
    NullableValue = 340888904,
},
            new UInt32UInt32E0M
{
    Id = 44,
    Value = 167662156,
    ModelInner = new UInt32UInt320MI
{
    Id = 41,
    Value = 1128294709,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 51,
    Value = 4038203684,
    ModelInner = new UInt32UInt320MI
{
    Id = 42,
    Value = 695061742,
    NullableValue = null,
},
    NullableValue = 893180463,
},
            new UInt32UInt32E0M
{
    Id = 58,
    Value = 3799354327,
    ModelInner = new UInt32UInt320MI
{
    Id = 49,
    Value = 2391468089,
    NullableValue = 2613173685,
},
    NullableValue = 3333911761,
},
            new UInt32UInt32E0M
{
    Id = 60,
    Value = 2389011,
    ModelInner = new UInt32UInt320MI
{
    Id = 50,
    Value = 1228361594,
    NullableValue = 1185660967,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 67,
    Value = 310196352,
    ModelInner = new UInt32UInt320MI
{
    Id = 54,
    Value = 1359721747,
    NullableValue = 3904738615,
},
    NullableValue = 2976910737,
},
            new UInt32UInt32E0M
{
    Id = 69,
    Value = 2355974436,
    ModelInner = new UInt32UInt320MI
{
    Id = 57,
    Value = 492570481,
    NullableValue = 283208352,
},
    NullableValue = 3602581824,
},
            new UInt32UInt32E0M
{
    Id = 75,
    Value = 845355835,
    ModelInner = new UInt32UInt320MI
{
    Id = 59,
    Value = 1161338475,
    NullableValue = 1949535596,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 83,
    Value = 1123261825,
    ModelInner = new UInt32UInt320MI
{
    Id = 60,
    Value = 1277580437,
    NullableValue = 351171662,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 90,
    Value = 2191407833,
    ModelInner = new UInt32UInt320MI
{
    Id = 68,
    Value = 4195744059,
    NullableValue = 492132412,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 93,
    Value = 2233504160,
    ModelInner = new UInt32UInt320MI
{
    Id = 77,
    Value = 2229306220,
    NullableValue = 2402467670,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 96,
    Value = 962165897,
    ModelInner = new UInt32UInt320MI
{
    Id = 80,
    Value = 2230742617,
    NullableValue = null,
},
    NullableValue = 1263561948,
},
            new UInt32UInt32E0M
{
    Id = 99,
    Value = 660154040,
    ModelInner = new UInt32UInt320MI
{
    Id = 83,
    Value = 1837861785,
    NullableValue = 2807235038,
},
    NullableValue = 683973248,
},
            new UInt32UInt32E0M
{
    Id = 108,
    Value = 3902457564,
    ModelInner = new UInt32UInt320MI
{
    Id = 91,
    Value = 717165517,
    NullableValue = 3730170343,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 114,
    Value = 1542256993,
    ModelInner = new UInt32UInt320MI
{
    Id = 97,
    Value = 2835061325,
    NullableValue = 3623645092,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 120,
    Value = 1282267470,
    ModelInner = new UInt32UInt320MI
{
    Id = 103,
    Value = 2070372185,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 125,
    Value = 4005859163,
    ModelInner = new UInt32UInt320MI
{
    Id = 112,
    Value = 3227587570,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 131,
    Value = 882209848,
    ModelInner = new UInt32UInt320MI
{
    Id = 120,
    Value = 2822841375,
    NullableValue = 3059954466,
},
    NullableValue = 2601584569,
},
            new UInt32UInt32E0M
{
    Id = 140,
    Value = 1700899366,
    ModelInner = new UInt32UInt320MI
{
    Id = 122,
    Value = 3332912576,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 149,
    Value = 1731078904,
    ModelInner = new UInt32UInt320MI
{
    Id = 129,
    Value = 4135059478,
    NullableValue = 3085743454,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 156,
    Value = 368727981,
    ModelInner = new UInt32UInt320MI
{
    Id = 137,
    Value = 1377780933,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 162,
    Value = 4142974149,
    ModelInner = new UInt32UInt320MI
{
    Id = 145,
    Value = 4229044901,
    NullableValue = 1990053217,
},
    NullableValue = 3237708821,
},
            new UInt32UInt32E0M
{
    Id = 167,
    Value = 2142488054,
    ModelInner = new UInt32UInt320MI
{
    Id = 151,
    Value = 1005838841,
    NullableValue = 1003496703,
},
    NullableValue = 2694906979,
},
            new UInt32UInt32E0M
{
    Id = 169,
    Value = 3087486355,
    ModelInner = new UInt32UInt320MI
{
    Id = 155,
    Value = 1419480190,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 173,
    Value = 1045913946,
    ModelInner = new UInt32UInt320MI
{
    Id = 161,
    Value = 1945138420,
    NullableValue = 3449462018,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 181,
    Value = 1755101762,
    ModelInner = new UInt32UInt320MI
{
    Id = 169,
    Value = 2446365642,
    NullableValue = 3064578488,
},
    NullableValue = 3327044416,
},
            new UInt32UInt32E0M
{
    Id = 184,
    Value = 1802757571,
    ModelInner = new UInt32UInt320MI
{
    Id = 178,
    Value = 2135881728,
    NullableValue = 4239093924,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 188,
    Value = 529252173,
    ModelInner = new UInt32UInt320MI
{
    Id = 185,
    Value = 1300729420,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 192,
    Value = 3587007028,
    ModelInner = new UInt32UInt320MI
{
    Id = 192,
    Value = 1384809758,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 197,
    Value = 3104275589,
    ModelInner = new UInt32UInt320MI
{
    Id = 201,
    Value = 2052682048,
    NullableValue = 2242043513,
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
INSERT INTO gedaqtests.uint32uint32e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt32}, 
    {mi_id:Int32},
    {mi_value:UInt32}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
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
                    await ((IUInt32SingleTypeUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32SingleTypeUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32uint32e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt32E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
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
                    var models = await ((IUInt32SingleTypeUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32SingleTypeUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

