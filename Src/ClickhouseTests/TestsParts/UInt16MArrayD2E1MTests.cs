

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
new System.UInt16[,] { { 10771, 32232, }, { 5676, 55235, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.UInt16[,] { { 52100, 32920, }, { 4766, 39303, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 60074, 15548, }, { 43215, 42083, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 12,
    Value = 
new System.UInt16[,] { { 24329, 26425, }, { 352, 17240, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.UInt16[,] { { 5719, 16446, }, { 8632, 14666, }, },
    NullableValue = 
new System.UInt16[,] { { 5464, 60949, }, { 10023, 20477, }, },
},
    NullableValue = 
new System.UInt16[,] { { 47959, 6955, }, { 8328, 25375, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 17,
    Value = 
new System.UInt16[,] { { 30231, 11092, }, { 9726, 39458, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 22,
    Value = 
new System.UInt16[,] { { 59063, 43421, }, { 37474, 49391, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 3163, 63985, }, { 14453, 20069, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 20,
    Value = 
new System.UInt16[,] { { 8311, 43718, }, { 28291, 22931, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.UInt16[,] { { 60908, 9504, }, { 60505, 62717, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 34371, 54799, }, { 12184, 44223, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 25,
    Value = 
new System.UInt16[,] { { 31674, 19958, }, { 20052, 9716, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.UInt16[,] { { 38931, 39232, }, { 15372, 25612, }, },
    NullableValue = 
new System.UInt16[,] { { 42483, 33000, }, { 5907, 23012, }, },
},
    NullableValue = 
new System.UInt16[,] { { 33857, 724, }, { 43555, 26402, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 29,
    Value = 
new System.UInt16[,] { { 39327, 51700, }, { 3522, 62989, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 34,
    Value = 
new System.UInt16[,] { { 43970, 50930, }, { 2600, 9628, }, },
    NullableValue = 
new System.UInt16[,] { { 35867, 6703, }, { 42018, 342, }, },
},
    NullableValue = 
new System.UInt16[,] { { 45676, 47540, }, { 32710, 16209, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 30,
    Value = 
new System.UInt16[,] { { 19237, 29388, }, { 11647, 4249, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 40,
    Value = 
new System.UInt16[,] { { 15226, 2684, }, { 30428, 53281, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 31,
    Value = 
new System.UInt16[,] { { 49812, 52870, }, { 35747, 8429, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 43,
    Value = 
new System.UInt16[,] { { 59299, 10366, }, { 41413, 31111, }, },
    NullableValue = 
new System.UInt16[,] { { 40515, 53835, }, { 12252, 40963, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 32,
    Value = 
new System.UInt16[,] { { 18717, 20352, }, { 2350, 19273, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 52,
    Value = 
new System.UInt16[,] { { 46202, 40264, }, { 39723, 47317, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 23202, 11069, }, { 52458, 43499, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 41,
    Value = 
new System.UInt16[,] { { 25550, 62963, }, { 37197, 2568, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 53,
    Value = 
new System.UInt16[,] { { 34828, 54395, }, { 32210, 45465, }, },
    NullableValue = 
new System.UInt16[,] { { 36694, 17464, }, { 23171, 54331, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 47,
    Value = 
new System.UInt16[,] { { 16149, 48740, }, { 49628, 23568, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 54,
    Value = 
new System.UInt16[,] { { 532, 16945, }, { 2409, 22718, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 52,
    Value = 
new System.UInt16[,] { { 38172, 12147, }, { 371, 3253, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 60,
    Value = 
new System.UInt16[,] { { 47972, 52792, }, { 12532, 36882, }, },
    NullableValue = 
new System.UInt16[,] { { 48226, 54111, }, { 36661, 15176, }, },
},
    NullableValue = 
new System.UInt16[,] { { 28171, 14058, }, { 51054, 64146, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 53,
    Value = 
new System.UInt16[,] { { 15563, 8940, }, { 40027, 50468, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.UInt16[,] { { 21867, 25239, }, { 30216, 13880, }, },
    NullableValue = 
new System.UInt16[,] { { 17210, 32366, }, { 14037, 42059, }, },
},
    NullableValue = 
new System.UInt16[,] { { 63089, 1665, }, { 46689, 608, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 58,
    Value = 
new System.UInt16[,] { { 28574, 26986, }, { 48710, 22360, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt16[,] { { 58833, 14607, }, { 24927, 51325, }, },
    NullableValue = 
new System.UInt16[,] { { 52872, 2301, }, { 40636, 23220, }, },
},
    NullableValue = 
new System.UInt16[,] { { 63309, 22958, }, { 34547, 21638, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 61,
    Value = 
new System.UInt16[,] { { 25185, 27442, }, { 718, 25074, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.UInt16[,] { { 61585, 25286, }, { 13638, 27060, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 9113, 5125, }, { 18897, 12607, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 70,
    Value = 
new System.UInt16[,] { { 12748, 5299, }, { 59026, 23824, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 91,
    Value = 
new System.UInt16[,] { { 9700, 50644, }, { 37515, 43041, }, },
    NullableValue = 
new System.UInt16[,] { { 16699, 14632, }, { 51685, 47588, }, },
},
    NullableValue = 
new System.UInt16[,] { { 14915, 53019, }, { 36892, 55574, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 79,
    Value = 
new System.UInt16[,] { { 6766, 3036, }, { 7595, 30760, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.UInt16[,] { { 27022, 41156, }, { 13521, 55907, }, },
    NullableValue = 
new System.UInt16[,] { { 19010, 56642, }, { 33388, 38969, }, },
},
    NullableValue = 
new System.UInt16[,] { { 52981, 13979, }, { 55197, 29503, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 81,
    Value = 
new System.UInt16[,] { { 24066, 61824, }, { 55790, 18979, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 101,
    Value = 
new System.UInt16[,] { { 33271, 42610, }, { 16453, 33776, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 50357, 23615, }, { 33977, 11003, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 82,
    Value = 
new System.UInt16[,] { { 44670, 7263, }, { 57538, 1835, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 102,
    Value = 
new System.UInt16[,] { { 7055, 42540, }, { 56942, 36346, }, },
    NullableValue = 
new System.UInt16[,] { { 10338, 42476, }, { 31575, 38173, }, },
},
    NullableValue = 
new System.UInt16[,] { { 50246, 58988, }, { 8509, 44491, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 85,
    Value = 
new System.UInt16[,] { { 37897, 40576, }, { 1925, 41632, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.UInt16[,] { { 31991, 9666, }, { 25252, 55010, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 34240, 25549, }, { 24179, 21702, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 94,
    Value = 
new System.UInt16[,] { { 37861, 19112, }, { 7714, 33586, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 117,
    Value = 
new System.UInt16[,] { { 38823, 272, }, { 11600, 7463, }, },
    NullableValue = 
new System.UInt16[,] { { 22332, 55295, }, { 49011, 21452, }, },
},
    NullableValue = 
new System.UInt16[,] { { 29797, 20642, }, { 51360, 14240, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 98,
    Value = 
new System.UInt16[,] { { 13614, 3173, }, { 25085, 54020, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.UInt16[,] { { 46511, 11836, }, { 53087, 62421, }, },
    NullableValue = 
new System.UInt16[,] { { 20241, 40487, }, { 38198, 54732, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 100,
    Value = 
new System.UInt16[,] { { 29630, 51631, }, { 40717, 5268, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 131,
    Value = 
new System.UInt16[,] { { 50246, 3621, }, { 44111, 7609, }, },
    NullableValue = 
new System.UInt16[,] { { 41916, 34012, }, { 34015, 40756, }, },
},
    NullableValue = 
new System.UInt16[,] { { 33244, 26779, }, { 61892, 11624, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 108,
    Value = 
new System.UInt16[,] { { 13833, 31911, }, { 15190, 18401, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 137,
    Value = 
new System.UInt16[,] { { 9860, 24102, }, { 31539, 2508, }, },
    NullableValue = 
new System.UInt16[,] { { 26657, 48308, }, { 20863, 35951, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 110,
    Value = 
new System.UInt16[,] { { 38087, 43195, }, { 29127, 28042, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.UInt16[,] { { 41640, 32981, }, { 4145, 7629, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 31955, 49571, }, { 28822, 26732, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 114,
    Value = 
new System.UInt16[,] { { 34484, 59962, }, { 58775, 33889, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 150,
    Value = 
new System.UInt16[,] { { 28949, 48294, }, { 39986, 18179, }, },
    NullableValue = 
new System.UInt16[,] { { 15126, 28547, }, { 31608, 62634, }, },
},
    NullableValue = 
new System.UInt16[,] { { 29250, 12150, }, { 49002, 41977, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 117,
    Value = 
new System.UInt16[,] { { 40652, 38903, }, { 6361, 49509, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 151,
    Value = 
new System.UInt16[,] { { 60266, 64023, }, { 37397, 5978, }, },
    NullableValue = 
new System.UInt16[,] { { 5249, 40683, }, { 36494, 61568, }, },
},
    NullableValue = 
new System.UInt16[,] { { 7051, 25051, }, { 6936, 5756, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 118,
    Value = 
new System.UInt16[,] { { 43425, 52946, }, { 213, 21814, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 159,
    Value = 
new System.UInt16[,] { { 10178, 27481, }, { 64915, 55508, }, },
    NullableValue = 
new System.UInt16[,] { { 4504, 15376, }, { 9060, 32836, }, },
},
    NullableValue = 
new System.UInt16[,] { { 2489, 38934, }, { 9072, 39030, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 119,
    Value = 
new System.UInt16[,] { { 48184, 28009, }, { 43357, 40508, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 163,
    Value = 
new System.UInt16[,] { { 57901, 29954, }, { 7884, 9327, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 123,
    Value = 
new System.UInt16[,] { { 26117, 3123, }, { 65108, 56883, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 172,
    Value = 
new System.UInt16[,] { { 58572, 33486, }, { 64123, 14183, }, },
    NullableValue = 
new System.UInt16[,] { { 51122, 40, }, { 27182, 50189, }, },
},
    NullableValue = 
new System.UInt16[,] { { 55328, 49953, }, { 47848, 18085, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 130,
    Value = 
new System.UInt16[,] { { 41547, 44675, }, { 13850, 13461, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 181,
    Value = 
new System.UInt16[,] { { 42271, 13002, }, { 6928, 73, }, },
    NullableValue = 
new System.UInt16[,] { { 58624, 29641, }, { 8644, 30557, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 138,
    Value = 
new System.UInt16[,] { { 6100, 44588, }, { 19124, 43101, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 184,
    Value = 
new System.UInt16[,] { { 32750, 49286, }, { 28305, 61366, }, },
    NullableValue = 
new System.UInt16[,] { { 48250, 32680, }, { 31646, 31043, }, },
},
    NullableValue = 
new System.UInt16[,] { { 11687, 14310, }, { 15747, 57762, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 142,
    Value = 
new System.UInt16[,] { { 13232, 17608, }, { 10515, 4381, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 185,
    Value = 
new System.UInt16[,] { { 37199, 13881, }, { 4028, 35072, }, },
    NullableValue = 
new System.UInt16[,] { { 44661, 17312, }, { 24567, 12796, }, },
},
    NullableValue = 
new System.UInt16[,] { { 62154, 28718, }, { 16676, 52348, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 147,
    Value = 
new System.UInt16[,] { { 60188, 27167, }, { 57841, 14264, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 187,
    Value = 
new System.UInt16[,] { { 52796, 43175, }, { 25872, 15527, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt16[,] { { 31951, 37770, }, { 18368, 46106, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 188,
    Value = 
new System.UInt16[,] { { 10881, 26249, }, { 18775, 37804, }, },
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

