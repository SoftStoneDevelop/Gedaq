

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
    Id = 2,
    Value = 8322348540643870384L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 7,
    Value = 8487740730844937770L,
    NullableValue = null,
},
    NullableValue = 4366370988920848504L,
},
            new UInt64UInt64E0M
{
    Id = 3,
    Value = 8274124160883941676L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 16,
    Value = 7902520047259066670L,
    NullableValue = 1558470932880457498L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 10,
    Value = 8290949910255598465L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 19,
    Value = 2424675217371781115L,
    NullableValue = null,
},
    NullableValue = 1340633993330722853L,
},
            new UInt64UInt64E0M
{
    Id = 11,
    Value = 7524199995772389555L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 28,
    Value = 380233910272316659L,
    NullableValue = null,
},
    NullableValue = 3420487797570567319L,
},
            new UInt64UInt64E0M
{
    Id = 17,
    Value = 5503737493934779477L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 34,
    Value = 5646753071792675145L,
    NullableValue = 7661138874546036506L,
},
    NullableValue = 6636326677085623092L,
},
            new UInt64UInt64E0M
{
    Id = 23,
    Value = 716632488664581483L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 41,
    Value = 6702007472671047523L,
    NullableValue = null,
},
    NullableValue = 3233324591040794899L,
},
            new UInt64UInt64E0M
{
    Id = 31,
    Value = 4445475480848583698L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 48,
    Value = 6726131554068873742L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 35,
    Value = 2822583818265106844L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 49,
    Value = 4648481044096537910L,
    NullableValue = 4426859434234786044L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 39,
    Value = 3344319018518865946L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 56,
    Value = 6443581814093154303L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 40,
    Value = 7948466104554632793L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 58,
    Value = 3829278157900590905L,
    NullableValue = 9023624697334196190L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 47,
    Value = 6367388168209441200L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 62,
    Value = 4938034194334655046L,
    NullableValue = 7291637642243681963L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 48,
    Value = 1775839186852757484L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 66,
    Value = 6559477917163953089L,
    NullableValue = 8017600704596217716L,
},
    NullableValue = 7527110894872992582L,
},
            new UInt64UInt64E0M
{
    Id = 52,
    Value = 4068543398690420887L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 67,
    Value = 2203668659653744554L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 57,
    Value = 789790018575294581L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 71,
    Value = 6073406772327763174L,
    NullableValue = 1146639517334388461L,
},
    NullableValue = 3586890288835862234L,
},
            new UInt64UInt64E0M
{
    Id = 62,
    Value = 5894325901983034863L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 80,
    Value = 8069914962648756984L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 63,
    Value = 1725902411539147669L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 85,
    Value = 4659554114035288149L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 67,
    Value = 5588326048716716291L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 91,
    Value = 8226825563422219239L,
    NullableValue = 2136634608387380482L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 71,
    Value = 3522159528564582769L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 93,
    Value = 6920118309356825813L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 78,
    Value = 4376166596521960436L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 98,
    Value = 7444027010524661499L,
    NullableValue = 8083077864210296891L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 79,
    Value = 377670828598990980L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 103,
    Value = 3113575885976081148L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 84,
    Value = 1691384324946822673L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 112,
    Value = 7868325579530162567L,
    NullableValue = 201915527791190221L,
},
    NullableValue = 1242891182587149039L,
},
            new UInt64UInt64E0M
{
    Id = 89,
    Value = 5803070048646239825L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 114,
    Value = 6266825508298624483L,
    NullableValue = 5985315997333638446L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 95,
    Value = 5811284409597577875L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 117,
    Value = 1535422574610138910L,
    NullableValue = 835075896874878605L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 104,
    Value = 9199538769953882844L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 124,
    Value = 4666691792488337208L,
    NullableValue = null,
},
    NullableValue = 4399269356592548063L,
},
            new UInt64UInt64E0M
{
    Id = 111,
    Value = 5213832440365745157L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 133,
    Value = 7437928847483759731L,
    NullableValue = null,
},
    NullableValue = 6317806464514439836L,
},
            new UInt64UInt64E0M
{
    Id = 113,
    Value = 3113359693036033059L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 138,
    Value = 4137542851689710116L,
    NullableValue = 5810319908109055790L,
},
    NullableValue = 6001447377366882460L,
},
            new UInt64UInt64E0M
{
    Id = 116,
    Value = 2178541301162924970L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 146,
    Value = 8258751968623615986L,
    NullableValue = null,
},
    NullableValue = 100054981772370424L,
},
            new UInt64UInt64E0M
{
    Id = 124,
    Value = 6145071202050509463L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 155,
    Value = 2709116156334863146L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 127,
    Value = 1965212831457210181L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 157,
    Value = 3782738254743736593L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 128,
    Value = 9022741700420208912L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 163,
    Value = 6939269636943031575L,
    NullableValue = 4925071431773465798L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 136,
    Value = 8040073609156402131L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 170,
    Value = 7374136400016633787L,
    NullableValue = 3337151019270408879L,
},
    NullableValue = 7406934595854800060L,
},
            new UInt64UInt64E0M
{
    Id = 140,
    Value = 7628789168518758371L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 171,
    Value = 6936071432301272893L,
    NullableValue = 2786186926241467285L,
},
    NullableValue = 7313405488528161655L,
},
            new UInt64UInt64E0M
{
    Id = 142,
    Value = 3085904045320219073L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 173,
    Value = 7274410650297383365L,
    NullableValue = null,
},
    NullableValue = 8006955200817103440L,
},
            new UInt64UInt64E0M
{
    Id = 144,
    Value = 5061626184883395041L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 174,
    Value = 930079977248098224L,
    NullableValue = 8204630085552072266L,
},
    NullableValue = 1425718299426266315L,
},
            new UInt64UInt64E0M
{
    Id = 150,
    Value = 6078780305708789993L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 178,
    Value = 4519509445769371280L,
    NullableValue = 6366466930006031787L,
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

