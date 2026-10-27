

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
    internal partial interface IDecimalListnumericListD1
    {
    }
    
    internal partial class DecimalListnumericListD1 : IDecimalListnumericListD1
    {


#region TestData

        private readonly DecimalnumericListD1E2M[] _testData = new DecimalnumericListD1E2M[]
        {
            new DecimalnumericListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.440049921326308m,

0.192278770789839m,

0.493560513858842m,

0.287182422328567m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.533318922456457m,

0.433911707448495m,

0.356597527097496m,

0.770229965448314m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0925634732284736m,

0.782133232388984m,

0.525814643027537m,

0.00809138597919334m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.802703932078076m,

0.654336489066674m,

0.675329100763899m,

0.805581443257151m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0140105296099547m,

0.738717231907546m,

0.41085683322788m,

0.649563835370723m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.129595312161088m,

0.0734617588564357m,

0.237547014268708m,

0.0835654184708913m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.897453201125561m,

0.585906203830709m,

0.962998183797275m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.860656078532819m,

0.22570296501566m,

0.214289035909259m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.361564141595665m,

0.904239302501081m,

0.277790412768054m,

0.577241282110219m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.349328312563165m,

0.459386098642904m,

0.290285182414435m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.120127882602003m,

0.242530507696434m,

0.0769477089886573m,

0.631687536998398m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.240515039424253m,

0.304903715235317m,

0.647584823356408m,

0.106518791253131m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.180757604134861m,

0.729891479428128m,

0.57781201289663m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.791463098467873m,

0.891012513716583m,

0.90891344515669m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.723841164857491m,

0.589382558055474m,

0.10968296988405m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.116663267746399m,

0.929386261535542m,

0.862674119680873m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.644645590976939m,

0.751386757487035m,

0.420423279396677m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.123718770551517m,

0.975276656325311m,

0.645002736017366m,

0.204001818247375m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.477530996978738m,

0.105962028502373m,

0.309424292899017m,

0.576958079400407m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.038761999456306m,

0.84669714763474m,

0.24274563354219m,

0.42912913875935m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.556115903407918m,

0.179340706365361m,

0.470437347185479m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0136727987274853m,

0.706547782763289m,

0.119483153309225m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.157284737900864m,

0.936465042793854m,

0.420460506870605m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.70467254055682m,

0.771885426879492m,

0.267874828934885m,

0.244257834256605m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.704779763901572m,

0.947806755973379m,

0.226526074279578m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.994456907418658m,

0.786191152241012m,

0.575699376167806m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.299473116065393m,

0.184554026044729m,

0.727860919572384m,

0.466029800378726m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.61132334934566m,

0.621273148276995m,

0.59898521191097m,

0.517654370879384m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.821175574943914m,

0.0270098950869152m,

0.636786488758614m,

0.706695538816662m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.611208614677202m,

0.163434268509906m,

0.363695653443316m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.522862052686035m,

0.858094769502664m,

0.0517010568838977m,

0.330926040276889m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.564016735977914m,

0.226761504620896m,

0.738129101972711m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.97367194023093m,

0.295283697014482m,

0.0022537995984262m,

0.89255393717658m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0877118580717753m,

0.0525086810316384m,

0.655963378004698m,

0.0258997867527659m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.17072279866666m,

0.35335244273458m,

0.923895560919386m,

0.178940546014592m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.457174881687695m,

0.872890042023848m,

0.670404316407899m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.952751988490658m,

0.219526906486541m,

0.822320859840838m,

0.86770867449477m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.354296557352899m,

0.259194507776013m,

0.722980345087254m,

0.983505140169638m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.590344360726152m,

0.892166544893215m,

0.511661816400796m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.483853159658471m,

0.658138224829252m,

0.0757071407505403m,

0.0246711005040339m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.2459367355569m,

0.895155301407566m,

0.852700214147162m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.674184072009151m,

0.08263481041791m,

0.844023306560158m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.199767640847888m,

0.349231312159267m,

0.106976660922607m,

0.462148941302922m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.761858575894065m,

0.595358241335846m,

0.167814980201756m,

0.271283197559825m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.237443351292947m,

0.690293884409032m,

0.454721615134393m,

0.41926723350531m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.816436731442525m,

0.408219627569776m,

0.474849980536476m,

0.982647190928596m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.222164397054871m,

0.919845086610603m,

0.51082405584874m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0907270622704946m,

0.180471518312727m,

0.323097133329734m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.669023151410526m,

0.664642728232849m,

0.408630085619869m,

0.363354123186554m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.8031486429884m,

0.624156953892757m,

0.348241588798542m,

0.970949532162192m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.572511395519149m,

0.575790145196896m,

0.0637393363717202m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.672435109882172m,

0.825929866746323m,

0.0491175175053556m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.806540898349485m,

0.886662493981075m,

0.999226467465086m,

0.546771088723237m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.975739700257662m,

0.75089351169487m,

0.564747652814739m,

0.145453862097176m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.750012241207646m,

0.336600084123155m,

0.0187933952571953m,

0.0495911019373159m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.016574202204413m,

0.453031778875378m,

0.265695943300408m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.962591506556537m,

0.102625721422945m,

0.358861638993836m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.157762861163521m,

0.975495214549627m,

0.951626316276812m,

0.834107308428704m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.522126685681977m,

0.461896758290795m,

0.306465785538674m,

0.829800863473849m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.590900249228744m,

0.605022127116889m,

0.941015138722853m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0770817290745425m,

0.429135993154458m,

0.652038336314542m,

0.815788938308619m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.261030273109243m,

0.354813354123386m,

0.770018016914133m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0925444272256073m,

0.452200732258681m,

0.693578203661641m,

0.509837672462294m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.237418457879319m,

0.0776088673992393m,

0.878136244216059m,

0.139689239521209m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 176,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.938104624826139m,

0.0459866369939068m,

0.220798482551779m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.720922080570943m,

0.40386868206705m,

0.842551788595701m,

0.982785111063895m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.233232562098063m,

0.428799900547044m,

0.818384032705678m,

0.118653972370166m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.820024105809656m,

0.436794872397253m,

0.0256240265222993m,

0.933884362767371m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.00650231797859169m,

0.97651614169276m,

0.876320120090195m,

0.582181777761802m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 194,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.565396524170468m,

0.300521035384832m,

0.975356998059361m,

0.910827053174175m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.727059935192222m,

0.250679100108502m,

0.807121337174778m,

0.420061870400028m,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2mi(
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2mi(
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
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
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

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
            asPartInterface: typeof(IDecimalListnumericListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericlistd1e2m(
	id,
    value,
    nullablevalue,
    decimalnumericlistd1e2mi_id
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
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericlistd1e2mi_id", 
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
                List<DecimalnumericListD1E2M> models = null;

                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericListD1E2M> models = null;

                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await ((IDecimalListnumericListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M), typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                await((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 144, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericListD1E2M>();
                var models2 = new List<FlatDecimalnumericListD1E2M>();
                ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 155, query1, 16, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var firstItems2 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 71, query1, 173, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 95, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 64, query1, 176, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
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
FROM public.decimalnumericlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems1 = new List<FlatDecimalnumericListD1E2M>();
                var secondItems2 = new List<FlatDecimalnumericListD1E2M>();
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 64, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.decimalnumericlistd1e2m m
LEFT JOIN public.decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
            asPartInterface: typeof(IDecimalListnumericListD1)),
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
                var models = await((IDecimalListnumericListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 176))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[34], false);
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
                var models = ((IDecimalListnumericListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 116, 110))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[34], false);
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
                await using var cmd = await ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models = await ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[6], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[7], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[8], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[9], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[10], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[11], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[23],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[24],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[25],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[26],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[27],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 75);
                var models =  ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
FROM public.binary_decimalnumericlistd1e2m m
LEFT JOIN public.binary_decimalnumericlistd1e2mi mi ON mi.id = m.decimalnumericlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericListD1)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models =  ((IDecimalListnumericListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericlistd1e2mi
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
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI), typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                await ((IDecimalListnumericListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MI>();
                var models2 = new List<DecimalnumericListD1E2MI>();
                ((IDecimalListnumericListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
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
                var models = await ((IDecimalListnumericListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA), typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                await ((IDecimalListnumericListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericListD1E2MIWA>();
                var models2 = new List<DecimalnumericListD1E2MIWA>();
                ((IDecimalListnumericListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericListD1))]
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
                var models = await ((IDecimalListnumericListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

