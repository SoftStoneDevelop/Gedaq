

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
    internal partial interface INpgsqlBoxSingleTypebox
    {
    }
    
    internal partial class NpgsqlBoxSingleTypebox : INpgsqlBoxSingleTypebox
    {


#region TestData

        private readonly NpgsqlBoxbox0M[] _testData = new NpgsqlBoxbox0M[]
        {
            new NpgsqlBoxbox0M
{
    Id = 3,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9707283680235191d,right: 0.6092773037773457d,bottom: 0.11215853644445506d,left: 0.6026412586037638d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8286980642755074d,right: 0.8639626651101037d,bottom: 0.23862858037789958d,left: 0.6038518672731444d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8702407179640481d,right: 0.4847361116009732d,bottom: 0.5456736906879168d,left: 0.23908447489272133d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.25042603044203726d,right: 0.5342460271963715d,bottom: 0.05448984392005418d,left: 0.07038088270485465d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8685179111914098d,right: 0.8569327567717238d,bottom: 0.013665099261010893d,left: 0.04765723256033205d),
},
            new NpgsqlBoxbox0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9696898300904022d,right: 0.29152781688359053d,bottom: 0.8212234546266246d,left: 0.07562277881562307d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8041388181039325d,right: 0.8100865803911068d,bottom: 0.5093242706017896d,left: 0.10067162327950552d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.08838327026651471d,right: 0.9975372491639125d,bottom: 0.06074461580156976d,left: 0.40759381191389477d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2077123495856975d,right: 0.6867849179226835d,bottom: 0.1959887557343657d,left: 0.21114977616371944d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5586480194739945d,right: 0.8714757650884546d,bottom: 0.05305852161279001d,left: 0.29822863504814034d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8029863380098067d,right: 0.9346151259783329d,bottom: 0.09565315325715784d,left: 0.4008690097943207d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7408276880751065d,right: 0.34733326303109024d,bottom: 0.4087993223686398d,left: 0.23077554815940737d),
},
            new NpgsqlBoxbox0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8041817215837379d,right: 0.7250033631854519d,bottom: 0.303058505562801d,left: 0.4840264938905241d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.70427794978667d,right: 0.99350529467319d,bottom: 0.42851514821921477d,left: 0.0813025702346798d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9997432277203986d,right: 0.7385651182499647d,bottom: 0.6858962983501822d,left: 0.19064755130358269d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5593045360981453d,right: 0.5010838502706734d,bottom: 0.3980870160403289d,left: 0.3445607357627186d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6677552614492285d,right: 0.533543544623764d,bottom: 0.018855977722935235d,left: 0.17436770674494606d),
},
            new NpgsqlBoxbox0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7856797689000831d,right: 0.9000482134840174d,bottom: 0.5818362587701486d,left: 0.6150966529642607d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9709676809122934d,right: 0.8061933577801849d,bottom: 0.4088479254829127d,left: 0.20243109474811838d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.833894290824229d,right: 0.6922532185104331d,bottom: 0.22023352265273344d,left: 0.3468589080789547d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9315931222884611d,right: 0.8510287654512534d,bottom: 0.9240279585615353d,left: 0.8213264229026039d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6146726911362779d,right: 0.8255318883744172d,bottom: 0.24997939844900785d,left: 0.1418936331779217d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7021760773584433d,right: 0.7735835110520851d,bottom: 0.6397492671063459d,left: 0.6440600946402172d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6009722982230357d,right: 0.9594134894152749d,bottom: 0.5003138308165738d,left: 0.9504435377505256d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7330496325895197d,right: 0.8138030739517468d,bottom: 0.6587343123264333d,left: 0.4989950083790896d),
},
            new NpgsqlBoxbox0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3906700412417029d,right: 0.6744666156983496d,bottom: 0.11732755259902083d,left: 0.41391536900199777d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.0862918329864013d,right: 0.8711955489263069d,bottom: 0.017896356012700565d,left: 0.21266184759575235d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.38747521247936767d,right: 0.8687580749925962d,bottom: 0.2169842956805743d,left: 0.4518211997109911d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8701537122120343d,right: 0.5516831426451609d,bottom: 0.09264313529133372d,left: 0.3441590957239602d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9192505886678879d,right: 0.8141430174416712d,bottom: 0.8634263917433658d,left: 0.30489674765260755d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.553350517983721d,right: 0.4215131951977602d,bottom: 0.12110834399479264d,left: 0.14979727567468604d),
},
            new NpgsqlBoxbox0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.30246094728385886d,right: 0.7105142631136853d,bottom: 0.16368903823110503d,left: 0.07556598716829799d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6013931242935074d,right: 0.7340206257988267d,bottom: 0.5437354008759667d,left: 0.0330437027248085d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 58,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7404173900775886d,right: 0.8949459954030263d,bottom: 0.5321495689822924d,left: 0.4282866301204189d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5590195146478627d,right: 0.17708078831231222d,bottom: 0.3356683402618783d,left: 0.15612075596262354d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6648043755677454d,right: 0.8941784052135933d,bottom: 0.1210954120812926d,left: 0.22782390182242662d),
},
            new NpgsqlBoxbox0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8056040621853044d,right: 0.42507578636181864d,bottom: 0.27184007796671583d,left: 0.2639104315643753d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8466354734615493d,right: 0.08166538718000138d,bottom: 0.4493116319559928d,left: 0.058736047151356385d),
},
            new NpgsqlBoxbox0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5541919625227721d,right: 0.9654751036942d,bottom: 0.4607607898970061d,left: 0.8245366175391635d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.41927853078234234d,right: 0.7029771654137036d,bottom: 0.28654863626987415d,left: 0.2997200397607579d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9056045035626732d,right: 0.10597416945257965d,bottom: 0.07814098625416044d,left: 0.01962570429660504d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6998674689297056d,right: 0.6688446408573138d,bottom: 0.2920205507317669d,left: 0.5144002413291616d),
},
            new NpgsqlBoxbox0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.20962554603668082d,right: 0.8210089617983639d,bottom: 0.10150728789541508d,left: 0.06989290005265514d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7320169388082519d,right: 0.9455978206031456d,bottom: 0.586113245613313d,left: 0.27895127962316923d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6040150361006451d,right: 0.8323409604601392d,bottom: 0.44111824592162596d,left: 0.4977650344404029d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8311986878755732d,right: 0.9611564879424502d,bottom: 0.274059368378315d,left: 0.03839889324202084d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8324283029038421d,right: 0.8379668566703069d,bottom: 0.6464251270430733d,left: 0.47135944357517634d),
},
            new NpgsqlBoxbox0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8734178055207513d,right: 0.6902963562334458d,bottom: 0.5573641497117017d,left: 0.5224132080448767d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5667823097326666d,right: 0.8537684442425177d,bottom: 0.34912687107198703d,left: 0.2788924634446356d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4316151051268846d,right: 0.8936624956900079d,bottom: 0.3306844504319173d,left: 0.2222225907489015d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.927347264847008d,right: 0.4004615412701228d,bottom: 0.35130780680049123d,left: 0.008259148287080076d),
},
            new NpgsqlBoxbox0M
{
    Id = 112,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.814094963383856d,right: 0.4144054347938868d,bottom: 0.31177952559371913d,left: 0.02403447875761544d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7431353676218277d,right: 0.7416275866085824d,bottom: 0.05638798151816404d,left: 0.033597427934384694d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5286867707589229d,right: 0.7514675772594909d,bottom: 0.5227833790670507d,left: 0.19296612221769083d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6446070230765882d,right: 0.8387480369263853d,bottom: 0.029644307867889297d,left: 0.3661502231371959d),
},
            new NpgsqlBoxbox0M
{
    Id = 126,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8332084371986826d,right: 0.9624329461240035d,bottom: 0.534888345894045d,left: 0.5919657276164656d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.18751354609341409d,right: 0.663050017436001d,bottom: 0.02461909197424017d,left: 0.319124649619835d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7972456726034878d,right: 0.8148082798869332d,bottom: 0.6156825498546922d,left: 0.6947458180908409d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5724130826854725d,right: 0.8796051006705298d,bottom: 0.5206119472892853d,left: 0.6500653225178283d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5481159694712866d,right: 0.9986469024651312d,bottom: 0.040690428583176064d,left: 0.3918831974313466d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.859443908674293d,right: 0.999348724127498d,bottom: 0.16275633153301372d,left: 0.8015423277757968d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9920551157539882d,right: 0.6516752358196488d,bottom: 0.9829965650378479d,left: 0.4985094910949559d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 151,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.48444326839439245d,right: 0.746050372792508d,bottom: 0.28897894759957266d,left: 0.6574405043716239d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6245091849774959d,right: 0.2978131241021581d,bottom: 0.024412636090444417d,left: 0.23205356707916525d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.41846401487766416d,right: 0.9262549524935155d,bottom: 0.4134985285477042d,left: 0.537452068383231d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.49247784428779307d,right: 0.8035263278964438d,bottom: 0.03353543896377276d,left: 0.04404902535109345d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5631377614403603d,right: 0.5415593154344669d,bottom: 0.4418472713126034d,left: 0.30807931524420396d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.446404181769413d,right: 0.7011222789381306d,bottom: 0.36092237945744754d,left: 0.427570488364996d),
},
            new NpgsqlBoxbox0M
{
    Id = 168,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7441640118633688d,right: 0.9754386907653617d,bottom: 0.08961922446953452d,left: 0.31208160849016064d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3))]
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

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxSingleTypebox)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxSingleTypebox)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxSingleTypebox)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7408276880751065d,right: 0.34733326303109024d,bottom: 0.4087993223686398d,left: 0.23077554815940737d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(3);
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

                    nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6677552614492285d,right: 0.533543544623764d,bottom: 0.018855977722935235d,left: 0.17436770674494606d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
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
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxbox0mi_id", 
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
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox? nullable = null;
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxbox0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxbox0m(
	id,
    value,
    nullablevalue,
    npgsqlboxbox0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxbox0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlBox), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlboxbox0mi_id", 
                methodParametrName: "npgsqlboxbox0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxSingleTypebox)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[26],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[27],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[28],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M), typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 3, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 39, query1, 8, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[32],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxbox0M>();
                var models2 = new List<FlatNpgsqlBoxbox0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 47, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var firstItems2 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 32, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 39, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 38, query1, 25, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 3, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
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
FROM public.npgsqlboxbox0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems1 = new List<FlatNpgsqlBoxbox0M>();
                var secondItems2 = new List<FlatNpgsqlBoxbox0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
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
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 32, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 139, 94))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[30], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[31], false);NpgsqlBoxbox0M.AssertModel(models[24],_testData[32], false);NpgsqlBoxbox0M.AssertModel(models[25],_testData[33], false);NpgsqlBoxbox0M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 152);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[33], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9707283680235191d,right: 0.6092773037773457d,bottom: 0.11215853644445506d,left: 0.6026412586037638d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8286980642755074d,right: 0.8639626651101037d,bottom: 0.23862858037789958d,left: 0.6038518672731444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8702407179640481d,right: 0.4847361116009732d,bottom: 0.5456736906879168d,left: 0.23908447489272133d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25042603044203726d,right: 0.5342460271963715d,bottom: 0.05448984392005418d,left: 0.07038088270485465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8685179111914098d,right: 0.8569327567717238d,bottom: 0.013665099261010893d,left: 0.04765723256033205d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9696898300904022d,right: 0.29152781688359053d,bottom: 0.8212234546266246d,left: 0.07562277881562307d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8041388181039325d,right: 0.8100865803911068d,bottom: 0.5093242706017896d,left: 0.10067162327950552d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08838327026651471d,right: 0.9975372491639125d,bottom: 0.06074461580156976d,left: 0.40759381191389477d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2077123495856975d,right: 0.6867849179226835d,bottom: 0.1959887557343657d,left: 0.21114977616371944d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5586480194739945d,right: 0.8714757650884546d,bottom: 0.05305852161279001d,left: 0.29822863504814034d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8029863380098067d,right: 0.9346151259783329d,bottom: 0.09565315325715784d,left: 0.4008690097943207d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7408276880751065d,right: 0.34733326303109024d,bottom: 0.4087993223686398d,left: 0.23077554815940737d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8041817215837379d,right: 0.7250033631854519d,bottom: 0.303058505562801d,left: 0.4840264938905241d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.70427794978667d,right: 0.99350529467319d,bottom: 0.42851514821921477d,left: 0.0813025702346798d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9997432277203986d,right: 0.7385651182499647d,bottom: 0.6858962983501822d,left: 0.19064755130358269d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5593045360981453d,right: 0.5010838502706734d,bottom: 0.3980870160403289d,left: 0.3445607357627186d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6677552614492285d,right: 0.533543544623764d,bottom: 0.018855977722935235d,left: 0.17436770674494606d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7856797689000831d,right: 0.9000482134840174d,bottom: 0.5818362587701486d,left: 0.6150966529642607d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9709676809122934d,right: 0.8061933577801849d,bottom: 0.4088479254829127d,left: 0.20243109474811838d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.833894290824229d,right: 0.6922532185104331d,bottom: 0.22023352265273344d,left: 0.3468589080789547d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9315931222884611d,right: 0.8510287654512534d,bottom: 0.9240279585615353d,left: 0.8213264229026039d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6146726911362779d,right: 0.8255318883744172d,bottom: 0.24997939844900785d,left: 0.1418936331779217d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7021760773584433d,right: 0.7735835110520851d,bottom: 0.6397492671063459d,left: 0.6440600946402172d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6009722982230357d,right: 0.9594134894152749d,bottom: 0.5003138308165738d,left: 0.9504435377505256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7330496325895197d,right: 0.8138030739517468d,bottom: 0.6587343123264333d,left: 0.4989950083790896d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3906700412417029d,right: 0.6744666156983496d,bottom: 0.11732755259902083d,left: 0.41391536900199777d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.0862918329864013d,right: 0.8711955489263069d,bottom: 0.017896356012700565d,left: 0.21266184759575235d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38747521247936767d,right: 0.8687580749925962d,bottom: 0.2169842956805743d,left: 0.4518211997109911d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8701537122120343d,right: 0.5516831426451609d,bottom: 0.09264313529133372d,left: 0.3441590957239602d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9192505886678879d,right: 0.8141430174416712d,bottom: 0.8634263917433658d,left: 0.30489674765260755d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.553350517983721d,right: 0.4215131951977602d,bottom: 0.12110834399479264d,left: 0.14979727567468604d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30246094728385886d,right: 0.7105142631136853d,bottom: 0.16368903823110503d,left: 0.07556598716829799d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6013931242935074d,right: 0.7340206257988267d,bottom: 0.5437354008759667d,left: 0.0330437027248085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7404173900775886d,right: 0.8949459954030263d,bottom: 0.5321495689822924d,left: 0.4282866301204189d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5590195146478627d,right: 0.17708078831231222d,bottom: 0.3356683402618783d,left: 0.15612075596262354d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6648043755677454d,right: 0.8941784052135933d,bottom: 0.1210954120812926d,left: 0.22782390182242662d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8056040621853044d,right: 0.42507578636181864d,bottom: 0.27184007796671583d,left: 0.2639104315643753d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8466354734615493d,right: 0.08166538718000138d,bottom: 0.4493116319559928d,left: 0.058736047151356385d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5541919625227721d,right: 0.9654751036942d,bottom: 0.4607607898970061d,left: 0.8245366175391635d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41927853078234234d,right: 0.7029771654137036d,bottom: 0.28654863626987415d,left: 0.2997200397607579d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9056045035626732d,right: 0.10597416945257965d,bottom: 0.07814098625416044d,left: 0.01962570429660504d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6998674689297056d,right: 0.6688446408573138d,bottom: 0.2920205507317669d,left: 0.5144002413291616d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.20962554603668082d,right: 0.8210089617983639d,bottom: 0.10150728789541508d,left: 0.06989290005265514d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7320169388082519d,right: 0.9455978206031456d,bottom: 0.586113245613313d,left: 0.27895127962316923d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6040150361006451d,right: 0.8323409604601392d,bottom: 0.44111824592162596d,left: 0.4977650344404029d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8311986878755732d,right: 0.9611564879424502d,bottom: 0.274059368378315d,left: 0.03839889324202084d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8324283029038421d,right: 0.8379668566703069d,bottom: 0.6464251270430733d,left: 0.47135944357517634d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8734178055207513d,right: 0.6902963562334458d,bottom: 0.5573641497117017d,left: 0.5224132080448767d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5667823097326666d,right: 0.8537684442425177d,bottom: 0.34912687107198703d,left: 0.2788924634446356d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4316151051268846d,right: 0.8936624956900079d,bottom: 0.3306844504319173d,left: 0.2222225907489015d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.927347264847008d,right: 0.4004615412701228d,bottom: 0.35130780680049123d,left: 0.008259148287080076d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.814094963383856d,right: 0.4144054347938868d,bottom: 0.31177952559371913d,left: 0.02403447875761544d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7431353676218277d,right: 0.7416275866085824d,bottom: 0.05638798151816404d,left: 0.033597427934384694d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5286867707589229d,right: 0.7514675772594909d,bottom: 0.5227833790670507d,left: 0.19296612221769083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6446070230765882d,right: 0.8387480369263853d,bottom: 0.029644307867889297d,left: 0.3661502231371959d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8332084371986826d,right: 0.9624329461240035d,bottom: 0.534888345894045d,left: 0.5919657276164656d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18751354609341409d,right: 0.663050017436001d,bottom: 0.02461909197424017d,left: 0.319124649619835d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7972456726034878d,right: 0.8148082798869332d,bottom: 0.6156825498546922d,left: 0.6947458180908409d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5724130826854725d,right: 0.8796051006705298d,bottom: 0.5206119472892853d,left: 0.6500653225178283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5481159694712866d,right: 0.9986469024651312d,bottom: 0.040690428583176064d,left: 0.3918831974313466d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.859443908674293d,right: 0.999348724127498d,bottom: 0.16275633153301372d,left: 0.8015423277757968d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9920551157539882d,right: 0.6516752358196488d,bottom: 0.9829965650378479d,left: 0.4985094910949559d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48444326839439245d,right: 0.746050372792508d,bottom: 0.28897894759957266d,left: 0.6574405043716239d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6245091849774959d,right: 0.2978131241021581d,bottom: 0.024412636090444417d,left: 0.23205356707916525d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41846401487766416d,right: 0.9262549524935155d,bottom: 0.4134985285477042d,left: 0.537452068383231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49247784428779307d,right: 0.8035263278964438d,bottom: 0.03353543896377276d,left: 0.04404902535109345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5631377614403603d,right: 0.5415593154344669d,bottom: 0.4418472713126034d,left: 0.30807931524420396d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.446404181769413d,right: 0.7011222789381306d,bottom: 0.36092237945744754d,left: 0.427570488364996d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7441640118633688d,right: 0.9754386907653617d,bottom: 0.08961922446953452d,left: 0.31208160849016064d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((3)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9707283680235191d,right: 0.6092773037773457d,bottom: 0.11215853644445506d,left: 0.6026412586037638d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8286980642755074d,right: 0.8639626651101037d,bottom: 0.23862858037789958d,left: 0.6038518672731444d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8702407179640481d,right: 0.4847361116009732d,bottom: 0.5456736906879168d,left: 0.23908447489272133d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.25042603044203726d,right: 0.5342460271963715d,bottom: 0.05448984392005418d,left: 0.07038088270485465d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8685179111914098d,right: 0.8569327567717238d,bottom: 0.013665099261010893d,left: 0.04765723256033205d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9696898300904022d,right: 0.29152781688359053d,bottom: 0.8212234546266246d,left: 0.07562277881562307d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8041388181039325d,right: 0.8100865803911068d,bottom: 0.5093242706017896d,left: 0.10067162327950552d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.08838327026651471d,right: 0.9975372491639125d,bottom: 0.06074461580156976d,left: 0.40759381191389477d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2077123495856975d,right: 0.6867849179226835d,bottom: 0.1959887557343657d,left: 0.21114977616371944d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5586480194739945d,right: 0.8714757650884546d,bottom: 0.05305852161279001d,left: 0.29822863504814034d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8029863380098067d,right: 0.9346151259783329d,bottom: 0.09565315325715784d,left: 0.4008690097943207d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7408276880751065d,right: 0.34733326303109024d,bottom: 0.4087993223686398d,left: 0.23077554815940737d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8041817215837379d,right: 0.7250033631854519d,bottom: 0.303058505562801d,left: 0.4840264938905241d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.70427794978667d,right: 0.99350529467319d,bottom: 0.42851514821921477d,left: 0.0813025702346798d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9997432277203986d,right: 0.7385651182499647d,bottom: 0.6858962983501822d,left: 0.19064755130358269d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5593045360981453d,right: 0.5010838502706734d,bottom: 0.3980870160403289d,left: 0.3445607357627186d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6677552614492285d,right: 0.533543544623764d,bottom: 0.018855977722935235d,left: 0.17436770674494606d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7856797689000831d,right: 0.9000482134840174d,bottom: 0.5818362587701486d,left: 0.6150966529642607d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9709676809122934d,right: 0.8061933577801849d,bottom: 0.4088479254829127d,left: 0.20243109474811838d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.833894290824229d,right: 0.6922532185104331d,bottom: 0.22023352265273344d,left: 0.3468589080789547d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9315931222884611d,right: 0.8510287654512534d,bottom: 0.9240279585615353d,left: 0.8213264229026039d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((38)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6146726911362779d,right: 0.8255318883744172d,bottom: 0.24997939844900785d,left: 0.1418936331779217d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7021760773584433d,right: 0.7735835110520851d,bottom: 0.6397492671063459d,left: 0.6440600946402172d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6009722982230357d,right: 0.9594134894152749d,bottom: 0.5003138308165738d,left: 0.9504435377505256d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7330496325895197d,right: 0.8138030739517468d,bottom: 0.6587343123264333d,left: 0.4989950083790896d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3906700412417029d,right: 0.6744666156983496d,bottom: 0.11732755259902083d,left: 0.41391536900199777d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.0862918329864013d,right: 0.8711955489263069d,bottom: 0.017896356012700565d,left: 0.21266184759575235d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38747521247936767d,right: 0.8687580749925962d,bottom: 0.2169842956805743d,left: 0.4518211997109911d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8701537122120343d,right: 0.5516831426451609d,bottom: 0.09264313529133372d,left: 0.3441590957239602d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9192505886678879d,right: 0.8141430174416712d,bottom: 0.8634263917433658d,left: 0.30489674765260755d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.553350517983721d,right: 0.4215131951977602d,bottom: 0.12110834399479264d,left: 0.14979727567468604d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.30246094728385886d,right: 0.7105142631136853d,bottom: 0.16368903823110503d,left: 0.07556598716829799d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6013931242935074d,right: 0.7340206257988267d,bottom: 0.5437354008759667d,left: 0.0330437027248085d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((58)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7404173900775886d,right: 0.8949459954030263d,bottom: 0.5321495689822924d,left: 0.4282866301204189d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5590195146478627d,right: 0.17708078831231222d,bottom: 0.3356683402618783d,left: 0.15612075596262354d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6648043755677454d,right: 0.8941784052135933d,bottom: 0.1210954120812926d,left: 0.22782390182242662d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8056040621853044d,right: 0.42507578636181864d,bottom: 0.27184007796671583d,left: 0.2639104315643753d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8466354734615493d,right: 0.08166538718000138d,bottom: 0.4493116319559928d,left: 0.058736047151356385d))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5541919625227721d,right: 0.9654751036942d,bottom: 0.4607607898970061d,left: 0.8245366175391635d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41927853078234234d,right: 0.7029771654137036d,bottom: 0.28654863626987415d,left: 0.2997200397607579d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9056045035626732d,right: 0.10597416945257965d,bottom: 0.07814098625416044d,left: 0.01962570429660504d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6998674689297056d,right: 0.6688446408573138d,bottom: 0.2920205507317669d,left: 0.5144002413291616d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.20962554603668082d,right: 0.8210089617983639d,bottom: 0.10150728789541508d,left: 0.06989290005265514d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7320169388082519d,right: 0.9455978206031456d,bottom: 0.586113245613313d,left: 0.27895127962316923d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6040150361006451d,right: 0.8323409604601392d,bottom: 0.44111824592162596d,left: 0.4977650344404029d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8311986878755732d,right: 0.9611564879424502d,bottom: 0.274059368378315d,left: 0.03839889324202084d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8324283029038421d,right: 0.8379668566703069d,bottom: 0.6464251270430733d,left: 0.47135944357517634d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8734178055207513d,right: 0.6902963562334458d,bottom: 0.5573641497117017d,left: 0.5224132080448767d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5667823097326666d,right: 0.8537684442425177d,bottom: 0.34912687107198703d,left: 0.2788924634446356d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4316151051268846d,right: 0.8936624956900079d,bottom: 0.3306844504319173d,left: 0.2222225907489015d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.927347264847008d,right: 0.4004615412701228d,bottom: 0.35130780680049123d,left: 0.008259148287080076d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((112)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.814094963383856d,right: 0.4144054347938868d,bottom: 0.31177952559371913d,left: 0.02403447875761544d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7431353676218277d,right: 0.7416275866085824d,bottom: 0.05638798151816404d,left: 0.033597427934384694d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5286867707589229d,right: 0.7514675772594909d,bottom: 0.5227833790670507d,left: 0.19296612221769083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6446070230765882d,right: 0.8387480369263853d,bottom: 0.029644307867889297d,left: 0.3661502231371959d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((126)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8332084371986826d,right: 0.9624329461240035d,bottom: 0.534888345894045d,left: 0.5919657276164656d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.18751354609341409d,right: 0.663050017436001d,bottom: 0.02461909197424017d,left: 0.319124649619835d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7972456726034878d,right: 0.8148082798869332d,bottom: 0.6156825498546922d,left: 0.6947458180908409d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5724130826854725d,right: 0.8796051006705298d,bottom: 0.5206119472892853d,left: 0.6500653225178283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((94)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5481159694712866d,right: 0.9986469024651312d,bottom: 0.040690428583176064d,left: 0.3918831974313466d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.859443908674293d,right: 0.999348724127498d,bottom: 0.16275633153301372d,left: 0.8015423277757968d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9920551157539882d,right: 0.6516752358196488d,bottom: 0.9829965650378479d,left: 0.4985094910949559d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((151)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.48444326839439245d,right: 0.746050372792508d,bottom: 0.28897894759957266d,left: 0.6574405043716239d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((95)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6245091849774959d,right: 0.2978131241021581d,bottom: 0.024412636090444417d,left: 0.23205356707916525d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.41846401487766416d,right: 0.9262549524935155d,bottom: 0.4134985285477042d,left: 0.537452068383231d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.49247784428779307d,right: 0.8035263278964438d,bottom: 0.03353543896377276d,left: 0.04404902535109345d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((100)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5631377614403603d,right: 0.5415593154344669d,bottom: 0.4418472713126034d,left: 0.30807931524420396d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.446404181769413d,right: 0.7011222789381306d,bottom: 0.36092237945744754d,left: 0.427570488364996d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((168)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7441640118633688d,right: 0.9754386907653617d,bottom: 0.08961922446953452d,left: 0.31208160849016064d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxbox0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxbox0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxbox0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxbox0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxbox0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
FROM public.binary_npgsqlboxbox0m m
LEFT JOIN public.binary_npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxbox0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxbox0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxbox0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxbox0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxbox0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
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
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI), typeof(NpgsqlBoxbox0MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MI>();
                var models2 = new List<NpgsqlBoxbox0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models = await ((INpgsqlBoxSingleTypebox)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxbox0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA), typeof(NpgsqlBoxbox0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxbox0MIWA>();
                var models2 = new List<NpgsqlBoxbox0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox))]
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
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

