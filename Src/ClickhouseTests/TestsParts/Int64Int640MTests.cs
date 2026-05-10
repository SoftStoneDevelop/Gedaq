

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

        private readonly Int64Int640M[] _testData = new Int64Int640M[]
        {
            new Int64Int640M
{
    Id = 6,
    Value = 493392678881536542L,
    ModelInner = new Int64Int640MI
{
    Id = 5,
    Value = 4356231931341391441L,
    NullableValue = 6149959113031735512L,
},
    NullableValue = 7609033218227177457L,
},
            new Int64Int640M
{
    Id = 9,
    Value = 7131866327923807200L,
    ModelInner = new Int64Int640MI
{
    Id = 8,
    Value = 5024882318854758554L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 15,
    Value = 9040009139061720499L,
    ModelInner = new Int64Int640MI
{
    Id = 14,
    Value = 7310883683253345963L,
    NullableValue = null,
},
    NullableValue = 7508344410850717877L,
},
            new Int64Int640M
{
    Id = 21,
    Value = 7266044561747481007L,
    ModelInner = new Int64Int640MI
{
    Id = 21,
    Value = 5782771484104335327L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 25,
    Value = 5454315985665936504L,
    ModelInner = new Int64Int640MI
{
    Id = 28,
    Value = 447956927962723983L,
    NullableValue = 5797157947377856816L,
},
    NullableValue = 6207288024053102L,
},
            new Int64Int640M
{
    Id = 27,
    Value = 5724996333180177693L,
    ModelInner = new Int64Int640MI
{
    Id = 32,
    Value = 8892505931184969822L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 28,
    Value = 8778163474503016848L,
    ModelInner = new Int64Int640MI
{
    Id = 38,
    Value = 8249961885285630931L,
    NullableValue = 8845982889818754464L,
},
    NullableValue = 5543770140575133882L,
},
            new Int64Int640M
{
    Id = 29,
    Value = 8844521624908749850L,
    ModelInner = new Int64Int640MI
{
    Id = 39,
    Value = 7800665898573042670L,
    NullableValue = null,
},
    NullableValue = 119496911798185887L,
},
            new Int64Int640M
{
    Id = 30,
    Value = 7296949269238954236L,
    ModelInner = new Int64Int640MI
{
    Id = 48,
    Value = 5248208752681420254L,
    NullableValue = null,
},
    NullableValue = 4766416095023026381L,
},
            new Int64Int640M
{
    Id = 34,
    Value = 7230970624485172566L,
    ModelInner = new Int64Int640MI
{
    Id = 51,
    Value = 4840054991940756868L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 36,
    Value = 1953537617479457430L,
    ModelInner = new Int64Int640MI
{
    Id = 55,
    Value = 6475939158259675383L,
    NullableValue = 7332381674218678691L,
},
    NullableValue = 154177857447424917L,
},
            new Int64Int640M
{
    Id = 45,
    Value = 463609266142699469L,
    ModelInner = new Int64Int640MI
{
    Id = 56,
    Value = 9120396219403278527L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 52,
    Value = 5387640930211870240L,
    ModelInner = new Int64Int640MI
{
    Id = 58,
    Value = 4586978845078440268L,
    NullableValue = 4412976523084325057L,
},
    NullableValue = 3538317783280455557L,
},
            new Int64Int640M
{
    Id = 61,
    Value = 8020612469447703174L,
    ModelInner = new Int64Int640MI
{
    Id = 66,
    Value = 5369221080003585524L,
    NullableValue = 4843468911324181396L,
},
    NullableValue = 2985711103818274862L,
},
            new Int64Int640M
{
    Id = 64,
    Value = 4342962585679337259L,
    ModelInner = new Int64Int640MI
{
    Id = 67,
    Value = 143038592200201861L,
    NullableValue = 7664385730562166706L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 67,
    Value = 7788116492290916669L,
    ModelInner = new Int64Int640MI
{
    Id = 71,
    Value = 9128169749552622542L,
    NullableValue = null,
},
    NullableValue = 6681387556571604058L,
},
            new Int64Int640M
{
    Id = 68,
    Value = 8683035032892443590L,
    ModelInner = new Int64Int640MI
{
    Id = 76,
    Value = 4417325045419069155L,
    NullableValue = null,
},
    NullableValue = 1178992707320296495L,
},
            new Int64Int640M
{
    Id = 72,
    Value = 4386281814416599418L,
    ModelInner = new Int64Int640MI
{
    Id = 79,
    Value = 5081343411616602887L,
    NullableValue = 9123092662707937534L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 81,
    Value = 2823250970226128772L,
    ModelInner = new Int64Int640MI
{
    Id = 82,
    Value = 3112133913591241303L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 88,
    Value = 6530755228714560944L,
    ModelInner = new Int64Int640MI
{
    Id = 86,
    Value = 2425234875533590310L,
    NullableValue = 660449929645887981L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 93,
    Value = 1492920649918010393L,
    ModelInner = new Int64Int640MI
{
    Id = 90,
    Value = 2297703927127698173L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 94,
    Value = 8028353533101947084L,
    ModelInner = new Int64Int640MI
{
    Id = 92,
    Value = 8471203632647712928L,
    NullableValue = 3108432124357337035L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 98,
    Value = 5423022505307553581L,
    ModelInner = new Int64Int640MI
{
    Id = 96,
    Value = 9218073584619026220L,
    NullableValue = 854381650352697736L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 99,
    Value = 7001901967606816730L,
    ModelInner = new Int64Int640MI
{
    Id = 104,
    Value = 9188097197683112850L,
    NullableValue = 4565182953929442348L,
},
    NullableValue = 2660252774166509004L,
},
            new Int64Int640M
{
    Id = 100,
    Value = 6288532887030409895L,
    ModelInner = new Int64Int640MI
{
    Id = 105,
    Value = 4017843428471587528L,
    NullableValue = 6457439103478979817L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 104,
    Value = 8863028802524819281L,
    ModelInner = new Int64Int640MI
{
    Id = 113,
    Value = 8862198777543201616L,
    NullableValue = 2027961836758261564L,
},
    NullableValue = 1529863850161910759L,
},
            new Int64Int640M
{
    Id = 105,
    Value = 3501131398129535410L,
    ModelInner = new Int64Int640MI
{
    Id = 119,
    Value = 1803700929878430572L,
    NullableValue = null,
},
    NullableValue = 5203736651960076556L,
},
            new Int64Int640M
{
    Id = 108,
    Value = 3596848383676074399L,
    ModelInner = new Int64Int640MI
{
    Id = 126,
    Value = 5831916452604638156L,
    NullableValue = 4234918985643168426L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 116,
    Value = 8364012439227435822L,
    ModelInner = new Int64Int640MI
{
    Id = 131,
    Value = 1220949582956661953L,
    NullableValue = 6946054017422294747L,
},
    NullableValue = 9096729922824015660L,
},
            new Int64Int640M
{
    Id = 118,
    Value = 6373646043423668238L,
    ModelInner = new Int64Int640MI
{
    Id = 140,
    Value = 6934025983686607275L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 122,
    Value = 8377516950875804203L,
    ModelInner = new Int64Int640MI
{
    Id = 145,
    Value = 5658350554481171226L,
    NullableValue = 5480407752238894848L,
},
    NullableValue = 1627753683543058564L,
},
            new Int64Int640M
{
    Id = 129,
    Value = 1876648170395737571L,
    ModelInner = new Int64Int640MI
{
    Id = 149,
    Value = 4048615755672269176L,
    NullableValue = 2998660566713707373L,
},
    NullableValue = 4182646660355033479L,
},
            new Int64Int640M
{
    Id = 131,
    Value = 1075357519350781644L,
    ModelInner = new Int64Int640MI
{
    Id = 151,
    Value = 5678301887952707676L,
    NullableValue = 1979330913331273458L,
},
    NullableValue = 3854816474778220841L,
},
            new Int64Int640M
{
    Id = 134,
    Value = 7957802381452372701L,
    ModelInner = new Int64Int640MI
{
    Id = 158,
    Value = 393246989149738358L,
    NullableValue = 7866423881060574941L,
},
    NullableValue = 2177477816096662531L,
},
            new Int64Int640M
{
    Id = 136,
    Value = 309086753617551300L,
    ModelInner = new Int64Int640MI
{
    Id = 159,
    Value = 7200844676639247406L,
    NullableValue = 772966511309005576L,
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
INSERT INTO gedaqtests.int64int640m(
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
FROM gedaqtests.int64int640m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(Int64Int640M)],
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
                    Int64Int640M.AssertModel(models[0],_testData[i], false);
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
                    Int64Int640M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

