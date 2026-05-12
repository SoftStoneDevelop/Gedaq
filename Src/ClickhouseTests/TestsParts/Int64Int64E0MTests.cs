

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
    Value = 2781643779225455731L,
    ModelInner = new Int64Int64E0MI
{
    Id = 1,
    Value = 8865263079420740556L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 6,
    Value = 1566934817555637798L,
    ModelInner = new Int64Int64E0MI
{
    Id = 7,
    Value = 2171963670081708009L,
    NullableValue = 5567729980932383868L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 13,
    Value = 7210649702014882187L,
    ModelInner = new Int64Int64E0MI
{
    Id = 14,
    Value = 7929594030306667023L,
    NullableValue = 3474020149218350977L,
},
    NullableValue = 307905542466764969L,
},
            new Int64Int64E0M
{
    Id = 20,
    Value = 4549880810628890448L,
    ModelInner = new Int64Int64E0MI
{
    Id = 19,
    Value = 5595953233194669870L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 25,
    Value = 7207385351147358660L,
    ModelInner = new Int64Int64E0MI
{
    Id = 24,
    Value = 6234557710969430201L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 33,
    Value = 2056998307203594927L,
    ModelInner = new Int64Int64E0MI
{
    Id = 32,
    Value = 1934711469497840255L,
    NullableValue = null,
},
    NullableValue = 3273455586487619627L,
},
            new Int64Int64E0M
{
    Id = 41,
    Value = 2319170377832429968L,
    ModelInner = new Int64Int64E0MI
{
    Id = 40,
    Value = 4529429846405722658L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 48,
    Value = 3220864991291183400L,
    ModelInner = new Int64Int64E0MI
{
    Id = 42,
    Value = 1257945436047588807L,
    NullableValue = 8860174738176231037L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 53,
    Value = 4612459558232277142L,
    ModelInner = new Int64Int64E0MI
{
    Id = 50,
    Value = 8156288660400873408L,
    NullableValue = null,
},
    NullableValue = 5370079228571131059L,
},
            new Int64Int64E0M
{
    Id = 56,
    Value = 7512405241029718163L,
    ModelInner = new Int64Int64E0MI
{
    Id = 58,
    Value = 4499950221211284798L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 62,
    Value = 2258484921871730740L,
    ModelInner = new Int64Int64E0MI
{
    Id = 67,
    Value = 6070472358776834157L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 68,
    Value = 4755836136311352210L,
    ModelInner = new Int64Int64E0MI
{
    Id = 75,
    Value = 4223089309547195939L,
    NullableValue = 1640103277770880618L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 71,
    Value = 494041563630906591L,
    ModelInner = new Int64Int64E0MI
{
    Id = 79,
    Value = 5438881374022704868L,
    NullableValue = null,
},
    NullableValue = 598005957073202559L,
},
            new Int64Int64E0M
{
    Id = 79,
    Value = 9121375607431128131L,
    ModelInner = new Int64Int64E0MI
{
    Id = 85,
    Value = 2033511364680015608L,
    NullableValue = null,
},
    NullableValue = 8096024479330163005L,
},
            new Int64Int64E0M
{
    Id = 86,
    Value = 5343881288739051762L,
    ModelInner = new Int64Int64E0MI
{
    Id = 87,
    Value = 2104880765600665586L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 94,
    Value = 4075122678614332785L,
    ModelInner = new Int64Int64E0MI
{
    Id = 95,
    Value = 8215685479772365741L,
    NullableValue = 5172023339046353053L,
},
    NullableValue = 5648625878415015757L,
},
            new Int64Int64E0M
{
    Id = 100,
    Value = 3442279305454897650L,
    ModelInner = new Int64Int64E0MI
{
    Id = 101,
    Value = 9192790820267827198L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 101,
    Value = 6946129442073498107L,
    ModelInner = new Int64Int64E0MI
{
    Id = 106,
    Value = 6144276236559082653L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 107,
    Value = 5798919350648212752L,
    ModelInner = new Int64Int64E0MI
{
    Id = 111,
    Value = 5939340375192875676L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 115,
    Value = 3404998436860145102L,
    ModelInner = new Int64Int64E0MI
{
    Id = 116,
    Value = 8312846907651273413L,
    NullableValue = 1270886722192732600L,
},
    NullableValue = 8180843767057462250L,
},
            new Int64Int64E0M
{
    Id = 123,
    Value = 8556705054983651762L,
    ModelInner = new Int64Int64E0MI
{
    Id = 124,
    Value = 6614291991234869357L,
    NullableValue = 1888898336366214312L,
},
    NullableValue = 7937714997755351792L,
},
            new Int64Int64E0M
{
    Id = 127,
    Value = 7078030389708438032L,
    ModelInner = new Int64Int64E0MI
{
    Id = 125,
    Value = 6721347073222651160L,
    NullableValue = 1877971284322764943L,
},
    NullableValue = 3768603090035228842L,
},
            new Int64Int64E0M
{
    Id = 130,
    Value = 8131365984337494204L,
    ModelInner = new Int64Int64E0MI
{
    Id = 134,
    Value = 4897130814723724067L,
    NullableValue = null,
},
    NullableValue = 2861858888948656883L,
},
            new Int64Int64E0M
{
    Id = 135,
    Value = 1440079325393102372L,
    ModelInner = new Int64Int64E0MI
{
    Id = 139,
    Value = 169147702769279230L,
    NullableValue = 2316186959520941703L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 142,
    Value = 8160762776460271777L,
    ModelInner = new Int64Int64E0MI
{
    Id = 144,
    Value = 6951326984073897448L,
    NullableValue = 2842788503646706294L,
},
    NullableValue = 8509110643720720822L,
},
            new Int64Int64E0M
{
    Id = 143,
    Value = 9197282163828264556L,
    ModelInner = new Int64Int64E0MI
{
    Id = 151,
    Value = 1065124184733014083L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 151,
    Value = 5716175888247798686L,
    ModelInner = new Int64Int64E0MI
{
    Id = 155,
    Value = 2088027917031589730L,
    NullableValue = 8457949122223743860L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 157,
    Value = 5122297900887203541L,
    ModelInner = new Int64Int64E0MI
{
    Id = 156,
    Value = 282702754275054032L,
    NullableValue = 225426314784974477L,
},
    NullableValue = 1126354622342745529L,
},
            new Int64Int64E0M
{
    Id = 163,
    Value = 2326478082867518221L,
    ModelInner = new Int64Int64E0MI
{
    Id = 163,
    Value = 2594883986751056604L,
    NullableValue = 5233138927002132915L,
},
    NullableValue = 5017656910777175382L,
},
            new Int64Int64E0M
{
    Id = 172,
    Value = 5313061865179435202L,
    ModelInner = new Int64Int64E0MI
{
    Id = 172,
    Value = 2609422785775052362L,
    NullableValue = null,
},
    NullableValue = 7439869096867460776L,
},
            new Int64Int64E0M
{
    Id = 173,
    Value = 2399506661985216600L,
    ModelInner = new Int64Int64E0MI
{
    Id = 174,
    Value = 5348670540122152869L,
    NullableValue = 8187152904025212838L,
},
    NullableValue = 9094911822380038032L,
},
            new Int64Int64E0M
{
    Id = 179,
    Value = 7774424924118230212L,
    ModelInner = new Int64Int64E0MI
{
    Id = 177,
    Value = 8139577523476147620L,
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 187,
    Value = 8321895044768534262L,
    ModelInner = new Int64Int64E0MI
{
    Id = 185,
    Value = 3829871622838758028L,
    NullableValue = null,
},
    NullableValue = 6153327652543269075L,
},
            new Int64Int64E0M
{
    Id = 188,
    Value = 1485533339098314896L,
    ModelInner = new Int64Int64E0MI
{
    Id = 192,
    Value = 5101778298682700233L,
    NullableValue = 4056630274896178200L,
},
    NullableValue = null,
},
            new Int64Int64E0M
{
    Id = 195,
    Value = 4616246592703954932L,
    ModelInner = new Int64Int64E0MI
{
    Id = 197,
    Value = 2851328972644447192L,
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

