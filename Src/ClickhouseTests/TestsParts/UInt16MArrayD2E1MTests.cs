

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
    internal partial interface IUInt16MArrayMArrayD2
    {
    }
    
    internal partial class UInt16MArrayMArrayD2 : IUInt16MArrayMArrayD2
    {


#region TestData

        private readonly UInt16MArrayD2E1M[] _testData = new UInt16MArrayD2E1M[]
        {
            new UInt16MArrayD2E1M
{
    Id = 3,
    Value = 
new System.UInt16[,] { { 45665, 21496, }, { 4263, 20079, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.UInt16[,] { { 50683, 25457, }, { 34623, 21129, }, },
    NullableValue = 
new System.UInt16[,] { { 37288, 46449, }, { 24923, 27926, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 7,
    Value = 
new System.UInt16[,] { { 38462, 55572, }, { 54410, 54855, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 10,
    Value = 
new System.UInt16[,] { { 39626, 50398, }, { 11039, 65398, }, },
    NullableValue = 
new System.UInt16[,] { { 19885, 34552, }, { 26942, 12197, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 13,
    Value = 
new System.UInt16[,] { { 103, 13259, }, { 25616, 53248, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.UInt16[,] { { 51010, 22778, }, { 15128, 7568, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 54117, 45331, }, { 29096, 61263, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 14,
    Value = 
new System.UInt16[,] { { 5798, 39911, }, { 43289, 33513, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.UInt16[,] { { 55198, 8427, }, { 27128, 12586, }, },
    NullableValue = 
new System.UInt16[,] { { 56252, 62442, }, { 39095, 12513, }, },
},
    NullableValue = 
new System.UInt16[,] { { 60785, 57649, }, { 5233, 15908, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 21,
    Value = 
new System.UInt16[,] { { 64315, 21972, }, { 42287, 31210, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.UInt16[,] { { 6537, 9616, }, { 3745, 28608, }, },
    NullableValue = 
new System.UInt16[,] { { 24334, 19801, }, { 60053, 6107, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 27,
    Value = 
new System.UInt16[,] { { 63946, 32689, }, { 21957, 21195, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 24,
    Value = 
new System.UInt16[,] { { 29278, 41635, }, { 57857, 47099, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 36,
    Value = 
new System.UInt16[,] { { 35905, 64943, }, { 28008, 47857, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt16[,] { { 36202, 49598, }, { 43730, 53428, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 607, 19061, }, { 7464, 48499, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 38,
    Value = 
new System.UInt16[,] { { 15859, 37176, }, { 47847, 54956, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.UInt16[,] { { 63508, 38808, }, { 50205, 11250, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 56965, 48659, }, { 49058, 4418, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 45,
    Value = 
new System.UInt16[,] { { 64809, 45588, }, { 38300, 60562, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.UInt16[,] { { 41286, 34882, }, { 33712, 6336, }, },
    NullableValue = 
new System.UInt16[,] { { 61169, 57760, }, { 11662, 11946, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 48,
    Value = 
new System.UInt16[,] { { 25257, 14644, }, { 40123, 47647, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.UInt16[,] { { 47643, 18537, }, { 18229, 65068, }, },
    NullableValue = 
new System.UInt16[,] { { 24264, 29921, }, { 39110, 38510, }, },
},
    NullableValue = 
new System.UInt16[,] { { 47543, 28816, }, { 5536, 40819, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 55,
    Value = 
new System.UInt16[,] { { 26384, 21717, }, { 55444, 19326, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.UInt16[,] { { 64560, 2819, }, { 44072, 13239, }, },
    NullableValue = 
new System.UInt16[,] { { 45577, 55258, }, { 2, 16234, }, },
},
    NullableValue = 
new System.UInt16[,] { { 20420, 53247, }, { 517, 25577, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt16[,] { { 63247, 42263, }, { 37108, 54635, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 44,
    Value = 
new System.UInt16[,] { { 450, 44341, }, { 23519, 62248, }, },
    NullableValue = 
new System.UInt16[,] { { 48902, 60574, }, { 31378, 15480, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 64,
    Value = 
new System.UInt16[,] { { 12935, 26540, }, { 18204, 60914, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt16[,] { { 45294, 20243, }, { 36727, 39963, }, },
    NullableValue = 
new System.UInt16[,] { { 24943, 9398, }, { 50402, 26971, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 67,
    Value = 
new System.UInt16[,] { { 40855, 10751, }, { 49379, 30715, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.UInt16[,] { { 213, 27633, }, { 6010, 35091, }, },
    NullableValue = 
new System.UInt16[,] { { 40367, 2683, }, { 59916, 29758, }, },
},
    NullableValue = 
new System.UInt16[,] { { 37910, 51888, }, { 61511, 36857, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 70,
    Value = 
new System.UInt16[,] { { 50484, 57501, }, { 44446, 50185, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 66,
    Value = 
new System.UInt16[,] { { 7847, 51634, }, { 7644, 1008, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 34710, 28289, }, { 58515, 63836, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 75,
    Value = 
new System.UInt16[,] { { 10282, 29458, }, { 58427, 37533, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 75,
    Value = 
new System.UInt16[,] { { 58620, 42143, }, { 46474, 46891, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 78,
    Value = 
new System.UInt16[,] { { 7275, 31997, }, { 54793, 13218, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.UInt16[,] { { 64592, 46046, }, { 16974, 22, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 83,
    Value = 
new System.UInt16[,] { { 24816, 54682, }, { 49860, 62769, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.UInt16[,] { { 49297, 965, }, { 61273, 14851, }, },
    NullableValue = 
new System.UInt16[,] { { 63640, 40434, }, { 2415, 20171, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt16[,] { { 5358, 1741, }, { 54178, 17890, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.UInt16[,] { { 9017, 28317, }, { 17838, 40628, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 24618, 44708, }, { 13389, 32063, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 91,
    Value = 
new System.UInt16[,] { { 19388, 26056, }, { 22391, 51395, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 91,
    Value = 
new System.UInt16[,] { { 14771, 44039, }, { 35495, 48624, }, },
    NullableValue = 
new System.UInt16[,] { { 24061, 54780, }, { 31253, 17724, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 99,
    Value = 
new System.UInt16[,] { { 24894, 3582, }, { 25126, 37236, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.UInt16[,] { { 61078, 39295, }, { 13729, 22914, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 48718, 20936, }, { 59777, 1439, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt16[,] { { 53319, 14517, }, { 48576, 14307, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 106,
    Value = 
new System.UInt16[,] { { 7362, 14856, }, { 43785, 4783, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 34321, 33872, }, { 14081, 9533, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 111,
    Value = 
new System.UInt16[,] { { 40613, 20781, }, { 18675, 55823, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.UInt16[,] { { 26495, 62458, }, { 15083, 45992, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 38718, 42161, }, { 47718, 23832, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 112,
    Value = 
new System.UInt16[,] { { 21996, 20044, }, { 52892, 13939, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.UInt16[,] { { 9042, 62082, }, { 24849, 12927, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 119,
    Value = 
new System.UInt16[,] { { 50444, 37377, }, { 5588, 53597, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 118,
    Value = 
new System.UInt16[,] { { 45668, 37554, }, { 11230, 31424, }, },
    NullableValue = 
new System.UInt16[,] { { 32411, 27214, }, { 20151, 28339, }, },
},
    NullableValue = 
new System.UInt16[,] { { 44312, 58975, }, { 7555, 8609, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 120,
    Value = 
new System.UInt16[,] { { 60350, 37396, }, { 35963, 47754, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 127,
    Value = 
new System.UInt16[,] { { 31835, 50908, }, { 13388, 5511, }, },
    NullableValue = 
new System.UInt16[,] { { 19513, 56258, }, { 4457, 56888, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 128,
    Value = 
new System.UInt16[,] { { 55552, 56896, }, { 20701, 10519, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 134,
    Value = 
new System.UInt16[,] { { 30280, 369, }, { 47258, 45567, }, },
    NullableValue = 
new System.UInt16[,] { { 47617, 58278, }, { 51120, 46562, }, },
},
    NullableValue = 
new System.UInt16[,] { { 2515, 11406, }, { 36306, 64713, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 131,
    Value = 
new System.UInt16[,] { { 14048, 37269, }, { 6389, 60456, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.UInt16[,] { { 16311, 22992, }, { 21753, 7953, }, },
    NullableValue = 
new System.UInt16[,] { { 46678, 39327, }, { 48732, 56617, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 133,
    Value = 
new System.UInt16[,] { { 26318, 3411, }, { 31692, 12083, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt16[,] { { 18400, 55300, }, { 39902, 46705, }, },
    NullableValue = 
new System.UInt16[,] { { 16438, 49171, }, { 9841, 25008, }, },
},
    NullableValue = 
new System.UInt16[,] { { 26575, 3488, }, { 38893, 30977, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 139,
    Value = 
new System.UInt16[,] { { 35851, 52331, }, { 50586, 48559, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.UInt16[,] { { 54579, 23731, }, { 44605, 41583, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 147,
    Value = 
new System.UInt16[,] { { 11132, 23257, }, { 5249, 20773, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 155,
    Value = 
new System.UInt16[,] { { 62784, 32006, }, { 45338, 5188, }, },
    NullableValue = 
new System.UInt16[,] { { 38057, 20450, }, { 2323, 47206, }, },
},
    NullableValue = 
new System.UInt16[,] { { 56907, 19535, }, { 30982, 20189, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt16[,] { { 11120, 59939, }, { 1003, 18911, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.UInt16[,] { { 50631, 47378, }, { 33200, 34404, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 156,
    Value = 
new System.UInt16[,] { { 61242, 47302, }, { 19276, 5492, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 167,
    Value = 
new System.UInt16[,] { { 37156, 376, }, { 28793, 11339, }, },
    NullableValue = 
new System.UInt16[,] { { 20063, 49780, }, { 1668, 5940, }, },
},
    NullableValue = 
new System.UInt16[,] { { 19254, 10354, }, { 3871, 20973, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 165,
    Value = 
new System.UInt16[,] { { 18899, 48737, }, { 23598, 11784, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 173,
    Value = 
new System.UInt16[,] { { 48748, 64791, }, { 701, 32829, }, },
    NullableValue = 
new System.UInt16[,] { { 43378, 50790, }, { 21785, 54734, }, },
},
    NullableValue = 
new System.UInt16[,] { { 18182, 18221, }, { 12558, 14516, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 167,
    Value = 
new System.UInt16[,] { { 6964, 42879, }, { 58457, 26737, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 178,
    Value = 
new System.UInt16[,] { { 29793, 30949, }, { 38171, 61351, }, },
    NullableValue = 
new System.UInt16[,] { { 14938, 36431, }, { 58441, 39984, }, },
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
INSERT INTO gedaqtests.uint16marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt16))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt16))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt16[,]), 
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
                    await ((IUInt16MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IUInt16MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.uint16marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt16MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt16MArrayMArrayD2)),
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
                    var models = await ((IUInt16MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt16MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

