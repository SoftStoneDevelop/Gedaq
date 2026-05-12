

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
    Id = 2,
    Value = 1929008198,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 6,
    Value = 389170508,
    NullableValue = null,
},
    NullableValue = 3289155222,
},
            new UInt32UInt32E0M
{
    Id = 5,
    Value = 3446773317,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 15,
    Value = 1950642646,
    NullableValue = 4238101141,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 12,
    Value = 1875484494,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 18,
    Value = 1966499609,
    NullableValue = 1123170947,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 15,
    Value = 2144909215,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 26,
    Value = 1713127158,
    NullableValue = null,
},
    NullableValue = 3161897936,
},
            new UInt32UInt32E0M
{
    Id = 17,
    Value = 3967810867,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 34,
    Value = 1833161237,
    NullableValue = 4164320296,
},
    NullableValue = 2713229436,
},
            new UInt32UInt32E0M
{
    Id = 22,
    Value = 3705625025,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 41,
    Value = 4028276295,
    NullableValue = 1603728985,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 28,
    Value = 492242568,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 47,
    Value = 4235682978,
    NullableValue = null,
},
    NullableValue = 363065502,
},
            new UInt32UInt32E0M
{
    Id = 29,
    Value = 1154794948,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 53,
    Value = 353756454,
    NullableValue = 2053594072,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 35,
    Value = 2977991251,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 58,
    Value = 3739890706,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 40,
    Value = 1062653437,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 59,
    Value = 3803281389,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 49,
    Value = 2328105010,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 64,
    Value = 851289117,
    NullableValue = 3108420718,
},
    NullableValue = 3820137553,
},
            new UInt32UInt32E0M
{
    Id = 56,
    Value = 3088345593,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 71,
    Value = 2277226861,
    NullableValue = null,
},
    NullableValue = 497882047,
},
            new UInt32UInt32E0M
{
    Id = 59,
    Value = 1242249712,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 77,
    Value = 2674156395,
    NullableValue = 805250896,
},
    NullableValue = 3834342292,
},
            new UInt32UInt32E0M
{
    Id = 64,
    Value = 3784858849,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 85,
    Value = 3770788099,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 69,
    Value = 257662126,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 91,
    Value = 4054236305,
    NullableValue = 1953527919,
},
    NullableValue = 1853365901,
},
            new UInt32UInt32E0M
{
    Id = 75,
    Value = 1928800871,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 92,
    Value = 3187399900,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 77,
    Value = 802857638,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 95,
    Value = 2900285693,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 85,
    Value = 1087224629,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 101,
    Value = 3666619394,
    NullableValue = null,
},
    NullableValue = 1172878557,
},
            new UInt32UInt32E0M
{
    Id = 94,
    Value = 3441658858,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 106,
    Value = 2934945939,
    NullableValue = null,
},
    NullableValue = 3374967039,
},
            new UInt32UInt32E0M
{
    Id = 98,
    Value = 1113646881,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 115,
    Value = 686460862,
    NullableValue = 4200524461,
},
    NullableValue = 125343846,
},
            new UInt32UInt32E0M
{
    Id = 100,
    Value = 376714321,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 119,
    Value = 653939605,
    NullableValue = 348544772,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 102,
    Value = 2555438680,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 121,
    Value = 68644047,
    NullableValue = 3338757020,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 108,
    Value = 2622799464,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 124,
    Value = 4006897159,
    NullableValue = 387678327,
},
    NullableValue = 1208445402,
},
            new UInt32UInt32E0M
{
    Id = 115,
    Value = 826287376,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 133,
    Value = 401111479,
    NullableValue = null,
},
    NullableValue = 2239195625,
},
            new UInt32UInt32E0M
{
    Id = 119,
    Value = 3452750974,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 134,
    Value = 1594368810,
    NullableValue = 2180896061,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 125,
    Value = 664964602,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 137,
    Value = 2730738691,
    NullableValue = 2127678359,
},
    NullableValue = 1991739614,
},
            new UInt32UInt32E0M
{
    Id = 133,
    Value = 529751832,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 140,
    Value = 1877317313,
    NullableValue = 999264120,
},
    NullableValue = 1565814711,
},
            new UInt32UInt32E0M
{
    Id = 141,
    Value = 2171266369,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 145,
    Value = 1440262897,
    NullableValue = 3703694425,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 146,
    Value = 3712584929,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 150,
    Value = 612225200,
    NullableValue = 2791682035,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 149,
    Value = 425541350,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 152,
    Value = 4282413225,
    NullableValue = 1341484493,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 152,
    Value = 1138576132,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 154,
    Value = 1181066425,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 158,
    Value = 2110867063,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 163,
    Value = 1365394458,
    NullableValue = 234704800,
},
    NullableValue = 3559415451,
},
            new UInt32UInt32E0M
{
    Id = 166,
    Value = 3700617708,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 166,
    Value = 295395415,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 168,
    Value = 706344350,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 168,
    Value = 3995546893,
    NullableValue = null,
},
    NullableValue = 2742269362,
},
            new UInt32UInt32E0M
{
    Id = 177,
    Value = 1959621933,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 171,
    Value = 316574599,
    NullableValue = null,
},
    NullableValue = 3563939014,
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

