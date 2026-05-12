

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
    Id = 7,
    Value = 1752061003210280597L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 1,
    Value = 1991625425094558649L,
    NullableValue = null,
},
    NullableValue = 3932293226031105131L,
},
            new UInt64UInt64E0M
{
    Id = 9,
    Value = 5721100299894946040L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 8,
    Value = 7329775707961718839L,
    NullableValue = 5425344627819838657L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 10,
    Value = 5864785880161716024L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 12,
    Value = 6587122441783828382L,
    NullableValue = 890584056564097705L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 12,
    Value = 9091272775549446597L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 14,
    Value = 5970847781264499249L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 18,
    Value = 7875043050051468607L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 20,
    Value = 3281113368558224817L,
    NullableValue = 5327415470952357114L,
},
    NullableValue = 2575607629619580982L,
},
            new UInt64UInt64E0M
{
    Id = 26,
    Value = 5374325811239660232L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 24,
    Value = 8162825704461185614L,
    NullableValue = 4920052435548150775L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 30,
    Value = 9090452768188384275L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 30,
    Value = 2491156483502443825L,
    NullableValue = 8482215281347704L,
},
    NullableValue = 8802330843930390015L,
},
            new UInt64UInt64E0M
{
    Id = 34,
    Value = 8353330379734774343L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 33,
    Value = 4395519439287675920L,
    NullableValue = null,
},
    NullableValue = 7310292787876936185L,
},
            new UInt64UInt64E0M
{
    Id = 37,
    Value = 2354299316901143711L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 41,
    Value = 4928065296973942300L,
    NullableValue = null,
},
    NullableValue = 8134834522992392385L,
},
            new UInt64UInt64E0M
{
    Id = 39,
    Value = 7789215836420458292L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 49,
    Value = 844966800879561568L,
    NullableValue = null,
},
    NullableValue = 7478977083606558919L,
},
            new UInt64UInt64E0M
{
    Id = 46,
    Value = 4078360602979317229L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 58,
    Value = 3601549753476679009L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 53,
    Value = 7716769553565081276L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 65,
    Value = 5535865931397563397L,
    NullableValue = null,
},
    NullableValue = 7843926559966430624L,
},
            new UInt64UInt64E0M
{
    Id = 59,
    Value = 121951841195709890L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 66,
    Value = 4959669279078433498L,
    NullableValue = 8437580464835666978L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 67,
    Value = 357753024981637480L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 71,
    Value = 1875237669060403421L,
    NullableValue = null,
},
    NullableValue = 5984214635666201713L,
},
            new UInt64UInt64E0M
{
    Id = 74,
    Value = 3455006649128219849L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 79,
    Value = 5624570735064135887L,
    NullableValue = 7005445546055994435L,
},
    NullableValue = 578545040852749298L,
},
            new UInt64UInt64E0M
{
    Id = 77,
    Value = 6700851855886775524L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 86,
    Value = 1048124700133327187L,
    NullableValue = 5462562948643304331L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 85,
    Value = 782818065613707215L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 95,
    Value = 6730893152374068787L,
    NullableValue = null,
},
    NullableValue = 1380376535660820192L,
},
            new UInt64UInt64E0M
{
    Id = 93,
    Value = 7979647505299334709L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 104,
    Value = 2134636476997332149L,
    NullableValue = null,
},
    NullableValue = 4207377358166024601L,
},
            new UInt64UInt64E0M
{
    Id = 96,
    Value = 1315475917437730089L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 113,
    Value = 1935267759056864174L,
    NullableValue = null,
},
    NullableValue = 6368737238131690521L,
},
            new UInt64UInt64E0M
{
    Id = 100,
    Value = 2218835621198324832L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 114,
    Value = 5947342363380885967L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 104,
    Value = 6290734992345389356L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 117,
    Value = 5069117365068410302L,
    NullableValue = null,
},
    NullableValue = 5507605703197412250L,
},
            new UInt64UInt64E0M
{
    Id = 109,
    Value = 287975048922905316L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 124,
    Value = 6562524994049021436L,
    NullableValue = 6915698891727491129L,
},
    NullableValue = 3155256917407338387L,
},
            new UInt64UInt64E0M
{
    Id = 115,
    Value = 3394489295112532441L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 126,
    Value = 6083909020282303123L,
    NullableValue = 5673280138313610446L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 122,
    Value = 7764538565845158167L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 130,
    Value = 3725775668106016802L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 123,
    Value = 8493420992430311491L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 131,
    Value = 1287189774637735182L,
    NullableValue = 8958296291455296309L,
},
    NullableValue = 4716654535840747975L,
},
            new UInt64UInt64E0M
{
    Id = 127,
    Value = 5036878074090876992L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 138,
    Value = 2009952513200845224L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 131,
    Value = 2371750122838566350L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 144,
    Value = 6027454069641256187L,
    NullableValue = 8713507430348664055L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 140,
    Value = 2462098943880264076L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 148,
    Value = 290591258790359464L,
    NullableValue = null,
},
    NullableValue = 5689111411719110322L,
},
            new UInt64UInt64E0M
{
    Id = 143,
    Value = 4451699388410552347L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 153,
    Value = 4675919148487992756L,
    NullableValue = null,
},
    NullableValue = 9051484209828348816L,
},
            new UInt64UInt64E0M
{
    Id = 148,
    Value = 3232608106120207646L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 156,
    Value = 4628669337459483718L,
    NullableValue = 4619049373639972405L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 155,
    Value = 2728065041225905668L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 161,
    Value = 3612365355365286142L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 162,
    Value = 4879522137836191054L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 163,
    Value = 1141625313849343506L,
    NullableValue = 2552106419318362794L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 168,
    Value = 4368061112519316361L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 165,
    Value = 5749361223272087457L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 171,
    Value = 7076635751806614004L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 171,
    Value = 1924933225618161721L,
    NullableValue = 370642943372163998L,
},
    NullableValue = 1636322293889549029L,
},
            new UInt64UInt64E0M
{
    Id = 180,
    Value = 892455553467635395L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 180,
    Value = 3037016717975187278L,
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

