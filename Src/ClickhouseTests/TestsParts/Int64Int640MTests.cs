

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
    Id = 9,
    Value = 7726070677168020968L,
    ModelInner = new Int64Int640MI
{
    Id = 6,
    Value = 907864927922036305L,
    NullableValue = null,
},
    NullableValue = 215949840550866345L,
},
            new Int64Int640M
{
    Id = 16,
    Value = 8134688590388836654L,
    ModelInner = new Int64Int640MI
{
    Id = 14,
    Value = 7177364120450087843L,
    NullableValue = 2044168844525758483L,
},
    NullableValue = 3487758666308668872L,
},
            new Int64Int640M
{
    Id = 25,
    Value = 1572610601408514318L,
    ModelInner = new Int64Int640MI
{
    Id = 15,
    Value = 5586954552060043130L,
    NullableValue = 7472056289214371216L,
},
    NullableValue = 1740014628033671308L,
},
            new Int64Int640M
{
    Id = 27,
    Value = 8114406932549191383L,
    ModelInner = new Int64Int640MI
{
    Id = 24,
    Value = 7561437004264707182L,
    NullableValue = 7353168596838043095L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 34,
    Value = 8993397006728660997L,
    ModelInner = new Int64Int640MI
{
    Id = 31,
    Value = 2507967890188171163L,
    NullableValue = 9108459895434457871L,
},
    NullableValue = 8809813865397862660L,
},
            new Int64Int640M
{
    Id = 42,
    Value = 8938386579242897799L,
    ModelInner = new Int64Int640MI
{
    Id = 40,
    Value = 8655282270280166121L,
    NullableValue = 3985386420067166500L,
},
    NullableValue = 5150126155700296435L,
},
            new Int64Int640M
{
    Id = 48,
    Value = 614171633694612486L,
    ModelInner = new Int64Int640MI
{
    Id = 41,
    Value = 234958232693522242L,
    NullableValue = 8365536163365544278L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 49,
    Value = 4052018053142662409L,
    ModelInner = new Int64Int640MI
{
    Id = 44,
    Value = 7704841255394227381L,
    NullableValue = null,
},
    NullableValue = 2990821868465853413L,
},
            new Int64Int640M
{
    Id = 52,
    Value = 5398100232235102895L,
    ModelInner = new Int64Int640MI
{
    Id = 46,
    Value = 6555331903123238744L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 56,
    Value = 4285024604049729100L,
    ModelInner = new Int64Int640MI
{
    Id = 49,
    Value = 208487557365438386L,
    NullableValue = 2852823019320054532L,
},
    NullableValue = 42413588097516192L,
},
            new Int64Int640M
{
    Id = 64,
    Value = 8610630704898597890L,
    ModelInner = new Int64Int640MI
{
    Id = 54,
    Value = 4914502367427248906L,
    NullableValue = 1918281809072642423L,
},
    NullableValue = 5082785853209719281L,
},
            new Int64Int640M
{
    Id = 73,
    Value = 8454549354020413526L,
    ModelInner = new Int64Int640MI
{
    Id = 62,
    Value = 8988415305764552102L,
    NullableValue = null,
},
    NullableValue = 7732316167569525571L,
},
            new Int64Int640M
{
    Id = 77,
    Value = 6221694406693317726L,
    ModelInner = new Int64Int640MI
{
    Id = 69,
    Value = 3224352615955656358L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 78,
    Value = 8444578171953176191L,
    ModelInner = new Int64Int640MI
{
    Id = 72,
    Value = 2373163245966429558L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 82,
    Value = 5021593217764598223L,
    ModelInner = new Int64Int640MI
{
    Id = 79,
    Value = 5891672337604431499L,
    NullableValue = null,
},
    NullableValue = 7410300464514000753L,
},
            new Int64Int640M
{
    Id = 90,
    Value = 3082531764134177193L,
    ModelInner = new Int64Int640MI
{
    Id = 83,
    Value = 8758457020088448192L,
    NullableValue = 398083445788954791L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 99,
    Value = 3119955157017255060L,
    ModelInner = new Int64Int640MI
{
    Id = 90,
    Value = 915968348224187974L,
    NullableValue = 8369780129377012626L,
},
    NullableValue = 5075302957677149531L,
},
            new Int64Int640M
{
    Id = 104,
    Value = 5851817437766520084L,
    ModelInner = new Int64Int640MI
{
    Id = 99,
    Value = 8759230289541536179L,
    NullableValue = null,
},
    NullableValue = 7352129268718011285L,
},
            new Int64Int640M
{
    Id = 109,
    Value = 5473676365078154292L,
    ModelInner = new Int64Int640MI
{
    Id = 103,
    Value = 475483913947209994L,
    NullableValue = null,
},
    NullableValue = 2501726000507772875L,
},
            new Int64Int640M
{
    Id = 114,
    Value = 5323432758959629990L,
    ModelInner = new Int64Int640MI
{
    Id = 108,
    Value = 1872056836613463190L,
    NullableValue = 43720007424182984L,
},
    NullableValue = 7206887068636731225L,
},
            new Int64Int640M
{
    Id = 123,
    Value = 3322804856816349840L,
    ModelInner = new Int64Int640MI
{
    Id = 113,
    Value = 4334322364750151148L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 132,
    Value = 369814478281710350L,
    ModelInner = new Int64Int640MI
{
    Id = 120,
    Value = 8735619990159241630L,
    NullableValue = 2090061976622536884L,
},
    NullableValue = 4736181973427185932L,
},
            new Int64Int640M
{
    Id = 140,
    Value = 5385361605389840447L,
    ModelInner = new Int64Int640MI
{
    Id = 128,
    Value = 1178113568291939367L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 148,
    Value = 3568752974292152949L,
    ModelInner = new Int64Int640MI
{
    Id = 135,
    Value = 7922909080333800049L,
    NullableValue = 3484967242132215594L,
},
    NullableValue = 6589469562426835928L,
},
            new Int64Int640M
{
    Id = 154,
    Value = 7644029787450571875L,
    ModelInner = new Int64Int640MI
{
    Id = 144,
    Value = 3668930451072358489L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 162,
    Value = 985667247769678063L,
    ModelInner = new Int64Int640MI
{
    Id = 147,
    Value = 4031778582555678020L,
    NullableValue = 976055794790497618L,
},
    NullableValue = 1899117400593263509L,
},
            new Int64Int640M
{
    Id = 163,
    Value = 4951476000597821538L,
    ModelInner = new Int64Int640MI
{
    Id = 152,
    Value = 7327244014816004140L,
    NullableValue = 7466489944529742012L,
},
    NullableValue = 6468117490883760792L,
},
            new Int64Int640M
{
    Id = 165,
    Value = 7450822066244740274L,
    ModelInner = new Int64Int640MI
{
    Id = 156,
    Value = 2510732272990284304L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 169,
    Value = 5967172453248680861L,
    ModelInner = new Int64Int640MI
{
    Id = 162,
    Value = 1828447866820842905L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 173,
    Value = 6687675903437914976L,
    ModelInner = new Int64Int640MI
{
    Id = 164,
    Value = 5209860463885751441L,
    NullableValue = 2830808378653606778L,
},
    NullableValue = 5306103498654397564L,
},
            new Int64Int640M
{
    Id = 182,
    Value = 5007488027598603644L,
    ModelInner = new Int64Int640MI
{
    Id = 168,
    Value = 3635541021103531959L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 190,
    Value = 3512743071104090258L,
    ModelInner = new Int64Int640MI
{
    Id = 171,
    Value = 8614611682938246352L,
    NullableValue = 3169742081675226958L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 199,
    Value = 8240318331575022249L,
    ModelInner = new Int64Int640MI
{
    Id = 175,
    Value = 4786104537076493164L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 207,
    Value = 1643405215402219375L,
    ModelInner = new Int64Int640MI
{
    Id = 180,
    Value = 8972522368425002046L,
    NullableValue = 2961192650678501681L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 214,
    Value = 5465683867587730013L,
    ModelInner = new Int64Int640MI
{
    Id = 182,
    Value = 261132287642698353L,
    NullableValue = 7831614398830941494L,
},
    NullableValue = 774840828380235951L,
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

