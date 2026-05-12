

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
    Id = 6,
    Value = 794206234,
    ModelInner = new Int32Int32E0MI
{
    Id = 8,
    Value = 289934401,
    NullableValue = null,
},
    NullableValue = 1015348496,
},
            new Int32Int32E0M
{
    Id = 11,
    Value = 590400550,
    ModelInner = new Int32Int32E0MI
{
    Id = 10,
    Value = 590640881,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 16,
    Value = 1642026534,
    ModelInner = new Int32Int32E0MI
{
    Id = 17,
    Value = 966847470,
    NullableValue = 1700573066,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 20,
    Value = 54361068,
    ModelInner = new Int32Int32E0MI
{
    Id = 22,
    Value = 39759547,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 26,
    Value = 2042886689,
    ModelInner = new Int32Int32E0MI
{
    Id = 24,
    Value = 1201663640,
    NullableValue = 1031205797,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 31,
    Value = 2095582443,
    ModelInner = new Int32Int32E0MI
{
    Id = 32,
    Value = 1851334983,
    NullableValue = 2112322337,
},
    NullableValue = 772648705,
},
            new Int32Int32E0M
{
    Id = 32,
    Value = 1054496980,
    ModelInner = new Int32Int32E0MI
{
    Id = 39,
    Value = 1190657399,
    NullableValue = 1128475575,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 37,
    Value = 1791761137,
    ModelInner = new Int32Int32E0MI
{
    Id = 46,
    Value = 896721839,
    NullableValue = 566769389,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 38,
    Value = 635813131,
    ModelInner = new Int32Int32E0MI
{
    Id = 53,
    Value = 1944934844,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 44,
    Value = 963549342,
    ModelInner = new Int32Int32E0MI
{
    Id = 59,
    Value = 1269883848,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 50,
    Value = 1673244430,
    ModelInner = new Int32Int32E0MI
{
    Id = 66,
    Value = 949302468,
    NullableValue = null,
},
    NullableValue = 1839321674,
},
            new Int32Int32E0M
{
    Id = 53,
    Value = 664981808,
    ModelInner = new Int32Int32E0MI
{
    Id = 73,
    Value = 813968705,
    NullableValue = 1364289934,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 61,
    Value = 1051274023,
    ModelInner = new Int32Int32E0MI
{
    Id = 78,
    Value = 1606984361,
    NullableValue = 490877698,
},
    NullableValue = 963551469,
},
            new Int32Int32E0M
{
    Id = 69,
    Value = 1834263552,
    ModelInner = new Int32Int32E0MI
{
    Id = 85,
    Value = 2123836164,
    NullableValue = 1301608929,
},
    NullableValue = 108697731,
},
            new Int32Int32E0M
{
    Id = 71,
    Value = 235904793,
    ModelInner = new Int32Int32E0MI
{
    Id = 91,
    Value = 672700273,
    NullableValue = 1233429726,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 78,
    Value = 1199331267,
    ModelInner = new Int32Int32E0MI
{
    Id = 96,
    Value = 1187828683,
    NullableValue = 967216069,
},
    NullableValue = 1689725994,
},
            new Int32Int32E0M
{
    Id = 83,
    Value = 190765002,
    ModelInner = new Int32Int32E0MI
{
    Id = 97,
    Value = 1918624072,
    NullableValue = null,
},
    NullableValue = 1954432799,
},
            new Int32Int32E0M
{
    Id = 90,
    Value = 1965692845,
    ModelInner = new Int32Int32E0MI
{
    Id = 106,
    Value = 997746230,
    NullableValue = 1082185496,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 91,
    Value = 855989351,
    ModelInner = new Int32Int32E0MI
{
    Id = 109,
    Value = 1378249454,
    NullableValue = 630704317,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 94,
    Value = 1014269500,
    ModelInner = new Int32Int32E0MI
{
    Id = 113,
    Value = 2120182094,
    NullableValue = 1759458643,
},
    NullableValue = 1611364571,
},
            new Int32Int32E0M
{
    Id = 96,
    Value = 199476633,
    ModelInner = new Int32Int32E0MI
{
    Id = 120,
    Value = 582176842,
    NullableValue = 202830889,
},
    NullableValue = 1922610392,
},
            new Int32Int32E0M
{
    Id = 99,
    Value = 1775747767,
    ModelInner = new Int32Int32E0MI
{
    Id = 127,
    Value = 699361067,
    NullableValue = 558662942,
},
    NullableValue = 972205296,
},
            new Int32Int32E0M
{
    Id = 103,
    Value = 1553732315,
    ModelInner = new Int32Int32E0MI
{
    Id = 135,
    Value = 698358309,
    NullableValue = 1579910591,
},
    NullableValue = 1333354898,
},
            new Int32Int32E0M
{
    Id = 107,
    Value = 189106856,
    ModelInner = new Int32Int32E0MI
{
    Id = 138,
    Value = 1176980965,
    NullableValue = 1026990775,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 114,
    Value = 1395186765,
    ModelInner = new Int32Int32E0MI
{
    Id = 146,
    Value = 1726056252,
    NullableValue = null,
},
    NullableValue = 461036005,
},
            new Int32Int32E0M
{
    Id = 118,
    Value = 1259948788,
    ModelInner = new Int32Int32E0MI
{
    Id = 149,
    Value = 1300263711,
    NullableValue = 223325897,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 127,
    Value = 135803903,
    ModelInner = new Int32Int32E0MI
{
    Id = 154,
    Value = 72925552,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 133,
    Value = 1923736542,
    ModelInner = new Int32Int32E0MI
{
    Id = 155,
    Value = 230973885,
    NullableValue = 307890745,
},
    NullableValue = 1239735615,
},
            new Int32Int32E0M
{
    Id = 134,
    Value = 1463791037,
    ModelInner = new Int32Int32E0MI
{
    Id = 164,
    Value = 577541343,
    NullableValue = 1330455986,
},
    NullableValue = 2145931010,
},
            new Int32Int32E0M
{
    Id = 141,
    Value = 1667987568,
    ModelInner = new Int32Int32E0MI
{
    Id = 171,
    Value = 1759081029,
    NullableValue = 761455827,
},
    NullableValue = 2070762725,
},
            new Int32Int32E0M
{
    Id = 143,
    Value = 1276579832,
    ModelInner = new Int32Int32E0MI
{
    Id = 178,
    Value = 1021117618,
    NullableValue = 830683907,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 145,
    Value = 1557632898,
    ModelInner = new Int32Int32E0MI
{
    Id = 181,
    Value = 665457077,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 151,
    Value = 1981541688,
    ModelInner = new Int32Int32E0MI
{
    Id = 183,
    Value = 1981698381,
    NullableValue = 1695076263,
},
    NullableValue = 191320237,
},
            new Int32Int32E0M
{
    Id = 152,
    Value = 58543558,
    ModelInner = new Int32Int32E0MI
{
    Id = 192,
    Value = 1328314222,
    NullableValue = 840409193,
},
    NullableValue = null,
},
            new Int32Int32E0M
{
    Id = 160,
    Value = 93627819,
    ModelInner = new Int32Int32E0MI
{
    Id = 195,
    Value = 335557306,
    NullableValue = 501288620,
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

