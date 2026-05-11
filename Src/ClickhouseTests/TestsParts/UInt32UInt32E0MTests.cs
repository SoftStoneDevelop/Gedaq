

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
    Value = 2392184740,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 5,
    Value = 2155075942,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 6,
    Value = 1934564648,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 12,
    Value = 3619873578,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 13,
    Value = 4133389453,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 14,
    Value = 2047443657,
    NullableValue = 1377815864,
},
    NullableValue = 550902627,
},
            new UInt32UInt32E0M
{
    Id = 22,
    Value = 1193867826,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 20,
    Value = 159841857,
    NullableValue = null,
},
    NullableValue = 1687329240,
},
            new UInt32UInt32E0M
{
    Id = 31,
    Value = 316863807,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 21,
    Value = 1029638416,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 36,
    Value = 4076655161,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 27,
    Value = 2282829470,
    NullableValue = 862373124,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 38,
    Value = 4294014266,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 33,
    Value = 2547285262,
    NullableValue = 929579301,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 46,
    Value = 2494933246,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 35,
    Value = 4294166503,
    NullableValue = 4185976383,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 47,
    Value = 3003271266,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 43,
    Value = 3670662556,
    NullableValue = 631347080,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 55,
    Value = 3602896892,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 51,
    Value = 734047271,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 59,
    Value = 1351884621,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 59,
    Value = 3564685175,
    NullableValue = 2895349296,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 66,
    Value = 38897927,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 61,
    Value = 2238538907,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 71,
    Value = 3249592711,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 64,
    Value = 445990599,
    NullableValue = null,
},
    NullableValue = 1936444674,
},
            new UInt32UInt32E0M
{
    Id = 77,
    Value = 4269502342,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 68,
    Value = 2261510571,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 78,
    Value = 1113949075,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 75,
    Value = 421527123,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 83,
    Value = 3962471446,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 78,
    Value = 1715666976,
    NullableValue = null,
},
    NullableValue = 3396281499,
},
            new UInt32UInt32E0M
{
    Id = 91,
    Value = 1254755595,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 81,
    Value = 1651803857,
    NullableValue = null,
},
    NullableValue = 499936078,
},
            new UInt32UInt32E0M
{
    Id = 95,
    Value = 1290770764,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 89,
    Value = 1083863501,
    NullableValue = 3072387220,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 98,
    Value = 602602827,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 93,
    Value = 4261269111,
    NullableValue = 3208981050,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 100,
    Value = 4011654817,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 100,
    Value = 3888424856,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 104,
    Value = 625528369,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 109,
    Value = 2914927518,
    NullableValue = 3182020853,
},
    NullableValue = 2702461000,
},
            new UInt32UInt32E0M
{
    Id = 112,
    Value = 3879898613,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 113,
    Value = 2407682004,
    NullableValue = 2011793518,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 120,
    Value = 212362545,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 121,
    Value = 2859417325,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 127,
    Value = 709590359,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 125,
    Value = 1316993913,
    NullableValue = 3384613861,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 136,
    Value = 3513550025,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 126,
    Value = 2765731343,
    NullableValue = 1858700011,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 142,
    Value = 1308396545,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 134,
    Value = 1321102048,
    NullableValue = null,
},
    NullableValue = 496720451,
},
            new UInt32UInt32E0M
{
    Id = 145,
    Value = 4083796315,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 140,
    Value = 330101834,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 153,
    Value = 238715852,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 141,
    Value = 1631891625,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 154,
    Value = 131078692,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 148,
    Value = 1775692922,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 157,
    Value = 2500540348,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 149,
    Value = 1536649698,
    NullableValue = 405879163,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 161,
    Value = 1572863897,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 153,
    Value = 1226278040,
    NullableValue = null,
},
    NullableValue = 250053119,
},
            new UInt32UInt32E0M
{
    Id = 170,
    Value = 2900797861,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 160,
    Value = 3614632053,
    NullableValue = 3725097366,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 177,
    Value = 1173131210,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 168,
    Value = 456602909,
    NullableValue = 2217235832,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 183,
    Value = 2284380698,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 177,
    Value = 1424007536,
    NullableValue = null,
},
    NullableValue = 726819463,
},
            new UInt32UInt32E0M
{
    Id = 185,
    Value = 1981878069,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 180,
    Value = 1062231398,
    NullableValue = null,
},
    NullableValue = 4014463340,
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

