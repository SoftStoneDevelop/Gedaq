

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
0.1300693806782368d,

0.1826461571238026d,

0.7060721254300205d,

0.5945995457556233d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.12127417929724937d,

0.1592753986650669d,

0.32645100442051334d,

0.7730183664982385d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8694553849596846d,

0.997533704542503d,

0.37628695664782985d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.557701140495458d,

0.6480714179610036d,

0.6478825390520616d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20526020863729255d,

0.6690005617594028d,

0.6748450435169441d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6947274774626303d,

0.7982532714640315d,

0.14753479517670332d,

0.9841610840224088d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8717284346029693d,

0.6064360075180442d,

0.1255874311250217d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07394837649136232d,

0.9840779764596095d,

0.8720083176622224d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5871271559942206d,

0.160370578611436d,

0.5553749291128547d,

0.195332991685772d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6920736182377758d,

0.27295951926953976d,

0.29110192468583906d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2081005364143258d,

0.1914566162379865d,

0.6998183856587197d,

0.46459461650741696d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31596818149501504d,

0.20623056493957004d,

0.15143060356779492d,

0.7672394935469705d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4942630871514121d,

0.5381265477230271d,

0.3180639259038165d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6754264830150686d,

0.28935338551466283d,

0.21869745932945417d,

0.8808280832136375d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9724034819642045d,

0.3899398094033645d,

0.0304741688050314d,

0.9366971737699434d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.24094635346957438d,

0.48482753849130644d,

0.5307317970251586d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8078309993829847d,

0.21665164646502033d,

0.9617078582765296d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5269780150225828d,

0.9290157162265388d,

0.673419589502484d,

0.6543924803321666d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9961443310405699d,

0.19538870969658728d,

0.5533172798923376d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4477209135588486d,

0.9455073686936869d,

0.16356677504090134d,

0.8538918968209267d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3920787386458028d,

0.2593178841296707d,

0.7909395461902994d,

0.14912813634161515d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5133365798634013d,

0.3373051614941356d,

0.6192725021164315d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1424213621839041d,

0.35129583729904856d,

0.21509190586201277d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6076624954816778d,

0.7901879340485473d,

0.16606748812080752d,

0.18022422324115417d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.898464062509048d,

0.5529886353712891d,

0.8466726236484735d,

0.7479387335095393d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6243494697770996d,

0.10964029718474855d,

0.004484218831078413d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3655212851931232d,

0.8498431852940083d,

0.5056566842917467d,

0.22480207632485594d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3240404455813114d,

0.7228687164441807d,

0.9755826303892768d,

0.9501458233436875d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3395740923574758d,

0.9695450796923482d,

0.08551523053441568d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5348226320883228d,

0.755659440589d,

0.48266829623926244d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.35649272737994986d,

0.7863745319366305d,

0.09042149272554079d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.45493496089521857d,

0.4066427227781598d,

0.9666548211906417d,

0.8204827441412362d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.37659795065917545d,

0.04917237355488657d,

0.7612092207292325d,

0.6470078700976242d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7112148493305935d,

0.3930861804674579d,

0.23011854694545097d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3916330961724277d,

0.058849655614395924d,

0.9337574490667179d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4752902997045767d,

0.0439631748404552d,

0.36237077881341173d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7539756815446151d,

0.9295697901217005d,

0.5913744396651419d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8517949171930659d,

0.7804385235134003d,

0.570317738400658d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.28721149939210977d,

0.5711382980441256d,

0.6534552589510219d,

0.482548507213832d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6120358776912144d,

0.9565490197970772d,

0.644693987755294d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.43591749655882783d,

0.4625092105330353d,

0.540700128346033d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5625109454602691d,

0.7047314951908941d,

0.08184118031128684d,

0.2508486375376503d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9418355214185907d,

0.4740894592921788d,

0.7805078859130024d,

0.9276102444167387d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09011157049354501d,

0.43458487662394363d,

0.5416189657704978d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.08298553203702863d,

0.2873261694920959d,

0.9231073808030861d,

0.11018803100798225d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4230777234418489d,

0.3736551440247259d,

0.8307117390584934d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7199280984551844d,

0.2166893581347238d,

0.3547274479959528d,

