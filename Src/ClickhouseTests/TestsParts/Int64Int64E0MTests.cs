

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
    Id = 1,
    Value = 6008835257294627913L,
    ModelInner = new Int64Int64E0MI
{
    Id = 4,
    Value = 946790971469491353L,
    NullableValue = 5742996228809279734L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 9,
    Value = 5600322292560939387L,
    ModelInner = new Int64Int64E0MI
{
    Id = 7,
    Value = 5752236935544311109L,
    NullableValue = 7746429934839963980L,
},
    NullableValue = 4260886418841985404L,
},
            new Int64Int64E0M
{
    Id = 11,
    Value = 6816693780899249762L,
    ModelInner = new Int64Int64E0MI
{
    Id = 9,
    Value = 6058340565491544761L,
    NullableValue = 8286662713832386218L,
},
    NullableValue = 8894054641081364160L,
},
            new Int64Int64E0M
{
    Id = 15,
    Value = 3735515615460839201L,
    ModelInner = new Int64Int64E0MI
{
    Id = 15,
    Value = 1327144423750025829L,
    NullableValue = 166869112423177502L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 22,
    Value = 8684130334525724636L,
    ModelInner = new Int64Int64E0MI
{
    Id = 16,
    Value = 5108193762091491210L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 28,
    Value = 8834315669330796002L,
    ModelInner = new Int64Int64E0MI
{
    Id = 19,
    Value = 5047760319350080866L,
    NullableValue = 1923503573890935613L,
},
    NullableValue = 2735754564516076255L,
},
            new Int64Int64E0M
{
    Id = 29,
    Value = 6049546876143669730L,
    ModelInner = new Int64Int64E0MI
{
    Id = 26,
    Value = 2275073090859261328L,
    NullableValue = null,
},
    NullableValue = 389493453744552018L,
},
            new Int64Int64E0M
{
    Id = 30,
    Value = 2765477010498240618L,
    ModelInner = new Int64Int64E0MI
{
    Id = 29,
    Value = 5642219285175406272L,
    NullableValue = 7946762947411629288L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 33,
    Value = 6865671853569002569L,
    ModelInner = new Int64Int64E0MI
{
    Id = 34,
    Value = 2919839454449371570L,
    NullableValue = 7639791793533568316L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 34,
    Value = 5081217051346111587L,
    ModelInner = new Int64Int64E0MI
{
    Id = 40,
    Value = 9187002796692194607L,
    NullableValue = null,
},
    NullableValue = 6668883185836356395L,
},
            new Int64Int64E0M
{
    Id = 39,
    Value = 2747704966179656210L,
    ModelInner = new Int64Int64E0MI
{
    Id = 47,
    Value = 525397404840321895L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 45,
    Value = 8681862630733688240L,
    ModelInner = new Int64Int64E0MI
{
    Id = 53,
    Value = 47111263815566454L,
    NullableValue = null,
},
    NullableValue = 6024210914474120939L,
},
            new Int64Int64E0M
{
    Id = 49,
    Value = 708801652109089384L,
    ModelInner = new Int64Int64E0MI
{
    Id = 61,
    Value = 3227352171716488684L,
    NullableValue = null,
},
    NullableValue = 2721618922069213139L,
},
            new Int64Int64E0M
{
    Id = 53,
    Value = 2080493221353248326L,
    ModelInner = new Int64Int64E0MI
{
    Id = 66,
    Value = 2441150624328101144L,
    NullableValue = null,
},
    NullableValue = 4054015002552487500L,
},
            new Int64Int64E0M
{
    Id = 60,
    Value = 5328030009192094090L,
    ModelInner = new Int64Int64E0MI
{
    Id = 74,
    Value = 6101048585311336447L,
    NullableValue = 6246672045274781052L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 67,
    Value = 1046478569558819102L,
    ModelInner = new Int64Int64E0MI
{
    Id = 82,
    Value = 7765040608613392746L,
    NullableValue = 503277805560876533L,
},
    NullableValue = 5692987241055978165L,
},
            new Int64Int64E0M
{
    Id = 70,
    Value = 6748516230022772390L,
    ModelInner = new Int64Int64E0MI
{
    Id = 91,
    Value = 7930869869267671810L,
    NullableValue = 5969608312682721887L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 77,
    Value = 8356496084214712770L,
    ModelInner = new Int64Int64E0MI
{
    Id = 98,
    Value = 837883796745818680L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 84,
    Value = 7579076779529288438L,
    ModelInner = new Int64Int64E0MI
{
    Id = 102,
    Value = 6217301605945090890L,
    NullableValue = 1035624952405728214L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 89,
    Value = 2952590602608487646L,
    ModelInner = new Int64Int64E0MI
{
    Id = 111,
    Value = 5149018304674401038L,
    NullableValue = 9002804581952328365L,
},
    NullableValue = 2338557333183394378L,
},
            new Int64Int64E0M
{
    Id = 93,
    Value = 699357363918776646L,
    ModelInner = new Int64Int64E0MI
{
    Id = 113,
    Value = 4406676993835245451L,
    NullableValue = 8540403915255909599L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 100,
    Value = 5392340113531605119L,
    ModelInner = new Int64Int64E0MI
{
    Id = 115,
    Value = 3214085491371529485L,
    NullableValue = null,
},
    NullableValue = 4188255179943786284L,
},
            new Int64Int64E0M
{
    Id = 106,
    Value = 7735342961546689699L,
    ModelInner = new Int64Int64E0MI
{
    Id = 121,
    Value = 9183408159078057581L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 107,
    Value = 6781140832060417577L,
    ModelInner = new Int64Int64E0MI
{
    Id = 129,
    Value = 5723915748361531026L,
    NullableValue = 251768469837439992L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 109,
    Value = 5555203339077605037L,
    ModelInner = new Int64Int64E0MI
{
    Id = 138,
    Value = 6152009674726596178L,
    NullableValue = null,
},
    NullableValue = 8525798701535555769L,
},
            new Int64Int64E0M
{
    Id = 116,
    Value = 4179411625125166896L,
    ModelInner = new Int64Int64E0MI
{
    Id = 144,
    Value = 5775540122547551705L,
    NullableValue = 3108184894715687060L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 123,
    Value = 4031691814312147084L,
    ModelInner = new Int64Int64E0MI
{
    Id = 145,
    Value = 7176060572280267716L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 132,
    Value = 3968634631931949141L,
    ModelInner = new Int64Int64E0MI
{
    Id = 149,
    Value = 8014721650462786766L,
    NullableValue = 5122146204726696461L,
},
    NullableValue = 2747181527756254002L,
},
            new Int64Int64E0M
{
    Id = 137,
    Value = 2446387683160226428L,
    ModelInner = new Int64Int64E0MI
{
    Id = 150,
    Value = 6869456963206945309L,
    NullableValue = 1932842760063977867L,
},
    NullableValue = 708039074667288187L,
},
            new Int64Int64E0M
{
    Id = 145,
    Value = 1173858778467763242L,
    ModelInner = new Int64Int64E0MI
{
    Id = 159,
    Value = 7534342567277736342L,
    NullableValue = null,
},
    NullableValue = 5549078635391808581L,
},
            new Int64Int64E0M
{
    Id = 153,
    Value = 2373733318898659486L,
    ModelInner = new Int64Int64E0MI
{
    Id = 165,
    Value = 5707225990390346836L,
    NullableValue = null,
},
    NullableValue = 6367769730912118060L,
},
            new Int64Int64E0M
{
    Id = 155,
    Value = 5343784111246729929L,
    ModelInner = new Int64Int64E0MI
{
    Id = 171,
    Value = 1172077799633094962L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 159,
    Value = 3009814449159024271L,
    ModelInner = new Int64Int64E0MI
{
    Id = 172,
    Value = 184834129714316038L,
    NullableValue = 7779775643026859930L,
},
    NullableValue = 7927568560658510704L,
},
            new Int64Int64E0M
{
    Id = 166,
    Value = 2423702808180311342L,
    ModelInner = new Int64Int64E0MI
{
    Id = 173,
    Value = 6229097107455811914L,
    NullableValue = null,
},
    NullableValue = 3909650508135318157L,
},
            new Int64Int64E0M
{
    Id = 172,
    Value = 2407084244860081870L,
    ModelInner = new Int64Int64E0MI
{
    Id = 178,
    Value = 8269718739523738502L,
    NullableValue = 4896054314664241860L,
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

