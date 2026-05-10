

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
    internal partial interface IUInt64SingleTypeUInt64
    {
    }
    
    internal partial class UInt64SingleTypeUInt64 : IUInt64SingleTypeUInt64
    {


#region TestData

        private readonly UInt64UInt640M[] _testData = new UInt64UInt640M[]
        {
            new UInt64UInt640M
{
    Id = 4,
    Value = 805209994745610106L,
    ModelInner = new UInt64UInt640MI
{
    Id = 9,
    Value = 4855982079116375491L,
    NullableValue = null,
},
    NullableValue = 955866996103007291L,
},
            new UInt64UInt640M
{
    Id = 10,
    Value = 3603174253374736103L,
    ModelInner = new UInt64UInt640MI
{
    Id = 14,
    Value = 9183311018932151223L,
    NullableValue = null,
},
    NullableValue = 7602751613612213674L,
},
            new UInt64UInt640M
{
    Id = 17,
    Value = 8756070623528705102L,
    ModelInner = new UInt64UInt640MI
{
    Id = 22,
    Value = 5702609631102419212L,
    NullableValue = 7884876807447226992L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 18,
    Value = 8819119271980455147L,
    ModelInner = new UInt64UInt640MI
{
    Id = 30,
    Value = 8369126018735157028L,
    NullableValue = 5842907268265663639L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 19,
    Value = 9013941065370352262L,
    ModelInner = new UInt64UInt640MI
{
    Id = 37,
    Value = 8512701113527465230L,
    NullableValue = 3630307169913105582L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 26,
    Value = 5144279840916995866L,
    ModelInner = new UInt64UInt640MI
{
    Id = 43,
    Value = 306239806403154101L,
    NullableValue = 3281697055771846707L,
},
    NullableValue = 6766077773838299305L,
},
            new UInt64UInt640M
{
    Id = 27,
    Value = 8680123679569112480L,
    ModelInner = new UInt64UInt640MI
{
    Id = 44,
    Value = 2486297311041895546L,
    NullableValue = 4595233525002158609L,
},
    NullableValue = 8768272253902864473L,
},
            new UInt64UInt640M
{
    Id = 30,
    Value = 1205785615988267809L,
    ModelInner = new UInt64UInt640MI
{
    Id = 53,
    Value = 4233026983607831646L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 32,
    Value = 6070664985603055749L,
    ModelInner = new UInt64UInt640MI
{
    Id = 57,
    Value = 5473704557270315228L,
    NullableValue = 2023181755113311559L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 39,
    Value = 4147724501391907460L,
    ModelInner = new UInt64UInt640MI
{
    Id = 62,
    Value = 1527718635685888227L,
    NullableValue = 5327358881257716097L,
},
    NullableValue = 4607951399066481361L,
},
            new UInt64UInt640M
{
    Id = 43,
    Value = 3729947899793054179L,
    ModelInner = new UInt64UInt640MI
{
    Id = 63,
    Value = 7424048652724284802L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 44,
    Value = 8006944854409208772L,
    ModelInner = new UInt64UInt640MI
{
    Id = 67,
    Value = 1173581960105692592L,
    NullableValue = null,
},
    NullableValue = 5152643767083487526L,
},
            new UInt64UInt640M
{
    Id = 50,
    Value = 51457556548259372L,
    ModelInner = new UInt64UInt640MI
{
    Id = 71,
    Value = 8456825882897311546L,
    NullableValue = 6569421380548909363L,
},
    NullableValue = 1439963438300007286L,
},
            new UInt64UInt640M
{
    Id = 52,
    Value = 2124281955354250152L,
    ModelInner = new UInt64UInt640MI
{
    Id = 74,
    Value = 612391418489470401L,
    NullableValue = null,
},
    NullableValue = 574110812857063631L,
},
            new UInt64UInt640M
{
    Id = 60,
    Value = 6912248714424523179L,
    ModelInner = new UInt64UInt640MI
{
    Id = 77,
    Value = 8499205898062165925L,
    NullableValue = 8057694608684674119L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 68,
    Value = 84393291080757651L,
    ModelInner = new UInt64UInt640MI
{
    Id = 85,
    Value = 8313010943456681967L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 71,
    Value = 961047295889925359L,
    ModelInner = new UInt64UInt640MI
{
    Id = 90,
    Value = 3459048757512494815L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 76,
    Value = 5940457741911808233L,
    ModelInner = new UInt64UInt640MI
{
    Id = 92,
    Value = 8754578924012922797L,
    NullableValue = 2153678111243562058L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 82,
    Value = 11268268668019514L,
    ModelInner = new UInt64UInt640MI
{
    Id = 101,
    Value = 394494514783814257L,
    NullableValue = 4455241882845837180L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 91,
    Value = 5036912267610588730L,
    ModelInner = new UInt64UInt640MI
{
    Id = 105,
    Value = 4989408044543416028L,
    NullableValue = null,
},
    NullableValue = 4354219614278860451L,
},
            new UInt64UInt640M
{
    Id = 99,
    Value = 6425052161916085764L,
    ModelInner = new UInt64UInt640MI
{
    Id = 106,
    Value = 7239534785949645607L,
    NullableValue = 7930646714077772877L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 102,
    Value = 5984652622537594117L,
    ModelInner = new UInt64UInt640MI
{
    Id = 107,
    Value = 4574754314144812736L,
    NullableValue = 1766807197998527508L,
},
    NullableValue = 9148435543559948741L,
},
            new UInt64UInt640M
{
    Id = 111,
    Value = 7630363257760090641L,
    ModelInner = new UInt64UInt640MI
{
    Id = 109,
    Value = 62061325705874240L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 120,
    Value = 3662856180539305065L,
    ModelInner = new UInt64UInt640MI
{
    Id = 116,
    Value = 7341773541279935220L,
    NullableValue = 8257482998443486829L,
},
    NullableValue = 2175673159326952832L,
},
            new UInt64UInt640M
{
    Id = 121,
    Value = 3364488132034604302L,
    ModelInner = new UInt64UInt640MI
{
    Id = 121,
    Value = 3898227733068190828L,
    NullableValue = 6876208890855773143L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 129,
    Value = 7218087803465522795L,
    ModelInner = new UInt64UInt640MI
{
    Id = 128,
    Value = 5754758199646238836L,
    NullableValue = 7860396897147902053L,
},
    NullableValue = 8265694016206853030L,
},
            new UInt64UInt640M
{
    Id = 137,
    Value = 4249844833603413763L,
    ModelInner = new UInt64UInt640MI
{
    Id = 131,
    Value = 5653325509780705178L,
    NullableValue = 5279298742835611719L,
},
    NullableValue = 4226390399933954744L,
},
            new UInt64UInt640M
{
    Id = 144,
    Value = 2748321197089019911L,
    ModelInner = new UInt64UInt640MI
{
    Id = 139,
    Value = 163304830779084257L,
    NullableValue = 7246490593457776369L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 151,
    Value = 8999431301996219525L,
    ModelInner = new UInt64UInt640MI
{
    Id = 147,
    Value = 3252096474347541728L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 154,
    Value = 2663546796606495343L,
    ModelInner = new UInt64UInt640MI
{
    Id = 149,
    Value = 5285225393921082706L,
    NullableValue = 4537517623538658465L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 158,
    Value = 1739094433035868867L,
    ModelInner = new UInt64UInt640MI
{
    Id = 152,
    Value = 7032835600242361347L,
    NullableValue = 7128876556046067056L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 160,
    Value = 3757846811166256780L,
    ModelInner = new UInt64UInt640MI
{
    Id = 158,
    Value = 5806389008865781967L,
    NullableValue = 3559621619844998679L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 162,
    Value = 8851322248050966300L,
    ModelInner = new UInt64UInt640MI
{
    Id = 166,
    Value = 1453637689658795059L,
    NullableValue = 5267449112346790917L,
},
    NullableValue = 7558544198433533030L,
},
            new UInt64UInt640M
{
    Id = 171,
    Value = 8286934730129262044L,
    ModelInner = new UInt64UInt640MI
{
    Id = 167,
    Value = 1467106407936726265L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 172,
    Value = 2356958830220175518L,
    ModelInner = new UInt64UInt640MI
{
    Id = 173,
    Value = 3962069553752711382L,
    NullableValue = null,
},
    NullableValue = 6301208738430464822L,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64uint640m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt64}, 
    {mi_id:Int32},
    {mi_value:UInt64}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypeUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
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
                    await ((IUInt64SingleTypeUInt64)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64SingleTypeUInt64)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64uint640m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64UInt640M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypeUInt64)),
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
                    var models = await ((IUInt64SingleTypeUInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt640M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64SingleTypeUInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt640M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

