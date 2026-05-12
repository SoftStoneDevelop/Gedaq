

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.350956022839515m,

0.731108380292499m,

0.803368353348266m,

0.961378468418538m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0936293170941931m,

0.567280354312758m,

0.488628850136021m,

0.289445630375811m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.131442680236433m,

0.676080198951634m,

0.38191634817987m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.121415684804627m,

0.856941305114314m,

0.650346729015133m,

0.484079505891781m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.368719161221712m,

0.30295510741026m,

0.0189839312497172m,

0.372852415692769m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.399050587287325m,

0.768183444216035m,

0.582397306029585m,

0.70446931668573m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.171302209190485m,

0.488645429733402m,

0.904706269221081m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.479720700589836m,

0.283028805454573m,

0.0957032435217178m,

0.66433256589542m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.964444592637023m,

0.779087568945455m,

0.0363552766820203m,

0.591007364521132m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.55729279910679m,

0.681056724054097m,

0.0620432264507618m,

0.0239604167763204m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.628567510000578m,

0.74770726352242m,

0.408227075589152m,

0.218864414048054m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.666141765870718m,

0.114685494271088m,

0.713524555678435m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.852401562443818m,

0.574530158588618m,

0.422541416833088m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.838215382336228m,

0.610354579784839m,

0.00319039227328666m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.464152775631733m,

0.491325321267622m,

0.202356776465654m,

0.736455517801598m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.344620791642962m,

0.103162396488626m,

0.135625592765977m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.808186810421011m,

0.168054941726667m,

0.183660041215051m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.479011310264506m,

0.425172159005787m,

0.222038537284145m,

0.688184320391821m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.38355077291215m,

0.884315897532269m,

0.487174619711414m,

0.873203733212078m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.567887428147496m,

0.783478793900239m,

0.0221813521490241m,

0.027695313252331m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.157910525813949m,

0.379932345371049m,

0.0279432994127665m,

0.0584575041279498m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.770913760107893m,

0.859339599385649m,

0.4305913112236m,

0.0189735370790458m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.310063688296704m,

0.28025264200857m,

0.379295936038573m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.867860237290341m,

0.292074134446429m,

0.148900533632142m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.902508505023874m,

0.546248595074764m,

0.432149211996873m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.77692063683524m,

0.916974436752076m,

0.802569185398424m,

0.869104441858218m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.350586870294024m,

0.942374340475418m,

0.817262328337939m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290706861868116m,

0.63646729772628m,

0.890104115420574m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.66628455147597m,

0.861121291079738m,

0.203786515520741m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.714876467150831m,

0.042623267863996m,

0.44931152281354m,

0.166203003563807m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.982881996131936m,

0.0535927637674388m,

0.80882963770796m,

0.28606804052247m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.945101323809116m,

0.0238842750134979m,

0.221476315200617m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.996980228481756m,

0.511036246030633m,

0.390497452584164m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.88417855912327m,

0.380305614367168m,

0.449070155133495m,

0.5951456367824m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0148455291064902m,

0.293525033634384m,

0.10297077904355m,

0.866329561647296m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.102788365173332m,

0.734702959593578m,

0.415617418279281m,

0.0814962327854577m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0241820060983768m,

0.966054897503847m,

0.113083330200201m,

0.799446190361311m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.599106463567961m,

0.639696716558007m,

0.389298041743439m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.972174618514836m,

0.794949821320403m,

0.521044909878585m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.48423565015257m,

0.520863549437593m,

0.42928983756526m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.218584069584093m,

0.92102268956695m,

0.617278228830598m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.743174273551126m,

0.768897584210849m,

0.896857705026284m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0280674431518327m,

0.781837479760072m,

0.0276295597297497m,

0.914683188233653m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.548561406129646m,

0.792093487431622m,

0.361704404543547m,

0.673994956347624m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0476207901940774m,

0.138588764468826m,

0.713037531686138m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.791160249819578m,

0.208182062819987m,

0.916845421831704m,

0.159216262312359m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.215770276599236m,

0.587594505415519m,

0.896781508273757m,

0.889073374312956m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.14372491155912m,

0.781762716014806m,

0.847764765689547m,

0.884655175847756m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0940885952960206m,

0.577702405102966m,

0.833573596135037m,

0.814882707413686m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.720241726380916m,

0.364294885357067m,

0.996307600985453m,

0.244367315010241m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.534406346034031m,

0.840203007577736m,

0.925470216768909m,

0.636542517481496m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.738504525663775m,

0.197064519988047m,

0.723559743397297m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.409769141761988m,

0.173487776911902m,

0.355482283859128m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.783451865621563m,

0.63827986588216m,

0.952293710452738m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.607953955746725m,

0.669247609057849m,

0.84101830318822m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.638751279546574m,

0.466567696755631m,

0.521012688540202m,

0.130444651031022m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.841598397642722m,

0.291296355417934m,

0.346554111462248m,

0.258482294735137m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.5634472194351m,

0.383869533332074m,

0.624288769676659m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.11529807240208m,

0.64362207429031m,

0.230760924951085m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.763464433824886m,

0.940735881775243m,

0.911571320495539m,

0.863069104963142m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.620652783039255m,

0.152202404393331m,

0.276796305775676m,

0.0681789822740577m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.521218167761718m,

0.118599595055123m,

