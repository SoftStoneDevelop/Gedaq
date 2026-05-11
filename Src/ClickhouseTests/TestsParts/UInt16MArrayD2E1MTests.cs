

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
    Id = 6,
    Value = 
new System.UInt16[,] { { 17203, 46788, }, { 19983, 22020, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 1,
    Value = 
new System.UInt16[,] { { 4513, 11697, }, { 61466, 52639, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 12,
    Value = 
new System.UInt16[,] { { 61134, 15977, }, { 52535, 292, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.UInt16[,] { { 48083, 53943, }, { 43639, 14731, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 16,
    Value = 
new System.UInt16[,] { { 28594, 47111, }, { 43879, 61516, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.UInt16[,] { { 56981, 53884, }, { 42662, 3953, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 24,
    Value = 
new System.UInt16[,] { { 15945, 20110, }, { 48582, 38987, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.UInt16[,] { { 50405, 63515, }, { 46483, 54609, }, },
    NullableValue = 
new System.UInt16[,] { { 3612, 1685, }, { 23511, 47282, }, },
},
    NullableValue = 
new System.UInt16[,] { { 20984, 60378, }, { 64612, 27133, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 31,
    Value = 
new System.UInt16[,] { { 48822, 42146, }, { 36669, 23134, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.UInt16[,] { { 6624, 10231, }, { 21211, 8550, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 40,
    Value = 
new System.UInt16[,] { { 54107, 22981, }, { 37540, 30603, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt16[,] { { 16660, 19663, }, { 9130, 31253, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 41,
    Value = 
new System.UInt16[,] { { 21616, 35533, }, { 60451, 64385, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.UInt16[,] { { 3940, 30209, }, { 54984, 28344, }, },
    NullableValue = 
new System.UInt16[,] { { 41405, 11144, }, { 36741, 17177, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt16[,] { { 47060, 56154, }, { 57083, 25660, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.UInt16[,] { { 14700, 36162, }, { 25758, 43260, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 51,
    Value = 
new System.UInt16[,] { { 50081, 34426, }, { 52257, 11929, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.UInt16[,] { { 32112, 10167, }, { 21089, 4869, }, },
    NullableValue = 
new System.UInt16[,] { { 54528, 51467, }, { 62448, 18201, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 59,
    Value = 
new System.UInt16[,] { { 57226, 7373, }, { 50710, 12378, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt16[,] { { 62194, 1107, }, { 42214, 43643, }, },
    NullableValue = 
new System.UInt16[,] { { 16510, 50144, }, { 44753, 63310, }, },
},
    NullableValue = 
new System.UInt16[,] { { 52435, 47984, }, { 62835, 61875, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 65,
    Value = 
new System.UInt16[,] { { 11655, 56149, }, { 3199, 6809, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 52,
    Value = 
new System.UInt16[,] { { 10622, 8989, }, { 7475, 41082, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 73,
    Value = 
new System.UInt16[,] { { 675, 35098, }, { 40848, 629, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 53,
    Value = 
new System.UInt16[,] { { 32731, 33130, }, { 40585, 59531, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 18569, 7888, }, { 49554, 54858, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 77,
    Value = 
new System.UInt16[,] { { 54447, 31740, }, { 10588, 4153, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.UInt16[,] { { 10849, 56058, }, { 10751, 458, }, },
    NullableValue = 
new System.UInt16[,] { { 53949, 42946, }, { 42891, 3056, }, },
},
    NullableValue = 
new System.UInt16[,] { { 48376, 35157, }, { 45302, 41389, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 83,
    Value = 
new System.UInt16[,] { { 16953, 25571, }, { 17181, 34887, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.UInt16[,] { { 12289, 55167, }, { 24400, 19944, }, },
    NullableValue = 
new System.UInt16[,] { { 44962, 36934, }, { 55673, 35317, }, },
},
    NullableValue = 
new System.UInt16[,] { { 64646, 23061, }, { 50325, 10808, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 91,
    Value = 
new System.UInt16[,] { { 13198, 7214, }, { 43710, 39900, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.UInt16[,] { { 18646, 39494, }, { 9999, 7178, }, },
    NullableValue = 
new System.UInt16[,] { { 15788, 63838, }, { 60794, 25410, }, },
},
    NullableValue = 
new System.UInt16[,] { { 9334, 32246, }, { 33597, 25596, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 100,
    Value = 
new System.UInt16[,] { { 2478, 14878, }, { 9985, 6559, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.UInt16[,] { { 2162, 59931, }, { 30200, 33065, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 17931, 55758, }, { 35887, 43327, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 107,
    Value = 
new System.UInt16[,] { { 46068, 24368, }, { 7349, 21438, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 74,
    Value = 
new System.UInt16[,] { { 4659, 14581, }, { 47532, 65458, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 112,
    Value = 
new System.UInt16[,] { { 6704, 60836, }, { 50786, 17678, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 79,
    Value = 
new System.UInt16[,] { { 17191, 21377, }, { 56253, 64102, }, },
    NullableValue = 
new System.UInt16[,] { { 51495, 1516, }, { 45760, 34002, }, },
},
    NullableValue = 
new System.UInt16[,] { { 55247, 7816, }, { 22696, 50362, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 119,
    Value = 
new System.UInt16[,] { { 29533, 46659, }, { 21350, 37760, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 84,
    Value = 
new System.UInt16[,] { { 17550, 13158, }, { 37438, 14370, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 122,
    Value = 
new System.UInt16[,] { { 59238, 22515, }, { 14662, 18282, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.UInt16[,] { { 36579, 43628, }, { 38062, 61167, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.UInt16[,] { { 35683, 16515, }, { 29431, 1669, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 92,
    Value = 
new System.UInt16[,] { { 9965, 31964, }, { 9934, 61964, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 52409, 10180, }, { 51221, 59007, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 133,
    Value = 
new System.UInt16[,] { { 38097, 15674, }, { 50044, 27661, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.UInt16[,] { { 1477, 32718, }, { 41526, 39825, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 136,
    Value = 
new System.UInt16[,] { { 8355, 31365, }, { 24592, 23769, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 99,
    Value = 
new System.UInt16[,] { { 52906, 54452, }, { 28234, 23090, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 32143, 63152, }, { 30307, 5200, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 141,
    Value = 
new System.UInt16[,] { { 56051, 44103, }, { 28562, 58886, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.UInt16[,] { { 33445, 48657, }, { 26335, 55742, }, },
    NullableValue = 
new System.UInt16[,] { { 34206, 28596, }, { 47657, 25182, }, },
},
    NullableValue = 
new System.UInt16[,] { { 51927, 7616, }, { 65312, 54623, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 148,
    Value = 
new System.UInt16[,] { { 49335, 21740, }, { 38216, 48496, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.UInt16[,] { { 39453, 24770, }, { 62619, 48798, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 26826, 43800, }, { 9463, 53841, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 154,
    Value = 
new System.UInt16[,] { { 1668, 30695, }, { 62228, 664, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.UInt16[,] { { 32654, 51931, }, { 24902, 5501, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 21076, 22685, }, { 15831, 38883, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 157,
    Value = 
new System.UInt16[,] { { 25587, 63397, }, { 6172, 41957, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 116,
    Value = 
new System.UInt16[,] { { 14334, 19976, }, { 4115, 36847, }, },
    NullableValue = 
new System.UInt16[,] { { 48443, 32224, }, { 4046, 46826, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 165,
    Value = 
new System.UInt16[,] { { 32394, 25704, }, { 52431, 36922, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.UInt16[,] { { 43341, 11406, }, { 4994, 48543, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 168,
    Value = 
new System.UInt16[,] { { 50106, 18302, }, { 6408, 3703, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.UInt16[,] { { 22174, 56167, }, { 19008, 51148, }, },
    NullableValue = 
new System.UInt16[,] { { 55837, 44893, }, { 702, 27905, }, },
},
    NullableValue = 
new System.UInt16[,] { { 11486, 26930, }, { 6576, 63478, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 173,
    Value = 
new System.UInt16[,] { { 58618, 8929, }, { 41456, 56612, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 132,
    Value = 
new System.UInt16[,] { { 59585, 20579, }, { 54018, 15626, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 11214, 38006, }, { 3032, 58305, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 176,
    Value = 
new System.UInt16[,] { { 44322, 13243, }, { 12591, 36739, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.UInt16[,] { { 62016, 46087, }, { 39969, 31926, }, },
    NullableValue = 
new System.UInt16[,] { { 9254, 12440, }, { 44410, 64859, }, },
},
    NullableValue = 
new System.UInt16[,] { { 57253, 57801, }, { 6917, 65137, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 179,
    Value = 
new System.UInt16[,] { { 30265, 51959, }, { 2120, 21619, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.UInt16[,] { { 54380, 34028, }, { 44591, 35076, }, },
    NullableValue = 
new System.UInt16[,] { { 63232, 51779, }, { 1303, 22119, }, },
},
    NullableValue = 
new System.UInt16[,] { { 45100, 52531, }, { 20940, 29519, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 181,
    Value = 
new System.UInt16[,] { { 23407, 58184, }, { 13134, 48170, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.UInt16[,] { { 65137, 49469, }, { 61201, 13311, }, },
    NullableValue = 
new System.UInt16[,] { { 26999, 32991, }, { 20231, 39523, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 189,
    Value = 
new System.UInt16[,] { { 18060, 14742, }, { 54318, 21681, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 151,
    Value = 
new System.UInt16[,] { { 39974, 54887, }, { 20289, 16795, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 193,
    Value = 
new System.UInt16[,] { { 1007, 1896, }, { 8731, 45244, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.UInt16[,] { { 10857, 45122, }, { 64706, 8621, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 7606, 14204, }, { 44382, 26577, }, },
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

