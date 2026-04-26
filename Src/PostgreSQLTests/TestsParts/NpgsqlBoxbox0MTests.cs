

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
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5991067301855811d,right: 0.6490780263592937d,bottom: 0.26520974550895904d,left: 0.2465520235960924d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.995735938111539d,right: 0.7175046913567835d,bottom: 0.8142403501245826d,left: 0.4830440825125796d),
},
            new NpgsqlBoxbox0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9309144044907612d,right: 0.7690785932807772d,bottom: 0.744154899681525d,left: 0.7653996357564284d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8601055422144555d,right: 0.8446923408984083d,bottom: 0.46494633719996137d,left: 0.5709393505054244d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5419102663009313d,right: 0.43866983960646977d,bottom: 0.4060671330530874d,left: 0.03215628633515066d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6591253435027242d,right: 0.7711037491525833d,bottom: 0.4900903618033523d,left: 0.5064684650867646d),
},
            new NpgsqlBoxbox0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9246458922302128d,right: 0.7497564743111736d,bottom: 0.45098196522679623d,left: 0.3698922961602892d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5930070206590589d,right: 0.9453186551310319d,bottom: 0.44267423197088784d,left: 0.5711714074396034d),
},
            new NpgsqlBoxbox0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6935094802018925d,right: 0.9429418978936465d,bottom: 0.5707214596967919d,left: 0.8123984005324595d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2985971185698324d,right: 0.9139776429124087d,bottom: 0.10617395421613951d,left: 0.6871708153114576d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5149908669338243d,right: 0.19079483728290714d,bottom: 0.352096161745295d,left: 0.07974208068519106d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.12330052793360635d,right: 0.426088281379691d,bottom: 0.09841580622842205d,left: 0.09563335958827146d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7782985901889382d,right: 0.6147868131331454d,bottom: 0.1363769366379306d,left: 0.2520633038755532d),
},
            new NpgsqlBoxbox0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5049396477158045d,right: 0.8241711367220284d,bottom: 0.3273370347467043d,left: 0.2526795283908223d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9558150149565476d,right: 0.9650410612075634d,bottom: 0.6649216900317486d,left: 0.33952462706024955d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5235273838472849d,right: 0.6238391272930756d,bottom: 0.36646017725356206d,left: 0.10082462688550986d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8709051899400304d,right: 0.30668779983732564d,bottom: 0.2574905583839435d,left: 0.11159614904298054d),
},
            new NpgsqlBoxbox0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7227529876432611d,right: 0.42425941572263004d,bottom: 0.4921128488075128d,left: 0.35685386224548954d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.628906049006411d,right: 0.7130750449420841d,bottom: 0.5065217912380716d,left: 0.4814666353072098d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.35782523848401815d,right: 0.8232880468316363d,bottom: 0.06972401149439866d,left: 0.15234094432781564d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.840014171529617d,right: 0.37796734669655385d,bottom: 0.34394042716260975d,left: 0.2353330696998881d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.24235267641965308d,right: 0.9762836889575847d,bottom: 0.013191956206442312d,left: 0.45558804127942965d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.43869987225416973d,right: 0.896917294660753d,bottom: 0.24399889789779317d,left: 0.002270755882138986d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8080152131030099d,right: 0.5648430265241718d,bottom: 0.6353980408800399d,left: 0.14743330299442647d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4281078638362398d,right: 0.49787275988476853d,bottom: 0.12698762574915956d,left: 0.4787089326623216d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.686841187098799d,right: 0.8793220635990836d,bottom: 0.24829613492500902d,left: 0.1702611413929478d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8467282865369256d,right: 0.516852312093768d,bottom: 0.08498350589530002d,left: 0.28585144670336315d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9616521193258389d,right: 0.7409581417857024d,bottom: 0.5289533379410686d,left: 0.23828418258772166d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5404871911001891d,right: 0.7713533677247078d,bottom: 0.1619469093905469d,left: 0.7566918785787764d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9764477664871136d,right: 0.7085009064970706d,bottom: 0.33055204971541485d,left: 0.4433255647231501d),
},
            new NpgsqlBoxbox0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5504756991431883d,right: 0.9508173360895341d,bottom: 0.16571822174644713d,left: 0.46600959874924497d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.031394421658518135d,right: 0.38737776234432686d,bottom: 0.013978350631560055d,left: 0.3032873706483207d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9537049445893991d,right: 0.6160209107918492d,bottom: 0.24607308223429836d,left: 0.38676863906842596d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8402111968779558d,right: 0.9233265565580601d,bottom: 0.818028308689704d,left: 0.31944245262762894d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.784948736921833d,right: 0.7076854616420524d,bottom: 0.5778760161599151d,left: 0.3733120356499231d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7212054159814579d,right: 0.5934083517110748d,bottom: 0.15393320118145526d,left: 0.17544222147147492d),
},
            new NpgsqlBoxbox0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5278613441247613d,right: 0.34754281998492276d,bottom: 0.41969502905799394d,left: 0.10003930529064942d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8444070242336472d,right: 0.7269456781193275d,bottom: 0.39351728963894395d,left: 0.463362698250649d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2110400016672368d,right: 0.6362817072130538d,bottom: 0.1336482774172365d,left: 0.5313717638374196d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9599637003892725d,right: 0.9423428306292135d,bottom: 0.12241921009662138d,left: 0.21661677816357172d),
},
            new NpgsqlBoxbox0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.793984432984126d,right: 0.46212563478323687d,bottom: 0.7700124292567689d,left: 0.28889066152043785d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9079796908481481d,right: 0.9097116077332783d,bottom: 0.7788876421564027d,left: 0.5804413615757914d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5233033715353061d,right: 0.8528263553931218d,bottom: 0.14628463206555342d,left: 0.4614478130957921d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6202665354233738d,right: 0.11982405345706137d,bottom: 0.32071931438412327d,left: 0.06273549414331236d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 110,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4972203462988004d,right: 0.504008089093447d,bottom: 0.46534715659170667d,left: 0.2542215786104297d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8050160526422648d,right: 0.46058106419385325d,bottom: 0.5309118843084286d,left: 0.029699512894544422d),
},
            new NpgsqlBoxbox0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7633805712602397d,right: 0.7583505545204149d,bottom: 0.25760987077967723d,left: 0.6760938867063858d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9440674273574534d,right: 0.8992804093729505d,bottom: 0.7237747890380553d,left: 0.5332672436800256d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8222962761742788d,right: 0.9534711346776759d,bottom: 0.43997614118057315d,left: 0.20949371996954436d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6969864430021528d,right: 0.8331410370200311d,bottom: 0.6709898230887048d,left: 0.012003662896161393d),
},
            new NpgsqlBoxbox0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9026570629031707d,right: 0.7628657188279911d,bottom: 0.4556877166175516d,left: 0.42237634593880324d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7646436027331175d,right: 0.6001330227652172d,bottom: 0.40503715256417117d,left: 0.5456848801536613d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5878490438161734d,right: 0.4804903564320643d,bottom: 0.4883374086279152d,left: 0.39014625068011677d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6297035383359489d,right: 0.5928091341441799d,bottom: 0.387067808079669d,left: 0.24484778141610464d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.35970777262779596d,right: 0.4009352531109912d,bottom: 0.27643130923935655d,left: 0.034536945780194395d),
},
            new NpgsqlBoxbox0M
{
    Id = 136,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8459179517397567d,right: 0.9303300963135097d,bottom: 0.8109433274540988d,left: 0.8750101740031292d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 140,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7967862730879813d,right: 0.2154810297330373d,bottom: 0.5277667290118011d,left: 0.005854853730125842d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.1699115785860168d,right: 0.9363232828072431d,bottom: 0.07894401503328785d,left: 0.820350299825655d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7914282902252489d,right: 0.7904099942462681d,bottom: 0.16151540025787292d,left: 0.10254252333869651d),
},
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 144,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7610636587220228d,right: 0.8099319564967042d,bottom: 0.555524565465952d,left: 0.36696446252647463d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxbox0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.756138548408596d,right: 0.8689777665077482d,bottom: 0.1829643390343053d,left: 0.864458960180035d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.17853811840611844d,right: 0.8052881391566926d,bottom: 0.06656840359494964d,left: 0.5044347736068193d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7604432139151108d,right: 0.9933633220929501d,bottom: 0.5860099365082082d,left: 0.7993940644009924d),
},
            new NpgsqlBoxbox0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6118932836758527d,right: 0.6319144147538205d,bottom: 0.21974350672790466d,left: 0.42578568447407406d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8254055499284662d,right: 0.784823889206685d,bottom: 0.4564595628508935d,left: 0.36838398465157984d),
},
            new NpgsqlBoxbox0M
{
    Id = 162,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8521155265987495d,right: 0.562317568364157d,bottom: 0.4768890113906876d,left: 0.5486985977018443d),
    ModelInner = new NpgsqlBoxbox0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4983391707740744d,right: 0.36005564138337764d,bottom: 0.3489426973908003d,left: 0.08267780775082745d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7936666948850499d,right: 0.40018390624808897d,bottom: 0.7558017770087292d,left: 0.10544079791377559d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5278828978318081d,right: 0.8882172842137012d,bottom: 0.19014905108558455d,left: 0.6813375036059229d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.7782985901889382d,right: 0.6147868131331454d,bottom: 0.1363769366379306d,left: 0.2520633038755532d)));
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.8709051899400304d,right: 0.30668779983732564d,bottom: 0.2574905583839435d,left: 0.11159614904298054d)));
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
                Assert.That(nullable, Is.Null);
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

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((INpgsqlBoxSingleTypebox)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((INpgsqlBoxSingleTypebox)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[7], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[8], false);FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[9], false);FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[10], false);FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[11], false);FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[12], false);FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[13], false);FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[14], false);FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[15], false);FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[16], false);FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[17], false);FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[18], false);FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[19], false);FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[20], false);FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[21], false);FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[22], false);FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[23], false);FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[24], false);FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[25], false);FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[26], false);FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[27], false);FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[1], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[2], false);FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[3], false);FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[4], false);FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[5], false);FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[6], false);FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[7], false);FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[8], false);FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[9], false);FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[10], false);FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[11], false);FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[12], false);FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[13], false);FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[14], false);FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[15], false);FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[16], false);FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[17], false);FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[18], false);FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[19], false);FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[20], false);FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[21], false);FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[22], false);FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[23], false);FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[24], false);FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[25], false);FlatNpgsqlBoxbox0M.AssertModel(models[25],_testData[26], false);FlatNpgsqlBoxbox0M.AssertModel(models[26],_testData[27], false);FlatNpgsqlBoxbox0M.AssertModel(models[27],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[2], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[3], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[4], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[5], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[6], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[24],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[25],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[26],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[3], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[4], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[5], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[6], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[24],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[25],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[26],_testData[29], false);
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

                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxbox0M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 104, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[20], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[21], false);FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[22], false);FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[23], false);FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[24], false);FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[25], false);FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[26], false);FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[27], false);FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[26], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[27], false);FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxbox0m m
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
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
LEFT JOIN public.npgsqlboxbox0mi mi ON mi.id = m.npgsqlboxbox0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);FlatNpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);FlatNpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);FlatNpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);FlatNpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);FlatNpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);FlatNpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);FlatNpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);FlatNpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);FlatNpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);FlatNpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);FlatNpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);FlatNpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);FlatNpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);FlatNpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);FlatNpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);FlatNpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);FlatNpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);FlatNpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);FlatNpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlBoxbox0M.AssertModel(models[0],_testData[25], false);FlatNpgsqlBoxbox0M.AssertModel(models[1],_testData[26], false);FlatNpgsqlBoxbox0M.AssertModel(models[2],_testData[27], false);FlatNpgsqlBoxbox0M.AssertModel(models[3],_testData[28], false);FlatNpgsqlBoxbox0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelBatchAsync(connection, 98, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[29], false);
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
                var models =  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxbox0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSelectModelBatch(connection, 97, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[5], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[6], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[7], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[8], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[9], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[20],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[21],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[22],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[23],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[24],_testData[29], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[10], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlBoxbox0M.AssertModel(models[0],_testData[11], false);NpgsqlBoxbox0M.AssertModel(models[1],_testData[12], false);NpgsqlBoxbox0M.AssertModel(models[2],_testData[13], false);NpgsqlBoxbox0M.AssertModel(models[3],_testData[14], false);NpgsqlBoxbox0M.AssertModel(models[4],_testData[15], false);NpgsqlBoxbox0M.AssertModel(models[5],_testData[16], false);NpgsqlBoxbox0M.AssertModel(models[6],_testData[17], false);NpgsqlBoxbox0M.AssertModel(models[7],_testData[18], false);NpgsqlBoxbox0M.AssertModel(models[8],_testData[19], false);NpgsqlBoxbox0M.AssertModel(models[9],_testData[20], false);NpgsqlBoxbox0M.AssertModel(models[10],_testData[21], false);NpgsqlBoxbox0M.AssertModel(models[11],_testData[22], false);NpgsqlBoxbox0M.AssertModel(models[12],_testData[23], false);NpgsqlBoxbox0M.AssertModel(models[13],_testData[24], false);NpgsqlBoxbox0M.AssertModel(models[14],_testData[25], false);NpgsqlBoxbox0M.AssertModel(models[15],_testData[26], false);NpgsqlBoxbox0M.AssertModel(models[16],_testData[27], false);NpgsqlBoxbox0M.AssertModel(models[17],_testData[28], false);NpgsqlBoxbox0M.AssertModel(models[18],_testData[29], false);
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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5991067301855811d,right: 0.6490780263592937d,bottom: 0.26520974550895904d,left: 0.2465520235960924d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.995735938111539d,right: 0.7175046913567835d,bottom: 0.8142403501245826d,left: 0.4830440825125796d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9309144044907612d,right: 0.7690785932807772d,bottom: 0.744154899681525d,left: 0.7653996357564284d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8601055422144555d,right: 0.8446923408984083d,bottom: 0.46494633719996137d,left: 0.5709393505054244d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5419102663009313d,right: 0.43866983960646977d,bottom: 0.4060671330530874d,left: 0.03215628633515066d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6591253435027242d,right: 0.7711037491525833d,bottom: 0.4900903618033523d,left: 0.5064684650867646d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9246458922302128d,right: 0.7497564743111736d,bottom: 0.45098196522679623d,left: 0.3698922961602892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5930070206590589d,right: 0.9453186551310319d,bottom: 0.44267423197088784d,left: 0.5711714074396034d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6935094802018925d,right: 0.9429418978936465d,bottom: 0.5707214596967919d,left: 0.8123984005324595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2985971185698324d,right: 0.9139776429124087d,bottom: 0.10617395421613951d,left: 0.6871708153114576d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5149908669338243d,right: 0.19079483728290714d,bottom: 0.352096161745295d,left: 0.07974208068519106d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.12330052793360635d,right: 0.426088281379691d,bottom: 0.09841580622842205d,left: 0.09563335958827146d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7782985901889382d,right: 0.6147868131331454d,bottom: 0.1363769366379306d,left: 0.2520633038755532d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5049396477158045d,right: 0.8241711367220284d,bottom: 0.3273370347467043d,left: 0.2526795283908223d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9558150149565476d,right: 0.9650410612075634d,bottom: 0.6649216900317486d,left: 0.33952462706024955d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5235273838472849d,right: 0.6238391272930756d,bottom: 0.36646017725356206d,left: 0.10082462688550986d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8709051899400304d,right: 0.30668779983732564d,bottom: 0.2574905583839435d,left: 0.11159614904298054d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7227529876432611d,right: 0.42425941572263004d,bottom: 0.4921128488075128d,left: 0.35685386224548954d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.628906049006411d,right: 0.7130750449420841d,bottom: 0.5065217912380716d,left: 0.4814666353072098d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35782523848401815d,right: 0.8232880468316363d,bottom: 0.06972401149439866d,left: 0.15234094432781564d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.840014171529617d,right: 0.37796734669655385d,bottom: 0.34394042716260975d,left: 0.2353330696998881d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24235267641965308d,right: 0.9762836889575847d,bottom: 0.013191956206442312d,left: 0.45558804127942965d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43869987225416973d,right: 0.896917294660753d,bottom: 0.24399889789779317d,left: 0.002270755882138986d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8080152131030099d,right: 0.5648430265241718d,bottom: 0.6353980408800399d,left: 0.14743330299442647d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4281078638362398d,right: 0.49787275988476853d,bottom: 0.12698762574915956d,left: 0.4787089326623216d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.686841187098799d,right: 0.8793220635990836d,bottom: 0.24829613492500902d,left: 0.1702611413929478d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8467282865369256d,right: 0.516852312093768d,bottom: 0.08498350589530002d,left: 0.28585144670336315d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9616521193258389d,right: 0.7409581417857024d,bottom: 0.5289533379410686d,left: 0.23828418258772166d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5404871911001891d,right: 0.7713533677247078d,bottom: 0.1619469093905469d,left: 0.7566918785787764d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9764477664871136d,right: 0.7085009064970706d,bottom: 0.33055204971541485d,left: 0.4433255647231501d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5504756991431883d,right: 0.9508173360895341d,bottom: 0.16571822174644713d,left: 0.46600959874924497d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.031394421658518135d,right: 0.38737776234432686d,bottom: 0.013978350631560055d,left: 0.3032873706483207d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9537049445893991d,right: 0.6160209107918492d,bottom: 0.24607308223429836d,left: 0.38676863906842596d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8402111968779558d,right: 0.9233265565580601d,bottom: 0.818028308689704d,left: 0.31944245262762894d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.784948736921833d,right: 0.7076854616420524d,bottom: 0.5778760161599151d,left: 0.3733120356499231d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7212054159814579d,right: 0.5934083517110748d,bottom: 0.15393320118145526d,left: 0.17544222147147492d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5278613441247613d,right: 0.34754281998492276d,bottom: 0.41969502905799394d,left: 0.10003930529064942d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8444070242336472d,right: 0.7269456781193275d,bottom: 0.39351728963894395d,left: 0.463362698250649d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2110400016672368d,right: 0.6362817072130538d,bottom: 0.1336482774172365d,left: 0.5313717638374196d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9599637003892725d,right: 0.9423428306292135d,bottom: 0.12241921009662138d,left: 0.21661677816357172d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.793984432984126d,right: 0.46212563478323687d,bottom: 0.7700124292567689d,left: 0.28889066152043785d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9079796908481481d,right: 0.9097116077332783d,bottom: 0.7788876421564027d,left: 0.5804413615757914d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5233033715353061d,right: 0.8528263553931218d,bottom: 0.14628463206555342d,left: 0.4614478130957921d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6202665354233738d,right: 0.11982405345706137d,bottom: 0.32071931438412327d,left: 0.06273549414331236d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4972203462988004d,right: 0.504008089093447d,bottom: 0.46534715659170667d,left: 0.2542215786104297d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8050160526422648d,right: 0.46058106419385325d,bottom: 0.5309118843084286d,left: 0.029699512894544422d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7633805712602397d,right: 0.7583505545204149d,bottom: 0.25760987077967723d,left: 0.6760938867063858d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9440674273574534d,right: 0.8992804093729505d,bottom: 0.7237747890380553d,left: 0.5332672436800256d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8222962761742788d,right: 0.9534711346776759d,bottom: 0.43997614118057315d,left: 0.20949371996954436d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6969864430021528d,right: 0.8331410370200311d,bottom: 0.6709898230887048d,left: 0.012003662896161393d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9026570629031707d,right: 0.7628657188279911d,bottom: 0.4556877166175516d,left: 0.42237634593880324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7646436027331175d,right: 0.6001330227652172d,bottom: 0.40503715256417117d,left: 0.5456848801536613d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5878490438161734d,right: 0.4804903564320643d,bottom: 0.4883374086279152d,left: 0.39014625068011677d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6297035383359489d,right: 0.5928091341441799d,bottom: 0.387067808079669d,left: 0.24484778141610464d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35970777262779596d,right: 0.4009352531109912d,bottom: 0.27643130923935655d,left: 0.034536945780194395d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8459179517397567d,right: 0.9303300963135097d,bottom: 0.8109433274540988d,left: 0.8750101740031292d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7967862730879813d,right: 0.2154810297330373d,bottom: 0.5277667290118011d,left: 0.005854853730125842d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1699115785860168d,right: 0.9363232828072431d,bottom: 0.07894401503328785d,left: 0.820350299825655d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7914282902252489d,right: 0.7904099942462681d,bottom: 0.16151540025787292d,left: 0.10254252333869651d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7610636587220228d,right: 0.8099319564967042d,bottom: 0.555524565465952d,left: 0.36696446252647463d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.756138548408596d,right: 0.8689777665077482d,bottom: 0.1829643390343053d,left: 0.864458960180035d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17853811840611844d,right: 0.8052881391566926d,bottom: 0.06656840359494964d,left: 0.5044347736068193d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7604432139151108d,right: 0.9933633220929501d,bottom: 0.5860099365082082d,left: 0.7993940644009924d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6118932836758527d,right: 0.6319144147538205d,bottom: 0.21974350672790466d,left: 0.42578568447407406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8254055499284662d,right: 0.784823889206685d,bottom: 0.4564595628508935d,left: 0.36838398465157984d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8521155265987495d,right: 0.562317568364157d,bottom: 0.4768890113906876d,left: 0.5486985977018443d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4983391707740744d,right: 0.36005564138337764d,bottom: 0.3489426973908003d,left: 0.08267780775082745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7936666948850499d,right: 0.40018390624808897d,bottom: 0.7558017770087292d,left: 0.10544079791377559d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5278828978318081d,right: 0.8882172842137012d,bottom: 0.19014905108558455d,left: 0.6813375036059229d))));

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
                Assert.That((System.Int32)model[0], Is.EqualTo((2)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5991067301855811d,right: 0.6490780263592937d,bottom: 0.26520974550895904d,left: 0.2465520235960924d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.995735938111539d,right: 0.7175046913567835d,bottom: 0.8142403501245826d,left: 0.4830440825125796d))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9309144044907612d,right: 0.7690785932807772d,bottom: 0.744154899681525d,left: 0.7653996357564284d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8601055422144555d,right: 0.8446923408984083d,bottom: 0.46494633719996137d,left: 0.5709393505054244d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5419102663009313d,right: 0.43866983960646977d,bottom: 0.4060671330530874d,left: 0.03215628633515066d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6591253435027242d,right: 0.7711037491525833d,bottom: 0.4900903618033523d,left: 0.5064684650867646d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9246458922302128d,right: 0.7497564743111736d,bottom: 0.45098196522679623d,left: 0.3698922961602892d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5930070206590589d,right: 0.9453186551310319d,bottom: 0.44267423197088784d,left: 0.5711714074396034d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6935094802018925d,right: 0.9429418978936465d,bottom: 0.5707214596967919d,left: 0.8123984005324595d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2985971185698324d,right: 0.9139776429124087d,bottom: 0.10617395421613951d,left: 0.6871708153114576d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5149908669338243d,right: 0.19079483728290714d,bottom: 0.352096161745295d,left: 0.07974208068519106d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.12330052793360635d,right: 0.426088281379691d,bottom: 0.09841580622842205d,left: 0.09563335958827146d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7782985901889382d,right: 0.6147868131331454d,bottom: 0.1363769366379306d,left: 0.2520633038755532d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5049396477158045d,right: 0.8241711367220284d,bottom: 0.3273370347467043d,left: 0.2526795283908223d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9558150149565476d,right: 0.9650410612075634d,bottom: 0.6649216900317486d,left: 0.33952462706024955d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5235273838472849d,right: 0.6238391272930756d,bottom: 0.36646017725356206d,left: 0.10082462688550986d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8709051899400304d,right: 0.30668779983732564d,bottom: 0.2574905583839435d,left: 0.11159614904298054d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7227529876432611d,right: 0.42425941572263004d,bottom: 0.4921128488075128d,left: 0.35685386224548954d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.628906049006411d,right: 0.7130750449420841d,bottom: 0.5065217912380716d,left: 0.4814666353072098d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35782523848401815d,right: 0.8232880468316363d,bottom: 0.06972401149439866d,left: 0.15234094432781564d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.840014171529617d,right: 0.37796734669655385d,bottom: 0.34394042716260975d,left: 0.2353330696998881d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((50)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.24235267641965308d,right: 0.9762836889575847d,bottom: 0.013191956206442312d,left: 0.45558804127942965d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.43869987225416973d,right: 0.896917294660753d,bottom: 0.24399889789779317d,left: 0.002270755882138986d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8080152131030099d,right: 0.5648430265241718d,bottom: 0.6353980408800399d,left: 0.14743330299442647d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4281078638362398d,right: 0.49787275988476853d,bottom: 0.12698762574915956d,left: 0.4787089326623216d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.686841187098799d,right: 0.8793220635990836d,bottom: 0.24829613492500902d,left: 0.1702611413929478d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8467282865369256d,right: 0.516852312093768d,bottom: 0.08498350589530002d,left: 0.28585144670336315d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9616521193258389d,right: 0.7409581417857024d,bottom: 0.5289533379410686d,left: 0.23828418258772166d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5404871911001891d,right: 0.7713533677247078d,bottom: 0.1619469093905469d,left: 0.7566918785787764d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9764477664871136d,right: 0.7085009064970706d,bottom: 0.33055204971541485d,left: 0.4433255647231501d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5504756991431883d,right: 0.9508173360895341d,bottom: 0.16571822174644713d,left: 0.46600959874924497d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.031394421658518135d,right: 0.38737776234432686d,bottom: 0.013978350631560055d,left: 0.3032873706483207d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9537049445893991d,right: 0.6160209107918492d,bottom: 0.24607308223429836d,left: 0.38676863906842596d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8402111968779558d,right: 0.9233265565580601d,bottom: 0.818028308689704d,left: 0.31944245262762894d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.784948736921833d,right: 0.7076854616420524d,bottom: 0.5778760161599151d,left: 0.3733120356499231d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7212054159814579d,right: 0.5934083517110748d,bottom: 0.15393320118145526d,left: 0.17544222147147492d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5278613441247613d,right: 0.34754281998492276d,bottom: 0.41969502905799394d,left: 0.10003930529064942d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8444070242336472d,right: 0.7269456781193275d,bottom: 0.39351728963894395d,left: 0.463362698250649d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2110400016672368d,right: 0.6362817072130538d,bottom: 0.1336482774172365d,left: 0.5313717638374196d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9599637003892725d,right: 0.9423428306292135d,bottom: 0.12241921009662138d,left: 0.21661677816357172d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.793984432984126d,right: 0.46212563478323687d,bottom: 0.7700124292567689d,left: 0.28889066152043785d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9079796908481481d,right: 0.9097116077332783d,bottom: 0.7788876421564027d,left: 0.5804413615757914d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5233033715353061d,right: 0.8528263553931218d,bottom: 0.14628463206555342d,left: 0.4614478130957921d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6202665354233738d,right: 0.11982405345706137d,bottom: 0.32071931438412327d,left: 0.06273549414331236d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((110)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4972203462988004d,right: 0.504008089093447d,bottom: 0.46534715659170667d,left: 0.2542215786104297d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8050160526422648d,right: 0.46058106419385325d,bottom: 0.5309118843084286d,left: 0.029699512894544422d))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7633805712602397d,right: 0.7583505545204149d,bottom: 0.25760987077967723d,left: 0.6760938867063858d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9440674273574534d,right: 0.8992804093729505d,bottom: 0.7237747890380553d,left: 0.5332672436800256d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8222962761742788d,right: 0.9534711346776759d,bottom: 0.43997614118057315d,left: 0.20949371996954436d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6969864430021528d,right: 0.8331410370200311d,bottom: 0.6709898230887048d,left: 0.012003662896161393d))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9026570629031707d,right: 0.7628657188279911d,bottom: 0.4556877166175516d,left: 0.42237634593880324d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7646436027331175d,right: 0.6001330227652172d,bottom: 0.40503715256417117d,left: 0.5456848801536613d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5878490438161734d,right: 0.4804903564320643d,bottom: 0.4883374086279152d,left: 0.39014625068011677d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6297035383359489d,right: 0.5928091341441799d,bottom: 0.387067808079669d,left: 0.24484778141610464d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.35970777262779596d,right: 0.4009352531109912d,bottom: 0.27643130923935655d,left: 0.034536945780194395d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((136)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8459179517397567d,right: 0.9303300963135097d,bottom: 0.8109433274540988d,left: 0.8750101740031292d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((140)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7967862730879813d,right: 0.2154810297330373d,bottom: 0.5277667290118011d,left: 0.005854853730125842d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.1699115785860168d,right: 0.9363232828072431d,bottom: 0.07894401503328785d,left: 0.820350299825655d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7914282902252489d,right: 0.7904099942462681d,bottom: 0.16151540025787292d,left: 0.10254252333869651d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((144)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7610636587220228d,right: 0.8099319564967042d,bottom: 0.555524565465952d,left: 0.36696446252647463d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.756138548408596d,right: 0.8689777665077482d,bottom: 0.1829643390343053d,left: 0.864458960180035d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.17853811840611844d,right: 0.8052881391566926d,bottom: 0.06656840359494964d,left: 0.5044347736068193d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7604432139151108d,right: 0.9933633220929501d,bottom: 0.5860099365082082d,left: 0.7993940644009924d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6118932836758527d,right: 0.6319144147538205d,bottom: 0.21974350672790466d,left: 0.42578568447407406d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8254055499284662d,right: 0.784823889206685d,bottom: 0.4564595628508935d,left: 0.36838398465157984d))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((162)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8521155265987495d,right: 0.562317568364157d,bottom: 0.4768890113906876d,left: 0.5486985977018443d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4983391707740744d,right: 0.36005564138337764d,bottom: 0.3489426973908003d,left: 0.08267780775082745d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7936666948850499d,right: 0.40018390624808897d,bottom: 0.7558017770087292d,left: 0.10544079791377559d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5278828978318081d,right: 0.8882172842137012d,bottom: 0.19014905108558455d,left: 0.6813375036059229d))));

            }
        }

#endregion

#region BinaryImportModelInner

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
        private void ImportModelInnerConfig()
        {
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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxbox0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxSingleTypebox)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxSingleTypebox)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((INpgsqlBoxSingleTypebox)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxSingleTypebox)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxbox0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModelInner(connection).ToList();
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

        [Test, Order(2)]
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

#endregion

    }
}

