

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
    internal partial interface IInt64SingleTypeInt64
    {
    }
    
    internal partial class Int64SingleTypeInt64 : IInt64SingleTypeInt64
    {


#region TestData

        private readonly Int64Int64E0M[] _testData = new Int64Int64E0M[]
        {
            new Int64Int64E0M
{
    Id = 6,
    Value = 4105020193119492147L,
    ModelInner = new Int64Int64E0MI
{
    Id = 6,
    Value = 3070168191465724272L,
    NullableValue = 7384471992403611068L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 12,
    Value = 7590247879656012306L,
    ModelInner = new Int64Int64E0MI
{
    Id = 9,
    Value = 1282595308693183429L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 17,
    Value = 3228645655313053670L,
    ModelInner = new Int64Int64E0MI
{
    Id = 13,
    Value = 8953064905524381366L,
    NullableValue = null,
},
    NullableValue = 4082674786247068953L,
},
            new Int64Int64E0M
{
    Id = 19,
    Value = 5669660811229315037L,
    ModelInner = new Int64Int64E0MI
{
    Id = 19,
    Value = 130990661963044139L,
    NullableValue = null,
},
    NullableValue = 1878553285416242653L,
},
            new Int64Int64E0M
{
    Id = 20,
    Value = 7370762676701502626L,
    ModelInner = new Int64Int64E0MI
{
    Id = 24,
    Value = 4775430271023883339L,
    NullableValue = null,
},
    NullableValue = 7562182838748887163L,
},
            new Int64Int64E0M
{
    Id = 25,
    Value = 8993697912374661711L,
    ModelInner = new Int64Int64E0MI
{
    Id = 33,
    Value = 542090640555164281L,
    NullableValue = 440330440215318836L,
},
    NullableValue = 7023743265882717343L,
},
            new Int64Int64E0M
{
    Id = 33,
    Value = 9006244097427145499L,
    ModelInner = new Int64Int64E0MI
{
    Id = 42,
    Value = 1318781209947517090L,
    NullableValue = null,
},
    NullableValue = 4208891759430930552L,
},
            new Int64Int64E0M
{
    Id = 36,
    Value = 1494832244251731507L,
    ModelInner = new Int64Int64E0MI
{
    Id = 45,
    Value = 8021408759250602971L,
    NullableValue = 6598381533168477321L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 41,
    Value = 572507070149763483L,
    ModelInner = new Int64Int64E0MI
{
    Id = 48,
    Value = 4356782780028244503L,
    NullableValue = 2750976260661838355L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 43,
    Value = 3268208094218504036L,
    ModelInner = new Int64Int64E0MI
{
    Id = 51,
    Value = 6394047994274070327L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 49,
    Value = 7825244911056823791L,
    ModelInner = new Int64Int64E0MI
{
    Id = 60,
    Value = 6842270349738879461L,
    NullableValue = 6587692560928202591L,
},
    NullableValue = 2369460964230402796L,
},
            new Int64Int64E0M
{
    Id = 57,
    Value = 1156599030310575785L,
    ModelInner = new Int64Int64E0MI
{
    Id = 66,
    Value = 246406225702327822L,
    NullableValue = 6117652008108270864L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 66,
    Value = 5456691959728294933L,
    ModelInner = new Int64Int64E0MI
{
    Id = 74,
    Value = 8777361976447107902L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 75,
    Value = 7827369984974795614L,
    ModelInner = new Int64Int64E0MI
{
    Id = 82,
    Value = 8434892964082781691L,
    NullableValue = null,
},
    NullableValue = 5874308111554993378L,
},
            new Int64Int64E0M
{
    Id = 76,
    Value = 2568026461213588469L,
    ModelInner = new Int64Int64E0MI
{
    Id = 88,
    Value = 4168243327641767946L,
    NullableValue = 4820770768088396993L,
},
    NullableValue = 9014833570752804736L,
},
            new Int64Int64E0M
{
    Id = 78,
    Value = 5666523910498342154L,
    ModelInner = new Int64Int64E0MI
{
    Id = 92,
    Value = 1275025879047151931L,
    NullableValue = 5506903612161705907L,
},
    NullableValue = 5601612773270409650L,
},
            new Int64Int64E0M
{
    Id = 87,
    Value = 3168245152435176816L,
    ModelInner = new Int64Int64E0MI
{
    Id = 101,
    Value = 4689473987019249713L,
    NullableValue = 7893095669787398589L,
},
    NullableValue = 6717275220877090077L,
},
            new Int64Int64E0M
{
    Id = 94,
    Value = 8584196383260285462L,
    ModelInner = new Int64Int64E0MI
{
    Id = 102,
    Value = 6825204799366467937L,
    NullableValue = null,
},
    NullableValue = 6334973504490711304L,
},
            new Int64Int64E0M
{
    Id = 103,
    Value = 9216348634829333115L,
    ModelInner = new Int64Int64E0MI
{
    Id = 110,
    Value = 9028296838487719370L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 112,
    Value = 6593788816416887408L,
    ModelInner = new Int64Int64E0MI
{
    Id = 118,
    Value = 4379888571651048533L,
    NullableValue = null,
},
    NullableValue = 560162770594772305L,
},
            new Int64Int64E0M
{
    Id = 121,
    Value = 7339073429762243856L,
    ModelInner = new Int64Int64E0MI
{
    Id = 126,
    Value = 3847711969927468207L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 125,
    Value = 2890761797466437863L,
    ModelInner = new Int64Int64E0MI
{
    Id = 131,
    Value = 7138853852762051049L,
    NullableValue = 7201905927435369371L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 132,
    Value = 2446604576788395423L,
    ModelInner = new Int64Int64E0MI
{
    Id = 134,
    Value = 4479054722147814847L,
    NullableValue = 6846322280664054161L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 136,
    Value = 1725297052484520739L,
    ModelInner = new Int64Int64E0MI
{
    Id = 142,
    Value = 7956351102319002138L,
    NullableValue = 2652956295943214352L,
},
    NullableValue = 6402779210473444436L,
},
            new Int64Int64E0M
{
    Id = 137,
    Value = 8670454380532622980L,
    ModelInner = new Int64Int64E0MI
{
    Id = 147,
    Value = 8279792133145122049L,
    NullableValue = null,
},
    NullableValue = 8552558755451640598L,
},
            new Int64Int64E0M
{
    Id = 145,
    Value = 3708615438265546449L,
    ModelInner = new Int64Int64E0MI
{
    Id = 156,
    Value = 3107050586891392956L,
    NullableValue = null,
},
    NullableValue = 6119028220701490952L,
},
            new Int64Int64E0M
{
    Id = 152,
    Value = 7513173122688257074L,
    ModelInner = new Int64Int64E0MI
{
    Id = 159,
    Value = 5135979502199413193L,
    NullableValue = null,
},
    NullableValue = 904406849116139225L,
},
            new Int64Int64E0M
{
    Id = 158,
    Value = 740611657612377340L,
    ModelInner = new Int64Int64E0MI
{
    Id = 161,
    Value = 244099188643977679L,
    NullableValue = 4916837366263019587L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 162,
    Value = 2020248910701323344L,
    ModelInner = new Int64Int64E0MI
{
    Id = 165,
    Value = 5900713142867392211L,
    NullableValue = null,
},
    NullableValue = 6847754809768708196L,
},
            new Int64Int64E0M
{
    Id = 166,
    Value = 7987714164842110768L,
    ModelInner = new Int64Int64E0MI
{
    Id = 167,
    Value = 8470994693932274761L,
    NullableValue = 4272233523137561065L,
},
    NullableValue = 7275930365367025368L,
},
            new Int64Int64E0M
{
    Id = 169,
    Value = 7910037266642759436L,
    ModelInner = new Int64Int64E0MI
{
    Id = 170,
    Value = 2551225258703452494L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 177,
    Value = 154780270794197102L,
    ModelInner = new Int64Int64E0MI
{
    Id = 175,
    Value = 6443850197213712126L,
    NullableValue = null,
},
    NullableValue = 7279499802231601409L,
},
            new Int64Int64E0M
{
    Id = 185,
    Value = 2819393982293262815L,
    ModelInner = new Int64Int64E0MI
{
    Id = 183,
    Value = 1912239080222545612L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 193,
    Value = 1606913434093429172L,
    ModelInner = new Int64Int64E0MI
{
    Id = 184,
    Value = 3152803338201636537L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 199,
    Value = 268399956695708868L,
    ModelInner = new Int64Int64E0MI
{
    Id = 193,
    Value = 5167801000718764379L,
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
INSERT INTO gedaqtests.int64int64e0m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Int64}, 
    {mi_id:Int32},
    {mi_value:Int64}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypeInt64)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int64), 
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
                    await ((IInt64SingleTypeInt64)this).InsertModelDbConnectionAsync(
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
                     ((IInt64SingleTypeInt64)this).InsertModelDbConnection(
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
FROM gedaqtests.int64int64e0m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64Int64E0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64SingleTypeInt64)),
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
                    var models = await ((IInt64SingleTypeInt64)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64Int64E0M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IInt64SingleTypeInt64)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    Int64Int64E0M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

