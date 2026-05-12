

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
    internal partial interface IDoubleMArraydouble_precisionMMArrayD1
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMMArrayD1 : IDoubleMArraydouble_precisionMMArrayD1
    {


#region TestData

        private readonly Doubledouble_precisionMMArrayD1E1M[] _testData = new Doubledouble_precisionMMArrayD1E1M[]
        {
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.5014914104385886d,
0.3890894351458659d,
0.8648225940332683d,
0.2862852749596373d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.7712185071628577d,
0.7091166227882035d,
0.61870949790171d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Double[4]
{
0.909533691289139d,
0.6403498551915033d,
0.6345828522635575d,
0.1598993354149365d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 4,
    Value = 
new System.Double[3]
{
0.38203461885627d,
0.08426423634715585d,
0.5446774911125865d,
},
    NullableValue = 
new System.Double[4]
{
0.9474932778332706d,
0.29943229556792783d,
0.13033091893855298d,
0.32195083743189334d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Double[4]
{
0.9630265409222697d,
0.45601483157431055d,
0.758097108702767d,
0.9967482411205162d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.9905110609999157d,
0.0042162591252749015d,
0.7170939973640488d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Double[4]
{
0.009457064602589993d,
0.028083699505804804d,
0.27984738458874936d,
0.42498736997683073d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Double[4]
{
0.10557332129832231d,
0.7737394727158149d,
0.6572829733193088d,
0.6588006967512463d,
},
    NullableValue = 
new System.Double[3]
{
0.46483833615931647d,
0.26586883962750696d,
0.8362764814515559d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Double[4]
{
0.19974205360378205d,
0.9119262110284365d,
0.5220562792798734d,
0.9080432120416084d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Double[4]
{
0.4083923395444181d,
0.834973694550757d,
0.3229195194426583d,
0.9985209770944914d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Double[4]
{
0.9491355218063325d,
0.3837849254941438d,
0.7569368814688114d,
0.40375847277012467d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.5544358584098364d,
0.37425933712647974d,
0.9183578569609382d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Double[4]
{
0.36372885263525434d,
0.2063874756682499d,
0.3036574786626529d,
0.5247545578363008d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Double[4]
{
0.7928860478101608d,
0.30136623405488927d,
0.2860015143795712d,
0.17245044336262516d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Double[3]
{
0.9172702499599364d,
0.44509054581349383d,
0.8793410567856984d,
},
    NullableValue = 
new System.Double[4]
{
0.10750678402829805d,
0.22638059406885236d,
0.6817547465667022d,
0.0424288530135678d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Double[3]
{
0.3967553406230159d,
0.03430986754072152d,
0.9321905291735862d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.23487888146799096d,
0.8381610683002778d,
0.6564865191399396d,
0.723095225411396d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Double[3]
{
0.5160605382946746d,
0.050649339048308484d,
0.6964651707448735d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Double[3]
{
0.9998061725853359d,
0.7596905907000511d,
0.3153531938216658d,
},
    NullableValue = 
new System.Double[4]
{
0.4274030764715797d,
0.22390873668819467d,
0.47634978443903975d,
0.41931308613958673d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 63,
    Value = 
new System.Double[4]
{
0.20782065486750034d,
0.19428946174824335d,
0.15372233201992846d,
0.281669009692309d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Double[4]
{
0.1927265996248656d,
0.5289863872980223d,
0.20001140913373916d,
0.6186167069591216d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Double[4]
{
0.6992160066781536d,
0.3578955413013398d,
0.9485553373401739d,
0.2013568149131275d,
},
    NullableValue = 
new System.Double[4]
{
0.3655216872692434d,
0.8172874878476808d,
0.48331434193011724d,
0.3842110275458034d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Double[3]
{
0.4832046175960817d,
0.5818289318532541d,
0.7438460405906882d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Double[3]
{
0.41693796829628094d,
0.38908038973661296d,
0.04751841584471461d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Double[3]
{
0.11335970594883449d,
0.6338216193566185d,
0.20900299509558018d,
},
    NullableValue = 
new System.Double[4]
{
0.49506258718772944d,
0.9253523206579797d,
0.9460386697661254d,
0.8598828942627074d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Double[3]
{
0.7510512703013079d,
0.27733501371963387d,
0.40175002928099113d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Double[3]
{
0.8565042496304498d,
0.20134293135475878d,
0.0012788100700884542d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Double[4]
{
0.1739485614860895d,
0.9021124462641508d,
0.08615477776766467d,
0.9413339466195689d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Double[4]
{
0.6226144326475661d,
0.08325475208982291d,
0.5721723447385093d,
0.20209899840835965d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Double[3]
{
0.6427839254933647d,
0.5806228550066567d,
0.191726515981954d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Double[4]
{
0.33543256702917723d,
0.7163082603657489d,
0.9061124001287504d,
0.5250843398440801d,
},
    NullableValue = 
new System.Double[3]
{
0.47838689464511d,
0.5430673595115538d,
0.5781985947121413d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Double[3]
{
0.600102441195227d,
0.7296792419177357d,
0.2903294167163766d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.20494520245917414d,
0.9338832497098488d,
0.9619234918855782d,
0.03519855419353324d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Double[4]
{
0.16342596049676006d,
0.23358977890851995d,
0.8496152407753158d,
0.9463456889155911d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Double[4]
{
0.2784273618812352d,
0.6394863704708874d,
0.043614234977344624d,
0.8945390102395315d,
},
    NullableValue = 
new System.Double[3]
{
0.7680122004458753d,
0.13057873740239445d,
0.20030190328765785d,
},
},
    NullableValue = 
new System.Double[4]
{
0.08502175821494573d,
0.8522200513840612d,
0.011749511829533765d,
0.790848847674494d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 99,
    Value = 
new System.Double[4]
{
0.586859483661112d,
0.5254982942730464d,
0.9598218278067642d,
0.47013118306092394d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7739580819090504d,
0.9739737363608788d,
0.0305508462662738d,
0.7174207086846315d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Double[4]
{
0.04070389654230666d,
0.6142743490804724d,
0.8943787885915829d,
0.7027714676340925d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Double[4]
{
0.0795080498484092d,
0.5237284145512212d,
0.8054427954372655d,
0.21150505579486d,
},
    NullableValue = 
new System.Double[4]
{
0.9415892362384025d,
0.02656849310862819d,
0.03512809840375253d,
0.37850066989933584d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Double[4]
{
0.7596722304307181d,
0.47716291850741277d,
0.22809729150783997d,
0.5630847767300586d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 120,
    Value = 
new System.Double[4]
{
0.20560355857024992d,
0.8556446508579105d,
0.9829030555064017d,
0.758984238227641d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 50,
    Value = 
new System.Double[4]
{
0.8559694899334908d,
0.2857890339837943d,
0.7650814666597894d,
0.5799862765341129d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.787415373168161d,
0.30352376617959886d,
0.35401507686856026d,
0.8226122411790135d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Double[3]
{
0.48918485415771973d,
0.8108800196591386d,
0.3665911721306443d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Double[3]
{
0.03132893284528515d,
0.6349409328773267d,
0.2770104412945298d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Double[3]
{
0.9197612278036879d,
0.8534125493689932d,
0.7630919546258442d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Double[3]
{
0.3331466133145149d,
0.7776161690556811d,
0.07247152100110943d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.28265627396361126d,
0.9225085991241022d,
0.9082139609105087d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Double[3]
{
0.003481949092141279d,
0.5496231048726827d,
0.8708232537276995d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Double[3]
{
0.3537677421289489d,
0.280027226860983d,
0.86056709548226d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.388287120320856d,
0.1774393802875598d,
0.7802784536849513d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Double[4]
{
0.4425003052443811d,
0.580283633647288d,
0.775659420276476d,
0.5239450473294263d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 154,
    Value = 
new System.Double[3]
{
0.6827810490967343d,
0.3155231673639979d,
0.9911038887508057d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Double[3]
{
0.8691662069047641d,
0.7431934358333395d,
0.9814188209051831d,
},
    NullableValue = 
new System.Double[4]
{
0.020024146982484226d,
0.17118297347667044d,
0.10199903582885561d,
0.2247982637454683d,
},
},
    NullableValue = 
new System.Double[3]
{
0.342403224866473d,
0.7537145322828217d,
0.490293290000025d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Double[4]
{
0.06680768113076552d,
0.23697362988675696d,
0.4871070972291245d,
0.04006777716163312d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Double[4]
{
0.3205613454836562d,
0.9945611492043841d,
0.5492416473196899d,
0.6907993160041392d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Double[4]
{
0.8872832692141097d,
0.10092302064967684d,
0.4861665610914653d,
0.7646341522306511d,
},
    NullableValue = 
new System.Double[3]
{
0.2346358237952555d,
0.07401689572085401d,
0.467198399559255d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Double[4]
{
0.9016094112713684d,
0.1854055314761478d,
0.7882972060212824d,
0.2919994309703867d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4304999827494468d,
0.8905402080091356d,
0.11327572264129848d,
0.26050937799411733d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Double[3]
{
0.24885079295924595d,
0.011960449719031763d,
0.7997297086756852d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Double[3]
{
0.9517261676149811d,
0.008227873434588862d,
0.9292065368176399d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.6363918670861485d,
0.5847900656812691d,
0.3940039304375037d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Double[4]
{
0.6135707184929845d,
0.7009749815981184d,
0.3793864024790218d,
0.7715229995323443d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4766207012249032d,
0.9744338529850528d,
0.7131002734267625d,
0.3256091417242012d,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
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

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.5544358584098364d,
0.37425933712647974d,
0.9183578569609382d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Double[]>();
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
                    ((NpgsqlParameter<System.Double[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483640);
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmmarrayd1e1mi_id
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
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Double[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionmmarrayd1e1mi_id", 
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
                System.Double[] nullable = null;
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.23487888146799096d,
0.8381610683002778d,
0.6564865191399396d,
0.723095225411396d,
}));
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Double[] nullable = null;
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMMArrayD1E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M), typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 165, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 165, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 170, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 160, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 120, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
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
FROM public.doubledouble_precisionmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 154, query1, 170, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 40, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MI),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMMArrayD1E1M),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
FROM public.binary_doubledouble_precisionmmarrayd1e1m m
LEFT JOIN public.binary_doubledouble_precisionmmarrayd1e1mi mi ON mi.id = m.doubledouble_precisionmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
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
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI), typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MI>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA), typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                var models2 = new List<Doubledouble_precisionMMArrayD1E1MIWA>();
                ((IDoubleMArraydouble_precisionMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

