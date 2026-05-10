

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
    internal partial interface IDecimalArraynumericArray
    {
    }
    
    internal partial class DecimalArraynumericArray : IDecimalArraynumericArray
    {


#region TestData

        private readonly DecimalnumericArray1M[] _testData = new DecimalnumericArray1M[]
        {
            new DecimalnumericArray1M
{
    Id = 2,
    Value = 
new System.Decimal[3]
{
0.106378846350061m,
0.606626749051389m,
0.803631944732475m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.407566362776136m,
0.348957400163226m,
0.930977279324172m,
0.895481430594087m,
},
},
            new DecimalnumericArray1M
{
    Id = 6,
    Value = 
new System.Decimal[3]
{
0.984619947369212m,
0.128870202285566m,
0.331054667459485m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 8,
    Value = 
new System.Decimal[4]
{
0.942282305986411m,
0.824290260149972m,
0.291970802796926m,
0.858171259217853m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.872933453218351m,
0.932495729688208m,
0.0839283920953374m,
},
},
            new DecimalnumericArray1M
{
    Id = 7,
    Value = 
new System.Decimal[4]
{
0.794643342339056m,
0.961730547108999m,
0.304378463423841m,
0.384857048464226m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 11,
    Value = 
new System.Decimal[4]
{
0.276863469520503m,
0.906627167160427m,
0.813656452019112m,
0.0532462688531332m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 9,
    Value = 
new System.Decimal[3]
{
0.538113549486413m,
0.380468847268482m,
0.507681723001294m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.567226006179611m,
0.295721751950051m,
0.314266286171758m,
},
},
            new DecimalnumericArray1M
{
    Id = 16,
    Value = 
new System.Decimal[4]
{
0.499187618162193m,
0.820406596788264m,
0.99444258379421m,
0.69271829185984m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.0787988111296896m,
0.247077417390035m,
0.997410905329714m,
0.317052701302174m,
},
},
            new DecimalnumericArray1M
{
    Id = 19,
    Value = 
new System.Decimal[4]
{
0.813399755575101m,
0.883402259425898m,
0.615414241366138m,
0.0183167057999999m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 15,
    Value = 
new System.Decimal[4]
{
0.0674655493373881m,
0.898328909716602m,
0.173689624525068m,
0.999804396496061m,
},
    NullableValue = 
new System.Decimal[3]
{
0.729824138914491m,
0.0851470756028249m,
0.261379899129094m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.0771653211937308m,
0.0689097050909662m,
0.547793021686403m,
0.624151620968313m,
},
},
            new DecimalnumericArray1M
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.207852566790427m,
0.749361556888197m,
0.377568258638563m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.348871237163312m,
0.745064494378821m,
0.916833055075659m,
0.767677849719026m,
},
},
            new DecimalnumericArray1M
{
    Id = 29,
    Value = 
new System.Decimal[4]
{
0.562338576613886m,
0.53813391478141m,
0.687753040252733m,
0.226947227359616m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 20,
    Value = 
new System.Decimal[4]
{
0.0588820743945039m,
0.372160562125932m,
0.51946420774506m,
0.187962902780341m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0317130172584766m,
0.321811900218685m,
0.0423658343193969m,
0.480758061116023m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.931630806386264m,
0.425193819320294m,
0.206664169217233m,
0.985656413162284m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.58616342201974m,
0.329334462802799m,
0.470491203322351m,
},
},
            new DecimalnumericArray1M
{
    Id = 36,
    Value = 
new System.Decimal[3]
{
0.922066857521503m,
0.344809550123183m,
0.304399345185847m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.502159183748951m,
0.465737647142977m,
0.708418863344903m,
0.706923905170908m,
},
    NullableValue = 
new System.Decimal[4]
{
0.105866792961618m,
0.935397119093918m,
0.966167160185484m,
0.0303998136841235m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.466158835082315m,
0.684619019576833m,
0.560706933883738m,
0.478303331556847m,
},
},
            new DecimalnumericArray1M
{
    Id = 41,
    Value = 
new System.Decimal[3]
{
0.58653254260165m,
0.623785630464799m,
0.719290018519093m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 43,
    Value = 
new System.Decimal[4]
{
0.458027081714186m,
0.368902421793574m,
0.61730724986221m,
0.146775104178739m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 29,
    Value = 
new System.Decimal[3]
{
0.357951702901513m,
0.378361091750468m,
0.635061563911856m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 50,
    Value = 
new System.Decimal[3]
{
0.183971667932389m,
0.823510469637778m,
0.555212046567503m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.193537516490202m,
0.332056941939153m,
0.838180245267488m,
0.96730424432486m,
},
},
            new DecimalnumericArray1M
{
    Id = 52,
    Value = 
new System.Decimal[3]
{
0.769704743728512m,
0.059384272620792m,
0.258861245753974m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 38,
    Value = 
new System.Decimal[4]
{
0.771873368885416m,
0.741215606676427m,
0.283540429030061m,
0.428308889003862m,
},
    NullableValue = 
new System.Decimal[4]
{
0.784997033742674m,
0.450439920602617m,
0.49189488876586m,
0.972728580824525m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.801971352519208m,
0.273193884546597m,
0.226683398947758m,
0.317260113293179m,
},
},
            new DecimalnumericArray1M
{
    Id = 58,
    Value = 
new System.Decimal[4]
{
0.190001910847316m,
0.923550229759139m,
0.424125011519398m,
0.595438116762856m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.28804483054207m,
0.270489142479441m,
0.838273609553559m,
0.528208054202876m,
},
},
            new DecimalnumericArray1M
{
    Id = 67,
    Value = 
new System.Decimal[3]
{
0.75831390861509m,
0.744812533885759m,
0.783825746075748m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 47,
    Value = 
new System.Decimal[3]
{
0.580086849115752m,
0.573442452864085m,
0.647780890371788m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.840421469108513m,
0.829755175022074m,
0.777731500269187m,
},
},
            new DecimalnumericArray1M
{
    Id = 75,
    Value = 
new System.Decimal[3]
{
0.370764498477012m,
0.968927172245276m,
0.781737664780233m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.910947007434391m,
0.559913192967818m,
0.0709790808789714m,
},
},
            new DecimalnumericArray1M
{
    Id = 78,
    Value = 
new System.Decimal[4]
{
0.388553232272432m,
0.49066487447123m,
0.550707773315928m,
0.642413714651114m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 55,
    Value = 
new System.Decimal[3]
{
0.437012447792698m,
0.618638400534768m,
0.895440034345812m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.0730967158832565m,
0.321857334902785m,
0.123584855597049m,
0.779660019201706m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 94,
    Value = 
new System.Decimal[4]
{
0.74922790655903m,
0.358853081990993m,
0.971650190381992m,
0.503448817382619m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[4]
{
0.0836112302214359m,
0.515947299317257m,
0.604236664056616m,
0.07237392917584m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.689848798055944m,
0.464617529567169m,
0.971915712747744m,
},
},
            new DecimalnumericArray1M
{
    Id = 98,
    Value = 
new System.Decimal[4]
{
0.190028800872365m,
0.757617254243002m,
0.811475162735482m,
0.498437765205479m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.596663291610994m,
0.136599430788238m,
0.0166481553211555m,
},
},
            new DecimalnumericArray1M
{
    Id = 105,
    Value = 
new System.Decimal[4]
{
0.821120866040349m,
0.77698215475884m,
0.974810126252641m,
0.43561650732415m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 66,
    Value = 
new System.Decimal[4]
{
0.173042001845385m,
0.0648307250136465m,
0.484593321021862m,
0.24932454810667m,
},
    NullableValue = 
new System.Decimal[3]
{
0.920285397551871m,
0.542546937567081m,
0.592563563410974m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 109,
    Value = 
new System.Decimal[4]
{
0.724323909091676m,
0.687020439652351m,
0.436444239152226m,
0.244627536686783m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.880449988414585m,
0.906307873342058m,
0.868636484789033m,
0.332655647573972m,
},
},
            new DecimalnumericArray1M
{
    Id = 117,
    Value = 
new System.Decimal[3]
{
0.187129158908098m,
0.765331891096984m,
0.863638507401335m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 67,
    Value = 
new System.Decimal[3]
{
0.264511876221159m,
0.287740287955879m,
0.855137665174796m,
},
    NullableValue = 
new System.Decimal[4]
{
0.000932553463592889m,
0.710225460091023m,
0.774127730039736m,
0.660872622414709m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 119,
    Value = 
new System.Decimal[4]
{
0.573710223741188m,
0.663840898955942m,
0.95896623491194m,
0.255729327016479m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 121,
    Value = 
new System.Decimal[3]
{
0.631113102197207m,
0.541960757986334m,
0.522699833943672m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 69,
    Value = 
new System.Decimal[4]
{
0.972394259389584m,
0.213316605547753m,
0.391403644267772m,
0.651914274463055m,
},
    NullableValue = 
new System.Decimal[4]
{
0.250555426321279m,
0.744843370364524m,
0.286251330743881m,
0.346820952299735m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 130,
    Value = 
new System.Decimal[3]
{
0.240957378984735m,
0.895039562661976m,
0.897477092279171m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 139,
    Value = 
new System.Decimal[4]
{
0.540835804973532m,
0.157084311471967m,
0.422759881175798m,
0.400908501592205m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 73,
    Value = 
new System.Decimal[4]
{
0.368081465873353m,
0.709073491739978m,
0.241216656039074m,
0.365006811406587m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.461901070588416m,
0.0987406355531751m,
0.402310107119761m,
},
},
            new DecimalnumericArray1M
{
    Id = 142,
    Value = 
new System.Decimal[4]
{
0.297494083709696m,
0.316601300523254m,
0.602498470983255m,
0.7001758943903m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.184505622764203m,
0.383907928880991m,
0.0189881381520355m,
0.785543278569756m,
},
},
            new DecimalnumericArray1M
{
    Id = 148,
    Value = 
new System.Decimal[3]
{
0.596864078427527m,
0.75932813746669m,
0.68681007765474m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 81,
    Value = 
new System.Decimal[4]
{
0.899160687057054m,
0.23593589333323m,
0.694357652337451m,
0.64854092873328m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.945968044548244m,
0.0359449405452009m,
0.768553253160654m,
0.1579229614717m,
},
},
            new DecimalnumericArray1M
{
    Id = 157,
    Value = 
new System.Decimal[4]
{
0.0625943693188372m,
0.222788697541575m,
0.264621967309696m,
0.226137228057488m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 161,
    Value = 
new System.Decimal[4]
{
0.286496354719762m,
0.224365659246157m,
0.896896671160764m,
0.923770986633428m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 83,
    Value = 
new System.Decimal[3]
{
0.462695309966507m,
0.959472994633499m,
0.447745499977213m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.987148528334624m,
0.114583752018806m,
0.870751824743733m,
},
},
            new DecimalnumericArray1M
{
    Id = 169,
    Value = 
new System.Decimal[3]
{
0.552313289560226m,
0.0706206845725381m,
0.368004746895404m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.272685281469135m,
0.53686943359554m,
0.231457693740499m,
0.423290377126337m,
},
},
            new DecimalnumericArray1M
{
    Id = 173,
    Value = 
new System.Decimal[3]
{
0.788629140538273m,
0.313067140428564m,
0.27508829303238m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 88,
    Value = 
new System.Decimal[3]
{
0.0334071778529924m,
0.140605829772018m,
0.596534548242314m,
},
    NullableValue = 
new System.Decimal[4]
{
0.106172719367422m,
0.328151002650037m,
0.860213304734899m,
0.774266608271668m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 175,
    Value = 
new System.Decimal[4]
{
0.0341080065008569m,
0.942805263313396m,
0.18154298619021m,
0.710191845139131m,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1mi(
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
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
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

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalArraynumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalArraynumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalArraynumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
            asPartInterface: typeof(IDecimalArraynumericArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
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
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalArraynumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalArraynumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.0787988111296896m,
0.247077417390035m,
0.997410905329714m,
0.317052701302174m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.0771653211937308m,
0.0689097050909662m,
0.547793021686403m,
0.624151620968313m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.348871237163312m,
0.745064494378821m,
0.916833055075659m,
0.767677849719026m,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Decimal[]>();
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    ((NpgsqlParameter<System.Decimal[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483635);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray1m(
	id,
    value,
    nullablevalue,
    decimalnumericarray1mi_id
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
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Decimal[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.58616342201974m,
0.329334462802799m,
0.470491203322351m,
}));
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.466158835082315m,
0.684619019576833m,
0.560706933883738m,
0.478303331556847m,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Decimal[] nullable = null;
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDecimalArraynumericArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray1M> models = null;

                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 67, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 58, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 105, query1, 157, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 43, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 148, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 148, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 148, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 169, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 52, 19))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[34], false);
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
                await using var cmd = await ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                DecimalnumericArray1M.AssertModel(models[0],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 121);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                DecimalnumericArray1M.AssertModel(models[0],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray1M),
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
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
FROM public.binary_decimalnumericarray1m m
LEFT JOIN public.binary_decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models =  ((IDecimalArraynumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models = await ((IDecimalArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI), typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models1 = new List<DecimalnumericArray1MI>();
                var models2 = new List<DecimalnumericArray1MI>();
                await ((IDecimalArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MI>();
                var models2 = new List<DecimalnumericArray1MI>();
                ((IDecimalArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models = await ((IDecimalArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

