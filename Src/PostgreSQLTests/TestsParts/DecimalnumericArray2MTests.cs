

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region TestData

        private readonly DecimalnumericArray2M[] _testData = new DecimalnumericArray2M[]
        {
            new DecimalnumericArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.421877200244384m,

0.902790328465914m,

0.865642000209409m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.585779891998798m,

0.787096493487675m,

0.228999435481445m,

0.4166179983551m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.521756428218892m,

0.332899787965692m,

0.900267289712425m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132551988823365m,

0.00266879426992506m,

0.234261466559092m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.393652896929639m,

0.00443165873656548m,

0.469995957033082m,

},
},
            new DecimalnumericArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.476247182851582m,

0.113201223581746m,

0.124193491712061m,

0.876581221258686m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.690134874150344m,

0.573886902837378m,

0.607389073221748m,

0.409260527868753m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.355772546249356m,

0.937083666768062m,

0.564620797100502m,

0.878334937406424m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.926104021037107m,

0.134496537466054m,

0.960038275261065m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.397319239748037m,

0.57405834762519m,

0.937671497795736m,

0.889596259484678m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.098767510419983m,

0.802505002771154m,

0.480839899259587m,

},
},
            new DecimalnumericArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.679269361014117m,

0.172708563468385m,

0.851922142380782m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.206325130744734m,

0.215207693353036m,

0.0530135286665086m,

0.338612852911801m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.578184819266973m,

0.87505945094286m,

0.393466053293071m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.856673900850567m,

0.875459416879919m,

0.128033458496107m,

0.223510078004032m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.773287072216334m,

0.712716444972704m,

0.632661514884283m,

0.0727011559126742m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.220727295771321m,

0.258624580742774m,

0.946794793166685m,

0.535900144287259m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.150189439123149m,

0.0809750959077648m,

0.740431124760191m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.214398282307341m,

0.651961358064617m,

0.793077407679924m,

0.567813067100067m,

},
},
            new DecimalnumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.317396146474341m,

0.634332586454284m,

0.591906742725592m,

0.947504027282221m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.587345405438269m,

0.687365536736625m,

0.867917795405396m,

0.0646126898960777m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561561330641858m,

0.132036462028569m,

0.612089283884832m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0300897631771979m,

0.48732498265944m,

0.701194047936231m,

0.793752720477324m,

},
},
            new DecimalnumericArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.70212201964996m,

0.290656419287774m,

0.600573432501274m,

0.436913702941606m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.111249363882682m,

0.499514708112671m,

0.177452086025671m,

0.748395553946658m,

},
},
            new DecimalnumericArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.696740657322018m,

0.515128050373264m,

0.887963570578874m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.402011952085118m,

0.401681698058299m,

0.554713006600633m,

0.664785571009067m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.274595692067943m,

0.61890979236373m,

0.574303147408824m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.168703792051401m,

0.906262025645094m,

0.469303049563166m,

0.0986972816240814m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.245976926978467m,

0.129538747463392m,

0.0219633526676704m,

0.292774802936602m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.339497957408464m,

0.685908826757987m,

0.144757205583493m,

0.610540302369441m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.370428278708828m,

0.217581046635998m,

0.173376224298118m,

},
},
            new DecimalnumericArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.569302698422986m,

0.504070753697918m,

0.118017884125497m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.377377386917941m,

0.417056127909738m,

0.578195491814801m,

},
},
            new DecimalnumericArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.5178727933007m,

0.963828405916222m,

0.598866200781259m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.207793382300256m,

0.643609173788211m,

0.512631264484982m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.75590592467775m,

0.517662530708767m,

0.613255392945245m,

0.0446309663998475m,

},
},
            new DecimalnumericArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.520589573566668m,

0.846381472561292m,

0.996862951349404m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.519396354570569m,

0.569507508303495m,

0.0200116435545018m,

0.518891345104572m,

},
},
            new DecimalnumericArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.173798207792743m,

0.794462683314356m,

0.604396419310675m,

0.142778882379922m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.260389432782985m,

0.383386947627374m,

0.576559427855015m,

0.96772860669016m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.137567909080703m,

0.493240000957382m,

0.477568769728488m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.950420504265329m,

0.356717383762442m,

0.139079117011142m,

},
},
            new DecimalnumericArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.164461232651281m,

0.658019355928076m,

0.823656492199734m,

0.214344674880664m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.402074789903263m,

0.947916715646413m,

