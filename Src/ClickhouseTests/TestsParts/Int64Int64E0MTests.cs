

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
    Value = 1008411473525990775L,
    ModelInner = new Int64Int64E0MI
{
    Id = 2,
    Value = 3258752766440721765L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 6,
    Value = 44079568409515459L,
    ModelInner = new Int64Int64E0MI
{
    Id = 6,
    Value = 2933786499678173927L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 9,
    Value = 4852327603759418079L,
    ModelInner = new Int64Int64E0MI
{
    Id = 8,
    Value = 7933991782459249408L,
    NullableValue = 2080562179938449636L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 10,
    Value = 2674610424890607390L,
    ModelInner = new Int64Int64E0MI
{
    Id = 9,
    Value = 2300941477606464928L,
    NullableValue = 3080627185642770096L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 16,
    Value = 1615018436074326595L,
    ModelInner = new Int64Int64E0MI
{
    Id = 15,
    Value = 5515695490744273510L,
    NullableValue = null,
},
    NullableValue = 6232160892467897872L,
},
            new Int64Int64E0M
{
    Id = 17,
    Value = 6665089240990182463L,
    ModelInner = new Int64Int64E0MI
{
    Id = 20,
    Value = 5237435408159747194L,
    NullableValue = null,
},
    NullableValue = 4991350575615017625L,
},
            new Int64Int64E0M
{
    Id = 24,
    Value = 6358035393150438779L,
    ModelInner = new Int64Int64E0MI
{
    Id = 25,
    Value = 5708684140211833686L,
    NullableValue = null,
},
    NullableValue = 8927870546799440506L,
},
            new Int64Int64E0M
{
    Id = 30,
    Value = 7343899614364671419L,
    ModelInner = new Int64Int64E0MI
{
    Id = 33,
    Value = 5101027588251484L,
    NullableValue = 4305929945224097573L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 32,
    Value = 8656164794140849279L,
    ModelInner = new Int64Int64E0MI
{
    Id = 42,
    Value = 5966259472209523084L,
    NullableValue = null,
},
    NullableValue = 8877185324529118130L,
},
            new Int64Int64E0M
{
    Id = 39,
    Value = 1189008288192595419L,
    ModelInner = new Int64Int64E0MI
{
    Id = 46,
    Value = 712661488960597248L,
    NullableValue = 6894849030384636258L,
},
    NullableValue = 478971018063777109L,
},
            new Int64Int64E0M
{
    Id = 45,
    Value = 5389546725259308388L,
    ModelInner = new Int64Int64E0MI
{
    Id = 55,
    Value = 2047361282751327219L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 50,
    Value = 7212035976190126894L,
    ModelInner = new Int64Int64E0MI
{
    Id = 56,
    Value = 366459240587461561L,
    NullableValue = 4744466932071977753L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 51,
    Value = 3877626880186908645L,
    ModelInner = new Int64Int64E0MI
{
    Id = 62,
    Value = 4977724025660842065L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 59,
    Value = 5662170320761943944L,
    ModelInner = new Int64Int64E0MI
{
    Id = 66,
    Value = 137283083937731662L,
    NullableValue = 4032223378744921875L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 62,
    Value = 6128613915742418410L,
    ModelInner = new Int64Int64E0MI
{
    Id = 67,
    Value = 6122693649688197453L,
    NullableValue = 3390807484855666752L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 66,
    Value = 8208228845485125806L,
    ModelInner = new Int64Int64E0MI
{
    Id = 70,
    Value = 2631145350200074102L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 75,
    Value = 2866713725633516426L,
    ModelInner = new Int64Int64E0MI
{
    Id = 79,
    Value = 2316100699161027275L,
    NullableValue = 8695147361418318680L,
},
    NullableValue = 6042245401482867455L,
},
            new Int64Int64E0M
{
    Id = 76,
    Value = 7435217055332071920L,
    ModelInner = new Int64Int64E0MI
{
    Id = 84,
    Value = 6821753435242886334L,
    NullableValue = null,
},
    NullableValue = 2218711546386589204L,
},
            new Int64Int64E0M
{
    Id = 77,
    Value = 5595838698995731617L,
    ModelInner = new Int64Int64E0MI
{
    Id = 87,
    Value = 2127443660848071605L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 86,
    Value = 7874060566074660440L,
    ModelInner = new Int64Int64E0MI
{
    Id = 89,
    Value = 6416920375320187862L,
    NullableValue = 5142678760185927016L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 91,
    Value = 1684976996257450667L,
    ModelInner = new Int64Int64E0MI
{
    Id = 98,
    Value = 3527027326070563186L,
    NullableValue = 3110079657364307181L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 96,
    Value = 7877707719688115904L,
    ModelInner = new Int64Int64E0MI
{
    Id = 106,
    Value = 6996888990882213053L,
    NullableValue = null,
},
    NullableValue = 4980818915734965406L,
},
            new Int64Int64E0M
{
    Id = 98,
    Value = 4809375935743185261L,
    ModelInner = new Int64Int64E0MI
{
    Id = 113,
    Value = 4976118615117284797L,
    NullableValue = 7385641391645579671L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 101,
    Value = 8130395952114154985L,
    ModelInner = new Int64Int64E0MI
{
    Id = 114,
    Value = 3120430721326773498L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 105,
    Value = 8114211380659415632L,
    ModelInner = new Int64Int64E0MI
{
    Id = 115,
    Value = 5401109791886028352L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 110,
    Value = 3743025455779992975L,
    ModelInner = new Int64Int64E0MI
{
    Id = 117,
    Value = 7814756853880833497L,
    NullableValue = 7838382862969870584L,
},
    NullableValue = 1742748254027950894L,
},
            new Int64Int64E0M
{
    Id = 113,
    Value = 4985256282651926327L,
    ModelInner = new Int64Int64E0MI
{
    Id = 120,
    Value = 1110097666365185703L,
    NullableValue = 6599495940697226609L,
},
    NullableValue = 6151417756179805045L,
},
            new Int64Int64E0M
{
    Id = 116,
    Value = 4915909430923491739L,
    ModelInner = new Int64Int64E0MI
{
    Id = 129,
    Value = 1200977818219851054L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 119,
    Value = 1526484020030403875L,
    ModelInner = new Int64Int64E0MI
{
    Id = 136,
    Value = 976586654292759071L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 120,
    Value = 1994644418987851743L,
    ModelInner = new Int64Int64E0MI
{
    Id = 143,
    Value = 8823589890261949774L,
    NullableValue = null,
},
    NullableValue = 8961174916392358722L,
},
            new Int64Int64E0M
{
    Id = 125,
    Value = 3677605087276740981L,
    ModelInner = new Int64Int64E0MI
{
    Id = 148,
    Value = 4557204572322160771L,
    NullableValue = 1646181956450142840L,
},
    NullableValue = 4473160714533416841L,
},
            new Int64Int64E0M
{
    Id = 131,
    Value = 7839823001670412644L,
    ModelInner = new Int64Int64E0MI
{
    Id = 149,
    Value = 2714422684013488413L,
    NullableValue = 2676502577584809681L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 136,
    Value = 8276859568822654318L,
    ModelInner = new Int64Int64E0MI
{
    Id = 157,
    Value = 6371115831906191667L,
    NullableValue = 3270657239989016211L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 138,
    Value = 4774852516133374933L,
    ModelInner = new Int64Int64E0MI
{
    Id = 164,
    Value = 8443786543587195068L,
    NullableValue = 8120259188457133026L,
},
    NullableValue = 2318698625480684395L,
},
            new Int64Int64E0M
{
    Id = 139,
    Value = 7916699503883951997L,
    ModelInner = new Int64Int64E0MI
{
    Id = 171,
    Value = 4798070155347616723L,
    NullableValue = null,
},
    NullableValue = 5849948916049951093L,
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

