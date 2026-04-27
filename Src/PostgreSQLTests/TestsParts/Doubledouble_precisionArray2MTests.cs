

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region TestData

        private readonly Doubledouble_precisionArray2M[] _testData = new Doubledouble_precisionArray2M[]
        {
            new Doubledouble_precisionArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.007618928307045358d,

0.6020503294980315d,

0.08547398817156371d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9232518197896868d,

0.4759918522694465d,

0.44628741573516306d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3386463469248209d,

0.018924715765523015d,

0.06926494641312231d,

0.7437434401705827d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.15391053946792776d,

0.5626338910115657d,

0.9735870956567321d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7445726886173754d,

0.17335591011157214d,

0.6859231801089068d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8711271229757064d,

0.5412062849904755d,

0.5305955206238365d,

0.9968680403003574d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.07186043879488702d,

0.4673428296434773d,

0.61749034193035d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6315549368000991d,

0.9754211927859083d,

0.28830222796290605d,

0.6798703002846311d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4861768744065097d,

0.008617991123968327d,

0.7001670090139855d,

0.13070113289572072d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4042850068128806d,

0.14587796377213869d,

0.7553411370231947d,

0.7455523729730221d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6857376334537489d,

0.0903354571943954d,

0.7084992230023085d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7463094680003968d,

0.7570375301678859d,

0.9381830518997682d,

0.1458216667547686d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6407302865011667d,

0.957828225627944d,

0.4456014285454236d,

0.7425366016903563d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6308042756862456d,

0.19200511060866987d,

0.1752048173130557d,

0.8461066227161226d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5188466045785594d,

0.4562455400560521d,

0.18598763643822658d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7165218911447568d,

0.9378299831031903d,

0.30740063935245987d,

0.015202573901008765d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19013386212958316d,

0.5227656952337093d,

0.5941441569215132d,

0.9487034232173958d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.13256859419379396d,

0.9921428720247447d,

0.2937615823830867d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3464313555039017d,

0.3264858903340112d,

0.3148232809685533d,

0.6300040489546767d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.07305779658705513d,

0.924337439866019d,

0.5187008231451902d,

0.04546847382766572d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9011487401307199d,

0.7332967471128986d,

0.5917158533725184d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.09406753261237799d,

0.37203810556823513d,

0.028692235725259474d,

0.3576734889534485d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31215205760486686d,

0.7867864819915207d,

0.7225457216550638d,

0.19396097936477974d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.017844628146639674d,

0.8243297326932271d,

0.8917259672953743d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.14069496463451514d,

0.934638088321379d,

0.40038305221600357d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.04696178942457174d,

0.3682718635191945d,

0.21853052223172786d,

0.4891135830015354d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.04262538951631201d,

0.19683817395317027d,

0.5151708160339941d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6229444631332075d,

0.2513032266218178d,

0.9777720965793385d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9882153326783262d,

0.5026886862715803d,

0.982758379909241d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5303821550218771d,

0.8182240217177333d,

0.7325320676947873d,

0.8458024781298638d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.04223682685156638d,

0.5459157828298151d,

0.39067565729083986d,

0.7076687895444068d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.09527407342595617d,

0.05223217904622246d,

0.6696784800744249d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6262759732437386d,

0.3985520457227051d,

0.37559609833196894d,

0.6531584758968068d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9425850755056862d,

0.7407889137078818d,

0.447369439768064d,

0.9167974058031325d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.978179953325788d,

0.9124700758001689d,

0.49589616002583314d,

0.9112487024510016d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.13412735185397262d,

0.4274045925101728d,

0.5352057680541771d,

0.8231239309408612d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.016792376187859115d,

0.7046859365346183d,

0.6219501458174896d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26984028379837544d,

0.18069267974789982d,

0.6179421092609867d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6831168691280689d,

0.03726226811243749d,

0.5366963961176258d,

0.7352304919023628d,

},
    NullableValue = null,
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.30120063197545344d,

0.6417705495460165d,

0.44049069793430196d,

0.11411355142299862d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9377337395101388d,

0.7999821946915159d,

0.4264305688262846d,

0.33082623918980636d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7851352342175434d,

0.12349297831338613d,

0.9732898030444306d,

0.18338905755863766d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9653938129316763d,

0.3781750117717352d,

0.507330675390544d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7594380578454171d,

0.1678685287061049d,

0.6641842965495517d,

0.11452436132523314d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7411629087924293d,

0.35597038721859153d,

0.9272851544555004d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.47254762519487514d,

0.5093380958507836d,

0.18905375217028975d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.4059262187368716d,

0.9679844394715729d,

0.44009991470908627d,

