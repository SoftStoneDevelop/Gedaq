

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

        private readonly UInt64UInt640M[] _testData = new UInt64UInt640M[]
        {
            new UInt64UInt640M
{
    Id = 9,
    Value = 7382851675392679664L,
    ModelInner = new UInt64UInt640MI
{
    Id = 1,
    Value = 9034206686396750219L,
    NullableValue = 8841880541876641049L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 18,
    Value = 2121059836108929024L,
    ModelInner = new UInt64UInt640MI
{
    Id = 9,
    Value = 3104917649938814854L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 26,
    Value = 1031506464572605810L,
    ModelInner = new UInt64UInt640MI
{
    Id = 15,
    Value = 8916510201790178582L,
    NullableValue = 5233766993496679261L,
},
    NullableValue = 7178982072278725544L,
},
            new UInt64UInt640M
{
    Id = 31,
    Value = 5851044251542009436L,
    ModelInner = new UInt64UInt640MI
{
    Id = 21,
    Value = 6124480205450940375L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 33,
    Value = 6514934405421766784L,
    ModelInner = new UInt64UInt640MI
{
    Id = 28,
    Value = 3739804384914193215L,
    NullableValue = null,
},
    NullableValue = 7719220978070941994L,
},
            new UInt64UInt640M
{
    Id = 34,
    Value = 1736917948224433182L,
    ModelInner = new UInt64UInt640MI
{
    Id = 33,
    Value = 8535789068003623868L,
    NullableValue = null,
},
    NullableValue = 182757864005013599L,
},
            new UInt64UInt640M
{
    Id = 42,
    Value = 4000844717284097839L,
    ModelInner = new UInt64UInt640MI
{
    Id = 40,
    Value = 2630665196160401638L,
    NullableValue = 7002798130336200103L,
},
    NullableValue = 2650109886942678388L,
},
            new UInt64UInt640M
{
    Id = 47,
    Value = 9059834871743576232L,
    ModelInner = new UInt64UInt640MI
{
    Id = 44,
    Value = 2490253365435124073L,
    NullableValue = 6111449111458002782L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 48,
    Value = 2502586751472293235L,
    ModelInner = new UInt64UInt640MI
{
    Id = 52,
    Value = 1001638154507858293L,
    NullableValue = 5656280384327987512L,
},
    NullableValue = 9148104703070627063L,
},
            new UInt64UInt640M
{
    Id = 53,
    Value = 6214843119202944106L,
    ModelInner = new UInt64UInt640MI
{
    Id = 60,
    Value = 9149122488077883848L,
    NullableValue = 8943519057078860240L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 56,
    Value = 5803703325557207806L,
    ModelInner = new UInt64UInt640MI
{
    Id = 67,
    Value = 1176976283497452739L,
    NullableValue = 522932100435725358L,
},
    NullableValue = 3564451013841536087L,
},
            new UInt64UInt640M
{
    Id = 60,
    Value = 5094037306041092906L,
    ModelInner = new UInt64UInt640MI
{
    Id = 76,
    Value = 5761436712608618829L,
    NullableValue = 6999432606684208629L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 61,
    Value = 8996699270136656940L,
    ModelInner = new UInt64UInt640MI
{
    Id = 82,
    Value = 8247259652890571155L,
    NullableValue = null,
},
    NullableValue = 378162029431260759L,
},
            new UInt64UInt640M
{
    Id = 62,
    Value = 2599753471336941927L,
    ModelInner = new UInt64UInt640MI
{
    Id = 85,
    Value = 4455664204740096178L,
    NullableValue = 2108376449587267025L,
},
    NullableValue = 6862922651105315191L,
},
            new UInt64UInt640M
{
    Id = 68,
    Value = 8272871513238107533L,
    ModelInner = new UInt64UInt640MI
{
    Id = 87,
    Value = 6899373589303166580L,
    NullableValue = 4515439114987360019L,
},
    NullableValue = 3239977437576806208L,
},
            new UInt64UInt640M
{
    Id = 75,
    Value = 5149954423762425610L,
    ModelInner = new UInt64UInt640MI
{
    Id = 88,
    Value = 5316215601516261723L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 82,
    Value = 5977602832592416900L,
    ModelInner = new UInt64UInt640MI
{
    Id = 93,
    Value = 4939431676770606698L,
    NullableValue = 7410085941763624114L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 89,
    Value = 7867652318810664854L,
    ModelInner = new UInt64UInt640MI
{
    Id = 95,
    Value = 7612067066225691667L,
    NullableValue = 5013757089463975422L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 91,
    Value = 5446445627448568137L,
    ModelInner = new UInt64UInt640MI
{
    Id = 101,
    Value = 8724201710502651361L,
    NullableValue = 3381138005553022653L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 93,
    Value = 8546677883018785526L,
    ModelInner = new UInt64UInt640MI
{
    Id = 106,
    Value = 536086229858855880L,
    NullableValue = 1445213058335936111L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 94,
    Value = 3011227634406904765L,
    ModelInner = new UInt64UInt640MI
{
    Id = 109,
    Value = 6204707300122423515L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 99,
    Value = 7660935510092862521L,
    ModelInner = new UInt64UInt640MI
{
    Id = 113,
    Value = 5547360855015830328L,
    NullableValue = null,
},
    NullableValue = 4726578484039075050L,
},
            new UInt64UInt640M
{
    Id = 105,
    Value = 7527647378080383854L,
    ModelInner = new UInt64UInt640MI
{
    Id = 115,
    Value = 1816177781116846703L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 112,
    Value = 9100360436193703254L,
    ModelInner = new UInt64UInt640MI
{
    Id = 123,
    Value = 5640459443192926974L,
    NullableValue = 6451416747220010982L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 117,
    Value = 6034060197768456008L,
    ModelInner = new UInt64UInt640MI
{
    Id = 132,
    Value = 5828096379012351750L,
    NullableValue = null,
},
    NullableValue = 2750251587934293635L,
},
            new UInt64UInt640M
{
    Id = 119,
    Value = 4156438031459895445L,
    ModelInner = new UInt64UInt640MI
{
    Id = 136,
    Value = 4633991775015521764L,
    NullableValue = 3405375343078236320L,
},
    NullableValue = 2968491973735785128L,
},
            new UInt64UInt640M
{
    Id = 123,
    Value = 2819899064245843978L,
    ModelInner = new UInt64UInt640MI
{
    Id = 145,
    Value = 4389907535283886937L,
    NullableValue = null,
},
    NullableValue = 8118171522382962509L,
},
            new UInt64UInt640M
{
    Id = 126,
    Value = 1267391853045316867L,
    ModelInner = new UInt64UInt640MI
{
    Id = 151,
    Value = 421582697394498773L,
    NullableValue = 210181839899366288L,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 134,
    Value = 8809477845015003695L,
    ModelInner = new UInt64UInt640MI
{
    Id = 158,
    Value = 4281748975927186049L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 143,
    Value = 3061813277387216716L,
    ModelInner = new UInt64UInt640MI
{
    Id = 165,
    Value = 5042288220921563541L,
    NullableValue = 9035926336716771871L,
},
    NullableValue = 2538200191743773570L,
},
            new UInt64UInt640M
{
    Id = 152,
    Value = 3378647139898275859L,
    ModelInner = new UInt64UInt640MI
{
    Id = 172,
    Value = 1344881192521462869L,
    NullableValue = 4627004160275109608L,
},
    NullableValue = 7360396532690334031L,
},
            new UInt64UInt640M
{
    Id = 158,
    Value = 5727413059815772215L,
    ModelInner = new UInt64UInt640MI
{
    Id = 175,
    Value = 2689645869594814108L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 162,
    Value = 8568410039693998935L,
    ModelInner = new UInt64UInt640MI
{
    Id = 179,
    Value = 6562182366109433794L,
    NullableValue = null,
},
    NullableValue = null,
},
            new UInt64UInt640M
{
    Id = 171,
    Value = 221709083115581890L,
    ModelInner = new UInt64UInt640MI
{
    Id = 188,
    Value = 8554377770100856351L,
    NullableValue = null,
},
    NullableValue = 8845197112691219416L,
},
            new UInt64UInt640M
{
    Id = 174,
    Value = 8583503185143163260L,
    ModelInner = new UInt64UInt640MI
{
    Id = 192,
    Value = 809425430573930533L,
    NullableValue = 7817633260724503610L,
},
    NullableValue = 6172028959705809642L,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.uint64uint640m(
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
FROM gedaqtests.uint64uint640m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(UInt64UInt640M)],
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
                    UInt64UInt640M.AssertModel(models[0],_testData[i], false);
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
                    UInt64UInt640M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

