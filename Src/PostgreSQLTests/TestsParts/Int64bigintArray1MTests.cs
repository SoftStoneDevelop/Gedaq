

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
    Id = 2,
    Value = 
new System.Int64[3]
{
1140233278392505592L,
797534755548983560L,
7399001890571867506L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
12653631044760328L,
1907162657611502415L,
6453409793500374123L,
3262590658257616742L,
},
},
            new Int64bigintArray1M
{
    Id = 7,
    Value = 
new System.Int64[3]
{
544110872568401263L,
5430968689463889584L,
3696606318030956909L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 9,
    Value = 
new System.Int64[3]
{
9099873146044053459L,
8709399381796831506L,
205397701763978663L,
},
    NullableValue = 
new System.Int64[4]
{
1962443037663625659L,
8917271716234936737L,
7943797865468942613L,
4397463961824132280L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 9,
    Value = 
new System.Int64[3]
{
3094688770857252620L,
5052672860395616914L,
8752233079099934743L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 18,
    Value = 
new System.Int64[3]
{
7888196877785602935L,
816513045656999183L,
5632057782845041538L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 18,
    Value = 
new System.Int64[3]
{
1061996139388371150L,
4988303172392782420L,
4298209668774679785L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 25,
    Value = 
new System.Int64[4]
{
7382248276955651788L,
5603509911244085135L,
9205276794744905138L,
2230313901950933847L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 29,
    Value = 
new System.Int64[3]
{
5079136494577852337L,
6920082497500834598L,
2670076293409972974L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 21,
    Value = 
new System.Int64[4]
{
5261008657681857839L,
5117887100574838360L,
8307168982145290215L,
4696194084176484544L,
},
    NullableValue = 
new System.Int64[3]
{
4055402307548962648L,
4266717374200180776L,
3052274383817910664L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 32,
    Value = 
new System.Int64[4]
{
8852755378707843889L,
5297424311534084575L,
3934448962166827682L,
1668663508554237791L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
5744777082415859173L,
1006976032228493093L,
3165830424027904729L,
},
},
            new Int64bigintArray1M
{
    Id = 33,
    Value = 
new System.Int64[3]
{
6178898802081373672L,
1504646738232809035L,
7838200290831908690L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 24,
    Value = 
new System.Int64[4]
{
7405500815008295988L,
8138945270907057363L,
7049348565552764386L,
5449843200867669783L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 38,
    Value = 
new System.Int64[3]
{
8059554234673447183L,
4160645943559639827L,
964767680135580637L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 42,
    Value = 
new System.Int64[4]
{
4495378673386605723L,
7447118394762338797L,
443512259160084515L,
4748538985463691025L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 33,
    Value = 
new System.Int64[4]
{
3550285683484515442L,
2205914480148278458L,
6109169559818821649L,
2830597013891138484L,
},
    NullableValue = 
new System.Int64[3]
{
1021440106791298621L,
6307996739053569060L,
4172472615893625252L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 46,
    Value = 
new System.Int64[3]
{
3766138566848803313L,
3955430732813045655L,
5346108116303669209L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
260415950807306488L,
8137631510829289802L,
6503537573568245394L,
},
},
            new Int64bigintArray1M
{
    Id = 52,
    Value = 
new System.Int64[4]
{
3253682858820528392L,
225409683169757285L,
7487454702950753620L,
5875859445949085801L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 40,
    Value = 
new System.Int64[4]
{
7956533153361573008L,
7599827157803293404L,
334556783435903272L,
7993661084450556257L,
},
    NullableValue = 
new System.Int64[3]
{
5881662413743320603L,
1774216605752141128L,
6807418281291528485L,
},
},
    NullableValue = 
new System.Int64[3]
{
2667896330952338862L,
129734060663310835L,
6312769926219614439L,
},
},
            new Int64bigintArray1M
{
    Id = 57,
    Value = 
new System.Int64[4]
{
8684320029987723051L,
1792348805090780304L,
7739449878465694505L,
1895163361390408375L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 63,
    Value = 
new System.Int64[3]
{
6181773755683870300L,
6169425673842091233L,
8932989787876155771L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 48,
    Value = 
new System.Int64[4]
{
3720162281597268159L,
3480493390075654952L,
8228111918670694705L,
6381314339330756097L,
},
    NullableValue = 
new System.Int64[4]
{
171966070184910402L,
1480768344467708173L,
5775796462739736750L,
2092677626126787704L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 69,
    Value = 
new System.Int64[4]
{
4353272218491072775L,
1209094754301362256L,
7447955511411233035L,
2337074743523783130L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 72,
    Value = 
new System.Int64[4]
{
4784895887572705022L,
2451259585895953374L,
1788055235536668277L,
6544157592901875822L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 54,
    Value = 
new System.Int64[4]
{
7098626939660629383L,
3852343634717405035L,
7002408888248220820L,
938260375750088218L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 78,
    Value = 
new System.Int64[3]
{
6651660547587895801L,
3152151249151617234L,
6824749316277894935L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 80,
    Value = 
new System.Int64[3]
{
6174237379980783480L,
5985123324672385928L,
3408270695589541068L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 56,
    Value = 
new System.Int64[4]
{
8597374216062070574L,
7065634112671185476L,
1530642066334251917L,
8434575266960379643L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
8937562640929740986L,
5429154613391604063L,
279182807017931125L,
},
},
            new Int64bigintArray1M
{
    Id = 82,
    Value = 
new System.Int64[3]
{
8124980946613015340L,
812576060279160445L,
9097522762183621261L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1209032735251510961L,
9138462053530308157L,
3693878210604908969L,
20900724982589950L,
},
},
            new Int64bigintArray1M
{
    Id = 91,
    Value = 
new System.Int64[3]
{
8846105324920993854L,
7312415887488107333L,
2926540262424974797L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 61,
    Value = 
new System.Int64[3]
{
112377772066300301L,
6872978989266922035L,
3098517878436578608L,
},
    NullableValue = 
new System.Int64[4]
{
5803140002852215899L,
7891389022118595987L,
7926896891734769260L,
6120461264807155337L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 94,
    Value = 
new System.Int64[3]
{
7677255430146319820L,
8311975644323141684L,
6935842962972755080L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 95,
    Value = 
new System.Int64[4]
{
8286953673384929808L,
328948883260736476L,
8384420261537917545L,
8945222386906695354L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 68,
    Value = 
new System.Int64[4]
{
2780183568143593264L,
2807513059196580165L,
780265308977488352L,
8211138342693807950L,
},
    NullableValue = 
new System.Int64[3]
{
2942227210608177495L,
6933660153402871L,
4549056914758424923L,
},
},
    NullableValue = 
new System.Int64[4]
{
572565701407146217L,
3606458996331259602L,
9197527776976703043L,
7936054786215807463L,
},
},
            new Int64bigintArray1M
{
    Id = 98,
    Value = 
new System.Int64[4]
{
1187835125266557435L,
2512633250485196933L,
8741507983490406764L,
3818385974387960552L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 107,
    Value = 
new System.Int64[3]
{
7742094331035468671L,
6554287716463266920L,
5304464971758238277L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 71,
    Value = 
new System.Int64[4]
{
5107559666612562162L,
124979391591163228L,
8674731165113564338L,
7668509196415888602L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
2806105953138020065L,
2483457994078625524L,
7723447143915014438L,
},
},
            new Int64bigintArray1M
{
    Id = 112,
    Value = 
new System.Int64[4]
{
4158663356102644267L,
8088506962130500522L,
5633632202763957963L,
8723191420040084207L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 115,
    Value = 
new System.Int64[4]
{
7061269287649175220L,
1231610334858718578L,
137976311716688509L,
8569456296037832543L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 80,
    Value = 
new System.Int64[3]
{
3707919728494170821L,
2438989556510721829L,
5222064039567739545L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 119,
    Value = 
new System.Int64[4]
{
853262167930551253L,
2438831222277972956L,
1153705810939387771L,
3552976663186897346L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 121,
    Value = 
new System.Int64[4]
{
8975337809186545939L,
8748260877486693780L,
8218066126469341744L,
5875029090715733662L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 87,
    Value = 
new System.Int64[3]
{
6332260102618224832L,
2897386167210809868L,
7997946259887899987L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
4839123885781880156L,
9060024678130614480L,
2641018726578758749L,
},
},
            new Int64bigintArray1M
{
    Id = 122,
    Value = 
new System.Int64[4]
{
3267609009096332375L,
5061833270593992478L,
3784283625800204623L,
4008788905633014952L,
},
    ModelInner = null,
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 126,
    Value = 
new System.Int64[4]
{
3349927153095220552L,
3170531054088153520L,
723364971282190262L,
4409376827192477254L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 88,
    Value = 
new System.Int64[4]
{
6807623708831321278L,
231347188331480068L,
50354591820749580L,
5938864514461885816L,
},
    NullableValue = 
new System.Int64[3]
{
5912552814345256632L,
7448907403794409073L,
5748062406335619754L,
},
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 131,
    Value = 
new System.Int64[3]
{
187924844018253756L,
3216102356662216165L,
8916620035256816780L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[3]
{
4101591977213128759L,
383854201914325193L,
6194240194187076911L,
},
},
            new Int64bigintArray1M
{
    Id = 137,
    Value = 
new System.Int64[3]
{
2846102608799210057L,
5278012061002464906L,
6112998125509215437L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 92,
    Value = 
new System.Int64[4]
{
3648780804581284742L,
6491266404594290734L,
1800471686168314863L,
8292566172114140514L,
},
    NullableValue = null,
},
    NullableValue = 
new System.Int64[3]
{
3059183012825184031L,
3753171743224360401L,
2172450177132895935L,
},
},
            new Int64bigintArray1M
{
    Id = 143,
    Value = 
new System.Int64[3]
{
5958338918477993400L,
9126070972325770896L,
7257574261392480204L,
},
    ModelInner = null,
    NullableValue = 
new System.Int64[4]
{
1697771109327606079L,
5025125607038400961L,
1331464516050236584L,
2252512178385847307L,
},
},
            new Int64bigintArray1M
{
    Id = 145,
    Value = 
new System.Int64[4]
{
4826969205264183651L,
6262602774963245664L,
1484956047742257588L,
8977358785271310109L,
},
    ModelInner = new Int64bigintArray1MI
{
    Id = 95,
    Value = 
new System.Int64[4]
{
7227910994600031709L,
3816394112565221243L,
6008699047593370873L,
267168828800572402L,
},
    NullableValue = null,
},
    NullableValue = null,
},
            new Int64bigintArray1M
{
    Id = 150,
    Value = 
new System.Int64[4]
{
1116078484801233851L,
1191865824358918080L,
3034052111415161862L,
5784007189559015884L,
},
    ModelInner = null,
    NullableValue = null,
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

                    nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
new System.Int64[3]
{
5744777082415859173L,
1006976032228493093L,
3165830424027904729L,
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
260415950807306488L,
8137631510829289802L,
6503537573568245394L,
}));
                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
2667896330952338862L,
129734060663310835L,
6312769926219614439L,
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[1], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[32],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[2], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(models[12],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(models[13],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(models[14],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(models[15],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(models[16],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(models[17],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(models[18],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(models[19],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(models[20],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(models[21],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[22],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[23],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[24],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[25],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[26],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[27],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[28],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[29],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[30],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[31],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        Int64bigintArray1M.AssertModel(models[0],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        Int64bigintArray1M.AssertModel(models[0],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        Int64bigintArray1M.AssertModel(models[0],_testData[3], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[4], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[5], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[29],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[30],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        Int64bigintArray1M.AssertModel(models[0],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 63, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 95, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 18, query1, 121, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
                 ((IInt64ArraybigintArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 131, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 126, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(models[5],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(models[6],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(models[7],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[8],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[9],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[10],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatInt64bigintArray1M.AssertModel(models[0],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(models[1],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(models[2],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(models[3],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(models[4],_testData[34], false);
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
                await ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 80, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 72, query1, 38, query2))
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
                 ((IInt64ArraybigintArray)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatInt64bigintArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatInt64bigintArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatInt64bigintArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
                foreach(var batchResult in await ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatchAsync(connection, 126, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        Int64bigintArray1M.AssertModel(models[0],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        Int64bigintArray1M.AssertModel(models[0],_testData[6], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[7], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[8], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[9], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[10], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[11], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[12], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[22],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[23],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[24],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[25],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[26],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[27],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[28],_testData[34], false);
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
                foreach(var batchResult in  ((IInt64ArraybigintArray)this).DbConnectionSTSelectModelBatch(connection, 82, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        Int64bigintArray1M.AssertModel(models[0],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        Int64bigintArray1M.AssertModel(models[0],_testData[13], false);
                        Int64bigintArray1M.AssertModel(models[1],_testData[14], false);
                        Int64bigintArray1M.AssertModel(models[2],_testData[15], false);
                        Int64bigintArray1M.AssertModel(models[3],_testData[16], false);
                        Int64bigintArray1M.AssertModel(models[4],_testData[17], false);
                        Int64bigintArray1M.AssertModel(models[5],_testData[18], false);
                        Int64bigintArray1M.AssertModel(models[6],_testData[19], false);
                        Int64bigintArray1M.AssertModel(models[7],_testData[20], false);
                        Int64bigintArray1M.AssertModel(models[8],_testData[21], false);
                        Int64bigintArray1M.AssertModel(models[9],_testData[22], false);
                        Int64bigintArray1M.AssertModel(models[10],_testData[23], false);
                        Int64bigintArray1M.AssertModel(models[11],_testData[24], false);
                        Int64bigintArray1M.AssertModel(models[12],_testData[25], false);
                        Int64bigintArray1M.AssertModel(models[13],_testData[26], false);
                        Int64bigintArray1M.AssertModel(models[14],_testData[27], false);
                        Int64bigintArray1M.AssertModel(models[15],_testData[28], false);
                        Int64bigintArray1M.AssertModel(models[16],_testData[29], false);
                        Int64bigintArray1M.AssertModel(models[17],_testData[30], false);
                        Int64bigintArray1M.AssertModel(models[18],_testData[31], false);
                        Int64bigintArray1M.AssertModel(models[19],_testData[32], false);
                        Int64bigintArray1M.AssertModel(models[20],_testData[33], false);
                        Int64bigintArray1M.AssertModel(models[21],_testData[34], false);
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
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                Int64bigintArray1M.AssertModel(models[0],_testData[25], false);
                Int64bigintArray1M.AssertModel(models[1],_testData[26], false);
                Int64bigintArray1M.AssertModel(models[2],_testData[27], false);
                Int64bigintArray1M.AssertModel(models[3],_testData[28], false);
                Int64bigintArray1M.AssertModel(models[4],_testData[29], false);
                Int64bigintArray1M.AssertModel(models[5],_testData[30], false);
                Int64bigintArray1M.AssertModel(models[6],_testData[31], false);
                Int64bigintArray1M.AssertModel(models[7],_testData[32], false);
                Int64bigintArray1M.AssertModel(models[8],_testData[33], false);
                Int64bigintArray1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
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

