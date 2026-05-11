

using Npgsql;
using NpgsqlTypes;
using Gedaq.Common.Enums;
using Gedaq.Npgsql.Attributes;
using Gedaq.Npgsql.Enums;
using System;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IDoubleListdouble_precisionListD1
    {
    }
    
    internal partial class DoubleListdouble_precisionListD1 : IDoubleListdouble_precisionListD1
    {


#region TestData

        private readonly Doubledouble_precisionListD1E2M[] _testData = new Doubledouble_precisionListD1E2M[]
        {
            new Doubledouble_precisionListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7909328257954876d,

0.9029441859454275d,

0.5505477889241326d,

0.5599390494473689d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21852710497596806d,

0.39721877150292706d,

0.6583083739707167d,

0.9323270786471862d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1710783236512835d,

0.2449011741153888d,

0.9325643940549301d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7773718223163574d,

0.46349134489826027d,

0.9790463216974115d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18323437206119486d,

0.13227011893182206d,

0.9966356846899781d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6129011186455638d,

0.1390521750210716d,

0.916130774804184d,

0.5362073632660503d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.04681112878325644d,

0.43182335480558987d,

0.6242134475271738d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08466013718817855d,

0.9940514968488968d,

0.9864347417182471d,

0.36441022094990694d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9940059976905001d,

0.18883517386985416d,

0.24198539164397115d,

0.37855676295036245d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4267632233268135d,

0.05708965695783885d,

0.8645276963632689d,

0.7420790495441502d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8295163660595523d,

0.43156479725765773d,

0.13916650492193516d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4482085217973002d,

0.553926519337846d,

0.9062483147868468d,

0.3815109908049704d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28102553880754944d,

0.7726722962400425d,

0.9008385122710121d,

0.8980826804842171d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7565837258596744d,

0.9942805109550448d,

0.7740065329281484d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7528885435915742d,

0.7940149344093052d,

0.10918931947001431d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4659880309964758d,

0.4256450548034133d,

0.5149221687502832d,

0.7849093214910027d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.02135752246353617d,

0.49316940246957974d,

0.5177681263398766d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28885465490628115d,

0.007867206747960487d,

0.9803483499578365d,

0.8294161552073633d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1267103138605884d,

0.15189955116377862d,

0.624712061950893d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8389672288111829d,

0.783560154314523d,

0.5207523638774639d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7469699087325005d,

0.7819172449092537d,

0.5271145509583395d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8807889812422794d,

0.2239319781983814d,

0.6264215453029078d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12917093147143088d,

0.08945585600376549d,

0.34020773732824194d,

0.8283384307416535d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7243247089853484d,

0.9805039917781511d,

0.48217240371264714d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.15977805856563698d,

0.23891559309416843d,

0.23089040885071277d,

0.996222659785449d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.853478728463019d,

0.604841488371588d,

0.1820544423898639d,

0.21859846155129414d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8740657281196244d,

0.1264016252005472d,

0.46440405116056027d,

0.10128916769166385d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21388191911653343d,

0.5004077417425116d,

0.20966996440350438d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5659372918939454d,

0.49355416242687167d,

0.34104322917217944d,

0.028449512719515124d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5171508669971202d,

0.11763447767794544d,

0.7139490313199435d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9323617936498044d,

0.06961311571363882d,

0.6519453981697562d,

0.9569706058382508d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9909716314466506d,

0.6052967651585818d,

0.9640984669543875d,

0.9337129892530943d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.15534795936182433d,

0.770301402947492d,

0.9717048699714566d,

0.03130497283706846d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.38970799160951486d,

0.6432283007253982d,

0.43478894452612904d,

0.1126223377790988d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9224093436612446d,

0.4904533202148922d,

0.39172149535464373d,

0.050399311942072145d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12006489942427523d,

0.16907454916191d,

0.2605784998274726d,

0.31906612713147064d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6449172256542699d,

0.7224025561590163d,

0.05693704549738532d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.016100265581266093d,

0.419969983742977d,

0.5228341324450292d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3674874885561933d,

0.41038095536214103d,

0.20951105646757173d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5650715962993671d,

0.3522558889343269d,

0.6914386405294872d,

0.013693528872927185d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.36324939395199063d,

0.1870309172910284d,

0.35081616497133905d,

0.8397635857380267d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05585478563375801d,

0.2530911361905388d,

0.7287542141925265d,

0.3074902705369068d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.781857539567644d,

0.03469760600469585d,

0.2806669899862536d,

0.4796493523516189d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8981887750705143d,

0.24688936052870525d,

0.7283956088554712d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5147869535601266d,

0.8884502969211289d,

0.5000190828340978d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4038283364187909d,

0.6961678964744791d,

0.13739959073058206d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.41091865195388133d,

0.31447265142382463d,

0.5691109622754656d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.49230944740167615d,

0.7185761729533274d,

0.0732396544613989d,

0.9890499438654494d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1281831955656655d,

0.5707970373205234d,

0.7097437352105248d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2144755321170949d,

0.6349814772037758d,

0.18923993301343767d,

0.3849381322553289d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4284321933337989d,

0.5070352122936462d,

0.872220539148741d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36349218764599d,

0.274584110663165d,

0.9059179338668706d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19325503992573667d,

0.25033717099790087d,

0.6635394454599597d,

0.8756726893081149d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19939524794195462d,

0.3643516372480309d,

0.4770649236865915d,

0.3612223833406516d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26231644189162795d,

0.065109882810229d,

0.10693095771825467d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09783840138222366d,

0.9049289078932178d,

0.1725681281592475d,

0.00647947621123679d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.007827014069273996d,

0.39634946959843476d,

0.18395584441998403d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1467584594268435d,

0.3385853978519239d,

0.8906603048602466d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4126436806262578d,

0.36702279464159193d,

0.903775108070426d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.27911927544507065d,

0.9904613106618084d,

0.7684654123183577d,

0.5217434281508655d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.37711231686558677d,

0.34463153587829987d,

0.8505819782270978d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2414880367709754d,

0.3414335339627401d,

0.5474098051797065d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4190853197303386d,

0.9845164029275412d,

0.5609598005210096d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.34515255962852576d,

0.5669723699856845d,

0.4952379109590541d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.02767603693124343d,

0.13382781164314883d,

0.4673672079506008d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6680185701702299d,

0.5224626918070273d,

0.8979207372723398d,

0.9631961212852811d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2966456799304511d,

0.14027051934780432d,

0.7558451847338762d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7051361298781518d,

0.8762054570260277d,

0.2392462161730382d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9569266846808083d,

0.6484404269772703d,

0.06418917838317517d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13015815923693663d,

0.8233578085901763d,

0.06335592014332503d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3446041837795206d,

0.6743745343054087d,

0.12134464405111323d,

0.9816102626471632d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09665179478974151d,

0.1889108556873147d,

0.7849693428865566d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35257704464369866d,

0.36902807519308733d,

0.2524403411568481d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06721029246801935d,

0.2999105176506208d,

0.15092335441091775d,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
);
",
            methodName:"InsertModelInner",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2mi(
	id,
    value,
    nullablevalue
)
VALUES (
    $1, 
    $2, 
    $3
)
RETURNING
    id,
    value,
    nullablevalue
;
",
            methodName:"InsertModelInnerReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerReturningConfig()
        {
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionlistd1e2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionlistd1e2mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
)
RETURNING
    nullablevalue,
    value,
~StartInner::ModelInner:Id~
~Reinterpret::Id~
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionListD1E2M> models = null;

                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionListD1E2M> models = null;

                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleListdouble_precisionListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[2], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[3], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[31],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M), typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 85, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 177, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var models2 = new List<FlatDoubledouble_precisionListD1E2M>();
                ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 170, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 161, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 161, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 85, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionListD1E2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionListD1E2M>();
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 103, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 

