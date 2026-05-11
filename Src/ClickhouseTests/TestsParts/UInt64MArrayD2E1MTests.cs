

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
    internal partial interface IUInt64MArrayMArrayD2
    {
    }
    
    internal partial class UInt64MArrayMArrayD2 : IUInt64MArrayMArrayD2
    {


#region TestData

        private readonly UInt64MArrayD2E1M[] _testData = new UInt64MArrayD2E1M[]
        {
            new UInt64MArrayD2E1M
{
    Id = 8,
    Value = 
new System.UInt64[,] { {
8676751624160891206L,
1674303201814102432L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 1,
    Value = 
new System.UInt64[,] { {
3390065773798798472L,
7241046900698756711L, } },
    NullableValue = 
new System.UInt64[,] { {
28038257826234619L,
4549376203900301188L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 10,
    Value = 
new System.UInt64[,] { {
4762396666684271793L,
2951634118887217986L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 5,
    Value = 
new System.UInt64[,] { {
7821675467906066942L,
5653414440774772007L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
4407485750811190773L,
1408852138475277415L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 12,
    Value = 
new System.UInt64[,] { {
1827160803618620830L,
3203388710008251114L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 14,
    Value = 
new System.UInt64[,] { {
3991653833170722282L,
8410715076326272737L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 14,
    Value = 
new System.UInt64[,] { {
8351284876182685219L,
2329092403342012669L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 19,
    Value = 
new System.UInt64[,] { {
5485265205220054554L,
927706072525063149L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
6980604281254572428L,
1305623191617833603L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 22,
    Value = 
new System.UInt64[,] { {
6506442782057922439L,
8133910289765531632L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 20,
    Value = 
new System.UInt64[,] { {
3456718448014703587L,
3114696430633310847L, } },
    NullableValue = 
new System.UInt64[,] { {
3986960121837594048L,
5395001931939251425L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 28,
    Value = 
new System.UInt64[,] { {
8552512017076915608L,
5990597177370440061L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 25,
    Value = 
new System.UInt64[,] { {
8729413339014253130L,
4631564885303750003L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 33,
    Value = 
new System.UInt64[,] { {
2860148995403124221L,
8791768475845129330L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 31,
    Value = 
new System.UInt64[,] { {
5039449233261555717L,
3503891087914094539L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
3801672887087213622L,
9002939106696170242L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 34,
    Value = 
new System.UInt64[,] { {
5821361777568334931L,
9183248023402511785L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 33,
    Value = 
new System.UInt64[,] { {
3664033562577907631L,
2373315320144703483L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
6981032698701432774L,
665764359774533486L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 35,
    Value = 
new System.UInt64[,] { {
5679661565844208506L,
3981543295513070433L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 42,
    Value = 
new System.UInt64[,] { {
3965907260235538683L,
1378135620245436038L, } },
    NullableValue = 
new System.UInt64[,] { {
2954832470644818282L,
690894290353326327L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 39,
    Value = 
new System.UInt64[,] { {
7178535431179719557L,
5415947374631090294L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 50,
    Value = 
new System.UInt64[,] { {
2582189878266876140L,
2727206317098822216L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
449697356410410614L,
7877652372011739594L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 44,
    Value = 
new System.UInt64[,] { {
7266808409965402041L,
2783013857190851679L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 51,
    Value = 
new System.UInt64[,] { {
4094728308959173686L,
8355215673891379486L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 53,
    Value = 
new System.UInt64[,] { {
1427091110254349749L,
6264719914480586439L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 59,
    Value = 
new System.UInt64[,] { {
6462631315817340661L,
1604241617170088869L, } },
    NullableValue = 
new System.UInt64[,] { {
1962098612496803762L,
1469533921357218983L, } },
},
    NullableValue = 
new System.UInt64[,] { {
1809854309152318483L,
7899426981975818908L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 57,
    Value = 
new System.UInt64[,] { {
6615190918537679000L,
2806424944061444788L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 62,
    Value = 
new System.UInt64[,] { {
3845082934531382764L,
6999013204819434312L, } },
    NullableValue = 
new System.UInt64[,] { {
4929677288843223314L,
8647588638807034435L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 62,
    Value = 
new System.UInt64[,] { {
5100655043785190757L,
7336101804454513155L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 69,
    Value = 
new System.UInt64[,] { {
6943287807183248627L,
4578316473984849729L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 65,
    Value = 
new System.UInt64[,] { {
4789313298234043372L,
8303388035897355190L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 77,
    Value = 
new System.UInt64[,] { {
5159030291361807853L,
1106277656624880153L, } },
    NullableValue = 
new System.UInt64[,] { {
5423918069858011620L,
7905603336267101412L, } },
},
    NullableValue = 
new System.UInt64[,] { {
7671171605158550726L,
6208051986083916690L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 70,
    Value = 
new System.UInt64[,] { {
4950595378907278531L,
4998444128699362815L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 83,
    Value = 
new System.UInt64[,] { {
7407446531041325274L,
5950610934180848198L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
2922705255586071237L,
4823288917229287298L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 78,
    Value = 
new System.UInt64[,] { {
4829546168411713681L,
3015590813579236136L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 88,
    Value = 
new System.UInt64[,] { {
3143745467057989103L,
3818505760438727313L, } },
    NullableValue = 
new System.UInt64[,] { {
7124274537260971493L,
2706531158296711676L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 80,
    Value = 
new System.UInt64[,] { {
3407990152614549286L,
4052728039974914337L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 96,
    Value = 
new System.UInt64[,] { {
909110098218682550L,
8448624316249252624L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
7391643802406981870L,
3443387267530381577L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 85,
    Value = 
new System.UInt64[,] { {
5239448201053237112L,
5760535409661292533L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 103,
    Value = 
new System.UInt64[,] { {
5495595025190013378L,
8116661962096952918L, } },
    NullableValue = 
new System.UInt64[,] { {
8709759421050096914L,
6252244781369069089L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 87,
    Value = 
new System.UInt64[,] { {
4962577361354195791L,
4752024768448950543L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 106,
    Value = 
new System.UInt64[,] { {
3285823818076498871L,
7356696257841905468L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
2428251954620031001L,
3900208961007887685L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 93,
    Value = 
new System.UInt64[,] { {
4504021924572403591L,
1458859876488984514L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 108,
    Value = 
new System.UInt64[,] { {
887565841992299754L,
4326135778811352943L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
7150060994821484842L,
4530488744824096229L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 102,
    Value = 
new System.UInt64[,] { {
7174036184090046793L,
3914975043005563053L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 115,
    Value = 
new System.UInt64[,] { {
6798102528843287779L,
6754287702593275310L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 104,
    Value = 
new System.UInt64[,] { {
5567762292821245471L,
2960723840522409917L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 119,
    Value = 
new System.UInt64[,] { {
5768455362920046672L,
9115749253383459282L, } },
    NullableValue = 
new System.UInt64[,] { {
1078933588385251844L,
7362747244577916024L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 110,
    Value = 
new System.UInt64[,] { {
4596332259217688008L,
8658306770829101839L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 121,
    Value = 
new System.UInt64[,] { {
3506756194801867306L,
4060105009520192856L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 116,
    Value = 
new System.UInt64[,] { {
8591519320775028367L,
6506371049089087702L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 126,
    Value = 
new System.UInt64[,] { {
3241881484683965652L,
8103360721520213749L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
6135030966465397241L,
5506484299893641198L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 124,
    Value = 
new System.UInt64[,] { {
8834189301286583953L,
8320925119674562825L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 128,
    Value = 
new System.UInt64[,] { {
907480594627887738L,
2138127231724289823L, } },
    NullableValue = 
new System.UInt64[,] { {
8145646481130870436L,
3430525004130576370L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 128,
    Value = 
new System.UInt64[,] { {
6222321799482981368L,
7544782048685446076L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 129,
    Value = 
new System.UInt64[,] { {
8211903327996545135L,
2545770682524107563L, } },
    NullableValue = 
new System.UInt64[,] { {
8977671453960307538L,
9096657362716335499L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 129,
    Value = 
new System.UInt64[,] { {
6049045743155095636L,
1526095550697944722L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 135,
    Value = 
new System.UInt64[,] { {
8880874455344480925L,
4565813191512695562L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 133,
    Value = 
new System.UInt64[,] { {
2576666676026207831L,
5837278541165724621L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 137,
    Value = 
new System.UInt64[,] { {
1587637310699684315L,
7859517561418478352L, } },
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 141,
    Value = 
new System.UInt64[,] { {
788211411913233483L,
988065090534421712L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 141,
    Value = 
new System.UInt64[,] { {
4668337000132200374L,
1894184417798174925L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
7072353231160599369L,
7438946680944202348L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 149,
    Value = 
new System.UInt64[,] { {
8057613821469352076L,
561460648134556682L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 143,
    Value = 
new System.UInt64[,] { {
3598540936172606167L,
7014930070137055949L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
7933250982486280808L,
1496034149668019161L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 157,
    Value = 
new System.UInt64[,] { {
3706687708565456497L,
7054687957064664231L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 152,
    Value = 
new System.UInt64[,] { {
4781368920372021513L,
1002000467612286470L, } },
    NullableValue = 
new System.UInt64[,] { {
2225307944615866509L,
4653051326148446597L, } },
},
    NullableValue = null,
},
            new UInt64MArrayD2E1M
{
    Id = 159,
    Value = 
new System.UInt64[,] { {
266582687172149994L,
1631342421600406828L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 156,
    Value = 
new System.UInt64[,] { {
6277000811107486726L,
7733015520424574591L, } },
    NullableValue = null,
},
    NullableValue = 
new System.UInt64[,] { {
682169929998968773L,
1222923172751630273L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 168,
    Value = 
new System.UInt64[,] { {
8037895400018456284L,
3975644277446445611L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 161,
    Value = 
new System.UInt64[,] { {
887587417139552585L,
544659960861327480L, } },
    NullableValue = 
new System.UInt64[,] { {
5757341203990577927L,
4201211121577037172L, } },
},
    NullableValue = 
new System.UInt64[,] { {
2859314479864670156L,
4944235433534060398L, } },
},
            new UInt64MArrayD2E1M
{
    Id = 174,
    Value = 
new System.UInt64[,] { {
5212336779093051935L,
931733594002471080L, } },
    ModelInner = new UInt64MArrayD2E1MI
{
    Id = 165,
    Value = 
new System.UInt64[,] { {
5290166851438173456L,
5022358889396673738L, } },
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
INSERT INTO gedaqtests.uint64marrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UInt64))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UInt64))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.UInt64[,]), 
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
                    await ((IUInt64MArrayMArrayD2)this).InsertModelDbConnectionAsync(
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
                     ((IUInt64MArrayMArrayD2)this).InsertModelDbConnection(
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
FROM gedaqtests.uint64marrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64MArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IUInt64MArrayMArrayD2)),
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
                    var models = await ((IUInt64MArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IUInt64MArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    UInt64MArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