0.938808442381802m,

0.546056725217852m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.18068146395655m,

0.485378370584504m,

0.51571800864903m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.441477712008959m,

0.106936484765837m,

0.436857055308363m,

0.0348889090983463m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.610602535025305m,

0.938434609456337m,

0.94284613940107m,

0.269222610985945m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.674219562254442m,

0.362834703558764m,

0.930191025562214m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.23530684408616m,

0.331896302046201m,

0.224390666485576m,

0.00802403046901501m,

},
},
            new DecimalnumericArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.196534716111945m,

0.14795317005676m,

0.830328610660032m,

0.235348624150355m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.207294603889758m,

0.664517024269438m,

0.469592595585345m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.897324526974016m,

0.631792017343271m,

0.917891672910616m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.652306812407188m,

0.633469024044493m,

0.0301026656101913m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.539320934035544m,

0.219204751031506m,

0.980795538997646m,

0.0962795318690789m,

},
},
            new DecimalnumericArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.93447916638975m,

0.455011808621666m,

0.162291684634364m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.710864136730743m,

0.888171972432497m,

0.316969252482593m,

0.789688138484005m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.728177874001754m,

0.871112275973152m,

0.0129643189125564m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.26246203873242m,

0.5602733758637m,

0.0767241103268419m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.553728553201119m,

0.766822292893137m,

0.571741472297768m,

},
},
            new DecimalnumericArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.586071351957651m,

0.707885612249793m,

0.258545160349947m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.485298024262235m,

0.421906282244878m,

