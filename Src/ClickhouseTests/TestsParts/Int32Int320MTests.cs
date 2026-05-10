

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

        private readonly Int32Int320M[] _testData = new Int32Int320M[]
        {
            new Int32Int320M
{
    Id = 9,
    Value = 918954779,
    ModelInner = new Int32Int320MI
{
    Id = 7,
    Value = 1927550646,
    NullableValue = 2077684919,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 11,
    Value = 1098406725,
    ModelInner = new Int32Int320MI
{
    Id = 16,
    Value = 1680275091,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 18,
    Value = 1002757792,
    ModelInner = new Int32Int320MI
{
    Id = 22,
    Value = 328186659,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 24,
    Value = 1312354587,
    ModelInner = new Int32Int320MI
{
    Id = 29,
    Value = 411456804,
    NullableValue = null,
},
    NullableValue = 1334758772,
},
            new Int32Int320M
{
    Id = 33,
    Value = 355528510,
    ModelInner = new Int32Int320MI
{
    Id = 33,
    Value = 908629250,
    NullableValue = 1839437718,
},
    NullableValue = 1015733781,
},
            new Int32Int320M
{
    Id = 35,
    Value = 1406053484,
    ModelInner = new Int32Int320MI
{
    Id = 39,
    Value = 640411310,
    NullableValue = 85624187,
},
    NullableValue = 772872121,
},
            new Int32Int320M
{
    Id = 39,
    Value = 737562010,
    ModelInner = new Int32Int320MI
{
    Id = 47,
    Value = 839723805,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 41,
    Value = 526634308,
    ModelInner = new Int32Int320MI
{
    Id = 50,
    Value = 780361000,
    NullableValue = 2138846150,
},
    NullableValue = 895892791,
},
            new Int32Int320M
{
    Id = 49,
    Value = 1802882024,
    ModelInner = new Int32Int320MI
{
    Id = 59,
    Value = 1705705919,
    NullableValue = null,
},
    NullableValue = 2029492451,
},
            new Int32Int320M
{
    Id = 56,
    Value = 1183271768,
    ModelInner = new Int32Int320MI
{
    Id = 62,
    Value = 596321893,
    NullableValue = 1655636352,
},
    NullableValue = 755982483,
},
            new Int32Int320M
{
    Id = 59,
    Value = 1424575264,
    ModelInner = new Int32Int320MI
{
    Id = 65,
    Value = 1071206251,
    NullableValue = 622671987,
},
    NullableValue = 1152906049,
},
            new Int32Int320M
{
    Id = 61,
    Value = 1773913299,
    ModelInner = new Int32Int320MI
{
    Id = 73,
    Value = 2054065110,
    NullableValue = null,
},
    NullableValue = 88492004,
},
            new Int32Int320M
{
    Id = 65,
    Value = 505052945,
    ModelInner = new Int32Int320MI
{
    Id = 82,
    Value = 1961333277,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 67,
    Value = 1423988037,
    ModelInner = new Int32Int320MI
{
    Id = 86,
    Value = 616956133,
    NullableValue = 1598735879,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 72,
    Value = 1762940709,
    ModelInner = new Int32Int320MI
{
    Id = 89,
    Value = 2007238656,
    NullableValue = 969211020,
},
    NullableValue = 1909714138,
},
            new Int32Int320M
{
    Id = 73,
    Value = 2076006830,
    ModelInner = new Int32Int320MI
{
    Id = 95,
    Value = 1040864231,
    NullableValue = 950967369,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 82,
    Value = 50565340,
    ModelInner = new Int32Int320MI
{
    Id = 101,
    Value = 587590466,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 91,
    Value = 350175465,
    ModelInner = new Int32Int320MI
{
    Id = 104,
    Value = 319932347,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 92,
    Value = 428703386,
    ModelInner = new Int32Int320MI
{
    Id = 105,
    Value = 26609310,
    NullableValue = 1253252043,
},
    NullableValue = 1680083853,
},
            new Int32Int320M
{
    Id = 97,
    Value = 1211852928,
    ModelInner = new Int32Int320MI
{
    Id = 106,
    Value = 1298626278,
    NullableValue = 1703735452,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 106,
    Value = 282285774,
    ModelInner = new Int32Int320MI
{
    Id = 109,
    Value = 2114557630,
    NullableValue = 1593710247,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 112,
    Value = 89168402,
    ModelInner = new Int32Int320MI
{
    Id = 117,
    Value = 2092840192,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 120,
    Value = 1475283662,
    ModelInner = new Int32Int320MI
{
    Id = 119,
    Value = 1557287859,
    NullableValue = 629107001,
},
    NullableValue = 1657305712,
},
            new Int32Int320M
{
    Id = 127,
    Value = 1334594029,
    ModelInner = new Int32Int320MI
{
    Id = 120,
    Value = 1079328150,
    NullableValue = 2060854966,
},
    NullableValue = 942191465,
},
            new Int32Int320M
{
    Id = 130,
    Value = 323152649,
    ModelInner = new Int32Int320MI
{
    Id = 126,
    Value = 1790841107,
    NullableValue = 1478336294,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 136,
    Value = 1086121462,
    ModelInner = new Int32Int320MI
{
    Id = 127,
    Value = 2071437775,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 138,
    Value = 1075426072,
    ModelInner = new Int32Int320MI
{
    Id = 130,
    Value = 2124197729,
    NullableValue = 583877366,
},
    NullableValue = 1901589929,
},
            new Int32Int320M
{
    Id = 140,
    Value = 979632776,
    ModelInner = new Int32Int320MI
{
    Id = 133,
    Value = 789291004,
    NullableValue = null,
},
    NullableValue = 4523164,
},
            new Int32Int320M
{
    Id = 142,
    Value = 1701506253,
    ModelInner = new Int32Int320MI
{
    Id = 141,
    Value = 1647289804,
    NullableValue = 1191967676,
},
    NullableValue = 1320223693,
},
            new Int32Int320M
{
    Id = 151,
    Value = 2091461810,
    ModelInner = new Int32Int320MI
{
    Id = 148,
    Value = 1342375931,
    NullableValue = 695172876,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 159,
    Value = 621562673,
    ModelInner = new Int32Int320MI
{
    Id = 153,
    Value = 1477978767,
    NullableValue = 1398363884,
},
    NullableValue = 2079859479,
},
            new Int32Int320M
{
    Id = 160,
    Value = 1394178609,
    ModelInner = new Int32Int320MI
{
    Id = 155,
    Value = 677794073,
    NullableValue = 1413102139,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 169,
    Value = 1449095230,
    ModelInner = new Int32Int320MI
{
    Id = 160,
    Value = 1268399681,
    NullableValue = 1999678266,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 171,
    Value = 636597634,
    ModelInner = new Int32Int320MI
{
    Id = 164,
    Value = 661786525,
    NullableValue = 22710801,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 178,
    Value = 263132100,
    ModelInner = new Int32Int320MI
{
    Id = 165,
    Value = 1157252819,
    NullableValue = null,
},
    NullableValue = 1361661453,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.int32int320m(
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
FROM gedaqtests.int32int320m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int32Int320M)],
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
                    Int32Int320M.AssertModel(models[0],_testData[i], false);
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
                    Int32Int320M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

