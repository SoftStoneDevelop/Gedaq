

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
    Id = 6,
    Value = 1634694880,
    ModelInner = new Int32Int320MI
{
    Id = 9,
    Value = 1068809110,
    NullableValue = 429556000,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 15,
    Value = 1103375523,
    ModelInner = new Int32Int320MI
{
    Id = 14,
    Value = 52336985,
    NullableValue = 874724680,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 22,
    Value = 452818817,
    ModelInner = new Int32Int320MI
{
    Id = 20,
    Value = 336392124,
    NullableValue = null,
},
    NullableValue = 2014737044,
},
            new Int32Int320M
{
    Id = 28,
    Value = 879274391,
    ModelInner = new Int32Int320MI
{
    Id = 24,
    Value = 2117000793,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 31,
    Value = 1306240297,
    ModelInner = new Int32Int320MI
{
    Id = 32,
    Value = 1737976384,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 40,
    Value = 1556035095,
    ModelInner = new Int32Int320MI
{
    Id = 38,
    Value = 1913687500,
    NullableValue = null,
},
    NullableValue = 1256203794,
},
            new Int32Int320M
{
    Id = 45,
    Value = 436211076,
    ModelInner = new Int32Int320MI
{
    Id = 46,
    Value = 1515847371,
    NullableValue = 2146231910,
},
    NullableValue = 233199846,
},
            new Int32Int320M
{
    Id = 50,
    Value = 1979092767,
    ModelInner = new Int32Int320MI
{
    Id = 54,
    Value = 1446447345,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 52,
    Value = 427465951,
    ModelInner = new Int32Int320MI
{
    Id = 63,
    Value = 1714623322,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 54,
    Value = 1415102196,
    ModelInner = new Int32Int320MI
{
    Id = 70,
    Value = 1994335776,
    NullableValue = 1333435022,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 63,
    Value = 120970794,
    ModelInner = new Int32Int320MI
{
    Id = 77,
    Value = 1040200454,
    NullableValue = 127993478,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 69,
    Value = 845196450,
    ModelInner = new Int32Int320MI
{
    Id = 79,
    Value = 2037856460,
    NullableValue = 784793896,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 72,
    Value = 1108468019,
    ModelInner = new Int32Int320MI
{
    Id = 83,
    Value = 1628582011,
    NullableValue = 1343232696,
},
    NullableValue = 1611309997,
},
            new Int32Int320M
{
    Id = 78,
    Value = 237329566,
    ModelInner = new Int32Int320MI
{
    Id = 89,
    Value = 598068137,
    NullableValue = null,
},
    NullableValue = 204992910,
},
            new Int32Int320M
{
    Id = 86,
    Value = 1009068044,
    ModelInner = new Int32Int320MI
{
    Id = 94,
    Value = 533752877,
    NullableValue = null,
},
    NullableValue = 1518372162,
},
            new Int32Int320M
{
    Id = 93,
    Value = 695109579,
    ModelInner = new Int32Int320MI
{
    Id = 96,
    Value = 2054352133,
    NullableValue = 729585871,
},
    NullableValue = 223428029,
},
            new Int32Int320M
{
    Id = 102,
    Value = 1282516791,
    ModelInner = new Int32Int320MI
{
    Id = 97,
    Value = 1557270385,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 109,
    Value = 182048370,
    ModelInner = new Int32Int320MI
{
    Id = 98,
    Value = 1365913435,
    NullableValue = null,
},
    NullableValue = 13693285,
},
            new Int32Int320M
{
    Id = 117,
    Value = 1067965525,
    ModelInner = new Int32Int320MI
{
    Id = 101,
    Value = 459896471,
    NullableValue = null,
},
    NullableValue = 639908027,
},
            new Int32Int320M
{
    Id = 121,
    Value = 1827397290,
    ModelInner = new Int32Int320MI
{
    Id = 105,
    Value = 1923489946,
    NullableValue = null,
},
    NullableValue = 299473591,
},
            new Int32Int320M
{
    Id = 129,
    Value = 638510756,
    ModelInner = new Int32Int320MI
{
    Id = 110,
    Value = 1363648594,
    NullableValue = null,
},
    NullableValue = 406799513,
},
            new Int32Int320M
{
    Id = 131,
    Value = 1478529220,
    ModelInner = new Int32Int320MI
{
    Id = 113,
    Value = 1242335322,
    NullableValue = 2078455241,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 133,
    Value = 1567541315,
    ModelInner = new Int32Int320MI
{
    Id = 116,
    Value = 705706187,
    NullableValue = 823503932,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 137,
    Value = 684078680,
    ModelInner = new Int32Int320MI
{
    Id = 123,
    Value = 1503931906,
    NullableValue = 2033396053,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 140,
    Value = 475390363,
    ModelInner = new Int32Int320MI
{
    Id = 126,
    Value = 95671418,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 144,
    Value = 941340242,
    ModelInner = new Int32Int320MI
{
    Id = 130,
    Value = 716416624,
    NullableValue = 1286661404,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 146,
    Value = 978651003,
    ModelInner = new Int32Int320MI
{
    Id = 136,
    Value = 2123208886,
    NullableValue = 1196629470,
},
    NullableValue = 281419032,
},
            new Int32Int320M
{
    Id = 153,
    Value = 335958567,
    ModelInner = new Int32Int320MI
{
    Id = 137,
    Value = 997545970,
    NullableValue = null,
},
    NullableValue = 1200614699,
},
            new Int32Int320M
{
    Id = 158,
    Value = 2102933153,
    ModelInner = new Int32Int320MI
{
    Id = 140,
    Value = 1328636225,
    NullableValue = 1291397822,
},
    NullableValue = 1098247411,
},
            new Int32Int320M
{
    Id = 163,
    Value = 28710892,
    ModelInner = new Int32Int320MI
{
    Id = 143,
    Value = 318432354,
    NullableValue = 1505927799,
},
    NullableValue = 1392328526,
},
            new Int32Int320M
{
    Id = 166,
    Value = 1621391540,
    ModelInner = new Int32Int320MI
{
    Id = 146,
    Value = 1175983202,
    NullableValue = 1904326710,
},
    NullableValue = 50560334,
},
            new Int32Int320M
{
    Id = 173,
    Value = 1552888652,
    ModelInner = new Int32Int320MI
{
    Id = 150,
    Value = 2076543411,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 174,
    Value = 1819431681,
    ModelInner = new Int32Int320MI
{
    Id = 154,
    Value = 1334290729,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int32Int320M
{
    Id = 176,
    Value = 2047582558,
    ModelInner = new Int32Int320MI
{
    Id = 159,
    Value = 1099320299,
    NullableValue = 1161164871,
},
    NullableValue = 450236027,
},
            new Int32Int320M
{
    Id = 178,
    Value = 1846073980,
    ModelInner = new Int32Int320MI
{
    Id = 163,
    Value = 1817094050,
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

