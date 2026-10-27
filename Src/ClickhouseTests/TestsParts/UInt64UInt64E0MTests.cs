

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
    Id = 6,
    Value = 730766411004093713L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 5,
    Value = 5550034062384876630L,
    NullableValue = null,
},
    NullableValue = 8751342863579308068L,
},
            new UInt64UInt64E0M
{
    Id = 8,
    Value = 4343593133308690423L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 10,
    Value = 9013360412142984893L,
    NullableValue = 1774020256430542232L,
},
    NullableValue = 3264906311784641200L,
},
            new UInt64UInt64E0M
{
    Id = 12,
    Value = 4274340654364587273L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 16,
    Value = 5968593268945771012L,
    NullableValue = 1855260981716106660L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 21,
    Value = 2205582300571687817L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 24,
    Value = 4641274544647335157L,
    NullableValue = null,
},
    NullableValue = 1761259462440510519L,
},
            new UInt64UInt64E0M
{
    Id = 28,
    Value = 1310402866574418172L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 32,
    Value = 1854501076978724450L,
    NullableValue = 7759827506113049042L,
},
    NullableValue = 7808568580865500429L,
},
            new UInt64UInt64E0M
{
    Id = 35,
    Value = 8550006633228023677L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 34,
    Value = 7746809790921564819L,
    NullableValue = 7858406067512355918L,
},
    NullableValue = 8780868078494678152L,
},
            new UInt64UInt64E0M
{
    Id = 36,
    Value = 3356125272124882268L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 39,
    Value = 6952180829877437181L,
    NullableValue = 4148325200299160425L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 45,
    Value = 2353693066441528985L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 47,
    Value = 3675583113773136913L,
    NullableValue = null,
},
    NullableValue = 1724494300527086620L,
},
            new UInt64UInt64E0M
{
    Id = 50,
    Value = 2075436713712190968L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 52,
    Value = 987921101176728591L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 54,
    Value = 4323518671020821596L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 54,
    Value = 7612808137555334011L,
    NullableValue = null,
},
    NullableValue = 8270573406106110041L,
},
            new UInt64UInt64E0M
{
    Id = 55,
    Value = 5050833715925577559L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 58,
    Value = 1397598352585193967L,
    NullableValue = null,
},
    NullableValue = 5004048396773424228L,
},
            new UInt64UInt64E0M
{
    Id = 64,
    Value = 7776450799564204288L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 64,
    Value = 2491466293564444272L,
    NullableValue = 6504670103596378732L,
},
    NullableValue = 4894538672101151785L,
},
            new UInt64UInt64E0M
{
    Id = 69,
    Value = 4873284192005912076L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 71,
    Value = 3230154602024265349L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 74,
    Value = 4474123151799639884L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 80,
    Value = 7115793853586687591L,
    NullableValue = 6495835772180010481L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 76,
    Value = 5291653310644256164L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 89,
    Value = 4279210386354082413L,
    NullableValue = 8694217936544187963L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 83,
    Value = 9122842711572059760L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 95,
    Value = 3110553725232921600L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 88,
    Value = 7659131751020199015L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 97,
    Value = 7994476190201322503L,
    NullableValue = null,
},
    NullableValue = 9014437044333400553L,
},
            new UInt64UInt64E0M
{
    Id = 89,
    Value = 4949688060818269669L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 100,
    Value = 1721743536762757039L,
    NullableValue = null,
},
    NullableValue = 7065407676267475140L,
},
            new UInt64UInt64E0M
{
    Id = 97,
    Value = 6113602228840772979L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 107,
    Value = 1034262111018107392L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 101,
    Value = 3425958782547695638L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 114,
    Value = 7484947181260270761L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 106,
    Value = 8252826823536498296L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 121,
    Value = 4231105716276358435L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 113,
    Value = 6795273607222064711L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 128,
    Value = 9028935984512456577L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 114,
    Value = 2410488651255863685L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 130,
    Value = 3213056831875188600L,
    NullableValue = null,
},
    NullableValue = 1979929503007167516L,
},
            new UInt64UInt64E0M
{
    Id = 121,
    Value = 4056083375288836706L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 138,
    Value = 5942502768252549961L,
    NullableValue = null,
},
    NullableValue = 6667512554228966381L,
},
            new UInt64UInt64E0M
{
    Id = 124,
    Value = 8465429307609606698L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 142,
    Value = 7974350716808564803L,
    NullableValue = 7121957456729076229L,
},
    NullableValue = 5253047637837804217L,
},
            new UInt64UInt64E0M
{
    Id = 131,
    Value = 3626732093839003190L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 145,
    Value = 7964216541670725424L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 140,
    Value = 3714731036131206275L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 147,
    Value = 6645608547760048988L,
    NullableValue = null,
},
    NullableValue = 6086094640784614362L,
},
            new UInt64UInt64E0M
{
    Id = 148,
    Value = 2879300358591057800L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 148,
    Value = 2284578889454185073L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 157,
    Value = 1676343416983388815L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 153,
    Value = 8337196525541954328L,
    NullableValue = 3867800029651787343L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 165,
    Value = 7985280562194121867L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 159,
    Value = 6942098982696390381L,
    NullableValue = null,
},
    NullableValue = 7201817689428641653L,
},
            new UInt64UInt64E0M
{
    Id = 166,
    Value = 7495363572905127566L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 166,
    Value = 46132481944756958L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 168,
    Value = 4863977229669345380L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 169,
    Value = 661128313302477999L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 173,
    Value = 8050699399184441669L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 172,
    Value = 3324732671366052277L,
    NullableValue = 2832804666313738948L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 174,
    Value = 2892392411853717293L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 180,
    Value = 184669744455425546L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 180,
    Value = 5915579902458054909L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 181,
    Value = 4927568712613095984L,
    NullableValue = 5805342488571298747L,
},
    NullableValue = 2636195361749932942L,
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

