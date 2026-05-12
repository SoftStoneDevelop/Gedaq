

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
    Value = 869166968545741362L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 9,
    Value = 1225823520032985272L,
    NullableValue = null,
},
    NullableValue = 4273331910201097115L,
},
            new UInt64UInt64E0M
{
    Id = 10,
    Value = 8083803152807726144L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 15,
    Value = 1982583752139594675L,
    NullableValue = 7249840728859809968L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 14,
    Value = 7232959531430021037L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 17,
    Value = 2979320203555791774L,
    NullableValue = 1505324414531625593L,
},
    NullableValue = 4465817503630171276L,
},
            new UInt64UInt64E0M
{
    Id = 19,
    Value = 699957037912905769L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 19,
    Value = 7843701264337096989L,
    NullableValue = 3447876903401952649L,
},
    NullableValue = 2752218641434537870L,
},
            new UInt64UInt64E0M
{
    Id = 21,
    Value = 3783855186443260703L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 23,
    Value = 7280859291441318414L,
    NullableValue = 5870891904483998802L,
},
    NullableValue = 2932289047415505205L,
},
            new UInt64UInt64E0M
{
    Id = 30,
    Value = 2993194286420193873L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 26,
    Value = 2566583757396630067L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 32,
    Value = 3257091794994342709L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 27,
    Value = 2991527491843013566L,
    NullableValue = null,
},
    NullableValue = 713765648312994862L,
},
            new UInt64UInt64E0M
{
    Id = 35,
    Value = 6592789651547137002L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 30,
    Value = 8432537694354009088L,
    NullableValue = 2767055738969449451L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 43,
    Value = 7814338262162819365L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 32,
    Value = 9160532136043272236L,
    NullableValue = 7545495926350348788L,
},
    NullableValue = 1343900598553120282L,
},
            new UInt64UInt64E0M
{
    Id = 47,
    Value = 2537330173161189857L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 35,
    Value = 5057062160871642865L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 49,
    Value = 3090451916852691757L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 41,
    Value = 480599129091370620L,
    NullableValue = 3984643220920495304L,
},
    NullableValue = 6142836067383891331L,
},
            new UInt64UInt64E0M
{
    Id = 53,
    Value = 5969540349909081109L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 49,
    Value = 7936393320386110924L,
    NullableValue = null,
},
    NullableValue = 6129991737661262921L,
},
            new UInt64UInt64E0M
{
    Id = 59,
    Value = 9089279658415946622L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 53,
    Value = 359888060955872581L,
    NullableValue = null,
},
    NullableValue = 6801966892668590923L,
},
            new UInt64UInt64E0M
{
    Id = 63,
    Value = 2691393829800642833L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 61,
    Value = 2825308054938131649L,
    NullableValue = 7749750150424180400L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 67,
    Value = 3202601535155427102L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 70,
    Value = 6327455100867341928L,
    NullableValue = 6279236157352362885L,
},
    NullableValue = 4132538660124963153L,
},
            new UInt64UInt64E0M
{
    Id = 74,
    Value = 7090329879948409502L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 75,
    Value = 326572835155108599L,
    NullableValue = 5263275311016999282L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 83,
    Value = 7261183477117480188L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 78,
    Value = 5635417322529544576L,
    NullableValue = null,
},
    NullableValue = 3811640358101168756L,
},
            new UInt64UInt64E0M
{
    Id = 84,
    Value = 6302503221299387772L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 79,
    Value = 5746379431625933891L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 86,
    Value = 7432133059182267153L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 88,
    Value = 4478711355082349515L,
    NullableValue = null,
},
    NullableValue = 5823881230409150437L,
},
            new UInt64UInt64E0M
{
    Id = 91,
    Value = 6203521744632246410L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 95,
    Value = 8747704881321158071L,
    NullableValue = 4637615544274144134L,
},
    NullableValue = 6130451278903102759L,
},
            new UInt64UInt64E0M
{
    Id = 99,
    Value = 563254836046833326L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 99,
    Value = 8540443375311626193L,
    NullableValue = 1926408867360875771L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 107,
    Value = 3795041222295997342L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 106,
    Value = 4880394761161573587L,
    NullableValue = null,
},
    NullableValue = 2079499092336211015L,
},
            new UInt64UInt64E0M
{
    Id = 109,
    Value = 937230731618898578L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 114,
    Value = 1676101475769359275L,
    NullableValue = 5422677973580056505L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 112,
    Value = 5929466834106763406L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 117,
    Value = 1589989124175840860L,
    NullableValue = 5219280052408307604L,
},
    NullableValue = 542872432835386929L,
},
            new UInt64UInt64E0M
{
    Id = 114,
    Value = 6564429837174484324L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 126,
    Value = 7926146167423104186L,
    NullableValue = 9032967023742030426L,
},
    NullableValue = 1201092576465466030L,
},
            new UInt64UInt64E0M
{
    Id = 116,
    Value = 5552956570297553234L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 127,
    Value = 5735467490967882441L,
    NullableValue = 6502872557357707644L,
},
    NullableValue = 356708094431382659L,
},
            new UInt64UInt64E0M
{
    Id = 124,
    Value = 2809129494757422002L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 132,
    Value = 3048669160219082762L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 125,
    Value = 7227388865820963565L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 135,
    Value = 5468884385132058838L,
    NullableValue = 4499624827590131159L,
},
    NullableValue = 5259355609255131093L,
},
            new UInt64UInt64E0M
{
    Id = 126,
    Value = 685562548637074859L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 139,
    Value = 764807470517151250L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 135,
    Value = 5054048505307058108L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 146,
    Value = 3908685638668906624L,
    NullableValue = null,
},
    NullableValue = 4853528234411145790L,
},
            new UInt64UInt64E0M
{
    Id = 143,
    Value = 2620964963793991812L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 151,
    Value = 9006897027552842985L,
    NullableValue = 2964340987041817200L,
},
    NullableValue = 180030972350343003L,
},
            new UInt64UInt64E0M
{
    Id = 148,
    Value = 3978746088456738563L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 158,
    Value = 6774984202016650043L,
    NullableValue = 513573248079450499L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 156,
    Value = 1152224269566178960L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 166,
    Value = 7026970848525361353L,
    NullableValue = 4567264861571838769L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 163,
    Value = 1029222087773807074L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 168,
    Value = 793577678604317250L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 167,
    Value = 6490674138241474730L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 174,
    Value = 4447164103201847743L,
    NullableValue = 9183382203817265750L,
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