0.0530978242989872m,

},
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)), 
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
                methodParametrName: "decimalnumericarray2mi_id", 
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
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                methodParametrName: "decimalnumericarray2mi_id", 
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
                List<DecimalnumericArray2M> models = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<DecimalnumericArray2M> models = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDecimalListnumericArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDecimalListnumericArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 103;
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[29], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 3;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[1], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M), typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                await((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 76, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 121, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDecimalnumericArray2M>();
                var models2 = new List<FlatDecimalnumericArray2M>();
                ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var firstItems2 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 60, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 110, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 14, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[29], false);
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 125, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[29], false);
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
FROM public.decimalnumericarray2m m
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
FROM public.decimalnumericarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems1 = new List<FlatDecimalnumericArray2M>();
                var secondItems2 = new List<FlatDecimalnumericArray2M>();
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 60, query1, 117, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[29], false);
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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            asPartInterface: typeof(IDecimalListnumericArray)),
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
                var models = await((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[29], false);
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
                var models = ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    DecimalnumericArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 20, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[29], false);
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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
DecimalnumericArray2M.AssertModel(models[0],_testData[7], false);DecimalnumericArray2M.AssertModel(models[1],_testData[8], false);DecimalnumericArray2M.AssertModel(models[2],_testData[9], false);DecimalnumericArray2M.AssertModel(models[3],_testData[10], false);DecimalnumericArray2M.AssertModel(models[4],_testData[11], false);DecimalnumericArray2M.AssertModel(models[5],_testData[12], false);DecimalnumericArray2M.AssertModel(models[6],_testData[13], false);DecimalnumericArray2M.AssertModel(models[7],_testData[14], false);DecimalnumericArray2M.AssertModel(models[8],_testData[15], false);DecimalnumericArray2M.AssertModel(models[9],_testData[16], false);DecimalnumericArray2M.AssertModel(models[10],_testData[17], false);DecimalnumericArray2M.AssertModel(models[11],_testData[18], false);DecimalnumericArray2M.AssertModel(models[12],_testData[19], false);DecimalnumericArray2M.AssertModel(models[13],_testData[20], false);DecimalnumericArray2M.AssertModel(models[14],_testData[21], false);DecimalnumericArray2M.AssertModel(models[15],_testData[22], false);DecimalnumericArray2M.AssertModel(models[16],_testData[23], false);DecimalnumericArray2M.AssertModel(models[17],_testData[24], false);DecimalnumericArray2M.AssertModel(models[18],_testData[25], false);DecimalnumericArray2M.AssertModel(models[19],_testData[26], false);DecimalnumericArray2M.AssertModel(models[20],_testData[27], false);DecimalnumericArray2M.AssertModel(models[21],_testData[28], false);DecimalnumericArray2M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
DecimalnumericArray2M.AssertModel(models[0],_testData[4], false);DecimalnumericArray2M.AssertModel(models[1],_testData[5], false);DecimalnumericArray2M.AssertModel(models[2],_testData[6], false);DecimalnumericArray2M.AssertModel(models[3],_testData[7], false);DecimalnumericArray2M.AssertModel(models[4],_testData[8], false);DecimalnumericArray2M.AssertModel(models[5],_testData[9], false);DecimalnumericArray2M.AssertModel(models[6],_testData[10], false);DecimalnumericArray2M.AssertModel(models[7],_testData[11], false);DecimalnumericArray2M.AssertModel(models[8],_testData[12], false);DecimalnumericArray2M.AssertModel(models[9],_testData[13], false);DecimalnumericArray2M.AssertModel(models[10],_testData[14], false);DecimalnumericArray2M.AssertModel(models[11],_testData[15], false);DecimalnumericArray2M.AssertModel(models[12],_testData[16], false);DecimalnumericArray2M.AssertModel(models[13],_testData[17], false);DecimalnumericArray2M.AssertModel(models[14],_testData[18], false);DecimalnumericArray2M.AssertModel(models[15],_testData[19], false);DecimalnumericArray2M.AssertModel(models[16],_testData[20], false);DecimalnumericArray2M.AssertModel(models[17],_testData[21], false);DecimalnumericArray2M.AssertModel(models[18],_testData[22], false);DecimalnumericArray2M.AssertModel(models[19],_testData[23], false);DecimalnumericArray2M.AssertModel(models[20],_testData[24], false);DecimalnumericArray2M.AssertModel(models[21],_testData[25], false);DecimalnumericArray2M.AssertModel(models[22],_testData[26], false);DecimalnumericArray2M.AssertModel(models[23],_testData[27], false);DecimalnumericArray2M.AssertModel(models[24],_testData[28], false);DecimalnumericArray2M.AssertModel(models[25],_testData[29], false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IDecimalListnumericArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new DecimalnumericArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IDecimalListnumericArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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
            asPartInterface: typeof(IDecimalListnumericArray))]
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<DecimalnumericArray2M>(15);

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
                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                DecimalnumericArray2M.AssertModel(models[0],_testData[0], false);
                DecimalnumericArray2M.AssertModel(models[1],_testData[1], false);
                DecimalnumericArray2M.AssertModel(models[2],_testData[2], false);
                DecimalnumericArray2M.AssertModel(models[3],_testData[3], false);
                DecimalnumericArray2M.AssertModel(models[4],_testData[4], false);
                DecimalnumericArray2M.AssertModel(models[5],_testData[5], false);
                DecimalnumericArray2M.AssertModel(models[6],_testData[6], false);
                DecimalnumericArray2M.AssertModel(models[7],_testData[7], false);
                DecimalnumericArray2M.AssertModel(models[8],_testData[8], false);
                DecimalnumericArray2M.AssertModel(models[9],_testData[9], false);
                DecimalnumericArray2M.AssertModel(models[10],_testData[10], false);
                DecimalnumericArray2M.AssertModel(models[11],_testData[11], false);
                DecimalnumericArray2M.AssertModel(models[12],_testData[12], false);
                DecimalnumericArray2M.AssertModel(models[13],_testData[13], false);
                DecimalnumericArray2M.AssertModel(models[14],_testData[14], false);
                DecimalnumericArray2M.AssertModel(models[15],_testData[15], false);
                DecimalnumericArray2M.AssertModel(models[16],_testData[16], false);
                DecimalnumericArray2M.AssertModel(models[17],_testData[17], false);
                DecimalnumericArray2M.AssertModel(models[18],_testData[18], false);
                DecimalnumericArray2M.AssertModel(models[19],_testData[19], false);
                DecimalnumericArray2M.AssertModel(models[20],_testData[20], false);
                DecimalnumericArray2M.AssertModel(models[21],_testData[21], false);
                DecimalnumericArray2M.AssertModel(models[22],_testData[22], false);
                DecimalnumericArray2M.AssertModel(models[23],_testData[23], false);
                DecimalnumericArray2M.AssertModel(models[24],_testData[24], false);
                DecimalnumericArray2M.AssertModel(models[25],_testData[25], false);
                DecimalnumericArray2M.AssertModel(models[26],_testData[26], false);
                DecimalnumericArray2M.AssertModel(models[27],_testData[27], false);
                DecimalnumericArray2M.AssertModel(models[28],_testData[28], false);
                DecimalnumericArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(DecimalnumericArray2M)],
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    DecimalnumericArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
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
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

