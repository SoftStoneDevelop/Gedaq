

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
    Value = 5857058111793930462L,
    ModelInner = new Int64Int64E0MI
{
    Id = 7,
    Value = 8040187835451708447L,
    NullableValue = 7123499074461970129L,
},
    NullableValue = 4274742924698131904L,
},
            new Int64Int64E0M
{
    Id = 11,
    Value = 7211650949375541706L,
    ModelInner = new Int64Int64E0MI
{
    Id = 13,
    Value = 4547865854698538963L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 15,
    Value = 4893471391349483265L,
    ModelInner = new Int64Int64E0MI
{
    Id = 14,
    Value = 8571937163480939122L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 22,
    Value = 3831197884129231567L,
    ModelInner = new Int64Int64E0MI
{
    Id = 21,
    Value = 7736915178655179373L,
    NullableValue = null,
},
    NullableValue = 1594654296027249214L,
},
            new Int64Int64E0M
{
    Id = 29,
    Value = 1033488426391507131L,
    ModelInner = new Int64Int64E0MI
{
    Id = 23,
    Value = 7666571140746494523L,
    NullableValue = 4749209709296336407L,
},
    NullableValue = 7234213319721553788L,
},
            new Int64Int64E0M
{
    Id = 33,
    Value = 4725515010510404977L,
    ModelInner = new Int64Int64E0MI
{
    Id = 24,
    Value = 7635542758048068073L,
    NullableValue = 2678649829458494256L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 42,
    Value = 1802868227285898215L,
    ModelInner = new Int64Int64E0MI
{
    Id = 33,
    Value = 5854093629730024986L,
    NullableValue = 5615196794270990852L,
},
    NullableValue = 659274020888529559L,
},
            new Int64Int64E0M
{
    Id = 47,
    Value = 5140041791013268844L,
    ModelInner = new Int64Int64E0MI
{
    Id = 38,
    Value = 829808384233867265L,
    NullableValue = 2286362398489321445L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 56,
    Value = 4406636275631464332L,
    ModelInner = new Int64Int64E0MI
{
    Id = 44,
    Value = 6350650383774747790L,
    NullableValue = null,
},
    NullableValue = 5323313945022925268L,
},
            new Int64Int64E0M
{
    Id = 60,
    Value = 6854497642760438410L,
    ModelInner = new Int64Int64E0MI
{
    Id = 49,
    Value = 8542316044116170851L,
    NullableValue = 736132687948340006L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 62,
    Value = 1308461369068505500L,
    ModelInner = new Int64Int64E0MI
{
    Id = 50,
    Value = 9015167279932718031L,
    NullableValue = 7258424620886885874L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 66,
    Value = 4829160300933047480L,
    ModelInner = new Int64Int64E0MI
{
    Id = 51,
    Value = 6362107914715143805L,
    NullableValue = 1345005316620294575L,
},
    NullableValue = 1747987585845604026L,
},
            new Int64Int64E0M
{
    Id = 68,
    Value = 7582302093781676293L,
    ModelInner = new Int64Int64E0MI
{
    Id = 58,
    Value = 5418098769954712618L,
    NullableValue = 73749041524746503L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 69,
    Value = 2042490812677485379L,
    ModelInner = new Int64Int64E0MI
{
    Id = 63,
    Value = 3195230966860522224L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 73,
    Value = 4440500369409644049L,
    ModelInner = new Int64Int64E0MI
{
    Id = 67,
    Value = 8716496467176812872L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 75,
    Value = 2006702873490935460L,
    ModelInner = new Int64Int64E0MI
{
    Id = 74,
    Value = 9122653598066456045L,
    NullableValue = 1347037047533906719L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 79,
    Value = 382496803045410307L,
    ModelInner = new Int64Int64E0MI
{
    Id = 76,
    Value = 2918256475862638969L,
    NullableValue = 6761040197633046006L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 86,
    Value = 6954527044723121102L,
    ModelInner = new Int64Int64E0MI
{
    Id = 78,
    Value = 5935266262509227927L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 87,
    Value = 2192222954731170996L,
    ModelInner = new Int64Int64E0MI
{
    Id = 87,
    Value = 6437378211270890392L,
    NullableValue = 7170347373868500371L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 93,
    Value = 5259319750069546746L,
    ModelInner = new Int64Int64E0MI
{
    Id = 90,
    Value = 3332315567903859723L,
    NullableValue = null,
},
    NullableValue = 4037193322885400091L,
},
            new Int64Int64E0M
{
    Id = 97,
    Value = 6332826863157069519L,
    ModelInner = new Int64Int64E0MI
{
    Id = 94,
    Value = 2274288494622770247L,
    NullableValue = 5078468107254023421L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 98,
    Value = 5195699518804368485L,
    ModelInner = new Int64Int64E0MI
{
    Id = 96,
    Value = 6638862599359173944L,
    NullableValue = null,
},
    NullableValue = 17975241543124730L,
},
            new Int64Int64E0M
{
    Id = 101,
    Value = 2439329510098485912L,
    ModelInner = new Int64Int64E0MI
{
    Id = 101,
    Value = 8419137227148152065L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 110,
    Value = 4726293659855465978L,
    ModelInner = new Int64Int64E0MI
{
    Id = 103,
    Value = 183864003891878869L,
    NullableValue = 2593117808599581342L,
},
    NullableValue = 6543528138195165706L,
},
            new Int64Int64E0M
{
    Id = 111,
    Value = 4747856980140243754L,
    ModelInner = new Int64Int64E0MI
{
    Id = 110,
    Value = 4155058599916362082L,
    NullableValue = 3117692949726927516L,
},
    NullableValue = 6060368581754784394L,
},
            new Int64Int64E0M
{
    Id = 116,
    Value = 132678260644218714L,
    ModelInner = new Int64Int64E0MI
{
    Id = 112,
    Value = 2702999873445022795L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 121,
    Value = 6960718186165550663L,
    ModelInner = new Int64Int64E0MI
{
    Id = 117,
    Value = 7310345113720299358L,
    NullableValue = null,
},
    NullableValue = 1651659288635209078L,
},
            new Int64Int64E0M
{
    Id = 130,
    Value = 2999981241384788976L,
    ModelInner = new Int64Int64E0MI
{
    Id = 125,
    Value = 2454949510121120847L,
    NullableValue = 8704545722411529726L,
},
    NullableValue = 2351921296421297035L,
},
            new Int64Int64E0M
{
    Id = 139,
    Value = 8166874400741598055L,
    ModelInner = new Int64Int64E0MI
{
    Id = 133,
    Value = 3493222211127256444L,
    NullableValue = null,
},
    NullableValue = 4416601804738728492L,
},
            new Int64Int64E0M
{
    Id = 143,
    Value = 12707984137015772L,
    ModelInner = new Int64Int64E0MI
{
    Id = 142,
    Value = 3664084621288593554L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 146,
    Value = 3006258208330157270L,
    ModelInner = new Int64Int64E0MI
{
    Id = 145,
    Value = 4793198392481542502L,
    NullableValue = null,
},
    NullableValue = 9188902354403004979L,
},
            new Int64Int64E0M
{
    Id = 152,
    Value = 5354661105228484593L,
    ModelInner = new Int64Int64E0MI
{
    Id = 146,
    Value = 8697364682032209228L,
    NullableValue = null,
},
    NullableValue = 4733450444830580767L,
},
            new Int64Int64E0M
{
    Id = 153,
    Value = 6305077069699095176L,
    ModelInner = new Int64Int64E0MI
{
    Id = 148,
    Value = 1742012129075107249L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 162,
    Value = 6824248238380957600L,
    ModelInner = new Int64Int64E0MI
{
    Id = 153,
    Value = 4836096538342988928L,
    NullableValue = null,
},
    NullableValue = 1742211205572912102L,
},
            new Int64Int64E0M
{
    Id = 169,
    Value = 594464397016575917L,
    ModelInner = new Int64Int64E0MI
{
    Id = 155,
    Value = 3029815386291781306L,
    NullableValue = 8771124205857564367L,
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

