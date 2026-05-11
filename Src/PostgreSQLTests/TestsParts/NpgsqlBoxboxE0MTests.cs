

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

        private readonly NpgsqlBoxboxE0M[] _testData = new NpgsqlBoxboxE0M[]
        {
            new NpgsqlBoxboxE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7694684986417765d,right: 0.9976263862045828d,bottom: 0.6137028020138536d,left: 0.47789941328652474d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8384801341439865d,right: 0.6079014249982286d,bottom: 0.32738498447901887d,left: 0.31558313528125703d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7766343133765468d,right: 0.5757400057158445d,bottom: 0.031085181971916898d,left: 0.2397620163851938d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5941757408664663d,right: 0.8875045108396215d,bottom: 0.3350675363930138d,left: 0.30277568795249643d),
},
            new NpgsqlBoxboxE0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8011561742973362d,right: 0.7367821842034692d,bottom: 0.5370415065983707d,left: 0.4628779177029968d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9801382787016826d,right: 0.29433435988707146d,bottom: 0.49314092200426496d,left: 0.24525937957601818d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5624097378531377d,right: 0.5365085484858385d,bottom: 0.3088926807853348d,left: 0.36043459365375574d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.66264458305089d,right: 0.9481260404287548d,bottom: 0.4516214433872816d,left: 0.6394420968934218d),
},
            new NpgsqlBoxboxE0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6244930072446155d,right: 0.6351198330920482d,bottom: 0.3281756736481882d,left: 0.21058149247572877d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.2038876517157927d,right: 0.8102804683580414d,bottom: 0.017141749474565593d,left: 0.7026870014981038d),
},
            new NpgsqlBoxboxE0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3489747785930607d,right: 0.6050224530001014d,bottom: 0.26947416702039584d,left: 0.42563740235975067d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5539638201940645d,right: 0.5603804547082535d,bottom: 0.30962642234709103d,left: 0.27684136359378975d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7874851190242248d,right: 0.6789563741882901d,bottom: 0.7250050041799818d,left: 0.01788838582848784d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.023153945425785194d,right: 0.6458407126752187d,bottom: 0.006734067111298869d,left: 0.05991262659367502d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5622741544844096d,right: 0.7158310875867279d,bottom: 0.5043683958245025d,left: 0.40131106741672185d),
},
            new NpgsqlBoxboxE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8968559075835026d,right: 0.9720744124272502d,bottom: 0.33444790134963054d,left: 0.005511132825042453d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9628360921711989d,right: 0.9343243093794411d,bottom: 0.4280351040118945d,left: 0.8106405605222403d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.596899079957707d,right: 0.23149048466770905d,bottom: 0.21516780569239924d,left: 0.17595268705015388d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9938128182897686d,right: 0.32138502697505056d,bottom: 0.8707268904057669d,left: 0.009427661058401982d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4792204689684231d,right: 0.24672081837737692d,bottom: 0.18995687015106144d,left: 0.09656428884633328d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6010357555654113d,right: 0.282341902486834d,bottom: 0.252014455490565d,left: 0.04702823054810645d),
},
            new NpgsqlBoxboxE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.578748300101372d,right: 0.274897484634816d,bottom: 0.1746766934983468d,left: 0.20881897340501798d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 49,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.38390793887556784d,right: 0.5367221140439055d,bottom: 0.12269313244748692d,left: 0.42821253582199525d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8728138312723038d,right: 0.4080474845853854d,bottom: 0.06467193675271887d,left: 0.3932009514685584d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7690008744169208d,right: 0.7775200099498227d,bottom: 0.2617715467064272d,left: 0.13933629751050813d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6435051043732422d,right: 0.4645745300384101d,bottom: 0.5107160081728459d,left: 0.42660767721350135d),
},
            new NpgsqlBoxboxE0M
{
    Id = 63,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.800940533888793d,right: 0.8724109099355504d,bottom: 0.07268242811536241d,left: 0.8051624300507408d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8228262309923451d,right: 0.8302029711074128d,bottom: 0.6648624723322719d,left: 0.46970036476982313d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6895043706010903d,right: 0.4945335134828469d,bottom: 0.39778245546534874d,left: 0.21680288904775635d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6064409853288955d,right: 0.48462866781795644d,bottom: 0.48272432247132024d,left: 0.20401667265382728d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9892472232913837d,right: 0.6011345465566819d,bottom: 0.8880192691399689d,left: 0.24984637334615234d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7838885776177816d,right: 0.5146997427097693d,bottom: 0.7503734131012217d,left: 0.3088277562982261d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9068071665586017d,right: 0.41811226679020075d,bottom: 0.8625583035551948d,left: 0.3728418797370432d),
},
            new NpgsqlBoxboxE0M
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46606511704746767d,right: 0.6153657159054744d,bottom: 0.275598020712824d,left: 0.3230554452386407d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9607878297669246d,right: 0.7247384753002795d,bottom: 0.20599225986299308d,left: 0.46281114698015036d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 44,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8570595350316605d,right: 0.9194994138899623d,bottom: 0.541903008009012d,left: 0.0009796696507928804d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8579016094700636d,right: 0.6466853317521049d,bottom: 0.4492681793989014d,left: 0.23927662655863602d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9721023093062138d,right: 0.7476672186529084d,bottom: 0.20561558237953592d,left: 0.27534465566648225d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 97,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.46511290549503115d,right: 0.46525958725884753d,bottom: 0.11247805198953054d,left: 0.3778527023543047d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8275721606143024d,right: 0.7844110868000378d,bottom: 0.5868033103014761d,left: 0.7754955322115333d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7219460612395884d,right: 0.23837505324948782d,bottom: 0.6242960895700073d,left: 0.19394379382066573d),
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.6353406215692609d,right: 0.8181687557604378d,bottom: 0.5270424872686891d,left: 0.4939688957687983d),
},
            new NpgsqlBoxboxE0M
{
    Id = 104,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4623441002945251d,right: 0.8530185376629661d,bottom: 0.09916360835890381d,left: 0.2881166672997173d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6895289980759794d,right: 0.945469271264189d,bottom: 0.06865835095521289d,left: 0.015588439379549901d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.23908749645123917d,right: 0.6594051826128176d,bottom: 0.12481245490391002d,left: 0.6369388548745853d),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6137980116583392d,right: 0.26717010593619117d,bottom: 0.29187670354384543d,left: 0.1970304540077905d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8778705564910944d,right: 0.26795992651107536d,bottom: 0.2723035588564514d,left: 0.16028308049202755d),
},
            new NpgsqlBoxboxE0M
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6921854215609888d,right: 0.6306915322986988d,bottom: 0.32552616468153983d,left: 0.033100303571367395d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7413824644709064d,right: 0.9999018316672863d,bottom: 0.11283268929508905d,left: 0.9220393419217434d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.5988755707214288d,right: 0.5533112191584862d,bottom: 0.3721079949267204d,left: 0.18346804589354793d),
},
            new NpgsqlBoxboxE0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.3692754854558351d,right: 0.12304943978798843d,bottom: 0.23365911051655852d,left: 0.1108599758516714d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.12046363842268903d,right: 0.9709953344960098d,bottom: 0.08045876166065624d,left: 0.3679852592590457d),
},
            new NpgsqlBoxboxE0M
{
    Id = 124,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4240196973710083d,right: 0.3648636383050463d,bottom: 0.30870770194028707d,left: 0.2405414917111146d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.4491074297640484d,right: 0.7859813768575918d,bottom: 0.3854285163319525d,left: 0.07626311521764095d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7406435925794013d,right: 0.35051059813984453d,bottom: 0.6380592486587449d,left: 0.1739538719477719d),
},
            new NpgsqlBoxboxE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9997610931848347d,right: 0.5515787731498516d,bottom: 0.9342405451817931d,left: 0.4905711880617265d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8431446188243151d,right: 0.7605960231122032d,bottom: 0.8319832459460477d,left: 0.4210012249700861d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.583826037350197d,right: 0.4802358792269501d,bottom: 0.025543974784475454d,left: 0.2657368746348362d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.13640785362076768d,right: 0.6467269231943169d,bottom: 0.02844892050607717d,left: 0.11975814923199724d),
},
            new NpgsqlBoxboxE0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9295510104800628d,right: 0.7073584586755471d,bottom: 0.24740306577419913d,left: 0.3777553797226332d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2800832057564403d,right: 0.8863446531571897d,bottom: 0.1648626105449581d,left: 0.5372316897023842d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.2003733401507788d,right: 0.9867566097059928d,bottom: 0.09084081425656931d,left: 0.8498380533006284d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.8476780062616599d,right: 0.5684791844374983d,bottom: 0.7926415035669979d,left: 0.34351323490762575d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.9448579102412886d,right: 0.9590158940898276d,bottom: 0.7411481711975609d,left: 0.7640060493029341d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.8601035974138893d,right: 0.870370507168d,bottom: 0.40120244040983777d,left: 0.056295642149786884d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.7617459236399542d,right: 0.34162715262112264d,bottom: 0.10410222990294438d,left: 0.1525878807232135d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.9307006200555039d,right: 0.27807901949024516d,bottom: 0.1446989589793084d,left: 0.23705800522229425d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.5571492907774924d,right: 0.5419453070798541d,bottom: 0.34078892511232617d,left: 0.5121846251165977d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 164,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6174894514559077d,right: 0.49905774202746156d,bottom: 0.146624877261176d,left: 0.02348970484386459d),
    ModelInner = new NpgsqlBoxboxE0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6972254559325995d,right: 0.2066025463363541d,bottom: 0.611067835145638d,left: 0.18969203614295016d),
    NullableValue = new NpgsqlTypes.NpgsqlBox(top: 0.7072085959364312d,right: 0.711576190289449d,bottom: 0.27870309326415543d,left: 0.6288360585526276d),
},
    NullableValue = null,
},
            new NpgsqlBoxboxE0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlBox(top: 0.6753263304863101d,right: 0.8676054721190677d,bottom: 0.22370025533338722d,left: 0.3337320013712607d),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0mi(
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
INSERT INTO public.npgsqlboxboxe0mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
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
INSERT INTO public.npgsqlboxboxe0mi(
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
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.2038876517157927d,right: 0.8102804683580414d,bottom: 0.017141749474565593d,left: 0.7026870014981038d)));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.5622741544844096d,right: 0.7158310875867279d,bottom: 0.5043683958245025d,left: 0.40131106741672185d)));
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
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
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
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlBox(top: 0.6010357555654113d,right: 0.282341902486834d,bottom: 0.252014455490565d,left: 0.04702823054810645d)));
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
                List<NpgsqlBoxboxE0M> models = null;

                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxSingleTypebox)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxE0M> models = null;

                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxSingleTypebox)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxe0m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlboxboxe0mi_id
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
                parametrName: "npgsqlboxboxe0mi_id", 
                methodParametrName: "npgsqlboxboxe0mi_id", 
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
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 7;
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[34], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M), typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                await((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 159, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 159, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxE0M>();
                var models2 = new List<FlatNpgsqlBoxboxE0M>();
                ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 155, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxE0M)],
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                await ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 109, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTDynQuerySelectModelBatch(connection, 120, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxE0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
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
FROM public.npgsqlboxboxe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxE0M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxE0M>();
                 ((INpgsqlBoxSingleTypebox)this).DbConnectionDynQuerySelectModelBatch(connection, 109, query1, 97, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatchAsync(connection, 105, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[34], false);
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
                    NpgsqlBoxboxE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxSingleTypebox)this).DbConnectionSTSelectModelBatch(connection, 141, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlBoxboxE0M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxE0M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxE0M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxE0M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxE0M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxE0M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxE0M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxE0M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxE0M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxE0M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxE0M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxE0M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxE0M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxE0M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxE0M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxE0M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxE0M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxE0M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxE0M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxE0M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxE0M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxE0M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxE0M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxE0M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxE0M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxE0M.AssertModel(models[25],_testData[29], false);
                        NpgsqlBoxboxE0M.AssertModel(models[26],_testData[30], false);
                        NpgsqlBoxboxE0M.AssertModel(models[27],_testData[31], false);
                        NpgsqlBoxboxE0M.AssertModel(models[28],_testData[32], false);
                        NpgsqlBoxboxE0M.AssertModel(models[29],_testData[33], false);
                        NpgsqlBoxboxE0M.AssertModel(models[30],_testData[34], false);
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
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[5], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[6], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[7], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[8], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[9], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[10], false);
                NpgsqlBoxboxE0M.AssertModel(models[6],_testData[11], false);
                NpgsqlBoxboxE0M.AssertModel(models[7],_testData[12], false);
                NpgsqlBoxboxE0M.AssertModel(models[8],_testData[13], false);
                NpgsqlBoxboxE0M.AssertModel(models[9],_testData[14], false);
                NpgsqlBoxboxE0M.AssertModel(models[10],_testData[15], false);
                NpgsqlBoxboxE0M.AssertModel(models[11],_testData[16], false);
                NpgsqlBoxboxE0M.AssertModel(models[12],_testData[17], false);
                NpgsqlBoxboxE0M.AssertModel(models[13],_testData[18], false);
                NpgsqlBoxboxE0M.AssertModel(models[14],_testData[19], false);
                NpgsqlBoxboxE0M.AssertModel(models[15],_testData[20], false);
                NpgsqlBoxboxE0M.AssertModel(models[16],_testData[21], false);
                NpgsqlBoxboxE0M.AssertModel(models[17],_testData[22], false);
                NpgsqlBoxboxE0M.AssertModel(models[18],_testData[23], false);
                NpgsqlBoxboxE0M.AssertModel(models[19],_testData[24], false);
                NpgsqlBoxboxE0M.AssertModel(models[20],_testData[25], false);
                NpgsqlBoxboxE0M.AssertModel(models[21],_testData[26], false);
                NpgsqlBoxboxE0M.AssertModel(models[22],_testData[27], false);
                NpgsqlBoxboxE0M.AssertModel(models[23],_testData[28], false);
                NpgsqlBoxboxE0M.AssertModel(models[24],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[25],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[26],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[27],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[28],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxSingleTypebox)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxSingleTypebox)this).SetDbConnectionSelectModelParametrs(cmd, 141);
                var models =  ((INpgsqlBoxSingleTypebox)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlBoxboxE0M.AssertModel(models[0],_testData[29], false);
                NpgsqlBoxboxE0M.AssertModel(models[1],_testData[30], false);
                NpgsqlBoxboxE0M.AssertModel(models[2],_testData[31], false);
                NpgsqlBoxboxE0M.AssertModel(models[3],_testData[32], false);
                NpgsqlBoxboxE0M.AssertModel(models[4],_testData[33], false);
                NpgsqlBoxboxE0M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlboxboxe0m m
LEFT JOIN public.npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7694684986417765d,right: 0.9976263862045828d,bottom: 0.6137028020138536d,left: 0.47789941328652474d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8384801341439865d,right: 0.6079014249982286d,bottom: 0.32738498447901887d,left: 0.31558313528125703d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7766343133765468d,right: 0.5757400057158445d,bottom: 0.031085181971916898d,left: 0.2397620163851938d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5941757408664663d,right: 0.8875045108396215d,bottom: 0.3350675363930138d,left: 0.30277568795249643d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8011561742973362d,right: 0.7367821842034692d,bottom: 0.5370415065983707d,left: 0.4628779177029968d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9801382787016826d,right: 0.29433435988707146d,bottom: 0.49314092200426496d,left: 0.24525937957601818d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5624097378531377d,right: 0.5365085484858385d,bottom: 0.3088926807853348d,left: 0.36043459365375574d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.66264458305089d,right: 0.9481260404287548d,bottom: 0.4516214433872816d,left: 0.6394420968934218d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6244930072446155d,right: 0.6351198330920482d,bottom: 0.3281756736481882d,left: 0.21058149247572877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2038876517157927d,right: 0.8102804683580414d,bottom: 0.017141749474565593d,left: 0.7026870014981038d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3489747785930607d,right: 0.6050224530001014d,bottom: 0.26947416702039584d,left: 0.42563740235975067d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5539638201940645d,right: 0.5603804547082535d,bottom: 0.30962642234709103d,left: 0.27684136359378975d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7874851190242248d,right: 0.6789563741882901d,bottom: 0.7250050041799818d,left: 0.01788838582848784d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.023153945425785194d,right: 0.6458407126752187d,bottom: 0.006734067111298869d,left: 0.05991262659367502d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5622741544844096d,right: 0.7158310875867279d,bottom: 0.5043683958245025d,left: 0.40131106741672185d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8968559075835026d,right: 0.9720744124272502d,bottom: 0.33444790134963054d,left: 0.005511132825042453d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9628360921711989d,right: 0.9343243093794411d,bottom: 0.4280351040118945d,left: 0.8106405605222403d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.596899079957707d,right: 0.23149048466770905d,bottom: 0.21516780569239924d,left: 0.17595268705015388d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9938128182897686d,right: 0.32138502697505056d,bottom: 0.8707268904057669d,left: 0.009427661058401982d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4792204689684231d,right: 0.24672081837737692d,bottom: 0.18995687015106144d,left: 0.09656428884633328d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6010357555654113d,right: 0.282341902486834d,bottom: 0.252014455490565d,left: 0.04702823054810645d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.578748300101372d,right: 0.274897484634816d,bottom: 0.1746766934983468d,left: 0.20881897340501798d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38390793887556784d,right: 0.5367221140439055d,bottom: 0.12269313244748692d,left: 0.42821253582199525d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8728138312723038d,right: 0.4080474845853854d,bottom: 0.06467193675271887d,left: 0.3932009514685584d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7690008744169208d,right: 0.7775200099498227d,bottom: 0.2617715467064272d,left: 0.13933629751050813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6435051043732422d,right: 0.4645745300384101d,bottom: 0.5107160081728459d,left: 0.42660767721350135d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.800940533888793d,right: 0.8724109099355504d,bottom: 0.07268242811536241d,left: 0.8051624300507408d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8228262309923451d,right: 0.8302029711074128d,bottom: 0.6648624723322719d,left: 0.46970036476982313d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6895043706010903d,right: 0.4945335134828469d,bottom: 0.39778245546534874d,left: 0.21680288904775635d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6064409853288955d,right: 0.48462866781795644d,bottom: 0.48272432247132024d,left: 0.20401667265382728d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9892472232913837d,right: 0.6011345465566819d,bottom: 0.8880192691399689d,left: 0.24984637334615234d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7838885776177816d,right: 0.5146997427097693d,bottom: 0.7503734131012217d,left: 0.3088277562982261d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9068071665586017d,right: 0.41811226679020075d,bottom: 0.8625583035551948d,left: 0.3728418797370432d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46606511704746767d,right: 0.6153657159054744d,bottom: 0.275598020712824d,left: 0.3230554452386407d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9607878297669246d,right: 0.7247384753002795d,bottom: 0.20599225986299308d,left: 0.46281114698015036d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8570595350316605d,right: 0.9194994138899623d,bottom: 0.541903008009012d,left: 0.0009796696507928804d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8579016094700636d,right: 0.6466853317521049d,bottom: 0.4492681793989014d,left: 0.23927662655863602d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9721023093062138d,right: 0.7476672186529084d,bottom: 0.20561558237953592d,left: 0.27534465566648225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46511290549503115d,right: 0.46525958725884753d,bottom: 0.11247805198953054d,left: 0.3778527023543047d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8275721606143024d,right: 0.7844110868000378d,bottom: 0.5868033103014761d,left: 0.7754955322115333d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7219460612395884d,right: 0.23837505324948782d,bottom: 0.6242960895700073d,left: 0.19394379382066573d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6353406215692609d,right: 0.8181687557604378d,bottom: 0.5270424872686891d,left: 0.4939688957687983d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4623441002945251d,right: 0.8530185376629661d,bottom: 0.09916360835890381d,left: 0.2881166672997173d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6895289980759794d,right: 0.945469271264189d,bottom: 0.06865835095521289d,left: 0.015588439379549901d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23908749645123917d,right: 0.6594051826128176d,bottom: 0.12481245490391002d,left: 0.6369388548745853d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6137980116583392d,right: 0.26717010593619117d,bottom: 0.29187670354384543d,left: 0.1970304540077905d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8778705564910944d,right: 0.26795992651107536d,bottom: 0.2723035588564514d,left: 0.16028308049202755d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6921854215609888d,right: 0.6306915322986988d,bottom: 0.32552616468153983d,left: 0.033100303571367395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7413824644709064d,right: 0.9999018316672863d,bottom: 0.11283268929508905d,left: 0.9220393419217434d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5988755707214288d,right: 0.5533112191584862d,bottom: 0.3721079949267204d,left: 0.18346804589354793d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3692754854558351d,right: 0.12304943978798843d,bottom: 0.23365911051655852d,left: 0.1108599758516714d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.12046363842268903d,right: 0.9709953344960098d,bottom: 0.08045876166065624d,left: 0.3679852592590457d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4240196973710083d,right: 0.3648636383050463d,bottom: 0.30870770194028707d,left: 0.2405414917111146d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4491074297640484d,right: 0.7859813768575918d,bottom: 0.3854285163319525d,left: 0.07626311521764095d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7406435925794013d,right: 0.35051059813984453d,bottom: 0.6380592486587449d,left: 0.1739538719477719d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9997610931848347d,right: 0.5515787731498516d,bottom: 0.9342405451817931d,left: 0.4905711880617265d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8431446188243151d,right: 0.7605960231122032d,bottom: 0.8319832459460477d,left: 0.4210012249700861d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.583826037350197d,right: 0.4802358792269501d,bottom: 0.025543974784475454d,left: 0.2657368746348362d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13640785362076768d,right: 0.6467269231943169d,bottom: 0.02844892050607717d,left: 0.11975814923199724d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9295510104800628d,right: 0.7073584586755471d,bottom: 0.24740306577419913d,left: 0.3777553797226332d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2800832057564403d,right: 0.8863446531571897d,bottom: 0.1648626105449581d,left: 0.5372316897023842d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2003733401507788d,right: 0.9867566097059928d,bottom: 0.09084081425656931d,left: 0.8498380533006284d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8476780062616599d,right: 0.5684791844374983d,bottom: 0.7926415035669979d,left: 0.34351323490762575d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9448579102412886d,right: 0.9590158940898276d,bottom: 0.7411481711975609d,left: 0.7640060493029341d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8601035974138893d,right: 0.870370507168d,bottom: 0.40120244040983777d,left: 0.056295642149786884d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7617459236399542d,right: 0.34162715262112264d,bottom: 0.10410222990294438d,left: 0.1525878807232135d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9307006200555039d,right: 0.27807901949024516d,bottom: 0.1446989589793084d,left: 0.23705800522229425d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5571492907774924d,right: 0.5419453070798541d,bottom: 0.34078892511232617d,left: 0.5121846251165977d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6174894514559077d,right: 0.49905774202746156d,bottom: 0.146624877261176d,left: 0.02348970484386459d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6972254559325995d,right: 0.2066025463363541d,bottom: 0.611067835145638d,left: 0.18969203614295016d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7072085959364312d,right: 0.711576190289449d,bottom: 0.27870309326415543d,left: 0.6288360585526276d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6753263304863101d,right: 0.8676054721190677d,bottom: 0.22370025533338722d,left: 0.3337320013712607d))));//Value

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
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7694684986417765d,right: 0.9976263862045828d,bottom: 0.6137028020138536d,left: 0.47789941328652474d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((9)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8384801341439865d,right: 0.6079014249982286d,bottom: 0.32738498447901887d,left: 0.31558313528125703d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7766343133765468d,right: 0.5757400057158445d,bottom: 0.031085181971916898d,left: 0.2397620163851938d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5941757408664663d,right: 0.8875045108396215d,bottom: 0.3350675363930138d,left: 0.30277568795249643d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8011561742973362d,right: 0.7367821842034692d,bottom: 0.5370415065983707d,left: 0.4628779177029968d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9801382787016826d,right: 0.29433435988707146d,bottom: 0.49314092200426496d,left: 0.24525937957601818d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((16)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5624097378531377d,right: 0.5365085484858385d,bottom: 0.3088926807853348d,left: 0.36043459365375574d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.66264458305089d,right: 0.9481260404287548d,bottom: 0.4516214433872816d,left: 0.6394420968934218d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6244930072446155d,right: 0.6351198330920482d,bottom: 0.3281756736481882d,left: 0.21058149247572877d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2038876517157927d,right: 0.8102804683580414d,bottom: 0.017141749474565593d,left: 0.7026870014981038d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3489747785930607d,right: 0.6050224530001014d,bottom: 0.26947416702039584d,left: 0.42563740235975067d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((20)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5539638201940645d,right: 0.5603804547082535d,bottom: 0.30962642234709103d,left: 0.27684136359378975d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7874851190242248d,right: 0.6789563741882901d,bottom: 0.7250050041799818d,left: 0.01788838582848784d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.023153945425785194d,right: 0.6458407126752187d,bottom: 0.006734067111298869d,left: 0.05991262659367502d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5622741544844096d,right: 0.7158310875867279d,bottom: 0.5043683958245025d,left: 0.40131106741672185d))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8968559075835026d,right: 0.9720744124272502d,bottom: 0.33444790134963054d,left: 0.005511132825042453d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9628360921711989d,right: 0.9343243093794411d,bottom: 0.4280351040118945d,left: 0.8106405605222403d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.596899079957707d,right: 0.23149048466770905d,bottom: 0.21516780569239924d,left: 0.17595268705015388d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9938128182897686d,right: 0.32138502697505056d,bottom: 0.8707268904057669d,left: 0.009427661058401982d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4792204689684231d,right: 0.24672081837737692d,bottom: 0.18995687015106144d,left: 0.09656428884633328d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6010357555654113d,right: 0.282341902486834d,bottom: 0.252014455490565d,left: 0.04702823054810645d))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.578748300101372d,right: 0.274897484634816d,bottom: 0.1746766934983468d,left: 0.20881897340501798d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((49)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.38390793887556784d,right: 0.5367221140439055d,bottom: 0.12269313244748692d,left: 0.42821253582199525d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8728138312723038d,right: 0.4080474845853854d,bottom: 0.06467193675271887d,left: 0.3932009514685584d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7690008744169208d,right: 0.7775200099498227d,bottom: 0.2617715467064272d,left: 0.13933629751050813d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6435051043732422d,right: 0.4645745300384101d,bottom: 0.5107160081728459d,left: 0.42660767721350135d))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((63)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.800940533888793d,right: 0.8724109099355504d,bottom: 0.07268242811536241d,left: 0.8051624300507408d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8228262309923451d,right: 0.8302029711074128d,bottom: 0.6648624723322719d,left: 0.46970036476982313d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6895043706010903d,right: 0.4945335134828469d,bottom: 0.39778245546534874d,left: 0.21680288904775635d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6064409853288955d,right: 0.48462866781795644d,bottom: 0.48272432247132024d,left: 0.20401667265382728d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((36)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9892472232913837d,right: 0.6011345465566819d,bottom: 0.8880192691399689d,left: 0.24984637334615234d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7838885776177816d,right: 0.5146997427097693d,bottom: 0.7503734131012217d,left: 0.3088277562982261d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9068071665586017d,right: 0.41811226679020075d,bottom: 0.8625583035551948d,left: 0.3728418797370432d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((78)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46606511704746767d,right: 0.6153657159054744d,bottom: 0.275598020712824d,left: 0.3230554452386407d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9607878297669246d,right: 0.7247384753002795d,bottom: 0.20599225986299308d,left: 0.46281114698015036d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((44)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8570595350316605d,right: 0.9194994138899623d,bottom: 0.541903008009012d,left: 0.0009796696507928804d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8579016094700636d,right: 0.6466853317521049d,bottom: 0.4492681793989014d,left: 0.23927662655863602d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9721023093062138d,right: 0.7476672186529084d,bottom: 0.20561558237953592d,left: 0.27534465566648225d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((97)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.46511290549503115d,right: 0.46525958725884753d,bottom: 0.11247805198953054d,left: 0.3778527023543047d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8275721606143024d,right: 0.7844110868000378d,bottom: 0.5868033103014761d,left: 0.7754955322115333d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7219460612395884d,right: 0.23837505324948782d,bottom: 0.6242960895700073d,left: 0.19394379382066573d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6353406215692609d,right: 0.8181687557604378d,bottom: 0.5270424872686891d,left: 0.4939688957687983d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((104)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4623441002945251d,right: 0.8530185376629661d,bottom: 0.09916360835890381d,left: 0.2881166672997173d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6895289980759794d,right: 0.945469271264189d,bottom: 0.06865835095521289d,left: 0.015588439379549901d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.23908749645123917d,right: 0.6594051826128176d,bottom: 0.12481245490391002d,left: 0.6369388548745853d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6137980116583392d,right: 0.26717010593619117d,bottom: 0.29187670354384543d,left: 0.1970304540077905d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8778705564910944d,right: 0.26795992651107536d,bottom: 0.2723035588564514d,left: 0.16028308049202755d))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((113)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6921854215609888d,right: 0.6306915322986988d,bottom: 0.32552616468153983d,left: 0.033100303571367395d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7413824644709064d,right: 0.9999018316672863d,bottom: 0.11283268929508905d,left: 0.9220393419217434d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5988755707214288d,right: 0.5533112191584862d,bottom: 0.3721079949267204d,left: 0.18346804589354793d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.3692754854558351d,right: 0.12304943978798843d,bottom: 0.23365911051655852d,left: 0.1108599758516714d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.12046363842268903d,right: 0.9709953344960098d,bottom: 0.08045876166065624d,left: 0.3679852592590457d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((124)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4240196973710083d,right: 0.3648636383050463d,bottom: 0.30870770194028707d,left: 0.2405414917111146d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.4491074297640484d,right: 0.7859813768575918d,bottom: 0.3854285163319525d,left: 0.07626311521764095d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7406435925794013d,right: 0.35051059813984453d,bottom: 0.6380592486587449d,left: 0.1739538719477719d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9997610931848347d,right: 0.5515787731498516d,bottom: 0.9342405451817931d,left: 0.4905711880617265d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8431446188243151d,right: 0.7605960231122032d,bottom: 0.8319832459460477d,left: 0.4210012249700861d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((64)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.583826037350197d,right: 0.4802358792269501d,bottom: 0.025543974784475454d,left: 0.2657368746348362d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.13640785362076768d,right: 0.6467269231943169d,bottom: 0.02844892050607717d,left: 0.11975814923199724d))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9295510104800628d,right: 0.7073584586755471d,bottom: 0.24740306577419913d,left: 0.3777553797226332d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2800832057564403d,right: 0.8863446531571897d,bottom: 0.1648626105449581d,left: 0.5372316897023842d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.2003733401507788d,right: 0.9867566097059928d,bottom: 0.09084081425656931d,left: 0.8498380533006284d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8476780062616599d,right: 0.5684791844374983d,bottom: 0.7926415035669979d,left: 0.34351323490762575d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9448579102412886d,right: 0.9590158940898276d,bottom: 0.7411481711975609d,left: 0.7640060493029341d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.8601035974138893d,right: 0.870370507168d,bottom: 0.40120244040983777d,left: 0.056295642149786884d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((69)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7617459236399542d,right: 0.34162715262112264d,bottom: 0.10410222990294438d,left: 0.1525878807232135d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.9307006200555039d,right: 0.27807901949024516d,bottom: 0.1446989589793084d,left: 0.23705800522229425d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.5571492907774924d,right: 0.5419453070798541d,bottom: 0.34078892511232617d,left: 0.5121846251165977d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((164)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6174894514559077d,right: 0.49905774202746156d,bottom: 0.146624877261176d,left: 0.02348970484386459d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6972254559325995d,right: 0.2066025463363541d,bottom: 0.611067835145638d,left: 0.18969203614295016d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlBox?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.7072085959364312d,right: 0.711576190289449d,bottom: 0.27870309326415543d,left: 0.6288360585526276d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlBox)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlBox(top: 0.6753263304863101d,right: 0.8676054721190677d,bottom: 0.22370025533338722d,left: 0.3337320013712607d))));//Value

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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxSingleTypebox)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
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
COPY public.binary_npgsqlboxboxe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MI),
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
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
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
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MI>(2);
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
                    NpgsqlBoxboxE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
COPY public.binary_npgsqlboxboxe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxE0MIWA),
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxE0MIWA
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
                    NpgsqlBoxboxE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxE0M),
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
FROM public.binary_npgsqlboxboxe0m m
LEFT JOIN public.binary_npgsqlboxboxe0mi mi ON mi.id = m.npgsqlboxboxe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
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
                var importCollection = new List<NpgsqlBoxboxE0M>();
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
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxE0M>();
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
                    NpgsqlBoxboxE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxSingleTypebox)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(3)
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
                var models =  ((INpgsqlBoxSingleTypebox)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
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
                    NpgsqlBoxboxE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_npgsqlboxboxe0mi
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI), typeof(NpgsqlBoxboxE0MI)],
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                await ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MI>();
                var models2 = new List<NpgsqlBoxboxE0MI>();
                ((INpgsqlBoxSingleTypebox)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MI)],
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
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxboxE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA), typeof(NpgsqlBoxboxE0MIWA)],
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                await ((INpgsqlBoxSingleTypebox)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxE0MIWA>();
                var models2 = new List<NpgsqlBoxboxE0MIWA>();
                ((INpgsqlBoxSingleTypebox)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxE0MIWA)],
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
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
                    NpgsqlBoxboxE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