@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.doubledouble_precisionlistd1e2m m
LEFT JOIN public.doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 23, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatch(connection, 152, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models = await ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[11], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[12], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[13], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[14], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[15], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[16], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[17], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[18], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[19], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[20], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[21], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[22], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[19], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[20], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[21], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[22], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleListdouble_precisionListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_doubledouble_precisionlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void ImportModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    m.id,
    m.value,
~StartInner::ModelInner:Id~
    mi.id,
    mi.value,
    mi.nullablevalue,
~EndInner::ModelInner~
    m.nullablevalue
FROM public.binary_doubledouble_precisionlistd1e2m m
LEFT JOIN public.binary_doubledouble_precisionlistd1e2mi mi ON mi.id = m.doubledouble_precisionlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleListdouble_precisionListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleListdouble_precisionListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<Doubledouble_precisionListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleListdouble_precisionListD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDoubleListdouble_precisionListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI), typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                await ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MI>();
                var models2 = new List<Doubledouble_precisionListD1E2MI>();
                ((IDoubleListdouble_precisionListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDoubleListdouble_precisionListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDoubleListdouble_precisionListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA), typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                await ((IDoubleListdouble_precisionListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<Doubledouble_precisionListD1E2MIWA>();
                var models2 = new List<Doubledouble_precisionListD1E2MIWA>();
                ((IDoubleListdouble_precisionListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionListD1))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDoubleListdouble_precisionListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IDoubleListdouble_precisionListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

