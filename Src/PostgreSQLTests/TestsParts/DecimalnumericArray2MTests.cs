

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.915998958459822m,

0.967558258634415m,

0.868710911580037m,

0.395481724157629m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.524846454918397m,

0.512350759496258m,

0.716647508195752m,

0.671957703744753m,

},
},
            new DecimalnumericArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.762660673390139m,

0.767590084712811m,

0.642743070033438m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.417581724163956m,

0.273462943551782m,

0.949657689448087m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.440182964605909m,

0.0918303010088834m,

0.00402031978503892m,

0.364989969769797m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.906659863208954m,

0.427425425905736m,

0.85787032672484m,

0.577592440363547m,

},
},
            new DecimalnumericArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.852538024222104m,

0.613286869346145m,

0.0368081247404048m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.852043488912956m,

0.670558590537232m,

0.0495069838588419m,

0.0632431160906566m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.292419866205784m,

0.96631407263511m,

0.034579807093706m,

0.432619364167868m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.12132644950235m,

0.274426701704387m,

0.018117845755657m,

},
},
            new DecimalnumericArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.89966506052245m,

0.184632828003485m,

0.200598262346924m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.106001671658364m,

0.778044354342384m,

0.254491401249551m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.13413888937498m,

0.57126633027394m,

0.0419417739454601m,

},
},
            new DecimalnumericArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.390997230586387m,

0.926743749511894m,

0.780762738368924m,

0.197787709771365m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.585516424369724m,

0.30230778426295m,

0.456774695534087m,

0.71704949950773m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.674210679951236m,

0.859253930608468m,

0.238486654774657m,

0.404584102726944m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.200082340275911m,

0.29028323520872m,

0.887605755098556m,

0.318525577327408m,

},
},
            new DecimalnumericArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.228539728285878m,

0.553743785584261m,

0.234217588849619m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.730522655584106m,

0.535106604275636m,

0.352380306145089m,

0.964356023990824m,

},
},
            new DecimalnumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.637254495000017m,

0.794729540226545m,

0.0798388633931954m,

0.68343406426031m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.487373911437945m,

0.542256925833225m,

0.465330237182282m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.163860554814923m,

0.535765400476431m,

0.0457425244550469m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.558742621982736m,

0.97461381359742m,

0.913668014505743m,

0.0967568154937286m,

},
},
            new DecimalnumericArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.669073411625722m,

0.713670194108173m,

0.193218084669241m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.545607358629029m,

0.306877826227698m,

0.542152948014526m,

0.712138836000295m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0649631110348677m,

0.835093461574827m,

0.704404662518466m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.361827283597481m,

0.122414287590798m,

0.144817728147121m,

},
},
            new DecimalnumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.111802863456163m,

0.788549392018274m,

0.448051769020466m,

0.468673028644886m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.143106644037809m,

0.426734131703378m,

0.108827076934917m,

0.329785913803423m,

},
},
            new DecimalnumericArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.594198405375038m,

0.721875124394941m,

0.884727371932284m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.487767432380196m,

0.0759366096295819m,

0.00246562576347176m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0283305953068387m,

0.70798737111201m,

0.43586773140463m,

0.937321775237469m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.780040991028084m,

0.389437728595116m,

0.364456211373708m,

0.968950988878066m,

},
},
            new DecimalnumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0114644854402037m,

0.991380080407358m,

0.0480356235427734m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.702744537282168m,

0.0874748886732587m,

0.810426217434128m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.530584591696497m,

0.577378708547847m,

0.0698825927874778m,

0.536882622035462m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0820797494458664m,

0.0430314599765134m,

0.0245904671773196m,

0.264148336439777m,

},
},
            new DecimalnumericArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.437632759326968m,

0.530097697686641m,

0.0920700464019227m,

0.539812455077061m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.959441747955818m,

0.188230734155163m,

0.673101582319433m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.274381115917344m,

0.480452645988169m,

0.287814689945928m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.529612727243907m,

0.327800003426326m,

0.50217759193627m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0266624946415752m,

0.294039107312306m,

0.80643121294737m,

0.763605497966027m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.363007301868811m,

0.945133248718779m,

0.337472486872577m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.121637312616333m,

0.66823771805549m,

