

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
    internal partial interface IInt32SingleTypeInt32
    {
    }
    
    internal partial class Int32SingleTypeInt32 : IInt32SingleTypeInt32
    {


#region TestData

        private readonly Int32Int32E0M[] _testData = new Int32Int32E0M[]
        {
            new Int32Int32E0M
{
    Id = 9,
    Value = 1982904206,
    ModelInner = new Int32Int32E0MI
{
    Id = 8,
    Value = 1437139822,
    NullableValue = null,
},
    NullableValue = 2092517442,
},
            new Int32Int32E0M
{
    Id = 15,
    Value = 820654742,
    ModelInner = new Int32Int32E0MI
{
    Id = 10,
    Value = 1828545645,
    NullableValue = 143666957,
},
    NullableValue = 1337670306,
},
            new Int32Int32E0M
{
    Id = 23,
    Value = 341143942,
    ModelInner = new Int32Int32E0MI
{
    Id = 14,
    Value = 1226535476,
    NullableValue = 1611622870,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 25,
    Value = 1183206917,
    ModelInner = new Int32Int32E0MI
{
    Id = 20,
    Value = 1864728937,
    NullableValue = null,
},
    NullableValue = 597812138,
},
            new Int32Int32E0M
{
    Id = 32,
    Value = 77888395,
    ModelInner = new Int32Int32E0MI
{
    Id = 22,
    Value = 976397946,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 36,
    Value = 159283750,
    ModelInner = new Int32Int32E0MI
{
    Id = 27,
    Value = 1695558028,
    NullableValue = 1739482906,
},
    NullableValue = 797698189,
},
            new Int32Int32E0M
{
    Id = 37,
    Value = 1437123840,
    ModelInner = new Int32Int32E0MI
{
    Id = 36,
    Value = 1066035384,
    NullableValue = null,
},
    NullableValue = 616549624,
},
            new Int32Int32E0M
{
    Id = 46,
    Value = 4782272,
    ModelInner = new Int32Int32E0MI
{
    Id = 38,
    Value = 1278528845,
    NullableValue = null,
},
    NullableValue = 908194989,
},
            new Int32Int32E0M
{
    Id = 55,
    Value = 1474746749,
    ModelInner = new Int32Int32E0MI
{
    Id = 42,
    Value = 1365992624,
    NullableValue = null,
},
    NullableValue = 1238195395,
},
            new Int32Int32E0M
{
    Id = 58,
    Value = 846698281,
    ModelInner = new Int32Int32E0MI
{
    Id = 49,
    Value = 1412073962,
    NullableValue = 1885190027,
},
    NullableValue = 1962697229,
},
            new Int32Int32E0M
{
    Id = 60,
    Value = 785392135,
    ModelInner = new Int32Int32E0MI
{
    Id = 58,
    Value = 590467745,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 67,
    Value = 415130147,
    ModelInner = new Int32Int32E0MI
{
    Id = 65,
    Value = 791568313,
    NullableValue = 1803620858,
},
    NullableValue = 495345329,
},
            new Int32Int32E0M
{
    Id = 74,
    Value = 858814793,
    ModelInner = new Int32Int32E0MI
{
    Id = 67,
    Value = 1638668174,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 77,
    Value = 38067611,
    ModelInner = new Int32Int32E0MI
{
    Id = 76,
    Value = 2033444278,
    NullableValue = null,
},
    NullableValue = 179124634,
},
            new Int32Int32E0M
{
    Id = 78,
    Value = 1495472428,
    ModelInner = new Int32Int32E0MI
{
    Id = 80,
    Value = 1404548461,
    NullableValue = null,
},
    NullableValue = 661904306,
},
            new Int32Int32E0M
{
    Id = 82,
    Value = 2054119772,
    ModelInner = new Int32Int32E0MI
{
    Id = 82,
    Value = 1866624627,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 84,
    Value = 1364705765,
    ModelInner = new Int32Int32E0MI
{
    Id = 85,
    Value = 1492733546,
    NullableValue = 2018116444,
},
    NullableValue = 1583369183,
},
            new Int32Int32E0M
{
    Id = 88,
    Value = 1824871833,
    ModelInner = new Int32Int32E0MI
{
    Id = 87,
    Value = 41786022,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 91,
    Value = 1125611675,
    ModelInner = new Int32Int32E0MI
{
    Id = 90,
    Value = 1152135972,
    NullableValue = null,
},
    NullableValue = 1308776647,
},
            new Int32Int32E0M
{
    Id = 94,
    Value = 1717423067,
    ModelInner = new Int32Int32E0MI
{
    Id = 99,
    Value = 969134226,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 101,
    Value = 947305635,
    ModelInner = new Int32Int32E0MI
{
    Id = 103,
    Value = 674726817,
    NullableValue = null,
},
    NullableValue = 1048257509,
},
            new Int32Int32E0M
{
    Id = 102,
    Value = 1095215975,
    ModelInner = new Int32Int32E0MI
{
    Id = 104,
    Value = 644849784,
    NullableValue = null,
},
    NullableValue = 1635385730,
},
            new Int32Int32E0M
{
    Id = 111,
    Value = 1238598721,
    ModelInner = new Int32Int32E0MI
{
    Id = 105,
    Value = 504729151,
    NullableValue = 2060370705,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 112,
    Value = 96896814,
    ModelInner = new Int32Int32E0MI
{
    Id = 112,
    Value = 248163620,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 113,
    Value = 1159453941,
    ModelInner = new Int32Int32E0MI
{
    Id = 121,
    Value = 1980496293,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 119,
    Value = 1565189551,
    ModelInner = new Int32Int32E0MI
{
    Id = 129,
    Value = 2042787391,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 127,
    Value = 191305340,
    ModelInner = new Int32Int32E0MI
{
    Id = 137,
    Value = 1565729227,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 133,
    Value = 686782947,
    ModelInner = new Int32Int32E0MI
{
    Id = 145,
    Value = 1512487929,
    NullableValue = null,
},
    NullableValue = 1643890554,
},
            new Int32Int32E0M
{
    Id = 141,
    Value = 1254710026,
    ModelInner = new Int32Int32E0MI
{
    Id = 149,
    Value = 164195642,
    NullableValue = null,
},
    NullableValue = 1333900120,
},
            new Int32Int32E0M
{
    Id = 147,
    Value = 1941921310,
    ModelInner = new Int32Int32E0MI
{
    Id = 150,
    Value = 1592702444,
    NullableValue = 401422895,
},
    NullableValue = 784211225,
},
            new Int32Int32E0M
{
    Id = 148,
    Value = 1185278589,
    ModelInner = new Int32Int32E0MI
{
    Id = 159,
    Value = 1028893056,
    NullableValue = 1244472978,
},
    NullableValue = 674402901,
},
            new Int32Int32E0M
{
    Id = 153,
    Value = 20481027,
    ModelInner = new Int32Int32E0MI
{
    Id = 162,
    Value = 758065435,
    NullableValue = 636783701,
},
    NullableValue = 2003747090,
},
            new Int32Int32E0M
{
    Id = 157,
    Value = 134845603,
    ModelInner = new Int32Int32E0MI
{
    Id = 165,
    Value = 147529383,
    NullableValue = 1352013765,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 164,
    Value = 734153644,
    ModelInner = new Int32Int32E0MI
{
    Id = 167,
    Value = 372275051,
    NullableValue = null,
},
    NullableValue = 770352817,
},
            new Int32Int32E0M
{
    Id = 171,
    Value = 2086045664,
    ModelInner = new Int32Int32E0MI
{
    Id = 171,
    Value = 1091431985,
    NullableValue = 1756952187,
},
    NullableValue = 574101488,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int32e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int32}, 
    {mi_id:Int32},
    {mi_value:Int32}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
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
                    await ((IInt32SingleTypeInt32)this).InsertModelDbConnectionAsync(
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
                     ((IInt32SingleTypeInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.int32int32e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32Int32E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt32SingleTypeInt32)),
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
                    var models = await ((IInt32SingleTypeInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int32E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt32SingleTypeInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int32Int32E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

