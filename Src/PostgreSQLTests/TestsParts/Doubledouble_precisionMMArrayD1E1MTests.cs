

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
    Id = 1,
    Value = 
new System.Double[4]
{
0.18161329911267832d,
0.8915190191572755d,
0.5590484128468796d,
0.45433181351768415d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8247838604888571d,
0.5037740617221925d,
0.13654584533645986d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Double[4]
{
0.1236245755263482d,
0.3404951189866562d,
0.5390123511269945d,
0.618967563594838d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 9,
    Value = 
new System.Double[3]
{
0.04742605048480053d,
0.8217630723251841d,
0.7922218413462812d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Double[4]
{
0.026668959962634298d,
0.40600972096091525d,
0.5265946759927078d,
0.008847256354519772d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Double[4]
{
0.2960448827012261d,
0.035646907926134785d,
0.17822433795241932d,
0.2736574508859656d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Double[3]
{
0.9795384783627821d,
0.367956868405644d,
0.8977880648146901d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[3]
{
0.5986673226142848d,
0.12917927363768422d,
0.3392479833211224d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Double[4]
{
0.31063837087937385d,
0.10940961303076735d,
0.39566581251302224d,
0.8068374030114064d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 28,
    Value = 
new System.Double[4]
{
0.14761240847981627d,
0.6735431894327935d,
0.8188003695549478d,
0.3322148403755203d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Double[3]
{
0.23572002412139625d,
0.867810060232429d,
0.7121963266715305d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.28263075118544945d,
0.18461468634937794d,
0.010180501568122557d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9609966980849185d,
0.5319057214459796d,
0.9730548717063311d,
0.8860065950893d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Double[3]
{
0.7251324025867292d,
0.9140501790895887d,
0.2880686370463268d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Double[3]
{
0.3952191942341914d,
0.7649877766263333d,
0.43227053643039093d,
},
    NullableValue = 
new System.Double[4]
{
0.7506506186611874d,
0.15449351049665416d,
0.304596014525924d,
0.20812986692697133d,
},
},
    NullableValue = 
new System.Double[3]
{
0.7053849732375328d,
0.9477684949022368d,
0.959399515573368d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Double[3]
{
0.7236534173736556d,
0.9179926491576721d,
0.7187292965231615d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Double[3]
{
0.4538020223957494d,
0.7599280172887557d,
0.055860464310037994d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Double[4]
{
0.21059369842163977d,
0.848258666085081d,
0.31825635270238095d,
0.6604297076213719d,
},
    NullableValue = 
new System.Double[3]
{
0.013985469616162538d,
0.6282657858187296d,
0.5760327844662283d,
},
},
    NullableValue = 
new System.Double[4]
{
0.36863131764210655d,
0.07191425144456554d,
0.9892893018722181d,
0.0448697557258354d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 57,
    Value = 
new System.Double[3]
{
0.9030507235716354d,
0.455336324626917d,
0.14279575529644806d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 64,
    Value = 
new System.Double[3]
{
0.24939552363094153d,
0.43609569807394744d,
0.1763326860136606d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Double[3]
{
0.0011254863069591892d,
0.8110818483323429d,
0.672471211805033d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.9372296324021514d,
0.11334415807920395d,
0.27789688187054273d,
0.6141905723877858d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.35100059627048275d,
0.3470568283027663d,
0.707932993620133d,
0.03680456940338972d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.4662478453616721d,
0.45842821708087744d,
0.990002005253719d,
0.13765737466432126d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Double[3]
{
0.2274214793579835d,
0.5578084255705534d,
0.2782503167200634d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Double[4]
{
0.8311124051263685d,
0.07422313849391471d,
0.9151052622549678d,
0.19188494967634395d,
},
    NullableValue = 
new System.Double[3]
{
0.40730578385447924d,
0.17169273547010877d,
0.037690295310618516d,
},
},
    NullableValue = 
new System.Double[4]
{
0.9467977386061232d,
0.6495545926867154d,
0.7550823476921587d,
0.7169127589814768d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Double[4]
{
0.9752402175325375d,
0.4864662227600527d,
0.39997988941305473d,
0.0226710033236156d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Double[4]
{
0.8968251869254045d,
0.7429106253822293d,
0.2887863721084585d,
0.935090273442829d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Double[3]
{
0.11537360205398073d,
0.4100451269462868d,
0.5600297996615337d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.10569753485651467d,
0.5853429586508608d,
0.02413727601594018d,
0.7788089375635452d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 95,
    Value = 
new System.Double[4]
{
0.32869469266560947d,
0.10950704123897648d,
0.2701832779829024d,
0.8066440574040237d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.8914178021014993d,
0.5074290350392978d,
0.1633802917774072d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Double[4]
{
0.8999231350796374d,
0.07598771252214054d,
0.8581836793275357d,
0.485436243144862d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Double[4]
{
0.1782461132101648d,
0.542070110223385d,
0.9244066792876062d,
0.7138789911360484d,
},
    NullableValue = 
new System.Double[3]
{
0.8652185976980191d,
0.4904152666279601d,
0.6343255369987824d,
},
},
    NullableValue = 
new System.Double[3]
{
0.8066278332335226d,
0.49340973344852357d,
0.8580912777568802d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Double[4]
{
0.6690294784376933d,
0.9246866796009245d,
0.6417665335642342d,
0.16601769461865645d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.8245459161223343d,
0.8495183687497525d,
0.24428406030927052d,
0.24654092451399046d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Double[3]
{
0.9294390235672751d,
0.18509603887680937d,
0.5755879045835088d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Double[3]
{
0.8377429198460294d,
0.356961046145425d,
0.8824602032246972d,
},
    NullableValue = 
new System.Double[4]
{
0.12160194231005039d,
0.33504322690476607d,
0.5217992219023674d,
0.7010407321846006d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Double[3]
{
0.9664682477924207d,
0.726453930192936d,
0.4969341762067252d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Double[4]
{
0.3849421697509967d,
0.136506674495249d,
0.4464561355605565d,
0.4908724275719042d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Double[4]
{
0.514742266603253d,
0.44029891055772163d,
0.4165887090462619d,
0.4982989630051762d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Double[3]
{
0.1024702680558982d,
0.9930981542600168d,
0.1335521034540066d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9843499643874813d,
0.9557366598002457d,
0.17758872716122465d,
0.22410563890762358d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 125,
    Value = 
new System.Double[4]
{
0.23054930512217597d,
0.26278811162325955d,
0.2663705322737423d,
0.3376248826655315d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Double[3]
{
0.5288661711979274d,
0.4021500668001998d,
0.7601955512640556d,
},
    NullableValue = 
new System.Double[3]
{
0.30360417778814575d,
0.7158643091872106d,
0.653899235704223d,
},
},
    NullableValue = 
new System.Double[3]
{
0.9683824885418563d,
0.9097493532895757d,
0.49465568407679084d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 133,
    Value = 
new System.Double[3]
{
0.9133598177785194d,
0.3431623658698708d,
0.3045637780902588d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.6659404366852127d,
0.42537257962809405d,
0.7101710148534103d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 135,
    Value = 
new System.Double[4]
{
0.09667113779900394d,
0.24912749540135815d,
0.9996050431432938d,
0.5949185690518557d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 54,
    Value = 
new System.Double[4]
{
0.9842154111666634d,
0.43945947676125396d,
0.30939843678049006d,
0.18761140357552364d,
},
    NullableValue = 
new System.Double[4]
{
0.4353003862737185d,
0.5657528621426374d,
0.3318048287898665d,
0.5187655941694459d,
},
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 139,
    Value = 
new System.Double[4]
{
0.07540468865207095d,
0.4258746356575285d,
0.5462922970486122d,
0.5876637797281807d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 146,
    Value = 
new System.Double[4]
{
0.6184976487956075d,
0.3975960405145318d,
0.43315505976381885d,
0.19759108614136156d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Double[3]
{
0.7108386813795695d,
0.03362945494947933d,
0.6629211911005258d,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 151,
    Value = 
new System.Double[4]
{
0.0027355668332263994d,
0.6076710579512121d,
0.4934819651343194d,
0.043246943696400475d,
},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Double[3]
{
0.6449427772520797d,
0.8124977054192535d,
0.019590221360860638d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 65,
    Value = 
new System.Double[3]
{
0.7412300019886988d,
0.8980594834521873d,
0.9489960619175901d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.16129533283290776d,
0.8174130949843174d,
0.7174087778000977d,
0.2137185570741288d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Double[4]
{
0.4263472030907912d,
0.36829633626374925d,
0.7673326265221904d,
0.808311627825144d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[3]
{
0.32393392334018833d,
0.12961977342215303d,
0.7324615239874321d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Double[4]
{
0.7321976278497649d,
0.45447681452808064d,
0.0010386901752220679d,
0.26261334197346176d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Double[3]
{
0.273751527426612d,
0.5675574849870786d,
0.41063995109488793d,
},
    NullableValue = 
new System.Double[3]
{
0.08579994539540592d,
0.8173652257617382d,
0.8971728150008345d,
},
},
    NullableValue = 
new System.Double[3]
{
0.2440062648708312d,
0.28554028532156606d,
0.18371200829716638d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Double[4]
{
0.7107953452935667d,
0.187948850602092d,
0.8221240449291173d,
0.05966912487991649d,
},
    ModelInner = null,
    NullableValue = 
new System.Double[4]
{
0.9834016217872711d,
0.8415050727162995d,
0.946779744235119d,
0.8494681335813159d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Double[4]
{
0.36682554699503656d,
0.47444784283294783d,
0.7995117229496589d,
0.6313283853013538d,
},
    ModelInner = new Doubledouble_precisionMMArrayD1E1MI
{
    Id = 69,
    Value = 
new System.Double[4]
{
0.019590478927225763d,
0.8331072443893318d,
0.6464432487805445d,
0.4474841275673743d,
},
    NullableValue = null,
},
    NullableValue = 
new System.Double[4]
{
0.1335010722568567d,
0.33960463961106513d,
0.7202518539816072d,
0.7696379910079594d,
},
},
            new Doubledouble_precisionMMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Double[4]
{
0.49326402754185483d,
0.24129569126571504d,
0.2429680534370211d,
0.4512367800011322d,
},
    ModelInner = null,
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.9609966980849185d,
0.5319057214459796d,
0.9730548717063311d,
0.8860065950893d,
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

                    nullable = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[3]
{
0.7053849732375328d,
0.9477684949022368d,
0.959399515573368d,
}));
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
                Assert.That(nullable, Is.Null);
                nullable =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.36863131764210655d,
0.07191425144456554d,
0.9892893018722181d,
0.0448697557258354d,
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Double[4]
{
0.9372296324021514d,
0.11334415807920395d,
0.27789688187054273d,
0.6141905723877858d,
}));
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 139;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 33;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 155, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 111, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 64, query1, 19, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 14, query2))
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 163, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 162, query1, 151, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                 ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 155, query1, 161, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDoubledouble_precisionMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 161, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleMArraydouble_precisionMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 133, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        Doubledouble_precisionMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models = await ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleMArraydouble_precisionMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleMArraydouble_precisionMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((IDoubleMArraydouble_precisionMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                Doubledouble_precisionMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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

