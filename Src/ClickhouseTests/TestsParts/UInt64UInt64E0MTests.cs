

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
    Id = 3,
    Value = 4353617479157629472L,
    ModelInner = new UInt64UInt640MI
{
    Id = 7,
    Value = 4781452802895510350L,
    NullableValue = 3570952765478190108L,
},
    NullableValue = 8879482773246635531L,
},
            new UInt64UInt64E0M
{
    Id = 11,
    Value = 1475688637061793936L,
    ModelInner = new UInt64UInt640MI
{
    Id = 15,
    Value = 5896894152408757239L,
    NullableValue = null,
},
    NullableValue = 7405636198694491989L,
},
            new UInt64UInt64E0M
{
    Id = 17,
    Value = 3009000004660423099L,
    ModelInner = new UInt64UInt640MI
{
    Id = 20,
    Value = 3369500639300213244L,
    NullableValue = 8831459784066207500L,
},
    NullableValue = 7753099247713545317L,
},
            new UInt64UInt64E0M
{
    Id = 23,
    Value = 3717219039843221221L,
    ModelInner = new UInt64UInt640MI
{
    Id = 28,
    Value = 8821722989723419580L,
    NullableValue = 1138833085968256929L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 28,
    Value = 6339201461055611554L,
    ModelInner = new UInt64UInt640MI
{
    Id = 34,
    Value = 8687180891560056612L,
    NullableValue = null,
},
    NullableValue = 4204612220513950699L,
},
            new UInt64UInt64E0M
{
    Id = 37,
    Value = 8538088194441813920L,
    ModelInner = new UInt64UInt640MI
{
    Id = 35,
    Value = 6435121111096951481L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 41,
    Value = 8859980951069299813L,
    ModelInner = new UInt64UInt640MI
{
    Id = 36,
    Value = 1144628396277646147L,
    NullableValue = 429727285293513072L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 47,
    Value = 6437033006418448122L,
    ModelInner = new UInt64UInt640MI
{
    Id = 44,
    Value = 1811970516156363625L,
    NullableValue = null,
},
    NullableValue = 7074033592942159232L,
},
            new UInt64UInt64E0M
{
    Id = 53,
    Value = 5174650994675779819L,
    ModelInner = new UInt64UInt640MI
{
    Id = 46,
    Value = 2473109757395562511L,
    NullableValue = null,
},
    NullableValue = 5923786640532252503L,
},
            new UInt64UInt64E0M
{
    Id = 59,
    Value = 1470874189348222397L,
    ModelInner = new UInt64UInt640MI
{
    Id = 47,
    Value = 3152474055826006957L,
    NullableValue = 151716547583383066L,
},
    NullableValue = 484160410488965021L,
},
            new UInt64UInt64E0M
{
    Id = 68,
    Value = 8110018077709903460L,
    ModelInner = new UInt64UInt640MI
{
    Id = 53,
    Value = 8071979943167033447L,
    NullableValue = 4310835892982220420L,
},
    NullableValue = 6105436656402160824L,
},
            new UInt64UInt64E0M
{
    Id = 73,
    Value = 3801136424848236819L,
    ModelInner = new UInt64UInt640MI
{
    Id = 56,
    Value = 2776057055190831343L,
    NullableValue = 7500978180103686151L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 82,
    Value = 3029313288045391670L,
    ModelInner = new UInt64UInt640MI
{
    Id = 62,
    Value = 3283767658631995668L,
    NullableValue = 5662815902728721165L,
},
    NullableValue = 1451977198036172671L,
},
            new UInt64UInt64E0M
{
    Id = 87,
    Value = 7484399349647734945L,
    ModelInner = new UInt64UInt640MI
{
    Id = 68,
    Value = 7174658980428516612L,
    NullableValue = null,
},
    NullableValue = 5380222388693918312L,
},
            new UInt64UInt64E0M
{
    Id = 93,
    Value = 4483689123348646674L,
    ModelInner = new UInt64UInt640MI
{
    Id = 74,
    Value = 8278751876955884904L,
    NullableValue = 2354633057707176618L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 101,
    Value = 836420313345108505L,
    ModelInner = new UInt64UInt640MI
{
    Id = 78,
    Value = 3577334902896456674L,
    NullableValue = 6896483918861142003L,
},
    NullableValue = 7270151901140976835L,
},
            new UInt64UInt64E0M
{
    Id = 107,
    Value = 8950375400072682521L,
    ModelInner = new UInt64UInt640MI
{
    Id = 84,
    Value = 1461476939501563202L,
    NullableValue = null,
},
    NullableValue = 6505794222909937360L,
},
            new UInt64UInt64E0M
{
    Id = 109,
    Value = 1195878824967249866L,
    ModelInner = new UInt64UInt640MI
{
    Id = 92,
    Value = 98537021807144912L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 113,
    Value = 135326856908882180L,
    ModelInner = new UInt64UInt640MI
{
    Id = 97,
    Value = 2815940748195984960L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 115,
    Value = 3873415614922787858L,
    ModelInner = new UInt64UInt640MI
{
    Id = 98,
    Value = 7001224212006521728L,
    NullableValue = 9171267508394182288L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 116,
    Value = 1791328602323968159L,
    ModelInner = new UInt64UInt640MI
{
    Id = 99,
    Value = 2889279668892163488L,
    NullableValue = 2229841086632219128L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 124,
    Value = 1399760991615847129L,
    ModelInner = new UInt64UInt640MI
{
    Id = 107,
    Value = 8823684836107493231L,
    NullableValue = null,
},
    NullableValue = 339418278496526628L,
},
            new UInt64UInt64E0M
{
    Id = 125,
    Value = 2156797971678596108L,
    ModelInner = new UInt64UInt640MI
{
    Id = 110,
    Value = 7965598227685595479L,
    NullableValue = null,
},
    NullableValue = 4172569576647431401L,
},
            new UInt64UInt64E0M
{
    Id = 132,
    Value = 6603507380360135807L,
    ModelInner = new UInt64UInt640MI
{
    Id = 117,
    Value = 5389617233130600638L,
    NullableValue = null,
},
    NullableValue = 1978921218488741633L,
},
            new UInt64UInt64E0M
{
    Id = 134,
    Value = 5609315283847878700L,
    ModelInner = new UInt64UInt640MI
{
    Id = 124,
    Value = 7384844837298688418L,
    NullableValue = null,
},
    NullableValue = 521933239517833167L,
},
            new UInt64UInt64E0M
{
    Id = 135,
    Value = 9213791418636642733L,
    ModelInner = new UInt64UInt640MI
{
    Id = 125,
    Value = 4242355089439020931L,
    NullableValue = 536457065562786987L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 140,
    Value = 2655690715716189794L,
    ModelInner = new UInt64UInt640MI
{
    Id = 128,
    Value = 622507909088186218L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 145,
    Value = 5997238000953356364L,
    ModelInner = new UInt64UInt640MI
{
    Id = 131,
    Value = 6421127732553157236L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 148,
    Value = 6883808313356720965L,
    ModelInner = new UInt64UInt640MI
{
    Id = 138,
    Value = 8157582378586103859L,
    NullableValue = 361068651826931296L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 153,
    Value = 3795891713361434577L,
    ModelInner = new UInt64UInt640MI
{
    Id = 146,
    Value = 4812301696287404303L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 160,
    Value = 4862049659130057158L,
    ModelInner = new UInt64UInt640MI
{
    Id = 149,
    Value = 8289556205030131690L,
    NullableValue = 6860594656992828169L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 162,
    Value = 4879610977254975435L,
    ModelInner = new UInt64UInt640MI
{
    Id = 155,
    Value = 5745354876060859114L,
    NullableValue = 7662784893011187878L,
},
    NullableValue = 4231788113930062090L,
},
            new UInt64UInt64E0M
{
    Id = 165,
    Value = 3594717787247254342L,
    ModelInner = new UInt64UInt640MI
{
    Id = 158,
    Value = 1664332922929880479L,
    NullableValue = 849926588954987221L,
},
    NullableValue = 47962826563130373L,
},
            new UInt64UInt64E0M
{
    Id = 173,
    Value = 6798087672495443207L,
    ModelInner = new UInt64UInt640MI
{
    Id = 159,
    Value = 4770311487461385187L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 177,
    Value = 7956870630384159065L,
    ModelInner = new UInt64UInt640MI
{
    Id = 166,
    Value = 2511582843775241373L,
    NullableValue = 8762421121754913192L,
},
    NullableValue = 5330478776349970357L,
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

