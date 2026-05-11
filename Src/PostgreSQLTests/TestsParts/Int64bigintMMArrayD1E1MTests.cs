

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
    internal partial interface IInt64MArraybigintMMArrayD1
    {
    }
    
    internal partial class Int64MArraybigintMMArrayD1 : IInt64MArraybigintMMArrayD1
    {


#region TestData

        private readonly Int64bigintMMArrayD1E1M[] _testData = new Int64bigintMMArrayD1E1M[]
        {
            new Int64bigintMMArrayD1E1M
{
    Id = 5,
    Value = 
new System.Int64[4]
{
1972918540900997007L,
5248811016937397266L,
4234576971739408409L,
1880380626444255618L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3368149368366689151L,
9210834350479053267L,
3492733461087468669L,
100911746417564947L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 11,
    Value = 
new System.Int64[4]
{
4399024422689489658L,
3835668306021391464L,
6841381482927958745L,
986795909474239037L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Int64[4]
{
2120042806515835254L,
376047565020368792L,
7634310373927049214L,
6375548593320224962L,
},
    NullableValue = 
new System.Int64[4]
{
404989281089659171L,
682618492041675931L,
9063866010870952841L,
2794939275041406246L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Int64[4]
{
3131293944500435505L,
7210570759330488160L,
1390720887231133758L,
7063540842331710972L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 20,
    Value = 
new System.Int64[3]
{
3434368230045749602L,
3396748462999457648L,
4670632492768226207L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Int64[4]
{
2743582234484092693L,
8515544877969617830L,
1224897483397589582L,
1403458645797028730L,
},
    NullableValue = 
new System.Int64[3]
{
8643857791263383598L,
8755529869446831125L,
1201685432524977052L,
},
},
    NullableValue = 
new System.Int64[4]
{
1063681375565980084L,
2041004687191860935L,
4130105603074725358L,
3498004038738455425L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Int64[4]
{
7293642338709514743L,
7835832910727020849L,
6672140697837882798L,
1575688084762620574L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Int64[3]
{
8590636922935121046L,
7788605089846529800L,
7721154417713728747L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 13,
    Value = 
new System.Int64[4]
{
1098192013267767091L,
2380703252339029323L,
8356535262131785624L,
7569296054726011446L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
880988272258510631L,
7498866681336656218L,
6271688666131744130L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Int64[4]
{
3303362834831471689L,
5619068889449525958L,
2101597811726483616L,
5134477915221828042L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
8681480003960765312L,
3460665904327666144L,
6356320291553141527L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Int64[4]
{
2393699768752699593L,
5024059550293337813L,
2792789307193390675L,
5625364412310160766L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Int64[3]
{
451922421488088097L,
2412624033193102012L,
4817386480644215788L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Int64[3]
{
3167143724116845285L,
6864733552266733318L,
1700564786930959420L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
7702001341766022767L,
7782242760595180520L,
4605955209551880824L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Int64[4]
{
5765387961608128535L,
2565036859340903551L,
2593557862377263177L,
3656462055018845547L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Int64[4]
{
7646329049088049739L,
904800340431977449L,
8548080788987158737L,
727301212297436867L,
},
    NullableValue = 
new System.Int64[4]
{
3779771214292015739L,
580937428310923491L,
7160193506543242767L,
6800560880482196921L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 49,
    Value = 
new System.Int64[4]
{
4686110429069429997L,
1719397124536866302L,
6806781991884594695L,
4817062322253452542L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Int64[3]
{
8691678966864238089L,
3735339929609035154L,
7249747821303461424L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 28,
    Value = 
new System.Int64[3]
{
3797915054152748532L,
1094035689513234612L,
1545021743241390105L,
},
    NullableValue = 
new System.Int64[3]
{
2408111955703871873L,
8532829711233785194L,
8761625756550743871L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Int64[3]
{
2992103035584900226L,
8603051352180379509L,
4959830875889518268L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1290343284913552374L,
5312887003606710368L,
600757923309628451L,
183437549217768565L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 69,
    Value = 
new System.Int64[3]
{
6233404702622791591L,
4196606402121467285L,
7098435686899560576L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 30,
    Value = 
new System.Int64[4]
{
3335037294074367460L,
6456747420915470393L,
2052642776249827264L,
6089486545389736523L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[4]
{
6105010374137227084L,
4947817596703083198L,
8366080888830197893L,
6333570658644661505L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Int64[4]
{
1826188516479445787L,
6097484024435762679L,
8637178472913684105L,
9098122660120021252L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
124676944723068564L,
6107730520439892603L,
7637861264206153091L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 72,
    Value = 
new System.Int64[3]
{
738725102851344649L,
5276676135262082387L,
264058463434348975L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Int64[4]
{
8261227098347536025L,
7696543496124395896L,
5639175370967868690L,
4683903611244234506L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4707905023060413101L,
8073957863219542083L,
6265969008853217192L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Int64[4]
{
1831362031733716685L,
6949037403267303009L,
9214070036031038186L,
8299479490324170843L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Int64[4]
{
5985058616704858488L,
1036972733186279855L,
4398415057720206755L,
605618967948390870L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 44,
    Value = 
new System.Int64[4]
{
3628190148758006253L,
5766094415969424243L,
2785200823572892481L,
8859741155281678806L,
},
    NullableValue = 
new System.Int64[4]
{
6995457178831101660L,
3959228208608790129L,
5149294689727133529L,
4365618193577932090L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Int64[3]
{
2048904580965958909L,
6229300295091992726L,
304862079727522879L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
332202094822456577L,
9199552486424882187L,
4527773505345042064L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Int64[4]
{
3831523429900412803L,
7334781523825714706L,
8736614500868515005L,
4994237012955810646L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Int64[3]
{
4076680769081670924L,
1120097244661712850L,
7384967480217420916L,
},
    NullableValue = 
new System.Int64[4]
{
1342949964936288763L,
4944184664414491430L,
4323768419806733916L,
5154301104400396764L,
},
},
    NullableValue = 
new System.Int64[3]
{
2720091582963799086L,
5488602313923996039L,
1950944517671007362L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 94,
    Value = 
new System.Int64[3]
{
2379002633385212917L,
3210727617509025265L,
8953778233664623045L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 98,
    Value = 
new System.Int64[4]
{
6939400875432636793L,
6626903964418343604L,
763405936948255998L,
1684592333263859813L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Int64[4]
{
8890132018450288302L,
4420115113601054078L,
638176598190400950L,
8211746032510119240L,
},
    NullableValue = 
new System.Int64[4]
{
4525959004279636323L,
6560204986623880472L,
5097802112699381029L,
8078813701838481334L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Int64[3]
{
307792935396640892L,
1504153808943954782L,
917130506008739115L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Int64[4]
{
5588530155594239230L,
3784329447225842629L,
8918223721126211007L,
6179789274576069242L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Int64[4]
{
968683681224010619L,
9019146307682850503L,
5174227341008717256L,
4925167770511350025L,
},
    NullableValue = 
new System.Int64[3]
{
1303685610119759852L,
3088610911614314739L,
3301112750310924269L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Int64[4]
{
7749931090144152322L,
6893459393410616824L,
89267428906334036L,
8178511803392400857L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
2449347533951164449L,
9133795312345287857L,
8653962545487680833L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 128,
    Value = 
new System.Int64[3]
{
2112096118637536887L,
2813936958188218632L,
8325414336867758066L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Int64[3]
{
9159506578967141401L,
3380136335080162003L,
7130121407710283967L,
},
    NullableValue = 
new System.Int64[3]
{
3386605374759350554L,
4144506581701568431L,
442171854216950416L,
},
},
    NullableValue = 
new System.Int64[4]
{
9088053217988470050L,
3311017314839929068L,
1653475094734989827L,
5735050233710285397L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Int64[3]
{
3337374928511080856L,
8255993588770657657L,
196673648600561126L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
3019888377130734580L,
5409603821803012656L,
7901394800516992504L,
6024619341802391332L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Int64[3]
{
8951683475295329181L,
7993235026147071893L,
6527587954991157358L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Int64[4]
{
4411067558643585139L,
6577741718580070736L,
7928007898608478112L,
1785772087424336616L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Int64[4]
{
996765997906980978L,
385754485363574474L,
1888231619150024321L,
2158065487707719064L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1013971026193279521L,
4727743074644829753L,
4201840868129280825L,
1735477001021137028L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Int64[3]
{
6739912071035523976L,
6812298566086653133L,
3608290187523725874L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Int64[4]
{
1328951906835902027L,
400852965127523095L,
923148203053989634L,
4692709383272997213L,
},
    NullableValue = 
new System.Int64[3]
{
674429846716139521L,
1353431427636169331L,
39461114212970168L,
},
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 161,
    Value = 
new System.Int64[3]
{
9007007867877638077L,
7126605474559866035L,
8479168567750874683L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 165,
    Value = 
new System.Int64[4]
{
571892158665738543L,
8698972000233752814L,
296952422280812717L,
8137369726237364497L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Int64[4]
{
1960210323496671059L,
8300077419956680815L,
5127685601945740329L,
188901235605269947L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Int64[4]
{
6047705335155129928L,
5229207218267325284L,
3634081406152605785L,
6808414854688888938L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintMMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Int64[4]
{
1549724206653851362L,
6076983050281785428L,
729788268886491764L,
1282395960975114328L,
},
    ModelInner = new Int64bigintMMArrayD1E1MI
{
    Id = 93,
    Value = 
new System.Int64[4]
{
7090399492765135678L,
6848566275645624825L,
4128598235136956358L,
8051892079146067488L,
},
    NullableValue = 
new System.Int64[3]
{
1778771551185197860L,
8678175411941802042L,
5502275827892006399L,
},
},
    NullableValue = 
new System.Int64[3]
{
1569230312829563747L,
6573519582384533042L,
2211049570772553103L,
},
},
            new Int64bigintMMArrayD1E1M
{
    Id = 182,
    Value = 
new System.Int64[4]
{
1345580202449405194L,
8230963255806930816L,
8296651518211572652L,
1054527708080591040L,
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
INSERT INTO public.int64bigintmmarrayd1e1mi(
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
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IInt64MArraybigintMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)), 
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
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IInt64MArraybigintMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IInt64MArraybigintMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
880988272258510631L,
7498866681336656218L,
6271688666131744130L,
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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
8681480003960765312L,
3460665904327666144L,
6356320291553141527L,
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

                    nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    int64bigintmmarrayd1e1mi_id
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
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                methodParametrName: "int64bigintmmarrayd1e1mi_id", 
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
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
7702001341766022767L,
7782242760595180520L,
4605955209551880824L,
}));
                nullable =  ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IInt64MArraybigintMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IInt64MArraybigintMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintMMArrayD1E1M> models = null;

                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IInt64MArraybigintMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 5;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 161;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 11;
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 171;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M), typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 153, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var models2 = new List<FlatInt64bigintMMArrayD1E1M>();
                ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 42, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var firstItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 32, query1, 147, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatInt64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 71, query1, 171, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                await ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 147, query1, 23, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatInt64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
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
FROM public.int64bigintmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems1 = new List<FlatInt64bigintMMArrayD1E1M>();
                var secondItems2 = new List<FlatInt64bigintMMArrayD1E1M>();
                 ((IInt64MArraybigintMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 79, query1, 49, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.int64bigintmmarrayd1e1m m
LEFT JOIN public.int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 143))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    Int64bigintMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IInt64MArraybigintMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 20, 171))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64MArraybigintMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64MArraybigintMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 114);
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                Int64bigintMMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                Int64bigintMMArrayD1E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MI),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_int64bigintmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new Int64bigintMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintMMArrayD1E1M),
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
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
FROM public.binary_int64bigintmmarrayd1e1m m
LEFT JOIN public.binary_int64bigintmmarrayd1e1mi mi ON mi.id = m.int64bigintmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IInt64MArraybigintMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IInt64MArraybigintMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<Int64bigintMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IInt64MArraybigintMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IInt64MArraybigintMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models =  ((IInt64MArraybigintMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Int64bigintMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_int64bigintmmarrayd1e1mi
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
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI), typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                await ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MI>();
                var models2 = new List<Int64bigintMMArrayD1E1MI>();
                ((IInt64MArraybigintMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1)),
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_int64bigintmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA), typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                await ((IInt64MArraybigintMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<Int64bigintMMArrayD1E1MIWA>();
                var models2 = new List<Int64bigintMMArrayD1E1MIWA>();
                ((IInt64MArraybigintMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Int64bigintMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64MArraybigintMMArrayD1))]
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
                var models = await ((IInt64MArraybigintMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IInt64MArraybigintMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Int64bigintMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

