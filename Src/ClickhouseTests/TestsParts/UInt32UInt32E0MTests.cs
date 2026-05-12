

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
    Id = 8,
    Value = 1680074142,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 7,
    Value = 1255590351,
    NullableValue = 2985911376,
},
    NullableValue = 2117826758,
},
            new UInt32UInt32E0M
{
    Id = 13,
    Value = 2963245624,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 9,
    Value = 1346228628,
    NullableValue = 1552188289,
},
    NullableValue = 579956772,
},
            new UInt32UInt32E0M
{
    Id = 20,
    Value = 3834015183,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 11,
    Value = 758577250,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 27,
    Value = 2238574688,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 19,
    Value = 3155332298,
    NullableValue = 2661417799,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 36,
    Value = 3751251730,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 22,
    Value = 1690357994,
    NullableValue = 2226032394,
},
    NullableValue = 2007475095,
},
            new UInt32UInt32E0M
{
    Id = 39,
    Value = 3458772857,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 23,
    Value = 2723074261,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 40,
    Value = 2846263571,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 25,
    Value = 1572177065,
    NullableValue = 633522704,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 46,
    Value = 2604210320,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 30,
    Value = 3362449078,
    NullableValue = null,
},
    NullableValue = 1451856495,
},
            new UInt32UInt32E0M
{
    Id = 53,
    Value = 4012548737,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 36,
    Value = 2920666608,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 54,
    Value = 759392899,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 38,
    Value = 3664230392,
    NullableValue = 2341981173,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 63,
    Value = 2745203062,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 41,
    Value = 2485026256,
    NullableValue = null,
},
    NullableValue = 2855486006,
},
            new UInt32UInt32E0M
{
    Id = 72,
    Value = 3115934027,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 47,
    Value = 1987656083,
    NullableValue = null,
},
    NullableValue = 933984966,
},
            new UInt32UInt32E0M
{
    Id = 74,
    Value = 1269762854,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 56,
    Value = 1143639860,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 82,
    Value = 1188675534,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 60,
    Value = 2563275525,
    NullableValue = 3981732416,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 89,
    Value = 3656330639,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 61,
    Value = 3367534972,
    NullableValue = null,
},
    NullableValue = 1331515750,
},
            new UInt32UInt32E0M
{
    Id = 92,
    Value = 4192066219,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 68,
    Value = 1384336645,
    NullableValue = 3047901725,
},
    NullableValue = 2246248495,
},
            new UInt32UInt32E0M
{
    Id = 96,
    Value = 35349375,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 70,
    Value = 2082550139,
    NullableValue = 3682171163,
},
    NullableValue = 4081769693,
},
            new UInt32UInt32E0M
{
    Id = 99,
    Value = 2057576126,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 75,
    Value = 1294051950,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 103,
    Value = 2382653760,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 78,
    Value = 2675251703,
    NullableValue = 127808523,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 112,
    Value = 685478873,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 81,
    Value = 2799738015,
    NullableValue = 1917216490,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 118,
    Value = 2534507088,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 84,
    Value = 3798805771,
    NullableValue = null,
},
    NullableValue = 2238523378,
},
            new UInt32UInt32E0M
{
    Id = 123,
    Value = 964672627,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 87,
    Value = 4226742619,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 128,
    Value = 4227635065,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 93,
    Value = 2425821330,
    NullableValue = null,
},
    NullableValue = 4154434830,
},
            new UInt32UInt32E0M
{
    Id = 136,
    Value = 4171609128,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 94,
    Value = 2319540172,
    NullableValue = null,
},
    NullableValue = 825479395,
},
            new UInt32UInt32E0M
{
    Id = 139,
    Value = 815796497,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 101,
    Value = 2684292816,
    NullableValue = 448899908,
},
    NullableValue = 3357635725,
},
            new UInt32UInt32E0M
{
    Id = 141,
    Value = 2634938993,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 110,
    Value = 1123152216,
    NullableValue = null,
},
    NullableValue = 1510014331,
},
            new UInt32UInt32E0M
{
    Id = 149,
    Value = 2000552565,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 113,
    Value = 592851735,
    NullableValue = 1964727751,
},
    NullableValue = 3426288819,
},
            new UInt32UInt32E0M
{
    Id = 154,
    Value = 2912868251,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 120,
    Value = 4210703206,
    NullableValue = null,
},
    NullableValue = 194112830,
},
            new UInt32UInt32E0M
{
    Id = 161,
    Value = 3291330507,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 121,
    Value = 1255024140,
    NullableValue = 1333809800,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 163,
    Value = 2740388192,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 124,
    Value = 542015424,
    NullableValue = null,
},
    NullableValue = 2645438488,
},
            new UInt32UInt32E0M
{
    Id = 167,
    Value = 2377112266,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 126,
    Value = 3851433684,
    NullableValue = 11068714,
},
    NullableValue = 2496885130,
},
            new UInt32UInt32E0M
{
    Id = 169,
    Value = 4211877803,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 132,
    Value = 69514073,
    NullableValue = 2405620491,
},
    NullableValue = 1703476947,
},
            new UInt32UInt32E0M
{
    Id = 173,
    Value = 2387987483,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 133,
    Value = 3087520062,
    NullableValue = 1219421016,
},
    NullableValue = 3069492631,
},
            new UInt32UInt32E0M
{
    Id = 182,
    Value = 2388462355,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 137,
    Value = 2338744096,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 186,
    Value = 3169479364,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 142,
    Value = 1236889054,
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

