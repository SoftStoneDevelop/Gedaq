

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
new System.UInt16[,] { { 1907, 48543, }, { 25532, 39438, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 7,
    Value = 
new System.UInt16[,] { { 61801, 38122, }, { 58823, 5640, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 9,
    Value = 
new System.UInt16[,] { { 29273, 29287, }, { 56010, 18790, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 8,
    Value = 
new System.UInt16[,] { { 59896, 26644, }, { 43800, 45902, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 10,
    Value = 
new System.UInt16[,] { { 15940, 54502, }, { 61070, 56098, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 11,
    Value = 
new System.UInt16[,] { { 17482, 11491, }, { 18877, 35674, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 16097, 56951, }, { 7901, 59491, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 11,
    Value = 
new System.UInt16[,] { { 8665, 12453, }, { 3575, 64144, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.UInt16[,] { { 9867, 15522, }, { 50717, 60887, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 18,
    Value = 
new System.UInt16[,] { { 7785, 23182, }, { 33590, 53584, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 17,
    Value = 
new System.UInt16[,] { { 34244, 24424, }, { 61198, 16951, }, },
    NullableValue = 
new System.UInt16[,] { { 10689, 53762, }, { 41937, 1536, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 21,
    Value = 
new System.UInt16[,] { { 64025, 17200, }, { 15246, 18289, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt16[,] { { 46273, 6584, }, { 53423, 47379, }, },
    NullableValue = 
new System.UInt16[,] { { 42487, 43440, }, { 10541, 23891, }, },
},
    NullableValue = 
new System.UInt16[,] { { 54549, 37624, }, { 12350, 53560, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 24,
    Value = 
new System.UInt16[,] { { 40889, 30318, }, { 15177, 41749, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 27,
    Value = 
new System.UInt16[,] { { 16219, 53042, }, { 46477, 17466, }, },
    NullableValue = 
new System.UInt16[,] { { 16474, 3578, }, { 31889, 39958, }, },
},
    NullableValue = 
new System.UInt16[,] { { 64795, 54614, }, { 35568, 39810, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 26,
    Value = 
new System.UInt16[,] { { 46628, 60556, }, { 55321, 29107, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 30,
    Value = 
new System.UInt16[,] { { 21539, 56982, }, { 16618, 28829, }, },
    NullableValue = 
new System.UInt16[,] { { 2076, 8775, }, { 8145, 41265, }, },
},
    NullableValue = 
new System.UInt16[,] { { 3747, 65077, }, { 33274, 58698, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 28,
    Value = 
new System.UInt16[,] { { 60866, 34953, }, { 32218, 59558, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 32,
    Value = 
new System.UInt16[,] { { 58676, 61751, }, { 45947, 7075, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 35208, 4380, }, { 28988, 21478, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 31,
    Value = 
new System.UInt16[,] { { 41065, 54261, }, { 42848, 57472, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 41,
    Value = 
new System.UInt16[,] { { 4994, 50190, }, { 62513, 47819, }, },
    NullableValue = 
new System.UInt16[,] { { 13556, 60358, }, { 37061, 13725, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 32,
    Value = 
new System.UInt16[,] { { 59489, 27870, }, { 6918, 20062, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt16[,] { { 25961, 43581, }, { 38398, 1189, }, },
    NullableValue = 
new System.UInt16[,] { { 42310, 6405, }, { 47678, 9102, }, },
},
    NullableValue = 
new System.UInt16[,] { { 4888, 29077, }, { 65028, 65225, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 33,
    Value = 
new System.UInt16[,] { { 50684, 22066, }, { 32501, 65228, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 56,
    Value = 
new System.UInt16[,] { { 54214, 15610, }, { 46046, 28158, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 41104, 36635, }, { 8766, 54720, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 42,
    Value = 
new System.UInt16[,] { { 36749, 38496, }, { 61673, 59704, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 58,
    Value = 
new System.UInt16[,] { { 45607, 38969, }, { 34, 18939, }, },
    NullableValue = 
new System.UInt16[,] { { 2918, 46683, }, { 26830, 1969, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 49,
    Value = 
new System.UInt16[,] { { 42262, 6618, }, { 10686, 36552, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 67,
    Value = 
new System.UInt16[,] { { 38988, 5534, }, { 21524, 24776, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 24240, 14759, }, { 41292, 51855, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 58,
    Value = 
new System.UInt16[,] { { 7261, 50304, }, { 35161, 22069, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 72,
    Value = 
new System.UInt16[,] { { 9458, 11737, }, { 55392, 60039, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 66,
    Value = 
new System.UInt16[,] { { 15042, 2342, }, { 15790, 25647, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 81,
    Value = 
new System.UInt16[,] { { 44664, 62169, }, { 46571, 43635, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 73,
    Value = 
new System.UInt16[,] { { 57697, 43516, }, { 5278, 11106, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 88,
    Value = 
new System.UInt16[,] { { 14512, 61403, }, { 30662, 51262, }, },
    NullableValue = 
new System.UInt16[,] { { 28753, 47553, }, { 22706, 55292, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 80,
    Value = 
new System.UInt16[,] { { 43539, 36221, }, { 13889, 40209, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 94,
    Value = 
new System.UInt16[,] { { 21406, 2210, }, { 59039, 28908, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 89,
    Value = 
new System.UInt16[,] { { 16404, 33026, }, { 30549, 50761, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.UInt16[,] { { 57071, 38456, }, { 31639, 19021, }, },
    NullableValue = 
new System.UInt16[,] { { 52654, 34961, }, { 3703, 21010, }, },
},
    NullableValue = 
new System.UInt16[,] { { 9974, 23882, }, { 45021, 7342, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 95,
    Value = 
new System.UInt16[,] { { 8488, 1477, }, { 13443, 12662, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 107,
    Value = 
new System.UInt16[,] { { 36807, 47182, }, { 16923, 56265, }, },
    NullableValue = 
new System.UInt16[,] { { 6838, 54520, }, { 25718, 43239, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 100,
    Value = 
new System.UInt16[,] { { 57880, 1716, }, { 9711, 29736, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 110,
    Value = 
new System.UInt16[,] { { 49694, 58291, }, { 11824, 10113, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 107,
    Value = 
new System.UInt16[,] { { 45553, 1193, }, { 33413, 46725, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.UInt16[,] { { 12303, 12213, }, { 37363, 40824, }, },
    NullableValue = 
new System.UInt16[,] { { 3470, 56304, }, { 34548, 46226, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 108,
    Value = 
new System.UInt16[,] { { 50871, 19331, }, { 28670, 61574, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 122,
    Value = 
new System.UInt16[,] { { 55257, 8560, }, { 19956, 64733, }, },
    NullableValue = 
new System.UInt16[,] { { 1101, 21221, }, { 29268, 12254, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 113,
    Value = 
new System.UInt16[,] { { 61267, 18208, }, { 26381, 12295, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.UInt16[,] { { 16586, 50452, }, { 64142, 59642, }, },
    NullableValue = 
new System.UInt16[,] { { 41549, 2313, }, { 33243, 54224, }, },
},
    NullableValue = 
new System.UInt16[,] { { 13261, 48077, }, { 48688, 48530, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 118,
    Value = 
new System.UInt16[,] { { 21469, 57231, }, { 58568, 32488, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.UInt16[,] { { 47352, 50762, }, { 51386, 32851, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 45072, 36215, }, { 3746, 42238, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 120,
    Value = 
new System.UInt16[,] { { 43119, 25306, }, { 47073, 46279, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 142,
    Value = 
new System.UInt16[,] { { 46307, 10585, }, { 42341, 64046, }, },
    NullableValue = 
new System.UInt16[,] { { 57070, 20523, }, { 17399, 17039, }, },
},
    NullableValue = 
new System.UInt16[,] { { 30684, 207, }, { 61214, 63305, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 124,
    Value = 
new System.UInt16[,] { { 32698, 64053, }, { 49841, 6385, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt16[,] { { 32469, 4951, }, { 24364, 5727, }, },
    NullableValue = 
new System.UInt16[,] { { 37834, 38558, }, { 21161, 1381, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 129,
    Value = 
new System.UInt16[,] { { 31962, 27745, }, { 31983, 32693, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 145,
    Value = 
new System.UInt16[,] { { 5055, 60866, }, { 38820, 24033, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 36984, 10335, }, { 62443, 7117, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 138,
    Value = 
new System.UInt16[,] { { 50912, 16919, }, { 62963, 14407, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 151,
    Value = 
new System.UInt16[,] { { 24920, 63788, }, { 19152, 3029, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 146,
    Value = 
new System.UInt16[,] { { 21028, 41862, }, { 50481, 45336, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 157,
    Value = 
new System.UInt16[,] { { 57768, 47224, }, { 42803, 11553, }, },
    NullableValue = 
new System.UInt16[,] { { 47381, 14949, }, { 47873, 19918, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 150,
    Value = 
new System.UInt16[,] { { 37910, 11577, }, { 24876, 2243, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 164,
    Value = 
new System.UInt16[,] { { 59305, 33196, }, { 41377, 4138, }, },
    NullableValue = 
new System.UInt16[,] { { 33561, 13769, }, { 390, 10389, }, },
},
    NullableValue = 
new System.UInt16[,] { { 55047, 21254, }, { 5784, 33288, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 153,
    Value = 
new System.UInt16[,] { { 51324, 32363, }, { 17450, 16106, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 166,
    Value = 
new System.UInt16[,] { { 17684, 14623, }, { 37789, 52855, }, },
    NullableValue = 
new System.UInt16[,] { { 38756, 46495, }, { 43434, 6999, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 159,
    Value = 
new System.UInt16[,] { { 60869, 48087, }, { 61218, 65363, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 171,
    Value = 
new System.UInt16[,] { { 40479, 3232, }, { 63512, 1494, }, },
    NullableValue = null,
},
    NullableValue = 
new System.UInt16[,] { { 30495, 41615, }, { 13394, 56374, }, },
},
            new UInt16MArrayD2E1M
{
    Id = 166,
    Value = 
new System.UInt16[,] { { 50518, 40652, }, { 35523, 46057, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 173,
    Value = 
new System.UInt16[,] { { 1119, 52160, }, { 32259, 59684, }, },
    NullableValue = 
new System.UInt16[,] { { 20985, 26798, }, { 34872, 13891, }, },
},
    NullableValue = null,
},
            new UInt16MArrayD2E1M
{
    Id = 168,
    Value = 
new System.UInt16[,] { { 31396, 29797, }, { 3786, 1145, }, },
    ModelInner = new UInt16MArrayD2E1MI
{
    Id = 179,
    Value = 
new System.UInt16[,] { { 17313, 52474, }, { 2140, 60139, }, },
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

