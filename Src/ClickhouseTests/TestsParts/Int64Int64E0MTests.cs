

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
    Value = 502319635069992310L,
    ModelInner = new Int64Int640MI
{
    Id = 7,
    Value = 4704955207840241007L,
    NullableValue = 7618438237668963427L,
},
    NullableValue = 6509663070837970163L,
},
            new Int64Int64E0M
{
    Id = 4,
    Value = 1496077576413226778L,
    ModelInner = new Int64Int640MI
{
    Id = 15,
    Value = 2642036020748351847L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 9,
    Value = 577005733836939298L,
    ModelInner = new Int64Int640MI
{
    Id = 23,
    Value = 1345974627612293762L,
    NullableValue = null,
},
    NullableValue = 5457782743593389552L,
},
            new Int64Int64E0M
{
    Id = 12,
    Value = 5056950229024524858L,
    ModelInner = new Int64Int640MI
{
    Id = 29,
    Value = 6110474431554751074L,
    NullableValue = 1347011847295824458L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 17,
    Value = 8143236580553009216L,
    ModelInner = new Int64Int640MI
{
    Id = 36,
    Value = 8023112117821873817L,
    NullableValue = null,
},
    NullableValue = 5346261471812913375L,
},
            new Int64Int64E0M
{
    Id = 24,
    Value = 4793517271101725571L,
    ModelInner = new Int64Int640MI
{
    Id = 43,
    Value = 6569488517676943750L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 33,
    Value = 2050841732399570473L,
    ModelInner = new Int64Int640MI
{
    Id = 50,
    Value = 3847515108442356245L,
    NullableValue = null,
},
    NullableValue = 7043462763588539532L,
},
            new Int64Int64E0M
{
    Id = 41,
    Value = 6564441096619759101L,
    ModelInner = new Int64Int640MI
{
    Id = 53,
    Value = 7785197813080191762L,
    NullableValue = 5029411959262457912L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 48,
    Value = 5959801900362399856L,
    ModelInner = new Int64Int640MI
{
    Id = 61,
    Value = 3458859864340543438L,
    NullableValue = null,
},
    NullableValue = 7404589066983410428L,
},
            new Int64Int64E0M
{
    Id = 57,
    Value = 2660686207742838606L,
    ModelInner = new Int64Int640MI
{
    Id = 68,
    Value = 609337339661219464L,
    NullableValue = 6577631272612843916L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 58,
    Value = 8183047030829748518L,
    ModelInner = new Int64Int640MI
{
    Id = 73,
    Value = 4420465707209570312L,
    NullableValue = 8103745199499137006L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 62,
    Value = 2710935154755814055L,
    ModelInner = new Int64Int640MI
{
    Id = 79,
    Value = 96144647430930330L,
    NullableValue = 2662909319601752062L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 65,
    Value = 2061780460556412844L,
    ModelInner = new Int64Int640MI
{
    Id = 81,
    Value = 5665410803567507171L,
    NullableValue = 4347852208719413217L,
},
    NullableValue = 1945199402003849039L,
},
            new Int64Int64E0M
{
    Id = 66,
    Value = 5478014719029454365L,
    ModelInner = new Int64Int640MI
{
    Id = 86,
    Value = 3690145128970001446L,
    NullableValue = 7142463971868361235L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 74,
    Value = 4606914358357849689L,
    ModelInner = new Int64Int640MI
{
    Id = 93,
    Value = 4839999568351860273L,
    NullableValue = 4921212328247162709L,
},
    NullableValue = 7387940075512181619L,
},
            new Int64Int64E0M
{
    Id = 75,
    Value = 4211717465107419899L,
    ModelInner = new Int64Int640MI
{
    Id = 96,
    Value = 5573757641514670777L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 84,
    Value = 4024925726307291498L,
    ModelInner = new Int64Int640MI
{
    Id = 102,
    Value = 8732207018719436925L,
    NullableValue = null,
},
    NullableValue = 5584690953011403099L,
},
            new Int64Int64E0M
{
    Id = 92,
    Value = 4563226913096081217L,
    ModelInner = new Int64Int640MI
{
    Id = 106,
    Value = 3394850281330383093L,
    NullableValue = 6321382341335165950L,
},
    NullableValue = 1684838823211953219L,
},
            new Int64Int64E0M
{
    Id = 98,
    Value = 7629488481816576520L,
    ModelInner = new Int64Int640MI
{
    Id = 109,
    Value = 7675081406423007529L,
    NullableValue = 5883063539104406810L,
},
    NullableValue = 2666742773677831410L,
},
            new Int64Int64E0M
{
    Id = 106,
    Value = 6962919108317168738L,
    ModelInner = new Int64Int640MI
{
    Id = 114,
    Value = 6870775979642931085L,
    NullableValue = 5303364638682470685L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 107,
    Value = 1757487971675798032L,
    ModelInner = new Int64Int640MI
{
    Id = 116,
    Value = 5024101127059102748L,
    NullableValue = null,
},
    NullableValue = 1458395004085206785L,
},
            new Int64Int64E0M
{
    Id = 114,
    Value = 4100200640151474688L,
    ModelInner = new Int64Int640MI
{
    Id = 119,
    Value = 5995881396098669005L,
    NullableValue = null,
},
    NullableValue = 3942900140333245331L,
},
            new Int64Int64E0M
{
    Id = 122,
    Value = 639443828442951904L,
    ModelInner = new Int64Int640MI
{
    Id = 123,
    Value = 6509605427772528496L,
    NullableValue = 7532984138186968422L,
},
    NullableValue = 3637902088733701361L,
},
            new Int64Int64E0M
{
    Id = 128,
    Value = 523970974439971915L,
    ModelInner = new Int64Int640MI
{
    Id = 127,
    Value = 4891069843523970248L,
    NullableValue = 2376495370673165593L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 136,
    Value = 9018292321856579349L,
    ModelInner = new Int64Int640MI
{
    Id = 134,
    Value = 805134340991850670L,
    NullableValue = 3781072466990745720L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 143,
    Value = 1955112615866660927L,
    ModelInner = new Int64Int640MI
{
    Id = 142,
    Value = 383027612642142925L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 146,
    Value = 5410542970074151455L,
    ModelInner = new Int64Int640MI
{
    Id = 151,
    Value = 1548535853007926081L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 149,
    Value = 7873479917087614527L,
    ModelInner = new Int64Int640MI
{
    Id = 154,
    Value = 4230469621037190984L,
    NullableValue = 5077531631764233736L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 158,
    Value = 940806823731801689L,
    ModelInner = new Int64Int640MI
{
    Id = 155,
    Value = 8514684488942507838L,
    NullableValue = 2992434636217909479L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 166,
    Value = 1856410542378346445L,
    ModelInner = new Int64Int640MI
{
    Id = 164,
    Value = 5367198629784505237L,
    NullableValue = 7431764399201738931L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 173,
    Value = 3093944908252341854L,
    ModelInner = new Int64Int640MI
{
    Id = 172,
    Value = 2176079394621665412L,
    NullableValue = 2467522304496936988L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 182,
    Value = 1365118926827032928L,
    ModelInner = new Int64Int640MI
{
    Id = 179,
    Value = 2097030877535102594L,
    NullableValue = 553077160595064665L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 191,
    Value = 542213412230259939L,
    ModelInner = new Int64Int640MI
{
    Id = 182,
    Value = 4034046150129966167L,
    NullableValue = 6341330363071248113L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 192,
    Value = 1142568829132556130L,
    ModelInner = new Int64Int640MI
{
    Id = 184,
    Value = 6222456694204234012L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 197,
    Value = 4998100094502916875L,
    ModelInner = new Int64Int640MI
{
    Id = 187,
    Value = 5336086344842602822L,
    NullableValue = 6633459542769901545L,
},
    NullableValue = 3143865218164382494L,
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

