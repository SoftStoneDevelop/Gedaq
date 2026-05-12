

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
    Id = 5,
    Value = 5035037180999566638L,
    ModelInner = new Int64Int64E0MI
{
    Id = 1,
    Value = 3817367393643670753L,
    NullableValue = 6154738607644592542L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 12,
    Value = 3090328760803045811L,
    ModelInner = new Int64Int64E0MI
{
    Id = 5,
    Value = 8358160433714497456L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 17,
    Value = 2233093106142324634L,
    ModelInner = new Int64Int64E0MI
{
    Id = 6,
    Value = 7779283656238675303L,
    NullableValue = 5537914683998344016L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 25,
    Value = 2044962909004562076L,
    ModelInner = new Int64Int64E0MI
{
    Id = 12,
    Value = 632171857474549111L,
    NullableValue = 5237681948974016209L,
},
    NullableValue = 6913820485020191814L,
},
            new Int64Int64E0M
{
    Id = 27,
    Value = 319587337205426236L,
    ModelInner = new Int64Int64E0MI
{
    Id = 21,
    Value = 4590257683333648043L,
    NullableValue = null,
},
    NullableValue = 6326757504095196334L,
},
            new Int64Int64E0M
{
    Id = 33,
    Value = 170802914500725864L,
    ModelInner = new Int64Int64E0MI
{
    Id = 30,
    Value = 2716901254386875226L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 35,
    Value = 4943856475413139858L,
    ModelInner = new Int64Int64E0MI
{
    Id = 35,
    Value = 334559320430342585L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 38,
    Value = 9044210330706356008L,
    ModelInner = new Int64Int64E0MI
{
    Id = 41,
    Value = 3868133391426110784L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 47,
    Value = 3802408740814893632L,
    ModelInner = new Int64Int64E0MI
{
    Id = 47,
    Value = 3710448777957423305L,
    NullableValue = 6566228062462532603L,
},
    NullableValue = 4104771604527385296L,
},
            new Int64Int64E0M
{
    Id = 55,
    Value = 9124803867546013L,
    ModelInner = new Int64Int64E0MI
{
    Id = 53,
    Value = 1323176299359576687L,
    NullableValue = 8362058356657000668L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 63,
    Value = 1731565846994164340L,
    ModelInner = new Int64Int64E0MI
{
    Id = 55,
    Value = 666368563207976103L,
    NullableValue = 8725837045498955301L,
},
    NullableValue = 3958695870831186982L,
},
            new Int64Int64E0M
{
    Id = 67,
    Value = 5795407031180666118L,
    ModelInner = new Int64Int64E0MI
{
    Id = 60,
    Value = 7609128766327680290L,
    NullableValue = 570411196632605061L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 72,
    Value = 4138877670873944621L,
    ModelInner = new Int64Int64E0MI
{
    Id = 63,
    Value = 8991779159854870217L,
    NullableValue = 871856235279882659L,
},
    NullableValue = 4243205302564025161L,
},
            new Int64Int64E0M
{
    Id = 77,
    Value = 1371593759186982152L,
    ModelInner = new Int64Int64E0MI
{
    Id = 65,
    Value = 5299741775928995265L,
    NullableValue = 7632754511637359363L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 80,
    Value = 2420546333653397230L,
    ModelInner = new Int64Int64E0MI
{
    Id = 70,
    Value = 5122850712053739068L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 83,
    Value = 6319569393132329186L,
    ModelInner = new Int64Int64E0MI
{
    Id = 73,
    Value = 8231722047908326305L,
    NullableValue = 5469307583574631943L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 86,
    Value = 953495914233600578L,
    ModelInner = new Int64Int64E0MI
{
    Id = 81,
    Value = 759906097330586888L,
    NullableValue = 4509656003192517138L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 87,
    Value = 4858271551725630771L,
    ModelInner = new Int64Int64E0MI
{
    Id = 83,
    Value = 6788387498227375425L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 90,
    Value = 3850433103982671538L,
    ModelInner = new Int64Int64E0MI
{
    Id = 91,
    Value = 5641369385129310971L,
    NullableValue = null,
},
    NullableValue = 6659979513489691256L,
},
            new Int64Int64E0M
{
    Id = 97,
    Value = 4748665178130621029L,
    ModelInner = new Int64Int64E0MI
{
    Id = 94,
    Value = 350286798148914316L,
    NullableValue = null,
},
    NullableValue = 1633919879364630566L,
},
            new Int64Int64E0M
{
    Id = 100,
    Value = 1668107184679342428L,
    ModelInner = new Int64Int64E0MI
{
    Id = 96,
    Value = 8699290934399009717L,
    NullableValue = 3356368250655193509L,
},
    NullableValue = 7467956200579039280L,
},
            new Int64Int64E0M
{
    Id = 101,
    Value = 831936275563493901L,
    ModelInner = new Int64Int64E0MI
{
    Id = 98,
    Value = 15655772568425191L,
    NullableValue = 4402620490671072032L,
},
    NullableValue = 2004462381658101329L,
},
            new Int64Int64E0M
{
    Id = 110,
    Value = 5226087701905151758L,
    ModelInner = new Int64Int64E0MI
{
    Id = 105,
    Value = 611993346003476714L,
    NullableValue = 2675377891157111728L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 117,
    Value = 496336232951535725L,
    ModelInner = new Int64Int64E0MI
{
    Id = 110,
    Value = 6112749002032494612L,
    NullableValue = 5077836717241663695L,
},
    NullableValue = 2905103791429785393L,
},
            new Int64Int64E0M
{
    Id = 125,
    Value = 1607368953998922684L,
    ModelInner = new Int64Int64E0MI
{
    Id = 116,
    Value = 4085885756154283701L,
    NullableValue = null,
},
    NullableValue = 1295634521461145519L,
},
            new Int64Int64E0M
{
    Id = 131,
    Value = 1159321200459758412L,
    ModelInner = new Int64Int64E0MI
{
    Id = 125,
    Value = 5294672636909989520L,
    NullableValue = 1812731234538395289L,
},
    NullableValue = 4063468279056253747L,
},
            new Int64Int64E0M
{
    Id = 139,
    Value = 3518713195157825199L,
    ModelInner = new Int64Int64E0MI
{
    Id = 132,
    Value = 5644369506514648175L,
    NullableValue = null,
},
    NullableValue = 8191441268244928930L,
},
            new Int64Int64E0M
{
    Id = 148,
    Value = 9137961916590834554L,
    ModelInner = new Int64Int64E0MI
{
    Id = 139,
    Value = 1279215028711247358L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 153,
    Value = 1082523198444877212L,
    ModelInner = new Int64Int64E0MI
{
    Id = 141,
    Value = 1986060350122800566L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 161,
    Value = 6655934543881092026L,
    ModelInner = new Int64Int64E0MI
{
    Id = 148,
    Value = 6747773866600914166L,
    NullableValue = 1733445559534339964L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 163,
    Value = 2704692935725584499L,
    ModelInner = new Int64Int64E0MI
{
    Id = 153,
    Value = 2069410995409056248L,
    NullableValue = null,
},
    NullableValue = 424812085990040592L,
},
            new Int64Int64E0M
{
    Id = 165,
    Value = 4767199690046392312L,
    ModelInner = new Int64Int64E0MI
{
    Id = 161,
    Value = 8421303762623840424L,
    NullableValue = null,
},
    NullableValue = 8492634799102016500L,
},
            new Int64Int64E0M
{
    Id = 174,
    Value = 7872785354894928375L,
    ModelInner = new Int64Int64E0MI
{
    Id = 170,
    Value = 8826990102323804540L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 182,
    Value = 8857597679517012304L,
    ModelInner = new Int64Int64E0MI
{
    Id = 179,
    Value = 5204517838435568295L,
    NullableValue = 3301299317869079460L,
},
    NullableValue = 306168466935417724L,
},
            new Int64Int64E0M
{
    Id = 185,
    Value = 3605641896194992755L,
    ModelInner = new Int64Int64E0MI
{
    Id = 182,
    Value = 3587121214309670882L,
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

