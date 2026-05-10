

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.280152190395593m,

0.122782827094804m,

0.514092384789068m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0294784929091491m,

0.593989258321757m,

0.56632225569802m,

},
},
            new DecimalnumericArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.976147761749835m,

0.855106472860876m,

0.626356832001574m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.576617896263728m,

0.148514830504841m,

0.208861918019086m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.98849759520193m,

0.559836172975658m,

0.416938541582754m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.941754965742491m,

0.873393792210142m,

0.0819421905273062m,

0.656213615202047m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.742936065676864m,

0.414218345213281m,

0.543627071631142m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.613395422536632m,

0.240425167532689m,

0.0413874142456453m,

0.693970371513844m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.59345681718723m,

0.718910037458846m,

0.347091128612711m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.615692638083898m,

0.456149694615908m,

0.444378688643174m,

0.746210055934106m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.606274119350421m,

0.174588679521302m,

0.885728834094305m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.669260498354082m,

0.113128375245287m,

0.378523630891666m,

0.558775263190532m,

},
},
            new DecimalnumericArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.096894942638822m,

0.697564524108079m,

0.436618366583576m,

0.393143727187954m,

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
0.301220650090014m,

0.528746311167962m,

0.964510193927496m,

0.620459313398044m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.216820706520435m,

0.605638739950037m,

0.367145811317415m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.261721078710721m,

0.0376371367639616m,

0.169488033350759m,

0.0618622825197149m,

},
},
            new DecimalnumericArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.42570217959389m,

0.554345308764155m,

0.962029413297764m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.433925924295573m,

0.67817614656738m,

0.2352232825701m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.775405851740096m,

0.341767561733253m,

0.275311466075693m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.784243535443665m,

0.451633968353199m,

0.113585064502115m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.845384007568688m,

0.352562202642229m,

0.597884909130055m,

},
},
            new DecimalnumericArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.658708932331973m,

0.232813740297931m,

0.613102046572665m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.271856064398368m,

0.11368716165417m,

0.0443694360576582m,

0.76817522507884m,

},
},
            new DecimalnumericArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.969888998645701m,

0.916634792013825m,

0.697133859943838m,

0.178809641059865m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0355634232072064m,

0.398528956245395m,

0.0583276126816746m,

0.963749058380695m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.563417665620632m,

0.760018163322511m,

0.709686440746986m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.713085717955016m,

0.193134383136803m,

0.375019420007343m,

0.088053871168902m,

},
},
            new DecimalnumericArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.085792753374051m,

0.529529288343987m,

0.244400885038572m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.658801880369378m,

0.470595082709269m,

0.487386495238684m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.145109467637466m,

0.0429827397686853m,

0.805251642649262m,

0.332093420449931m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.458354986301761m,

0.453825000807434m,

0.901906799869831m,

0.089412741042595m,

},
},
            new DecimalnumericArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.687633839986041m,

0.819113121260206m,

0.782363081855549m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.60368855592633m,

0.552439978278117m,

0.330928890960877m,

},
},
            new DecimalnumericArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.999721719613312m,

0.428037318938615m,

0.219108476774365m,

0.819311960768148m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0163391006944233m,

0.110369330569607m,

0.66318944648205m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.184557859735905m,

0.100130745106439m,

0.133229467311235m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.911508168623822m,

0.00938539775302916m,

0.590021267486312m,

},
},
            new DecimalnumericArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.677684926687425m,

0.731615660254722m,

0.281778592696195m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.47437337168092m,

0.55515168265895m,

0.713306491940694m,

0.362302057731428m,

},
},
            new DecimalnumericArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0589453508775598m,

0.171512696673224m,

0.930868501682228m,

0.577294385229096m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.959673184962392m,

0.601573977062686m,

0.156445014262008m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.758768857280756m,

0.976298671578414m,

0.91159050794353m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.636880450057256m,

0.623585831159926m,

0.687184566730929m,

0.754877693417095m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0112973357114367m,

0.757318284552703m,

0.0531844812369185m,

0.954368664113588m,

},
},
            new DecimalnumericArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.464201041444177m,

0.326314598122423m,

0.23029164601971m,

0.799064071220009m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.265079166419435m,

0.848928241933934m,

0.457918165589801m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.552290471973554m,

0.0759223967981647m,

0.147103205561908m,

0.876037305898138m,

},
},
            new DecimalnumericArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.043461559955944m,

0.633999533098755m,

0.764972227409091m,

0.334234674427566m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.869775548774336m,

0.579261731310068m,

0.748133406432824m,

},
},
            new DecimalnumericArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.112162108727101m,

0.898401769250542m,

0.0352371892393208m,

0.856459656518587m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.189845931663644m,

0.76332357119501m,

0.555513748432747m,

0.616489605473635m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.347049784047434m,

0.0092725649169878m,

0.588720388166471m,

},
},
            new DecimalnumericArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.977398110117881m,

0.727276232936168m,

0.734180992081774m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.83044555284608m,

0.808793270022649m,

0.0962153888227148m,

},
},
            new DecimalnumericArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.950646065548381m,

0.762806360063312m,

0.000581374518703548m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.275760165016081m,

0.345704941698825m,

0.0242378377150424m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.72267868360496m,

0.885131683760544m,

0.2402865108859m,

},
},
            new DecimalnumericArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.253902419829598m,

