

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
    Id = 1,
    Value = 8658154563005309956L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 4,
    Value = 5096769439564406382L,
    NullableValue = null,
},
    NullableValue = 4546433285910176311L,
},
            new UInt64UInt64E0M
{
    Id = 10,
    Value = 8232901310221218779L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 6,
    Value = 3163845463026220402L,
    NullableValue = 5867903539983121890L,
},
    NullableValue = 7360421571240152455L,
},
            new UInt64UInt64E0M
{
    Id = 18,
    Value = 4718769780360002076L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 12,
    Value = 1209452011629390186L,
    NullableValue = 6278155196074038535L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 27,
    Value = 8708726496905138440L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 17,
    Value = 7671297813968796168L,
    NullableValue = 6352287170569865635L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 30,
    Value = 6260455898254661332L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 25,
    Value = 2079941942372958274L,
    NullableValue = null,
},
    NullableValue = 2146635946136389367L,
},
            new UInt64UInt64E0M
{
    Id = 39,
    Value = 7534920144110572888L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 27,
    Value = 2970576813487105358L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 41,
    Value = 1515411731472425477L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 33,
    Value = 8746950227237973130L,
    NullableValue = 6801052177329511720L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 48,
    Value = 3627926772300412165L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 34,
    Value = 3838679283920113270L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 50,
    Value = 6148531903045089878L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 35,
    Value = 5570336287994297835L,
    NullableValue = 7920239395221823240L,
},
    NullableValue = 8637989955778214624L,
},
            new UInt64UInt64E0M
{
    Id = 59,
    Value = 3098617945557157554L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 37,
    Value = 8235842309176843598L,
    NullableValue = null,
},
    NullableValue = 5331085015399285708L,
},
            new UInt64UInt64E0M
{
    Id = 67,
    Value = 6586758306674265546L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 43,
    Value = 3910499940845835259L,
    NullableValue = null,
},
    NullableValue = 2305442694014706192L,
},
            new UInt64UInt64E0M
{
    Id = 69,
    Value = 3326708129447247040L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 47,
    Value = 2289713168322953536L,
    NullableValue = 9084435817060700874L,
},
    NullableValue = 7650171326132254651L,
},
            new UInt64UInt64E0M
{
    Id = 70,
    Value = 4623418600793002462L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 52,
    Value = 6471962600309542827L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 76,
    Value = 6890840752583662608L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 60,
    Value = 3299732998884522699L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 84,
    Value = 758133535940692193L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 63,
    Value = 3906466746837150710L,
    NullableValue = null,
},
    NullableValue = 3103984390702244787L,
},
            new UInt64UInt64E0M
{
    Id = 89,
    Value = 7766562850714973644L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 70,
    Value = 2940128841901139924L,
    NullableValue = 6543122445076633093L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 98,
    Value = 6324016364347444885L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 74,
    Value = 3927530116411452528L,
    NullableValue = 4476938468908944672L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 104,
    Value = 7848791928366400979L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 81,
    Value = 3362183904913370876L,
    NullableValue = 2250664954856245135L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 107,
    Value = 9160513980536699128L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 86,
    Value = 4868078303988143568L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 108,
    Value = 7198463718128871354L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 91,
    Value = 1535172919254468006L,
    NullableValue = 8088436292686886578L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 114,
    Value = 3845310225879054676L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 93,
    Value = 1281038066259938298L,
    NullableValue = 7599614177116407280L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 118,
    Value = 5769068820303516756L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 94,
    Value = 5622188580892724038L,
    NullableValue = 4000553897487470959L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 126,
    Value = 8051619048091081293L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 97,
    Value = 449294253218101671L,
    NullableValue = null,
},
    NullableValue = 5864665535478915967L,
},
            new UInt64UInt64E0M
{
    Id = 132,
    Value = 1925272669608825354L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 100,
    Value = 6174502206233346108L,
    NullableValue = null,
},
    NullableValue = 9038693099886813948L,
},
            new UInt64UInt64E0M
{
    Id = 141,
    Value = 8109578092888246566L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 109,
    Value = 6899338857333663266L,
    NullableValue = 3967087692627808244L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 146,
    Value = 6931293341341388811L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 115,
    Value = 8002470104434589832L,
    NullableValue = 5303475169201094806L,
},
    NullableValue = 6261176357514868470L,
},
            new UInt64UInt64E0M
{
    Id = 154,
    Value = 1521084577303470062L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 122,
    Value = 7408514701612906725L,
    NullableValue = 3539105859404658956L,
},
    NullableValue = 6409408196248928698L,
},
            new UInt64UInt64E0M
{
    Id = 163,
    Value = 6806921875345902784L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 128,
    Value = 9213205071970260403L,
    NullableValue = 5013949281982641955L,
},
    NullableValue = 8806056958804549908L,
},
            new UInt64UInt64E0M
{
    Id = 170,
    Value = 6717250585934621010L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 130,
    Value = 1293926386517479676L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 179,
    Value = 1038830993032829721L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 139,
    Value = 8030484861386724243L,
    NullableValue = 8167215111747930740L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 181,
    Value = 4508731385693767036L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 145,
    Value = 7474887234922518529L,
    NullableValue = 1699344130350492301L,
},
    NullableValue = 4951704907404582752L,
},
            new UInt64UInt64E0M
{
    Id = 186,
    Value = 1455432923082140343L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 150,
    Value = 3087892464509304634L,
    NullableValue = 4475963155168439651L,
},
    NullableValue = null,
},
            new UInt64UInt64E0M
{
    Id = 189,
    Value = 5046888542109682091L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 155,
    Value = 1512081450910351053L,
    NullableValue = 7467031920205225125L,
},
    NullableValue = 5849943917061966948L,
},
            new UInt64UInt64E0M
{
    Id = 190,
    Value = 7147699924872874652L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 164,
    Value = 7257952668049265284L,
    NullableValue = null,
},
    NullableValue = 1544034171796156840L,
},
            new UInt64UInt64E0M
{
    Id = 192,
    Value = 3772471665670688356L,
    ModelInner = new UInt64UInt64E0MI
{
    Id = 167,
    Value = 4781661261018735652L,
    NullableValue = 1153097120625300469L,
},
    NullableValue = 6915490058929933282L,
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