0.9348613119211762d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2172940291896337d,

0.7265898152536154d,

0.09465510735903315d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.21532142365613705d,

0.32176445659481157d,

0.33025573048250567d,

0.8745430256218089d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9943848919331569d,

0.5304802586378157d,

0.24585649286511224d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5873621564908956d,

0.2447346113360489d,

0.5310577116648121d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3324598244210518d,

0.10310453187717739d,

0.848405692490444d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.01552406296582276d,

0.8109712459972128d,

0.7292429043472821d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4204706963659298d,

0.2283397911117816d,

0.8503321676211056d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4208106340905384d,

0.5576023235345016d,

0.9838261956487148d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.06136435139217822d,

0.8230483579460942d,

0.5150176797074915d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.17393153603998934d,

0.6635674639108274d,

0.0479217027387282d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.125138324623303d,

0.7448613730701865d,

0.7784180495324963d,

0.5608369017343953d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12004578488978712d,

0.4518713058701469d,

0.2751187820270905d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5573220731378471d,

0.4327929437925201d,

0.8570815575151236d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7101102658833817d,

0.9764982940037615d,

0.9399724495265905d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8197860649186856d,

0.24592851780269231d,

0.9171833570768536d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6282730141747463d,

0.3020418330291236d,

0.2564989380172005d,

0.22294867143765618d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.20300081323224584d,

0.4175875724593757d,

0.9049523289695913d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.21643777857277302d,

0.30646336256419215d,

0.495703903821193d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33993613834732417d,

0.033532063203948304d,

0.5392008614766346d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.22596555971262455d,

0.9614701657571335d,

0.8928101035610478d,

0.6523604254103242d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6303967876989162d,

0.16318996104595507d,

0.20703672187229782d,

0.8541426523840986d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6669814814159132d,

0.43941343168759084d,

0.14310017739491954d,

0.652353947626326d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7655805564195767d,

0.576437503931815d,

0.01307720924979161d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.45442871128473283d,

0.36447708510202503d,

0.9315767410727639d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8121772916149551d,

0.8702819750913058d,

0.16502678649484226d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5371071673947904d,

0.43511734052794837d,

0.8800989084251849d,

0.46198544969581157d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16489635743081332d,

0.017160971808520498d,

0.28161011379940415d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9953009746517886d,

0.3166987146001422d,

0.598977550248362d,

0.5878953877425895d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3157291675786441d,

0.3508868712211505d,

0.4819370964200732d,

0.6600702450408978d,

},
    ModelInner = new Doubledouble_precisionListD1E2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5581958254004452d,

0.5571003198875385d,

0.0670251800832734d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.945923890751082d,

0.1854123298816569d,

0.7997484826143731d,

0.49826055508358635d,

},
},
            new Doubledouble_precisionListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6663208333537529d,

0.5444262559312393d,

0.17395514748450436d,

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 5;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 153;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[29], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[30], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[31], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[32], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[33], false);
                        Doubledouble_precisionListD1E2M.AssertModel(models[27],_testData[34], false);
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
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 52, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
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
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 100, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[29],_testData[34], false);
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
                await ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 68, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 94, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(models[14],_testData[34], false);
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
                 ((IDoubleListdouble_precisionListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 129, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatDoubledouble_precisionListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 28, 90))
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionListD1)this).DbConnectionSTSelectModelBatch(connection, 122, 66))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models = await ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Doubledouble_precisionListD1E2M.AssertModel(models[0],_testData[8], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[1],_testData[9], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[2],_testData[10], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[3],_testData[11], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[4],_testData[12], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[5],_testData[13], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[6],_testData[14], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[7],_testData[15], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[8],_testData[16], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[9],_testData[17], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[10],_testData[18], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[11],_testData[19], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[12],_testData[20], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[13],_testData[21], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[14],_testData[22], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[15],_testData[23], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[16],_testData[24], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[17],_testData[25], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[18],_testData[26], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[19],_testData[27], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[20],_testData[28], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[21],_testData[29], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[22],_testData[30], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[23],_testData[31], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[24],_testData[32], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[25],_testData[33], false);
                Doubledouble_precisionListD1E2M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionListD1)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((IDoubleListdouble_precisionListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

