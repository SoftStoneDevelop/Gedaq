

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
    Id = 1,
    Value = 
new System.Decimal[3]
{
0.124211739754357m,
0.201744793608011m,
0.269635256247303m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.299678571676022m,
0.6542489049854m,
0.209395477053666m,
},
},
            new DecimalnumericArray1M
{
    Id = 10,
    Value = 
new System.Decimal[4]
{
0.340792963627043m,
0.287230020710649m,
0.108540838583554m,
0.926665299145181m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 7,
    Value = 
new System.Decimal[3]
{
0.385871908267376m,
0.525406664555091m,
0.924957444453661m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.711656786578238m,
0.97701056146712m,
0.436176904875961m,
0.478158289065636m,
},
},
            new DecimalnumericArray1M
{
    Id = 14,
    Value = 
new System.Decimal[4]
{
0.750311871629655m,
0.772882847006951m,
0.165446509662108m,
0.0177846933234184m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 18,
    Value = 
new System.Decimal[4]
{
0.274725467992348m,
0.160371165895289m,
0.362637644406071m,
0.39148827770576m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 11,
    Value = 
new System.Decimal[3]
{
0.140621840135181m,
0.636453680164308m,
0.942957063456738m,
},
    NullableValue = 
new System.Decimal[4]
{
0.110510341640622m,
0.160222761530246m,
0.075106511649812m,
0.889782470041236m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 21,
    Value = 
new System.Decimal[3]
{
0.173024430368705m,
0.755111600649019m,
0.96101328934957m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.724493306506085m,
0.939469156880564m,
0.860963613600151m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.557443340757079m,
0.711525678639043m,
0.0815207633778605m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.854344956617084m,
0.552283995319233m,
0.464568057309879m,
0.805449742565637m,
},
},
            new DecimalnumericArray1M
{
    Id = 35,
    Value = 
new System.Decimal[4]
{
0.280021093823355m,
0.927705702244294m,
0.964234319120073m,
0.37271463602778m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.860898099776331m,
0.13929774709795m,
0.245206868470968m,
},
},
            new DecimalnumericArray1M
{
    Id = 38,
    Value = 
new System.Decimal[4]
{
0.491259355860491m,
0.180240330314616m,
0.75749202060408m,
0.92342759878955m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 17,
    Value = 
new System.Decimal[4]
{
0.0675029103878215m,
0.236535628922198m,
0.267641793865065m,
0.439563716923565m,
},
    NullableValue = 
new System.Decimal[3]
{
0.48693159067743m,
0.615606074983985m,
0.790964757200741m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 41,
    Value = 
new System.Decimal[3]
{
0.251886796876041m,
0.75205339398628m,
0.512273224947388m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.0702477781674733m,
0.0822942983388363m,
0.027061570580282m,
0.076043658636113m,
},
},
            new DecimalnumericArray1M
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.125794468503583m,
0.305287472610059m,
0.214565472044014m,
0.595376406752m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 26,
    Value = 
new System.Decimal[3]
{
0.177443485975334m,
0.832725498927236m,
0.0786733834306542m,
},
    NullableValue = 
new System.Decimal[3]
{
0.512966425253477m,
0.752451013367468m,
0.655745445054387m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 54,
    Value = 
new System.Decimal[3]
{
0.495104361803976m,
0.399092858391735m,
0.650782427761327m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.346167154802077m,
0.910654755260999m,
0.116158397326285m,
0.916710827772625m,
},
},
            new DecimalnumericArray1M
{
    Id = 55,
    Value = 
new System.Decimal[3]
{
0.172386749573088m,
0.278846923574165m,
0.0290402287039135m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 30,
    Value = 
new System.Decimal[4]
{
0.883597783849334m,
0.0139503354896175m,
0.477137603804473m,
0.284513655578902m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.63915828307106m,
0.4908885148771m,
0.914602700476574m,
0.429063887582092m,
},
},
            new DecimalnumericArray1M
{
    Id = 61,
    Value = 
new System.Decimal[4]
{
0.743710609505038m,
0.209573760606424m,
0.65990102423465m,
0.935414155880615m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.207280120163076m,
0.654081360534787m,
0.970144572002896m,
},
},
            new DecimalnumericArray1M
{
    Id = 69,
    Value = 
new System.Decimal[4]
{
0.710273560971974m,
0.660490485691113m,
0.260735781046747m,
0.277552725984292m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 36,
    Value = 
new System.Decimal[4]
{
0.868771548564883m,
0.712434707713141m,
0.426888004075049m,
0.980409127143831m,
},
    NullableValue = 
new System.Decimal[4]
{
0.238514773057402m,
0.754429910860212m,
0.126069603518288m,
0.25489536395616m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 78,
    Value = 
new System.Decimal[4]
{
0.095544440788224m,
0.58923030118749m,
0.504423997662741m,
0.899200059109612m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.582838527890497m,
0.907910765667251m,
0.142510993474916m,
},
},
            new DecimalnumericArray1M
{
    Id = 82,
    Value = 
new System.Decimal[3]
{
0.366488950153217m,
0.693679175396113m,
0.823722659469551m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 37,
    Value = 
new System.Decimal[3]
{
0.287973565723864m,
0.362767046817497m,
0.978781797091148m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 86,
    Value = 
new System.Decimal[3]
{
0.72271647877314m,
0.0961606018850407m,
0.132244968449562m,
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
0.244846244441034m,
0.754616842877838m,
0.732365596931938m,
0.460036634543069m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 39,
    Value = 
new System.Decimal[4]
{
0.777327253506066m,
0.709696598052893m,
0.390633098638187m,
0.943906837591706m,
},
    NullableValue = 
new System.Decimal[4]
{
0.422331390954352m,
0.305008417568837m,
0.726255746925941m,
0.402054771794349m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.846119303220983m,
0.963011412707272m,
0.517454289220513m,
},
},
            new DecimalnumericArray1M
{
    Id = 100,
    Value = 
new System.Decimal[4]
{
0.724893479698181m,
0.252026860955667m,
0.912709530413136m,
0.369815375389756m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0173989363908251m,
0.719576098706336m,
0.74977490292467m,
},
},
            new DecimalnumericArray1M
{
    Id = 107,
    Value = 
new System.Decimal[4]
{
0.268343271795457m,
0.863679000121776m,
0.398887565980776m,
0.708410097176535m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 44,
    Value = 
new System.Decimal[4]
{
0.406153076379888m,
0.911331573472107m,
0.151013750823788m,
0.534519405905689m,
},
    NullableValue = 
new System.Decimal[4]
{
0.756550846617512m,
0.692626720652591m,
0.782872152428382m,
0.324933401387535m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.441152538072389m,
0.0318964625553263m,
0.728992262703015m,
0.383851375294212m,
},
},
            new DecimalnumericArray1M
{
    Id = 115,
    Value = 
new System.Decimal[3]
{
0.0621372305410265m,
0.257756701923497m,
0.365055669421953m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.0901883584014547m,
0.540738692891123m,
0.605019010652889m,
},
},
            new DecimalnumericArray1M
{
    Id = 120,
    Value = 
new System.Decimal[4]
{
0.0842479559174372m,
0.599230153801265m,
0.312048241211584m,
0.196499700608361m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 47,
    Value = 
new System.Decimal[3]
{
0.76521960540914m,
0.727224899660356m,
0.637182353917896m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 124,
    Value = 
new System.Decimal[4]
{
0.0407146672418932m,
0.333731539635569m,
0.452704525352865m,
0.684681375318618m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.371966542592395m,
0.388807440249538m,
0.088730515927982m,
},
},
            new DecimalnumericArray1M
{
    Id = 125,
    Value = 
new System.Decimal[3]
{
0.179273984403953m,
0.518593239097606m,
0.271532938130685m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 56,
    Value = 
new System.Decimal[4]
{
0.24660099843176m,
0.79157411779485m,
0.931168745159231m,
0.420356258722624m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 132,
    Value = 
new System.Decimal[4]
{
0.599347397033384m,
0.113362708114211m,
0.38515286194555m,
0.0619029786206742m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.224808100909162m,
0.304235748607897m,
0.833615270464926m,
},
},
            new DecimalnumericArray1M
{
    Id = 139,
    Value = 
new System.Decimal[3]
{
0.0334965258009372m,
0.393797918147862m,
0.571236764011913m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 60,
    Value = 
new System.Decimal[4]
{
0.989251529983753m,
0.662621660489246m,
0.847608625798222m,
0.851408254598311m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.258339499925078m,
0.486642146209524m,
0.00279828981648m,
0.398769249517123m,
},
},
            new DecimalnumericArray1M
{
    Id = 142,
    Value = 
new System.Decimal[3]
{
0.274159692471978m,
0.922686087019957m,
0.311178735798885m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 149,
    Value = 
new System.Decimal[3]
{
0.244578353681365m,
0.0968706804881533m,
0.593525933938901m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 61,
    Value = 
new System.Decimal[3]
{
0.0609135192798824m,
0.83882991043m,
0.950497068740109m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.760291163328262m,
0.888622967119054m,
0.0148078895803392m,
0.154559575942925m,
},
},
            new DecimalnumericArray1M
{
    Id = 150,
    Value = 
new System.Decimal[3]
{
0.72946005586931m,
0.902392401927574m,
0.0597137388624642m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 151,
    Value = 
new System.Decimal[4]
{
0.124174060872946m,
0.748391121675522m,
0.264999571954747m,
0.660231072746256m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 62,
    Value = 
new System.Decimal[4]
{
0.144599450745203m,
0.898289865564091m,
0.86374169908481m,
0.36487909476888m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.494886176491873m,
0.0751185596682795m,
0.872963856159704m,
},
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
                Assert.That(nullable, Is.Null);
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
0.854344956617084m,
0.552283995319233m,
0.464568057309879m,
0.805449742565637m,
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
new System.Decimal[3]
{
0.860898099776331m,
0.13929774709795m,
0.245206868470968m,
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
new System.Decimal[4]
{
0.0702477781674733m,
0.0822942983388363m,
0.027061570580282m,
0.076043658636113m,
}));
                nullable =  ((IDecimalArraynumericArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.346167154802077m,
0.910654755260999m,
0.116158397326285m,
0.916710827772625m,
}));
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.63915828307106m,
0.4908885148771m,
0.914602700476574m,
0.429063887582092m,
}));
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IDecimalArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((IDecimalArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IDecimalArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((IDecimalArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[14], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[15], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[16], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[17], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[18], false);FlatDecimalnumericArray1M.AssertModel(models[5],_testData[19], false);FlatDecimalnumericArray1M.AssertModel(models[6],_testData[20], false);FlatDecimalnumericArray1M.AssertModel(models[7],_testData[21], false);FlatDecimalnumericArray1M.AssertModel(models[8],_testData[22], false);FlatDecimalnumericArray1M.AssertModel(models[9],_testData[23], false);FlatDecimalnumericArray1M.AssertModel(models[10],_testData[24], false);FlatDecimalnumericArray1M.AssertModel(models[11],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[12],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[13],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[14],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[19], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[20], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[21], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[22], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[23], false);FlatDecimalnumericArray1M.AssertModel(models[5],_testData[24], false);FlatDecimalnumericArray1M.AssertModel(models[6],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[7],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[8],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[9],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[10],_testData[29], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[8], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[9], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[10], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[11], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[12], false);FlatDecimalnumericArray1M.AssertModel(models[5],_testData[13], false);FlatDecimalnumericArray1M.AssertModel(models[6],_testData[14], false);FlatDecimalnumericArray1M.AssertModel(models[7],_testData[15], false);FlatDecimalnumericArray1M.AssertModel(models[8],_testData[16], false);FlatDecimalnumericArray1M.AssertModel(models[9],_testData[17], false);FlatDecimalnumericArray1M.AssertModel(models[10],_testData[18], false);FlatDecimalnumericArray1M.AssertModel(models[11],_testData[19], false);FlatDecimalnumericArray1M.AssertModel(models[12],_testData[20], false);FlatDecimalnumericArray1M.AssertModel(models[13],_testData[21], false);FlatDecimalnumericArray1M.AssertModel(models[14],_testData[22], false);FlatDecimalnumericArray1M.AssertModel(models[15],_testData[23], false);FlatDecimalnumericArray1M.AssertModel(models[16],_testData[24], false);FlatDecimalnumericArray1M.AssertModel(models[17],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[18],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[19],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[20],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[10], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[11], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[12], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[13], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[14], false);FlatDecimalnumericArray1M.AssertModel(models[5],_testData[15], false);FlatDecimalnumericArray1M.AssertModel(models[6],_testData[16], false);FlatDecimalnumericArray1M.AssertModel(models[7],_testData[17], false);FlatDecimalnumericArray1M.AssertModel(models[8],_testData[18], false);FlatDecimalnumericArray1M.AssertModel(models[9],_testData[19], false);FlatDecimalnumericArray1M.AssertModel(models[10],_testData[20], false);FlatDecimalnumericArray1M.AssertModel(models[11],_testData[21], false);FlatDecimalnumericArray1M.AssertModel(models[12],_testData[22], false);FlatDecimalnumericArray1M.AssertModel(models[13],_testData[23], false);FlatDecimalnumericArray1M.AssertModel(models[14],_testData[24], false);FlatDecimalnumericArray1M.AssertModel(models[15],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[16],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[17],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[18],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[19],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
DecimalnumericArray1M.AssertModel(models[0],_testData[2], false);DecimalnumericArray1M.AssertModel(models[1],_testData[3], false);DecimalnumericArray1M.AssertModel(models[2],_testData[4], false);DecimalnumericArray1M.AssertModel(models[3],_testData[5], false);DecimalnumericArray1M.AssertModel(models[4],_testData[6], false);DecimalnumericArray1M.AssertModel(models[5],_testData[7], false);DecimalnumericArray1M.AssertModel(models[6],_testData[8], false);DecimalnumericArray1M.AssertModel(models[7],_testData[9], false);DecimalnumericArray1M.AssertModel(models[8],_testData[10], false);DecimalnumericArray1M.AssertModel(models[9],_testData[11], false);DecimalnumericArray1M.AssertModel(models[10],_testData[12], false);DecimalnumericArray1M.AssertModel(models[11],_testData[13], false);DecimalnumericArray1M.AssertModel(models[12],_testData[14], false);DecimalnumericArray1M.AssertModel(models[13],_testData[15], false);DecimalnumericArray1M.AssertModel(models[14],_testData[16], false);DecimalnumericArray1M.AssertModel(models[15],_testData[17], false);DecimalnumericArray1M.AssertModel(models[16],_testData[18], false);DecimalnumericArray1M.AssertModel(models[17],_testData[19], false);DecimalnumericArray1M.AssertModel(models[18],_testData[20], false);DecimalnumericArray1M.AssertModel(models[19],_testData[21], false);DecimalnumericArray1M.AssertModel(models[20],_testData[22], false);DecimalnumericArray1M.AssertModel(models[21],_testData[23], false);DecimalnumericArray1M.AssertModel(models[22],_testData[24], false);DecimalnumericArray1M.AssertModel(models[23],_testData[25], false);DecimalnumericArray1M.AssertModel(models[24],_testData[26], false);DecimalnumericArray1M.AssertModel(models[25],_testData[27], false);DecimalnumericArray1M.AssertModel(models[26],_testData[28], false);DecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
DecimalnumericArray1M.AssertModel(models[0],_testData[23], false);DecimalnumericArray1M.AssertModel(models[1],_testData[24], false);DecimalnumericArray1M.AssertModel(models[2],_testData[25], false);DecimalnumericArray1M.AssertModel(models[3],_testData[26], false);DecimalnumericArray1M.AssertModel(models[4],_testData[27], false);DecimalnumericArray1M.AssertModel(models[5],_testData[28], false);DecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
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

                var models =  ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
DecimalnumericArray1M.AssertModel(models[0],_testData[15], false);DecimalnumericArray1M.AssertModel(models[1],_testData[16], false);DecimalnumericArray1M.AssertModel(models[2],_testData[17], false);DecimalnumericArray1M.AssertModel(models[3],_testData[18], false);DecimalnumericArray1M.AssertModel(models[4],_testData[19], false);DecimalnumericArray1M.AssertModel(models[5],_testData[20], false);DecimalnumericArray1M.AssertModel(models[6],_testData[21], false);DecimalnumericArray1M.AssertModel(models[7],_testData[22], false);DecimalnumericArray1M.AssertModel(models[8],_testData[23], false);DecimalnumericArray1M.AssertModel(models[9],_testData[24], false);DecimalnumericArray1M.AssertModel(models[10],_testData[25], false);DecimalnumericArray1M.AssertModel(models[11],_testData[26], false);DecimalnumericArray1M.AssertModel(models[12],_testData[27], false);DecimalnumericArray1M.AssertModel(models[13],_testData[28], false);DecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
DecimalnumericArray1M.AssertModel(models[0],_testData[24], false);DecimalnumericArray1M.AssertModel(models[1],_testData[25], false);DecimalnumericArray1M.AssertModel(models[2],_testData[26], false);DecimalnumericArray1M.AssertModel(models[3],_testData[27], false);DecimalnumericArray1M.AssertModel(models[4],_testData[28], false);DecimalnumericArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 132, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[5], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[6], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[7], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[8], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[9], false);FlatDecimalnumericArray1M.AssertModel(models[5],_testData[10], false);FlatDecimalnumericArray1M.AssertModel(models[6],_testData[11], false);FlatDecimalnumericArray1M.AssertModel(models[7],_testData[12], false);FlatDecimalnumericArray1M.AssertModel(models[8],_testData[13], false);FlatDecimalnumericArray1M.AssertModel(models[9],_testData[14], false);FlatDecimalnumericArray1M.AssertModel(models[10],_testData[15], false);FlatDecimalnumericArray1M.AssertModel(models[11],_testData[16], false);FlatDecimalnumericArray1M.AssertModel(models[12],_testData[17], false);FlatDecimalnumericArray1M.AssertModel(models[13],_testData[18], false);FlatDecimalnumericArray1M.AssertModel(models[14],_testData[19], false);FlatDecimalnumericArray1M.AssertModel(models[15],_testData[20], false);FlatDecimalnumericArray1M.AssertModel(models[16],_testData[21], false);FlatDecimalnumericArray1M.AssertModel(models[17],_testData[22], false);FlatDecimalnumericArray1M.AssertModel(models[18],_testData[23], false);FlatDecimalnumericArray1M.AssertModel(models[19],_testData[24], false);FlatDecimalnumericArray1M.AssertModel(models[20],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[21],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[22],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[23],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
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
LEFT JOIN public.decimalnumericarray1mi mi ON mi.id = m.decimalnumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 41, query1, 10, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[9], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[10], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[11], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[12], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[13], false);FlatDecimalnumericArray1M.AssertModel(models[5],_testData[14], false);FlatDecimalnumericArray1M.AssertModel(models[6],_testData[15], false);FlatDecimalnumericArray1M.AssertModel(models[7],_testData[16], false);FlatDecimalnumericArray1M.AssertModel(models[8],_testData[17], false);FlatDecimalnumericArray1M.AssertModel(models[9],_testData[18], false);FlatDecimalnumericArray1M.AssertModel(models[10],_testData[19], false);FlatDecimalnumericArray1M.AssertModel(models[11],_testData[20], false);FlatDecimalnumericArray1M.AssertModel(models[12],_testData[21], false);FlatDecimalnumericArray1M.AssertModel(models[13],_testData[22], false);FlatDecimalnumericArray1M.AssertModel(models[14],_testData[23], false);FlatDecimalnumericArray1M.AssertModel(models[15],_testData[24], false);FlatDecimalnumericArray1M.AssertModel(models[16],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[17],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[18],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[19],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatDecimalnumericArray1M.AssertModel(models[0],_testData[2], false);FlatDecimalnumericArray1M.AssertModel(models[1],_testData[3], false);FlatDecimalnumericArray1M.AssertModel(models[2],_testData[4], false);FlatDecimalnumericArray1M.AssertModel(models[3],_testData[5], false);FlatDecimalnumericArray1M.AssertModel(models[4],_testData[6], false);FlatDecimalnumericArray1M.AssertModel(models[5],_testData[7], false);FlatDecimalnumericArray1M.AssertModel(models[6],_testData[8], false);FlatDecimalnumericArray1M.AssertModel(models[7],_testData[9], false);FlatDecimalnumericArray1M.AssertModel(models[8],_testData[10], false);FlatDecimalnumericArray1M.AssertModel(models[9],_testData[11], false);FlatDecimalnumericArray1M.AssertModel(models[10],_testData[12], false);FlatDecimalnumericArray1M.AssertModel(models[11],_testData[13], false);FlatDecimalnumericArray1M.AssertModel(models[12],_testData[14], false);FlatDecimalnumericArray1M.AssertModel(models[13],_testData[15], false);FlatDecimalnumericArray1M.AssertModel(models[14],_testData[16], false);FlatDecimalnumericArray1M.AssertModel(models[15],_testData[17], false);FlatDecimalnumericArray1M.AssertModel(models[16],_testData[18], false);FlatDecimalnumericArray1M.AssertModel(models[17],_testData[19], false);FlatDecimalnumericArray1M.AssertModel(models[18],_testData[20], false);FlatDecimalnumericArray1M.AssertModel(models[19],_testData[21], false);FlatDecimalnumericArray1M.AssertModel(models[20],_testData[22], false);FlatDecimalnumericArray1M.AssertModel(models[21],_testData[23], false);FlatDecimalnumericArray1M.AssertModel(models[22],_testData[24], false);FlatDecimalnumericArray1M.AssertModel(models[23],_testData[25], false);FlatDecimalnumericArray1M.AssertModel(models[24],_testData[26], false);FlatDecimalnumericArray1M.AssertModel(models[25],_testData[27], false);FlatDecimalnumericArray1M.AssertModel(models[26],_testData[28], false);FlatDecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSelectModelBatchAsync(connection, 107, 54))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
DecimalnumericArray1M.AssertModel(models[0],_testData[20], false);DecimalnumericArray1M.AssertModel(models[1],_testData[21], false);DecimalnumericArray1M.AssertModel(models[2],_testData[22], false);DecimalnumericArray1M.AssertModel(models[3],_testData[23], false);DecimalnumericArray1M.AssertModel(models[4],_testData[24], false);DecimalnumericArray1M.AssertModel(models[5],_testData[25], false);DecimalnumericArray1M.AssertModel(models[6],_testData[26], false);DecimalnumericArray1M.AssertModel(models[7],_testData[27], false);DecimalnumericArray1M.AssertModel(models[8],_testData[28], false);DecimalnumericArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
DecimalnumericArray1M.AssertModel(models[0],_testData[11], false);DecimalnumericArray1M.AssertModel(models[1],_testData[12], false);DecimalnumericArray1M.AssertModel(models[2],_testData[13], false);DecimalnumericArray1M.AssertModel(models[3],_testData[14], false);DecimalnumericArray1M.AssertModel(models[4],_testData[15], false);DecimalnumericArray1M.AssertModel(models[5],_testData[16], false);DecimalnumericArray1M.AssertModel(models[6],_testData[17], false);DecimalnumericArray1M.AssertModel(models[7],_testData[18], false);DecimalnumericArray1M.AssertModel(models[8],_testData[19], false);DecimalnumericArray1M.AssertModel(models[9],_testData[20], false);DecimalnumericArray1M.AssertModel(models[10],_testData[21], false);DecimalnumericArray1M.AssertModel(models[11],_testData[22], false);DecimalnumericArray1M.AssertModel(models[12],_testData[23], false);DecimalnumericArray1M.AssertModel(models[13],_testData[24], false);DecimalnumericArray1M.AssertModel(models[14],_testData[25], false);DecimalnumericArray1M.AssertModel(models[15],_testData[26], false);DecimalnumericArray1M.AssertModel(models[16],_testData[27], false);DecimalnumericArray1M.AssertModel(models[17],_testData[28], false);DecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((IDecimalArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSelectModelBatch(connection, 78, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
DecimalnumericArray1M.AssertModel(models[0],_testData[15], false);DecimalnumericArray1M.AssertModel(models[1],_testData[16], false);DecimalnumericArray1M.AssertModel(models[2],_testData[17], false);DecimalnumericArray1M.AssertModel(models[3],_testData[18], false);DecimalnumericArray1M.AssertModel(models[4],_testData[19], false);DecimalnumericArray1M.AssertModel(models[5],_testData[20], false);DecimalnumericArray1M.AssertModel(models[6],_testData[21], false);DecimalnumericArray1M.AssertModel(models[7],_testData[22], false);DecimalnumericArray1M.AssertModel(models[8],_testData[23], false);DecimalnumericArray1M.AssertModel(models[9],_testData[24], false);DecimalnumericArray1M.AssertModel(models[10],_testData[25], false);DecimalnumericArray1M.AssertModel(models[11],_testData[26], false);DecimalnumericArray1M.AssertModel(models[12],_testData[27], false);DecimalnumericArray1M.AssertModel(models[13],_testData[28], false);DecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
DecimalnumericArray1M.AssertModel(models[0],_testData[7], false);DecimalnumericArray1M.AssertModel(models[1],_testData[8], false);DecimalnumericArray1M.AssertModel(models[2],_testData[9], false);DecimalnumericArray1M.AssertModel(models[3],_testData[10], false);DecimalnumericArray1M.AssertModel(models[4],_testData[11], false);DecimalnumericArray1M.AssertModel(models[5],_testData[12], false);DecimalnumericArray1M.AssertModel(models[6],_testData[13], false);DecimalnumericArray1M.AssertModel(models[7],_testData[14], false);DecimalnumericArray1M.AssertModel(models[8],_testData[15], false);DecimalnumericArray1M.AssertModel(models[9],_testData[16], false);DecimalnumericArray1M.AssertModel(models[10],_testData[17], false);DecimalnumericArray1M.AssertModel(models[11],_testData[18], false);DecimalnumericArray1M.AssertModel(models[12],_testData[19], false);DecimalnumericArray1M.AssertModel(models[13],_testData[20], false);DecimalnumericArray1M.AssertModel(models[14],_testData[21], false);DecimalnumericArray1M.AssertModel(models[15],_testData[22], false);DecimalnumericArray1M.AssertModel(models[16],_testData[23], false);DecimalnumericArray1M.AssertModel(models[17],_testData[24], false);DecimalnumericArray1M.AssertModel(models[18],_testData[25], false);DecimalnumericArray1M.AssertModel(models[19],_testData[26], false);DecimalnumericArray1M.AssertModel(models[20],_testData[27], false);DecimalnumericArray1M.AssertModel(models[21],_testData[28], false);DecimalnumericArray1M.AssertModel(models[22],_testData[29], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
DecimalnumericArray1M.AssertModel(models[0],_testData[11], false);DecimalnumericArray1M.AssertModel(models[1],_testData[12], false);DecimalnumericArray1M.AssertModel(models[2],_testData[13], false);DecimalnumericArray1M.AssertModel(models[3],_testData[14], false);DecimalnumericArray1M.AssertModel(models[4],_testData[15], false);DecimalnumericArray1M.AssertModel(models[5],_testData[16], false);DecimalnumericArray1M.AssertModel(models[6],_testData[17], false);DecimalnumericArray1M.AssertModel(models[7],_testData[18], false);DecimalnumericArray1M.AssertModel(models[8],_testData[19], false);DecimalnumericArray1M.AssertModel(models[9],_testData[20], false);DecimalnumericArray1M.AssertModel(models[10],_testData[21], false);DecimalnumericArray1M.AssertModel(models[11],_testData[22], false);DecimalnumericArray1M.AssertModel(models[12],_testData[23], false);DecimalnumericArray1M.AssertModel(models[13],_testData[24], false);DecimalnumericArray1M.AssertModel(models[14],_testData[25], false);DecimalnumericArray1M.AssertModel(models[15],_testData[26], false);DecimalnumericArray1M.AssertModel(models[16],_testData[27], false);DecimalnumericArray1M.AssertModel(models[17],_testData[28], false);DecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
DecimalnumericArray1M.AssertModel(models[0],_testData[7], false);DecimalnumericArray1M.AssertModel(models[1],_testData[8], false);DecimalnumericArray1M.AssertModel(models[2],_testData[9], false);DecimalnumericArray1M.AssertModel(models[3],_testData[10], false);DecimalnumericArray1M.AssertModel(models[4],_testData[11], false);DecimalnumericArray1M.AssertModel(models[5],_testData[12], false);DecimalnumericArray1M.AssertModel(models[6],_testData[13], false);DecimalnumericArray1M.AssertModel(models[7],_testData[14], false);DecimalnumericArray1M.AssertModel(models[8],_testData[15], false);DecimalnumericArray1M.AssertModel(models[9],_testData[16], false);DecimalnumericArray1M.AssertModel(models[10],_testData[17], false);DecimalnumericArray1M.AssertModel(models[11],_testData[18], false);DecimalnumericArray1M.AssertModel(models[12],_testData[19], false);DecimalnumericArray1M.AssertModel(models[13],_testData[20], false);DecimalnumericArray1M.AssertModel(models[14],_testData[21], false);DecimalnumericArray1M.AssertModel(models[15],_testData[22], false);DecimalnumericArray1M.AssertModel(models[16],_testData[23], false);DecimalnumericArray1M.AssertModel(models[17],_testData[24], false);DecimalnumericArray1M.AssertModel(models[18],_testData[25], false);DecimalnumericArray1M.AssertModel(models[19],_testData[26], false);DecimalnumericArray1M.AssertModel(models[20],_testData[27], false);DecimalnumericArray1M.AssertModel(models[21],_testData[28], false);DecimalnumericArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(DecimalnumericArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray1M>(15);

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
                ((IDecimalArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray1M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalArraynumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericArray1M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[14], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[15], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[16], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[17], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[20],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[21],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[22],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[23],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[24],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[25],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[26],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[27],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[28],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

