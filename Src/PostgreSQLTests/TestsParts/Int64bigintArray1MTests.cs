

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region TestData

        private readonly Int64bigintArray1M[] _testData = new Int64bigintArray1M[]
        {
            new Int64bigintArray1M
{
    Id = 6,
    Value = 
new System.Int64[4]
{
6199809321631138111L,
4214689157404373951L,
3130271636036527076L,
6725523360435285314L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5963869871045942953L,
2740896767535505759L,
2155742277075783454L,
4393784649080079685L,
},
},
            new Int64bigintArray1M
{
    Id = 7,
    Value = 
new System.Int64[4]
{
5077820613671692428L,
7023330250889487943L,
1869617643011719037L,
8088958395612176596L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 1,
    Value = 
new System.Int64[3]
{
5704206967889357105L,
2390292295255859L,
2090877696799622536L,
},
    NullableValue = 
new System.Int64[3]
{
6172130551811435262L,
8278406809633903096L,
1422641136158794791L,
},
},
    NullableValue = 
new System.Int64[3]
{
3860809297921210876L,
7523789843960353261L,
7849229479594602073L,
},
},
            new Int64bigintArray1M
{
    Id = 14,
    Value = 
new System.Int64[3]
{
7849515212108220129L,
4896856388819961657L,
1412033757861833517L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
9161252903932470373L,
218455955506920953L,
7593985125760452112L,
},
},
            new Int64bigintArray1M
{
    Id = 16,
    Value = 
new System.Int64[4]
{
7002920749797783482L,
1346818281303292967L,
7442952866424264163L,
1232619357266078088L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 8,
    Value = 
new System.Int64[4]
{
363033475521811544L,
5619877766365256283L,
3726612884950172694L,
6691020288513846770L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 21,
    Value = 
new System.Int64[4]
{
2350616193475549901L,
622032210792581911L,
6802154323804374253L,
8923137629681459723L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1508421201386938485L,
5014030195680667366L,
306513736077271518L,
},
},
            new Int64bigintArray1M
{
    Id = 29,
    Value = 
new System.Int64[4]
{
1846586294083451980L,
4512521187463352754L,
1225214312894878653L,
3293844530163385487L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 12,
    Value = 
new System.Int64[4]
{
9058640255562480288L,
4693931419330546457L,
6728150274810921776L,
7625605508419465740L,
},
    NullableValue = 
new System.Int64[3]
{
914805037986515298L,
7918610091828935268L,
1003927091632301014L,
},
},
    NullableValue = 
new System.Int64[4]
{
8818125521169964656L,
3364621849571334005L,
3740972888244511465L,
601318471045103682L,
},
},
            new Int64bigintArray1M
{
    Id = 34,
    Value = 
new System.Int64[3]
{
2385013191120022106L,
6180457545661298453L,
3852190854960517808L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
5692367296182474472L,
6926031893278235985L,
4431822386401232958L,
2935644402127985394L,
},
},
            new Int64bigintArray1M
{
    Id = 35,
    Value = 
new System.Int64[3]
{
2997492044472266418L,
6483698139736647603L,
7746442575409060397L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 15,
    Value = 
new System.Int64[3]
{
2854745881872500055L,
8775047444072704064L,
232333835064921062L,
},
    NullableValue = 
new System.Int64[4]
{
820049918777495060L,
2726773545846156316L,
6657783425332326672L,
8174536801714957458L,
},
},
    NullableValue = 
new System.Int64[3]
{
4059912455038175125L,
5374481588023852990L,
1377431697358895337L,
},
},
            new Int64bigintArray1M
{
    Id = 36,
    Value = 
new System.Int64[4]
{
4085424581692832530L,
7080468188553457500L,
2792662862321443989L,
4055774329510384439L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
3527463985387139627L,
1612385956235574231L,
4889070719118863650L,
},
},
            new Int64bigintArray1M
{
    Id = 43,
    Value = 
new System.Int64[3]
{
1115858067676974612L,
1920449967483005853L,
3915520517180839411L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 22,
    Value = 
new System.Int64[3]
{
3882596862437475021L,
2916181235650747614L,
697356028104247339L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 50,
    Value = 
new System.Int64[4]
{
5599586581170293863L,
5599708468886794521L,
8724697784748564342L,
2240023279507374330L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 53,
    Value = 
new System.Int64[4]
{
3413376379343522978L,
7853129284028664799L,
7221493388774642054L,
4893394104597033562L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 26,
    Value = 
new System.Int64[3]
{
666140771933966763L,
8367471369629930671L,
5678538957404373274L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
3508249898035657364L,
1055282249043416507L,
4084525253600123041L,
6405362411500530332L,
},
},
            new Int64bigintArray1M
{
    Id = 55,
    Value = 
new System.Int64[4]
{
5841764815638188396L,
5913495886135248927L,
7177994782454772069L,
5118372175843381514L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8607697935099341449L,
6381142934200726046L,
1203004572707954731L,
},
},
            new Int64bigintArray1M
{
    Id = 62,
    Value = 
new System.Int64[3]
{
2391045895515517528L,
7744882831651913542L,
5336532160177593846L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 35,
    Value = 
new System.Int64[3]
{
6788139688245781547L,
4697643552007030991L,
6793449069115248216L,
},
    NullableValue = 
new System.Int64[3]
{
1269155153212884423L,
7955755023544486452L,
5360026200109198651L,
},
},
    NullableValue = 
new System.Int64[4]
{
615096629145127984L,
6192028523249523842L,
3938566834045905323L,
550558280041615600L,
},
},
            new Int64bigintArray1M
{
    Id = 66,
    Value = 
new System.Int64[3]
{
8693756091425037595L,
8612750171531344520L,
2221867145824204257L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4104094378291607695L,
4250367262434607585L,
5774243927315437711L,
},
},
            new Int64bigintArray1M
{
    Id = 70,
    Value = 
new System.Int64[3]
{
5956164126538522286L,
7694899315230813335L,
3713323751031630109L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 37,
    Value = 
new System.Int64[4]
{
4225993858408078120L,
2032175823308883075L,
9011277015905774521L,
4899943435061106309L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 77,
    Value = 
new System.Int64[4]
{
5754723457877247330L,
2061484523927193357L,
929040781859595372L,
1629288935346288062L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1151728728833103910L,
9123795685603572320L,
7664480232897829570L,
2969986968921338901L,
},
},
            new Int64bigintArray1M
{
    Id = 86,
    Value = 
new System.Int64[3]
{
2817126254857792012L,
7301319062479871264L,
8973449890861842500L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 45,
    Value = 
new System.Int64[3]
{
3797538646115031855L,
1602534304343628229L,
6005386536207082671L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 90,
    Value = 
new System.Int64[4]
{
8552697890585533878L,
5155481384821372654L,
908479487343583542L,
2452038982539387026L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8259079562533439675L,
7429798494891996636L,
1198333100792983201L,
},
},
            new Int64bigintArray1M
{
    Id = 96,
    Value = 
new System.Int64[3]
{
7973247192320618018L,
1105538235580896466L,
1730164956449823158L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 52,
    Value = 
new System.Int64[4]
{
6801761841281306644L,
3696373082146791276L,
8418946324859075622L,
6695206021588906770L,
},
    NullableValue = 
new System.Int64[3]
{
8920615307577329354L,
2350040417957743593L,
1801750947847523423L,
},
},
    NullableValue = 
new System.Int64[3]
{
7901774682143178265L,
4314129108375401786L,
6085156673530681649L,
},
},
            new Int64bigintArray1M
{
    Id = 105,
    Value = 
new System.Int64[3]
{
7364400861335209676L,
2688276027330948407L,
3758468149193189234L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 113,
    Value = 
new System.Int64[4]
{
9216605509743221777L,
4518245708859869862L,
4835746605222351089L,
5658088275928920992L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 59,
    Value = 
new System.Int64[3]
{
986354043471006220L,
6804721000042405172L,
4945563284352717099L,
},
    NullableValue = 
new System.Int64[4]
{
3057356299626070708L,
3296022146101527997L,
4721130845998867766L,
181700498015523567L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 119,
    Value = 
new System.Int64[4]
{
2712537247162281641L,
5451937277441874551L,
3385739056198427935L,
4223066580782275997L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 127,
    Value = 
new System.Int64[3]
{
2241416190740877610L,
6017257946473285029L,
1854812807901345538L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 63,
    Value = 
new System.Int64[3]
{
6784810386488742370L,
8773972687983361879L,
3694990534391770166L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
496657218128227307L,
647885956870009338L,
602664640304867236L,
5877632032906545513L,
},
},
            new Int64bigintArray1M
{
    Id = 134,
    Value = 
new System.Int64[4]
{
1715576108567343434L,
8439922803826324006L,
9024881160559293236L,
6556872230751673066L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 140,
    Value = 
new System.Int64[3]
{
1833736508820951516L,
3653247573631683407L,
526485718399689460L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 67,
    Value = 
new System.Int64[4]
{
141400323899735762L,
4452776990354789102L,
2622530178578215331L,
8958808351227188662L,
},
    NullableValue = 
new System.Int64[3]
{
1490171940898509729L,
1115615944315915316L,
6983444909283759499L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 147,
    Value = 
new System.Int64[3]
{
3758639075244100100L,
8896861500022927079L,
2102478346651802383L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 156,
    Value = 
new System.Int64[3]
{
2301724489128372641L,
2786969756925236251L,
625256880984918723L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 72,
    Value = 
new System.Int64[3]
{
3057912961102962008L,
2433162233119537419L,
8306952228086485421L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 165,
    Value = 
new System.Int64[4]
{
8818485504207146046L,
6300082769064987355L,
3518787315036217302L,
6535456921714657189L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
4171241036696519462L,
6997542635169741421L,
728056112904960404L,
5267041150766885584L,
},
},
            new Int64bigintArray1M
{
    Id = 167,
    Value = 
new System.Int64[3]
{
3341318026599657931L,
894777529083107830L,
4190185296018570515L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 81,
    Value = 
new System.Int64[4]
{
491283314799006865L,
1815386332098454286L,
988176448087266687L,
6444659192409331052L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6430569051103280309L,
6478360657369208698L,
1271886553551213448L,
5469089244017421377L,
},
},
            new Int64bigintArray1M
{
    Id = 176,
    Value = 
new System.Int64[3]
{
4477609112280297880L,
3858544579411395637L,
8650739579274082537L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
1994658435201948432L,
8272087687910597367L,
6253711042169239938L,
},
},
            new Int64bigintArray1M
{
    Id = 178,
    Value = 
new System.Int64[3]
{
1079973240305070530L,
7398646165863002206L,
7845673915501164369L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 89,
    Value = 
new System.Int64[4]
{
7289168834285173505L,
5084117243809730115L,
1783946555336752662L,
7965332673137105662L,
},
    NullableValue = 
new System.Int64[4]
{
2649874094191027928L,
6796440681991562649L,
7276965295191397166L,
7934136861562382465L,
},
},
    NullableValue = 
new System.Int64[3]
{
1076648881599888382L,
5322746599772761109L,
6222282125429781810L,
},
},
            new Int64bigintArray1M
{
    Id = 180,
    Value = 
new System.Int64[3]
{
6930222012799725594L,
5820247464945663749L,
320802914449950246L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 185,
    Value = 
new System.Int64[3]
{
8508980127078555251L,
5701491266821840445L,
8713793005862679831L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 91,
    Value = 
new System.Int64[3]
{
7603007627083582760L,
634229908122475982L,
2994566105137684084L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 187,
    Value = 
new System.Int64[3]
{
1772324016401912994L,
5161092777646057147L,
8281748243579879468L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4839812828793893676L,
7421708214930267494L,
3321908583294774010L,
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647))]
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
1508421201386938485L,
5014030195680667366L,
306513736077271518L,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
8818125521169964656L,
3364621849571334005L,
3740972888244511465L,
601318471045103682L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
5692367296182474472L,
6926031893278235985L,
4431822386401232958L,
2935644402127985394L,
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Int64[]>();
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
                    ((NpgsqlParameter<System.Int64[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483647);
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

                    nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
4059912455038175125L,
5374481588023852990L,
1377431697358895337L,
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                System.Int64[] nullable = null;
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
3527463985387139627L,
1612385956235574231L,
4889070719118863650L,
}));
                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[4]
{
3508249898035657364L,
1055282249043416507L,
4084525253600123041L,
6405362411500530332L,
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64ArraybigintArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64ArraybigintArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 180;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 178;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        Int64bigintArray1M.AssertModel(models[0],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintArray1M.AssertModel(models[0],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        Int64bigintArray1M.AssertModel(models[0],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        Int64bigintArray1M.AssertModel(models[0],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M), typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                await((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 14, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 119, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintArray1M>();
                var models2 = new List<FlatInt64bigintArray1M>();
                ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 66, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var firstItems2 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 167, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 96, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 43, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 62, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[34], false);
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
FROM public.int64bigintarray1m m
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
FROM public.int64bigintarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems1 = new List<FlatInt64bigintArray1M>();
                var secondItems2 = new List<FlatInt64bigintArray1M>();
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 50, query1, 66, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
            asPartInterface: typeof(IInt64ArraybigintArray)),
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
                var models = await((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 50, 50))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintArray1M.AssertModel(models[0],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        Int64bigintArray1M.AssertModel(models[0],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 6, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        Int64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[30],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[31],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[32],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Int64bigintArray1M.AssertModel(models[0],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                Int64bigintArray1M.AssertModel(models[0],_testData[8], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[9], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[10], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[11], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[12], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[13], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[14], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[15], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[16], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[17], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[18], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[19], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[20], false);
                Int64bigintArray1M.AssertModel(models[13],_testData[21], false);
                Int64bigintArray1M.AssertModel(models[14],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[15],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[16],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[17],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[18],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[19],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[20],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[21],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[22],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[23],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[24],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[25],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[26],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 113);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                Int64bigintArray1M.AssertModel(models[0],_testData[22], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[23], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[24], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[10],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[11],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[12],_testData[34], false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64ArraybigintArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64ArraybigintArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64ArraybigintArray)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64ArraybigintArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64ArraybigintArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64ArraybigintArray)this).ImportModel(connection, importCollection);
                var models = ((IInt64ArraybigintArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models =  ((IInt64ArraybigintArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64ArraybigintArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintarray1mi
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
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI), typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                await ((IInt64ArraybigintArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MI>();
                var models2 = new List<Int64bigintArray1MI>();
                ((IInt64ArraybigintArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
                var models = await ((IInt64ArraybigintArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA), typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                await ((IInt64ArraybigintArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintArray1MIWA>();
                var models2 = new List<Int64bigintArray1MIWA>();
                ((IInt64ArraybigintArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray))]
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
                var models = await ((IInt64ArraybigintArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64ArraybigintArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