0.5585992954535915d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4209883516016131d,

0.7259814523202137d,

0.12535356320666047d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.68336737839911d,

0.3468691845989059d,

0.8894294064399111d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6363566630734604d,

0.6146223936504633d,

0.8103564398103535d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8206042798206117d,

0.05270971817921721d,

0.5214218572476325d,

0.592269564156694d,

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5831189532085701d,

0.8081316960260692d,

0.07875368173896358d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0029659695024766286d,

0.8405825759592281d,

0.47230142720627855d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.24328887551484268d,

0.028432984879266376d,

0.10715183042953946d,

0.7926280574395319d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7266567087576304d,

0.4568098615100218d,

0.3230269128734239d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.4139655783402685d,

0.4788291162341559d,

0.7045540668322307d,

},
},
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8082924070611596d,

0.6316110978675907d,

0.26446567628996054d,

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.8093686982641243d,

0.9547787790321404d,

0.017771319710463085d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40946312150429565d,

0.2533550549817617d,

0.9929219522857725d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9486622443397792d,

0.6455538774756118d,

0.7792540832522697d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9534778301704057d,

0.8506005481962386d,

0.482195950767463d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.41559410556705223d,

0.5979182696038039d,

0.7607213064709969d,

},
},
            new Doubledouble_precisionArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.43759006398122335d,

0.958574083343523d,

0.13443444734766286d,

0.8659460459491766d,

},
    ModelInner = null,
    NullableValue = null,
},
            new Doubledouble_precisionArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.23029948816837487d,

0.5130603137556558d,

0.9596416114985397d,

0.9937975005044973d,

},
    ModelInner = new Doubledouble_precisionArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.46345010385830654d,

0.13261645443962d,

0.2994990813563916d,

0.127628368282927d,

},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.23134859698232213d,

0.35392157823987236d,

0.23592732804714356d,

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.35246409018198144d,

0.29726578292709527d,

0.20550395910147812d,

