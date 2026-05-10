

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
    Id = 8,
    Value = 129851518,
    ModelInner = new Int32Int320MI
{
    Id = 8,
    Value = 1240493904,
    NullableValue = 467431257,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 15,
    Value = 1947738945,
    ModelInner = new Int32Int320MI
{
    Id = 16,
    Value = 2089514841,
    NullableValue = null,
},
    NullableValue = 534219580,
},
            new Int32Int320M
{
    Id = 20,
    Value = 777459396,
    ModelInner = new Int32Int320MI
{
    Id = 22,
    Value = 2110551365,
    NullableValue = null,
},
    NullableValue = 561377437,
},
            new Int32Int320M
{
    Id = 24,
    Value = 896311620,
    ModelInner = new Int32Int320MI
{
    Id = 26,
    Value = 1440394614,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 25,
    Value = 1618890795,
    ModelInner = new Int32Int320MI
{
    Id = 35,
    Value = 1817804913,
    NullableValue = 460565442,
},
    NullableValue = 1009370911,
},
            new Int32Int320M
{
    Id = 27,
    Value = 745427683,
    ModelInner = new Int32Int320MI
{
    Id = 44,
    Value = 511899230,
    NullableValue = 1963576063,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 35,
    Value = 1566562363,
    ModelInner = new Int32Int320MI
{
    Id = 52,
    Value = 153228223,
    NullableValue = 1985142058,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 42,
    Value = 1576858295,
    ModelInner = new Int32Int320MI
{
    Id = 55,
    Value = 611902553,
    NullableValue = null,
},
    NullableValue = 966512998,
},
            new Int32Int320M
{
    Id = 47,
    Value = 864975834,
    ModelInner = new Int32Int320MI
{
    Id = 56,
    Value = 1555950424,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 54,
    Value = 295637061,
    ModelInner = new Int32Int320MI
{
    Id = 63,
    Value = 631525221,
    NullableValue = null,
},
    NullableValue = 1691669507,
},
            new Int32Int320M
{
    Id = 56,
    Value = 1829539625,
    ModelInner = new Int32Int320MI
{
    Id = 66,
    Value = 1072904368,
    NullableValue = 1126635692,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 65,
    Value = 1365853072,
    ModelInner = new Int32Int320MI
{
    Id = 71,
    Value = 1496572443,
    NullableValue = 957423538,
},
    NullableValue = 1530081646,
},
            new Int32Int320M
{
    Id = 66,
    Value = 1035458489,
    ModelInner = new Int32Int320MI
{
    Id = 80,
    Value = 437948401,
    NullableValue = 1978500827,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 73,
    Value = 26944054,
    ModelInner = new Int32Int320MI
{
    Id = 88,
    Value = 254844292,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 77,
    Value = 237127793,
    ModelInner = new Int32Int320MI
{
    Id = 90,
    Value = 2032301454,
    NullableValue = 2081016342,
},
    NullableValue = 1343890484,
},
            new Int32Int320M
{
    Id = 83,
    Value = 1087710028,
    ModelInner = new Int32Int320MI
{
    Id = 93,
    Value = 1177926146,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 89,
    Value = 1357076490,
    ModelInner = new Int32Int320MI
{
    Id = 102,
    Value = 582571773,
    NullableValue = 1859453884,
},
    NullableValue = 229864438,
},
            new Int32Int320M
{
    Id = 95,
    Value = 1344915339,
    ModelInner = new Int32Int320MI
{
    Id = 103,
    Value = 1895018831,
    NullableValue = 518005172,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 98,
    Value = 371228718,
    ModelInner = new Int32Int320MI
{
    Id = 105,
    Value = 160611129,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 107,
    Value = 1605036331,
    ModelInner = new Int32Int320MI
{
    Id = 107,
    Value = 2102506449,
    NullableValue = 1490172853,
},
    NullableValue = 478038770,
},
            new Int32Int320M
{
    Id = 111,
    Value = 953089874,
    ModelInner = new Int32Int320MI
{
    Id = 113,
    Value = 1288844353,
    NullableValue = 515241400,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 112,
    Value = 1342254296,
    ModelInner = new Int32Int320MI
{
    Id = 122,
    Value = 1895610385,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 118,
    Value = 1270966933,
    ModelInner = new Int32Int320MI
{
    Id = 124,
    Value = 1205031951,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 123,
    Value = 1607998658,
    ModelInner = new Int32Int320MI
{
    Id = 133,
    Value = 703053297,
    NullableValue = null,
},
    NullableValue = 2042854420,
},
            new Int32Int320M
{
    Id = 125,
    Value = 1408272166,
    ModelInner = new Int32Int320MI
{
    Id = 136,
    Value = 1220875263,
    NullableValue = 2119273952,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 127,
    Value = 1912475180,
    ModelInner = new Int32Int320MI
{
    Id = 138,
    Value = 2071525981,
    NullableValue = 1304959446,
},
    NullableValue = 791561712,
},
            new Int32Int320M
{
    Id = 136,
    Value = 1411218339,
    ModelInner = new Int32Int320MI
{
    Id = 139,
    Value = 831161516,
    NullableValue = 585372703,
},
    NullableValue = 264798736,
},
            new Int32Int320M
{
    Id = 140,
    Value = 1825898739,
    ModelInner = new Int32Int320MI
{
    Id = 143,
    Value = 1267605314,
    NullableValue = null,
},
    NullableValue = 1040934045,
},
            new Int32Int320M
{
    Id = 144,
    Value = 454467382,
    ModelInner = new Int32Int320MI
{
    Id = 149,
    Value = 1629715280,
    NullableValue = 1478455919,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 151,
    Value = 810729413,
    ModelInner = new Int32Int320MI
{
    Id = 156,
    Value = 998463565,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 159,
    Value = 206468018,
    ModelInner = new Int32Int320MI
{
    Id = 163,
    Value = 284611785,
    NullableValue = null,
},
    NullableValue = 2011707695,
},
            new Int32Int320M
{
    Id = 163,
    Value = 426615993,
    ModelInner = new Int32Int320MI
{
    Id = 168,
    Value = 1660213570,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 166,
    Value = 1860195583,
    ModelInner = new Int32Int320MI
{
    Id = 171,
    Value = 966872496,
    NullableValue = null,
},
    NullableValue = 594596787,
},
            new Int32Int320M
{
    Id = 172,
    Value = 1288952966,
    ModelInner = new Int32Int320MI
{
    Id = 173,
    Value = 1276558272,
    NullableValue = 2049951945,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 181,
    Value = 1533925819,
    ModelInner = new Int32Int320MI
{
    Id = 176,
    Value = 755277727,
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
INSERT INTO gedaqtests.int32int320m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    @m_id:Int32,
    @m_value:Int32, 
    @mi_id:Int32,
    @mi_value:Int32
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
                parametrName: "mi_Value", 
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
                        m_Id: _testData[0].Id,
                        m_Value: _testData[0].Value,
                        mi_Id: _testData[0].ModelInner.Id,
                        mi_Value: _testData[0].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 34; i++)
                {
                     ((IInt32SingleTypeInt32)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[2].Id,
                        m_Value: _testData[2].Value,
                        mi_Id: _testData[2].ModelInner.Id,
                        mi_Value: _testData[2].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT INTO gedaqtests.int32int320m(
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
    m_id = @m_id:Int32
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

