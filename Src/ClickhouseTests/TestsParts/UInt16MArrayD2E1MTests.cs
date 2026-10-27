

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
    Id = 7,
    Value = 
new System.UInt16[,] { { 63224, 41355, }, { 20258, 34987, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 1,
    Value = 
new System.UInt16[,] { { 1916, 36420, }, { 59079, 366, }, },
    NullableValue = 
new System.UInt16[,] { { 18857, 32806, }, { 35226, 47062, }, },
},
    NullableValue = 
new System.UInt16[,] { { 56018, 32403, }, { 53988, 45447, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 15,
    Value = 
new System.UInt16[,] { { 16515, 27698, }, { 46609, 34367, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.UInt16[,] { { 15649, 25821, }, { 26915, 8444, }, },
    NullableValue = 
new System.UInt16[,] { { 58250, 50782, }, { 13729, 34221, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 22,
    Value = 
new System.UInt16[,] { { 65416, 42657, }, { 37550, 13369, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.UInt16[,] { { 5499, 47486, }, { 40304, 29371, }, },
    NullableValue = 
new System.UInt16[,] { { 5202, 56333, }, { 22777, 51569, }, },
},
    NullableValue = 
new System.UInt16[,] { { 11082, 12202, }, { 8687, 34165, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 28,
    Value = 
new System.UInt16[,] { { 3548, 36485, }, { 57892, 44492, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.UInt16[,] { { 25770, 56462, }, { 31843, 36218, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 39633, 58488, }, { 4111, 12444, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 37,
    Value = 
new System.UInt16[,] { { 47248, 2068, }, { 15394, 39345, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 21,
    Value = 
new System.UInt16[,] { { 156, 3284, }, { 3996, 20145, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 1167, 49464, }, { 57731, 973, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 43,
    Value = 
new System.UInt16[,] { { 22892, 50014, }, { 58209, 18386, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt16[,] { { 36009, 60568, }, { 19425, 935, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 49,
    Value = 
new System.UInt16[,] { { 62070, 30086, }, { 47629, 47026, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 28,
    Value = 
new System.UInt16[,] { { 18892, 23700, }, { 46340, 26742, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 61162, 17249, }, { 18678, 17778, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt16[,] { { 49618, 33172, }, { 6380, 62221, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 36,
    Value = 
new System.UInt16[,] { { 46247, 3302, }, { 20592, 59170, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 42395, 44773, }, { 37097, 17662, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 64,
    Value = 
new System.UInt16[,] { { 47302, 45851, }, { 26386, 28273, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 45,
    Value = 
new System.UInt16[,] { { 35269, 42541, }, { 24559, 7458, }, },
    NullableValue = 
new System.UInt16[,] { { 30226, 20990, }, { 48361, 39133, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 70,
    Value = 
new System.UInt16[,] { { 37630, 30504, }, { 8872, 27703, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 49,
    Value = 
new System.UInt16[,] { { 64515, 51365, }, { 46451, 16858, }, },
    NullableValue = 
new System.UInt16[,] { { 10019, 20929, }, { 13475, 20275, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 76,
    Value = 
new System.UInt16[,] { { 36762, 41540, }, { 17346, 54644, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 57,
    Value = 
new System.UInt16[,] { { 12453, 13945, }, { 48761, 36039, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 84,
    Value = 
new System.UInt16[,] { { 64488, 7803, }, { 238, 33751, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 63,
    Value = 
new System.UInt16[,] { { 8503, 16718, }, { 37788, 47031, }, },
    NullableValue = 
new System.UInt16[,] { { 12694, 55178, }, { 22492, 38891, }, },
},
    NullableValue = 
new System.UInt16[,] { { 59119, 12178, }, { 47013, 1067, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt16[,] { { 12893, 64472, }, { 13527, 33711, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 68,
    Value = 
new System.UInt16[,] { { 39549, 42485, }, { 22683, 32563, }, },
    NullableValue = 
new System.UInt16[,] { { 9303, 27792, }, { 11035, 31894, }, },
},
    NullableValue = 
new System.UInt16[,] { { 20747, 33069, }, { 34659, 28886, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 95,
    Value = 
new System.UInt16[,] { { 58946, 15282, }, { 25892, 44489, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 75,
    Value = 
new System.UInt16[,] { { 2216, 41141, }, { 58603, 12478, }, },
    NullableValue = 
new System.UInt16[,] { { 44409, 17500, }, { 44790, 14453, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt16[,] { { 11437, 39370, }, { 594, 27274, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 76,
    Value = 
new System.UInt16[,] { { 48563, 22904, }, { 7270, 53662, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 107,
    Value = 
new System.UInt16[,] { { 63351, 6288, }, { 53222, 32158, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 80,
    Value = 
new System.UInt16[,] { { 21730, 21319, }, { 23471, 15078, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 15437, 61777, }, { 24779, 12217, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 110,
    Value = 
new System.UInt16[,] { { 31789, 38663, }, { 39554, 2132, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 84,
    Value = 
new System.UInt16[,] { { 45260, 64996, }, { 20081, 49095, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 112,
    Value = 
new System.UInt16[,] { { 40780, 27894, }, { 35578, 34064, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 86,
    Value = 
new System.UInt16[,] { { 47472, 60553, }, { 37281, 56423, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 121,
    Value = 
new System.UInt16[,] { { 8632, 55293, }, { 12503, 18606, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 90,
    Value = 
new System.UInt16[,] { { 32325, 62573, }, { 2496, 38885, }, },
    NullableValue = 
new System.UInt16[,] { { 54065, 56370, }, { 4488, 57784, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 129,
    Value = 
new System.UInt16[,] { { 5654, 20711, }, { 47084, 8138, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 93,
    Value = 
new System.UInt16[,] { { 32579, 12899, }, { 2421, 49804, }, },
    NullableValue = 
new System.UInt16[,] { { 13701, 21622, }, { 16589, 47544, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 134,
    Value = 
new System.UInt16[,] { { 16777, 21244, }, { 60803, 15188, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 100,
    Value = 
new System.UInt16[,] { { 11787, 53591, }, { 50792, 9547, }, },
    NullableValue = 
new System.UInt16[,] { { 45179, 29892, }, { 59234, 29263, }, },
},
    NullableValue = 
new System.UInt16[,] { { 15458, 16234, }, { 48077, 19320, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 141,
    Value = 
new System.UInt16[,] { { 11695, 40313, }, { 61898, 19554, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 106,
    Value = 
new System.UInt16[,] { { 45300, 25048, }, { 55087, 27834, }, },
    NullableValue = 
new System.UInt16[,] { { 9851, 26567, }, { 13624, 22789, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 146,
    Value = 
new System.UInt16[,] { { 2113, 3830, }, { 8824, 59153, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 109,
    Value = 
new System.UInt16[,] { { 34616, 10453, }, { 63629, 61363, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 23559, 50211, }, { 56954, 7643, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 152,
    Value = 
new System.UInt16[,] { { 40970, 15363, }, { 18689, 9278, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.UInt16[,] { { 34628, 39143, }, { 8056, 18950, }, },
    NullableValue = 
new System.UInt16[,] { { 32214, 2557, }, { 30813, 62196, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 161,
    Value = 
new System.UInt16[,] { { 27475, 3291, }, { 50971, 21795, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 112,
    Value = 
new System.UInt16[,] { { 40102, 62348, }, { 19114, 17643, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 164,
    Value = 
new System.UInt16[,] { { 1436, 56906, }, { 14162, 27243, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.UInt16[,] { { 65144, 44405, }, { 63785, 44427, }, },
    NullableValue = 
new System.UInt16[,] { { 21459, 43164, }, { 54877, 28719, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 167,
    Value = 
new System.UInt16[,] { { 37248, 65200, }, { 41340, 22614, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 120,
    Value = 
new System.UInt16[,] { { 21141, 58239, }, { 29658, 1566, }, },
    NullableValue = 
new System.UInt16[,] { { 30474, 51549, }, { 27146, 61580, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 168,
    Value = 
new System.UInt16[,] { { 1416, 45772, }, { 9348, 50994, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.UInt16[,] { { 51393, 65518, }, { 4102, 55384, }, },
    NullableValue = 
new System.UInt16[,] { { 28727, 21004, }, { 27447, 27976, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 177,
    Value = 
new System.UInt16[,] { { 48331, 35858, }, { 40887, 56952, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 131,
    Value = 
new System.UInt16[,] { { 65389, 29320, }, { 25120, 61051, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 184,
    Value = 
new System.UInt16[,] { { 46929, 31181, }, { 2913, 47381, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 138,
    Value = 
new System.UInt16[,] { { 21086, 31941, }, { 8809, 27728, }, },
    NullableValue = 
new System.UInt16[,] { { 9147, 38503, }, { 36974, 4498, }, },
},
    NullableValue = 
new System.UInt16[,] { { 15313, 14095, }, { 46610, 55121, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 185,
    Value = 
new System.UInt16[,] { { 5440, 21299, }, { 29155, 29566, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.UInt16[,] { { 22298, 45669, }, { 27741, 46470, }, },
    NullableValue = 
new System.UInt16[,] { { 3463, 35299, }, { 17371, 5040, }, },
},
    NullableValue = 
new System.UInt16[,] { { 65058, 64309, }, { 43921, 5081, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 194,
    Value = 
new System.UInt16[,] { { 27824, 30266, }, { 7720, 50736, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt16[,] { { 25363, 20672, }, { 22327, 23277, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 31184, 6587, }, { 6863, 12583, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 196,
    Value = 
new System.UInt16[,] { { 44829, 12904, }, { 56797, 58811, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 148,
    Value = 
new System.UInt16[,] { { 56525, 16289, }, { 41016, 37071, }, },
    NullableValue = 
new System.UInt16[,] { { 37322, 37520, }, { 14431, 57402, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 197,
    Value = 
new System.UInt16[,] { { 19733, 45673, }, { 5666, 1036, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 149,
    Value = 
new System.UInt16[,] { { 53082, 41772, }, { 60250, 26775, }, },
    NullableValue = 
new System.UInt16[,] { { 17395, 5375, }, { 54913, 17879, }, },
},
    NullableValue = 
new System.UInt16[,] { { 41023, 11749, }, { 41681, 3821, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 205,
    Value = 
new System.UInt16[,] { { 56870, 53119, }, { 32984, 1116, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.UInt16[,] { { 4252, 50661, }, { 22552, 45822, }, },
    NullableValue = 
new System.UInt16[,] { { 11189, 30312, }, { 16279, 2143, }, },
},
    NullableValue = 
new System.UInt16[,] { { 33086, 36000, }, { 50561, 34455, }, },
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

