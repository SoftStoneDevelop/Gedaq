

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
new System.Decimal[3]
{
0.611381627859143m,
0.467688177194893m,
0.756640273440556m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 15,
    Value = 
new System.Decimal[4]
{
0.253584686360416m,
0.916300838815062m,
0.607072152076579m,
0.264328366750902m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 9,
    Value = 
new System.Decimal[4]
{
0.92277348786199m,
0.379948071192147m,
0.141277930799538m,
0.575500152143766m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.774690492960496m,
0.688254334531503m,
0.457090556726706m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 24,
    Value = 
new System.Decimal[3]
{
0.264447899661595m,
0.521693395874631m,
0.545564089059988m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 16,
    Value = 
new System.Decimal[3]
{
0.294707037862792m,
0.528752169950782m,
0.619184963141375m,
},
    NullableValue = 
new System.Decimal[4]
{
0.889172737330448m,
0.513034949017634m,
0.117621899028821m,
0.463176203757374m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.159673845673694m,
0.0777319956423312m,
0.145116193457638m,
},
},
            new DecimalnumericArray1M
{
    Id = 33,
    Value = 
new System.Decimal[4]
{
0.702823190181966m,
0.975230755957966m,
0.596860032714044m,
0.278625794340978m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 34,
    Value = 
new System.Decimal[4]
{
0.638129144715846m,
0.31958485826546m,
0.568757139745173m,
0.149028463397056m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 23,
    Value = 
new System.Decimal[3]
{
0.0780197461158781m,
0.794760446868694m,
0.317959131366376m,
},
    NullableValue = 
new System.Decimal[4]
{
0.487599549617003m,
0.319074195866812m,
0.0547159186418437m,
0.337092401170436m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.614364030911991m,
0.112870398092m,
0.18326964790123m,
},
},
            new DecimalnumericArray1M
{
    Id = 43,
    Value = 
new System.Decimal[3]
{
0.667526117156803m,
0.270105606820478m,
0.701489086829222m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 50,
    Value = 
new System.Decimal[4]
{
0.543527099746794m,
0.935774757388687m,
0.976652952514795m,
0.346602502909365m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 26,
    Value = 
new System.Decimal[3]
{
0.642043164879699m,
0.209398362477597m,
0.237815986192644m,
},
    NullableValue = 
new System.Decimal[3]
{
0.303760545333805m,
0.531365945548857m,
0.122235165101996m,
},
},
    NullableValue = 
new System.Decimal[4]
{
0.832356722426602m,
0.471083655090566m,
0.176491318257511m,
0.583587991975847m,
},
},
            new DecimalnumericArray1M
{
    Id = 51,
    Value = 
new System.Decimal[3]
{
0.00291349236736371m,
0.41408701125343m,
0.590144368043481m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.470757658341261m,
0.640911857914165m,
0.423260090071952m,
0.5042306809132m,
},
},
            new DecimalnumericArray1M
{
    Id = 60,
    Value = 
new System.Decimal[3]
{
0.0652571517086098m,
0.7606295869109m,
0.432412673844674m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 28,
    Value = 
new System.Decimal[4]
{
0.519234500476656m,
0.497725519640527m,
0.139457221422118m,
0.525759790595792m,
},
    NullableValue = 
new System.Decimal[4]
{
0.936393852399221m,
0.82121067355515m,
0.204386712827246m,
0.585121683209095m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 65,
    Value = 
new System.Decimal[3]
{
0.192798830111556m,
0.349226162971728m,
0.640426015223824m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.657556267051734m,
0.458629741921869m,
0.682422238116284m,
},
},
            new DecimalnumericArray1M
{
    Id = 70,
    Value = 
new System.Decimal[3]
{
0.743795259453599m,
0.39318605064846m,
0.515372301994874m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 32,
    Value = 
new System.Decimal[3]
{
0.0185797875160493m,
0.582504939877835m,
0.326094884115664m,
},
    NullableValue = 
new System.Decimal[3]
{
0.495538265050478m,
0.669396606169423m,
0.119987801271348m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.550446018260705m,
0.364497631221395m,
0.840881309135303m,
},
},
            new DecimalnumericArray1M
{
    Id = 75,
    Value = 
new System.Decimal[3]
{
0.986179854810578m,
0.682252025324711m,
0.440304076388243m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.133854259170917m,
0.781174590295644m,
0.632088646309101m,
0.761842005300978m,
},
},
            new DecimalnumericArray1M
{
    Id = 81,
    Value = 
new System.Decimal[4]
{
0.132378472745851m,
0.764408038612974m,
0.939178713058257m,
0.61373605107448m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 41,
    Value = 
new System.Decimal[4]
{
0.0396857909430522m,
0.715900774990531m,
0.637907860045429m,
0.414694172997381m,
},
    NullableValue = 
new System.Decimal[4]
{
0.165893347315525m,
0.113417490452736m,
0.445090931794164m,
0.258647559215796m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 89,
    Value = 
new System.Decimal[4]
{
0.579923607280539m,
0.104435697396244m,
0.615763761444382m,
0.616964871931531m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.595639377742928m,
0.493916915523237m,
0.823900768419355m,
},
},
            new DecimalnumericArray1M
{
    Id = 96,
    Value = 
new System.Decimal[4]
{
0.275348906750765m,
0.444055210047001m,
0.901823293750118m,
0.965455393144231m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 49,
    Value = 
new System.Decimal[4]
{
0.0838794887694735m,
0.332763492543672m,
0.977469638174588m,
0.312742024429501m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.998283899749986m,
0.369906292365716m,
0.132189063093393m,
0.971562868589309m,
},
},
            new DecimalnumericArray1M
{
    Id = 105,
    Value = 
new System.Decimal[4]
{
0.0233732241113349m,
0.529566624160272m,
0.827361423771139m,
0.321783678578056m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 110,
    Value = 
new System.Decimal[3]
{
0.688515649311258m,
0.0862639666163717m,
0.677517077782637m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 51,
    Value = 
new System.Decimal[3]
{
0.383275603417922m,
0.946327105483881m,
0.133238647204405m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.715449399798936m,
0.149399167470786m,
0.0590501970760883m,
0.978327903639051m,
},
},
            new DecimalnumericArray1M
{
    Id = 116,
    Value = 
new System.Decimal[3]
{
0.0879733959055128m,
0.782437735514509m,
0.438298063810775m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 124,
    Value = 
new System.Decimal[3]
{
0.746407156460496m,
0.901009421114305m,
0.270935709913081m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 56,
    Value = 
new System.Decimal[4]
{
0.199259526260911m,
0.134327926982798m,
0.0181917226014436m,
0.773752666564444m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[4]
{
0.448304544547379m,
0.261106546601966m,
0.146535304575337m,
0.758843429787662m,
},
},
            new DecimalnumericArray1M
{
    Id = 133,
    Value = 
new System.Decimal[3]
{
0.992407241078089m,
0.376752456307159m,
0.0263240738466982m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.868031427133567m,
0.894324720667386m,
0.517837404520781m,
0.448262885056797m,
},
},
            new DecimalnumericArray1M
{
    Id = 140,
    Value = 
new System.Decimal[3]
{
0.800165706756247m,
0.378007647110771m,
0.282999289119445m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 59,
    Value = 
new System.Decimal[3]
{
0.155714746758048m,
0.663352508892672m,
0.0272021323735567m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 149,
    Value = 
new System.Decimal[3]
{
0.519327149183655m,
0.791951068631745m,
0.670501551234755m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.475379480501627m,
0.818693947522712m,
0.479182014001603m,
0.452945624166719m,
},
},
            new DecimalnumericArray1M
{
    Id = 152,
    Value = 
new System.Decimal[4]
{
0.308800588597649m,
0.192459340897168m,
0.696016388914224m,
0.779476688575461m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 67,
    Value = 
new System.Decimal[3]
{
0.58225595629459m,
0.138752164598124m,
0.347326796519184m,
},
    NullableValue = 
new System.Decimal[3]
{
0.370283896577515m,
0.186515387105378m,
0.885668622043491m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 157,
    Value = 
new System.Decimal[4]
{
0.00735230999012837m,
0.139567571638145m,
0.545221267117913m,
0.0606154010425561m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.971702522086016m,
0.970255449011468m,
0.499046364543388m,
0.801301561634847m,
},
},
            new DecimalnumericArray1M
{
    Id = 164,
    Value = 
new System.Decimal[3]
{
0.599193140059928m,
0.0612341267830852m,
0.43714332764503m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 74,
    Value = 
new System.Decimal[3]
{
0.343189859694126m,
0.909778216043592m,
0.905937716478094m,
},
    NullableValue = 
new System.Decimal[3]
{
0.653567472841454m,
0.711968785729914m,
0.44786329643594m,
},
},
    NullableValue = 
new System.Decimal[3]
{
0.569615894834557m,
0.498831396757242m,
0.88753301419635m,
},
},
            new DecimalnumericArray1M
{
    Id = 169,
    Value = 
new System.Decimal[3]
{
0.445859030334832m,
0.230361035501417m,
0.992028924234448m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.150147874563323m,
0.146444384392327m,
0.787337849530356m,
0.0886325444952107m,
},
},
            new DecimalnumericArray1M
{
    Id = 171,
    Value = 
new System.Decimal[3]
{
0.681429817232419m,
0.990661606071619m,
0.444412490622809m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 76,
    Value = 
new System.Decimal[4]
{
0.270447712344898m,
0.707713916224446m,
0.030120583288433m,
0.233929261556738m,
},
    NullableValue = 
new System.Decimal[4]
{
0.849999577507748m,
0.0214774629746389m,
0.989038750731879m,
0.260884068157722m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 177,
    Value = 
new System.Decimal[3]
{
0.895970647725814m,
0.775281541459051m,
0.910773860888586m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[3]
{
0.615614295662141m,
0.522535669582111m,
0.793611380914294m,
},
},
            new DecimalnumericArray1M
{
    Id = 184,
    Value = 
new System.Decimal[3]
{
0.344131432507128m,
0.391363128588882m,
0.182624818546982m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 79,
    Value = 
new System.Decimal[3]
{
0.551228979415753m,
0.342555958733677m,
0.904860493344444m,
},
    NullableValue = null,
},
    NullableValue = 
new System.Decimal[3]
{
0.905936461222929m,
0.991114785659495m,
0.749857390030318m,
},
},
            new DecimalnumericArray1M
{
    Id = 186,
    Value = 
new System.Decimal[3]
{
0.00900391714422755m,
0.41579945029579m,
0.258652906428249m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 188,
    Value = 
new System.Decimal[4]
{
0.57601274788385m,
0.642057654623347m,
0.397348043552391m,
0.829494204171808m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 86,
    Value = 
new System.Decimal[4]
{
0.0828975188133927m,
0.518057796060854m,
0.0329759217346189m,
0.636334847556722m,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 195,
    Value = 
new System.Decimal[3]
{
0.955993738384339m,
0.640856836271782m,
0.286629996864905m,
},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 203,
    Value = 
new System.Decimal[4]
{
0.244413227943504m,
0.921700349490506m,
0.0144673365184608m,
0.257840978262681m,
},
    ModelInner = new DecimalnumericArray1MI
{
    Id = 89,
    Value = 
new System.Decimal[4]
{
0.8552039455202m,
0.812691787899495m,
0.455289662767399m,
0.379948144642011m,
},
    NullableValue = 
new System.Decimal[3]
{
0.300535740541375m,
0.895488780470432m,
0.653312973171878m,
},
},
    NullableValue = null,
},
            new DecimalnumericArray1M
{
    Id = 207,
    Value = 
new System.Decimal[3]
{
0.537592117774639m,
0.209069699765405m,
0.575017292710399m,
},
    ModelInner = null,
    NullableValue = 
new System.Decimal[4]
{
0.411692292144093m,
0.6812514246769m,
0.92798073488967m,
0.678670190807996m,
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
new System.Decimal[3]
{
0.614364030911991m,
0.112870398092m,
0.18326964790123m,
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
0.832356722426602m,
0.471083655090566m,
0.176491318257511m,
0.583587991975847m,
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
0.470757658341261m,
0.640911857914165m,
0.423260090071952m,
0.5042306809132m,
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
new System.Decimal[3]
{
0.657556267051734m,
0.458629741921869m,
0.682422238116284m,
}));
                nullable = await ((IDecimalArraynumericArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Decimal[3]
{
0.550446018260705m,
0.364497631221395m,
0.840881309135303m,
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 186;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[34], false);
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
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
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
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
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
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 65;
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
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[10], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 110, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 7, query1, 60, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IDecimalArraynumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 51, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 24, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 50, query1, 157, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[34], false);
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
                await ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 140, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 34, query1, 195, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[6], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[7], false);
                        FlatDecimalnumericArray1M.AssertModel(models[2],_testData[8], false);
                        FlatDecimalnumericArray1M.AssertModel(models[3],_testData[9], false);
                        FlatDecimalnumericArray1M.AssertModel(models[4],_testData[10], false);
                        FlatDecimalnumericArray1M.AssertModel(models[5],_testData[11], false);
                        FlatDecimalnumericArray1M.AssertModel(models[6],_testData[12], false);
                        FlatDecimalnumericArray1M.AssertModel(models[7],_testData[13], false);
                        FlatDecimalnumericArray1M.AssertModel(models[8],_testData[14], false);
                        FlatDecimalnumericArray1M.AssertModel(models[9],_testData[15], false);
                        FlatDecimalnumericArray1M.AssertModel(models[10],_testData[16], false);
                        FlatDecimalnumericArray1M.AssertModel(models[11],_testData[17], false);
                        FlatDecimalnumericArray1M.AssertModel(models[12],_testData[18], false);
                        FlatDecimalnumericArray1M.AssertModel(models[13],_testData[19], false);
                        FlatDecimalnumericArray1M.AssertModel(models[14],_testData[20], false);
                        FlatDecimalnumericArray1M.AssertModel(models[15],_testData[21], false);
                        FlatDecimalnumericArray1M.AssertModel(models[16],_testData[22], false);
                        FlatDecimalnumericArray1M.AssertModel(models[17],_testData[23], false);
                        FlatDecimalnumericArray1M.AssertModel(models[18],_testData[24], false);
                        FlatDecimalnumericArray1M.AssertModel(models[19],_testData[25], false);
                        FlatDecimalnumericArray1M.AssertModel(models[20],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(models[21],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(models[22],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(models[23],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(models[24],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(models[25],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(models[26],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(models[27],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericArray1M.AssertModel(models[0],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(models[1],_testData[34], false);
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
                 ((IDecimalArraynumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 16, query1, 164, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatDecimalnumericArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 50, 177))
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
                foreach(var batchResult in  ((IDecimalArraynumericArray)this).DbConnectionSTSelectModelBatch(connection, 16, 65))
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray1M.AssertModel(models[0],_testData[11], false);
                        DecimalnumericArray1M.AssertModel(models[1],_testData[12], false);
                        DecimalnumericArray1M.AssertModel(models[2],_testData[13], false);
                        DecimalnumericArray1M.AssertModel(models[3],_testData[14], false);
                        DecimalnumericArray1M.AssertModel(models[4],_testData[15], false);
                        DecimalnumericArray1M.AssertModel(models[5],_testData[16], false);
                        DecimalnumericArray1M.AssertModel(models[6],_testData[17], false);
                        DecimalnumericArray1M.AssertModel(models[7],_testData[18], false);
                        DecimalnumericArray1M.AssertModel(models[8],_testData[19], false);
                        DecimalnumericArray1M.AssertModel(models[9],_testData[20], false);
                        DecimalnumericArray1M.AssertModel(models[10],_testData[21], false);
                        DecimalnumericArray1M.AssertModel(models[11],_testData[22], false);
                        DecimalnumericArray1M.AssertModel(models[12],_testData[23], false);
                        DecimalnumericArray1M.AssertModel(models[13],_testData[24], false);
                        DecimalnumericArray1M.AssertModel(models[14],_testData[25], false);
                        DecimalnumericArray1M.AssertModel(models[15],_testData[26], false);
                        DecimalnumericArray1M.AssertModel(models[16],_testData[27], false);
                        DecimalnumericArray1M.AssertModel(models[17],_testData[28], false);
                        DecimalnumericArray1M.AssertModel(models[18],_testData[29], false);
                        DecimalnumericArray1M.AssertModel(models[19],_testData[30], false);
                        DecimalnumericArray1M.AssertModel(models[20],_testData[31], false);
                        DecimalnumericArray1M.AssertModel(models[21],_testData[32], false);
                        DecimalnumericArray1M.AssertModel(models[22],_testData[33], false);
                        DecimalnumericArray1M.AssertModel(models[23],_testData[34], false);
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
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 157);
                var models = await ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
DecimalnumericArray1M.AssertModel(models[0],_testData[25], false);DecimalnumericArray1M.AssertModel(models[1],_testData[26], false);DecimalnumericArray1M.AssertModel(models[2],_testData[27], false);DecimalnumericArray1M.AssertModel(models[3],_testData[28], false);DecimalnumericArray1M.AssertModel(models[4],_testData[29], false);DecimalnumericArray1M.AssertModel(models[5],_testData[30], false);DecimalnumericArray1M.AssertModel(models[6],_testData[31], false);DecimalnumericArray1M.AssertModel(models[7],_testData[32], false);DecimalnumericArray1M.AssertModel(models[8],_testData[33], false);DecimalnumericArray1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 60);
                var models =  ((IDecimalArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
DecimalnumericArray1M.AssertModel(models[0],_testData[10], false);DecimalnumericArray1M.AssertModel(models[1],_testData[11], false);DecimalnumericArray1M.AssertModel(models[2],_testData[12], false);DecimalnumericArray1M.AssertModel(models[3],_testData[13], false);DecimalnumericArray1M.AssertModel(models[4],_testData[14], false);DecimalnumericArray1M.AssertModel(models[5],_testData[15], false);DecimalnumericArray1M.AssertModel(models[6],_testData[16], false);DecimalnumericArray1M.AssertModel(models[7],_testData[17], false);DecimalnumericArray1M.AssertModel(models[8],_testData[18], false);DecimalnumericArray1M.AssertModel(models[9],_testData[19], false);DecimalnumericArray1M.AssertModel(models[10],_testData[20], false);DecimalnumericArray1M.AssertModel(models[11],_testData[21], false);DecimalnumericArray1M.AssertModel(models[12],_testData[22], false);DecimalnumericArray1M.AssertModel(models[13],_testData[23], false);DecimalnumericArray1M.AssertModel(models[14],_testData[24], false);DecimalnumericArray1M.AssertModel(models[15],_testData[25], false);DecimalnumericArray1M.AssertModel(models[16],_testData[26], false);DecimalnumericArray1M.AssertModel(models[17],_testData[27], false);DecimalnumericArray1M.AssertModel(models[18],_testData[28], false);DecimalnumericArray1M.AssertModel(models[19],_testData[29], false);DecimalnumericArray1M.AssertModel(models[20],_testData[30], false);DecimalnumericArray1M.AssertModel(models[21],_testData[31], false);DecimalnumericArray1M.AssertModel(models[22],_testData[32], false);DecimalnumericArray1M.AssertModel(models[23],_testData[33], false);DecimalnumericArray1M.AssertModel(models[24],_testData[34], false);
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635),
                (NpgsqlTypes.NpgsqlDbType)(-2147483635)
            },
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
            dbTypes: null,
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
            dbTypes: null,
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

