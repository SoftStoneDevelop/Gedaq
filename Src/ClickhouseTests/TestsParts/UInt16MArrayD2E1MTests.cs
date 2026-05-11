

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
    Id = 4,
    Value = 
new System.UInt16[,] { { 59023, 59827, }, { 61417, 60105, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 2,
    Value = 
new System.UInt16[,] { { 65174, 7132, }, { 52485, 58918, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 8,
    Value = 
new System.UInt16[,] { { 40589, 20771, }, { 23372, 38327, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 6,
    Value = 
new System.UInt16[,] { { 39610, 6975, }, { 33584, 22628, }, },
    NullableValue = 
new System.UInt16[,] { { 23884, 50871, }, { 804, 34962, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 16,
    Value = 
new System.UInt16[,] { { 57520, 33661, }, { 29073, 39358, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.UInt16[,] { { 28825, 19051, }, { 11407, 61129, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 14468, 20713, }, { 42611, 28465, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 22,
    Value = 
new System.UInt16[,] { { 64934, 26735, }, { 43125, 55660, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 15,
    Value = 
new System.UInt16[,] { { 20545, 46770, }, { 55009, 55582, }, },
    NullableValue = 
new System.UInt16[,] { { 28043, 51255, }, { 20187, 60147, }, },
},
    NullableValue = 
new System.UInt16[,] { { 2381, 42862, }, { 39478, 26302, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 29,
    Value = 
new System.UInt16[,] { { 34127, 63902, }, { 22684, 51720, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.UInt16[,] { { 28271, 37703, }, { 53599, 42370, }, },
    NullableValue = 
new System.UInt16[,] { { 62784, 46046, }, { 47186, 62485, }, },
},
    NullableValue = 
new System.UInt16[,] { { 48472, 48424, }, { 19624, 5209, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 31,
    Value = 
new System.UInt16[,] { { 35827, 43208, }, { 60305, 25400, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 23,
    Value = 
new System.UInt16[,] { { 49243, 23843, }, { 56992, 59537, }, },
    NullableValue = 
new System.UInt16[,] { { 38762, 15961, }, { 59742, 31486, }, },
},
    NullableValue = 
new System.UInt16[,] { { 45894, 59733, }, { 49485, 64656, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 40,
    Value = 
new System.UInt16[,] { { 45482, 14742, }, { 64605, 7193, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.UInt16[,] { { 31098, 11234, }, { 22049, 19550, }, },
    NullableValue = 
new System.UInt16[,] { { 10262, 53913, }, { 43685, 30834, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 48,
    Value = 
new System.UInt16[,] { { 7278, 748, }, { 61189, 63828, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 30,
    Value = 
new System.UInt16[,] { { 31342, 25336, }, { 47561, 24914, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 50630, 2157, }, { 39749, 10825, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 51,
    Value = 
new System.UInt16[,] { { 33895, 8162, }, { 38763, 54784, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 38,
    Value = 
new System.UInt16[,] { { 19481, 36080, }, { 46801, 20194, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 53,
    Value = 
new System.UInt16[,] { { 36681, 6338, }, { 17003, 19439, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.UInt16[,] { { 47806, 46278, }, { 53816, 31048, }, },
    NullableValue = 
new System.UInt16[,] { { 1528, 30715, }, { 53824, 15810, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 62,
    Value = 
new System.UInt16[,] { { 53541, 2174, }, { 4142, 43664, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.UInt16[,] { { 4292, 48563, }, { 48489, 3616, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 5480, 46946, }, { 52087, 61501, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 66,
    Value = 
new System.UInt16[,] { { 29355, 39395, }, { 4654, 18860, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 44,
    Value = 
new System.UInt16[,] { { 18536, 11016, }, { 2159, 45987, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 69,
    Value = 
new System.UInt16[,] { { 4724, 29968, }, { 8436, 19043, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt16[,] { { 33848, 15576, }, { 15960, 47803, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 58810, 8490, }, { 27293, 10811, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 74,
    Value = 
new System.UInt16[,] { { 51607, 51710, }, { 58312, 30370, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 46,
    Value = 
new System.UInt16[,] { { 27539, 8534, }, { 51490, 50152, }, },
    NullableValue = 
new System.UInt16[,] { { 48692, 60368, }, { 53273, 30747, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 76,
    Value = 
new System.UInt16[,] { { 4747, 1550, }, { 65476, 61355, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt16[,] { { 61399, 3769, }, { 41295, 55311, }, },
    NullableValue = 
new System.UInt16[,] { { 16310, 454, }, { 29608, 5318, }, },
},
    NullableValue = 
new System.UInt16[,] { { 16041, 11386, }, { 1698, 10163, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 82,
    Value = 
new System.UInt16[,] { { 41081, 1606, }, { 37306, 56403, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.UInt16[,] { { 41232, 20836, }, { 47707, 44233, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 86,
    Value = 
new System.UInt16[,] { { 64823, 449, }, { 49051, 41343, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.UInt16[,] { { 53047, 9052, }, { 4418, 21003, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 27829, 44431, }, { 64927, 25094, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 91,
    Value = 
new System.UInt16[,] { { 48956, 29413, }, { 26419, 3294, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.UInt16[,] { { 54539, 54428, }, { 3115, 46587, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 53417, 11807, }, { 45971, 32003, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 96,
    Value = 
new System.UInt16[,] { { 16775, 64948, }, { 26564, 26729, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 73,
    Value = 
new System.UInt16[,] { { 37855, 62893, }, { 25361, 28926, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 98,
    Value = 
new System.UInt16[,] { { 31742, 19329, }, { 9007, 40494, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 78,
    Value = 
new System.UInt16[,] { { 59367, 2136, }, { 55001, 24656, }, },
    NullableValue = 
new System.UInt16[,] { { 53298, 40198, }, { 11156, 54859, }, },
},
    NullableValue = 
new System.UInt16[,] { { 42083, 42856, }, { 59559, 26369, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 101,
    Value = 
new System.UInt16[,] { { 9731, 34056, }, { 39080, 15979, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.UInt16[,] { { 161, 44702, }, { 2597, 1858, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 109,
    Value = 
new System.UInt16[,] { { 8053, 6472, }, { 4044, 64645, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.UInt16[,] { { 46411, 25836, }, { 41715, 29113, }, },
    NullableValue = 
new System.UInt16[,] { { 16459, 2768, }, { 4255, 61181, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 110,
    Value = 
new System.UInt16[,] { { 10917, 46638, }, { 54901, 64225, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 87,
    Value = 
new System.UInt16[,] { { 53754, 28541, }, { 7598, 59611, }, },
    NullableValue = 
new System.UInt16[,] { { 9018, 46374, }, { 20144, 44443, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 115,
    Value = 
new System.UInt16[,] { { 25289, 61199, }, { 47730, 3155, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 96,
    Value = 
new System.UInt16[,] { { 62007, 6927, }, { 50675, 46847, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 124,
    Value = 
new System.UInt16[,] { { 13351, 10702, }, { 6966, 46502, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.UInt16[,] { { 51841, 52460, }, { 31066, 25998, }, },
    NullableValue = 
new System.UInt16[,] { { 29992, 17206, }, { 42195, 54833, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 126,
    Value = 
new System.UInt16[,] { { 7541, 17119, }, { 47669, 9079, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 104,
    Value = 
new System.UInt16[,] { { 47592, 3241, }, { 59187, 22048, }, },
    NullableValue = 
new System.UInt16[,] { { 42382, 57409, }, { 20056, 35721, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 132,
    Value = 
new System.UInt16[,] { { 4937, 6486, }, { 44866, 62678, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.UInt16[,] { { 42348, 59835, }, { 53574, 61148, }, },
    NullableValue = 
new System.UInt16[,] { { 542, 45885, }, { 7402, 28731, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 135,
    Value = 
new System.UInt16[,] { { 65308, 49169, }, { 57135, 33523, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.UInt16[,] { { 40880, 28679, }, { 54114, 53624, }, },
    NullableValue = 
new System.UInt16[,] { { 8486, 28043, }, { 48323, 55122, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 143,
    Value = 
new System.UInt16[,] { { 5771, 4036, }, { 36657, 23089, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 121,
    Value = 
new System.UInt16[,] { { 37884, 23413, }, { 33083, 17566, }, },
    NullableValue = 
new System.UInt16[,] { { 12907, 6314, }, { 35398, 9560, }, },
},
    NullableValue = 
new System.UInt16[,] { { 50502, 14728, }, { 33502, 59378, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 151,
    Value = 
new System.UInt16[,] { { 52560, 45713, }, { 42134, 56108, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.UInt16[,] { { 15866, 22338, }, { 17969, 65428, }, },
    NullableValue = 
new System.UInt16[,] { { 24054, 62434, }, { 38079, 46947, }, },
},
    NullableValue = 
new System.UInt16[,] { { 9322, 7999, }, { 35172, 36822, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 157,
    Value = 
new System.UInt16[,] { { 44171, 64807, }, { 6637, 6816, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 133,
    Value = 
new System.UInt16[,] { { 61596, 58261, }, { 55776, 47066, }, },
    NullableValue = 
new System.UInt16[,] { { 5246, 58209, }, { 43061, 23043, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 164,
    Value = 
new System.UInt16[,] { { 61948, 59943, }, { 50375, 26817, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.UInt16[,] { { 31979, 31074, }, { 1585, 7088, }, },
    NullableValue = 
new System.UInt16[,] { { 12713, 62403, }, { 52157, 21042, }, },
},
    NullableValue = 
new System.UInt16[,] { { 55638, 64341, }, { 41972, 58233, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 171,
    Value = 
new System.UInt16[,] { { 50570, 3879, }, { 17555, 10558, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.UInt16[,] { { 51838, 55690, }, { 38592, 12496, }, },
    NullableValue = 
new System.UInt16[,] { { 14672, 59100, }, { 33569, 44713, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 178,
    Value = 
new System.UInt16[,] { { 48619, 62115, }, { 37143, 11374, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 147,
    Value = 
new System.UInt16[,] { { 31811, 19754, }, { 18074, 53035, }, },
    NullableValue = 
new System.UInt16[,] { { 24900, 63404, }, { 29669, 23635, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 179,
    Value = 
new System.UInt16[,] { { 9346, 4117, }, { 25302, 25654, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 152,
    Value = 
new System.UInt16[,] { { 45154, 15747, }, { 13374, 47738, }, },
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

