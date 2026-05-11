

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
    Id = 2,
    Value = 7191731105933653155L,
    ModelInner = new Int64Int64E0MI
{
    Id = 3,
    Value = 2074956335859072122L,
    NullableValue = 1263267250361771086L,
},
    NullableValue = 5890462400715925791L,
},
            new Int64Int64E0M
{
    Id = 10,
    Value = 2872561787580585678L,
    ModelInner = new Int64Int64E0MI
{
    Id = 9,
    Value = 6686452365636445085L,
    NullableValue = 1714107945227177639L,
},
    NullableValue = 5608346435127610222L,
},
            new Int64Int64E0M
{
    Id = 19,
    Value = 5570147439179105205L,
    ModelInner = new Int64Int64E0MI
{
    Id = 16,
    Value = 4997489938377600355L,
    NullableValue = null,
},
    NullableValue = 4760190178169434655L,
},
            new Int64Int64E0M
{
    Id = 27,
    Value = 7262086103691332668L,
    ModelInner = new Int64Int64E0MI
{
    Id = 24,
    Value = 3422821930363054730L,
    NullableValue = null,
},
    NullableValue = 8036885358166439909L,
},
            new Int64Int64E0M
{
    Id = 32,
    Value = 8023161741938797594L,
    ModelInner = new Int64Int64E0MI
{
    Id = 25,
    Value = 4909998524429861095L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 35,
    Value = 577287032658788338L,
    ModelInner = new Int64Int64E0MI
{
    Id = 34,
    Value = 2227569088399371468L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 43,
    Value = 7549537140643619569L,
    ModelInner = new Int64Int64E0MI
{
    Id = 36,
    Value = 4363657269989364578L,
    NullableValue = 4462607407834464112L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 52,
    Value = 2747728065798604170L,
    ModelInner = new Int64Int64E0MI
{
    Id = 41,
    Value = 3237493184887654204L,
    NullableValue = 5583108723789949768L,
},
    NullableValue = 2910525937307301962L,
},
            new Int64Int64E0M
{
    Id = 60,
    Value = 4743657566844259184L,
    ModelInner = new Int64Int64E0MI
{
    Id = 46,
    Value = 7529203480025254999L,
    NullableValue = 5647488970671267904L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 69,
    Value = 8039743336298462653L,
    ModelInner = new Int64Int64E0MI
{
    Id = 55,
    Value = 1411722658519979549L,
    NullableValue = null,
},
    NullableValue = 4576784059695441569L,
},
            new Int64Int64E0M
{
    Id = 74,
    Value = 9200234552901452493L,
    ModelInner = new Int64Int64E0MI
{
    Id = 63,
    Value = 5395799080768246539L,
    NullableValue = 6933310466419779513L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 82,
    Value = 3948963354714575224L,
    ModelInner = new Int64Int64E0MI
{
    Id = 67,
    Value = 6280092881503657461L,
    NullableValue = null,
},
    NullableValue = 8949997622352539802L,
},
            new Int64Int64E0M
{
    Id = 85,
    Value = 8313095477293938605L,
    ModelInner = new Int64Int64E0MI
{
    Id = 71,
    Value = 5990734645879812739L,
    NullableValue = 1777618736996755868L,
},
    NullableValue = 6233675214680592819L,
},
            new Int64Int64E0M
{
    Id = 92,
    Value = 2761048289164629889L,
    ModelInner = new Int64Int64E0MI
{
    Id = 77,
    Value = 883926649682030189L,
    NullableValue = 8907095909582285958L,
},
    NullableValue = 175932174368270498L,
},
            new Int64Int64E0M
{
    Id = 99,
    Value = 7400109247165561722L,
    ModelInner = new Int64Int64E0MI
{
    Id = 80,
    Value = 4946065030048686379L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 100,
    Value = 2066162682882417470L,
    ModelInner = new Int64Int64E0MI
{
    Id = 82,
    Value = 2150922698808988533L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 107,
    Value = 8820299955849576947L,
    ModelInner = new Int64Int64E0MI
{
    Id = 86,
    Value = 3072538494167999904L,
    NullableValue = 2872412006842267561L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 109,
    Value = 7709677573917616908L,
    ModelInner = new Int64Int64E0MI
{
    Id = 94,
    Value = 6330385114748236814L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 111,
    Value = 3308330240751577989L,
    ModelInner = new Int64Int64E0MI
{
    Id = 95,
    Value = 8681926032866423063L,
    NullableValue = null,
},
    NullableValue = 9165821378193575614L,
},
            new Int64Int64E0M
{
    Id = 116,
    Value = 8093818549427929319L,
    ModelInner = new Int64Int64E0MI
{
    Id = 98,
    Value = 5360746306303583195L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 120,
    Value = 5657025613725100894L,
    ModelInner = new Int64Int64E0MI
{
    Id = 103,
    Value = 1314767641678963563L,
    NullableValue = null,
},
    NullableValue = 7997513869969292337L,
},
            new Int64Int64E0M
{
    Id = 126,
    Value = 156459115403440817L,
    ModelInner = new Int64Int64E0MI
{
    Id = 105,
    Value = 3702175528860480196L,
    NullableValue = 717185959870703935L,
},
    NullableValue = 3030780120582560454L,
},
            new Int64Int64E0M
{
    Id = 131,
    Value = 2370508043300387608L,
    ModelInner = new Int64Int64E0MI
{
    Id = 108,
    Value = 2724216860001784405L,
    NullableValue = 89594608770248310L,
},
    NullableValue = 4006598251054862536L,
},
            new Int64Int64E0M
{
    Id = 134,
    Value = 1584481344988182919L,
    ModelInner = new Int64Int64E0MI
{
    Id = 114,
    Value = 8369031224435797569L,
    NullableValue = 828193468682778711L,
},
    NullableValue = 6899379938615252585L,
},
            new Int64Int64E0M
{
    Id = 139,
    Value = 12440123293882521L,
    ModelInner = new Int64Int64E0MI
{
    Id = 115,
    Value = 8060651157729629573L,
    NullableValue = 4345848678142581473L,
},
    NullableValue = 17694790045646300L,
},
            new Int64Int64E0M
{
    Id = 148,
    Value = 4279390478696598735L,
    ModelInner = new Int64Int64E0MI
{
    Id = 117,
    Value = 149347624586131711L,
    NullableValue = 2790727508055775408L,
},
    NullableValue = 9098436699216734587L,
},
            new Int64Int64E0M
{
    Id = 153,
    Value = 2799214534880447447L,
    ModelInner = new Int64Int64E0MI
{
    Id = 125,
    Value = 3512771740726077986L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 162,
    Value = 6552538355492842980L,
    ModelInner = new Int64Int64E0MI
{
    Id = 131,
    Value = 7909671656665957810L,
    NullableValue = 5288229053394456395L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 164,
    Value = 678328712269446496L,
    ModelInner = new Int64Int64E0MI
{
    Id = 140,
    Value = 6561558672629241305L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 171,
    Value = 6023217179036558057L,
    ModelInner = new Int64Int64E0MI
{
    Id = 145,
    Value = 6264070696711943900L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 172,
    Value = 8339144279567253645L,
    ModelInner = new Int64Int64E0MI
{
    Id = 146,
    Value = 103453745702801129L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 177,
    Value = 5703854310848663160L,
    ModelInner = new Int64Int64E0MI
{
    Id = 149,
    Value = 5150479656980669253L,
    NullableValue = 8943753639615552380L,
},
    NullableValue = 5445836210555437493L,
},
            new Int64Int64E0M
{
    Id = 179,
    Value = 3287817394661551741L,
    ModelInner = new Int64Int64E0MI
{
    Id = 154,
    Value = 4215478948335975764L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 183,
    Value = 1632978442509443084L,
    ModelInner = new Int64Int64E0MI
{
    Id = 163,
    Value = 4111700774582775227L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 184,
    Value = 7892718408248205883L,
    ModelInner = new Int64Int64E0MI
{
    Id = 172,
    Value = 413287051511520506L,
    NullableValue = null,
},
    NullableValue = 1384167974321974597L,
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

