

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
    Id = 8,
    Value = 1538400669,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 6,
    Value = 287006361,
    NullableValue = null,
},
    NullableValue = 313277723,
},
            new UInt32UInt32E0M
{
    Id = 15,
    Value = 724234586,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 10,
    Value = 2943457600,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 17,
    Value = 4120804362,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 19,
    Value = 2142261344,
    NullableValue = 2093890730,
},
    NullableValue = 1168285459,
},
            new UInt32UInt32E0M
{
    Id = 25,
    Value = 3963209063,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 26,
    Value = 523560784,
    NullableValue = 3124865047,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 31,
    Value = 1084006704,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 28,
    Value = 3218036681,
    NullableValue = 627525720,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 34,
    Value = 1387582012,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 29,
    Value = 3892433732,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 35,
    Value = 1839503074,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 36,
    Value = 3378643407,
    NullableValue = 572557238,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 38,
    Value = 4132114746,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 45,
    Value = 415609931,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 43,
    Value = 2906524395,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 52,
    Value = 2712373007,
    NullableValue = 2169491472,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 46,
    Value = 1230773950,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 55,
    Value = 3862287989,
    NullableValue = null,
},
    NullableValue = 2828776288,
},
            new UInt32UInt32E0M
{
    Id = 50,
    Value = 555379186,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 59,
    Value = 2735587129,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 59,
    Value = 3314851070,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 67,
    Value = 110255524,
    NullableValue = null,
},
    NullableValue = 3128428269,
},
            new UInt32UInt32E0M
{
    Id = 60,
    Value = 1409048473,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 69,
    Value = 3060162989,
    NullableValue = 4274168314,
},
    NullableValue = 7792418,
},
            new UInt32UInt32E0M
{
    Id = 63,
    Value = 2752968221,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 74,
    Value = 1210675883,
    NullableValue = null,
},
    NullableValue = 142669656,
},
            new UInt32UInt32E0M
{
    Id = 66,
    Value = 1097022533,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 80,
    Value = 3671108239,
    NullableValue = 3518307432,
},
    NullableValue = 1725746360,
},
            new UInt32UInt32E0M
{
    Id = 68,
    Value = 1992207811,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 84,
    Value = 3091040526,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 69,
    Value = 2647945503,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 87,
    Value = 2200476891,
    NullableValue = null,
},
    NullableValue = 1385593176,
},
            new UInt32UInt32E0M
{
    Id = 70,
    Value = 878705422,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 95,
    Value = 1405396010,
    NullableValue = 4267602765,
},
    NullableValue = 1772449878,
},
            new UInt32UInt32E0M
{
    Id = 72,
    Value = 3928146914,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 96,
    Value = 3135295853,
    NullableValue = 2898419754,
},
    NullableValue = 2890329882,
},
            new UInt32UInt32E0M
{
    Id = 77,
    Value = 1278853908,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 105,
    Value = 1055076492,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 82,
    Value = 3850097608,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 110,
    Value = 2824373648,
    NullableValue = 3121621423,
},
    NullableValue = 1627861781,
},
            new UInt32UInt32E0M
{
    Id = 90,
    Value = 1803040691,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 112,
    Value = 4090194608,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 96,
    Value = 616300169,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 121,
    Value = 135969768,
    NullableValue = null,
},
    NullableValue = 2312195536,
},
            new UInt32UInt32E0M
{
    Id = 105,
    Value = 2724309123,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 125,
    Value = 3537922891,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 114,
    Value = 2790212886,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 128,
    Value = 4135332539,
    NullableValue = 2021824599,
},
    NullableValue = 1503625189,
},
            new UInt32UInt32E0M
{
    Id = 116,
    Value = 1508502956,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 137,
    Value = 2586593288,
    NullableValue = 1151004137,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 118,
    Value = 825387140,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 139,
    Value = 1622375709,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 121,
    Value = 3335481520,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 147,
    Value = 2996600523,
    NullableValue = 3202803174,
},
    NullableValue = 3370095084,
},
            new UInt32UInt32E0M
{
    Id = 125,
    Value = 2541419715,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 153,
    Value = 2524101018,
    NullableValue = null,
},
    NullableValue = 544482327,
},
            new UInt32UInt32E0M
{
    Id = 127,
    Value = 1738081476,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 160,
    Value = 549743563,
    NullableValue = null,
},
    NullableValue = 3419676882,
},
            new UInt32UInt32E0M
{
    Id = 135,
    Value = 1570292690,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 164,
    Value = 1507730773,
    NullableValue = 3900957816,
},
    NullableValue = 1891413169,
},
            new UInt32UInt32E0M
{
    Id = 139,
    Value = 3512989689,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 165,
    Value = 96721134,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 144,
    Value = 660282278,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 173,
    Value = 1228792003,
    NullableValue = 2581785297,
},
    NullableValue = null,
},
            new UInt32UInt32E0M
{
    Id = 153,
    Value = 1221080161,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 180,
    Value = 3202757340,
    NullableValue = 821549648,
},
    NullableValue = 1641980864,
},
            new UInt32UInt32E0M
{
    Id = 161,
    Value = 3359599209,
    ModelInner = new UInt32UInt32E0MI
{
    Id = 181,
    Value = 3626838230,
    NullableValue = 422034182,
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