0.952692264897907m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.829531745933976m,

0.88349112755157m,

0.421993449427736m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.306107681536262m,

0.586803648718003m,

0.0235611199647938m,

0.97306716551287m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.325430419918908m,

0.912591458194265m,

0.846066898476098m,

0.690215522175501m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.349754609513887m,

0.990077220145831m,

0.258415381135184m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.127387917485892m,

0.121714268106475m,

0.390379319037412m,

0.662003672490838m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.969326697684311m,

0.736797374027305m,

0.560822657138806m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.583391311541769m,

0.376892336634538m,

0.341912159858461m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0518487139780529m,

0.546306233383757m,

0.808443859909721m,

0.607453149307049m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.618636011392287m,

0.395401930832605m,

0.569935761150219m,

0.422784254110123m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.45382464292211m,

0.414098551610342m,

0.911861069603819m,

0.259344703366853m,

},
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.65417786579929m,

0.694598466230214m,

0.386644491849876m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0335372536325596m,

0.990287661509459m,

0.0075682429497409m,

0.774459234378405m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.306421306106171m,

0.250683151638973m,

0.843875907043831m,

0.342372401931215m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.947331921610933m,

0.897625256544881m,

0.0444132380040622m,

0.294352969069566m,

},
},
            new DecimalnumericListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.941405041037311m,

0.432140012510664m,

0.0501592051824694m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0174584114550121m,

0.988687469110082m,

0.521950158070941m,

},
    ModelInner = new DecimalnumericListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.231091209160628m,

0.972027611217101m,

0.452076336042236m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.343913989286346m,

0.0943850079146393m,

0.894752289622016m,

0.737902385031886m,

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 37;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 154;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[34], false);
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
                await ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 166, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 102, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
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
                 ((IDecimalListnumericListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 1, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
                 ((IDecimalListnumericListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 5, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 56, query1, 5, query2))
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
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[27],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[28],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[29],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[30],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[31],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[32],_testData[34], false);
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
                await ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 147, query1, 141, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 96, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(models[15],_testData[34], false);
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
                 ((IDecimalListnumericListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 50, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 1, 11))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[30],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[31],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[32],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericListD1E2M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericListD1E2M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericListD1E2M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericListD1E2M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericListD1E2M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericListD1E2M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericListD1E2M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericListD1E2M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericListD1E2M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericListD1E2M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericListD1E2M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericListD1E2M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericListD1E2M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericListD1E2M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericListD1E2M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericListD1E2M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericListD1E2M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericListD1E2M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericListD1E2M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericListD1E2M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericListD1E2M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericListD1E2M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericListD1E2M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericListD1E2M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericListD1E2M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericListD1E2M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericListD1E2M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericListD1E2M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericListD1E2M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericListD1E2M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericListD1E2M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericListD1E2M.AssertModel(models[31],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericListD1)this).DbConnectionSTSelectModelBatch(connection, 56, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models = await ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericListD1)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((IDecimalListnumericListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                DecimalnumericListD1E2M.AssertModel(models[0],_testData[8], false);
                DecimalnumericListD1E2M.AssertModel(models[1],_testData[9], false);
                DecimalnumericListD1E2M.AssertModel(models[2],_testData[10], false);
                DecimalnumericListD1E2M.AssertModel(models[3],_testData[11], false);
                DecimalnumericListD1E2M.AssertModel(models[4],_testData[12], false);
                DecimalnumericListD1E2M.AssertModel(models[5],_testData[13], false);
                DecimalnumericListD1E2M.AssertModel(models[6],_testData[14], false);
                DecimalnumericListD1E2M.AssertModel(models[7],_testData[15], false);
                DecimalnumericListD1E2M.AssertModel(models[8],_testData[16], false);
                DecimalnumericListD1E2M.AssertModel(models[9],_testData[17], false);
                DecimalnumericListD1E2M.AssertModel(models[10],_testData[18], false);
                DecimalnumericListD1E2M.AssertModel(models[11],_testData[19], false);
                DecimalnumericListD1E2M.AssertModel(models[12],_testData[20], false);
                DecimalnumericListD1E2M.AssertModel(models[13],_testData[21], false);
                DecimalnumericListD1E2M.AssertModel(models[14],_testData[22], false);
                DecimalnumericListD1E2M.AssertModel(models[15],_testData[23], false);
                DecimalnumericListD1E2M.AssertModel(models[16],_testData[24], false);
                DecimalnumericListD1E2M.AssertModel(models[17],_testData[25], false);
                DecimalnumericListD1E2M.AssertModel(models[18],_testData[26], false);
                DecimalnumericListD1E2M.AssertModel(models[19],_testData[27], false);
                DecimalnumericListD1E2M.AssertModel(models[20],_testData[28], false);
                DecimalnumericListD1E2M.AssertModel(models[21],_testData[29], false);
                DecimalnumericListD1E2M.AssertModel(models[22],_testData[30], false);
                DecimalnumericListD1E2M.AssertModel(models[23],_testData[31], false);
                DecimalnumericListD1E2M.AssertModel(models[24],_testData[32], false);
                DecimalnumericListD1E2M.AssertModel(models[25],_testData[33], false);
                DecimalnumericListD1E2M.AssertModel(models[26],_testData[34], false);
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