0.846646317758715m,

0.40597850173439m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.947643923060302m,

0.0555637650575044m,

0.08857169910659m,

0.777258918941248m,

},
},
            new DecimalnumericArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.714065198145786m,

0.180779020674336m,

0.858149718719594m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.542170360651935m,

0.804835667813545m,

0.328205073240716m,

0.522288228206152m,

},
},
            new DecimalnumericArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.207349406214048m,

0.65004358172902m,

0.424688340345562m,

0.967802894988259m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.192856940417215m,

0.975364471783287m,

0.297616982413948m,

0.622755471452629m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.659712249079485m,

0.113047418636132m,

0.898857475346623m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.025194572425169m,

0.00108894440072238m,

0.0590275091339732m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.934686266086681m,

0.778911869842537m,

0.984177101357887m,

0.19014888127132m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.449187060110448m,

0.862101335642812m,

0.303259941431065m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.813007166899925m,

0.46533988050891m,

0.211330484436552m,

0.790562557869769m,

},
},
            new DecimalnumericArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.30196684178042m,

0.700189408120895m,

0.95694192927337m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.342971308060482m,

0.455085067186064m,

0.786955942895904m,

0.831519309724579m,

},
},
            new DecimalnumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.633026312093m,

0.771501459979524m,

0.298119340695335m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.78979878940405m,

0.434560915195832m,

0.681050969059248m,

0.330733331935179m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.849501601761129m,

0.355332365948627m,

0.813772054658921m,

0.920170681423185m,

},
},
            new DecimalnumericArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541221485546012m,

0.50301302977132m,

0.835889726798262m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0389465783207012m,

0.145125669265646m,

0.017707241509108m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.230406948664816m,

0.313008536981248m,

0.190102368827801m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.372947429075126m,

0.40573831478424m,

0.504237307270296m,

0.948963626936575m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.43765635883502m,

0.68753254444141m,

0.999723162828106m,

0.656611098774729m,

},
},
            new DecimalnumericArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.90995376952413m,

0.148451932704532m,

0.343392629359842m,

0.880858694555443m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.120663682946437m,

0.717196419094534m,

0.246659657946689m,

0.420859031277927m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.612709294395409m,

0.45212321057414m,

0.785272322279604m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.76564560437378m,

0.761584805489967m,

0.435462540963189m,

0.186277331878544m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.616963316212719m,

0.535846404896917m,

0.687395248957057m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.646239474721304m,

0.108755016116134m,

0.972804448811206m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.601739920874518m,

0.108694946647341m,

0.443398671881605m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0292913022997563m,

0.591759187302626m,

0.175824536466656m,

},
},
            new DecimalnumericArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.870823467922396m,

0.132661588592065m,

0.755486064770255m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.96527960749931m,

0.559483891845588m,

0.549754239873652m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.595913126433599m,

0.229552950459155m,

0.417570311509747m,

0.029096188135795m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.467083410029734m,

0.0827919502482794m,

0.840476492712078m,

