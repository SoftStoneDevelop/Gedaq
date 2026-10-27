

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
    internal partial interface IUInt32SingleTypeUInt32
    {
    }
    
    internal partial class UInt32SingleTypeUInt32 : IUInt32SingleTypeUInt32
    {


#region TestData

        private readonly UInt32UInt32E0M[] _testData = new UInt32UInt32E0M[]
        {
            new UInt32UInt32E0M
{
    Id = 2,
    Value = 292030016,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 7,
    Value = 48541605,
    NullableValue = 1022007418,
},
    NullableValue = 1882562986,
},
            new UInt32UInt32E0M
{
    Id = 8,
    Value = 2103205397,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 8,
    Value = 274655926,
    NullableValue = null,
},
    NullableValue = 2531183495,
},
            new UInt32UInt32E0M
{
    Id = 11,
    Value = 2567093112,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 15,
    Value = 719315884,
    NullableValue = 1567934841,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 18,
    Value = 164075615,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 21,
    Value = 1751765534,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 22,
    Value = 2334966924,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 29,
    Value = 233068419,
    NullableValue = null,
},
    NullableValue = 397361182,
},
            new UInt32UInt32E0M
{
    Id = 25,
    Value = 906363475,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 37,
    Value = 2891828422,
    NullableValue = 2689159406,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 32,
    Value = 2969649626,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 40,
    Value = 2401499038,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 35,
    Value = 2025620450,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 46,
    Value = 2987268719,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 40,
    Value = 2654741384,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 50,
    Value = 2556747049,
    NullableValue = 2645408980,
},
    NullableValue = 3797742064,
},
            new UInt32UInt32E0M
{
    Id = 48,
    Value = 1296809267,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 56,
    Value = 1283212653,
    NullableValue = null,
},
    NullableValue = 3378710904,
},
            new UInt32UInt32E0M
{
    Id = 56,
    Value = 2714742601,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 64,
    Value = 2156168676,
    NullableValue = null,
},
    NullableValue = 296664600,
},
            new UInt32UInt32E0M
{
    Id = 59,
    Value = 3979981881,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 72,
    Value = 1987820923,
    NullableValue = null,
},
    NullableValue = 927392089,
},
            new UInt32UInt32E0M
{
    Id = 66,
    Value = 3454303060,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 74,
    Value = 2650318228,
    NullableValue = 3965119522,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 70,
    Value = 1955864142,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 79,
    Value = 1277046359,
    NullableValue = 1749064880,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 76,
    Value = 272399475,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 88,
    Value = 2750650892,
    NullableValue = null,
},
    NullableValue = 3992518448,
},
            new UInt32UInt32E0M
{
    Id = 83,
    Value = 1321091365,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 93,
    Value = 261228101,
    NullableValue = 972506109,
},
    NullableValue = 397587164,
},
            new UInt32UInt32E0M
{
    Id = 88,
    Value = 1438183923,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 100,
    Value = 1332440737,
    NullableValue = null,
},
    NullableValue = 3725093449,
},
            new UInt32UInt32E0M
{
    Id = 96,
    Value = 778788323,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 109,
    Value = 2567560920,
    NullableValue = 2734734011,
},
    NullableValue = 4252088290,
},
            new UInt32UInt32E0M
{
    Id = 104,
    Value = 1211845295,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 111,
    Value = 564246676,
    NullableValue = 3536517854,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 105,
    Value = 3887379965,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 116,
    Value = 1544096233,
    NullableValue = 1534725278,
},
    NullableValue = 2014150318,
},
            new UInt32UInt32E0M
{
    Id = 111,
    Value = 705497979,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 124,
    Value = 2185233209,
    NullableValue = 682569275,
},
    NullableValue = 1401693693,
},
            new UInt32UInt32E0M
{
    Id = 119,
    Value = 726083067,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 133,
    Value = 164932518,
    NullableValue = 265624875,
},
    NullableValue = 894816141,
},
            new UInt32UInt32E0M
{
    Id = 124,
    Value = 958531750,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 137,
    Value = 281698756,
    NullableValue = 908580735,
},
    NullableValue = 667021684,
},
            new UInt32UInt32E0M
{
    Id = 133,
    Value = 3173150298,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 145,
    Value = 669772625,
    NullableValue = 3726006771,
},
    NullableValue = 1488495307,
},
            new UInt32UInt32E0M
{
    Id = 142,
    Value = 50329477,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 149,
    Value = 83182535,
    NullableValue = null,
},
    NullableValue = 1432656999,
},
            new UInt32UInt32E0M
{
    Id = 148,
    Value = 2329092285,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 155,
    Value = 515799433,
    NullableValue = null,
},
    NullableValue = 1155599976,
},
            new UInt32UInt32E0M
{
    Id = 153,
    Value = 357776888,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 157,
    Value = 250092487,
    NullableValue = null,
},
    NullableValue = 71463732,
},
            new UInt32UInt32E0M
{
    Id = 157,
    Value = 1225981178,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 160,
    Value = 1402117983,
    NullableValue = null,
},
    NullableValue = 2470404884,
},
            new UInt32UInt32E0M
{
    Id = 161,
    Value = 795751252,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 163,
    Value = 2275256715,
    NullableValue = 3581398412,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 163,
    Value = 3804906438,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 171,
    Value = 2748658370,
    NullableValue = 2403901369,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 167,
    Value = 2011888944,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 172,
    Value = 547323158,
    NullableValue = null,
},
    NullableValue = 1774721474,
},
            new UInt32UInt32E0M
{
    Id = 168,
    Value = 4046550137,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 173,
    Value = 1016469176,
    NullableValue = 3798153138,
},
    NullableValue = 3343120853,
},
            new UInt32UInt32E0M
{
    Id = 177,
    Value = 4234901895,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 181,
    Value = 2820615711,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 181,
    Value = 1037007614,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 182,
    Value = 3995578605,
    NullableValue = 3678204390,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 188,
    Value = 984176074,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 189,
    Value = 196858283,
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
INSERT INTO gedaqtests.uint32uint32e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt32}, 
    {mi_id:Int32},
    {mi_value:UInt32}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt32), 
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
                    await ((IUInt32SingleTypeUInt32)this).InsertModelDbConnectionAsync(
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
                     ((IUInt32SingleTypeUInt32)this).InsertModelDbConnection(
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
FROM gedaqtests.uint32uint32e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt32UInt32E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt32SingleTypeUInt32)),
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
                    var models = await ((IUInt32SingleTypeUInt32)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt32SingleTypeUInt32)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt32UInt32E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

