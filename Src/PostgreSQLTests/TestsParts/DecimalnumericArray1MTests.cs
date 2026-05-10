

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
    Id = 9,
    Value = 
new System.Decimal[3]
{
0.0573411265005245m,
0.754405479248596m,
0.0856261868077023m,
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
0.558818630694636m,
0.122447077007408m,
0.96086568628147m,
0.555938369264163m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 5,
    Value = 
new System.Decimal[3]
{
0.542637845147648m,
0.969711140686607m,
0.712427477733021m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.10295891842812m,
0.670384102223292m,
0.554165136410876m,
},
},
            new DecimalnumericArray1M
{
    Id = 19,
    Value = 
new System.Decimal[3]
{
0.830432718500234m,
0.486283093533901m,
0.614454249522738m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 21,
    Value = 
new System.Decimal[4]
{
0.463754582509092m,
0.094069690519026m,
0.860775922453571m,
0.713856888517754m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 13,
    Value = 
new System.Decimal[3]
{
0.7478597522735m,
0.580685876476676m,
0.692819291266235m,
},
    NullableValue = 
new System.Decimal[4]
{
0.660005871839564m,
0.911641109568191m,
0.73965991026619m,
0.064898086630716m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.0151072637901677m,
0.785383344379254m,
0.462801178038144m,
0.999233189803928m,
},
},
            new DecimalnumericArray1M
{
    Id = 24,
    Value = 
new System.Decimal[4]
{
0.701621610510596m,
0.237272626090433m,
0.0502153353910008m,
0.648550586172494m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.258341773114229m,
0.913425170543432m,
0.958479151889185m,
0.384993813562156m,
},
},
            new DecimalnumericArray1M
{
    Id = 33,
    Value = 
new System.Decimal[3]
{
0.0486421109082856m,
0.453409500370484m,
0.676666017207632m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 20,
    Value = 
new System.Decimal[4]
{
0.233724270518821m,
0.837989697600024m,
0.697904778429505m,
0.298166068467526m,
},
    NullableValue = 
new System.Decimal[4]
{
0.366211606849469m,
0.548714154119469m,
0.782536830738434m,
0.281463214684471m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 40,
    Value = 
new System.Decimal[4]
{
0.785895777100544m,
0.00651005945492844m,
0.44910591328202m,
0.820204403325484m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.488765266410493m,
0.530703253398837m,
0.696694279694204m,
0.021949437131691m,
},
},
            new DecimalnumericArray1M
{
    Id = 43,
    Value = 
new System.Decimal[3]
{
0.980494841048206m,
0.969468929128709m,
0.553753954938325m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 27,
    Value = 
new System.Decimal[4]
{
0.256906222689268m,
0.393251742914767m,
0.326866172255155m,
0.365241337073141m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.28516286814243m,
0.408582081243667m,
0.716883201326793m,
0.946593369159531m,
},
},
            new DecimalnumericArray1M
{
    Id = 44,
    Value = 
new System.Decimal[4]
{
0.609860815036773m,
0.687374348576934m,
0.921555225472152m,
0.684761627011113m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.322599659725447m,
0.310456117458646m,
0.758608252330155m,
0.692875586932148m,
},
},
            new DecimalnumericArray1M
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.0611471087209929m,
0.825093786879723m,
0.0224034506203757m,
0.326439222384056m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 30,
    Value = 
new System.Decimal[3]
{
0.581892488342219m,
0.61981328918294m,
0.628628586292304m,
},
    NullableValue = 
new System.Decimal[3]
{
0.350177760411691m,
0.431689340273266m,
0.0371536530127924m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 55,
    Value = 
new System.Decimal[3]
{
0.587390393635348m,
0.172188481528962m,
0.129918510776562m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 58,
    Value = 
new System.Decimal[4]
{
0.0658427946036485m,
0.378998026194697m,
0.572818693336305m,
0.786283181909536m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 34,
    Value = 
new System.Decimal[3]
{
0.570921921795571m,
0.300795876900586m,
0.3519321239486m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 59,
    Value = 
new System.Decimal[4]
{
0.294115668573974m,
0.183617856020865m,
0.487626465410524m,
0.255004833119483m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.186418077257275m,
0.238771381087976m,
0.987930151419494m,
0.254598629629959m,
},
},
            new DecimalnumericArray1M
{
    Id = 65,
    Value = 
new System.Decimal[3]
{
0.179748854791325m,
0.605077074320557m,
0.501649159438835m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 39,
    Value = 
new System.Decimal[3]
{
0.199927552344335m,
0.910649986383526m,
0.197844729711984m,
},
    NullableValue = 
new System.Decimal[4]
{
0.895249070819393m,
0.379312084000599m,
0.796899547656944m,
0.871576691964173m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.441608248627368m,
0.587502191608894m,
0.805825513410807m,
},
},
            new DecimalnumericArray1M
{
    Id = 68,
    Value = 
new System.Decimal[3]
{
0.554393988417131m,
0.669746425975254m,
0.229103321291928m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 77,
    Value = 
new System.Decimal[3]
{
0.279468920493798m,
0.638517044459144m,
0.547048549385413m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 43,
    Value = 
new System.Decimal[4]
{
0.351984279218813m,
0.740683260934539m,
0.0992105611991253m,
0.345318815769935m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.38152074870643m,
0.315481475681613m,
0.994877385427624m,
},
},
            new DecimalnumericArray1M
{
    Id = 82,
    Value = 
new System.Decimal[3]
{
0.966584672349832m,
0.528260682933104m,
0.630991086129949m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.176600401565205m,
0.913401817106879m,
0.785340558048479m,
},
},
            new DecimalnumericArray1M
{
    Id = 84,
    Value = 
new System.Decimal[3]
{
0.903428040450048m,
0.897826232151644m,
0.847494178771305m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 44,
    Value = 
new System.Decimal[3]
{
0.967883293192679m,
0.104377096779664m,
0.283657442472176m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.0555542623899042m,
0.681562932971399m,
0.717358245979204m,
0.769283893236451m,
},
},
            new DecimalnumericArray1M
{
    Id = 85,
    Value = 
new System.Decimal[4]
{
0.0809024464833553m,
0.55485426793436m,
0.445989563188078m,
0.979882008860321m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.576421486823986m,
0.231043904617684m,
0.0278024035432775m,
},
},
            new DecimalnumericArray1M
{
    Id = 88,
    Value = 
new System.Decimal[4]
{
0.598368351349837m,
0.0161443282122677m,
0.137229334628037m,
0.624730647629851m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 53,
    Value = 
new System.Decimal[3]
{
0.214670721449187m,
0.341031200083444m,
0.000542981341650983m,
},
    NullableValue = 
new System.Decimal[3]
{
0.660182877984299m,
0.800276318789368m,
0.0106227936487203m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.886767441659925m,
0.0190029966123603m,
0.933433505724684m,
0.381960952194391m,
},
},
            new DecimalnumericArray1M
{
    Id = 94,
    Value = 
new System.Decimal[3]
{
0.3920605075644m,
0.168787765160567m,
0.885918478587855m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.940241989995723m,
0.824417950391408m,
0.731226113248709m,
},
},
            new DecimalnumericArray1M
{
    Id = 100,
    Value = 
new System.Decimal[3]
{
0.0238442654761287m,
0.361936732165467m,
0.912550864737199m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 55,
    Value = 
new System.Decimal[4]
{
0.10881437457661m,
0.301749920137432m,
0.401389462128614m,
0.151747825771931m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.382409501908883m,
0.303153245003773m,
0.146617944920657m,
},
},
            new DecimalnumericArray1M
{
    Id = 101,
    Value = 
new System.Decimal[4]
{
0.307925560747617m,
0.420985205447247m,
0.530074519112613m,
0.373992850522837m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.374776874204408m,
0.571082164160875m,
0.508403610867126m,
0.862702865821822m,
},
},
            new DecimalnumericArray1M
{
    Id = 109,
    Value = 
new System.Decimal[4]
{
0.0734249612943371m,
0.561329155077298m,
0.990819562392433m,
0.70725244320172m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 58,
    Value = 
new System.Decimal[3]
{
0.953049470414152m,
0.607650489959742m,
0.272338028864442m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 116,
    Value = 
new System.Decimal[4]
{
0.919040098523449m,
0.652901616780822m,
0.774984497627412m,
0.0603153082126515m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.686761935561134m,
0.267255493321373m,
0.568773369230006m,
},
},
            new DecimalnumericArray1M
{
    Id = 124,
    Value = 
new System.Decimal[3]
{
0.754489152302124m,
0.889617985082667m,
0.550529588137163m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 66,
    Value = 
new System.Decimal[4]
{
0.305602222425867m,
0.0947989547573528m,
0.745132216591046m,
0.79602728915817m,
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
0.22892893679939m,
0.798376207136555m,
0.0276242322436524m,
0.199676052142513m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.809907706029975m,
0.327023748929488m,
0.93902932469138m,
0.450927384117972m,
},
},
            new DecimalnumericArray1M
{
    Id = 139,
    Value = 
new System.Decimal[3]
{
0.833750209650538m,
0.994610840462142m,
0.0257425722817686m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 68,
    Value = 
new System.Decimal[3]
{
0.768772146586105m,
0.14814926255655m,
0.352608242368853m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.946392213790248m,
0.965660303608284m,
0.533453795583341m,
},
},
            new DecimalnumericArray1M
{
    Id = 145,
    Value = 
new System.Decimal[4]
{
0.145289606718342m,
0.730148164839578m,
0.7827962150975m,
0.796026420502931m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.466748103169233m,
0.790209595057212m,
0.110956645430023m,
0.864408042367538m,
},
},
            new DecimalnumericArray1M
{
    Id = 154,
    Value = 
new System.Decimal[3]
{
0.664922569781808m,
0.513840311160737m,
0.517284896673513m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 72,
    Value = 
new System.Decimal[4]
{
0.562319727703987m,
0.185832742370272m,
0.169113788178526m,
0.785969855817672m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 159,
    Value = 
new System.Decimal[4]
{
0.570452664438106m,
0.0469568442138691m,
0.242162160430409m,
0.133624141604836m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 165,
    Value = 
new System.Decimal[4]
{
0.837540572251921m,
0.955189709503313m,
0.630907963106012m,
0.134007827608036m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 81,
    Value = 
new System.Decimal[4]
{
0.481630513160188m,
0.138064060570548m,
0.589457401091212m,
0.17079594285981m,
},
    NullableValue = 
new System.Decimal[4]
{
0.784688608874441m,
0.694187164412118m,
0.438603970675584m,
0.603577047828759m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 171,
    Value = 
new System.Decimal[4]
{
0.337981616649278m,
0.904802398231031m,
0.592360453249898m,
0.412491864608012m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 173,
    Value = 
new System.Decimal[4]
{
0.390686519379519m,
0.103983295614534m,
0.865753384531141m,
0.906935871021484m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 88,
    Value = 
new System.Decimal[3]
{
0.407715777079799m,
0.656757291246067m,
0.412906250597137m,
},
    NullableValue = 
new System.Decimal[4]
{
0.107762054464669m,
0.283555162482459m,
0.25509235953337m,
0.476081260782478m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.728991282119213m,
0.521361904458796m,
0.560888305186849m,
0.305990913615622m,
},
},
            new DecimalnumericArray1M
{
    Id = 181,
    Value = 
new System.Decimal[4]
{
0.331562074145641m,
0.77381705122984m,
0.00901613858872386m,
0.301418035580889m,
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalArraynumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
0.258341773114229m,
0.913425170543432m,
0.958479151889185m,
0.384993813562156m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.488765266410493m,
0.530703253398837m,
0.696694279694204m,
0.021949437131691m,
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[4]
{
0.28516286814243m,
0.408582081243667m,
0.716883201326793m,
0.946593369159531m,
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
0.322599659725447m,
0.310456117458646m,
0.758608252330155m,
0.692875586932148m,
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalArraynumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[32],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 159;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[29],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[30],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[31],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[32],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 65, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 109, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 116, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 132, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 44, query1, 44, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

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
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 19, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[29],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[30],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 33, 84))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[25],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[26],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[27],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[34], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 68);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

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
                DecimalnumericArray1M.AssertModel(models[15],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[17],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[18],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 84);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                DecimalnumericArray1M.AssertModel(models[0],_testData[18], false);
                DecimalnumericArray1M.AssertModel(models[1],_testData[19], false);
                DecimalnumericArray1M.AssertModel(models[2],_testData[20], false);
                DecimalnumericArray1M.AssertModel(models[3],_testData[21], false);
                DecimalnumericArray1M.AssertModel(models[4],_testData[22], false);
                DecimalnumericArray1M.AssertModel(models[5],_testData[23], false);
                DecimalnumericArray1M.AssertModel(models[6],_testData[24], false);
                DecimalnumericArray1M.AssertModel(models[7],_testData[25], false);
                DecimalnumericArray1M.AssertModel(models[8],_testData[26], false);
                DecimalnumericArray1M.AssertModel(models[9],_testData[27], false);
                DecimalnumericArray1M.AssertModel(models[10],_testData[28], false);
                DecimalnumericArray1M.AssertModel(models[11],_testData[29], false);
                DecimalnumericArray1M.AssertModel(models[12],_testData[30], false);
                DecimalnumericArray1M.AssertModel(models[13],_testData[31], false);
                DecimalnumericArray1M.AssertModel(models[14],_testData[32], false);
                DecimalnumericArray1M.AssertModel(models[15],_testData[33], false);
                DecimalnumericArray1M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalArraynumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalArraynumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalArraynumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(DecimalnumericArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalArraynumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalArraynumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalArraynumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalArraynumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models = await ((IDecimalArraynumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray1mi
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
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI), typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models1 = new List<DecimalnumericArray1MI>();
                var models2 = new List<DecimalnumericArray1MI>();
                await ((IDecimalArraynumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MI>();
                var models2 = new List<DecimalnumericArray1MI>();
                ((IDecimalArraynumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray)),
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
                var models = await ((IDecimalArraynumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA), typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                await ((IDecimalArraynumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray1MIWA>();
                var models2 = new List<DecimalnumericArray1MIWA>();
                ((IDecimalArraynumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalArraynumericArray))]
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
                var models = await ((IDecimalArraynumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalArraynumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

