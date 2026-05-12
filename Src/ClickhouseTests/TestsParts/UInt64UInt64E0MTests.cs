

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
    internal partial interface IUInt64SingleTypeUInt64
    {
    }
    
    internal partial class UInt64SingleTypeUInt64 : IUInt64SingleTypeUInt64
    {


#region TestData

        private readonly UInt64UInt64E0M[] _testData = new UInt64UInt64E0M[]
        {
            new UInt64UInt64E0M
{
    Id = 8,
    Value = 4882728907866149976L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 6,
    Value = 4073800960833780921L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 11,
    Value = 4823297636852338821L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 12,
    Value = 4128662624287343018L,
    NullableValue = 5721750269729433197L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 12,
    Value = 460691668877022936L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 14,
    Value = 8098609674819293158L,
    NullableValue = 638339763004406807L,
},
    NullableValue = 849236042088211123L,
},
            new UInt64UInt64E0M
{
    Id = 21,
    Value = 4077890707678168225L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 15,
    Value = 1048556258655697792L,
    NullableValue = 2963601514191496063L,
},
    NullableValue = 4184196951202171769L,
},
            new UInt64UInt64E0M
{
    Id = 22,
    Value = 1321770051893760333L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 19,
    Value = 8209235454312448712L,
    NullableValue = null,
},
    NullableValue = 7700471372362487529L,
},
            new UInt64UInt64E0M
{
    Id = 31,
    Value = 4857520971535215619L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 27,
    Value = 1540985238003963729L,
    NullableValue = 1375126833974069698L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 36,
    Value = 6808143331064162867L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 28,
    Value = 9175501501425015856L,
    NullableValue = 7958536933806594208L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 43,
    Value = 5040947859731246820L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 35,
    Value = 2247726798621457616L,
    NullableValue = 4210489672938591298L,
},
    NullableValue = 3750445565376086640L,
},
            new UInt64UInt64E0M
{
    Id = 44,
    Value = 147053061255449306L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 40,
    Value = 8545037743698850863L,
    NullableValue = 5598004247969583474L,
},
    NullableValue = 767771046925687864L,
},
            new UInt64UInt64E0M
{
    Id = 52,
    Value = 1236516043631982194L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 47,
    Value = 2766643366804053289L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 59,
    Value = 2462818060041684525L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 48,
    Value = 1416093343544478572L,
    NullableValue = null,
},
    NullableValue = 1335747644892277231L,
},
            new UInt64UInt64E0M
{
    Id = 65,
    Value = 991472621167836067L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 49,
    Value = 8272072049307311290L,
    NullableValue = 6384431485976276335L,
},
    NullableValue = 797768949111710935L,
},
            new UInt64UInt64E0M
{
    Id = 69,
    Value = 3732641887852877239L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 57,
    Value = 3538842905132373388L,
    NullableValue = 1974810659542954949L,
},
    NullableValue = 6477850907022813944L,
},
            new UInt64UInt64E0M
{
    Id = 74,
    Value = 5058471713674185305L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 64,
    Value = 6235638279002214261L,
    NullableValue = 3640476382771870946L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 76,
    Value = 523545928477308616L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 73,
    Value = 2776590844924620475L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 84,
    Value = 8506850938671889726L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 80,
    Value = 556886179726584137L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 89,
    Value = 6627476093489189827L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 88,
    Value = 3946957760558272081L,
    NullableValue = 6622853864280999040L,
},
    NullableValue = 3256902804853832359L,
},
            new UInt64UInt64E0M
{
    Id = 90,
    Value = 782053330854639120L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 96,
    Value = 6447268928602843355L,
    NullableValue = null,
},
    NullableValue = 6299429295311780535L,
},
            new UInt64UInt64E0M
{
    Id = 98,
    Value = 6434940814111829691L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 101,
    Value = 4290325342930674360L,
    NullableValue = 2811931263696208760L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 99,
    Value = 1717456005993952705L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 102,
    Value = 4118970909308123478L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 106,
    Value = 7230727417398184849L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 111,
    Value = 8774696720675770017L,
    NullableValue = null,
},
    NullableValue = 2875732804793262653L,
},
            new UInt64UInt64E0M
{
    Id = 113,
    Value = 844655257798471333L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 114,
    Value = 3404696216176472292L,
    NullableValue = 6628123742938475923L,
},
    NullableValue = 6220357960262662572L,
},
            new UInt64UInt64E0M
{
    Id = 120,
    Value = 4076413953125381995L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 123,
    Value = 8070994403240775698L,
    NullableValue = 7854477929602929852L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 127,
    Value = 8498019093897863625L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 126,
    Value = 5664808381539177623L,
    NullableValue = null,
},
    NullableValue = 5608369192196717670L,
},
            new UInt64UInt64E0M
{
    Id = 130,
    Value = 1585222779264644783L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 132,
    Value = 4841916370207306422L,
    NullableValue = null,
},
    NullableValue = 1790633939599789490L,
},
            new UInt64UInt64E0M
{
    Id = 133,
    Value = 7155511697441872209L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 138,
    Value = 1670338752125424801L,
    NullableValue = null,
},
    NullableValue = 2348794027894110847L,
},
            new UInt64UInt64E0M
{
    Id = 142,
    Value = 5754816739880976640L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 140,
    Value = 6579002222184484374L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 147,
    Value = 7712851223131733457L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 144,
    Value = 6840723710863971380L,
    NullableValue = null,
},
    NullableValue = 5736117564618267985L,
},
            new UInt64UInt64E0M
{
    Id = 152,
    Value = 8946054613150871762L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 151,
    Value = 5442061975609209887L,
    NullableValue = null,
},
    NullableValue = 5256318468824986186L,
},
            new UInt64UInt64E0M
{
    Id = 153,
    Value = 2284452057375345622L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 153,
    Value = 7710815948087701195L,
    NullableValue = 5558986124387491923L,
},
    NullableValue = 6547498966770304127L,
},
            new UInt64UInt64E0M
{
    Id = 159,
    Value = 8405057297467933913L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 156,
    Value = 8073433047993529340L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 164,
    Value = 5145461519460548860L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 161,
    Value = 8986102371348455744L,
    NullableValue = 2419000156711466837L,
},
    NullableValue = 6473359158835194401L,
},
            new UInt64UInt64E0M
{
    Id = 166,
    Value = 8835018155070457848L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 170,
    Value = 83104418453250695L,
    NullableValue = null,
},
    NullableValue = 6900759596692396510L,
},
            new UInt64UInt64E0M
{
    Id = 169,
    Value = 8686095452338448003L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 179,
    Value = 1591781363793215214L,
    NullableValue = null,
},
    NullableValue = 8008957735251043566L,
},
            new UInt64UInt64E0M
{
    Id = 177,
    Value = 3424743168475805630L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 185,
    Value = 5642678704356724821L,
    NullableValue = 2912516027035033569L,
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
INSERT INTO gedaqtests.uint64uint64e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UInt64}, 
    {mi_id:Int32},
    {mi_value:UInt64}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypeUInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64), 
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
                    await ((IUInt64SingleTypeUInt64)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64SingleTypeUInt64)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64uint64e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64UInt64E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64SingleTypeUInt64)),
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
                    var models = await ((IUInt64SingleTypeUInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt64E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64SingleTypeUInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64UInt64E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