0.816176253647916d,

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640))]
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IDoubleListdouble_precisionArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 92;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[24],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M), typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                await((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 14, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatDoubledouble_precisionArray2M>();
                var models2 = new List<FlatDoubledouble_precisionArray2M>();
                ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 51, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var firstItems2 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 67, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatDoubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[4], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[5], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[6], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[7], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[8], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[9], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[10], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[11], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[12], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[13], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[16],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[17],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[18],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[19],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[20],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[21],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[22],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[23],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[24],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                await ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 79, query1, 144, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatDoubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 73, query1, 141, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatDoubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
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
FROM public.doubledouble_precisionarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems1 = new List<FlatDoubledouble_precisionArray2M>();
                var secondItems2 = new List<FlatDoubledouble_precisionArray2M>();
                 ((IDoubleListdouble_precisionArray)this).DbConnectionDynQuerySelectModelBatch(connection, 83, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatDoubledouble_precisionArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)),
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
                var models = await((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[5], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[6], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[7], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[8], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[9], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[10], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[11], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[12], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[13], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[14], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[15], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[16], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[13],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[14],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[15],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[16],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[17],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[18],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[19],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[20],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[21],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[22],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[23],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
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
                var models = ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    Doubledouble_precisionArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IDoubleListdouble_precisionArray)this).DbConnectionSTSelectModelBatch(connection, 141, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        Doubledouble_precisionArray2M.AssertModel(models[0],_testData[17], false);
                        Doubledouble_precisionArray2M.AssertModel(models[1],_testData[18], false);
                        Doubledouble_precisionArray2M.AssertModel(models[2],_testData[19], false);
                        Doubledouble_precisionArray2M.AssertModel(models[3],_testData[20], false);
                        Doubledouble_precisionArray2M.AssertModel(models[4],_testData[21], false);
                        Doubledouble_precisionArray2M.AssertModel(models[5],_testData[22], false);
                        Doubledouble_precisionArray2M.AssertModel(models[6],_testData[23], false);
                        Doubledouble_precisionArray2M.AssertModel(models[7],_testData[24], false);
                        Doubledouble_precisionArray2M.AssertModel(models[8],_testData[25], false);
                        Doubledouble_precisionArray2M.AssertModel(models[9],_testData[26], false);
                        Doubledouble_precisionArray2M.AssertModel(models[10],_testData[27], false);
                        Doubledouble_precisionArray2M.AssertModel(models[11],_testData[28], false);
                        Doubledouble_precisionArray2M.AssertModel(models[12],_testData[29], false);
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[1], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[2], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[3], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[4], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[5], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[6], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[7], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[8], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[9], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[10], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[11], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[12], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[13], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[16],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[17],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[18],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[19],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[20],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[21],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[22],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[23],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[24],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[25],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[26],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[27],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 73);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
Doubledouble_precisionArray2M.AssertModel(models[0],_testData[14], false);Doubledouble_precisionArray2M.AssertModel(models[1],_testData[15], false);Doubledouble_precisionArray2M.AssertModel(models[2],_testData[16], false);Doubledouble_precisionArray2M.AssertModel(models[3],_testData[17], false);Doubledouble_precisionArray2M.AssertModel(models[4],_testData[18], false);Doubledouble_precisionArray2M.AssertModel(models[5],_testData[19], false);Doubledouble_precisionArray2M.AssertModel(models[6],_testData[20], false);Doubledouble_precisionArray2M.AssertModel(models[7],_testData[21], false);Doubledouble_precisionArray2M.AssertModel(models[8],_testData[22], false);Doubledouble_precisionArray2M.AssertModel(models[9],_testData[23], false);Doubledouble_precisionArray2M.AssertModel(models[10],_testData[24], false);Doubledouble_precisionArray2M.AssertModel(models[11],_testData[25], false);Doubledouble_precisionArray2M.AssertModel(models[12],_testData[26], false);Doubledouble_precisionArray2M.AssertModel(models[13],_testData[27], false);Doubledouble_precisionArray2M.AssertModel(models[14],_testData[28], false);Doubledouble_precisionArray2M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IDoubleListdouble_precisionArray)this).ImportModelInner(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<Doubledouble_precisionArray2M>(15);

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
                ((IDoubleListdouble_precisionArray)this).ImportModel(connection, importCollection);
                var models = ((IDoubleListdouble_precisionArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IDoubleListdouble_precisionArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IDoubleListdouble_precisionArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                Doubledouble_precisionArray2M.AssertModel(models[0],_testData[0], false);
                Doubledouble_precisionArray2M.AssertModel(models[1],_testData[1], false);
                Doubledouble_precisionArray2M.AssertModel(models[2],_testData[2], false);
                Doubledouble_precisionArray2M.AssertModel(models[3],_testData[3], false);
                Doubledouble_precisionArray2M.AssertModel(models[4],_testData[4], false);
                Doubledouble_precisionArray2M.AssertModel(models[5],_testData[5], false);
                Doubledouble_precisionArray2M.AssertModel(models[6],_testData[6], false);
                Doubledouble_precisionArray2M.AssertModel(models[7],_testData[7], false);
                Doubledouble_precisionArray2M.AssertModel(models[8],_testData[8], false);
                Doubledouble_precisionArray2M.AssertModel(models[9],_testData[9], false);
                Doubledouble_precisionArray2M.AssertModel(models[10],_testData[10], false);
                Doubledouble_precisionArray2M.AssertModel(models[11],_testData[11], false);
                Doubledouble_precisionArray2M.AssertModel(models[12],_testData[12], false);
                Doubledouble_precisionArray2M.AssertModel(models[13],_testData[13], false);
                Doubledouble_precisionArray2M.AssertModel(models[14],_testData[14], false);
                Doubledouble_precisionArray2M.AssertModel(models[15],_testData[15], false);
                Doubledouble_precisionArray2M.AssertModel(models[16],_testData[16], false);
                Doubledouble_precisionArray2M.AssertModel(models[17],_testData[17], false);
                Doubledouble_precisionArray2M.AssertModel(models[18],_testData[18], false);
                Doubledouble_precisionArray2M.AssertModel(models[19],_testData[19], false);
                Doubledouble_precisionArray2M.AssertModel(models[20],_testData[20], false);
                Doubledouble_precisionArray2M.AssertModel(models[21],_testData[21], false);
                Doubledouble_precisionArray2M.AssertModel(models[22],_testData[22], false);
                Doubledouble_precisionArray2M.AssertModel(models[23],_testData[23], false);
                Doubledouble_precisionArray2M.AssertModel(models[24],_testData[24], false);
                Doubledouble_precisionArray2M.AssertModel(models[25],_testData[25], false);
                Doubledouble_precisionArray2M.AssertModel(models[26],_testData[26], false);
                Doubledouble_precisionArray2M.AssertModel(models[27],_testData[27], false);
                Doubledouble_precisionArray2M.AssertModel(models[28],_testData[28], false);
                Doubledouble_precisionArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(Doubledouble_precisionArray2M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    Doubledouble_precisionArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(Doubledouble_precisionArray2MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640),
                (NpgsqlTypes.NpgsqlDbType)(-2147483640)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IDoubleListdouble_precisionArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IDoubleListdouble_precisionArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    Doubledouble_precisionArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

