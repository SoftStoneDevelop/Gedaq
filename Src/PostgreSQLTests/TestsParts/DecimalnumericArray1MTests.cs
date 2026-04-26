

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
    Id = 7,
    Value = 
new System.Decimal[4]
{
0.255216768574398m,
0.941563311041733m,
0.30841033091113m,
0.884489528197645m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.453257167627666m,
0.383209028291213m,
0.367781853013694m,
},
},
            new DecimalnumericArray1M
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.106137331316277m,
0.541976191848061m,
0.646232893961086m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 1,
    Value = 
new System.Decimal[4]
{
0.359771980222009m,
0.927516954245148m,
0.377054023477637m,
0.347544701006674m,
},
    NullableValue = 
new System.Decimal[3]
{
0.22705535423236m,
0.0730975063784095m,
0.0343918754292163m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.284083931354366m,
0.0870257383820385m,
0.490809921233933m,
0.740205769083119m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.187577966574982m,
0.0946185720914795m,
0.281394693216796m,
0.188962800365799m,
},
},
            new DecimalnumericArray1M
{
    Id = 30,
    Value = 
new System.Decimal[3]
{
0.556588533781634m,
0.691415936185297m,
0.829439119826381m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 10,
    Value = 
new System.Decimal[4]
{
0.682861452827197m,
0.0921600024316477m,
0.00754700548724052m,
0.992844815268114m,
},
    NullableValue = 
new System.Decimal[4]
{
0.0907844771160972m,
0.765794775109844m,
0.66078771579045m,
0.438403988129517m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 36,
    Value = 
new System.Decimal[3]
{
0.158807685166907m,
0.736290943506149m,
0.224978926818524m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.821762757222246m,
0.903987422624636m,
0.444373413399172m,
0.845210915043086m,
},
},
            new DecimalnumericArray1M
{
    Id = 37,
    Value = 
new System.Decimal[3]
{
0.517274953119843m,
0.444245092509474m,
0.684765156400334m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 18,
    Value = 
new System.Decimal[4]
{
0.658863493046884m,
0.79537557390331m,
0.28221864717189m,
0.139799604866807m,
},
    NullableValue = 
new System.Decimal[3]
{
0.281480735276385m,
0.511864283567909m,
0.557601442351571m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 41,
    Value = 
new System.Decimal[4]
{
0.387896967784091m,
0.187132253218097m,
0.164792986382075m,
0.351135143272227m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 42,
    Value = 
new System.Decimal[3]
{
0.313327304277482m,
0.330432543325299m,
0.60932112102809m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 25,
    Value = 
new System.Decimal[3]
{
0.82199806129825m,
0.548959402085986m,
0.495140642203105m,
},
    NullableValue = 
new System.Decimal[3]
{
0.893436855392022m,
0.880212303627172m,
0.229156393697239m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.182022724087491m,
0.396719914974898m,
0.55462589219096m,
0.715924779957932m,
},
},
            new DecimalnumericArray1M
{
    Id = 44,
    Value = 
new System.Decimal[4]
{
0.524933709466575m,
0.627487135673073m,
0.842303860804707m,
0.893352368620236m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.727819585805755m,
0.80169817312795m,
0.95694438556681m,
0.117625093244483m,
},
},
            new DecimalnumericArray1M
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.727392250987803m,
0.429744322584229m,
0.520455566216034m,
0.84219086439669m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 27,
    Value = 
new System.Decimal[3]
{
0.770115585634724m,
0.0149056574488393m,
0.35207231307151m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 52,
    Value = 
new System.Decimal[3]
{
0.638235681102075m,
0.790786027336044m,
0.122688869472122m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.797252262244906m,
0.746614458119492m,
0.142200143288566m,
0.679095463790898m,
},
},
            new DecimalnumericArray1M
{
    Id = 58,
    Value = 
new System.Decimal[3]
{
0.143166474908644m,
0.83636726550962m,
0.175576969144206m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 30,
    Value = 
new System.Decimal[3]
{
0.40291681577709m,
0.515345660647791m,
0.824242678192439m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.390903895421115m,
0.226946322261039m,
0.463729915604386m,
0.814792021884067m,
},
},
            new DecimalnumericArray1M
{
    Id = 64,
    Value = 
new System.Decimal[3]
{
0.751049932785242m,
0.990458607802832m,
0.0472091751630446m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 68,
    Value = 
new System.Decimal[3]
{
0.0263304653696141m,
0.205191770469598m,
0.444962558312005m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 35,
    Value = 
new System.Decimal[4]
{
0.0946780333149988m,
0.304122211024729m,
0.399019720421367m,
0.510919074797754m,
},
    NullableValue = 
new System.Decimal[4]
{
0.951552367564624m,
0.366099207106087m,
0.727567580175546m,
0.912442873572678m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 73,
    Value = 
new System.Decimal[4]
{
0.192772807311866m,
0.906892197795744m,
0.249504563906725m,
0.0364635688155078m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 74,
    Value = 
new System.Decimal[4]
{
0.189847884168052m,
0.582599215491662m,
0.242515159303548m,
0.216092216015309m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 41,
    Value = 
new System.Decimal[4]
{
0.630956082534054m,
0.628889898784448m,
0.897031950653698m,
0.945268434641518m,
},
    NullableValue = 
new System.Decimal[4]
{
0.74773961905897m,
0.824577152145754m,
0.101798326039542m,
0.885339569905579m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 82,
    Value = 
new System.Decimal[3]
{
0.127668771370411m,
0.207290758846439m,
0.363086007387179m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.700420191184739m,
0.999215505387813m,
0.777203306611584m,
},
},
            new DecimalnumericArray1M
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.0497108459219114m,
0.933467825712456m,
0.417965158313185m,
0.921566267917178m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 43,
    Value = 
new System.Decimal[3]
{
0.996148139771488m,
0.244256256615997m,
0.602035585863561m,
},
    NullableValue = 
new System.Decimal[3]
{
0.704980969570402m,
0.427753273921882m,
0.483252339615686m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.925205696461972m,
0.58812805084434m,
0.753851945837056m,
},
},
            new DecimalnumericArray1M
{
    Id = 91,
    Value = 
new System.Decimal[3]
{
0.602035520288201m,
0.625038675014073m,
0.651107516786578m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 92,
    Value = 
new System.Decimal[3]
{
0.705137718486845m,
0.297226105055071m,
0.352673226819636m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 47,
    Value = 
new System.Decimal[3]
{
0.0964203527827164m,
0.033398156254428m,
0.465260335939427m,
},
    NullableValue = 
new System.Decimal[3]
{
0.207557837109445m,
0.410290791483318m,
0.0793487771713837m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.147779946207713m,
0.941223659797714m,
0.921114091808127m,
},
},
            new DecimalnumericArray1M
{
    Id = 93,
    Value = 
new System.Decimal[3]
{
0.761572524823806m,
0.685312266052892m,
0.431744526998634m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 95,
    Value = 
new System.Decimal[4]
{
0.500697944257302m,
0.247910374086027m,
0.477387846705697m,
0.131540059801178m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 54,
    Value = 
new System.Decimal[3]
{
0.591052435198072m,
0.911103504710778m,
0.859585711593166m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.126691601963037m,
0.214214842299521m,
0.0337538223296319m,
},
},
            new DecimalnumericArray1M
{
    Id = 100,
    Value = 
new System.Decimal[4]
{
0.247486651837051m,
0.45265294235133m,
0.674611463320484m,
0.554922074176446m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 101,
    Value = 
new System.Decimal[3]
{
0.980453492659242m,
0.620451562275364m,
0.355723472174337m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 56,
    Value = 
new System.Decimal[4]
{
0.404053887982428m,
0.486652185167626m,
0.986829012988231m,
0.801383239371046m,
},
    NullableValue = 
new System.Decimal[4]
{
0.905470959193669m,
0.94397437180835m,
0.409847596513908m,
0.459614801326649m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 106,
    Value = 
new System.Decimal[4]
{
0.170262237701248m,
0.618761836096207m,
0.567879803939312m,
0.756424776007428m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.164671363094218m,
0.0948407813829566m,
0.257918069162823m,
},
},
            new DecimalnumericArray1M
{
    Id = 110,
    Value = 
new System.Decimal[3]
{
0.823434595351294m,
0.657040873248446m,
0.541281104470293m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 61,
    Value = 
new System.Decimal[3]
{
0.798897578762748m,
0.206434870635631m,
0.962578973231701m,
},
    NullableValue = 
new System.Decimal[4]
{
0.727720284195406m,
0.578017512875517m,
0.0727948972994476m,
0.616321978321304m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.78841854145753m,
0.956661528102898m,
0.885010463904648m,
},
},
            new DecimalnumericArray1M
{
    Id = 117,
    Value = 
new System.Decimal[4]
{
0.391900129453212m,
0.287520273758017m,
0.0690134157835013m,
0.193678321958943m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 118,
    Value = 
new System.Decimal[4]
{
0.66255416921534m,
0.225090931048042m,
0.0722686434223999m,
0.190724958674726m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 64,
    Value = 
new System.Decimal[4]
{
0.344145904303005m,
0.45421673804452m,
0.132285425712413m,
0.582655226154742m,
},
    NullableValue = 
new System.Decimal[3]
{
0.468414250818018m,
0.93986148150445m,
0.577566512374526m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.856169334056985m,
0.659365201357714m,
0.968890738660017m,
0.943374036622371m,
},
},
            new DecimalnumericArray1M
{
    Id = 124,
    Value = 
new System.Decimal[3]
{
0.587582306446348m,
0.543134750549991m,
0.349884374848773m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.234666763285191m,
0.483183739916673m,
0.13509021846967m,
},
},
            new DecimalnumericArray1M
{
    Id = 132,
    Value = 
new System.Decimal[4]
{
0.93585127789708m,
0.159061336808301m,
0.920827448242187m,
0.420475737761517m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 73,
    Value = 
new System.Decimal[4]
{
0.0294579139961199m,
0.808923313335187m,
0.7797388762845m,
0.877368928019942m,
},
    NullableValue = 
new System.Decimal[3]
{
0.320117646194389m,
0.924702589301212m,
0.0105313455612636m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.253172076666006m,
0.197166869345323m,
0.814330444138394m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.821762757222246m,
0.903987422624636m,
0.444373413399172m,
0.845210915043086m,
}));
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.182022724087491m,
0.396719914974898m,
0.55462589219096m,
0.715924779957932m,
}));
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
0.727819585805755m,
0.80169817312795m,
0.95694438556681m,
0.117625093244483m,
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
0.797252262244906m,
0.746614458119492m,
0.142200143288566m,
0.679095463790898m,
}));
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.390903895421115m,
0.226946322261039m,
0.463729915604386m,
0.814792021884067m,
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDecimalArraynumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((IDecimalArraynumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
FROM public.decimalnumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
FROM public.decimalnumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 50;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[30], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[29], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M), typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                await((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 52, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 92, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray1M>();
                var models2 = new List<FlatDecimalnumericArray1M>();
                ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 52, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.decimalnumericarray1m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var firstItems2 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 91, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray1M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 44, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[30], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 42, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray1m m
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
FROM public.decimalnumericarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems1 = new List<FlatDecimalnumericArray1M>();
                var secondItems2 = new List<FlatDecimalnumericArray1M>();
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 95, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[30], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IDecimalArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 110, 64))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[29], false);
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
                var models = ((IDecimalArraynumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 100, 95))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[29], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 44);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
DecimalnumericArray1M.AssertModel(models[0],_testData[9], false);DecimalnumericArray1M.AssertModel(models[1],_testData[10], false);DecimalnumericArray1M.AssertModel(models[2],_testData[11], false);DecimalnumericArray1M.AssertModel(models[3],_testData[12], false);DecimalnumericArray1M.AssertModel(models[4],_testData[13], false);DecimalnumericArray1M.AssertModel(models[5],_testData[14], false);DecimalnumericArray1M.AssertModel(models[6],_testData[15], false);DecimalnumericArray1M.AssertModel(models[7],_testData[16], false);DecimalnumericArray1M.AssertModel(models[8],_testData[17], false);DecimalnumericArray1M.AssertModel(models[9],_testData[18], false);DecimalnumericArray1M.AssertModel(models[10],_testData[19], false);DecimalnumericArray1M.AssertModel(models[11],_testData[20], false);DecimalnumericArray1M.AssertModel(models[12],_testData[21], false);DecimalnumericArray1M.AssertModel(models[13],_testData[22], false);DecimalnumericArray1M.AssertModel(models[14],_testData[23], false);DecimalnumericArray1M.AssertModel(models[15],_testData[24], false);DecimalnumericArray1M.AssertModel(models[16],_testData[25], false);DecimalnumericArray1M.AssertModel(models[17],_testData[26], false);DecimalnumericArray1M.AssertModel(models[18],_testData[27], false);DecimalnumericArray1M.AssertModel(models[19],_testData[28], false);DecimalnumericArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
DecimalnumericArray1M.AssertModel(models[0],_testData[22], false);DecimalnumericArray1M.AssertModel(models[1],_testData[23], false);DecimalnumericArray1M.AssertModel(models[2],_testData[24], false);DecimalnumericArray1M.AssertModel(models[3],_testData[25], false);DecimalnumericArray1M.AssertModel(models[4],_testData[26], false);DecimalnumericArray1M.AssertModel(models[5],_testData[27], false);DecimalnumericArray1M.AssertModel(models[6],_testData[28], false);DecimalnumericArray1M.AssertModel(models[7],_testData[29], false);
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

