

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
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9566851097321791d,right: 0.9060658722223114d,bottom: 0.9374730658701748d,left: 0.17994917054487558d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.33253912877769487d,right: 0.7729067689248509d,bottom: 0.29821056899040066d,left: 0.7172114711149725d),
},
            new NpgsqlBoxbox0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17088639741204736d,right: 0.9234910076035722d,bottom: 0.07623421971635647d,left: 0.1592307979670421d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4818663716439415d,right: 0.5988962601995272d,bottom: 0.19287336027653423d,left: 0.24320586098173413d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9915412954850735d,right: 0.6776030183415377d,bottom: 0.8474273551171206d,left: 0.556928263369935d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.46843843888201575d,right: 0.31793591353806083d,bottom: 0.14134086908536714d,left: 0.10021569891893378d),
},
            new NpgsqlBoxbox0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.354797818058331d,right: 0.6656064767236819d,bottom: 0.2153509714003976d,left: 0.5201869610296946d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8406263312885994d,right: 0.4426770073103876d,bottom: 0.4589300799557584d,left: 0.43412377027000715d),
},
            new NpgsqlBoxbox0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4989143567619182d,right: 0.7868139802124975d,bottom: 0.47367728234267614d,left: 0.21412592093906035d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5715094548717169d,right: 0.8505629584534461d,bottom: 0.1879226996585851d,left: 0.3623369347694041d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7208907692054544d,right: 0.5527056711000904d,bottom: 0.6472527842980923d,left: 0.18055656765415828d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5722395001307027d,right: 0.9925534669631284d,bottom: 0.05193178401936405d,left: 0.12303115049907587d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.45474680120179256d,right: 0.6514201221905875d,bottom: 0.36628649790877377d,left: 0.3552300439203092d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9949014779288399d,right: 0.9262568619042346d,bottom: 0.00027998657955818906d,left: 0.7838271340791245d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5384483596042471d,right: 0.3970441418466273d,bottom: 0.07866579047868649d,left: 0.39229107618195636d),
},
            new NpgsqlBoxbox0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6995676357088823d,right: 0.6587286850529772d,bottom: 0.2786152876436676d,left: 0.0030922153117798334d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3827654874600743d,right: 0.3767473002410311d,bottom: 0.01637371772050089d,left: 0.06661879446428931d),
},
            new NpgsqlBoxbox0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.686772992371429d,right: 0.28860293379849034d,bottom: 0.31613524289708994d,left: 0.2868553393878879d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9677832399606262d,right: 0.38357392519261313d,bottom: 0.4874681513922138d,left: 0.034915942398894506d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9987525332702236d,right: 0.7780595200166259d,bottom: 0.15482448032477403d,left: 0.29923189519502347d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.23784038922042783d,right: 0.6607687597566488d,bottom: 0.02630067960982474d,left: 0.10480329984499426d),
},
            new NpgsqlBoxbox0M
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8095654095681388d,right: 0.9945706017432624d,bottom: 0.6994607074124873d,left: 0.9750660003433795d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9889361688268412d,right: 0.45843904019326787d,bottom: 0.5247284830111622d,left: 0.21279759393726905d),
},
            new NpgsqlBoxbox0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9474734562632373d,right: 0.4267334067281775d,bottom: 0.8464969487969556d,left: 0.24463101065276305d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5035756331518957d,right: 0.5548848481477725d,bottom: 0.3717675056065656d,left: 0.17187680781172476d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.3564034078178332d,right: 0.6895740885451901d,bottom: 0.22547189255827338d,left: 0.2332110990839893d),
},
            new NpgsqlBoxbox0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9136307677933794d,right: 0.5215078953507145d,bottom: 0.540260481954028d,left: 0.3138381564332413d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4493866136711283d,right: 0.9970487617972789d,bottom: 0.13116175864982427d,left: 0.48957321464098813d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.15251445343917625d,right: 0.5737372415801004d,bottom: 0.09731114707806054d,left: 0.49029810457820344d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.1510572020037284d,right: 0.9951583022911613d,bottom: 0.0363901012443687d,left: 0.8828419166130923d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8072758364568977d,right: 0.4296043336649994d,bottom: 0.3646100236045072d,left: 0.2701658854686527d),
},
            new NpgsqlBoxbox0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7251104772772596d,right: 0.5899279984484206d,bottom: 0.5797777014016208d,left: 0.42309231477187403d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5499897374855159d,right: 0.8176957276115686d,bottom: 0.3104674391905822d,left: 0.5314280421215479d),
},
            new NpgsqlBoxbox0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5365606219103449d,right: 0.5357237601709207d,bottom: 0.44316276636111496d,left: 0.2296492524034761d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9452674379051094d,right: 0.8189398328376196d,bottom: 0.5564828376567119d,left: 0.5693523197654018d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6206762868308299d,right: 0.7154091286804565d,bottom: 0.3318436087963419d,left: 0.15940666220358102d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5901969603516286d,right: 0.907441209357253d,bottom: 0.2945927616554256d,left: 0.834981904033597d),
},
            new NpgsqlBoxbox0M
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7951969472406818d,right: 0.49185697931925176d,bottom: 0.7388195320737782d,left: 0.18873299558815382d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7602793817587906d,right: 0.6101975543999949d,bottom: 0.7193645091073275d,left: 0.28449363336350064d),
},
            new NpgsqlBoxbox0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9545693017037623d,right: 0.8976760294712565d,bottom: 0.46838714832162875d,left: 0.6849320691462913d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.867026353973548d,right: 0.8293216030857061d,bottom: 0.3667393489834936d,left: 0.28819201707572384d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9510078706683874d,right: 0.25025613615465725d,bottom: 0.20679443634216854d,left: 0.017346920722578152d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7363598962568898d,right: 0.7958981088685538d,bottom: 0.0962934433363638d,left: 0.40217358013809645d),
},
            new NpgsqlBoxbox0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17739133985950328d,right: 0.14486516713257203d,bottom: 0.11880589789304041d,left: 0.10364067380628594d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7805047951597309d,right: 0.44828724663836717d,bottom: 0.2603499258517741d,left: 0.10936449519403846d),
},
            new NpgsqlBoxbox0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6840458838332127d,right: 0.22389463778759422d,bottom: 0.47907461076887636d,left: 0.20996396016025842d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.912444089577567d,right: 0.7932155768003406d,bottom: 0.1462808064348594d,left: 0.7271972639995957d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9641969727922147d,right: 0.7380039054387216d,bottom: 0.6200666962107775d,left: 0.06401903854315494d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.24662805078788397d,right: 0.8179060120596594d,bottom: 0.11682896387409325d,left: 0.5376141095170172d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8009037991706347d,right: 0.9928460583474101d,bottom: 0.05887946513995779d,left: 0.4219730725553552d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9457747237505262d,right: 0.41698588968999595d,bottom: 0.7181329697775761d,left: 0.37453604492738946d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8965501186966635d,right: 0.7463057583285067d,bottom: 0.715792673842269d,left: 0.15037955172203044d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9684560411352974d,right: 0.6393022952953439d,bottom: 0.39704724769071287d,left: 0.267546374499556d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9986237784708302d,right: 0.7526705710208729d,bottom: 0.5941510114447263d,left: 0.4257188478065258d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8634088717993146d,right: 0.834562055409137d,bottom: 0.4772999174157422d,left: 0.12057919202172895d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9754081415522304d,right: 0.41394205111704274d,bottom: 0.4664286394958653d,left: 0.1631481798852762d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8103470256139328d,right: 0.8138162014809339d,bottom: 0.7157829777295601d,left: 0.6041335616417792d),
},
            new NpgsqlBoxbox0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8150210674425136d,right: 0.9348730501568816d,bottom: 0.19872810153103893d,left: 0.6614120970946149d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.997340116734109d,right: 0.24878904818284342d,bottom: 0.7414663916593954d,left: 0.05975387245223607d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9492123384384478d,right: 0.5067418712356985d,bottom: 0.0008270313740023072d,left: 0.17989265779010422d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8623748010370497d,right: 0.9620003219213895d,bottom: 0.048199056284646935d,left: 0.5001576529720332d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9843664034806024d,right: 0.7914490480613945d,bottom: 0.8765639081355556d,left: 0.7220803947217431d),
},
            new NpgsqlBoxbox0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5906993493018471d,right: 0.3191418440392857d,bottom: 0.17097139232351954d,left: 0.06939826760009227d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9385744700917216d,right: 0.9404140740719493d,bottom: 0.8379843992979348d,left: 0.3866070724353118d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9669663875562186d,right: 0.9521938840434121d,bottom: 0.5917780995750939d,left: 0.08793050963105242d),
},
            new NpgsqlBoxbox0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6074391916400338d,right: 0.9523130822392689d,bottom: 0.2904228399120302d,left: 0.6478319698289566d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6585733859504413d,right: 0.6765625303083693d,bottom: 0.051091237351980956d,left: 0.5719529307578128d),
},
            new NpgsqlBoxbox0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8195670190050652d,right: 0.962933424398616d,bottom: 0.5836041316755393d,left: 0.7152605873231517d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.941692122803703d,right: 0.9535441414641753d,bottom: 0.05164164393325277d,left: 0.2379292570495064d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8578984548930946d,right: 0.8793287271502159d,bottom: 0.07488771014871387d,left: 0.5736776192039524d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9246977994741074d,right: 0.9560176412336737d,bottom: 0.7678725746155479d,left: 0.7771641812314524d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8738357746241479d,right: 0.13835163954472862d,bottom: 0.5757096719681407d,left: 0.009804453971334448d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9684208686193917d,right: 0.7832980785050088d,bottom: 0.3601682397647369d,left: 0.06578585183841223d),
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5384483596042471d,right: 0.3970441418466273d,bottom: 0.07866579047868649d,left: 0.39229107618195636d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3827654874600743d,right: 0.3767473002410311d,bottom: 0.01637371772050089d,left: 0.06661879446428931d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.23784038922042783d,right: 0.6607687597566488d,bottom: 0.02630067960982474d,left: 0.10480329984499426d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.9889361688268412d,right: 0.45843904019326787d,bottom: 0.5247284830111622d,left: 0.21279759393726905d)));
                nullable =  ((INpgsqlBoxSingleTypebox)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.3564034078178332d,right: 0.6895740885451901d,bottom: 0.22547189255827338d,left: 0.2332110990839893d)));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8072758364568977d,right: 0.4296043336649994d,bottom: 0.3646100236045072d,left: 0.2701658854686527d)));
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[19],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 102, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[29], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 65, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 26, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[18],_testData[29], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 1, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 128, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[29], false);
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
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 116, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 27, query1, 26, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
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
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 82, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxbox0M.AssertModel(secondItems2[10],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 60, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 90, 121))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlBoxbox0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlBoxbox0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlBoxbox0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlBoxbox0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlBoxbox0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 27);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[6], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9566851097321791d,right: 0.9060658722223114d,bottom: 0.9374730658701748d,left: 0.17994917054487558d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.33253912877769487d,right: 0.7729067689248509d,bottom: 0.29821056899040066d,left: 0.7172114711149725d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17088639741204736d,right: 0.9234910076035722d,bottom: 0.07623421971635647d,left: 0.1592307979670421d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4818663716439415d,right: 0.5988962601995272d,bottom: 0.19287336027653423d,left: 0.24320586098173413d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9915412954850735d,right: 0.6776030183415377d,bottom: 0.8474273551171206d,left: 0.556928263369935d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46843843888201575d,right: 0.31793591353806083d,bottom: 0.14134086908536714d,left: 0.10021569891893378d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.354797818058331d,right: 0.6656064767236819d,bottom: 0.2153509714003976d,left: 0.5201869610296946d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8406263312885994d,right: 0.4426770073103876d,bottom: 0.4589300799557584d,left: 0.43412377027000715d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4989143567619182d,right: 0.7868139802124975d,bottom: 0.47367728234267614d,left: 0.21412592093906035d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5715094548717169d,right: 0.8505629584534461d,bottom: 0.1879226996585851d,left: 0.3623369347694041d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7208907692054544d,right: 0.5527056711000904d,bottom: 0.6472527842980923d,left: 0.18055656765415828d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5722395001307027d,right: 0.9925534669631284d,bottom: 0.05193178401936405d,left: 0.12303115049907587d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45474680120179256d,right: 0.6514201221905875d,bottom: 0.36628649790877377d,left: 0.3552300439203092d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9949014779288399d,right: 0.9262568619042346d,bottom: 0.00027998657955818906d,left: 0.7838271340791245d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5384483596042471d,right: 0.3970441418466273d,bottom: 0.07866579047868649d,left: 0.39229107618195636d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6995676357088823d,right: 0.6587286850529772d,bottom: 0.2786152876436676d,left: 0.0030922153117798334d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3827654874600743d,right: 0.3767473002410311d,bottom: 0.01637371772050089d,left: 0.06661879446428931d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.686772992371429d,right: 0.28860293379849034d,bottom: 0.31613524289708994d,left: 0.2868553393878879d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9677832399606262d,right: 0.38357392519261313d,bottom: 0.4874681513922138d,left: 0.034915942398894506d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9987525332702236d,right: 0.7780595200166259d,bottom: 0.15482448032477403d,left: 0.29923189519502347d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23784038922042783d,right: 0.6607687597566488d,bottom: 0.02630067960982474d,left: 0.10480329984499426d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8095654095681388d,right: 0.9945706017432624d,bottom: 0.6994607074124873d,left: 0.9750660003433795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9889361688268412d,right: 0.45843904019326787d,bottom: 0.5247284830111622d,left: 0.21279759393726905d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9474734562632373d,right: 0.4267334067281775d,bottom: 0.8464969487969556d,left: 0.24463101065276305d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5035756331518957d,right: 0.5548848481477725d,bottom: 0.3717675056065656d,left: 0.17187680781172476d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3564034078178332d,right: 0.6895740885451901d,bottom: 0.22547189255827338d,left: 0.2332110990839893d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9136307677933794d,right: 0.5215078953507145d,bottom: 0.540260481954028d,left: 0.3138381564332413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4493866136711283d,right: 0.9970487617972789d,bottom: 0.13116175864982427d,left: 0.48957321464098813d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.15251445343917625d,right: 0.5737372415801004d,bottom: 0.09731114707806054d,left: 0.49029810457820344d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1510572020037284d,right: 0.9951583022911613d,bottom: 0.0363901012443687d,left: 0.8828419166130923d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8072758364568977d,right: 0.4296043336649994d,bottom: 0.3646100236045072d,left: 0.2701658854686527d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7251104772772596d,right: 0.5899279984484206d,bottom: 0.5797777014016208d,left: 0.42309231477187403d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5499897374855159d,right: 0.8176957276115686d,bottom: 0.3104674391905822d,left: 0.5314280421215479d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5365606219103449d,right: 0.5357237601709207d,bottom: 0.44316276636111496d,left: 0.2296492524034761d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9452674379051094d,right: 0.8189398328376196d,bottom: 0.5564828376567119d,left: 0.5693523197654018d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6206762868308299d,right: 0.7154091286804565d,bottom: 0.3318436087963419d,left: 0.15940666220358102d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5901969603516286d,right: 0.907441209357253d,bottom: 0.2945927616554256d,left: 0.834981904033597d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7951969472406818d,right: 0.49185697931925176d,bottom: 0.7388195320737782d,left: 0.18873299558815382d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7602793817587906d,right: 0.6101975543999949d,bottom: 0.7193645091073275d,left: 0.28449363336350064d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9545693017037623d,right: 0.8976760294712565d,bottom: 0.46838714832162875d,left: 0.6849320691462913d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.867026353973548d,right: 0.8293216030857061d,bottom: 0.3667393489834936d,left: 0.28819201707572384d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9510078706683874d,right: 0.25025613615465725d,bottom: 0.20679443634216854d,left: 0.017346920722578152d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7363598962568898d,right: 0.7958981088685538d,bottom: 0.0962934433363638d,left: 0.40217358013809645d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17739133985950328d,right: 0.14486516713257203d,bottom: 0.11880589789304041d,left: 0.10364067380628594d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7805047951597309d,right: 0.44828724663836717d,bottom: 0.2603499258517741d,left: 0.10936449519403846d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6840458838332127d,right: 0.22389463778759422d,bottom: 0.47907461076887636d,left: 0.20996396016025842d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.912444089577567d,right: 0.7932155768003406d,bottom: 0.1462808064348594d,left: 0.7271972639995957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9641969727922147d,right: 0.7380039054387216d,bottom: 0.6200666962107775d,left: 0.06401903854315494d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24662805078788397d,right: 0.8179060120596594d,bottom: 0.11682896387409325d,left: 0.5376141095170172d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8009037991706347d,right: 0.9928460583474101d,bottom: 0.05887946513995779d,left: 0.4219730725553552d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9457747237505262d,right: 0.41698588968999595d,bottom: 0.7181329697775761d,left: 0.37453604492738946d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8965501186966635d,right: 0.7463057583285067d,bottom: 0.715792673842269d,left: 0.15037955172203044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9684560411352974d,right: 0.6393022952953439d,bottom: 0.39704724769071287d,left: 0.267546374499556d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9986237784708302d,right: 0.7526705710208729d,bottom: 0.5941510114447263d,left: 0.4257188478065258d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8634088717993146d,right: 0.834562055409137d,bottom: 0.4772999174157422d,left: 0.12057919202172895d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9754081415522304d,right: 0.41394205111704274d,bottom: 0.4664286394958653d,left: 0.1631481798852762d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8103470256139328d,right: 0.8138162014809339d,bottom: 0.7157829777295601d,left: 0.6041335616417792d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8150210674425136d,right: 0.9348730501568816d,bottom: 0.19872810153103893d,left: 0.6614120970946149d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.997340116734109d,right: 0.24878904818284342d,bottom: 0.7414663916593954d,left: 0.05975387245223607d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9492123384384478d,right: 0.5067418712356985d,bottom: 0.0008270313740023072d,left: 0.17989265779010422d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8623748010370497d,right: 0.9620003219213895d,bottom: 0.048199056284646935d,left: 0.5001576529720332d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9843664034806024d,right: 0.7914490480613945d,bottom: 0.8765639081355556d,left: 0.7220803947217431d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5906993493018471d,right: 0.3191418440392857d,bottom: 0.17097139232351954d,left: 0.06939826760009227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9385744700917216d,right: 0.9404140740719493d,bottom: 0.8379843992979348d,left: 0.3866070724353118d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9669663875562186d,right: 0.9521938840434121d,bottom: 0.5917780995750939d,left: 0.08793050963105242d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6074391916400338d,right: 0.9523130822392689d,bottom: 0.2904228399120302d,left: 0.6478319698289566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6585733859504413d,right: 0.6765625303083693d,bottom: 0.051091237351980956d,left: 0.5719529307578128d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8195670190050652d,right: 0.962933424398616d,bottom: 0.5836041316755393d,left: 0.7152605873231517d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.941692122803703d,right: 0.9535441414641753d,bottom: 0.05164164393325277d,left: 0.2379292570495064d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8578984548930946d,right: 0.8793287271502159d,bottom: 0.07488771014871387d,left: 0.5736776192039524d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9246977994741074d,right: 0.9560176412336737d,bottom: 0.7678725746155479d,left: 0.7771641812314524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8738357746241479d,right: 0.13835163954472862d,bottom: 0.5757096719681407d,left: 0.009804453971334448d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9684208686193917d,right: 0.7832980785050088d,bottom: 0.3601682397647369d,left: 0.06578585183841223d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((1)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9566851097321791d,right: 0.9060658722223114d,bottom: 0.9374730658701748d,left: 0.17994917054487558d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.33253912877769487d,right: 0.7729067689248509d,bottom: 0.29821056899040066d,left: 0.7172114711149725d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17088639741204736d,right: 0.9234910076035722d,bottom: 0.07623421971635647d,left: 0.1592307979670421d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4818663716439415d,right: 0.5988962601995272d,bottom: 0.19287336027653423d,left: 0.24320586098173413d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9915412954850735d,right: 0.6776030183415377d,bottom: 0.8474273551171206d,left: 0.556928263369935d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46843843888201575d,right: 0.31793591353806083d,bottom: 0.14134086908536714d,left: 0.10021569891893378d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.354797818058331d,right: 0.6656064767236819d,bottom: 0.2153509714003976d,left: 0.5201869610296946d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8406263312885994d,right: 0.4426770073103876d,bottom: 0.4589300799557584d,left: 0.43412377027000715d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4989143567619182d,right: 0.7868139802124975d,bottom: 0.47367728234267614d,left: 0.21412592093906035d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((13)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5715094548717169d,right: 0.8505629584534461d,bottom: 0.1879226996585851d,left: 0.3623369347694041d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7208907692054544d,right: 0.5527056711000904d,bottom: 0.6472527842980923d,left: 0.18055656765415828d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5722395001307027d,right: 0.9925534669631284d,bottom: 0.05193178401936405d,left: 0.12303115049907587d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.45474680120179256d,right: 0.6514201221905875d,bottom: 0.36628649790877377d,left: 0.3552300439203092d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9949014779288399d,right: 0.9262568619042346d,bottom: 0.00027998657955818906d,left: 0.7838271340791245d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5384483596042471d,right: 0.3970441418466273d,bottom: 0.07866579047868649d,left: 0.39229107618195636d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6995676357088823d,right: 0.6587286850529772d,bottom: 0.2786152876436676d,left: 0.0030922153117798334d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3827654874600743d,right: 0.3767473002410311d,bottom: 0.01637371772050089d,left: 0.06661879446428931d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.686772992371429d,right: 0.28860293379849034d,bottom: 0.31613524289708994d,left: 0.2868553393878879d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9677832399606262d,right: 0.38357392519261313d,bottom: 0.4874681513922138d,left: 0.034915942398894506d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9987525332702236d,right: 0.7780595200166259d,bottom: 0.15482448032477403d,left: 0.29923189519502347d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23784038922042783d,right: 0.6607687597566488d,bottom: 0.02630067960982474d,left: 0.10480329984499426d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((45)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8095654095681388d,right: 0.9945706017432624d,bottom: 0.6994607074124873d,left: 0.9750660003433795d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9889361688268412d,right: 0.45843904019326787d,bottom: 0.5247284830111622d,left: 0.21279759393726905d))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9474734562632373d,right: 0.4267334067281775d,bottom: 0.8464969487969556d,left: 0.24463101065276305d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((21)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5035756331518957d,right: 0.5548848481477725d,bottom: 0.3717675056065656d,left: 0.17187680781172476d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3564034078178332d,right: 0.6895740885451901d,bottom: 0.22547189255827338d,left: 0.2332110990839893d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9136307677933794d,right: 0.5215078953507145d,bottom: 0.540260481954028d,left: 0.3138381564332413d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4493866136711283d,right: 0.9970487617972789d,bottom: 0.13116175864982427d,left: 0.48957321464098813d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.15251445343917625d,right: 0.5737372415801004d,bottom: 0.09731114707806054d,left: 0.49029810457820344d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1510572020037284d,right: 0.9951583022911613d,bottom: 0.0363901012443687d,left: 0.8828419166130923d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8072758364568977d,right: 0.4296043336649994d,bottom: 0.3646100236045072d,left: 0.2701658854686527d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7251104772772596d,right: 0.5899279984484206d,bottom: 0.5797777014016208d,left: 0.42309231477187403d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5499897374855159d,right: 0.8176957276115686d,bottom: 0.3104674391905822d,left: 0.5314280421215479d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5365606219103449d,right: 0.5357237601709207d,bottom: 0.44316276636111496d,left: 0.2296492524034761d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9452674379051094d,right: 0.8189398328376196d,bottom: 0.5564828376567119d,left: 0.5693523197654018d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6206762868308299d,right: 0.7154091286804565d,bottom: 0.3318436087963419d,left: 0.15940666220358102d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5901969603516286d,right: 0.907441209357253d,bottom: 0.2945927616554256d,left: 0.834981904033597d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((65)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7951969472406818d,right: 0.49185697931925176d,bottom: 0.7388195320737782d,left: 0.18873299558815382d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7602793817587906d,right: 0.6101975543999949d,bottom: 0.7193645091073275d,left: 0.28449363336350064d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9545693017037623d,right: 0.8976760294712565d,bottom: 0.46838714832162875d,left: 0.6849320691462913d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.867026353973548d,right: 0.8293216030857061d,bottom: 0.3667393489834936d,left: 0.28819201707572384d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9510078706683874d,right: 0.25025613615465725d,bottom: 0.20679443634216854d,left: 0.017346920722578152d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7363598962568898d,right: 0.7958981088685538d,bottom: 0.0962934433363638d,left: 0.40217358013809645d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17739133985950328d,right: 0.14486516713257203d,bottom: 0.11880589789304041d,left: 0.10364067380628594d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7805047951597309d,right: 0.44828724663836717d,bottom: 0.2603499258517741d,left: 0.10936449519403846d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6840458838332127d,right: 0.22389463778759422d,bottom: 0.47907461076887636d,left: 0.20996396016025842d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.912444089577567d,right: 0.7932155768003406d,bottom: 0.1462808064348594d,left: 0.7271972639995957d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9641969727922147d,right: 0.7380039054387216d,bottom: 0.6200666962107775d,left: 0.06401903854315494d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24662805078788397d,right: 0.8179060120596594d,bottom: 0.11682896387409325d,left: 0.5376141095170172d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8009037991706347d,right: 0.9928460583474101d,bottom: 0.05887946513995779d,left: 0.4219730725553552d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9457747237505262d,right: 0.41698588968999595d,bottom: 0.7181329697775761d,left: 0.37453604492738946d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8965501186966635d,right: 0.7463057583285067d,bottom: 0.715792673842269d,left: 0.15037955172203044d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9684560411352974d,right: 0.6393022952953439d,bottom: 0.39704724769071287d,left: 0.267546374499556d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9986237784708302d,right: 0.7526705710208729d,bottom: 0.5941510114447263d,left: 0.4257188478065258d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8634088717993146d,right: 0.834562055409137d,bottom: 0.4772999174157422d,left: 0.12057919202172895d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9754081415522304d,right: 0.41394205111704274d,bottom: 0.4664286394958653d,left: 0.1631481798852762d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8103470256139328d,right: 0.8138162014809339d,bottom: 0.7157829777295601d,left: 0.6041335616417792d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8150210674425136d,right: 0.9348730501568816d,bottom: 0.19872810153103893d,left: 0.6614120970946149d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.997340116734109d,right: 0.24878904818284342d,bottom: 0.7414663916593954d,left: 0.05975387245223607d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9492123384384478d,right: 0.5067418712356985d,bottom: 0.0008270313740023072d,left: 0.17989265779010422d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8623748010370497d,right: 0.9620003219213895d,bottom: 0.048199056284646935d,left: 0.5001576529720332d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9843664034806024d,right: 0.7914490480613945d,bottom: 0.8765639081355556d,left: 0.7220803947217431d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5906993493018471d,right: 0.3191418440392857d,bottom: 0.17097139232351954d,left: 0.06939826760009227d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9385744700917216d,right: 0.9404140740719493d,bottom: 0.8379843992979348d,left: 0.3866070724353118d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9669663875562186d,right: 0.9521938840434121d,bottom: 0.5917780995750939d,left: 0.08793050963105242d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6074391916400338d,right: 0.9523130822392689d,bottom: 0.2904228399120302d,left: 0.6478319698289566d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6585733859504413d,right: 0.6765625303083693d,bottom: 0.051091237351980956d,left: 0.5719529307578128d))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8195670190050652d,right: 0.962933424398616d,bottom: 0.5836041316755393d,left: 0.7152605873231517d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.941692122803703d,right: 0.9535441414641753d,bottom: 0.05164164393325277d,left: 0.2379292570495064d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8578984548930946d,right: 0.8793287271502159d,bottom: 0.07488771014871387d,left: 0.5736776192039524d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9246977994741074d,right: 0.9560176412336737d,bottom: 0.7678725746155479d,left: 0.7771641812314524d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((72)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8738357746241479d,right: 0.13835163954472862d,bottom: 0.5757096719681407d,left: 0.009804453971334448d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9684208686193917d,right: 0.7832980785050088d,bottom: 0.3601682397647369d,left: 0.06578585183841223d))));

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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
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
        public  void DynQueryImportModelInnerTest()
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxbox0MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
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

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxbox0M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((INpgsqlBoxSingleTypebox)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((INpgsqlBoxSingleTypebox)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxbox0M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxbox0M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxbox0M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxbox0M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxbox0M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxbox0M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxbox0M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxbox0M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxbox0M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxbox0M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxbox0M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxbox0M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxbox0M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxbox0M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxbox0M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxbox0M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxbox0M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxbox0M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxbox0M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxbox0M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxbox0M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxbox0M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxbox0M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxbox0M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxbox0M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxbox0M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxbox0M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxbox0M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxbox0M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxbox0M.AssertModel(models[29],_testData[29], false);
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxSingleTypebox)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxbox0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
COPY public.binary_npgsqlboxbox0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxbox0MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