0.92380223187521m,

0.234360813738795m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.975999411351772m,

0.116282822177313m,

0.142687444430919m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.233476852307507m,

0.847360187890804m,

0.389357914926493m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.50856095142839m,

0.628660199740491m,

0.755852223638272m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.819411594542598m,

0.36171062784366m,

0.077740173035692m,

0.0463826683994856m,

},
},
            new DecimalnumericArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.943125049773222m,

0.896616175467236m,

0.478458455310824m,

0.902981323971829m,

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
0.204900233679343m,

0.855072844404489m,

0.66535353165897m,

0.492539452060302m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.763598185103387m,

0.560921142178941m,

0.54329135241761m,

0.952980615815744m,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.798220696735547m,

0.615354289550043m,

0.587236169656916m,

0.751583190522749m,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.374318336255959m,

0.989374894004239m,

0.738261608063448m,

0.962959287883524m,

},
},
            new DecimalnumericArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.741417142538058m,

0.0682038060489031m,

0.719444131251158m,

0.385982381403906m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.974210872757763m,

0.640277839602808m,

0.19093084822945m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.372967432079666m,

0.76619578787132m,

0.947792419980168m,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.513707775779239m,

0.389574065445092m,

0.530376866265537m,

},
},
            new DecimalnumericArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.12076125460389m,

0.864830663145182m,

0.586696456099042m,

0.448967257433918m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.545742684752323m,

0.150605951742663m,

0.142624639519192m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.889481251473714m,

0.670157489535383m,

0.571002435423661m,

0.118277631738628m,

},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.029167004327434m,

0.451523768666242m,

0.380490701916542m,

0.492204442998371m,

},
},
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.855524630917679m,

0.243260992956522m,

0.76311567231601m,

0.125308258439524m,

},
    ModelInner = null,
    NullableValue = null,
},
            new DecimalnumericArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.9361365263334m,

0.212699224981706m,

0.0572595525336414m,

},
    ModelInner = new DecimalnumericArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.195905475029933m,

0.886799822049593m,

0.341844455648351m,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.998072245580724m,

0.486886074565286m,

0.909747762807955m,

0.728275384877076m,

},
},
            new DecimalnumericArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.764217214420316m,

0.648946817213108m,

0.0507614918480938m,

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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                parametr2.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[29],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[14],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[15],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[13],_testData[34], false);
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
                parametr2.Value = 163;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        FlatDecimalnumericArray2M.AssertModel(models[16],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[17],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[18],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[19],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
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
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 163, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
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
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 34, query1, 113, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatDecimalnumericArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
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
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems2[18],_testData[34], false);
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
                 ((IDecimalListnumericArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 63, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[16],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 113, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatDecimalnumericArray2M.AssertModel(models[0],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(models[1],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(models[2],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(models[3],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(models[4],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(models[5],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(models[6],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(models[7],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[8],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[9],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[10],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[11],_testData[34], false);
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
                await ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 82, query1, 98, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatDecimalnumericArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatDecimalnumericArray2M.AssertModel(models[20],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(models[21],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(models[22],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(models[23],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IDecimalListnumericArray)this).DbConnectionDynQuerySelectModelBatch(connection, 135, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatDecimalnumericArray2M.AssertModel(firstItems1[7],_testData[34], false);
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
                foreach(var batchResult in await ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatchAsync(connection, 52, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[9], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[10], false);
                        DecimalnumericArray2M.AssertModel(models[2],_testData[11], false);
                        DecimalnumericArray2M.AssertModel(models[3],_testData[12], false);
                        DecimalnumericArray2M.AssertModel(models[4],_testData[13], false);
                        DecimalnumericArray2M.AssertModel(models[5],_testData[14], false);
                        DecimalnumericArray2M.AssertModel(models[6],_testData[15], false);
                        DecimalnumericArray2M.AssertModel(models[7],_testData[16], false);
                        DecimalnumericArray2M.AssertModel(models[8],_testData[17], false);
                        DecimalnumericArray2M.AssertModel(models[9],_testData[18], false);
                        DecimalnumericArray2M.AssertModel(models[10],_testData[19], false);
                        DecimalnumericArray2M.AssertModel(models[11],_testData[20], false);
                        DecimalnumericArray2M.AssertModel(models[12],_testData[21], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[22], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[23], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[24], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[25], false);
                        DecimalnumericArray2M.AssertModel(models[17],_testData[26], false);
                        DecimalnumericArray2M.AssertModel(models[18],_testData[27], false);
                        DecimalnumericArray2M.AssertModel(models[19],_testData[28], false);
                        DecimalnumericArray2M.AssertModel(models[20],_testData[29], false);
                        DecimalnumericArray2M.AssertModel(models[21],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[22],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[23],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[24],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

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
                        DecimalnumericArray2M.AssertModel(models[12],_testData[30], false);
                        DecimalnumericArray2M.AssertModel(models[13],_testData[31], false);
                        DecimalnumericArray2M.AssertModel(models[14],_testData[32], false);
                        DecimalnumericArray2M.AssertModel(models[15],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[16],_testData[34], false);
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
                foreach(var batchResult in  ((IDecimalListnumericArray)this).DbConnectionSTSelectModelBatch(connection, 163, 135))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        DecimalnumericArray2M.AssertModel(models[0],_testData[33], false);
                        DecimalnumericArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 34);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)),
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