0.939227463051398m,

},
    ModelInner = null,
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

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                DecimalnumericArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 1;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
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
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
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
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

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
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 24;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                        DecimalnumericArray2M.AssertModel(models[24],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 45, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 120, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 148, query1, 1, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 129, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 121, query1, 121, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 134, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 33, query1, 143, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 106, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 10, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[2], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[32],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 122, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[3], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[4], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[5], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[6], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[7], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[8], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[26],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[27],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[28],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[29],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[30],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[31],_testData[34], false);
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 83);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
DecimalnumericArray2M.AssertModel(models[0],_testData[19], false);DecimalnumericArray2M.AssertModel(models[1],_testData[20], false);DecimalnumericArray2M.AssertModel(models[2],_testData[21], false);DecimalnumericArray2M.AssertModel(models[3],_testData[22], false);DecimalnumericArray2M.AssertModel(models[4],_testData[23], false);DecimalnumericArray2M.AssertModel(models[5],_testData[24], false);DecimalnumericArray2M.AssertModel(models[6],_testData[25], false);DecimalnumericArray2M.AssertModel(models[7],_testData[26], false);DecimalnumericArray2M.AssertModel(models[8],_testData[27], false);DecimalnumericArray2M.AssertModel(models[9],_testData[28], false);DecimalnumericArray2M.AssertModel(models[10],_testData[29], false);DecimalnumericArray2M.AssertModel(models[11],_testData[30], false);DecimalnumericArray2M.AssertModel(models[12],_testData[31], false);DecimalnumericArray2M.AssertModel(models[13],_testData[32], false);DecimalnumericArray2M.AssertModel(models[14],_testData[33], false);DecimalnumericArray2M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(33));
DecimalnumericArray2M.AssertModel(models[0],_testData[2], false);DecimalnumericArray2M.AssertModel(models[1],_testData[3], false);DecimalnumericArray2M.AssertModel(models[2],_testData[4], false);DecimalnumericArray2M.AssertModel(models[3],_testData[5], false);DecimalnumericArray2M.AssertModel(models[4],_testData[6], false);DecimalnumericArray2M.AssertModel(models[5],_testData[7], false);DecimalnumericArray2M.AssertModel(models[6],_testData[8], false);DecimalnumericArray2M.AssertModel(models[7],_testData[9], false);DecimalnumericArray2M.AssertModel(models[8],_testData[10], false);DecimalnumericArray2M.AssertModel(models[9],_testData[11], false);DecimalnumericArray2M.AssertModel(models[10],_testData[12], false);DecimalnumericArray2M.AssertModel(models[11],_testData[13], false);DecimalnumericArray2M.AssertModel(models[12],_testData[14], false);DecimalnumericArray2M.AssertModel(models[13],_testData[15], false);DecimalnumericArray2M.AssertModel(models[14],_testData[16], false);DecimalnumericArray2M.AssertModel(models[15],_testData[17], false);DecimalnumericArray2M.AssertModel(models[16],_testData[18], false);DecimalnumericArray2M.AssertModel(models[17],_testData[19], false);DecimalnumericArray2M.AssertModel(models[18],_testData[20], false);DecimalnumericArray2M.AssertModel(models[19],_testData[21], false);DecimalnumericArray2M.AssertModel(models[20],_testData[22], false);DecimalnumericArray2M.AssertModel(models[21],_testData[23], false);DecimalnumericArray2M.AssertModel(models[22],_testData[24], false);DecimalnumericArray2M.AssertModel(models[23],_testData[25], false);DecimalnumericArray2M.AssertModel(models[24],_testData[26], false);DecimalnumericArray2M.AssertModel(models[25],_testData[27], false);DecimalnumericArray2M.AssertModel(models[26],_testData[28], false);DecimalnumericArray2M.AssertModel(models[27],_testData[29], false);DecimalnumericArray2M.AssertModel(models[28],_testData[30], false);DecimalnumericArray2M.AssertModel(models[29],_testData[31], false);DecimalnumericArray2M.AssertModel(models[30],_testData[32], false);DecimalnumericArray2M.AssertModel(models[31],_testData[33], false);DecimalnumericArray2M.AssertModel(models[32],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((IDecimalListnumericArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((IDecimalListnumericArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_decimalnumericarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IDecimalListnumericArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalnumericArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((IDecimalListnumericArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<DecimalnumericArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((IDecimalListnumericArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IDecimalListnumericArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IDecimalListnumericArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<DecimalnumericArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IDecimalListnumericArray)this).ImportModel(connection, importCollection);
                var models = ((IDecimalListnumericArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    DecimalnumericArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
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
                var models = await ((IDecimalListnumericArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
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
                var models = await ((IDecimalListnumericArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_decimalnumericarray2mi
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
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MI), typeof(DecimalnumericArray2MI)],
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                await ((IDecimalListnumericArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MI>();
                var models2 = new List<DecimalnumericArray2MI>();
                ((IDecimalListnumericArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
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
                var models = await ((IDecimalListnumericArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_decimalnumericarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA), typeof(DecimalnumericArray2MIWA)],
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                await ((IDecimalListnumericArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<DecimalnumericArray2MIWA>();
                var models2 = new List<DecimalnumericArray2MIWA>();
                ((IDecimalListnumericArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_decimalnumericarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(DecimalnumericArray2MIWA)],
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

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IDecimalListnumericArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IDecimalListnumericArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    DecimalnumericArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

