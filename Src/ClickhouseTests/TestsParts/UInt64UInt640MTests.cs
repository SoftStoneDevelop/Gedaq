

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

        private readonly UInt64UInt640M[] _testData = new UInt64UInt640M[]
        {
            new UInt64UInt640M
{
    Id = 7,
    Value = 2157529274681482237L,
    ModelInner = new UInt64UInt640MI
{
    Id = 7,
    Value = 5840326735311785755L,
    NullableValue = 85129654291372803L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 16,
    Value = 3944419653229088835L,
    ModelInner = new UInt64UInt640MI
{
    Id = 11,
    Value = 8073901269108917866L,
    NullableValue = null,
},
    NullableValue = 4228421150583456512L,
},
            new UInt64UInt640M
{
    Id = 21,
    Value = 1688196009093905114L,
    ModelInner = new UInt64UInt640MI
{
    Id = 14,
    Value = 834588160993961165L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 28,
    Value = 2048248240094276890L,
    ModelInner = new UInt64UInt640MI
{
    Id = 18,
    Value = 9069234082317405786L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 30,
    Value = 8589248191016316626L,
    ModelInner = new UInt64UInt640MI
{
    Id = 24,
    Value = 7464205439157854692L,
    NullableValue = 1964881503435351339L,
},
    NullableValue = 8815546843844863670L,
},
            new UInt64UInt640M
{
    Id = 37,
    Value = 5705905649490043653L,
    ModelInner = new UInt64UInt640MI
{
    Id = 32,
    Value = 6104197303024449255L,
    NullableValue = null,
},
    NullableValue = 6727130318282719265L,
},
            new UInt64UInt640M
{
    Id = 42,
    Value = 8960450532530572638L,
    ModelInner = new UInt64UInt640MI
{
    Id = 38,
    Value = 670124496293404398L,
    NullableValue = 4038890767864832527L,
},
    NullableValue = 7089423754816203110L,
},
            new UInt64UInt640M
{
    Id = 48,
    Value = 1808845844141154294L,
    ModelInner = new UInt64UInt640MI
{
    Id = 40,
    Value = 2696722453184849594L,
    NullableValue = 7837476913260081784L,
},
    NullableValue = 314401510532809688L,
},
            new UInt64UInt640M
{
    Id = 57,
    Value = 2779564524408214816L,
    ModelInner = new UInt64UInt640MI
{
    Id = 46,
    Value = 654362200874830818L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 61,
    Value = 9045751820989337452L,
    ModelInner = new UInt64UInt640MI
{
    Id = 52,
    Value = 8526894294973283097L,
    NullableValue = 768908522827579449L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 68,
    Value = 4457957986718275958L,
    ModelInner = new UInt64UInt640MI
{
    Id = 56,
    Value = 7470506076720107005L,
    NullableValue = null,
},
    NullableValue = 874620018795253563L,
},
            new UInt64UInt640M
{
    Id = 75,
    Value = 3479565696107393396L,
    ModelInner = new UInt64UInt640MI
{
    Id = 60,
    Value = 2913811301933400138L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 84,
    Value = 5196922778114149756L,
    ModelInner = new UInt64UInt640MI
{
    Id = 61,
    Value = 4753838243467036340L,
    NullableValue = null,
},
    NullableValue = 3311613084427717130L,
},
            new UInt64UInt640M
{
    Id = 85,
    Value = 2501506580684995207L,
    ModelInner = new UInt64UInt640MI
{
    Id = 69,
    Value = 5520739614507333701L,
    NullableValue = null,
},
    NullableValue = 9098264551291731791L,
},
            new UInt64UInt640M
{
    Id = 89,
    Value = 9039145022211183067L,
    ModelInner = new UInt64UInt640MI
{
    Id = 73,
    Value = 5366014243324731677L,
    NullableValue = 828984534156408694L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 90,
    Value = 851026120702943291L,
    ModelInner = new UInt64UInt640MI
{
    Id = 80,
    Value = 225824837529676274L,
    NullableValue = 3113709505805004301L,
},
    NullableValue = 6623606388445580284L,
},
            new UInt64UInt640M
{
    Id = 98,
    Value = 5382453722187678181L,
    ModelInner = new UInt64UInt640MI
{
    Id = 88,
    Value = 6074177723455194955L,
    NullableValue = null,
},
    NullableValue = 6651777818368961772L,
},
            new UInt64UInt640M
{
    Id = 104,
    Value = 8633786683722664651L,
    ModelInner = new UInt64UInt640MI
{
    Id = 97,
    Value = 9033264541453451062L,
    NullableValue = 5089799850519401094L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 110,
    Value = 1561349268210251715L,
    ModelInner = new UInt64UInt640MI
{
    Id = 102,
    Value = 4651817169596791616L,
    NullableValue = 1974448605069979000L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 118,
    Value = 1823675596525097963L,
    ModelInner = new UInt64UInt640MI
{
    Id = 103,
    Value = 6453124862865308626L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 119,
    Value = 6357838543788246078L,
    ModelInner = new UInt64UInt640MI
{
    Id = 104,
    Value = 1014483617518057382L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 125,
    Value = 2023582243494028833L,
    ModelInner = new UInt64UInt640MI
{
    Id = 106,
    Value = 275379659263024711L,
    NullableValue = null,
},
    NullableValue = 4617974234969142120L,
},
            new UInt64UInt640M
{
    Id = 134,
    Value = 257969846717150202L,
    ModelInner = new UInt64UInt640MI
{
    Id = 111,
    Value = 1939501018127558984L,
    NullableValue = null,
},
    NullableValue = 315417878784112331L,
},
            new UInt64UInt640M
{
    Id = 139,
    Value = 2243368979699763482L,
    ModelInner = new UInt64UInt640MI
{
    Id = 112,
    Value = 1282190114273905305L,
    NullableValue = 3694511851053382425L,
},
    NullableValue = 8744430237364348212L,
},
            new UInt64UInt640M
{
    Id = 145,
    Value = 7241228926841889825L,
    ModelInner = new UInt64UInt640MI
{
    Id = 116,
    Value = 3761777542150649122L,
    NullableValue = 1518504334342056924L,
},
    NullableValue = 5854543965647200830L,
},
            new UInt64UInt640M
{
    Id = 152,
    Value = 2776747772599732075L,
    ModelInner = new UInt64UInt640MI
{
    Id = 125,
    Value = 6118170519346479527L,
    NullableValue = null,
},
    NullableValue = 6906501515447188155L,
},
            new UInt64UInt640M
{
    Id = 156,
    Value = 9010264860912561790L,
    ModelInner = new UInt64UInt640MI
{
    Id = 134,
    Value = 4908295010403225549L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 157,
    Value = 4148269142545062021L,
    ModelInner = new UInt64UInt640MI
{
    Id = 137,
    Value = 5008618826514690453L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 160,
    Value = 6297368597293001032L,
    ModelInner = new UInt64UInt640MI
{
    Id = 144,
    Value = 4600975404277008386L,
    NullableValue = null,
},
    NullableValue = 3392396244780097360L,
},
            new UInt64UInt640M
{
    Id = 167,
    Value = 7927048770651033251L,
    ModelInner = new UInt64UInt640MI
{
    Id = 151,
    Value = 31712236732122492L,
    NullableValue = 4950437151289474754L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 175,
    Value = 8741973479349923165L,
    ModelInner = new UInt64UInt640MI
{
    Id = 160,
    Value = 1471748395145497825L,
    NullableValue = null,
},
    NullableValue = 69189579010407287L,
},
            new UInt64UInt640M
{
    Id = 178,
    Value = 3416643947520393784L,
    ModelInner = new UInt64UInt640MI
{
    Id = 169,
    Value = 521408468558720204L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 183,
    Value = 9014400508590503281L,
    ModelInner = new UInt64UInt640MI
{
    Id = 178,
    Value = 2855004210136722649L,
    NullableValue = 6639724711666233052L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 189,
    Value = 7486282424321825930L,
    ModelInner = new UInt64UInt640MI
{
    Id = 183,
    Value = 381078691550567135L,
    NullableValue = null,
},
    NullableValue = 4396111019162079528L,
},
            new UInt64UInt640M
{
    Id = 198,
    Value = 3552461834757134283L,
    ModelInner = new UInt64UInt640MI
{
    Id = 190,
    Value = 2520201470482496344L,
    NullableValue = null,
},
    NullableValue = 9026522269597556276L,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64uint640m(
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
FROM gedaqtests.uint64uint640m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64UInt640M)],
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
                    UInt64UInt640M.AssertModel(models[0],_testData[i], false);
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
                    UInt64UInt640M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

