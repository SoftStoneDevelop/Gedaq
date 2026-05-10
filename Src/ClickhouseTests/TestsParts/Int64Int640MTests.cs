

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
    Id = 3,
    Value = 6197661093772409567L,
    ModelInner = new Int64Int640MI
{
    Id = 3,
    Value = 2865643119069307662L,
    NullableValue = null,
},
    NullableValue = 7652166779552151754L,
},
            new Int64Int640M
{
    Id = 6,
    Value = 5718996665266834636L,
    ModelInner = new Int64Int640MI
{
    Id = 6,
    Value = 249696937804504850L,
    NullableValue = 6062780729162359410L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 12,
    Value = 8249496107320338914L,
    ModelInner = new Int64Int640MI
{
    Id = 15,
    Value = 2608216959476530856L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 14,
    Value = 3860601198043504748L,
    ModelInner = new Int64Int640MI
{
    Id = 19,
    Value = 1003826698539768534L,
    NullableValue = null,
},
    NullableValue = 6396411338926718135L,
},
            new Int64Int640M
{
    Id = 18,
    Value = 1384254105982311880L,
    ModelInner = new Int64Int640MI
{
    Id = 28,
    Value = 2438618011358239150L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 25,
    Value = 1048376598890825696L,
    ModelInner = new Int64Int640MI
{
    Id = 32,
    Value = 2484394890280548929L,
    NullableValue = 4462516907065954526L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 28,
    Value = 172933410334021774L,
    ModelInner = new Int64Int640MI
{
    Id = 41,
    Value = 7394961393949473397L,
    NullableValue = 6967541418299148142L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 30,
    Value = 6993384143001523019L,
    ModelInner = new Int64Int640MI
{
    Id = 47,
    Value = 5713315890167557656L,
    NullableValue = null,
},
    NullableValue = 5675884915048799207L,
},
            new Int64Int640M
{
    Id = 34,
    Value = 4818401042950116759L,
    ModelInner = new Int64Int640MI
{
    Id = 56,
    Value = 668792140580185820L,
    NullableValue = null,
},
    NullableValue = 5184642445310568424L,
},
            new Int64Int640M
{
    Id = 38,
    Value = 1128116345953365799L,
    ModelInner = new Int64Int640MI
{
    Id = 62,
    Value = 9019542171856456393L,
    NullableValue = 4598120267963682868L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 43,
    Value = 7502346365167635075L,
    ModelInner = new Int64Int640MI
{
    Id = 66,
    Value = 8869519509970537981L,
    NullableValue = 7189458558675216438L,
},
    NullableValue = 9078820440781806589L,
},
            new Int64Int640M
{
    Id = 48,
    Value = 783638882701204407L,
    ModelInner = new Int64Int640MI
{
    Id = 71,
    Value = 5560499232199194001L,
    NullableValue = 756350798982318978L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 53,
    Value = 5493455833627428932L,
    ModelInner = new Int64Int640MI
{
    Id = 80,
    Value = 6061046227297124470L,
    NullableValue = null,
},
    NullableValue = 3011960506164457875L,
},
            new Int64Int640M
{
    Id = 56,
    Value = 9076467021955624556L,
    ModelInner = new Int64Int640MI
{
    Id = 86,
    Value = 7432169241716243349L,
    NullableValue = null,
},
    NullableValue = 1285331085472999467L,
},
            new Int64Int640M
{
    Id = 62,
    Value = 7671928792001524496L,
    ModelInner = new Int64Int640MI
{
    Id = 93,
    Value = 6609940649082650177L,
    NullableValue = null,
},
    NullableValue = 5117888269511403867L,
},
            new Int64Int640M
{
    Id = 71,
    Value = 7745896723736725018L,
    ModelInner = new Int64Int640MI
{
    Id = 100,
    Value = 8151700346071232417L,
    NullableValue = 7363313775026928623L,
},
    NullableValue = 2040463601892329743L,
},
            new Int64Int640M
{
    Id = 76,
    Value = 8539217017600670587L,
    ModelInner = new Int64Int640MI
{
    Id = 107,
    Value = 4371288113399667541L,
    NullableValue = 2414314356566391234L,
},
    NullableValue = 444837535244393390L,
},
            new Int64Int640M
{
    Id = 85,
    Value = 673084372829151426L,
    ModelInner = new Int64Int640MI
{
    Id = 108,
    Value = 1398693099146659350L,
    NullableValue = 8960777029060666872L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 91,
    Value = 1591314999190869518L,
    ModelInner = new Int64Int640MI
{
    Id = 110,
    Value = 5464077393259603827L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 100,
    Value = 1307485485752443951L,
    ModelInner = new Int64Int640MI
{
    Id = 119,
    Value = 2797901669098731660L,
    NullableValue = null,
},
    NullableValue = 5173963801848523726L,
},
            new Int64Int640M
{
    Id = 108,
    Value = 7136041875348635565L,
    ModelInner = new Int64Int640MI
{
    Id = 126,
    Value = 3567419489458873240L,
    NullableValue = 6422909987599680963L,
},
    NullableValue = 651269987602194567L,
},
            new Int64Int640M
{
    Id = 117,
    Value = 804741771382213833L,
    ModelInner = new Int64Int640MI
{
    Id = 133,
    Value = 7563682523930235820L,
    NullableValue = 1056879583821484401L,
},
    NullableValue = 8922305140244850227L,
},
            new Int64Int640M
{
    Id = 125,
    Value = 5396172006296967511L,
    ModelInner = new Int64Int640MI
{
    Id = 142,
    Value = 1611849047869111498L,
    NullableValue = null,
},
    NullableValue = 7509875948759442521L,
},
            new Int64Int640M
{
    Id = 129,
    Value = 4124106615863175244L,
    ModelInner = new Int64Int640MI
{
    Id = 147,
    Value = 4210806672741295550L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 137,
    Value = 2891496020481816972L,
    ModelInner = new Int64Int640MI
{
    Id = 151,
    Value = 1467321852351859325L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 141,
    Value = 2099989386866413961L,
    ModelInner = new Int64Int640MI
{
    Id = 155,
    Value = 1062151638238502959L,
    NullableValue = null,
},
    NullableValue = 3547650583155181357L,
},
            new Int64Int640M
{
    Id = 143,
    Value = 7982375857488924729L,
    ModelInner = new Int64Int640MI
{
    Id = 159,
    Value = 2940119240228281098L,
    NullableValue = 5231203349794619036L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 145,
    Value = 8447275097409674920L,
    ModelInner = new Int64Int640MI
{
    Id = 167,
    Value = 5175835054997938171L,
    NullableValue = null,
},
    NullableValue = 7306636214979486140L,
},
            new Int64Int640M
{
    Id = 152,
    Value = 2066850425984181548L,
    ModelInner = new Int64Int640MI
{
    Id = 169,
    Value = 590477836835245313L,
    NullableValue = 7228590498973010700L,
},
    NullableValue = 3640911717790901421L,
},
            new Int64Int640M
{
    Id = 157,
    Value = 3092967760685394932L,
    ModelInner = new Int64Int640MI
{
    Id = 175,
    Value = 8127939823546047433L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 163,
    Value = 943104858926689243L,
    ModelInner = new Int64Int640MI
{
    Id = 176,
    Value = 6508678435964466606L,
    NullableValue = 7128740865415349695L,
},
    NullableValue = 6993808935913587917L,
},
            new Int64Int640M
{
    Id = 172,
    Value = 4718773740361935823L,
    ModelInner = new Int64Int640MI
{
    Id = 178,
    Value = 3101966793509876640L,
    NullableValue = 5945905012002479921L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 181,
    Value = 6947616927979302712L,
    ModelInner = new Int64Int640MI
{
    Id = 187,
    Value = 8008814574007779261L,
    NullableValue = 5502426463660406870L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 184,
    Value = 5447266245035310937L,
    ModelInner = new Int64Int640MI
{
    Id = 193,
    Value = 8013110313956685190L,
    NullableValue = 6165525090971420830L,
},
    NullableValue = null,
},
            new Int64Int640M
{
    Id = 185,
    Value = 1266992526506307898L,
    ModelInner = new Int64Int640MI
{
    Id = 201,
    Value = 6893527665809019747L,
    NullableValue = 328356218044304495L,
},
    NullableValue = 251025230138812219L,
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

