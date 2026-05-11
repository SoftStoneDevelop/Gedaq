

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
    Id = 1,
    Value = 1522006501,
    ModelInner = new Int32Int320MI
{
    Id = 2,
    Value = 1841550360,
    NullableValue = 1334971009,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 9,
    Value = 866195236,
    ModelInner = new Int32Int320MI
{
    Id = 11,
    Value = 1950160790,
    NullableValue = null,
},
    NullableValue = 411054214,
},
            new Int32Int32E0M
{
    Id = 16,
    Value = 309543143,
    ModelInner = new Int32Int320MI
{
    Id = 17,
    Value = 296788180,
    NullableValue = 2140329783,
},
    NullableValue = 1028863181,
},
            new Int32Int32E0M
{
    Id = 23,
    Value = 996761057,
    ModelInner = new Int32Int320MI
{
    Id = 19,
    Value = 1062791694,
    NullableValue = 771922246,
},
    NullableValue = 1651635822,
},
            new Int32Int32E0M
{
    Id = 30,
    Value = 2025654288,
    ModelInner = new Int32Int320MI
{
    Id = 28,
    Value = 943781313,
    NullableValue = 755611057,
},
    NullableValue = 630407540,
},
            new Int32Int32E0M
{
    Id = 39,
    Value = 149836734,
    ModelInner = new Int32Int320MI
{
    Id = 33,
    Value = 2001007203,
    NullableValue = 985409717,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 46,
    Value = 414172194,
    ModelInner = new Int32Int320MI
{
    Id = 42,
    Value = 704881791,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 47,
    Value = 1795029974,
    ModelInner = new Int32Int320MI
{
    Id = 50,
    Value = 615668444,
    NullableValue = null,
},
    NullableValue = 397524325,
},
            new Int32Int32E0M
{
    Id = 50,
    Value = 364950569,
    ModelInner = new Int32Int320MI
{
    Id = 57,
    Value = 1328615974,
    NullableValue = 160547616,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 52,
    Value = 722448775,
    ModelInner = new Int32Int320MI
{
    Id = 65,
    Value = 1552837897,
    NullableValue = 379643103,
},
    NullableValue = 1607248259,
},
            new Int32Int32E0M
{
    Id = 59,
    Value = 2010179611,
    ModelInner = new Int32Int320MI
{
    Id = 70,
    Value = 1841792958,
    NullableValue = 356727223,
},
    NullableValue = 1891180008,
},
            new Int32Int32E0M
{
    Id = 66,
    Value = 120044317,
    ModelInner = new Int32Int320MI
{
    Id = 72,
    Value = 706128286,
    NullableValue = 964781628,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 71,
    Value = 1077600780,
    ModelInner = new Int32Int320MI
{
    Id = 73,
    Value = 156627602,
    NullableValue = 466172643,
},
    NullableValue = 1109450197,
},
            new Int32Int32E0M
{
    Id = 75,
    Value = 1111085189,
    ModelInner = new Int32Int320MI
{
    Id = 78,
    Value = 494527398,
    NullableValue = 739256826,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 80,
    Value = 1129405584,
    ModelInner = new Int32Int320MI
{
    Id = 83,
    Value = 1808261513,
    NullableValue = 421840559,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 83,
    Value = 1925135728,
    ModelInner = new Int32Int320MI
{
    Id = 87,
    Value = 471008952,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 88,
    Value = 1851330354,
    ModelInner = new Int32Int320MI
{
    Id = 91,
    Value = 2058362306,
    NullableValue = null,
},
    NullableValue = 1893920827,
},
            new Int32Int32E0M
{
    Id = 95,
    Value = 1279677102,
    ModelInner = new Int32Int320MI
{
    Id = 95,
    Value = 1742568878,
    NullableValue = null,
},
    NullableValue = 1381171442,
},
            new Int32Int32E0M
{
    Id = 96,
    Value = 58421422,
    ModelInner = new Int32Int320MI
{
    Id = 104,
    Value = 227297081,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 104,
    Value = 934282409,
    ModelInner = new Int32Int320MI
{
    Id = 109,
    Value = 215284189,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 108,
    Value = 1964700567,
    ModelInner = new Int32Int320MI
{
    Id = 110,
    Value = 2004023599,
    NullableValue = 534040179,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 117,
    Value = 2138098846,
    ModelInner = new Int32Int320MI
{
    Id = 115,
    Value = 250697326,
    NullableValue = null,
},
    NullableValue = 1486019405,
},
            new Int32Int32E0M
{
    Id = 121,
    Value = 1834616194,
    ModelInner = new Int32Int320MI
{
    Id = 120,
    Value = 1420968481,
    NullableValue = 951794149,
},
    NullableValue = 153654681,
},
            new Int32Int32E0M
{
    Id = 122,
    Value = 389543855,
    ModelInner = new Int32Int320MI
{
    Id = 125,
    Value = 1469276588,
    NullableValue = null,
},
    NullableValue = 1673778187,
},
            new Int32Int32E0M
{
    Id = 130,
    Value = 1735595768,
    ModelInner = new Int32Int320MI
{
    Id = 128,
    Value = 1167354626,
    NullableValue = 1119023956,
},
    NullableValue = 252708698,
},
            new Int32Int32E0M
{
    Id = 135,
    Value = 688134612,
    ModelInner = new Int32Int320MI
{
    Id = 129,
    Value = 863463101,
    NullableValue = 1277465066,
},
    NullableValue = 540224970,
},
            new Int32Int32E0M
{
    Id = 139,
    Value = 1138064874,
    ModelInner = new Int32Int320MI
{
    Id = 137,
    Value = 890125084,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 146,
    Value = 484851757,
    ModelInner = new Int32Int320MI
{
    Id = 143,
    Value = 211647126,
    NullableValue = 423823723,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 152,
    Value = 1431695893,
    ModelInner = new Int32Int320MI
{
    Id = 150,
    Value = 1545195033,
    NullableValue = null,
},
    NullableValue = 578073499,
},
            new Int32Int32E0M
{
    Id = 155,
    Value = 978483342,
    ModelInner = new Int32Int320MI
{
    Id = 155,
    Value = 1524243945,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 163,
    Value = 1921162344,
    ModelInner = new Int32Int320MI
{
    Id = 162,
    Value = 1286848718,
    NullableValue = null,
},
    NullableValue = 174901104,
},
            new Int32Int32E0M
{
    Id = 168,
    Value = 1466435415,
    ModelInner = new Int32Int320MI
{
    Id = 163,
    Value = 2069042780,
    NullableValue = null,
},
    NullableValue = 1139334902,
},
            new Int32Int32E0M
{
    Id = 173,
    Value = 726004774,
    ModelInner = new Int32Int320MI
{
    Id = 164,
    Value = 267682121,
    NullableValue = 1336085515,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 174,
    Value = 2006905666,
    ModelInner = new Int32Int320MI
{
    Id = 170,
    Value = 1827512754,
    NullableValue = null,
},
    NullableValue = 760250096,
},
            new Int32Int32E0M
{
    Id = 181,
    Value = 1691801979,
    ModelInner = new Int32Int320MI
{
    Id = 171,
    Value = 636535214,
    NullableValue = null,
},
    NullableValue = 43017531,
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

