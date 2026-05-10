

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
    Id = 1,
    Value = 1058692809,
    ModelInner = new Int32Int320MI
{
    Id = 6,
    Value = 1075764370,
    NullableValue = 1178421203,
},
    NullableValue = 985189472,
},
            new Int32Int320M
{
    Id = 3,
    Value = 1006274203,
    ModelInner = new Int32Int320MI
{
    Id = 11,
    Value = 765341169,
    NullableValue = 153028593,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 9,
    Value = 1246255656,
    ModelInner = new Int32Int320MI
{
    Id = 12,
    Value = 1868698757,
    NullableValue = 2059553496,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 18,
    Value = 1918482556,
    ModelInner = new Int32Int320MI
{
    Id = 13,
    Value = 1357572092,
    NullableValue = null,
},
    NullableValue = 1969166405,
},
            new Int32Int320M
{
    Id = 25,
    Value = 488726089,
    ModelInner = new Int32Int320MI
{
    Id = 18,
    Value = 1553830390,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 26,
    Value = 1067486406,
    ModelInner = new Int32Int320MI
{
    Id = 27,
    Value = 857405383,
    NullableValue = 191232614,
},
    NullableValue = 795268727,
},
            new Int32Int320M
{
    Id = 29,
    Value = 1672323211,
    ModelInner = new Int32Int320MI
{
    Id = 31,
    Value = 1112670152,
    NullableValue = 1851027580,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 36,
    Value = 1634577667,
    ModelInner = new Int32Int320MI
{
    Id = 34,
    Value = 747370219,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 41,
    Value = 1781996624,
    ModelInner = new Int32Int320MI
{
    Id = 35,
    Value = 190435597,
    NullableValue = 1214829082,
},
    NullableValue = 985863434,
},
            new Int32Int320M
{
    Id = 46,
    Value = 773028707,
    ModelInner = new Int32Int320MI
{
    Id = 36,
    Value = 674421289,
    NullableValue = null,
},
    NullableValue = 980446185,
},
            new Int32Int320M
{
    Id = 48,
    Value = 1990303431,
    ModelInner = new Int32Int320MI
{
    Id = 42,
    Value = 1835542853,
    NullableValue = null,
},
    NullableValue = 2005805,
},
            new Int32Int320M
{
    Id = 57,
    Value = 2063728334,
    ModelInner = new Int32Int320MI
{
    Id = 46,
    Value = 2117793581,
    NullableValue = 1464888087,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 63,
    Value = 1205224020,
    ModelInner = new Int32Int320MI
{
    Id = 51,
    Value = 543894808,
    NullableValue = null,
},
    NullableValue = 1799357183,
},
            new Int32Int320M
{
    Id = 69,
    Value = 1441794727,
    ModelInner = new Int32Int320MI
{
    Id = 54,
    Value = 1100917968,
    NullableValue = 1068870719,
},
    NullableValue = 555137214,
},
            new Int32Int320M
{
    Id = 73,
    Value = 1367720306,
    ModelInner = new Int32Int320MI
{
    Id = 55,
    Value = 14528431,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 77,
    Value = 1402443668,
    ModelInner = new Int32Int320MI
{
    Id = 59,
    Value = 346714404,
    NullableValue = 1153957601,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 84,
    Value = 1839119654,
    ModelInner = new Int32Int320MI
{
    Id = 64,
    Value = 1847504145,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 89,
    Value = 2122832018,
    ModelInner = new Int32Int320MI
{
    Id = 72,
    Value = 1679652505,
    NullableValue = null,
},
    NullableValue = 173151890,
},
            new Int32Int320M
{
    Id = 93,
    Value = 650625888,
    ModelInner = new Int32Int320MI
{
    Id = 78,
    Value = 314330153,
    NullableValue = null,
},
    NullableValue = 1452209663,
},
            new Int32Int320M
{
    Id = 102,
    Value = 1680238169,
    ModelInner = new Int32Int320MI
{
    Id = 82,
    Value = 339637429,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 103,
    Value = 74217071,
    ModelInner = new Int32Int320MI
{
    Id = 85,
    Value = 626533972,
    NullableValue = 1129523356,
},
    NullableValue = 2072896313,
},
            new Int32Int320M
{
    Id = 112,
    Value = 1897818861,
    ModelInner = new Int32Int320MI
{
    Id = 87,
    Value = 1314902499,
    NullableValue = 142358538,
},
    NullableValue = 487979209,
},
            new Int32Int320M
{
    Id = 117,
    Value = 230355562,
    ModelInner = new Int32Int320MI
{
    Id = 94,
    Value = 390035013,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 118,
    Value = 2093320506,
    ModelInner = new Int32Int320MI
{
    Id = 98,
    Value = 1598533803,
    NullableValue = 1570609951,
},
    NullableValue = 1635292496,
},
            new Int32Int320M
{
    Id = 120,
    Value = 1931307332,
    ModelInner = new Int32Int320MI
{
    Id = 104,
    Value = 318520640,
    NullableValue = null,
},
    NullableValue = 141839174,
},
            new Int32Int320M
{
    Id = 127,
    Value = 1982940685,
    ModelInner = new Int32Int320MI
{
    Id = 108,
    Value = 1743914866,
    NullableValue = null,
},
    NullableValue = 1966857573,
},
            new Int32Int320M
{
    Id = 136,
    Value = 1807764977,
    ModelInner = new Int32Int320MI
{
    Id = 113,
    Value = 756604354,
    NullableValue = 1550634972,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 145,
    Value = 2137255572,
    ModelInner = new Int32Int320MI
{
    Id = 119,
    Value = 1046548636,
    NullableValue = 1163212508,
},
    NullableValue = 1997387231,
},
            new Int32Int320M
{
    Id = 147,
    Value = 1837246096,
    ModelInner = new Int32Int320MI
{
    Id = 125,
    Value = 1717922379,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 152,
    Value = 1732211986,
    ModelInner = new Int32Int320MI
{
    Id = 128,
    Value = 286021232,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 160,
    Value = 721508247,
    ModelInner = new Int32Int320MI
{
    Id = 136,
    Value = 1920621040,
    NullableValue = 168379254,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 161,
    Value = 1122320744,
    ModelInner = new Int32Int320MI
{
    Id = 143,
    Value = 2068169349,
    NullableValue = null,
},
    NullableValue = 1203041308,
},
            new Int32Int320M
{
    Id = 168,
    Value = 1213258405,
    ModelInner = new Int32Int320MI
{
    Id = 150,
    Value = 2087776821,
    NullableValue = null,
},
    NullableValue = 542196535,
},
            new Int32Int320M
{
    Id = 169,
    Value = 921018074,
    ModelInner = new Int32Int320MI
{
    Id = 155,
    Value = 251694382,
    NullableValue = 687094750,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 176,
    Value = 1901163068,
    ModelInner = new Int32Int320MI
{
    Id = 156,
    Value = 1728203696,
    NullableValue = 2114602517,
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

