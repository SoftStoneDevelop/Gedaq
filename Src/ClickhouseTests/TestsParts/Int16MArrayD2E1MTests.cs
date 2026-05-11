

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
    internal partial interface IInt16MArrayMArrayD2
    {
    }
    
    internal partial class Int16MArrayMArrayD2 : IInt16MArrayMArrayD2
    {


#region TestData

        private readonly Int16MArrayD2E1M[] _testData = new Int16MArrayD2E1M[]
        {
            new Int16MArrayD2E1M
{
    Id = 2,
    Value = 
new System.Int16[,] { { 23765, 14839, }, { 3763, 8166, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Int16[,] { { 23628, 6749, }, { 26989, 3846, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 8045, 16165, }, { 10909, 5421, }, },
},
            new Int16MArrayD2E1M
{
    Id = 7,
    Value = 
new System.Int16[,] { { 3906, 24654, }, { 5444, 20163, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Int16[,] { { 8368, 24892, }, { 13792, 5740, }, },
    NullableValue = 
new System.Int16[,] { { 16721, 5873, }, { 26064, 13469, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 15,
    Value = 
new System.Int16[,] { { 30011, 31419, }, { 26265, 28715, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Int16[,] { { 17426, 30905, }, { 19907, 10225, }, },
    NullableValue = 
new System.Int16[,] { { 17252, 13934, }, { 19347, 8731, }, },
},
    NullableValue = 
new System.Int16[,] { { 16083, 12215, }, { 4940, 16497, }, },
},
            new Int16MArrayD2E1M
{
    Id = 23,
    Value = 
new System.Int16[,] { { 22984, 29825, }, { 28028, 781, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Int16[,] { { 29848, 23481, }, { 10901, 25888, }, },
    NullableValue = 
new System.Int16[,] { { 4485, 13473, }, { 716, 27017, }, },
},
    NullableValue = 
new System.Int16[,] { { 741, 13517, }, { 30702, 12479, }, },
},
            new Int16MArrayD2E1M
{
    Id = 32,
    Value = 
new System.Int16[,] { { 25016, 4917, }, { 30438, 634, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 37,
    Value = 
new System.Int16[,] { { 26742, 26604, }, { 24321, 15905, }, },
    NullableValue = 
new System.Int16[,] { { 30439, 22474, }, { 19536, 7476, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 37,
    Value = 
new System.Int16[,] { { 329, 21398, }, { 20536, 12815, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Int16[,] { { 44, 6847, }, { 13539, 2262, }, },
    NullableValue = 
new System.Int16[,] { { 13138, 26121, }, { 2018, 17674, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 40,
    Value = 
new System.Int16[,] { { 29583, 10390, }, { 20520, 22302, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Int16[,] { { 2655, 13658, }, { 22119, 22235, }, },
    NullableValue = 
new System.Int16[,] { { 2996, 11511, }, { 31342, 31039, }, },
},
    NullableValue = 
new System.Int16[,] { { 20496, 27259, }, { 9086, 9985, }, },
},
            new Int16MArrayD2E1M
{
    Id = 41,
    Value = 
new System.Int16[,] { { 13407, 9905, }, { 28336, 12359, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.Int16[,] { { 9656, 2958, }, { 12066, 11425, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 45,
    Value = 
new System.Int16[,] { { 3642, 6920, }, { 12579, 19116, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Int16[,] { { 31288, 1473, }, { 13080, 4464, }, },
    NullableValue = 
new System.Int16[,] { { 18416, 30156, }, { 29533, 14377, }, },
},
    NullableValue = 
new System.Int16[,] { { 28277, 28138, }, { 26599, 22547, }, },
},
            new Int16MArrayD2E1M
{
    Id = 47,
    Value = 
new System.Int16[,] { { 1249, 21502, }, { 18233, 19888, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Int16[,] { { 9817, 27888, }, { 27052, 21858, }, },
    NullableValue = 
new System.Int16[,] { { 19696, 30985, }, { 16705, 6743, }, },
},
    NullableValue = 
new System.Int16[,] { { 12117, 28133, }, { 13396, 5978, }, },
},
            new Int16MArrayD2E1M
{
    Id = 49,
    Value = 
new System.Int16[,] { { 5369, 25490, }, { 27012, 13650, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Int16[,] { { 4692, 17740, }, { 12353, 26357, }, },
    NullableValue = 
new System.Int16[,] { { 23039, 24953, }, { 15364, 2360, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 56,
    Value = 
new System.Int16[,] { { 10353, 12914, }, { 17147, 26563, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Int16[,] { { 21392, 10761, }, { 4977, 30361, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 16582, 26287, }, { 10435, 17138, }, },
},
            new Int16MArrayD2E1M
{
    Id = 60,
    Value = 
new System.Int16[,] { { 2737, 17443, }, { 25196, 18237, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Int16[,] { { 17462, 10860, }, { 31552, 11413, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 66,
    Value = 
new System.Int16[,] { { 28193, 17084, }, { 13956, 26433, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Int16[,] { { 6352, 24490, }, { 15591, 24610, }, },
    NullableValue = 
new System.Int16[,] { { 15559, 29011, }, { 9264, 28479, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 74,
    Value = 
new System.Int16[,] { { 2305, 10094, }, { 26141, 31948, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Int16[,] { { 15366, 833, }, { 17928, 7218, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 31243, 25667, }, { 6231, 13691, }, },
},
            new Int16MArrayD2E1M
{
    Id = 75,
    Value = 
new System.Int16[,] { { 11582, 24836, }, { 16448, 14966, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Int16[,] { { 1589, 254, }, { 19511, 31838, }, },
    NullableValue = 
new System.Int16[,] { { 22538, 29890, }, { 14615, 16734, }, },
},
    NullableValue = 
new System.Int16[,] { { 11996, 3708, }, { 23133, 7266, }, },
},
            new Int16MArrayD2E1M
{
    Id = 76,
    Value = 
new System.Int16[,] { { 26676, 6233, }, { 16059, 9386, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Int16[,] { { 22369, 29232, }, { 21063, 23578, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 84,
    Value = 
new System.Int16[,] { { 5821, 26737, }, { 4113, 26985, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Int16[,] { { 2788, 14995, }, { 3408, 7393, }, },
    NullableValue = 
new System.Int16[,] { { 31468, 17327, }, { 24392, 27587, }, },
},
    NullableValue = 
new System.Int16[,] { { 13828, 12721, }, { 10718, 22012, }, },
},
            new Int16MArrayD2E1M
{
    Id = 93,
    Value = 
new System.Int16[,] { { 1391, 18896, }, { 22105, 17211, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Int16[,] { { 26649, 11469, }, { 25250, 22990, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 102,
    Value = 
new System.Int16[,] { { 12894, 10533, }, { 2526, 3064, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Int16[,] { { 1793, 24920, }, { 10929, 3154, }, },
    NullableValue = 
new System.Int16[,] { { 9099, 7179, }, { 11423, 22032, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 109,
    Value = 
new System.Int16[,] { { 5207, 8224, }, { 9174, 24683, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Int16[,] { { 3699, 14482, }, { 11241, 22031, }, },
    NullableValue = 
new System.Int16[,] { { 9540, 31208, }, { 32256, 5874, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 114,
    Value = 
new System.Int16[,] { { 16996, 791, }, { 22474, 19012, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.Int16[,] { { 4578, 21309, }, { 10807, 17797, }, },
    NullableValue = 
new System.Int16[,] { { 5407, 4678, }, { 31626, 32117, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 121,
    Value = 
new System.Int16[,] { { 21349, 15194, }, { 282, 15547, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Int16[,] { { 2099, 3464, }, { 24271, 20014, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 22627, 4859, }, { 24378, 23974, }, },
},
            new Int16MArrayD2E1M
{
    Id = 122,
    Value = 
new System.Int16[,] { { 21750, 5623, }, { 18201, 8101, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Int16[,] { { 14195, 22853, }, { 25331, 2062, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 126,
    Value = 
new System.Int16[,] { { 8747, 30144, }, { 16812, 32152, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.Int16[,] { { 14355, 7850, }, { 24976, 11893, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 14881, 23720, }, { 26426, 490, }, },
},
            new Int16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.Int16[,] { { 1188, 24869, }, { 19182, 4093, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Int16[,] { { 32393, 3752, }, { 16911, 12617, }, },
    NullableValue = 
new System.Int16[,] { { 24983, 3994, }, { 14851, 2499, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 139,
    Value = 
new System.Int16[,] { { 25416, 23529, }, { 31229, 15190, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Int16[,] { { 1975, 6373, }, { 1197, 18979, }, },
    NullableValue = 
new System.Int16[,] { { 11594, 10548, }, { 15622, 16157, }, },
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 141,
    Value = 
new System.Int16[,] { { 25385, 23916, }, { 20748, 31741, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Int16[,] { { 31388, 4463, }, { 3331, 8091, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 3261, 20231, }, { 819, 31497, }, },
},
            new Int16MArrayD2E1M
{
    Id = 148,
    Value = 
new System.Int16[,] { { 15185, 9944, }, { 24350, 4700, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.Int16[,] { { 19452, 10880, }, { 5732, 1910, }, },
    NullableValue = 
new System.Int16[,] { { 23640, 5865, }, { 12861, 12073, }, },
},
    NullableValue = 
new System.Int16[,] { { 6387, 27802, }, { 23009, 1200, }, },
},
            new Int16MArrayD2E1M
{
    Id = 156,
    Value = 
new System.Int16[,] { { 1094, 28648, }, { 7336, 15641, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Int16[,] { { 17139, 25912, }, { 17307, 29459, }, },
    NullableValue = 
new System.Int16[,] { { 5922, 9377, }, { 21395, 22036, }, },
},
    NullableValue = 
new System.Int16[,] { { 8079, 22722, }, { 25150, 2048, }, },
},
            new Int16MArrayD2E1M
{
    Id = 159,
    Value = 
new System.Int16[,] { { 28879, 22429, }, { 13313, 22381, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Int16[,] { { 14332, 11393, }, { 23458, 6729, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 24463, 5557, }, { 31425, 29006, }, },
},
            new Int16MArrayD2E1M
{
    Id = 160,
    Value = 
new System.Int16[,] { { 4073, 1670, }, { 24809, 18130, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Int16[,] { { 24904, 13571, }, { 26303, 14949, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 165,
    Value = 
new System.Int16[,] { { 24253, 1544, }, { 20832, 17758, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 172,
    Value = 
new System.Int16[,] { { 11078, 24778, }, { 6029, 25335, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 32114, 19827, }, { 10227, 696, }, },
},
            new Int16MArrayD2E1M
{
    Id = 173,
    Value = 
new System.Int16[,] { { 253, 32752, }, { 27705, 24920, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 180,
    Value = 
new System.Int16[,] { { 18510, 10372, }, { 8960, 8655, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new Int16MArrayD2E1M
{
    Id = 178,
    Value = 
new System.Int16[,] { { 6407, 14494, }, { 18534, 17358, }, },
    ModelInner = new Int16MArrayD2E1MI
{
    Id = 182,
    Value = 
new System.Int16[,] { { 12415, 15771, }, { 18799, 8451, }, },
    NullableValue = null,
},
    NullableValue = 
new System.Int16[,] { { 8092, 501, }, { 2176, 7966, }, },
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int16marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(Int16))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(Int16))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int16[,]), 
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
                    await ((IInt16MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IInt16MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.int16marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int16MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt16MArrayMArrayD2)),
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
                    var models = await ((IInt16MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt16MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int16MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

