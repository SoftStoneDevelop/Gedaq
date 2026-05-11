

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
    internal partial interface IDoubleMArraydouble_precisionMArrayD1
    {
    }
    
    internal partial class DoubleMArraydouble_precisionMArrayD1 : IDoubleMArraydouble_precisionMArrayD1
    {


#region TestData

        private readonly Doubledouble_precisionMArrayD1E1M[] _testData = new Doubledouble_precisionMArrayD1E1M[]
        {
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Double[3]
{
0.23932384011875651d,
0.5104333058777079d,
0.9250607471070625d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.09584999351775891d,
0.22971633774190914d,
0.3409675010828227d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Double[4]
{
0.06781529571046852d,
0.8479289413637274d,
0.9627321620013326d,
0.827017763666001d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 3,
    Value = 
new System.Double[3]
{
0.059099289158214496d,
0.009767674896599687d,
0.7071988059534707d,
},
    NullableValue = 
new System.Double[3]
{
0.8483958551844258d,
0.2032389224184311d,
0.32259286844454393d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Double[3]
{
0.3697838823852605d,
0.12478123112983552d,
0.3175528704803203d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 26,
    Value = 
new System.Double[4]
{
0.5561508707309176d,
0.9217595479119017d,
0.6467133817725658d,
0.3526386598248271d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 11,
    Value = 
new System.Double[4]
{
0.6315216617068349d,
0.0848202595659917d,
0.46528496090201166d,
0.014779102967705793d,
},
    NullableValue = 
new System.Double[4]
{
0.4396642432024357d,
0.7808140915589389d,
0.016952826673258703d,
0.8485363429806883d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Double[3]
{
0.12681200046459884d,
0.3394618056827384d,
0.34740082657414084d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Double[3]
{
0.614751547431831d,
0.8600332614266146d,
0.8761749267486009d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 13,
    Value = 
new System.Double[3]
{
0.9379330065320487d,
0.929300208233044d,
0.6697385415513132d,
},
    NullableValue = 
new System.Double[3]
{
0.44957777394351794d,
0.11347590983731382d,
0.028749557552852356d,
},
},
    NullableValue = 
new System.Double[3]
{
0.059306793916878986d,
0.8184842215269297d,
0.9705418556123506d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Double[3]
{
0.7551384969159817d,
0.7977756345291634d,
0.7108893118353412d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.6522119186702408d,
0.5124418301394801d,
0.5065342695261354d,
0.9483784750668525d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Double[4]
{
0.024523514951331205d,
0.583037727837176d,
0.4368197936991296d,
0.1351759666378768d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 22,
    Value = 
new System.Double[4]
{
0.452717776163566d,
0.3063867325786934d,
0.2110387370422595d,
0.973987458835071d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.7779852563043494d,
0.5093508757257367d,
0.8285197546806825d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Double[4]
{
0.5608218236306166d,
0.3304964773082608d,
0.8490086021018041d,
0.9081046252868464d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Double[4]
{
0.6150865258244946d,
0.04217574971924021d,
0.9681332516338972d,
0.5243911007799282d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 31,
    Value = 
new System.Double[4]
{
0.56824913638112d,
0.11238786366972842d,
0.5491207166516996d,
0.8651466359666865d,
},
    NullableValue = 
new System.Double[3]
{
0.6390133804972082d,
0.7660848494801755d,
0.3546754156815025d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Double[3]
{
0.15163030602555227d,
0.14974140997742857d,
0.10171695040747619d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Double[3]
{
0.14471162829095785d,
0.1020793106211656d,
0.3077877624766503d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.12252856800995016d,
0.7112892398507492d,
0.533136107864879d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.22541242782075033d,
0.425926393854415d,
0.9596513110408378d,
0.17995466562308338d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Double[4]
{
0.7587436543554776d,
0.8745459414288859d,
0.7939174338915245d,
0.27950850948992223d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Double[4]
{
0.7540148444629654d,
0.25570932961351367d,
0.3093661252594614d,
0.5155950969133967d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 37,
    Value = 
new System.Double[4]
{
0.9576103447619455d,
0.15629672310421272d,
0.6722774550277593d,
0.3089839160404566d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 82,
    Value = 
new System.Double[4]
{
0.2596518482775554d,
0.7495657952625258d,
0.49642300222926616d,
0.9365742779526327d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.35589783363326943d,
0.7898012290998787d,
0.7705089448285445d,
0.9192527508899818d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Double[4]
{
0.3850963858693395d,
0.36430511360044415d,
0.04779054149923834d,
0.9044958883398956d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 46,
    Value = 
new System.Double[4]
{
0.23188220140999172d,
0.3497119972795494d,
0.6906821556826586d,
0.9318147774097963d,
},
    NullableValue = 
new System.Double[3]
{
0.4908629391195459d,
0.14260806482739463d,
0.5122948091881967d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Double[3]
{
0.20709877591716574d,
0.5535041277927091d,
0.3859537525175061d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Double[4]
{
0.3505611628220229d,
0.3007768737765306d,
0.6471027281914699d,
0.8475889747399541d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 53,
    Value = 
new System.Double[4]
{
0.196163806549304d,
0.8144494200792719d,
0.5518217874997791d,
0.36868394454181985d,
},
    NullableValue = 
new System.Double[4]
{
0.6095280756268695d,
0.6706491875663994d,
0.9874592824835953d,
0.21053124520302924d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Double[4]
{
0.4525427271369392d,
0.7630694256650447d,
0.09737219448055223d,
0.5852525621224748d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 105,
    Value = 
new System.Double[4]
{
0.9811930777504377d,
0.6778440285610058d,
0.2317515971263816d,
0.15818838239413657d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 59,
    Value = 
new System.Double[3]
{
0.44829911838930503d,
0.22799749431939698d,
0.19953425873594843d,
},
    NullableValue = 
new System.Double[3]
{
0.9294842539691238d,
0.8816681590980581d,
0.8477647484530921d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8298124097204251d,
0.23602699918192904d,
0.13589034440028958d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Double[4]
{
0.4043738561899237d,
0.3523746330290285d,
0.6088217389794289d,
0.32339637884507777d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.47920549524844913d,
0.4882731717795795d,
0.5268141965832933d,
0.8445814823536176d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Double[3]
{
0.34607101219017045d,
0.3117822794805265d,
0.3183457848651473d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 60,
    Value = 
new System.Double[3]
{
0.7759293720988115d,
0.38208487161842963d,
0.6781920257535611d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.7176574783780582d,
0.27227209150724485d,
0.7183029891464389d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Double[3]
{
0.15405574211624562d,
0.8089662887493516d,
0.015627409848601337d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.3730214195370062d,
0.9071831976150199d,
0.3029774020422903d,
0.011703806753056045d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Double[3]
{
0.2928273441194018d,
0.8727944398440085d,
0.19473342415325479d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 67,
    Value = 
new System.Double[3]
{
0.25327522278299874d,
0.21389859849028636d,
0.6406593989468345d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 132,
    Value = 
new System.Double[4]
{
0.4934639185302573d,
0.5916273446110395d,
0.2506787553630553d,
0.9878976853714263d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Double[3]
{
0.6071396785577856d,
0.025932022859786685d,
0.0032202395066495137d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 73,
    Value = 
new System.Double[3]
{
0.605533118109576d,
0.5985312311994555d,
0.6804293988705836d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.6057611078950096d,
0.4987842082071817d,
0.00505064506997388d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Double[3]
{
0.7921616368578283d,
0.915903633285092d,
0.8373399380321641d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.7436299366943837d,
0.9857105477377581d,
0.9259422769950855d,
0.5922977867139619d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Double[4]
{
0.05843807439429349d,
0.5445449054678416d,
0.6042328783262436d,
0.18972348966875563d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 77,
    Value = 
new System.Double[3]
{
0.49523588455051826d,
0.6748204187712321d,
0.4823555224099553d,
},
    NullableValue = 
new System.Double[3]
{
0.995165087409551d,
0.7545185397720366d,
0.03248513844180956d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Double[4]
{
0.9465566780876511d,
0.27286017762029635d,
0.49320710478024055d,
0.37507574175934133d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Double[4]
{
0.8912817176667335d,
0.3075632382601068d,
0.14219997623823788d,
0.5891301753960054d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 83,
    Value = 
new System.Double[4]
{
0.5054758913028561d,
0.8974276441142349d,
0.46461541341918966d,
0.4637830266012254d,
},
    NullableValue = 
new System.Double[3]
{
0.5864418557871139d,
0.8278797214409956d,
0.5399742091625083d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Double[4]
{
0.2790973251752922d,
0.8957717607642591d,
0.41375319776702757d,
0.37206596722750185d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Double[4]
{
0.17050198838612785d,
0.07186823910836349d,
0.05690976849269902d,
0.7099122958451859d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 84,
    Value = 
new System.Double[4]
{
0.6098763198169808d,
0.30924682501458123d,
0.9454480780012602d,
0.36407289052285374d,
},
    NullableValue = 
new System.Double[3]
{
0.3985618132237798d,
0.5332290458686478d,
0.3717515239585145d,
},
},
    NullableValue = 
new System.Double[4]
{
0.4922869036016596d,
0.5495592249174346d,
0.9829921464798165d,
0.48444600591408304d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 164,
    Value = 
new System.Double[3]
{
0.23934054472743993d,
0.9687954693774332d,
0.3878779053667223d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.36517439292491594d,
0.7672349506020241d,
0.031021860472993046d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Double[3]
{
0.3714706073340479d,
0.6486525242918642d,
0.40231109814718313d,
},
    ModelInner = new Doubledouble_precisionMArrayD11MI
{
    Id = 92,
    Value = 
new System.Double[4]
{
0.48333929385941155d,
0.2693108530950924d,
0.9836182179204856d,
0.7671620733181862d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.5197228812189394d,
0.03297776332248059d,
0.6316780751292881d,
0.5658318560300027d,
},
},
            new Doubledouble_precisionMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Double[3]
{
0.7379845688657406d,
0.06905617631765071d,
0.4998405408359794d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.024716797335639806d,
0.539525166587227d,
0.7530426581671317d,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmarrayd11mi(
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
INSERT INTO public.doubledouble_precisionmarrayd11mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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

                changedRows =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmarrayd11mi_id
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)), 
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
                methodParametrName: "doubledouble_precisionmarrayd11mi_id", 
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
                changedRows =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmarrayd11mi_id
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
    doubledouble_precisionmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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

                    nullable =  ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.059306793916878986d,
0.8184842215269297d,
0.9705418556123506d,
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

                    nullable = await ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.6522119186702408d,
0.5124418301394801d,
0.5065342695261354d,
0.9483784750668525d,
}));
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

                    nullable = await ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.7779852563043494d,
0.5093508757257367d,
0.8285197546806825d,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionmarrayd1e1m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionmarrayd11mi_id
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
    doubledouble_precisionmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                methodParametrName: "doubledouble_precisionmarrayd11mi_id", 
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
                nullable =  ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IDoubleMArraydouble_precisionMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.22541242782075033d,
0.425926393854415d,
0.9596513110408378d,
0.17995466562308338d,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMArrayD1E1M> models = null;

                models =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionMArrayD1E1M> models = null;

                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDoubleMArraydouble_precisionMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M), typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmarrayd11mi mi ON mi.id = m.doubledouble_precisionmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M), typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmarrayd11mi mi ON mi.id = m.doubledouble_precisionmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M), typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 78;
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmarrayd11mi mi ON mi.id = m.doubledouble_precisionmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M), typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 74, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var models2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var firstItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 138, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 74, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 91, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 97, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
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
FROM public.doubledouble_precisionmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems1 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                var secondItems2 = new List<FlatDoubledouble_precisionMArrayD1E1M>();
                 ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 138, query1, 115, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionMArrayD1E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.doubledouble_precisionmarrayd1e1m m
LEFT JOIN public.doubledouble_precisionmarrayd11mi mi ON mi.id = m.doubledouble_precisionmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models = await((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 116, 136))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Doubledouble_precisionMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 43, 156))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[34], false);
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
                await using var cmd = await ((IDoubleMArraydouble_precisionMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleMArraydouble_precisionMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 136);
                var models =  ((IDoubleMArraydouble_precisionMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                Doubledouble_precisionMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                Doubledouble_precisionMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_doubledouble_precisionmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMArrayD11MIWA),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMArrayD11MI),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_doubledouble_precisionmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDoubleMArraydouble_precisionMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Doubledouble_precisionMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDoubleMArraydouble_precisionMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionMArrayD1E1M),
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
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
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
FROM public.binary_doubledouble_precisionmarrayd1e1m m
LEFT JOIN public.binary_doubledouble_precisionmarrayd11mi mi ON mi.id = m.doubledouble_precisionmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Doubledouble_precisionMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDoubleMArraydouble_precisionMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Doubledouble_precisionMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDoubleMArraydouble_precisionMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Doubledouble_precisionMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models =  ((IDoubleMArraydouble_precisionMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA), typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMArrayD11MIWA>();
                var models2 = new List<Doubledouble_precisionMArrayD11MIWA>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMArrayD11MIWA>();
                var models2 = new List<Doubledouble_precisionMArrayD11MIWA>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
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
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
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
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA), typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMArrayD11MIWA>();
                var models2 = new List<Doubledouble_precisionMArrayD11MIWA>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMArrayD11MIWA>();
                var models2 = new List<Doubledouble_precisionMArrayD11MIWA>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_doubledouble_precisionmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
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
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_doubledouble_precisionmarrayd11mi
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
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MI), typeof(Doubledouble_precisionMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models1 = new List<Doubledouble_precisionMArrayD11MI>();
                var models2 = new List<Doubledouble_precisionMArrayD11MI>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMArrayD11MI>();
                var models2 = new List<Doubledouble_precisionMArrayD11MI>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1)),
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
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_doubledouble_precisionmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA), typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
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
                var models1 = new List<Doubledouble_precisionMArrayD11MIWA>();
                var models2 = new List<Doubledouble_precisionMArrayD11MIWA>();
                await ((IDoubleMArraydouble_precisionMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Doubledouble_precisionMArrayD11MIWA>();
                var models2 = new List<Doubledouble_precisionMArrayD11MIWA>();
                ((IDoubleMArraydouble_precisionMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleMArraydouble_precisionMArrayD1))]
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
                var models = await ((IDoubleMArraydouble_precisionMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDoubleMArraydouble_precisionMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

